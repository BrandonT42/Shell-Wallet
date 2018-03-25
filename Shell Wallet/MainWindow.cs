using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RPCWrapper;
using System.Threading;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Shell_Wallet
{
    /// <summary>
    /// Main window
    /// </summary>
    internal partial class MainWindow : Form
    {
        // Initialize window
        internal MainWindow(String[] args)
        {
            // Initialize form window
            InitializeComponent();

            // Check for arguments
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].ToLower().IndexOf("testnet") > -1)
                    Config.Testnet = true;
                else if (args[i].ToLower().IndexOf("debug") > -1)
                    Config.Debug = true;
                else if (args[i].ToLower().IndexOf("log") > -1)
                    Config.Log = true;
            }

            // Setup console output
            writer = new ConsoleWriter(Console.Out);
            Console.SetOut(writer);

            // Add load event
            Load += OnLoad;
        }

        #region Variables
        // Logs console output
        private ConsoleWriter writer;
        private Boolean ShowKeys = false;
        private Boolean RemoteServer = false;
        #endregion

        #region Event Handlers
        // Runs when application is first loaded
        private void OnLoad(object sender, EventArgs e)
        {
            // Load configuration
            Config.Load();

            // Load address book
            AddressBook.Load();
            this.AddressGrid.DataSource = AddressBook.DataSource;

            // Load nicknames
            Nicknames.Load();

            // Set internal font (because designer is stupid and doesn't show fonts on datagridviews
            this.RecentBlocks.Font = this.AddressGrid.Font;
            this.TransactionPool.Font = this.AddressGrid.Font;

            // Set a few element defaults
            this.SendFromAddress.SelectedIndex = 0;
            this.Fee.Text = Config.DefaultFee;
            ShowHideAdvancedSend(null, null);

            // Ask the user to open simplewallet's path if it's not chosen in the config file
            if (!File.Exists(Config.ServerPath))
            {
                MessageBox.Show("walletd.exe path not found! Please select server location.", "Error");
                OpenServerPath.ShowDialog();
                if (!File.Exists(OpenServerPath.FileName)) Application.Exit();
                Config.ServerPath = OpenServerPath.FileName;
                Config.Save();

                // Bring window back to the front
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }

            // Update design elements
            UpdateElements();

            // Assign event handlers
            Application.ThreadExit += OnExit;

            // Assign server variables
            Server.RefreshRate = Config.RefreshRate;
            Server.NetworkRefreshRate = Config.NetworkRefreshRate;
            Server.NetworkMonitor = Config.NetworkMonitor;

            // Testnet mode
            if (Config.Testnet)
            {
                Server.Testnet = Config.Testnet;
                this.Text = "Shell Wallet (TESTNET)";
            }

            // Connect datasources
            Network.TransactionPool.SynchronizationContext = SynchronizationContext.Current;
            this.TransactionPool.DataSource = Network.TransactionPool;
            Network.RecentBlocks.SynchronizationContext = SynchronizationContext.Current;
            this.RecentBlocks.DataSource = Network.RecentBlocks;
            Wallet.Transactions.SynchronizationContext = SynchronizationContext.Current;
            this.TransactionLog.DataSource = Wallet.Transactions;

            // Assign update timer
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Tick += OnTimerTick;
            t.Interval = Config.GUIRefreshRate;
            t.Start();
        }

        // Runs when the main thread is exited
        private void OnExit(object sender, EventArgs e)
        {
            // Exit
            Server.Stop();
            Mobile.Stop();
            Config.Save();
            AddressBook.Save();
            Nicknames.Save();
        }

        // Form closing
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask if they'd really like to exit
            if (MessageBox.Show("Would you really like to exit?", "Exit Shell Wallet",
                MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        // Triggers when the rpc server is started
        private void OnStart(object sender, EventArgs e)
        {
            Console.WriteLine("RPC server started");
        }

        // Triggers when the rpc server is stopped
        private void OnStop(object sender, EventArgs e)
        {
            Mobile.Stop();
            Console.WriteLine("RPC server stopped");
        }

        // Triggers whenever the server makes an update
        private void OnTick(object sender, EventArgs e)
        {
            //
        }

        // Triggers when the network connection is made
        private void OnNetworkStart (object sender, EventArgs e)
        {
            Console.WriteLine("Network connection made");
        }

        // Triggers when the network connection is closed
        private void OnNetworkStop(object sender, EventArgs e)
        {
            Console.WriteLine("Network connection closed");
        }

        // Triggers when the network makes an update
        private void OnNetworkTick(object sender, EventArgs e)
        {
            //
        }

        //Triggers in main timer loop
        private void OnTimerTick(object sender, EventArgs e)
        {
            // Output any errors
            String error = Server.Error;
            if (Wallet.Alive && error != "")
            {
                Server.Stop();
                MessageBox.Show("Server error:\r\n" + error, "Error");
            }

            // Update elements
            UpdateElements();
        }
        #endregion

        #region Utilities
        // Open a wallet
        internal void OpenWallet(String Path, String Password = null)
        {
            // Make sure server isn't open
            if (Wallet.Alive) return;

            // Open password prompt if password isn't provided
            if (Password == null)
            {
                using (PasswordPrompt p = new PasswordPrompt())
                    if (p.ShowDialog() == DialogResult.OK)
                    {
                        Password = p.GetResult();
                        p.Dispose();
                    }
                    else return;
            }

            // Change menu elements before running server
            this.OpenWalletMenuOption.Enabled = false;
            this.OpenDefaultMenuOption.Enabled = false;
            this.ImportWalletMenuOption.Enabled = false;
            this.CreateWalletMenuOption.Enabled = false;
            this.CloseWalletMenuOption.Enabled = true;

            Console.WriteLine("Loading '{0}'", Path);

            // Check password
            LoadingPrompt l = new LoadingPrompt(Path, Password);

            // Password correct
            if (l.ShowDialog() == DialogResult.OK)
            {
                // Start the server
                if (Config.LocalDaemon)
                {
                    if (!Wallet.Open(Config.ServerPath, Path, Password, Config.ServerPassword, Config.ServerPort,
                      "127.0.0.1", Config.NodePort))
                        MessageBox.Show("Could not open wallet:\r\n" + Server.Error, "Error");
                }
                else
                {
                    if (!Wallet.Open(Config.ServerPath, Path, Password, Config.ServerPassword, Config.ServerPort,
                    Config.NodeHost, Config.NodePort))
                        MessageBox.Show("Could not open wallet:\r\n" + Server.Error, "Error");
                }
            }

            // Password incorrect
            else MessageBox.Show("Password is incorrect!", "Error");

            // Dispose of loading prompt
            l.Dispose();
        }

        // Wallet Loaded
        private void UpdateElements()
        {
            #region Update Network
            // Network online
            if (Network.Alive && Wallet.Alive && !RemoteServer)
            {
                // Enable and disable elements
                if (this.StartNetworkMenuOption.Enabled)
                    this.StartNetworkMenuOption.Enabled = false;
                if (this.CloseNetworkMenuOption.Enabled)
                    this.CloseNetworkMenuOption.Enabled = false;
            }
            else if (Network.Alive)
            {
                // Enable and disable elements
                if (this.StartNetworkMenuOption.Enabled)
                    this.StartNetworkMenuOption.Enabled = false;
                if (!this.CloseNetworkMenuOption.Enabled)
                    this.CloseNetworkMenuOption.Enabled = true;
            }
            else
            {
                // Enable and disable elements
                if (!this.StartNetworkMenuOption.Enabled)
                    this.StartNetworkMenuOption.Enabled = true;
                if (this.CloseNetworkMenuOption.Enabled)
                    this.CloseNetworkMenuOption.Enabled = false;
            }

            if (Network.Alive && Config.NetworkMonitor)
            {
                // Only do these updates if network tab is selected
                if (this.WalletTabs.SelectedTab.Text == "Network" || this.TotalBlocks.Text == "0")
                {
                    this.TotalBlocks.Text = Network.BlockHeight.ToString("N0");
                    this.TotalSupply.Text = String.Format("{0:n}", Network.Supply);
                    this.TotalTransactions.Text = Network.TransactionCount.ToString("N0");
                    this.GlobalHashrate.Text = Network.Hashrate;
                    this.Difficulty.Text = Network.Difficulty.ToString("N0");
                    this.Reward.Text = Network.Reward.ToString("N0");
                }
            }
            else
            {
                if (this.TotalBlocks.Text != "") this.TotalBlocks.Text = "";
                if (this.TotalSupply.Text != "") this.TotalSupply.Text = "";
                if (this.TotalTransactions.Text != "") this.TotalTransactions.Text = "";
                if (this.GlobalHashrate.Text != "") this.GlobalHashrate.Text = "";
                if (this.Difficulty.Text != "") this.Difficulty.Text = "";
                if (this.Reward.Text != "") this.Reward.Text = "";
            }
            #endregion

            #region Update Wallet
            // Server online
            if (Wallet.Alive)
            {
                // Set window name
                if (this.Text == "Shell Wallet" && !Config.Testnet)
                {
                    if (!RemoteServer)
                        this.Text = "Shell Wallet - \"" + Wallet.FileName + "\"";
                    else this.Text = "Shell Wallet - \"" + Config.RemotePath + "\"";
                }
                else if (this.Text == "Shell Wallet (TESTNET)" && Config.Testnet)
                {
                    if (!RemoteServer)
                        this.Text = "Shell Wallet (TESTNET) - \"" + Wallet.FileName + "\"";
                    else this.Text = "Shell Wallet (TESTNET) - \"" + Config.RemotePath + "\"";
                }

                // Enable wallet controls
                if (!this.CopyAddress.Enabled)
                    this.CopyAddress.Enabled = true;
                if (!this.CreateNewAddress.Enabled)
                    this.CreateNewAddress.Enabled = true;
                if (!this.DeleteSelectedAddress.Enabled)
                    this.DeleteSelectedAddress.Enabled = true;
                //if (!this.WalletAddresses.Enabled)
                //    this.WalletAddresses.Enabled = true;
                if (!this.ShowKeysButton.Enabled)
                    this.ShowKeysButton.Enabled = true;
                if (!this.ChangeNickname.Enabled)
                    this.ChangeNickname.Enabled = true;

                // Update menu options
                if (this.OpenWalletMenuOption.Enabled)
                    this.OpenWalletMenuOption.Enabled = false;
                if (this.OpenDefaultMenuOption.Enabled)
                    this.OpenDefaultMenuOption.Enabled = false;
                if (this.CreateWalletMenuOption.Enabled)
                    this.CreateWalletMenuOption.Enabled = false;
                if (this.ImportWalletMenuOption.Enabled)
                    this.ImportWalletMenuOption.Enabled = false;
                if (!this.ExportPrivateKeysMenuOption.Enabled)
                    this.ExportPrivateKeysMenuOption.Enabled = true;
                if (!this.ResyncMenuOption.Enabled)
                    this.ResyncMenuOption.Enabled = true;
                if (this.ConnectRemoteRPC.Enabled)
                    this.ConnectRemoteRPC.Enabled = false;
                if (!this.CloseWalletMenuOption.Enabled)
                    this.CloseWalletMenuOption.Enabled = true;

                // Change address selection
                if (this.WalletAddresses.DataSource == null &&
                    Wallet.Addresses != null && Wallet.Addresses.Count > 0)
                {
                    for (int i = 0; i < Wallet.Addresses.Count; i++)
                    {
                        String s = Nicknames.Get(Wallet.Addresses[i]);
                        if (s != "-")
                        {
                            Wallet.Addresses[i] = s;
                        }
                    }
                    this.WalletAddresses.DataSource = Wallet.Addresses;
                    this.WalletAddresses.SelectedIndex = 0;
                }

                // Update wallet status
                this.HeightStatus.Text = "Height: " + (Wallet.BlockCount + 1) +
                    " / " + Wallet.KnownBlockCount + " | Peer Count: " +
                    Wallet.PeerCount;
                
                // Update progress bar information if block height sync is behind
                if (Wallet.BlockCount != 0 && Wallet.KnownBlockCount != 0)
                {
                    int s = Wallet.BlockCount + 1;
                    int k = Wallet.KnownBlockCount;
                    var p = (double)s / (double)k * 100;
                    if ((int)p < 100 && (int)p >= 0)
                    {
                        this.SyncPercent.Text = "Sync Progress: " + (int)p + "%";
                        this.SyncProgress.Value = (int)p;
                    }
                    else if ((int)p >= 100)
                    {
                        this.SyncPercent.Text = "Sync Progress: 100%";
                    }
                    else
                    {
                        this.SyncPercent.Text = "Sync Progress: 0%";
                        this.SyncProgress.Value = 0;
                    }
                }

                // Update wallet balances
                this.BalanceBox.Text = Wallet.Balance;
                this.LockedBalanceBox.Text = Wallet.LockedBalance;
                this.SelectedBalanceBox.Text = Wallet.SelectedBalance;
                this.SelectedLockedBalanceBox.Text = Wallet.SelectedLockedBalance;

                // Update key display
                if (ShowKeys)
                {
                    PublicSpendKey.Text = Wallet.PublicSpendKey;
                    PrivateSpendKey.Text = Wallet.PrivateSpendKey;
                }
                else if (PrivateSpendKey.Text != "Hidden")
                {
                    PublicSpendKey.Text = "Hidden";
                    PrivateSpendKey.Text = "Hidden";
                }

                // Update send tab
                if (!RemoteServer && !SendTransaction.Enabled)
                {
                    SendTransaction.Enabled = true;
                }
            }

            // Server offline
            else
            {
                // Set window name
                if (this.Text != "Shell Wallet" && !Config.Testnet)
                    this.Text = "Shell Wallet";
                else if (this.Text != "Shell Wallet (TESTNET)" && Config.Testnet)
                    this.Text = "Shell Wallet (TESTNET)";

                // Disable wallet controls
                if (this.CopyAddress.Enabled)
                    this.CopyAddress.Enabled = false;
                if (this.CreateNewAddress.Enabled)
                    this.CreateNewAddress.Enabled = false;
                if (this.DeleteSelectedAddress.Enabled)
                    this.DeleteSelectedAddress.Enabled = false;
                if (this.ShowKeysButton.Enabled)
                    this.ShowKeysButton.Enabled = false;
                if (this.ChangeNickname.Enabled)
                    this.ChangeNickname.Enabled = false;
                if (this.WalletAddresses.Enabled)
                {
                    this.WalletAddresses.DataSource = null;
                    this.WalletAddresses.SelectedText = "";
                    //this.WalletAddresses.Enabled = false;
                }
                this.SyncPercent.Text = "Waiting to sync";
                this.SyncProgress.Value = 0;

                // Update menu options
                if (!this.OpenWalletMenuOption.Enabled)
                    this.OpenWalletMenuOption.Enabled = true;
                if (!this.OpenDefaultMenuOption.Enabled &&
                    Config.DefaultWalletPath != "")
                    this.OpenDefaultMenuOption.Enabled = true;
                else if (this.OpenDefaultMenuOption.Enabled &&
                    Config.DefaultWalletPath == "")
                    this.OpenDefaultMenuOption.Enabled = false;
                if (!this.CreateWalletMenuOption.Enabled)
                    this.CreateWalletMenuOption.Enabled = true;
                if (!this.ImportWalletMenuOption.Enabled)
                    this.ImportWalletMenuOption.Enabled = true;
                if (this.ExportPrivateKeysMenuOption.Enabled)
                    this.ExportPrivateKeysMenuOption.Enabled = false;
                if (this.ResyncMenuOption.Enabled)
                    this.ResyncMenuOption.Enabled = false;
                if (!this.ConnectRemoteRPC.Enabled)
                    this.ConnectRemoteRPC.Enabled = true;
                if (this.CloseWalletMenuOption.Enabled)
                    this.CloseWalletMenuOption.Enabled = false;

                // Reset wallet data
                this.BalanceBox.Text = "-";
                this.LockedBalanceBox.Text = "-";
                this.SelectedBalanceBox.Text = "-";
                this.SelectedLockedBalanceBox.Text = "-";
                this.PublicSpendKey.Text = "-";
                this.PrivateSpendKey.Text = "-";
                this.Nickname.Text = "-";
                this.HeightStatus.Text = "";

                // Update send tab
                if (SendTransaction.Enabled)
                    SendTransaction.Enabled = false;
            }
            #endregion

            #region Update Transactions
            if (this.TransactionLog.DataSource != Wallet.Transactions)
            {
                this.TransactionLog.DataSource = Wallet.Transactions;
            }
            #endregion

            #region Update Mobile
            // Mobile Disabled
            if (Config.EnableMobile && !this.mobileToolStripMenuItem.Enabled)
                this.mobileToolStripMenuItem.Enabled = true;

            // Mobile Enabled
            else if (!Config.EnableMobile && this.mobileToolStripMenuItem.Enabled)
                this.mobileToolStripMenuItem.Enabled = false;

            // Server online and mobile connected
            if (Mobile.Alive && Wallet.Alive)
            {
                // Update menu
                if (this.startMobileServerToolStripMenuItem.Enabled)
                    this.startMobileServerToolStripMenuItem.Enabled = false;
                if (!this.stopMobileServerToolStripMenuItem.Enabled)
                    this.stopMobileServerToolStripMenuItem.Enabled = true;
            }

            // Server online and mobile not connected
            else if (!Mobile.Alive && Wallet.Alive)
            {
                // Update menu
                if (!this.startMobileServerToolStripMenuItem.Enabled)
                    this.startMobileServerToolStripMenuItem.Enabled = true;
                if (this.stopMobileServerToolStripMenuItem.Enabled)
                    this.stopMobileServerToolStripMenuItem.Enabled = false;
            }

            // Server offline
            else
            {
                // Update menu
                if (this.startMobileServerToolStripMenuItem.Enabled)
                    this.startMobileServerToolStripMenuItem.Enabled = false;
                if (this.stopMobileServerToolStripMenuItem.Enabled)
                    this.stopMobileServerToolStripMenuItem.Enabled = false;
            }
            #endregion
    
            #region Other Updates
            if (Wallet.Alive && Network.Alive)
            {
                // Update server status
                if (this.ServerStatus.ForeColor == Color.Red ||
                    this.ServerStatus.ForeColor == Color.Blue)
                {
                    this.ServerStatus.ForeColor = Color.Green;
                }
                if (this.ServerStatus.Text != "Server / Daemon Connected")
                    this.ServerStatus.Text = "Server / Daemon Connected";
            }
            else if (Wallet.Alive && !Network.Alive)
            {
                // Update server status
                if (this.ServerStatus.ForeColor == Color.Red ||
                    this.ServerStatus.ForeColor == Color.Blue)
                {
                    this.ServerStatus.ForeColor = Color.Green;
                }
                if (this.ServerStatus.Text != "Server Connected")
                    this.ServerStatus.Text = "Server Connected";
            }
            else if (Network.Alive)
            {
                // Update server status
                if (this.ServerStatus.ForeColor == Color.Red)
                {
                    this.ServerStatus.ForeColor = Color.Blue;
                }
                if (this.ServerStatus.Text != "Daemon Connected")
                    this.ServerStatus.Text = "Daemon Connected";
            }
            else
            {
                // Update server status
                if (this.ServerStatus.ForeColor == Color.Green ||
                    this.ServerStatus.ForeColor == Color.Blue)
                {
                    this.ServerStatus.ForeColor = Color.Red;
                }
                if (this.ServerStatus.Text != "Not Connected")
                    this.ServerStatus.Text = "Not Connected";
            }
            #endregion
        }

        // Makes text boxes number-only
        private void NumberOnly(object semder, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
                e.Handled = true;
        }
        private void DecimalNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
            if (char.IsDigit(e.KeyChar) && ((sender as TextBox).Text.IndexOf('.') > -1))
                if ((sender as TextBox).Text.IndexOf('.') < (sender as TextBox).Text.Length - 2 &&
                    (sender as TextBox).SelectionStart > (sender as TextBox).Text.IndexOf('.'))
                    e.Handled = true;
        }
        #endregion

        #region Main  Menu
        #region Wallet
        // Open wallet selected in menu
        private void openWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only open if server isn't running
            if (Wallet.Alive) return;

            // Prompt file loading dialog
            if (OpenWalletDialog.ShowDialog() == DialogResult.OK)
            {
                if (OpenWalletDialog.CheckFileExists)
                {
                    OpenWallet(OpenWalletDialog.FileName);
                }
            }
        }

        // Open default wallet
        private void openDefaultWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only open if server isn't running
            if (Wallet.Alive) return;

            if (File.Exists(Config.DefaultWalletPath))
            {
                OpenWallet(Config.DefaultWalletPath);
            }
        }

        // Create a new wallet
        private void createWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only open if server isn't running
            if (Wallet.Alive) return;

            // Get new file location
            if (this.NewWalletDialog.ShowDialog() != DialogResult.OK) return;


            // Get path
            String i = this.NewWalletDialog.FileName;

            // Make sure file doesn't exist
            if (File.Exists(i))
            {
                MessageBox.Show("Cannot overwrite existing fies when creating a new wallet", "Error");
                return;
            }

            // Get password
            EnterPassword:
            PasswordPrompt p = new PasswordPrompt();
            if (p.ShowDialog() != DialogResult.OK) return;

            // Get password
            String s = p.GetResult();

            // Check if password is blank
            if (s.Length < 1 && !Config.AllowBlankPasswords)
            {
                MessageBox.Show("Please enter a password or choose to allow creation of " +
                    "wallets without passwords under the security tab in the options menu", "Error");
                goto EnterPassword;
            }

            // Create wallet
            if (Wallet.Create(Config.ServerPath, i, s) == true)
            {
                // Open wallet if successful
                OpenWallet(i, s);
            }

            else
            {
                MessageBox.Show("Failed to create wallet", "Error");
            }
        }

        // Import wallet selected in menu
        private void importWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only open if server isn't running
            if (Wallet.Alive) return;

            // Get keys
            ImportKeys k = new ImportKeys();
            if (k.ShowDialog() != DialogResult.OK) return;

            // Get new file location
            if (this.NewWalletDialog.ShowDialog() != DialogResult.OK) return;
            
            // Get path
            String i = this.NewWalletDialog.FileName;

            // Make sure file doesn't exist
            if (File.Exists(i))
            {
                MessageBox.Show("Cannot overwrite existing fies when importing a wallet", "Error");
                return;
            }

            EnterPassword:
            // Get password
            PasswordPrompt p = new PasswordPrompt();
            if (p.ShowDialog() != DialogResult.OK) return;

            // Get password
            String s = p.GetResult();

            // Check if password is blank
            if (s.Length < 1 && !Config.AllowBlankPasswords)
            {
                MessageBox.Show("Please enter a password or choose to allow creation of " +
                    "wallets without passwords under the security tab in the options menu", "Error");
                goto EnterPassword;
            }

            // Create wallet
            if (Wallet.Import(Config.ServerPath, i, s, k.ViewKey, k.SpendKey) == true)
            {
                // Open wallet if successful
                OpenWallet(i, s);
            }

            // Wallet creationg failed
            else
            {
                MessageBox.Show("Failed to import wallet, te entered keys may be incorrect");
            }
        }

        // Export private keys selected in menu
        private void viewWalletKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure server is running
            if (!Wallet.Alive) return;

            // Prompt for password
            PasswordPrompt p = new PasswordPrompt();
            if (p.ShowDialog() != DialogResult.OK) return;

            // Check if password is correct
            String s = Server.SafeEncrypt(p.GetResult());
            if (s == Wallet.Password)
            {
                if (SavePrivateKeys.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(SavePrivateKeys.FileName))
                        File.Create(SavePrivateKeys.FileName).Dispose();
                    File.WriteAllText(SavePrivateKeys.FileName,
                        "Keep these keys private, anyone who has access to them has access to your wallet!\r\n\r\n" +
                        "View Key: " + Wallet.ViewKey + "\r\npublic Spend Key: " + Wallet.PublicSpendKey +
                        "\r\nPrivate Spend Key: " + Wallet.PrivateSpendKey);
                    Process.Start(SavePrivateKeys.FileName);
                }
            }
            else
            {
                // Password incorrect
                MessageBox.Show("Password incorrect", "Error");
            }
        }

        // Resync was selected in the menu
        private void resyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ask if they really want to resync the wallet from zero
            if (MessageBox.Show("Are you sure you would like to resync the wallet from zero? " +
                "This resets the block height information and could take a while to re-sync.",
                "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Wallet.Resync();
            }
        }

        // Connect to RPC server selected in menu
        private void ConnectRPCServer_Click(object sender, EventArgs e)
        {
            if (!Wallet.Connect(Config.RemotePath, Config.RemotePort, Config.RemotePassword))
                MessageBox.Show("Could not connect to RPC server:\r\n" + Server.Error, "Error");
            else
            {
                RemoteServer = true;
                if (Config.RemoteReminder)
                {
                    new RemoteReminder().ShowDialog();
                }
            }
        }

        // Close wallet selected in menu
        private void closeWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stop the server
            Server.Stop();

            // Clear our transactions
            this.TransactionOutput.Text = "";
            this.SendToAddress.Text = "";
            this.AmountToSend.Text = "";
            this.Fee.Text = Config.DefaultFee;
            this.PaymentID.Text = "";
            this.UnlockTime.Text = "";
            this.ChangeAddress.Text = "";
            this.Mixin.Text = "";
            this.ExtraBox.Text = "";
            RemoteServer = false;
        }
        #endregion

        #region Network
        // Connect to network selected in menu
        private void startNetworkConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Network.Start(Config.NodeHost, Config.NodePort))
                MessageBox.Show("Unable to connect to daemon", "Error");
        }

        // Close connection with network
        private void CloseNetworkConnection_Click(object sender, EventArgs e)
        {
            Network.Stop();
        }
        #endregion

        #region Mobile
        // Start mobile server selected
        private void startMobileServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Mobile.Start(Config.MobilePort, Config.MobilePassword))
                MessageBox.Show("Failed to start the mobile server:\r\n" + Server.Error, "Error");
        }

        // Stop mobile server selected
        private void stopMobileServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mobile.Stop();
        }
        #endregion

        #region Options
        // Options selected in menu
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OptionsWindow Options = new OptionsWindow())
                Options.ShowDialog();
        }
        #endregion

        #region About
        // Open about dialog
        private void aboutShellWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow About = new AboutWindow();
            About.ShowDialog();
        }
        #endregion
        #endregion
        
        #region Wallet Tab
        // Seleted address changed
        private void WalletAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Wallet.Addresses.Count > this.WalletAddresses.SelectedIndex &&
                this.WalletAddresses.SelectedIndex >= 0)
            {
                Wallet.SelectedAddress = Wallet.Addresses[this.WalletAddresses.SelectedIndex];

                Nickname.Text = Nicknames.Get(Wallet.SelectedAddress);
                AddressDisplay.Text = Wallet.SelectedAddress;

                //Force an update outside of the refresh tick
                Wallet.Update();
            }
            Console.WriteLine("Selected address changed to: {0}", Wallet.SelectedAddress);
        }

        // Copy wallet address to clipboard
        private void CopyAddress_Click(object sender, EventArgs e)
        {
            // Copy selected address to clipboard
            Clipboard.SetText(Wallet.SelectedAddress);
        }

        // Create a new address
        private void CreateNewAddress_Click(object sender, EventArgs e)
        {
            Wallet.CreateAddress();
            for (int i = 0; i < Wallet.Addresses.Count; i++)
            {
                String s = Nicknames.Get(Wallet.Addresses[i]);
                if (s != "-")
                {
                    Wallet.Addresses[i] = s;
                }
            }
            this.WalletAddresses.DataSource = null;
            this.WalletAddresses.DataSource = Wallet.Addresses;
            if (Wallet.Addresses.Count > 0)
                this.WalletAddresses.SelectedIndex = Wallet.Addresses.Count - 1;
        }

        // Delete the selected address
        private void DeleteSelectedAddress_Click(object sender, EventArgs e)
        {
            // Ask if they really want to delete the address
            if (MessageBox.Show("Are you sure you would like to delete this address?\r\n" +
                "All funds stored on it will be lost permanently.\r\nThis includes " + Wallet.SelectedBalance +
                " balance and " + Wallet.SelectedLockedBalance + " locked balance.\r\n\r\n" + Wallet.SelectedAddress,
                "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Wallet.DeleteSelectedAddress();
                for (int i = 0; i < Wallet.Addresses.Count; i++)
                {
                    String s = Nicknames.Get(Wallet.Addresses[i]);
                    if (s != "-")
                    {
                        Wallet.Addresses[i] = s;
                    }
                }
                this.WalletAddresses.DataSource = null;
                this.WalletAddresses.DataSource = Wallet.Addresses;
                if (Wallet.Addresses.Count > 0)
                    this.WalletAddresses.SelectedIndex = 0;
            }
        }
        #endregion

        #region Send Tab
        // Send transaction button clicked
        private void SendTransaction_Click(object sender, EventArgs e)
        {
            // Check that the server is running
            if (!Wallet.Alive) return;

            // Get transaction variables
            String Address = SendToAddress.Text;
            double Amount = 0;
            if (AmountToSend.Text.Length > 0) Amount = Convert.ToDouble(AmountToSend.Text.Replace(",", ""));
            double Fee = 0;
            if (this.Fee.Text.Length > 0) Fee = Convert.ToDouble(this.Fee.Text);
            String PaymentID = this.PaymentID.Text;
            if (UnlockTime.Text.Length == 0) UnlockTime.Text = Config.DefaultUnlockTime;
            if (Mixin.Text.Length == 0) Mixin.Text = Config.DefaultMixin;

            if (MessageBox.Show("Would you like to send " + String.Format("{0:N}", Amount) + " with a fee of " +
                String.Format("{0:N}", Fee) + "?", "Send Transaction", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            // Create transaction
            List<String> AddressList = new List<String>();
            if ((String)SendFromAddress.SelectedItem == "Selected Address") AddressList.Add(Wallet.SelectedAddress);

            // Create transfer
            List<Transfer> TransferList = new List<Transfer>();
            Transfer Transfer = new Transfer(Address, Amount * 100);
            TransferList.Add(Transfer);

            // Send transaction
            JObject result = Wallet.Send(AddressList, TransferList, Fee, Convert.ToInt32(Mixin.Text), "", PaymentID,
                Convert.ToInt32(UnlockTime.Text), ChangeAddress.Text);

            // Print result to output
            if (result.Count > 0)
            {
                // Print transaction result
                if (result["transactionHash"] != null)
                {
                    this.TransactionOutput.Text = "Transaction successful\r\n\r\n";
                    this.TransactionOutput.Text += "Transaction ID:\r\n" + result["transactionHash"] + "\r\n\r\n";
                }
                else if (result["error"] != null)
                {
                    this.TransactionOutput.Text = "Transaction unsuccessful\r\n\r\n";
                    this.TransactionOutput.Text += "Error: " + result["error"] + "\r\n\r\n";
                }

                // Print transaction information
                this.TransactionOutput.Text += "Transaction Information:\r\n";
                if ((String)this.SendFromAddress.SelectedItem == "Selected Address")
                    this.TransactionOutput.Text += "Sent From: " + Wallet.SelectedAddress + "\r\n";
                else this.TransactionOutput.Text += "Sent From: Entire Balance\r\n";
                this.TransactionOutput.Text += "Sent To: " + Address + "\r\n";
                this.TransactionOutput.Text += "Amount: " + Amount + "\r\n";
                this.TransactionOutput.Text += "Fee: " + Fee + "\r\n";
                this.TransactionOutput.Text += "Change Address: " + ChangeAddress.Text + "\r\n";
                this.TransactionOutput.Text += "Payment ID: " + PaymentID + "\r\n";
                this.TransactionOutput.Text += "Unlock Time: " + UnlockTime.Text + "\r\n";
                this.TransactionOutput.Text += "Mixin: " + Mixin.Text + "\r\n";
                this.TransactionOutput.Text += "Extra: " + ExtraBox.Text + "\r\n\r\n";
            }
            else this.TransactionOutput.Text = Server.Error;
        }
        #endregion

        #region Transaction Log Tab
        private void TransactionLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.TransactionLog.CurrentCell != null && this.TransactionLog.SelectedRows.Count > 0)
            {
                using (TransactionInfo t = new TransactionInfo(Wallet.Transactions[TransactionLog.SelectedRows[0].Index]))
                {
                    t.ShowDialog();
                }
            }
        }
        #endregion

        #region Address Book Tab
        // Add new contact to address book
        private void AddContact_Click(object sender, EventArgs e)
        {
            ContactPrompt c = new ContactPrompt();
            if (c.ShowDialog() == DialogResult.OK)
            {
                AddressBook.DataSource.Add(c.GetResult());
                c.Dispose();
            }
        }

        // Remove selected contact
        private void RemoveContact_Click(object sender, EventArgs e)
        {
            if (this.AddressGrid.CurrentCell != null)
                AddressBook.DataSource.RemoveAt(this.AddressGrid.SelectedRows[0].Index);
        }

        // Edit attributes associated with contact
        private void EditContact_Click(object sender, EventArgs e)
        {
            if (this.AddressGrid.CurrentCell != null)
            {
                int i = this.AddressGrid.SelectedRows[0].Index;
                ContactPrompt c = new ContactPrompt(AddressBook.DataSource[i]);
                if (c.ShowDialog() == DialogResult.OK)
                {
                    AddressBook.DataSource[i] = c.GetResult();
                    c.Dispose();
                }
            }
        }

        // Redirect to send tab and auto-fill send information
        private void SendToContact_Click(object sender, EventArgs e)
        {
            // Make sure an address is selected
            if (this.AddressGrid.CurrentCell != null && this.AddressGrid.SelectedRows.Count > 0)
            {
                // Get selected address from address book
                Contact c = AddressBook.DataSource[this.AddressGrid.SelectedRows[0].Index];
                if (c.Address != null)
                    this.SendToAddress.Text = c.Address;
                else this.PaymentID.Text = "";
                if (c.PaymentID != null) this.PaymentID.Text = c.PaymentID;
                else this.PaymentID.Text = "";

                // Set focus on amount textbok and change to send tab
                this.WalletTabs.SelectedIndex = 1;
                this.AmountToSend.Focus();
            }
        }
        private void AddressGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.AddressGrid.ClearSelection();
                this.AddressGrid.Rows[e.RowIndex].Selected = true;
            }
            else
            {
                this.AddressGrid.ClearSelection();
            }
        }

        private void AddressGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SendToContact_Click(sender, e);
        }

        private void AddressMenuCopyAddress_Click(object sender, EventArgs e)
        {
            // Make sure an address is selected
            if (this.AddressGrid.CurrentCell != null && this.AddressGrid.SelectedRows.Count > 0)
            {
                // Get selected address from address book
                Contact c = AddressBook.DataSource[this.AddressGrid.SelectedRows[0].Index];

                // Copy to clipboard
                Clipboard.SetText(c.Address);
            }
        }
        #endregion

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (!Wallet.Alive && e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            if (Wallet.Alive) return;
            String[] Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (Files.Length == 1 && File.Exists(Files[0])) OpenWallet(Files[0]);
        }

        private void SendFromAddress_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SendFromAddress.SelectedIndex == 0)
            {
                ChangeAddressLabel.Font = new Font(ChangeAddressLabel.Font, FontStyle.Bold);
                ChangeAddressOptional.Visible = false;
            }
            else
            {
                ChangeAddressLabel.Font = new Font(ChangeAddressLabel.Font, FontStyle.Regular);
                ChangeAddressOptional.Visible = true;
            }
        }

        #region Naigation Buttons
        // Navigation button hovered
        private void MenuItemMouseEnter(object sender, EventArgs e)
        {
            // Set hover color
            if (sender is Label)
                (sender as Label).Parent.BackColor = Config.Theme.NavigationHover;
            else if (sender is PictureBox)
                (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationHover;
            else if (sender is Panel)
                (sender as Panel).BackColor = Config.Theme.NavigationHover;
        }
        private void MenuItemMouseLeave(object sender, EventArgs e)
        {
            // Get which button the user stopped overing
            if (sender is Label)
            {
                String Button = (sender as Label).Name.Replace("Label", "");
                if (Button == "WalletTab")
                    if (WalletTabs.SelectedIndex == 0) (sender as Label).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as Label).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "SendTab")
                    if (WalletTabs.SelectedIndex == 1) (sender as Label).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as Label).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "TransactionLogTab")
                    if (WalletTabs.SelectedIndex == 2) (sender as Label).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as Label).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "AddressBookTab")
                    if (WalletTabs.SelectedIndex == 3) (sender as Label).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as Label).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "NetworkTab")
                    if (WalletTabs.SelectedIndex == 4) (sender as Label).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as Label).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "OptionsTab")
                    if (WalletTabs.SelectedIndex == 5) (sender as Label).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as Label).Parent.BackColor = Config.Theme.NavigationButton;
            }
            else if (sender is PictureBox)
            {
                String Button = (sender as PictureBox).Name.Replace("Icon", "");
                if (Button == "WalletTab")
                    if (WalletTabs.SelectedIndex == 0) (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "SendTab")
                    if (WalletTabs.SelectedIndex == 1) (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "TransactionLogTab")
                    if (WalletTabs.SelectedIndex == 2) (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "AddressBookTab")
                    if (WalletTabs.SelectedIndex == 3) (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "NetworkTab")
                    if (WalletTabs.SelectedIndex == 4) (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationButton;
                else if (Button == "OptionsTab")
                    if (WalletTabs.SelectedIndex == 5) (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationClicked;
                    else (sender as PictureBox).Parent.BackColor = Config.Theme.NavigationButton;
            }
            else if (sender is Panel)
            {
                String Button = (sender as Panel).Name.Replace("Button", "");
                if (Button == "WalletTab")
                    if (WalletTabs.SelectedIndex == 0) (sender as Panel).BackColor = Config.Theme.NavigationClicked;
                    else (sender as Panel).BackColor = Config.Theme.NavigationButton;
                else if (Button == "SendTab")
                    if (WalletTabs.SelectedIndex == 1) (sender as Panel).BackColor = Config.Theme.NavigationClicked;
                    else (sender as Panel).BackColor = Config.Theme.NavigationButton;
                else if (Button == "TransactionLogTab")
                    if (WalletTabs.SelectedIndex == 2) (sender as Panel).BackColor = Config.Theme.NavigationClicked;
                    else (sender as Panel).BackColor = Config.Theme.NavigationButton;
                else if (Button == "AddressBookTab")
                    if (WalletTabs.SelectedIndex == 3) (sender as Panel).BackColor = Config.Theme.NavigationClicked;
                    else (sender as Panel).BackColor = Config.Theme.NavigationButton;
                else if (Button == "NetworkTab")
                    if (WalletTabs.SelectedIndex == 4) (sender as Panel).BackColor = Config.Theme.NavigationClicked;
                    else (sender as Panel).BackColor = Config.Theme.NavigationButton;
                else if (Button == "OptionsTab")
                    if (WalletTabs.SelectedIndex == 5) (sender as Panel).BackColor = Config.Theme.NavigationClicked;
                    else (sender as Panel).BackColor = Config.Theme.NavigationButton;
            }
        }

        // Navigation button clicked
        private void MenuItemClicked(object sender, EventArgs e)
        {
            // Get which button the user clicked
            String Button = "";
            if (sender is Label)
                Button = (sender as Label).Name.Replace("Label", "");
            else if (sender is PictureBox)
                Button = (sender as PictureBox).Name.Replace("Icon", "");
            else if (sender is Panel)
                Button = (sender as Panel).Name.Replace("Button", "");

            // Change tab
            if (Button == "WalletTab")
                WalletTabs.SelectedIndex = 0;
            else if (Button == "SendTab")
                WalletTabs.SelectedIndex = 1;
            else if (Button == "TransactionLogTab")
                WalletTabs.SelectedIndex = 2;
            else if (Button == "AddressBookTab")
                WalletTabs.SelectedIndex = 3;
            else if (Button == "NetworkTab")
                WalletTabs.SelectedIndex = 4;
            else if (Button == "OptionsTab")
                //WalletTabs.SelectedIndex = 5;
                using (OptionsWindow Options = new OptionsWindow())
                    Options.ShowDialog();

            // Change menu colors
            if (WalletTabs.SelectedIndex == 0)
                WalletTabButton.BackColor = Config.Theme.NavigationHover;
            else WalletTabButton.BackColor = Config.Theme.NavigationButton;
            if (WalletTabs.SelectedIndex == 1)
                SendTabButton.BackColor = Config.Theme.NavigationHover;
            else SendTabButton.BackColor = Config.Theme.NavigationButton;
            if (WalletTabs.SelectedIndex == 2)
                TransactionLogTabButton.BackColor = Config.Theme.NavigationHover;
            else TransactionLogTabButton.BackColor = Config.Theme.NavigationButton;
            if (WalletTabs.SelectedIndex == 3)
                AddressBookTabButton.BackColor = Config.Theme.NavigationHover;
            else AddressBookTabButton.BackColor = Config.Theme.NavigationButton;
            if (WalletTabs.SelectedIndex == 4)
                NetworkTabButton.BackColor = Config.Theme.NavigationHover;
            else NetworkTabButton.BackColor = Config.Theme.NavigationButton;
            if (WalletTabs.SelectedIndex == 5)
                OptionsTabButton.BackColor = Config.Theme.NavigationHover;
            else OptionsTabButton.BackColor = Config.Theme.NavigationButton;
        }
        #endregion

        #region UI Themes
        /*
        internal void ChangeTheme(Theme T)
        {
            // Set theme
            Config.Theme = T;

            // Set window colors
            BackColor = Config.Theme.Window;
            ForeColor = Config.Theme.Text;

            // Set control colors
            foreach (Control c in Controls)
            {
                if (c is Label && c.Name != "ServerStatus")
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = Config.Theme.Text;
                }
                else if (c is MenuStrip)
                {
                    c.BackColor = Config.Theme.Menu;
                    c.ForeColor = Config.Theme.MenuText;
                    (c as MenuStrip).Renderer = new MenuRenderer(Config.Theme.MenuHover,
                        Config.Theme.MenuHover, Config.Theme.MenuHover,
                        Config.Theme.MenuBorder);
                }
                else if (c is ToolStrip)
                {
                    c.BackColor = Config.Theme.Menu;
                    c.ForeColor = Config.Theme.MenuText;
                }
                else if (c is Panel)
                {
                    if (c.Name == "MenuPanel")
                    {
                        c.BackColor = Config.Theme.Navigation;
                    }
                    else if (c.Name.IndexOf("DIVIDER") > -1)
                    {
                        c.BackColor = Config.Theme.Borders;
                    }
                    else
                    {
                        c.BackColor = Config.Theme.Window;
                    }
                    c.ForeColor = Config.Theme.Text;
                }
                else if (c is TableLayoutPanel)
                {
                    if (c.Name.IndexOf("TabButton") > -1)
                    {
                        c.BackColor = Config.Theme.Navigation;
                        c.ForeColor = Config.Theme.NavigationText;
                    }
                    else
                    {
                        c.BackColor = Config.Theme.Window;
                        c.ForeColor = Config.Theme.Text;
                    }
                }
                else if (c is Button)
                {
                    c.BackColor = Config.Theme.Button;
                    c.ForeColor = Config.Theme.ButtonText;
                }
                else if (c is TabPage)
                {
                    c.BackColor = Config.Theme.Window;
                    c.ForeColor = Config.Theme.Text;
                }
                }
            foreach (Control c in WalletTabs.Controls)
                {
                    if (c is Label)
                    {
                        c.BackColor = Color.Transparent;
                        c.ForeColor = Config.Theme.Text;
                    }
                    else if (c is Panel)
                    {
                        c.BackColor = Config.Theme.Window;
                        c.ForeColor = Config.Theme.Text;
                    }
                    else if (c is TableLayoutPanel)
                    {
                        c.BackColor = Config.Theme.Window;
                        c.ForeColor = Config.Theme.Text;
                    }
                    else if (c is Button)
                    {
                        c.BackColor = Config.Theme.Button;
                        c.ForeColor = Config.Theme.ButtonText;
                    }
                    else if (c is TabPage)
                    {
                        c.BackColor = Config.Theme.Window;
                        c.ForeColor = Config.Theme.Text;
                    }
                }

            // Set icons
            if (Config.Theme.IconSet == 0)
            {
                LockedIcon.Image = Properties.Resources.LockedBlack;
                WalletTabIcon.Image = Properties.Resources.WalletBlack;
                SendTabIcon.Image = Properties.Resources.SendBlack;
                TransactionLogTabIcon.Image = Properties.Resources.TransactionLogBlack;
                AddressBookTabIcon.Image = Properties.Resources.AddressBookBlack;
                NetworkTabIcon.Image = Properties.Resources.NetworkBlack;
                OptionsTabIcon.Image = Properties.Resources.OptionsBlack;
            }
            else if (Config.Theme.IconSet == 1)
            {
                LockedIcon.Image = Properties.Resources.LockedWhite;
                WalletTabIcon.Image = Properties.Resources.WalletWhite;
                SendTabIcon.Image = Properties.Resources.SendWhite;
                TransactionLogTabIcon.Image = Properties.Resources.TransactionLogWhite;
                AddressBookTabIcon.Image = Properties.Resources.AddressBookWhite;
                NetworkTabIcon.Image = Properties.Resources.NetworkWhite;
                OptionsTabIcon.Image = Properties.Resources.OptionsWhite;
            }
        }
        */
        #endregion

        private void ShowKeysClick(object sender, EventArgs e)
        {
            if (ShowKeys)
            {
                ShowKeys = false;
                ShowKeysButton.Text = "Show keys";
            }
            else
            {
                using (PasswordPrompt p = new PasswordPrompt())
                {
                    if (p.ShowDialog() != DialogResult.OK) return;
                    if (Server.SafeEncrypt(p.GetResult()) == Wallet.Password)
                    {
                        ShowKeys = true;
                        ShowKeysButton.Text = "Hide Keys";
                    }
                    else MessageBox.Show("Password incorrect", "Error");
                }
            }
        }

        private void ChangeNickname_Click(object sender, EventArgs e)
        {
            using (NicknamePrompt n = new NicknamePrompt())
            {
                if (n.ShowDialog() == DialogResult.OK)
                {
                    Nicknames.Add(Wallet.SelectedAddress, n.Result);
                    Nickname.Text = n.Result;
                }
            }
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.DimGray;
        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }

        private Boolean ShowAdvancedSend = true;
        private void ShowHideAdvancedSend(object sender, EventArgs e)
        {
            if (ShowAdvancedSend)
            {
                ShowAdvancedSend = false;
                /*
                AdvancedSendPanel.Visible = false;
                SendTransaction.Location = new Point(SendTransaction.Location.X, 235 - SendTabScrollPanel.VerticalScroll.Value);
                SendOutputLabel.Location = new Point(3, 255 - SendTabScrollPanel.VerticalScroll.Value);
                TransactionOutput.Location = new Point(6, 275 - SendTabScrollPanel.VerticalScroll.Value);
                */
                SendTabLayout.RowStyles[1].Height = 0;
                SendTabLayout.Height = SendTabLayout.Height - 159;
                ShowAdvancedSendLabel.Text = "(+Show Advanced)";
            }
            else
            {
                ShowAdvancedSend = true;
                /*
                AdvancedSendPanel.Visible = true;
                SendTransaction.Location = new Point(SendTransaction.Location.X, 412 - SendTabScrollPanel.VerticalScroll.Value);
                SendOutputLabel.Location = new Point(3, 430 - SendTabScrollPanel.VerticalScroll.Value);
                TransactionOutput.Location = new Point(6, 450 - SendTabScrollPanel.VerticalScroll.Value);
                */
                SendTabLayout.RowStyles[1].Height = 159;
                SendTabLayout.Height = SendTabLayout.Height + 159;
                ShowAdvancedSendLabel.Text = "(-Hide Advanced)";
            }
        }
    }
}
