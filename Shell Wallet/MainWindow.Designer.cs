namespace Shell_Wallet
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                writer.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.WalletMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWalletMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDefaultMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateWalletMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportWalletMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportPrivateKeysMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ResyncMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ConnectRemoteRPC = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseWalletMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.NetworkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StartNetworkMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseNetworkMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMobileServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMobileServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWalletDialog = new System.Windows.Forms.OpenFileDialog();
            this.NewWalletDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenServerPath = new System.Windows.Forms.OpenFileDialog();
            this.SendTab = new System.Windows.Forms.TabPage();
            this.TransactionOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Mixin = new System.Windows.Forms.TextBox();
            this.UnlockTime = new System.Windows.Forms.TextBox();
            this.ChangeAddress = new System.Windows.Forms.TextBox();
            this.Fee = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangeAddressLabel = new System.Windows.Forms.Label();
            this.AmountToSend = new System.Windows.Forms.TextBox();
            this.SendFromAddress = new System.Windows.Forms.ComboBox();
            this.SendToAddress = new System.Windows.Forms.TextBox();
            this.SendTransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExtraBox = new System.Windows.Forms.TextBox();
            this.ChangeAddressOptional = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PaymentID = new System.Windows.Forms.TextBox();
            this.WalletTab = new System.Windows.Forms.TabPage();
            this.SelectedAddressInfo = new System.Windows.Forms.GroupBox();
            this.AddressDisplay = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ChangeNickname = new System.Windows.Forms.Button();
            this.ShowKeysButton = new System.Windows.Forms.Button();
            this.CopyAddress = new System.Windows.Forms.Button();
            this.SelectedBalanceBox = new System.Windows.Forms.TextBox();
            this.PrivateSpendKey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.PublicSpendKey = new System.Windows.Forms.TextBox();
            this.SelectedLockedBalanceBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.DeleteSelectedAddress = new System.Windows.Forms.Button();
            this.CreateNewAddress = new System.Windows.Forms.Button();
            this.WalletAddresses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SyncPercent = new System.Windows.Forms.Label();
            this.SyncProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.LockedBalanceBox = new System.Windows.Forms.TextBox();
            this.WalletTabs = new System.Windows.Forms.TabControl();
            this.TransactonLogTab = new System.Windows.Forms.TabPage();
            this.TransactionLog = new System.Windows.Forms.DataGridView();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactBookTab = new System.Windows.Forms.TabPage();
            this.EditContact = new System.Windows.Forms.Button();
            this.SendToContact = new System.Windows.Forms.Button();
            this.RemoveContact = new System.Windows.Forms.Button();
            this.AddContact = new System.Windows.Forms.Button();
            this.AddressGrid = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressBookMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddressMenuCopyAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressMenuEditAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddressMenuSendTo = new System.Windows.Forms.ToolStripMenuItem();
            this.NetworkTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TransactionPool = new System.Windows.Forms.DataGridView();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RecentBlocks = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TotalSupply = new System.Windows.Forms.Label();
            this.TotalTransactions = new System.Windows.Forms.Label();
            this.TotalBlocks = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Difficulty = new System.Windows.Forms.Label();
            this.Reward = new System.Windows.Forms.Label();
            this.GlobalHashrate = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.BlankTab = new System.Windows.Forms.TabPage();
            this.HeightStatus = new System.Windows.Forms.Label();
            this.ServerStatus = new System.Windows.Forms.Label();
            this.SavePrivateKeys = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenImportFile = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OptionsTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsTabIcon = new System.Windows.Forms.PictureBox();
            this.OptionsTabLabel = new System.Windows.Forms.Label();
            this.NetworkTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.NetworkTabIcon = new System.Windows.Forms.PictureBox();
            this.NetworkTabLabel = new System.Windows.Forms.Label();
            this.AddressBookTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.AddressBookTabIcon = new System.Windows.Forms.PictureBox();
            this.AddressBookTabLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TransactionLogTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.TransactionLogTabIcon = new System.Windows.Forms.PictureBox();
            this.TransactionLogTabLabel = new System.Windows.Forms.Label();
            this.MENUDIVIDER2 = new System.Windows.Forms.Panel();
            this.MENUDIVIDER1 = new System.Windows.Forms.Panel();
            this.WalletTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.WalletTabIcon = new System.Windows.Forms.PictureBox();
            this.WalletTabLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LockedIcon = new System.Windows.Forms.PictureBox();
            this.SendTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.SendTabIcon = new System.Windows.Forms.PictureBox();
            this.SendTabLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MainWindowTable = new System.Windows.Forms.TableLayoutPanel();
            this.RightSideTable = new System.Windows.Forms.TableLayoutPanel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionPoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recentBlocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuStrip.SuspendLayout();
            this.SendTab.SuspendLayout();
            this.WalletTab.SuspendLayout();
            this.SelectedAddressInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.WalletTabs.SuspendLayout();
            this.TransactonLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLog)).BeginInit();
            this.ContactBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).BeginInit();
            this.AddressBookMenu.SuspendLayout();
            this.NetworkTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionPool)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecentBlocks)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.OptionsTabButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsTabIcon)).BeginInit();
            this.NetworkTabButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetworkTabIcon)).BeginInit();
            this.AddressBookTabButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressBookTabIcon)).BeginInit();
            this.TransactionLogTabButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLogTabIcon)).BeginInit();
            this.WalletTabButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WalletTabIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockedIcon)).BeginInit();
            this.SendTabButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendTabIcon)).BeginInit();
            this.MainWindowTable.SuspendLayout();
            this.RightSideTable.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionPoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentBlocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WalletMenu,
            this.NetworkMenu,
            this.mobileToolStripMenuItem,
            this.OptionsMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Main Menu";
            // 
            // WalletMenu
            // 
            this.WalletMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenWalletMenuOption,
            this.OpenDefaultMenuOption,
            this.toolStripMenuItem3,
            this.CreateWalletMenuOption,
            this.ImportWalletMenuOption,
            this.toolStripMenuItem1,
            this.ExportPrivateKeysMenuOption,
            this.ResyncMenuOption,
            this.toolStripMenuItem6,
            this.ConnectRemoteRPC,
            this.CloseWalletMenuOption});
            this.WalletMenu.Name = "WalletMenu";
            this.WalletMenu.Size = new System.Drawing.Size(52, 20);
            this.WalletMenu.Text = "Wallet";
            // 
            // OpenWalletMenuOption
            // 
            this.OpenWalletMenuOption.Name = "OpenWalletMenuOption";
            this.OpenWalletMenuOption.Size = new System.Drawing.Size(193, 22);
            this.OpenWalletMenuOption.Text = "Open Wallet";
            this.OpenWalletMenuOption.Click += new System.EventHandler(this.openWalletToolStripMenuItem_Click);
            // 
            // OpenDefaultMenuOption
            // 
            this.OpenDefaultMenuOption.Name = "OpenDefaultMenuOption";
            this.OpenDefaultMenuOption.Size = new System.Drawing.Size(193, 22);
            this.OpenDefaultMenuOption.Text = "Open Default";
            this.OpenDefaultMenuOption.Click += new System.EventHandler(this.openDefaultWalletToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 6);
            // 
            // CreateWalletMenuOption
            // 
            this.CreateWalletMenuOption.Name = "CreateWalletMenuOption";
            this.CreateWalletMenuOption.Size = new System.Drawing.Size(193, 22);
            this.CreateWalletMenuOption.Text = "Create Wallet";
            this.CreateWalletMenuOption.Click += new System.EventHandler(this.createWalletToolStripMenuItem_Click);
            // 
            // ImportWalletMenuOption
            // 
            this.ImportWalletMenuOption.Name = "ImportWalletMenuOption";
            this.ImportWalletMenuOption.Size = new System.Drawing.Size(193, 22);
            this.ImportWalletMenuOption.Text = "Import Wallet";
            this.ImportWalletMenuOption.Click += new System.EventHandler(this.importWalletToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // ExportPrivateKeysMenuOption
            // 
            this.ExportPrivateKeysMenuOption.Name = "ExportPrivateKeysMenuOption";
            this.ExportPrivateKeysMenuOption.Size = new System.Drawing.Size(193, 22);
            this.ExportPrivateKeysMenuOption.Text = "Export Private Keys";
            this.ExportPrivateKeysMenuOption.Click += new System.EventHandler(this.viewWalletKeysToolStripMenuItem_Click);
            // 
            // ResyncMenuOption
            // 
            this.ResyncMenuOption.Name = "ResyncMenuOption";
            this.ResyncMenuOption.Size = new System.Drawing.Size(193, 22);
            this.ResyncMenuOption.Text = "Resync";
            this.ResyncMenuOption.Click += new System.EventHandler(this.resyncToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(190, 6);
            // 
            // ConnectRemoteRPC
            // 
            this.ConnectRemoteRPC.Name = "ConnectRemoteRPC";
            this.ConnectRemoteRPC.Size = new System.Drawing.Size(193, 22);
            this.ConnectRemoteRPC.Text = "Connect to RPC Server";
            this.ConnectRemoteRPC.Click += new System.EventHandler(this.ConnectRPCServer_Click);
            // 
            // CloseWalletMenuOption
            // 
            this.CloseWalletMenuOption.Enabled = false;
            this.CloseWalletMenuOption.Name = "CloseWalletMenuOption";
            this.CloseWalletMenuOption.Size = new System.Drawing.Size(193, 22);
            this.CloseWalletMenuOption.Text = "Close Wallet";
            this.CloseWalletMenuOption.Click += new System.EventHandler(this.closeWalletToolStripMenuItem_Click);
            // 
            // NetworkMenu
            // 
            this.NetworkMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartNetworkMenuOption,
            this.CloseNetworkMenuOption});
            this.NetworkMenu.Name = "NetworkMenu";
            this.NetworkMenu.Size = new System.Drawing.Size(64, 20);
            this.NetworkMenu.Text = "Network";
            // 
            // StartNetworkMenuOption
            // 
            this.StartNetworkMenuOption.Name = "StartNetworkMenuOption";
            this.StartNetworkMenuOption.Size = new System.Drawing.Size(216, 22);
            this.StartNetworkMenuOption.Text = "Start Network Connection";
            this.StartNetworkMenuOption.Click += new System.EventHandler(this.startNetworkConnectionToolStripMenuItem_Click);
            // 
            // CloseNetworkMenuOption
            // 
            this.CloseNetworkMenuOption.Enabled = false;
            this.CloseNetworkMenuOption.Name = "CloseNetworkMenuOption";
            this.CloseNetworkMenuOption.Size = new System.Drawing.Size(216, 22);
            this.CloseNetworkMenuOption.Text = "Close Network Connection";
            this.CloseNetworkMenuOption.Click += new System.EventHandler(this.CloseNetworkConnection_Click);
            // 
            // mobileToolStripMenuItem
            // 
            this.mobileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMobileServerToolStripMenuItem,
            this.stopMobileServerToolStripMenuItem});
            this.mobileToolStripMenuItem.Enabled = false;
            this.mobileToolStripMenuItem.Name = "mobileToolStripMenuItem";
            this.mobileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.mobileToolStripMenuItem.Text = "Mobile";
            // 
            // startMobileServerToolStripMenuItem
            // 
            this.startMobileServerToolStripMenuItem.Enabled = false;
            this.startMobileServerToolStripMenuItem.Name = "startMobileServerToolStripMenuItem";
            this.startMobileServerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.startMobileServerToolStripMenuItem.Text = "Start Mobile Server";
            this.startMobileServerToolStripMenuItem.Click += new System.EventHandler(this.startMobileServerToolStripMenuItem_Click);
            // 
            // stopMobileServerToolStripMenuItem
            // 
            this.stopMobileServerToolStripMenuItem.Enabled = false;
            this.stopMobileServerToolStripMenuItem.Name = "stopMobileServerToolStripMenuItem";
            this.stopMobileServerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.stopMobileServerToolStripMenuItem.Text = "Stop Mobile Server";
            this.stopMobileServerToolStripMenuItem.Click += new System.EventHandler(this.stopMobileServerToolStripMenuItem_Click);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsMenuOption,
            this.toolStripMenuItem2,
            this.AboutMenuOption});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu.Text = "Options";
            // 
            // OptionsMenuOption
            // 
            this.OptionsMenuOption.Name = "OptionsMenuOption";
            this.OptionsMenuOption.Size = new System.Drawing.Size(116, 22);
            this.OptionsMenuOption.Text = "Options";
            this.OptionsMenuOption.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 6);
            // 
            // AboutMenuOption
            // 
            this.AboutMenuOption.Name = "AboutMenuOption";
            this.AboutMenuOption.Size = new System.Drawing.Size(116, 22);
            this.AboutMenuOption.Text = "About";
            this.AboutMenuOption.Click += new System.EventHandler(this.aboutShellWalletToolStripMenuItem_Click);
            // 
            // OpenWalletDialog
            // 
            this.OpenWalletDialog.FileName = "Wallet";
            this.OpenWalletDialog.Filter = "Wallet Files|*.wallet|All files|*.*";
            // 
            // NewWalletDialog
            // 
            this.NewWalletDialog.DefaultExt = "wallet";
            this.NewWalletDialog.FileName = "New Wallet";
            this.NewWalletDialog.Filter = "Wallet Files|*.wallet|All files|*.*";
            this.NewWalletDialog.OverwritePrompt = false;
            // 
            // OpenServerPath
            // 
            this.OpenServerPath.FileName = "walletd.exe";
            this.OpenServerPath.Filter = "Wallet Server|walletd.exe";
            // 
            // SendTab
            // 
            this.SendTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SendTab.Controls.Add(this.TransactionOutput);
            this.SendTab.Controls.Add(this.label8);
            this.SendTab.Controls.Add(this.label20);
            this.SendTab.Controls.Add(this.label7);
            this.SendTab.Controls.Add(this.label6);
            this.SendTab.Controls.Add(this.label16);
            this.SendTab.Controls.Add(this.Mixin);
            this.SendTab.Controls.Add(this.UnlockTime);
            this.SendTab.Controls.Add(this.ChangeAddress);
            this.SendTab.Controls.Add(this.Fee);
            this.SendTab.Controls.Add(this.label17);
            this.SendTab.Controls.Add(this.label9);
            this.SendTab.Controls.Add(this.ChangeAddressLabel);
            this.SendTab.Controls.Add(this.AmountToSend);
            this.SendTab.Controls.Add(this.SendFromAddress);
            this.SendTab.Controls.Add(this.SendToAddress);
            this.SendTab.Controls.Add(this.SendTransaction);
            this.SendTab.Controls.Add(this.label4);
            this.SendTab.Controls.Add(this.label5);
            this.SendTab.Controls.Add(this.ExtraBox);
            this.SendTab.Controls.Add(this.ChangeAddressOptional);
            this.SendTab.Controls.Add(this.label10);
            this.SendTab.Controls.Add(this.label11);
            this.SendTab.Controls.Add(this.label14);
            this.SendTab.Controls.Add(this.label15);
            this.SendTab.Controls.Add(this.PaymentID);
            this.SendTab.ForeColor = System.Drawing.Color.Black;
            this.SendTab.Location = new System.Drawing.Point(4, 4);
            this.SendTab.Name = "SendTab";
            this.SendTab.Padding = new System.Windows.Forms.Padding(6);
            this.SendTab.Size = new System.Drawing.Size(595, 426);
            this.SendTab.TabIndex = 2;
            this.SendTab.Text = "Send";
            // 
            // TransactionOutput
            // 
            this.TransactionOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionOutput.Location = new System.Drawing.Point(9, 332);
            this.TransactionOutput.Multiline = true;
            this.TransactionOutput.Name = "TransactionOutput";
            this.TransactionOutput.ReadOnly = true;
            this.TransactionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransactionOutput.Size = new System.Drawing.Size(577, 85);
            this.TransactionOutput.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Output";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Send From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(9, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payment ID";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fee";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(242, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "(Optional)";
            // 
            // Mixin
            // 
            this.Mixin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mixin.Location = new System.Drawing.Point(300, 264);
            this.Mixin.Name = "Mixin";
            this.Mixin.Size = new System.Drawing.Size(286, 20);
            this.Mixin.TabIndex = 7;
            this.Mixin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // UnlockTime
            // 
            this.UnlockTime.Location = new System.Drawing.Point(9, 264);
            this.UnlockTime.Name = "UnlockTime";
            this.UnlockTime.Size = new System.Drawing.Size(285, 20);
            this.UnlockTime.TabIndex = 5;
            this.UnlockTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // ChangeAddress
            // 
            this.ChangeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeAddress.Location = new System.Drawing.Point(9, 147);
            this.ChangeAddress.Name = "ChangeAddress";
            this.ChangeAddress.Size = new System.Drawing.Size(577, 20);
            this.ChangeAddress.TabIndex = 6;
            // 
            // Fee
            // 
            this.Fee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fee.Location = new System.Drawing.Point(300, 72);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(286, 20);
            this.Fee.TabIndex = 3;
            this.Fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalNumberOnly);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(534, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "(Optional)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(9, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Extra";
            // 
            // ChangeAddressLabel
            // 
            this.ChangeAddressLabel.AutoSize = true;
            this.ChangeAddressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeAddressLabel.Location = new System.Drawing.Point(9, 131);
            this.ChangeAddressLabel.Name = "ChangeAddressLabel";
            this.ChangeAddressLabel.Size = new System.Drawing.Size(85, 13);
            this.ChangeAddressLabel.TabIndex = 16;
            this.ChangeAddressLabel.Text = "Change Address";
            // 
            // AmountToSend
            // 
            this.AmountToSend.Location = new System.Drawing.Point(9, 72);
            this.AmountToSend.Name = "AmountToSend";
            this.AmountToSend.Size = new System.Drawing.Size(285, 20);
            this.AmountToSend.TabIndex = 2;
            this.AmountToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalNumberOnly);
            // 
            // SendFromAddress
            // 
            this.SendFromAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendFromAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendFromAddress.FormattingEnabled = true;
            this.SendFromAddress.Items.AddRange(new object[] {
            "Entire Wallet Balance",
            "Selected Address"});
            this.SendFromAddress.Location = new System.Drawing.Point(9, 29);
            this.SendFromAddress.Name = "SendFromAddress";
            this.SendFromAddress.Size = new System.Drawing.Size(577, 21);
            this.SendFromAddress.TabIndex = 0;
            this.SendFromAddress.SelectedValueChanged += new System.EventHandler(this.SendFromAddress_SelectedValueChanged);
            // 
            // SendToAddress
            // 
            this.SendToAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendToAddress.Location = new System.Drawing.Point(9, 108);
            this.SendToAddress.Name = "SendToAddress";
            this.SendToAddress.Size = new System.Drawing.Size(577, 20);
            this.SendToAddress.TabIndex = 1;
            // 
            // SendTransaction
            // 
            this.SendTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTransaction.Enabled = false;
            this.SendTransaction.Location = new System.Drawing.Point(9, 290);
            this.SendTransaction.Name = "SendTransaction";
            this.SendTransaction.Size = new System.Drawing.Size(577, 23);
            this.SendTransaction.TabIndex = 9;
            this.SendTransaction.Text = "Send Transaction";
            this.SendTransaction.UseVisualStyleBackColor = true;
            this.SendTransaction.Click += new System.EventHandler(this.SendTransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Send To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount";
            // 
            // ExtraBox
            // 
            this.ExtraBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraBox.Location = new System.Drawing.Point(9, 225);
            this.ExtraBox.Name = "ExtraBox";
            this.ExtraBox.Size = new System.Drawing.Size(577, 20);
            this.ExtraBox.TabIndex = 8;
            // 
            // ChangeAddressOptional
            // 
            this.ChangeAddressOptional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeAddressOptional.AutoSize = true;
            this.ChangeAddressOptional.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeAddressOptional.Location = new System.Drawing.Point(534, 130);
            this.ChangeAddressOptional.Name = "ChangeAddressOptional";
            this.ChangeAddressOptional.Size = new System.Drawing.Size(52, 13);
            this.ChangeAddressOptional.TabIndex = 17;
            this.ChangeAddressOptional.Text = "(Optional)";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(300, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mixin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(9, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Unlock Time";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(534, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "(Optional)";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(534, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "(Optional)";
            // 
            // PaymentID
            // 
            this.PaymentID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentID.Location = new System.Drawing.Point(9, 186);
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Size = new System.Drawing.Size(577, 20);
            this.PaymentID.TabIndex = 4;
            // 
            // WalletTab
            // 
            this.WalletTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WalletTab.Controls.Add(this.SelectedAddressInfo);
            this.WalletTab.Controls.Add(this.DeleteSelectedAddress);
            this.WalletTab.Controls.Add(this.CreateNewAddress);
            this.WalletTab.Controls.Add(this.WalletAddresses);
            this.WalletTab.Controls.Add(this.label1);
            this.WalletTab.ForeColor = System.Drawing.Color.Black;
            this.WalletTab.Location = new System.Drawing.Point(4, 4);
            this.WalletTab.Margin = new System.Windows.Forms.Padding(0);
            this.WalletTab.Name = "WalletTab";
            this.WalletTab.Padding = new System.Windows.Forms.Padding(6);
            this.WalletTab.Size = new System.Drawing.Size(595, 426);
            this.WalletTab.TabIndex = 0;
            this.WalletTab.Text = "Wallet";
            // 
            // SelectedAddressInfo
            // 
            this.SelectedAddressInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedAddressInfo.Controls.Add(this.AddressDisplay);
            this.SelectedAddressInfo.Controls.Add(this.label13);
            this.SelectedAddressInfo.Controls.Add(this.label18);
            this.SelectedAddressInfo.Controls.Add(this.ChangeNickname);
            this.SelectedAddressInfo.Controls.Add(this.ShowKeysButton);
            this.SelectedAddressInfo.Controls.Add(this.CopyAddress);
            this.SelectedAddressInfo.Controls.Add(this.SelectedBalanceBox);
            this.SelectedAddressInfo.Controls.Add(this.PrivateSpendKey);
            this.SelectedAddressInfo.Controls.Add(this.label19);
            this.SelectedAddressInfo.Controls.Add(this.PublicSpendKey);
            this.SelectedAddressInfo.Controls.Add(this.SelectedLockedBalanceBox);
            this.SelectedAddressInfo.Controls.Add(this.label26);
            this.SelectedAddressInfo.Controls.Add(this.pictureBox2);
            this.SelectedAddressInfo.Controls.Add(this.label25);
            this.SelectedAddressInfo.Controls.Add(this.label24);
            this.SelectedAddressInfo.Controls.Add(this.Nickname);
            this.SelectedAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedAddressInfo.Location = new System.Drawing.Point(9, 91);
            this.SelectedAddressInfo.Name = "SelectedAddressInfo";
            this.SelectedAddressInfo.Size = new System.Drawing.Size(577, 326);
            this.SelectedAddressInfo.TabIndex = 23;
            this.SelectedAddressInfo.TabStop = false;
            this.SelectedAddressInfo.Text = "Selected Address Information";
            // 
            // AddressDisplay
            // 
            this.AddressDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressDisplay.BackColor = System.Drawing.Color.White;
            this.AddressDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressDisplay.Location = new System.Drawing.Point(25, 35);
            this.AddressDisplay.Name = "AddressDisplay";
            this.AddressDisplay.ReadOnly = true;
            this.AddressDisplay.Size = new System.Drawing.Size(535, 20);
            this.AddressDisplay.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(22, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Balance";
            // 
            // ChangeNickname
            // 
            this.ChangeNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeNickname.BackColor = System.Drawing.Color.Gainsboro;
            this.ChangeNickname.Enabled = false;
            this.ChangeNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeNickname.Location = new System.Drawing.Point(169, 288);
            this.ChangeNickname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ChangeNickname.Name = "ChangeNickname";
            this.ChangeNickname.Size = new System.Drawing.Size(150, 32);
            this.ChangeNickname.TabIndex = 17;
            this.ChangeNickname.Text = "Change Nicckname";
            this.ChangeNickname.UseVisualStyleBackColor = false;
            this.ChangeNickname.Click += new System.EventHandler(this.ChangeNickname_Click);
            // 
            // ShowKeysButton
            // 
            this.ShowKeysButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowKeysButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ShowKeysButton.Enabled = false;
            this.ShowKeysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowKeysButton.Location = new System.Drawing.Point(6, 288);
            this.ShowKeysButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ShowKeysButton.Name = "ShowKeysButton";
            this.ShowKeysButton.Size = new System.Drawing.Size(150, 32);
            this.ShowKeysButton.TabIndex = 22;
            this.ShowKeysButton.Text = "Show Keys";
            this.ShowKeysButton.UseVisualStyleBackColor = false;
            this.ShowKeysButton.Click += new System.EventHandler(this.ShowKeysClick);
            // 
            // CopyAddress
            // 
            this.CopyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.CopyAddress.Enabled = false;
            this.CopyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyAddress.Location = new System.Drawing.Point(421, 288);
            this.CopyAddress.Name = "CopyAddress";
            this.CopyAddress.Size = new System.Drawing.Size(150, 32);
            this.CopyAddress.TabIndex = 1;
            this.CopyAddress.Text = "Copy to Clipboard";
            this.CopyAddress.UseVisualStyleBackColor = false;
            this.CopyAddress.Click += new System.EventHandler(this.CopyAddress_Click);
            // 
            // SelectedBalanceBox
            // 
            this.SelectedBalanceBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelectedBalanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedBalanceBox.Enabled = false;
            this.SelectedBalanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedBalanceBox.ForeColor = System.Drawing.Color.Black;
            this.SelectedBalanceBox.Location = new System.Drawing.Point(25, 75);
            this.SelectedBalanceBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.SelectedBalanceBox.Name = "SelectedBalanceBox";
            this.SelectedBalanceBox.ReadOnly = true;
            this.SelectedBalanceBox.Size = new System.Drawing.Size(150, 16);
            this.SelectedBalanceBox.TabIndex = 3;
            this.SelectedBalanceBox.Text = "-";
            this.ToolTip.SetToolTip(this.SelectedBalanceBox, "Balance of your selected address");
            // 
            // PrivateSpendKey
            // 
            this.PrivateSpendKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrivateSpendKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrivateSpendKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateSpendKey.ForeColor = System.Drawing.Color.Black;
            this.PrivateSpendKey.Location = new System.Drawing.Point(25, 195);
            this.PrivateSpendKey.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.PrivateSpendKey.Name = "PrivateSpendKey";
            this.PrivateSpendKey.ReadOnly = true;
            this.PrivateSpendKey.Size = new System.Drawing.Size(535, 16);
            this.PrivateSpendKey.TabIndex = 21;
            this.PrivateSpendKey.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(22, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "Locked Balance";
            // 
            // PublicSpendKey
            // 
            this.PublicSpendKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PublicSpendKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublicSpendKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicSpendKey.ForeColor = System.Drawing.Color.Black;
            this.PublicSpendKey.Location = new System.Drawing.Point(25, 155);
            this.PublicSpendKey.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.PublicSpendKey.Name = "PublicSpendKey";
            this.PublicSpendKey.ReadOnly = true;
            this.PublicSpendKey.Size = new System.Drawing.Size(535, 16);
            this.PublicSpendKey.TabIndex = 20;
            this.PublicSpendKey.Text = "-";
            // 
            // SelectedLockedBalanceBox
            // 
            this.SelectedLockedBalanceBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelectedLockedBalanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedLockedBalanceBox.Enabled = false;
            this.SelectedLockedBalanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedLockedBalanceBox.ForeColor = System.Drawing.Color.Black;
            this.SelectedLockedBalanceBox.Location = new System.Drawing.Point(25, 115);
            this.SelectedLockedBalanceBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.SelectedLockedBalanceBox.Name = "SelectedLockedBalanceBox";
            this.SelectedLockedBalanceBox.ReadOnly = true;
            this.SelectedLockedBalanceBox.Size = new System.Drawing.Size(150, 16);
            this.SelectedLockedBalanceBox.TabIndex = 5;
            this.SelectedLockedBalanceBox.Text = "-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(22, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 15);
            this.label26.TabIndex = 19;
            this.label26.Text = "Public Spend Key";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shell_Wallet.Properties.Resources.LockedBlack;
            this.pictureBox2.Location = new System.Drawing.Point(6, 115);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(22, 179);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 15);
            this.label25.TabIndex = 18;
            this.label25.Text = "Private Spend Key";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(264, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 15;
            this.label24.Text = "Nickname";
            // 
            // Nickname
            // 
            this.Nickname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nickname.Enabled = false;
            this.Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nickname.Location = new System.Drawing.Point(267, 90);
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            this.Nickname.Size = new System.Drawing.Size(293, 16);
            this.Nickname.TabIndex = 16;
            this.Nickname.Text = "-";
            // 
            // DeleteSelectedAddress
            // 
            this.DeleteSelectedAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSelectedAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteSelectedAddress.Enabled = false;
            this.DeleteSelectedAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedAddress.Location = new System.Drawing.Point(436, 53);
            this.DeleteSelectedAddress.Name = "DeleteSelectedAddress";
            this.DeleteSelectedAddress.Size = new System.Drawing.Size(150, 32);
            this.DeleteSelectedAddress.TabIndex = 12;
            this.DeleteSelectedAddress.Text = "Delete This Address";
            this.DeleteSelectedAddress.UseVisualStyleBackColor = false;
            this.DeleteSelectedAddress.Click += new System.EventHandler(this.DeleteSelectedAddress_Click);
            // 
            // CreateNewAddress
            // 
            this.CreateNewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateNewAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.CreateNewAddress.Enabled = false;
            this.CreateNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewAddress.Location = new System.Drawing.Point(9, 53);
            this.CreateNewAddress.Name = "CreateNewAddress";
            this.CreateNewAddress.Size = new System.Drawing.Size(150, 32);
            this.CreateNewAddress.TabIndex = 11;
            this.CreateNewAddress.Text = "Create New Address";
            this.ToolTip.SetToolTip(this.CreateNewAddress, "Create a new address");
            this.CreateNewAddress.UseVisualStyleBackColor = false;
            this.CreateNewAddress.Click += new System.EventHandler(this.CreateNewAddress_Click);
            // 
            // WalletAddresses
            // 
            this.WalletAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WalletAddresses.BackColor = System.Drawing.Color.White;
            this.WalletAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WalletAddresses.Enabled = false;
            this.WalletAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WalletAddresses.FormattingEnabled = true;
            this.WalletAddresses.Location = new System.Drawing.Point(9, 26);
            this.WalletAddresses.Name = "WalletAddresses";
            this.WalletAddresses.Size = new System.Drawing.Size(577, 21);
            this.WalletAddresses.TabIndex = 0;
            this.ToolTip.SetToolTip(this.WalletAddresses, "Displays all of your addresses");
            this.WalletAddresses.SelectedIndexChanged += new System.EventHandler(this.WalletAddresses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Addresses";
            // 
            // SyncPercent
            // 
            this.SyncPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SyncPercent.ForeColor = System.Drawing.Color.DarkGray;
            this.SyncPercent.Location = new System.Drawing.Point(5, 423);
            this.SyncPercent.Name = "SyncPercent";
            this.SyncPercent.Size = new System.Drawing.Size(160, 13);
            this.SyncPercent.TabIndex = 8;
            this.SyncPercent.Text = "Waiting to sync";
            this.SyncPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SyncProgress
            // 
            this.SyncProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SyncProgress.Location = new System.Drawing.Point(5, 439);
            this.SyncProgress.Name = "SyncProgress";
            this.SyncProgress.Size = new System.Drawing.Size(159, 10);
            this.SyncProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SyncProgress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Locked Balance";
            // 
            // BalanceBox
            // 
            this.BalanceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceBox.BackColor = System.Drawing.Color.White;
            this.BalanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BalanceBox.Enabled = false;
            this.BalanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceBox.ForeColor = System.Drawing.Color.Black;
            this.BalanceBox.Location = new System.Drawing.Point(24, 57);
            this.BalanceBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.ReadOnly = true;
            this.BalanceBox.Size = new System.Drawing.Size(139, 16);
            this.BalanceBox.TabIndex = 2;
            this.BalanceBox.Text = "0.00";
            // 
            // LockedBalanceBox
            // 
            this.LockedBalanceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LockedBalanceBox.BackColor = System.Drawing.Color.White;
            this.LockedBalanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LockedBalanceBox.Enabled = false;
            this.LockedBalanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockedBalanceBox.ForeColor = System.Drawing.Color.Black;
            this.LockedBalanceBox.Location = new System.Drawing.Point(24, 97);
            this.LockedBalanceBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.LockedBalanceBox.Name = "LockedBalanceBox";
            this.LockedBalanceBox.ReadOnly = true;
            this.LockedBalanceBox.Size = new System.Drawing.Size(139, 16);
            this.LockedBalanceBox.TabIndex = 3;
            this.LockedBalanceBox.Text = "0.00";
            // 
            // WalletTabs
            // 
            this.WalletTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.WalletTabs.Controls.Add(this.WalletTab);
            this.WalletTabs.Controls.Add(this.SendTab);
            this.WalletTabs.Controls.Add(this.TransactonLogTab);
            this.WalletTabs.Controls.Add(this.ContactBookTab);
            this.WalletTabs.Controls.Add(this.NetworkTab);
            this.WalletTabs.Controls.Add(this.BlankTab);
            this.WalletTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WalletTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.WalletTabs.Location = new System.Drawing.Point(0, 0);
            this.WalletTabs.Margin = new System.Windows.Forms.Padding(0);
            this.WalletTabs.Multiline = true;
            this.WalletTabs.Name = "WalletTabs";
            this.WalletTabs.SelectedIndex = 0;
            this.WalletTabs.Size = new System.Drawing.Size(603, 435);
            this.WalletTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.WalletTabs.TabIndex = 1;
            // 
            // TransactonLogTab
            // 
            this.TransactonLogTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransactonLogTab.Controls.Add(this.TransactionLog);
            this.TransactonLogTab.ForeColor = System.Drawing.Color.Black;
            this.TransactonLogTab.Location = new System.Drawing.Point(4, 4);
            this.TransactonLogTab.Name = "TransactonLogTab";
            this.TransactonLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransactonLogTab.Size = new System.Drawing.Size(595, 426);
            this.TransactonLogTab.TabIndex = 6;
            this.TransactonLogTab.Text = "Transaction Log";
            // 
            // TransactionLog
            // 
            this.TransactionLog.AllowUserToAddRows = false;
            this.TransactionLog.AllowUserToDeleteRows = false;
            this.TransactionLog.AllowUserToResizeRows = false;
            this.TransactionLog.AutoGenerateColumns = false;
            this.TransactionLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransactionLog.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TransactionLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn,
            this.hashDataGridViewTextBoxColumn1});
            this.TransactionLog.DataSource = this.transactionBindingSource;
            this.TransactionLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionLog.Location = new System.Drawing.Point(3, 3);
            this.TransactionLog.MultiSelect = false;
            this.TransactionLog.Name = "TransactionLog";
            this.TransactionLog.ReadOnly = true;
            this.TransactionLog.RowHeadersVisible = false;
            this.TransactionLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionLog.ShowCellErrors = false;
            this.TransactionLog.ShowCellToolTips = false;
            this.TransactionLog.ShowEditingIcon = false;
            this.TransactionLog.ShowRowErrors = false;
            this.TransactionLog.Size = new System.Drawing.Size(589, 420);
            this.TransactionLog.TabIndex = 0;
            this.TransactionLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionLog_CellDoubleClick);
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            this.TypeColumn.FillWeight = 25F;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // ContactBookTab
            // 
            this.ContactBookTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactBookTab.Controls.Add(this.EditContact);
            this.ContactBookTab.Controls.Add(this.SendToContact);
            this.ContactBookTab.Controls.Add(this.RemoveContact);
            this.ContactBookTab.Controls.Add(this.AddContact);
            this.ContactBookTab.Controls.Add(this.AddressGrid);
            this.ContactBookTab.ForeColor = System.Drawing.Color.Black;
            this.ContactBookTab.Location = new System.Drawing.Point(4, 4);
            this.ContactBookTab.Name = "ContactBookTab";
            this.ContactBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContactBookTab.Size = new System.Drawing.Size(595, 426);
            this.ContactBookTab.TabIndex = 4;
            this.ContactBookTab.Text = "Address Book";
            // 
            // EditContact
            // 
            this.EditContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditContact.Location = new System.Drawing.Point(218, 397);
            this.EditContact.Name = "EditContact";
            this.EditContact.Size = new System.Drawing.Size(100, 23);
            this.EditContact.TabIndex = 5;
            this.EditContact.Text = "Edit";
            this.EditContact.UseVisualStyleBackColor = true;
            this.EditContact.Click += new System.EventHandler(this.EditContact_Click);
            // 
            // SendToContact
            // 
            this.SendToContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendToContact.Location = new System.Drawing.Point(449, 397);
            this.SendToContact.Name = "SendToContact";
            this.SendToContact.Size = new System.Drawing.Size(140, 23);
            this.SendToContact.TabIndex = 3;
            this.SendToContact.Text = "Send Transaction";
            this.SendToContact.UseVisualStyleBackColor = true;
            this.SendToContact.Click += new System.EventHandler(this.SendToContact_Click);
            // 
            // RemoveContact
            // 
            this.RemoveContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContact.Location = new System.Drawing.Point(112, 397);
            this.RemoveContact.Name = "RemoveContact";
            this.RemoveContact.Size = new System.Drawing.Size(100, 23);
            this.RemoveContact.TabIndex = 2;
            this.RemoveContact.Text = "Remove";
            this.RemoveContact.UseVisualStyleBackColor = true;
            this.RemoveContact.Click += new System.EventHandler(this.RemoveContact_Click);
            // 
            // AddContact
            // 
            this.AddContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContact.Location = new System.Drawing.Point(6, 397);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(100, 23);
            this.AddContact.TabIndex = 1;
            this.AddContact.Text = "Add";
            this.AddContact.UseVisualStyleBackColor = true;
            this.AddContact.Click += new System.EventHandler(this.AddContact_Click);
            // 
            // AddressGrid
            // 
            this.AddressGrid.AllowUserToAddRows = false;
            this.AddressGrid.AllowUserToDeleteRows = false;
            this.AddressGrid.AllowUserToResizeRows = false;
            this.AddressGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AddressGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.AddressColumn,
            this.PaymentIDColumn});
            this.AddressGrid.ContextMenuStrip = this.AddressBookMenu;
            this.AddressGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddressGrid.Location = new System.Drawing.Point(6, 6);
            this.AddressGrid.MultiSelect = false;
            this.AddressGrid.Name = "AddressGrid";
            this.AddressGrid.ReadOnly = true;
            this.AddressGrid.RowHeadersVisible = false;
            this.AddressGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddressGrid.ShowCellErrors = false;
            this.AddressGrid.ShowCellToolTips = false;
            this.AddressGrid.ShowEditingIcon = false;
            this.AddressGrid.ShowRowErrors = false;
            this.AddressGrid.Size = new System.Drawing.Size(583, 385);
            this.AddressGrid.TabIndex = 0;
            this.AddressGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AddressGrid_CellMouseDoubleClick);
            this.AddressGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AddressGrid_CellMouseClick);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.FillWeight = 50F;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "Address";
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // PaymentIDColumn
            // 
            this.PaymentIDColumn.DataPropertyName = "PaymentID";
            this.PaymentIDColumn.FillWeight = 50F;
            this.PaymentIDColumn.HeaderText = "Payment ID";
            this.PaymentIDColumn.Name = "PaymentIDColumn";
            this.PaymentIDColumn.ReadOnly = true;
            // 
            // AddressBookMenu
            // 
            this.AddressBookMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddressMenuCopyAddress,
            this.AddressMenuEditAddress,
            this.toolStripSeparator1,
            this.AddressMenuSendTo});
            this.AddressBookMenu.Name = "AddressBookMenu";
            this.AddressBookMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AddressBookMenu.ShowImageMargin = false;
            this.AddressBookMenu.Size = new System.Drawing.Size(92, 76);
            // 
            // AddressMenuCopyAddress
            // 
            this.AddressMenuCopyAddress.Name = "AddressMenuCopyAddress";
            this.AddressMenuCopyAddress.Size = new System.Drawing.Size(91, 22);
            this.AddressMenuCopyAddress.Text = "Copy";
            this.AddressMenuCopyAddress.Click += new System.EventHandler(this.AddressMenuCopyAddress_Click);
            // 
            // AddressMenuEditAddress
            // 
            this.AddressMenuEditAddress.Name = "AddressMenuEditAddress";
            this.AddressMenuEditAddress.Size = new System.Drawing.Size(91, 22);
            this.AddressMenuEditAddress.Text = "Edit";
            this.AddressMenuEditAddress.Click += new System.EventHandler(this.EditContact_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(88, 6);
            // 
            // AddressMenuSendTo
            // 
            this.AddressMenuSendTo.Name = "AddressMenuSendTo";
            this.AddressMenuSendTo.Size = new System.Drawing.Size(91, 22);
            this.AddressMenuSendTo.Text = "Send To";
            this.AddressMenuSendTo.Click += new System.EventHandler(this.SendToContact_Click);
            // 
            // NetworkTab
            // 
            this.NetworkTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NetworkTab.Controls.Add(this.tableLayoutPanel4);
            this.NetworkTab.Controls.Add(this.tableLayoutPanel3);
            this.NetworkTab.ForeColor = System.Drawing.Color.Black;
            this.NetworkTab.Location = new System.Drawing.Point(4, 4);
            this.NetworkTab.Name = "NetworkTab";
            this.NetworkTab.Padding = new System.Windows.Forms.Padding(3);
            this.NetworkTab.Size = new System.Drawing.Size(595, 426);
            this.NetworkTab.TabIndex = 5;
            this.NetworkTab.Text = "Network";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 80);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(583, 340);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TransactionPool);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 121);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction Pool";
            // 
            // TransactionPool
            // 
            this.TransactionPool.AllowUserToAddRows = false;
            this.TransactionPool.AllowUserToDeleteRows = false;
            this.TransactionPool.AllowUserToResizeColumns = false;
            this.TransactionPool.AllowUserToResizeRows = false;
            this.TransactionPool.AutoGenerateColumns = false;
            this.TransactionPool.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransactionPool.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TransactionPool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionPool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionPool.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmountColumn,
            this.FeeColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.TransactionPool.DataSource = this.transactionPoolBindingSource;
            this.TransactionPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionPool.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TransactionPool.Location = new System.Drawing.Point(3, 16);
            this.TransactionPool.MultiSelect = false;
            this.TransactionPool.Name = "TransactionPool";
            this.TransactionPool.ReadOnly = true;
            this.TransactionPool.RowHeadersVisible = false;
            this.TransactionPool.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransactionPool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionPool.ShowCellErrors = false;
            this.TransactionPool.ShowCellToolTips = false;
            this.TransactionPool.ShowEditingIcon = false;
            this.TransactionPool.ShowRowErrors = false;
            this.TransactionPool.Size = new System.Drawing.Size(571, 102);
            this.TransactionPool.TabIndex = 1;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.FillWeight = 10F;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // FeeColumn
            // 
            this.FeeColumn.DataPropertyName = "Fee";
            this.FeeColumn.FillWeight = 10F;
            this.FeeColumn.HeaderText = "Fee";
            this.FeeColumn.Name = "FeeColumn";
            this.FeeColumn.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RecentBlocks);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(577, 207);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recent Blocks";
            // 
            // RecentBlocks
            // 
            this.RecentBlocks.AllowUserToAddRows = false;
            this.RecentBlocks.AllowUserToDeleteRows = false;
            this.RecentBlocks.AllowUserToResizeColumns = false;
            this.RecentBlocks.AllowUserToResizeRows = false;
            this.RecentBlocks.AutoGenerateColumns = false;
            this.RecentBlocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecentBlocks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RecentBlocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecentBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecentBlocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heightDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.hashDataGridViewTextBoxColumn,
            this.difficultyDataGridViewTextBoxColumn,
            this.transactionsDataGridViewTextBoxColumn});
            this.RecentBlocks.DataSource = this.recentBlocksBindingSource;
            this.RecentBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentBlocks.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.RecentBlocks.Location = new System.Drawing.Point(3, 16);
            this.RecentBlocks.MultiSelect = false;
            this.RecentBlocks.Name = "RecentBlocks";
            this.RecentBlocks.ReadOnly = true;
            this.RecentBlocks.RowHeadersVisible = false;
            this.RecentBlocks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecentBlocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecentBlocks.ShowCellErrors = false;
            this.RecentBlocks.ShowCellToolTips = false;
            this.RecentBlocks.ShowEditingIcon = false;
            this.RecentBlocks.ShowRowErrors = false;
            this.RecentBlocks.Size = new System.Drawing.Size(571, 188);
            this.RecentBlocks.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(583, 68);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TotalSupply);
            this.groupBox6.Controls.Add(this.TotalTransactions);
            this.groupBox6.Controls.Add(this.TotalBlocks);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(285, 62);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Statistics";
            // 
            // TotalSupply
            // 
            this.TotalSupply.AutoSize = true;
            this.TotalSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSupply.Location = new System.Drawing.Point(121, 29);
            this.TotalSupply.Name = "TotalSupply";
            this.TotalSupply.Size = new System.Drawing.Size(0, 13);
            this.TotalSupply.TabIndex = 5;
            // 
            // TotalTransactions
            // 
            this.TotalTransactions.AutoSize = true;
            this.TotalTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTransactions.Location = new System.Drawing.Point(121, 42);
            this.TotalTransactions.Name = "TotalTransactions";
            this.TotalTransactions.Size = new System.Drawing.Size(0, 13);
            this.TotalTransactions.TabIndex = 4;
            // 
            // TotalBlocks
            // 
            this.TotalBlocks.AutoSize = true;
            this.TotalBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBlocks.Location = new System.Drawing.Point(121, 16);
            this.TotalBlocks.Name = "TotalBlocks";
            this.TotalBlocks.Size = new System.Drawing.Size(0, 13);
            this.TotalBlocks.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Total Blocks:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Total Supply:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Total Transactions:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Difficulty);
            this.groupBox3.Controls.Add(this.Reward);
            this.groupBox3.Controls.Add(this.GlobalHashrate);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(294, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 62);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network";
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSize = true;
            this.Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficulty.Location = new System.Drawing.Point(121, 29);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(0, 13);
            this.Difficulty.TabIndex = 11;
            // 
            // Reward
            // 
            this.Reward.AutoSize = true;
            this.Reward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reward.Location = new System.Drawing.Point(121, 42);
            this.Reward.Name = "Reward";
            this.Reward.Size = new System.Drawing.Size(0, 13);
            this.Reward.TabIndex = 10;
            // 
            // GlobalHashrate
            // 
            this.GlobalHashrate.AutoSize = true;
            this.GlobalHashrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalHashrate.Location = new System.Drawing.Point(121, 16);
            this.GlobalHashrate.Name = "GlobalHashrate";
            this.GlobalHashrate.Size = new System.Drawing.Size(0, 13);
            this.GlobalHashrate.TabIndex = 9;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "Global Hashrate:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 13);
            this.label28.TabIndex = 8;
            this.label28.Text = "Difficulty:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 42);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "Current Reward:";
            // 
            // BlankTab
            // 
            this.BlankTab.Location = new System.Drawing.Point(4, 4);
            this.BlankTab.Name = "BlankTab";
            this.BlankTab.Padding = new System.Windows.Forms.Padding(3);
            this.BlankTab.Size = new System.Drawing.Size(595, 426);
            this.BlankTab.TabIndex = 7;
            this.BlankTab.Text = "Options";
            this.BlankTab.UseVisualStyleBackColor = true;
            // 
            // HeightStatus
            // 
            this.HeightStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightStatus.AutoSize = true;
            this.HeightStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.HeightStatus.Location = new System.Drawing.Point(3, 1);
            this.HeightStatus.Name = "HeightStatus";
            this.HeightStatus.Size = new System.Drawing.Size(22, 13);
            this.HeightStatus.TabIndex = 2;
            this.HeightStatus.Text = "-----";
            // 
            // ServerStatus
            // 
            this.ServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerStatus.AutoSize = true;
            this.ServerStatus.ForeColor = System.Drawing.Color.Blue;
            this.ServerStatus.Location = new System.Drawing.Point(515, 1);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(79, 13);
            this.ServerStatus.TabIndex = 3;
            this.ServerStatus.Text = "Not Connected";
            this.ServerStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SavePrivateKeys
            // 
            this.SavePrivateKeys.DefaultExt = "txt";
            this.SavePrivateKeys.FileName = "Keys.txt";
            this.SavePrivateKeys.Filter = "Text Files|*txt";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.Controls.Add(this.panel9);
            this.MenuPanel.Controls.Add(this.panel8);
            this.MenuPanel.Controls.Add(this.panel7);
            this.MenuPanel.Controls.Add(this.SyncPercent);
            this.MenuPanel.Controls.Add(this.panel6);
            this.MenuPanel.Controls.Add(this.SyncProgress);
            this.MenuPanel.Controls.Add(this.OptionsTabButton);
            this.MenuPanel.Controls.Add(this.NetworkTabButton);
            this.MenuPanel.Controls.Add(this.AddressBookTabButton);
            this.MenuPanel.Controls.Add(this.panel5);
            this.MenuPanel.Controls.Add(this.TransactionLogTabButton);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER2);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER1);
            this.MenuPanel.Controls.Add(this.WalletTabButton);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.LockedIcon);
            this.MenuPanel.Controls.Add(this.SendTabButton);
            this.MenuPanel.Controls.Add(this.label12);
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Controls.Add(this.BalanceBox);
            this.MenuPanel.Controls.Add(this.LockedBalanceBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(3, 3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(169, 455);
            this.MenuPanel.TabIndex = 25;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DarkGray;
            this.panel9.Location = new System.Drawing.Point(0, 310);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(169, 1);
            this.panel9.TabIndex = 40;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Location = new System.Drawing.Point(0, 278);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(169, 1);
            this.panel8.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(0, 247);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 1);
            this.panel7.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(0, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 1);
            this.panel6.TabIndex = 37;
            // 
            // OptionsTabButton
            // 
            this.OptionsTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsTabButton.BackColor = System.Drawing.Color.White;
            this.OptionsTabButton.ColumnCount = 2;
            this.OptionsTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.OptionsTabButton.Controls.Add(this.OptionsTabIcon, 1, 0);
            this.OptionsTabButton.Controls.Add(this.OptionsTabLabel, 0, 0);
            this.OptionsTabButton.Location = new System.Drawing.Point(0, 279);
            this.OptionsTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.OptionsTabButton.Name = "OptionsTabButton";
            this.OptionsTabButton.RowCount = 1;
            this.OptionsTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTabButton.Size = new System.Drawing.Size(169, 30);
            this.OptionsTabButton.TabIndex = 36;
            this.OptionsTabButton.Click += new System.EventHandler(this.MenuItemClicked);
            this.OptionsTabButton.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.OptionsTabButton.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // OptionsTabIcon
            // 
            this.OptionsTabIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTabIcon.Image = global::Shell_Wallet.Properties.Resources.OptionsBlack;
            this.OptionsTabIcon.Location = new System.Drawing.Point(140, 3);
            this.OptionsTabIcon.Name = "OptionsTabIcon";
            this.OptionsTabIcon.Size = new System.Drawing.Size(26, 24);
            this.OptionsTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OptionsTabIcon.TabIndex = 0;
            this.OptionsTabIcon.TabStop = false;
            this.OptionsTabIcon.Click += new System.EventHandler(this.MenuItemClicked);
            this.OptionsTabIcon.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.OptionsTabIcon.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // OptionsTabLabel
            // 
            this.OptionsTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.OptionsTabLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsTabLabel.Location = new System.Drawing.Point(3, 0);
            this.OptionsTabLabel.Name = "OptionsTabLabel";
            this.OptionsTabLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.OptionsTabLabel.Size = new System.Drawing.Size(131, 30);
            this.OptionsTabLabel.TabIndex = 1;
            this.OptionsTabLabel.Text = "Options";
            this.OptionsTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.OptionsTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.OptionsTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // NetworkTabButton
            // 
            this.NetworkTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkTabButton.BackColor = System.Drawing.Color.White;
            this.NetworkTabButton.ColumnCount = 2;
            this.NetworkTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NetworkTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.NetworkTabButton.Controls.Add(this.NetworkTabIcon, 1, 0);
            this.NetworkTabButton.Controls.Add(this.NetworkTabLabel, 0, 0);
            this.NetworkTabButton.Location = new System.Drawing.Point(0, 248);
            this.NetworkTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.NetworkTabButton.Name = "NetworkTabButton";
            this.NetworkTabButton.RowCount = 1;
            this.NetworkTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NetworkTabButton.Size = new System.Drawing.Size(169, 30);
            this.NetworkTabButton.TabIndex = 35;
            this.NetworkTabButton.Click += new System.EventHandler(this.MenuItemClicked);
            this.NetworkTabButton.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.NetworkTabButton.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // NetworkTabIcon
            // 
            this.NetworkTabIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetworkTabIcon.Image = global::Shell_Wallet.Properties.Resources.NetworkBlack;
            this.NetworkTabIcon.Location = new System.Drawing.Point(140, 3);
            this.NetworkTabIcon.Name = "NetworkTabIcon";
            this.NetworkTabIcon.Size = new System.Drawing.Size(26, 24);
            this.NetworkTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NetworkTabIcon.TabIndex = 0;
            this.NetworkTabIcon.TabStop = false;
            this.NetworkTabIcon.Click += new System.EventHandler(this.MenuItemClicked);
            this.NetworkTabIcon.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.NetworkTabIcon.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // NetworkTabLabel
            // 
            this.NetworkTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.NetworkTabLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetworkTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkTabLabel.Location = new System.Drawing.Point(3, 0);
            this.NetworkTabLabel.Name = "NetworkTabLabel";
            this.NetworkTabLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.NetworkTabLabel.Size = new System.Drawing.Size(131, 30);
            this.NetworkTabLabel.TabIndex = 1;
            this.NetworkTabLabel.Text = "Network";
            this.NetworkTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NetworkTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.NetworkTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.NetworkTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // AddressBookTabButton
            // 
            this.AddressBookTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBookTabButton.BackColor = System.Drawing.Color.White;
            this.AddressBookTabButton.ColumnCount = 2;
            this.AddressBookTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddressBookTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.AddressBookTabButton.Controls.Add(this.AddressBookTabIcon, 1, 0);
            this.AddressBookTabButton.Controls.Add(this.AddressBookTabLabel, 0, 0);
            this.AddressBookTabButton.Location = new System.Drawing.Point(0, 217);
            this.AddressBookTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddressBookTabButton.Name = "AddressBookTabButton";
            this.AddressBookTabButton.RowCount = 1;
            this.AddressBookTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddressBookTabButton.Size = new System.Drawing.Size(169, 30);
            this.AddressBookTabButton.TabIndex = 34;
            this.AddressBookTabButton.Click += new System.EventHandler(this.MenuItemClicked);
            this.AddressBookTabButton.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.AddressBookTabButton.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // AddressBookTabIcon
            // 
            this.AddressBookTabIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressBookTabIcon.Image = global::Shell_Wallet.Properties.Resources.AddressBookBlack;
            this.AddressBookTabIcon.Location = new System.Drawing.Point(140, 3);
            this.AddressBookTabIcon.Name = "AddressBookTabIcon";
            this.AddressBookTabIcon.Size = new System.Drawing.Size(26, 24);
            this.AddressBookTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddressBookTabIcon.TabIndex = 0;
            this.AddressBookTabIcon.TabStop = false;
            this.AddressBookTabIcon.Click += new System.EventHandler(this.MenuItemClicked);
            this.AddressBookTabIcon.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.AddressBookTabIcon.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // AddressBookTabLabel
            // 
            this.AddressBookTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressBookTabLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressBookTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBookTabLabel.Location = new System.Drawing.Point(3, 0);
            this.AddressBookTabLabel.Name = "AddressBookTabLabel";
            this.AddressBookTabLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.AddressBookTabLabel.Size = new System.Drawing.Size(131, 30);
            this.AddressBookTabLabel.TabIndex = 1;
            this.AddressBookTabLabel.Text = "Address Book";
            this.AddressBookTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddressBookTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.AddressBookTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.AddressBookTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(0, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 1);
            this.panel5.TabIndex = 33;
            // 
            // TransactionLogTabButton
            // 
            this.TransactionLogTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionLogTabButton.BackColor = System.Drawing.Color.White;
            this.TransactionLogTabButton.ColumnCount = 2;
            this.TransactionLogTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TransactionLogTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TransactionLogTabButton.Controls.Add(this.TransactionLogTabIcon, 1, 0);
            this.TransactionLogTabButton.Controls.Add(this.TransactionLogTabLabel, 0, 0);
            this.TransactionLogTabButton.Location = new System.Drawing.Point(0, 186);
            this.TransactionLogTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.TransactionLogTabButton.Name = "TransactionLogTabButton";
            this.TransactionLogTabButton.RowCount = 1;
            this.TransactionLogTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TransactionLogTabButton.Size = new System.Drawing.Size(169, 30);
            this.TransactionLogTabButton.TabIndex = 32;
            this.TransactionLogTabButton.Click += new System.EventHandler(this.MenuItemClicked);
            this.TransactionLogTabButton.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.TransactionLogTabButton.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // TransactionLogTabIcon
            // 
            this.TransactionLogTabIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionLogTabIcon.Image = global::Shell_Wallet.Properties.Resources.TransactionLogBlack;
            this.TransactionLogTabIcon.Location = new System.Drawing.Point(140, 3);
            this.TransactionLogTabIcon.Name = "TransactionLogTabIcon";
            this.TransactionLogTabIcon.Size = new System.Drawing.Size(26, 24);
            this.TransactionLogTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TransactionLogTabIcon.TabIndex = 0;
            this.TransactionLogTabIcon.TabStop = false;
            this.TransactionLogTabIcon.Click += new System.EventHandler(this.MenuItemClicked);
            this.TransactionLogTabIcon.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.TransactionLogTabIcon.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // TransactionLogTabLabel
            // 
            this.TransactionLogTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.TransactionLogTabLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionLogTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionLogTabLabel.Location = new System.Drawing.Point(3, 0);
            this.TransactionLogTabLabel.Name = "TransactionLogTabLabel";
            this.TransactionLogTabLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.TransactionLogTabLabel.Size = new System.Drawing.Size(131, 30);
            this.TransactionLogTabLabel.TabIndex = 1;
            this.TransactionLogTabLabel.Text = "Transaction Log";
            this.TransactionLogTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionLogTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.TransactionLogTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.TransactionLogTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // MENUDIVIDER2
            // 
            this.MENUDIVIDER2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENUDIVIDER2.BackColor = System.Drawing.Color.DarkGray;
            this.MENUDIVIDER2.Location = new System.Drawing.Point(0, 154);
            this.MENUDIVIDER2.Name = "MENUDIVIDER2";
            this.MENUDIVIDER2.Size = new System.Drawing.Size(169, 1);
            this.MENUDIVIDER2.TabIndex = 31;
            // 
            // MENUDIVIDER1
            // 
            this.MENUDIVIDER1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENUDIVIDER1.BackColor = System.Drawing.Color.DarkGray;
            this.MENUDIVIDER1.Location = new System.Drawing.Point(0, 123);
            this.MENUDIVIDER1.Name = "MENUDIVIDER1";
            this.MENUDIVIDER1.Size = new System.Drawing.Size(169, 1);
            this.MENUDIVIDER1.TabIndex = 30;
            // 
            // WalletTabButton
            // 
            this.WalletTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WalletTabButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WalletTabButton.ColumnCount = 2;
            this.WalletTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WalletTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.WalletTabButton.Controls.Add(this.WalletTabIcon, 1, 0);
            this.WalletTabButton.Controls.Add(this.WalletTabLabel, 0, 0);
            this.WalletTabButton.Location = new System.Drawing.Point(0, 124);
            this.WalletTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.WalletTabButton.Name = "WalletTabButton";
            this.WalletTabButton.RowCount = 1;
            this.WalletTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WalletTabButton.Size = new System.Drawing.Size(169, 30);
            this.WalletTabButton.TabIndex = 29;
            this.WalletTabButton.Click += new System.EventHandler(this.MenuItemClicked);
            this.WalletTabButton.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.WalletTabButton.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // WalletTabIcon
            // 
            this.WalletTabIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WalletTabIcon.Image = global::Shell_Wallet.Properties.Resources.WalletBlack;
            this.WalletTabIcon.Location = new System.Drawing.Point(140, 3);
            this.WalletTabIcon.Name = "WalletTabIcon";
            this.WalletTabIcon.Size = new System.Drawing.Size(26, 24);
            this.WalletTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WalletTabIcon.TabIndex = 0;
            this.WalletTabIcon.TabStop = false;
            this.WalletTabIcon.Click += new System.EventHandler(this.MenuItemClicked);
            this.WalletTabIcon.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.WalletTabIcon.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // WalletTabLabel
            // 
            this.WalletTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.WalletTabLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WalletTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletTabLabel.Location = new System.Drawing.Point(3, 0);
            this.WalletTabLabel.Name = "WalletTabLabel";
            this.WalletTabLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.WalletTabLabel.Size = new System.Drawing.Size(131, 30);
            this.WalletTabLabel.TabIndex = 1;
            this.WalletTabLabel.Text = "Wallet";
            this.WalletTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WalletTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.WalletTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.WalletTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Shell_Wallet.Properties.Resources.TurtlecoinLogo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // LockedIcon
            // 
            this.LockedIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LockedIcon.Image = global::Shell_Wallet.Properties.Resources.LockedBlack;
            this.LockedIcon.Location = new System.Drawing.Point(6, 97);
            this.LockedIcon.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.LockedIcon.Name = "LockedIcon";
            this.LockedIcon.Size = new System.Drawing.Size(16, 16);
            this.LockedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LockedIcon.TabIndex = 5;
            this.LockedIcon.TabStop = false;
            // 
            // SendTabButton
            // 
            this.SendTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTabButton.BackColor = System.Drawing.Color.White;
            this.SendTabButton.ColumnCount = 2;
            this.SendTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SendTabButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SendTabButton.Controls.Add(this.SendTabIcon, 1, 0);
            this.SendTabButton.Controls.Add(this.SendTabLabel, 0, 0);
            this.SendTabButton.Location = new System.Drawing.Point(0, 155);
            this.SendTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.SendTabButton.Name = "SendTabButton";
            this.SendTabButton.RowCount = 1;
            this.SendTabButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SendTabButton.Size = new System.Drawing.Size(169, 30);
            this.SendTabButton.TabIndex = 6;
            this.SendTabButton.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // SendTabIcon
            // 
            this.SendTabIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTabIcon.Image = ((System.Drawing.Image)(resources.GetObject("SendTabIcon.Image")));
            this.SendTabIcon.Location = new System.Drawing.Point(140, 3);
            this.SendTabIcon.Name = "SendTabIcon";
            this.SendTabIcon.Size = new System.Drawing.Size(26, 24);
            this.SendTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SendTabIcon.TabIndex = 0;
            this.SendTabIcon.TabStop = false;
            this.SendTabIcon.Click += new System.EventHandler(this.MenuItemClicked);
            this.SendTabIcon.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.SendTabIcon.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // SendTabLabel
            // 
            this.SendTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.SendTabLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTabLabel.Location = new System.Drawing.Point(3, 0);
            this.SendTabLabel.Name = "SendTabLabel";
            this.SendTabLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.SendTabLabel.Size = new System.Drawing.Size(131, 30);
            this.SendTabLabel.TabIndex = 1;
            this.SendTabLabel.Text = "Send";
            this.SendTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.SendTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.SendTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Turtlecoin";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindowTable
            // 
            this.MainWindowTable.ColumnCount = 2;
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTable.Controls.Add(this.RightSideTable, 1, 0);
            this.MainWindowTable.Controls.Add(this.MenuPanel, 0, 0);
            this.MainWindowTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTable.Location = new System.Drawing.Point(0, 24);
            this.MainWindowTable.Name = "MainWindowTable";
            this.MainWindowTable.RowCount = 1;
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainWindowTable.Size = new System.Drawing.Size(784, 461);
            this.MainWindowTable.TabIndex = 26;
            // 
            // RightSideTable
            // 
            this.RightSideTable.ColumnCount = 1;
            this.RightSideTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightSideTable.Controls.Add(this.FooterPanel, 0, 1);
            this.RightSideTable.Controls.Add(this.WalletTabs, 0, 0);
            this.RightSideTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSideTable.Location = new System.Drawing.Point(178, 3);
            this.RightSideTable.Name = "RightSideTable";
            this.RightSideTable.RowCount = 2;
            this.RightSideTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightSideTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RightSideTable.Size = new System.Drawing.Size(603, 455);
            this.RightSideTable.TabIndex = 27;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.HeightStatus);
            this.FooterPanel.Controls.Add(this.ServerStatus);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterPanel.Location = new System.Drawing.Point(3, 438);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(597, 14);
            this.FooterPanel.TabIndex = 28;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.FillWeight = 80F;
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "Date";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.FillWeight = 50F;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            this.feeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            this.feeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hashDataGridViewTextBoxColumn1
            // 
            this.hashDataGridViewTextBoxColumn1.DataPropertyName = "Hash";
            this.hashDataGridViewTextBoxColumn1.FillWeight = 200F;
            this.hashDataGridViewTextBoxColumn1.HeaderText = "Hash";
            this.hashDataGridViewTextBoxColumn1.Name = "hashDataGridViewTextBoxColumn1";
            this.hashDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(RPCWrapper.Transaction);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn3.FillWeight = 10F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hash";
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Hash";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // transactionPoolBindingSource
            // 
            this.transactionPoolBindingSource.DataSource = typeof(RPCWrapper.RecentBlocks);
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.FillWeight = 10F;
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 30F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.FillWeight = 10F;
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hashDataGridViewTextBoxColumn
            // 
            this.hashDataGridViewTextBoxColumn.DataPropertyName = "Hash";
            this.hashDataGridViewTextBoxColumn.FillWeight = 50F;
            this.hashDataGridViewTextBoxColumn.HeaderText = "Hash";
            this.hashDataGridViewTextBoxColumn.Name = "hashDataGridViewTextBoxColumn";
            this.hashDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // difficultyDataGridViewTextBoxColumn
            // 
            this.difficultyDataGridViewTextBoxColumn.DataPropertyName = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.FillWeight = 15F;
            this.difficultyDataGridViewTextBoxColumn.HeaderText = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.Name = "difficultyDataGridViewTextBoxColumn";
            this.difficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionsDataGridViewTextBoxColumn
            // 
            this.transactionsDataGridViewTextBoxColumn.DataPropertyName = "Transactions";
            this.transactionsDataGridViewTextBoxColumn.FillWeight = 20F;
            this.transactionsDataGridViewTextBoxColumn.HeaderText = "Transactions";
            this.transactionsDataGridViewTextBoxColumn.Name = "transactionsDataGridViewTextBoxColumn";
            this.transactionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recentBlocksBindingSource
            // 
            this.recentBlocksBindingSource.DataSource = typeof(RPCWrapper.RecentBlocks);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.MainWindowTable);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 524);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell Wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.SendTab.ResumeLayout(false);
            this.SendTab.PerformLayout();
            this.WalletTab.ResumeLayout(false);
            this.WalletTab.PerformLayout();
            this.SelectedAddressInfo.ResumeLayout(false);
            this.SelectedAddressInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.WalletTabs.ResumeLayout(false);
            this.TransactonLogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLog)).EndInit();
            this.ContactBookTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).EndInit();
            this.AddressBookMenu.ResumeLayout(false);
            this.NetworkTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionPool)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecentBlocks)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.OptionsTabButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OptionsTabIcon)).EndInit();
            this.NetworkTabButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NetworkTabIcon)).EndInit();
            this.AddressBookTabButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddressBookTabIcon)).EndInit();
            this.TransactionLogTabButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLogTabIcon)).EndInit();
            this.WalletTabButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WalletTabIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockedIcon)).EndInit();
            this.SendTabButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SendTabIcon)).EndInit();
            this.MainWindowTable.ResumeLayout(false);
            this.RightSideTable.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionPoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentBlocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem WalletMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenWalletMenuOption;
        private System.Windows.Forms.ToolStripMenuItem ImportWalletMenuOption;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CloseWalletMenuOption;
        private System.Windows.Forms.OpenFileDialog OpenWalletDialog;
        private System.Windows.Forms.ToolStripMenuItem CreateWalletMenuOption;
        private System.Windows.Forms.SaveFileDialog NewWalletDialog;
        private System.Windows.Forms.OpenFileDialog OpenServerPath;
        private System.Windows.Forms.TabPage SendTab;
        private System.Windows.Forms.TabPage WalletTab;
        private System.Windows.Forms.TextBox LockedBalanceBox;
        private System.Windows.Forms.TextBox BalanceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl WalletTabs;
        private System.Windows.Forms.Label HeightStatus;
        private System.Windows.Forms.Label ServerStatus;
        private System.Windows.Forms.Button SendTransaction;
        private System.Windows.Forms.TextBox PaymentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Fee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountToSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SendToAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TransactionOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage ContactBookTab;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Button CopyAddress;
        private System.Windows.Forms.TextBox ExtraBox;
        private System.Windows.Forms.TextBox Mixin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ChangeAddress;
        private System.Windows.Forms.TextBox UnlockTime;
        private System.Windows.Forms.Label ChangeAddressLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar SyncProgress;
        private System.Windows.Forms.Label SyncPercent;
        private System.Windows.Forms.DataGridView AddressGrid;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.Button SendToContact;
        private System.Windows.Forms.Button RemoveContact;
        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuOption;
        private System.Windows.Forms.Button EditContact;
        private System.Windows.Forms.ComboBox WalletAddresses;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ChangeAddressOptional;
        private System.Windows.Forms.TextBox SelectedLockedBalanceBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox SelectedBalanceBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button DeleteSelectedAddress;
        private System.Windows.Forms.Button CreateNewAddress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox SendFromAddress;
        private System.Windows.Forms.ToolStripMenuItem OpenDefaultMenuOption;
        private System.Windows.Forms.SaveFileDialog SavePrivateKeys;
        private System.Windows.Forms.ContextMenuStrip AddressBookMenu;
        private System.Windows.Forms.ToolStripMenuItem AddressMenuCopyAddress;
        private System.Windows.Forms.ToolStripMenuItem AddressMenuEditAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddressMenuSendTo;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentIDColumn;
        private System.Windows.Forms.TabPage NetworkTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Label Reward;
        private System.Windows.Forms.Label GlobalHashrate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label TotalSupply;
        private System.Windows.Forms.Label TotalTransactions;
        private System.Windows.Forms.Label TotalBlocks;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView RecentBlocks;
        private System.Windows.Forms.BindingSource transactionPoolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TransactionPool;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem NetworkMenu;
        private System.Windows.Forms.ToolStripMenuItem StartNetworkMenuOption;
        private System.Windows.Forms.ToolStripMenuItem ExportPrivateKeysMenuOption;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuOption;
        private System.Windows.Forms.ToolStripMenuItem CloseNetworkMenuOption;
        private System.Windows.Forms.BindingSource recentBlocksBindingSource;
        private System.Windows.Forms.ToolStripMenuItem ResyncMenuOption;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMobileServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMobileServerToolStripMenuItem;
        private System.Windows.Forms.TabPage TransactonLogTab;
        private System.Windows.Forms.DataGridView TransactionLog;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem ConnectRemoteRPC;
        private System.Windows.Forms.OpenFileDialog OpenImportFile;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox LockedIcon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel SendTabButton;
        private System.Windows.Forms.PictureBox SendTabIcon;
        private System.Windows.Forms.Label SendTabLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel WalletTabButton;
        private System.Windows.Forms.PictureBox WalletTabIcon;
        private System.Windows.Forms.Label WalletTabLabel;
        private System.Windows.Forms.Panel MENUDIVIDER1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel TransactionLogTabButton;
        private System.Windows.Forms.PictureBox TransactionLogTabIcon;
        private System.Windows.Forms.Label TransactionLogTabLabel;
        private System.Windows.Forms.Panel MENUDIVIDER2;
        private System.Windows.Forms.TabPage BlankTab;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel OptionsTabButton;
        private System.Windows.Forms.PictureBox OptionsTabIcon;
        private System.Windows.Forms.Label OptionsTabLabel;
        private System.Windows.Forms.TableLayoutPanel NetworkTabButton;
        private System.Windows.Forms.PictureBox NetworkTabIcon;
        private System.Windows.Forms.Label NetworkTabLabel;
        private System.Windows.Forms.TableLayoutPanel AddressBookTabButton;
        private System.Windows.Forms.PictureBox AddressBookTabIcon;
        private System.Windows.Forms.Label AddressBookTabLabel;
        private System.Windows.Forms.TableLayoutPanel MainWindowTable;
        private System.Windows.Forms.TableLayoutPanel RightSideTable;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ChangeNickname;
        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button ShowKeysButton;
        private System.Windows.Forms.TextBox PrivateSpendKey;
        private System.Windows.Forms.TextBox PublicSpendKey;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox SelectedAddressInfo;
        private System.Windows.Forms.TextBox AddressDisplay;
        private System.Windows.Forms.Label label13;
    }
}

