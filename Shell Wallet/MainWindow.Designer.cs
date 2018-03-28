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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWalletDialog = new System.Windows.Forms.OpenFileDialog();
            this.NewWalletDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenServerPath = new System.Windows.Forms.OpenFileDialog();
            this.SendTab = new System.Windows.Forms.TabPage();
            this.SendTabScrollPanel = new System.Windows.Forms.Panel();
            this.SendTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SendOutputLabel = new System.Windows.Forms.Label();
            this.TransactionOutput = new System.Windows.Forms.TextBox();
            this.SendTransaction = new System.Windows.Forms.Button();
            this.QuickSendPanel = new System.Windows.Forms.Panel();
            this.AmountFeeTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxSizer2 = new System.Windows.Forms.Panel();
            this.AmountToSend = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxSizer3 = new System.Windows.Forms.Panel();
            this.Fee = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.ChangeAddressLabel = new System.Windows.Forms.Label();
            this.ShowAdvancedSendLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxSizer4 = new System.Windows.Forms.Panel();
            this.ChangeAddress = new System.Windows.Forms.TextBox();
            this.ChangeAddressOptional = new System.Windows.Forms.Label();
            this.TextBoxSizer1 = new System.Windows.Forms.Panel();
            this.SendToAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ComboBoxSizer1 = new System.Windows.Forms.Panel();
            this.SendFromAddress = new System.Windows.Forms.ComboBox();
            this.AdvancedSendPanel = new System.Windows.Forms.Panel();
            this.UnlockTimeMixinTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxSizer7 = new System.Windows.Forms.Panel();
            this.UnlockTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxSizer8 = new System.Windows.Forms.Panel();
            this.Mixin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxSizer6 = new System.Windows.Forms.Panel();
            this.ExtraBox = new System.Windows.Forms.TextBox();
            this.TextBoxSizer5 = new System.Windows.Forms.Panel();
            this.PaymentID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.WalletTab = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ChangeNickname = new System.Windows.Forms.Button();
            this.PrivateSpendKey = new System.Windows.Forms.TextBox();
            this.CopyAddress = new System.Windows.Forms.Button();
            this.ShowKeysButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TextBoxSizer9 = new System.Windows.Forms.Panel();
            this.AddressDisplay = new System.Windows.Forms.TextBox();
            this.ComboBoxSizer2 = new System.Windows.Forms.Panel();
            this.WalletAddresses = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.PublicSpendKey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SelectedLockedBalanceBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.SelectedBalanceBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteSelectedAddress = new System.Windows.Forms.Button();
            this.CreateNewAddress = new System.Windows.Forms.Button();
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
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionPoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RecentBlocks = new System.Windows.Forms.DataGridView();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recentBlocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.OptionsTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsTabIcon = new System.Windows.Forms.PictureBox();
            this.OptionsTabLabel = new System.Windows.Forms.Label();
            this.NetworkTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.NetworkTabIcon = new System.Windows.Forms.PictureBox();
            this.NetworkTabLabel = new System.Windows.Forms.Label();
            this.AddressBookTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.AddressBookTabIcon = new System.Windows.Forms.PictureBox();
            this.AddressBookTabLabel = new System.Windows.Forms.Label();
            this.TransactionLogTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.TransactionLogTabIcon = new System.Windows.Forms.PictureBox();
            this.TransactionLogTabLabel = new System.Windows.Forms.Label();
            this.WalletTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.WalletTabIcon = new System.Windows.Forms.PictureBox();
            this.WalletTabLabel = new System.Windows.Forms.Label();
            this.SendTabButton = new System.Windows.Forms.TableLayoutPanel();
            this.SendTabIcon = new System.Windows.Forms.PictureBox();
            this.SendTabLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.LockedIcon = new System.Windows.Forms.PictureBox();
            this.OpenImportFile = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MENUDIVIDER6 = new System.Windows.Forms.Panel();
            this.MENUDIVIDER5 = new System.Windows.Forms.Panel();
            this.MENUDIVIDER4 = new System.Windows.Forms.Panel();
            this.MENUDIVIDER7 = new System.Windows.Forms.Panel();
            this.MENUDIVIDER3 = new System.Windows.Forms.Panel();
            this.MENUDIVIDER2 = new System.Windows.Forms.Panel();
            this.MENUDIVIDER1 = new System.Windows.Forms.Panel();
            this.MainWindowTable = new System.Windows.Forms.TableLayoutPanel();
            this.RightSideTable = new System.Windows.Forms.TableLayoutPanel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.SendTab.SuspendLayout();
            this.SendTabScrollPanel.SuspendLayout();
            this.SendTabLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.QuickSendPanel.SuspendLayout();
            this.AmountFeeTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TextBoxSizer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TextBoxSizer3.SuspendLayout();
            this.TextBoxSizer4.SuspendLayout();
            this.TextBoxSizer1.SuspendLayout();
            this.ComboBoxSizer1.SuspendLayout();
            this.AdvancedSendPanel.SuspendLayout();
            this.UnlockTimeMixinTable.SuspendLayout();
            this.panel4.SuspendLayout();
            this.TextBoxSizer7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TextBoxSizer8.SuspendLayout();
            this.TextBoxSizer6.SuspendLayout();
            this.TextBoxSizer5.SuspendLayout();
            this.WalletTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.TextBoxSizer9.SuspendLayout();
            this.ComboBoxSizer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.WalletTabs.SuspendLayout();
            this.TransactonLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.ContactBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).BeginInit();
            this.AddressBookMenu.SuspendLayout();
            this.NetworkTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionPool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionPoolBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecentBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentBlocksBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.SendTabButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendTabIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockedIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.MainWindowTable.SuspendLayout();
            this.RightSideTable.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WalletMenu,
            this.NetworkMenu,
            this.mobileToolStripMenuItem,
            this.aboutToolStripMenuItem});
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutShellWalletToolStripMenuItem_Click);
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
            this.SendTab.Controls.Add(this.SendTabScrollPanel);
            this.SendTab.ForeColor = System.Drawing.Color.Black;
            this.SendTab.Location = new System.Drawing.Point(4, 4);
            this.SendTab.Name = "SendTab";
            this.SendTab.Padding = new System.Windows.Forms.Padding(6);
            this.SendTab.Size = new System.Drawing.Size(601, 432);
            this.SendTab.TabIndex = 2;
            this.SendTab.Text = "Send";
            // 
            // SendTabScrollPanel
            // 
            this.SendTabScrollPanel.AutoScroll = true;
            this.SendTabScrollPanel.Controls.Add(this.SendTabLayout);
            this.SendTabScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTabScrollPanel.Location = new System.Drawing.Point(6, 6);
            this.SendTabScrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SendTabScrollPanel.Name = "SendTabScrollPanel";
            this.SendTabScrollPanel.Size = new System.Drawing.Size(589, 420);
            this.SendTabScrollPanel.TabIndex = 23;
            // 
            // SendTabLayout
            // 
            this.SendTabLayout.ColumnCount = 1;
            this.SendTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SendTabLayout.Controls.Add(this.panel1, 0, 2);
            this.SendTabLayout.Controls.Add(this.QuickSendPanel, 0, 0);
            this.SendTabLayout.Controls.Add(this.AdvancedSendPanel, 0, 1);
            this.SendTabLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.SendTabLayout.Location = new System.Drawing.Point(0, 0);
            this.SendTabLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SendTabLayout.Name = "SendTabLayout";
            this.SendTabLayout.RowCount = 3;
            this.SendTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.SendTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.SendTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SendTabLayout.Size = new System.Drawing.Size(572, 575);
            this.SendTabLayout.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SendOutputLabel);
            this.panel1.Controls.Add(this.TransactionOutput);
            this.panel1.Controls.Add(this.SendTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 150);
            this.panel1.TabIndex = 37;
            // 
            // SendOutputLabel
            // 
            this.SendOutputLabel.AutoSize = true;
            this.SendOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendOutputLabel.Location = new System.Drawing.Point(3, 21);
            this.SendOutputLabel.Name = "SendOutputLabel";
            this.SendOutputLabel.Size = new System.Drawing.Size(57, 17);
            this.SendOutputLabel.TabIndex = 34;
            this.SendOutputLabel.Text = "Output";
            // 
            // TransactionOutput
            // 
            this.TransactionOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionOutput.Location = new System.Drawing.Point(6, 38);
            this.TransactionOutput.Multiline = true;
            this.TransactionOutput.Name = "TransactionOutput";
            this.TransactionOutput.ReadOnly = true;
            this.TransactionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransactionOutput.Size = new System.Drawing.Size(557, 100);
            this.TransactionOutput.TabIndex = 10;
            // 
            // SendTransaction
            // 
            this.SendTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTransaction.Enabled = false;
            this.SendTransaction.Location = new System.Drawing.Point(413, 0);
            this.SendTransaction.Name = "SendTransaction";
            this.SendTransaction.Size = new System.Drawing.Size(150, 32);
            this.SendTransaction.TabIndex = 9;
            this.SendTransaction.Text = "Send Transaction";
            this.SendTransaction.UseVisualStyleBackColor = true;
            this.SendTransaction.Click += new System.EventHandler(this.SendTransaction_Click);
            // 
            // QuickSendPanel
            // 
            this.QuickSendPanel.Controls.Add(this.AmountFeeTable);
            this.QuickSendPanel.Controls.Add(this.label30);
            this.QuickSendPanel.Controls.Add(this.ChangeAddressLabel);
            this.QuickSendPanel.Controls.Add(this.ShowAdvancedSendLabel);
            this.QuickSendPanel.Controls.Add(this.label4);
            this.QuickSendPanel.Controls.Add(this.TextBoxSizer4);
            this.QuickSendPanel.Controls.Add(this.ChangeAddressOptional);
            this.QuickSendPanel.Controls.Add(this.TextBoxSizer1);
            this.QuickSendPanel.Controls.Add(this.label20);
            this.QuickSendPanel.Controls.Add(this.ComboBoxSizer1);
            this.QuickSendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuickSendPanel.Location = new System.Drawing.Point(0, 0);
            this.QuickSendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.QuickSendPanel.Name = "QuickSendPanel";
            this.QuickSendPanel.Size = new System.Drawing.Size(572, 260);
            this.QuickSendPanel.TabIndex = 0;
            // 
            // AmountFeeTable
            // 
            this.AmountFeeTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountFeeTable.ColumnCount = 2;
            this.AmountFeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AmountFeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AmountFeeTable.Controls.Add(this.panel2, 0, 0);
            this.AmountFeeTable.Controls.Add(this.panel3, 1, 0);
            this.AmountFeeTable.Location = new System.Drawing.Point(6, 129);
            this.AmountFeeTable.Name = "AmountFeeTable";
            this.AmountFeeTable.RowCount = 1;
            this.AmountFeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AmountFeeTable.Size = new System.Drawing.Size(560, 48);
            this.AmountFeeTable.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TextBoxSizer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 48);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount";
            // 
            // TextBoxSizer2
            // 
            this.TextBoxSizer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer2.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer2.Controls.Add(this.AmountToSend);
            this.TextBoxSizer2.Location = new System.Drawing.Point(0, 16);
            this.TextBoxSizer2.Name = "TextBoxSizer2";
            this.TextBoxSizer2.Size = new System.Drawing.Size(277, 32);
            this.TextBoxSizer2.TabIndex = 26;
            // 
            // AmountToSend
            // 
            this.AmountToSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountToSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountToSend.Location = new System.Drawing.Point(6, 9);
            this.AmountToSend.Name = "AmountToSend";
            this.AmountToSend.Size = new System.Drawing.Size(263, 13);
            this.AmountToSend.TabIndex = 2;
            this.AmountToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalNumberOnly);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TextBoxSizer3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 48);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fee";
            // 
            // TextBoxSizer3
            // 
            this.TextBoxSizer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer3.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer3.Controls.Add(this.Fee);
            this.TextBoxSizer3.Location = new System.Drawing.Point(3, 16);
            this.TextBoxSizer3.Name = "TextBoxSizer3";
            this.TextBoxSizer3.Size = new System.Drawing.Size(277, 32);
            this.TextBoxSizer3.TabIndex = 27;
            // 
            // Fee
            // 
            this.Fee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fee.Location = new System.Drawing.Point(6, 9);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(263, 13);
            this.Fee.TabIndex = 3;
            this.Fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalNumberOnly);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 17);
            this.label30.TabIndex = 23;
            this.label30.Text = "Quick Send";
            // 
            // ChangeAddressLabel
            // 
            this.ChangeAddressLabel.AutoSize = true;
            this.ChangeAddressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeAddressLabel.Location = new System.Drawing.Point(3, 181);
            this.ChangeAddressLabel.Name = "ChangeAddressLabel";
            this.ChangeAddressLabel.Size = new System.Drawing.Size(85, 13);
            this.ChangeAddressLabel.TabIndex = 16;
            this.ChangeAddressLabel.Text = "Change Address";
            // 
            // ShowAdvancedSendLabel
            // 
            this.ShowAdvancedSendLabel.AutoSize = true;
            this.ShowAdvancedSendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAdvancedSendLabel.ForeColor = System.Drawing.Color.Black;
            this.ShowAdvancedSendLabel.Location = new System.Drawing.Point(3, 236);
            this.ShowAdvancedSendLabel.Name = "ShowAdvancedSendLabel";
            this.ShowAdvancedSendLabel.Size = new System.Drawing.Size(138, 17);
            this.ShowAdvancedSendLabel.TabIndex = 29;
            this.ShowAdvancedSendLabel.Text = "(+Hide Advanced)";
            this.ShowAdvancedSendLabel.Click += new System.EventHandler(this.ShowHideAdvancedSend);
            this.ShowAdvancedSendLabel.MouseEnter += new System.EventHandler(this.label31_MouseEnter);
            this.ShowAdvancedSendLabel.MouseLeave += new System.EventHandler(this.label31_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Send To";
            // 
            // TextBoxSizer4
            // 
            this.TextBoxSizer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer4.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer4.Controls.Add(this.ChangeAddress);
            this.TextBoxSizer4.Location = new System.Drawing.Point(6, 196);
            this.TextBoxSizer4.Name = "TextBoxSizer4";
            this.TextBoxSizer4.Size = new System.Drawing.Size(560, 32);
            this.TextBoxSizer4.TabIndex = 28;
            // 
            // ChangeAddress
            // 
            this.ChangeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeAddress.Location = new System.Drawing.Point(6, 9);
            this.ChangeAddress.Name = "ChangeAddress";
            this.ChangeAddress.Size = new System.Drawing.Size(546, 13);
            this.ChangeAddress.TabIndex = 6;
            // 
            // ChangeAddressOptional
            // 
            this.ChangeAddressOptional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeAddressOptional.AutoSize = true;
            this.ChangeAddressOptional.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeAddressOptional.Location = new System.Drawing.Point(514, 181);
            this.ChangeAddressOptional.Name = "ChangeAddressOptional";
            this.ChangeAddressOptional.Size = new System.Drawing.Size(52, 13);
            this.ChangeAddressOptional.TabIndex = 17;
            this.ChangeAddressOptional.Text = "(Optional)";
            // 
            // TextBoxSizer1
            // 
            this.TextBoxSizer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer1.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer1.Controls.Add(this.SendToAddress);
            this.TextBoxSizer1.Location = new System.Drawing.Point(6, 94);
            this.TextBoxSizer1.Name = "TextBoxSizer1";
            this.TextBoxSizer1.Size = new System.Drawing.Size(560, 32);
            this.TextBoxSizer1.TabIndex = 25;
            // 
            // SendToAddress
            // 
            this.SendToAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendToAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendToAddress.Location = new System.Drawing.Point(6, 9);
            this.SendToAddress.Name = "SendToAddress";
            this.SendToAddress.Size = new System.Drawing.Size(546, 13);
            this.SendToAddress.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Send From";
            // 
            // ComboBoxSizer1
            // 
            this.ComboBoxSizer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSizer1.BackColor = System.Drawing.Color.White;
            this.ComboBoxSizer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxSizer1.Controls.Add(this.SendFromAddress);
            this.ComboBoxSizer1.Location = new System.Drawing.Point(6, 43);
            this.ComboBoxSizer1.Name = "ComboBoxSizer1";
            this.ComboBoxSizer1.Size = new System.Drawing.Size(560, 32);
            this.ComboBoxSizer1.TabIndex = 24;
            // 
            // SendFromAddress
            // 
            this.SendFromAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendFromAddress.BackColor = System.Drawing.Color.White;
            this.SendFromAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendFromAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendFromAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendFromAddress.FormattingEnabled = true;
            this.SendFromAddress.Items.AddRange(new object[] {
            "Entire Balance"});
            this.SendFromAddress.Location = new System.Drawing.Point(6, 3);
            this.SendFromAddress.Margin = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.SendFromAddress.Name = "SendFromAddress";
            this.SendFromAddress.Size = new System.Drawing.Size(546, 24);
            this.SendFromAddress.TabIndex = 0;
            this.SendFromAddress.SelectedIndexChanged += new System.EventHandler(this.SendFromAddress_SelectedIndexChanged);
            this.SendFromAddress.SelectedValueChanged += new System.EventHandler(this.SendFromAddress_SelectedValueChanged);
            // 
            // AdvancedSendPanel
            // 
            this.AdvancedSendPanel.Controls.Add(this.UnlockTimeMixinTable);
            this.AdvancedSendPanel.Controls.Add(this.label7);
            this.AdvancedSendPanel.Controls.Add(this.label9);
            this.AdvancedSendPanel.Controls.Add(this.label17);
            this.AdvancedSendPanel.Controls.Add(this.TextBoxSizer6);
            this.AdvancedSendPanel.Controls.Add(this.TextBoxSizer5);
            this.AdvancedSendPanel.Controls.Add(this.label15);
            this.AdvancedSendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvancedSendPanel.Location = new System.Drawing.Point(0, 260);
            this.AdvancedSendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AdvancedSendPanel.Name = "AdvancedSendPanel";
            this.AdvancedSendPanel.Size = new System.Drawing.Size(572, 159);
            this.AdvancedSendPanel.TabIndex = 35;
            // 
            // UnlockTimeMixinTable
            // 
            this.UnlockTimeMixinTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnlockTimeMixinTable.ColumnCount = 2;
            this.UnlockTimeMixinTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnlockTimeMixinTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnlockTimeMixinTable.Controls.Add(this.panel4, 0, 0);
            this.UnlockTimeMixinTable.Controls.Add(this.panel5, 1, 0);
            this.UnlockTimeMixinTable.Location = new System.Drawing.Point(6, 105);
            this.UnlockTimeMixinTable.Name = "UnlockTimeMixinTable";
            this.UnlockTimeMixinTable.RowCount = 1;
            this.UnlockTimeMixinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnlockTimeMixinTable.Size = new System.Drawing.Size(560, 48);
            this.UnlockTimeMixinTable.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.TextBoxSizer7);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 48);
            this.panel4.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Unlock Time";
            // 
            // TextBoxSizer7
            // 
            this.TextBoxSizer7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer7.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer7.Controls.Add(this.UnlockTime);
            this.TextBoxSizer7.Location = new System.Drawing.Point(0, 16);
            this.TextBoxSizer7.Name = "TextBoxSizer7";
            this.TextBoxSizer7.Size = new System.Drawing.Size(277, 32);
            this.TextBoxSizer7.TabIndex = 32;
            // 
            // UnlockTime
            // 
            this.UnlockTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnlockTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnlockTime.Location = new System.Drawing.Point(6, 9);
            this.UnlockTime.Name = "UnlockTime";
            this.UnlockTime.Size = new System.Drawing.Size(263, 13);
            this.UnlockTime.TabIndex = 5;
            this.UnlockTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(228, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "(Optional)";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.TextBoxSizer8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(280, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 48);
            this.panel5.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mixin";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(228, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "(Optional)";
            // 
            // TextBoxSizer8
            // 
            this.TextBoxSizer8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer8.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer8.Controls.Add(this.Mixin);
            this.TextBoxSizer8.Location = new System.Drawing.Point(3, 16);
            this.TextBoxSizer8.Name = "TextBoxSizer8";
            this.TextBoxSizer8.Size = new System.Drawing.Size(277, 32);
            this.TextBoxSizer8.TabIndex = 33;
            // 
            // Mixin
            // 
            this.Mixin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mixin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mixin.Location = new System.Drawing.Point(6, 9);
            this.Mixin.Name = "Mixin";
            this.Mixin.Size = new System.Drawing.Size(263, 13);
            this.Mixin.TabIndex = 7;
            this.Mixin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payment ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(3, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Extra";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(514, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "(Optional)";
            // 
            // TextBoxSizer6
            // 
            this.TextBoxSizer6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer6.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer6.Controls.Add(this.ExtraBox);
            this.TextBoxSizer6.Location = new System.Drawing.Point(6, 70);
            this.TextBoxSizer6.Name = "TextBoxSizer6";
            this.TextBoxSizer6.Size = new System.Drawing.Size(560, 32);
            this.TextBoxSizer6.TabIndex = 31;
            // 
            // ExtraBox
            // 
            this.ExtraBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtraBox.Location = new System.Drawing.Point(6, 9);
            this.ExtraBox.Name = "ExtraBox";
            this.ExtraBox.Size = new System.Drawing.Size(546, 13);
            this.ExtraBox.TabIndex = 8;
            // 
            // TextBoxSizer5
            // 
            this.TextBoxSizer5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer5.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer5.Controls.Add(this.PaymentID);
            this.TextBoxSizer5.Location = new System.Drawing.Point(6, 19);
            this.TextBoxSizer5.Name = "TextBoxSizer5";
            this.TextBoxSizer5.Size = new System.Drawing.Size(560, 32);
            this.TextBoxSizer5.TabIndex = 30;
            // 
            // PaymentID
            // 
            this.PaymentID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentID.Location = new System.Drawing.Point(6, 9);
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Size = new System.Drawing.Size(546, 13);
            this.PaymentID.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(514, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "(Optional)";
            // 
            // WalletTab
            // 
            this.WalletTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WalletTab.Controls.Add(this.pictureBox4);
            this.WalletTab.Controls.Add(this.ChangeNickname);
            this.WalletTab.Controls.Add(this.PrivateSpendKey);
            this.WalletTab.Controls.Add(this.CopyAddress);
            this.WalletTab.Controls.Add(this.ShowKeysButton);
            this.WalletTab.Controls.Add(this.label8);
            this.WalletTab.Controls.Add(this.label18);
            this.WalletTab.Controls.Add(this.TextBoxSizer9);
            this.WalletTab.Controls.Add(this.ComboBoxSizer2);
            this.WalletTab.Controls.Add(this.label25);
            this.WalletTab.Controls.Add(this.PublicSpendKey);
            this.WalletTab.Controls.Add(this.label19);
            this.WalletTab.Controls.Add(this.label26);
            this.WalletTab.Controls.Add(this.SelectedLockedBalanceBox);
            this.WalletTab.Controls.Add(this.pictureBox2);
            this.WalletTab.Controls.Add(this.label24);
            this.WalletTab.Controls.Add(this.Nickname);
            this.WalletTab.Controls.Add(this.SelectedBalanceBox);
            this.WalletTab.Controls.Add(this.label13);
            this.WalletTab.Controls.Add(this.DeleteSelectedAddress);
            this.WalletTab.Controls.Add(this.CreateNewAddress);
            this.WalletTab.Controls.Add(this.label1);
            this.WalletTab.ForeColor = System.Drawing.Color.Black;
            this.WalletTab.Location = new System.Drawing.Point(4, 4);
            this.WalletTab.Margin = new System.Windows.Forms.Padding(0);
            this.WalletTab.Name = "WalletTab";
            this.WalletTab.Padding = new System.Windows.Forms.Padding(6);
            this.WalletTab.Size = new System.Drawing.Size(601, 432);
            this.WalletTab.TabIndex = 0;
            this.WalletTab.Text = "Wallet";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Shell_Wallet.Properties.Resources.ShellBlack;
            this.pictureBox4.Location = new System.Drawing.Point(9, 188);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // ChangeNickname
            // 
            this.ChangeNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeNickname.BackColor = System.Drawing.Color.Gainsboro;
            this.ChangeNickname.Enabled = false;
            this.ChangeNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeNickname.Location = new System.Drawing.Point(165, 391);
            this.ChangeNickname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ChangeNickname.Name = "ChangeNickname";
            this.ChangeNickname.Size = new System.Drawing.Size(150, 32);
            this.ChangeNickname.TabIndex = 17;
            this.ChangeNickname.Text = "Change Nicckname";
            this.ToolTip.SetToolTip(this.ChangeNickname, "Change the nickname for this address");
            this.ChangeNickname.UseVisualStyleBackColor = false;
            this.ChangeNickname.Click += new System.EventHandler(this.ChangeNickname_Click);
            // 
            // PrivateSpendKey
            // 
            this.PrivateSpendKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrivateSpendKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrivateSpendKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateSpendKey.ForeColor = System.Drawing.Color.Black;
            this.PrivateSpendKey.Location = new System.Drawing.Point(6, 336);
            this.PrivateSpendKey.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.PrivateSpendKey.Name = "PrivateSpendKey";
            this.PrivateSpendKey.ReadOnly = true;
            this.PrivateSpendKey.Size = new System.Drawing.Size(535, 16);
            this.PrivateSpendKey.TabIndex = 21;
            this.PrivateSpendKey.Text = "-";
            // 
            // CopyAddress
            // 
            this.CopyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.CopyAddress.Enabled = false;
            this.CopyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyAddress.Image = global::Shell_Wallet.Properties.Resources.Clipboard;
            this.CopyAddress.Location = new System.Drawing.Point(560, 133);
            this.CopyAddress.Name = "CopyAddress";
            this.CopyAddress.Size = new System.Drawing.Size(32, 32);
            this.CopyAddress.TabIndex = 1;
            this.ToolTip.SetToolTip(this.CopyAddress, "Copy this address to your clipboard");
            this.CopyAddress.UseVisualStyleBackColor = false;
            this.CopyAddress.Click += new System.EventHandler(this.CopyAddress_Click);
            // 
            // ShowKeysButton
            // 
            this.ShowKeysButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowKeysButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ShowKeysButton.Enabled = false;
            this.ShowKeysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowKeysButton.Location = new System.Drawing.Point(9, 391);
            this.ShowKeysButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ShowKeysButton.Name = "ShowKeysButton";
            this.ShowKeysButton.Size = new System.Drawing.Size(150, 32);
            this.ShowKeysButton.TabIndex = 22;
            this.ShowKeysButton.Text = "Show Keys";
            this.ToolTip.SetToolTip(this.ShowKeysButton, "Show or hide your spend keys");
            this.ShowKeysButton.UseVisualStyleBackColor = false;
            this.ShowKeysButton.Click += new System.EventHandler(this.ShowKeysClick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Selected Address Information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Balance";
            // 
            // TextBoxSizer9
            // 
            this.TextBoxSizer9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSizer9.BackColor = System.Drawing.Color.White;
            this.TextBoxSizer9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSizer9.Controls.Add(this.AddressDisplay);
            this.TextBoxSizer9.Location = new System.Drawing.Point(9, 134);
            this.TextBoxSizer9.Name = "TextBoxSizer9";
            this.TextBoxSizer9.Size = new System.Drawing.Size(545, 32);
            this.TextBoxSizer9.TabIndex = 25;
            // 
            // AddressDisplay
            // 
            this.AddressDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressDisplay.BackColor = System.Drawing.Color.White;
            this.AddressDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressDisplay.Location = new System.Drawing.Point(6, 9);
            this.AddressDisplay.Name = "AddressDisplay";
            this.AddressDisplay.ReadOnly = true;
            this.AddressDisplay.Size = new System.Drawing.Size(531, 13);
            this.AddressDisplay.TabIndex = 24;
            this.ToolTip.SetToolTip(this.AddressDisplay, "Selected address");
            // 
            // ComboBoxSizer2
            // 
            this.ComboBoxSizer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSizer2.BackColor = System.Drawing.Color.White;
            this.ComboBoxSizer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboBoxSizer2.Controls.Add(this.WalletAddresses);
            this.ComboBoxSizer2.Location = new System.Drawing.Point(9, 26);
            this.ComboBoxSizer2.Name = "ComboBoxSizer2";
            this.ComboBoxSizer2.Size = new System.Drawing.Size(583, 32);
            this.ComboBoxSizer2.TabIndex = 24;
            // 
            // WalletAddresses
            // 
            this.WalletAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WalletAddresses.BackColor = System.Drawing.Color.White;
            this.WalletAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WalletAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WalletAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletAddresses.FormattingEnabled = true;
            this.WalletAddresses.Location = new System.Drawing.Point(6, 3);
            this.WalletAddresses.Name = "WalletAddresses";
            this.WalletAddresses.Size = new System.Drawing.Size(569, 24);
            this.WalletAddresses.TabIndex = 0;
            this.ToolTip.SetToolTip(this.WalletAddresses, "Displays all of your addresses");
            this.WalletAddresses.SelectedIndexChanged += new System.EventHandler(this.WalletAddresses_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(6, 318);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 15);
            this.label25.TabIndex = 18;
            this.label25.Text = "Private Spend Key";
            // 
            // PublicSpendKey
            // 
            this.PublicSpendKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PublicSpendKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublicSpendKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicSpendKey.ForeColor = System.Drawing.Color.Black;
            this.PublicSpendKey.Location = new System.Drawing.Point(9, 299);
            this.PublicSpendKey.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.PublicSpendKey.Name = "PublicSpendKey";
            this.PublicSpendKey.ReadOnly = true;
            this.PublicSpendKey.Size = new System.Drawing.Size(535, 16);
            this.PublicSpendKey.TabIndex = 20;
            this.PublicSpendKey.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "Locked Balance";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(6, 283);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 15);
            this.label26.TabIndex = 19;
            this.label26.Text = "Public Spend Key";
            // 
            // SelectedLockedBalanceBox
            // 
            this.SelectedLockedBalanceBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelectedLockedBalanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedLockedBalanceBox.Enabled = false;
            this.SelectedLockedBalanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedLockedBalanceBox.ForeColor = System.Drawing.Color.Black;
            this.SelectedLockedBalanceBox.Location = new System.Drawing.Point(28, 227);
            this.SelectedLockedBalanceBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.SelectedLockedBalanceBox.Name = "SelectedLockedBalanceBox";
            this.SelectedLockedBalanceBox.ReadOnly = true;
            this.SelectedLockedBalanceBox.Size = new System.Drawing.Size(150, 16);
            this.SelectedLockedBalanceBox.TabIndex = 5;
            this.SelectedLockedBalanceBox.Text = "-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shell_Wallet.Properties.Resources.LockedBlack;
            this.pictureBox2.Location = new System.Drawing.Point(9, 227);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(6, 246);
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
            this.Nickname.Location = new System.Drawing.Point(9, 264);
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            this.Nickname.Size = new System.Drawing.Size(468, 16);
            this.Nickname.TabIndex = 16;
            this.Nickname.Text = "-";
            // 
            // SelectedBalanceBox
            // 
            this.SelectedBalanceBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelectedBalanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedBalanceBox.Enabled = false;
            this.SelectedBalanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedBalanceBox.ForeColor = System.Drawing.Color.Black;
            this.SelectedBalanceBox.Location = new System.Drawing.Point(28, 188);
            this.SelectedBalanceBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.SelectedBalanceBox.Name = "SelectedBalanceBox";
            this.SelectedBalanceBox.ReadOnly = true;
            this.SelectedBalanceBox.Size = new System.Drawing.Size(150, 16);
            this.SelectedBalanceBox.TabIndex = 3;
            this.SelectedBalanceBox.Text = "-";
            this.ToolTip.SetToolTip(this.SelectedBalanceBox, "Balance of your selected address");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Address";
            // 
            // DeleteSelectedAddress
            // 
            this.DeleteSelectedAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSelectedAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteSelectedAddress.Enabled = false;
            this.DeleteSelectedAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedAddress.Location = new System.Drawing.Point(442, 64);
            this.DeleteSelectedAddress.Name = "DeleteSelectedAddress";
            this.DeleteSelectedAddress.Size = new System.Drawing.Size(150, 32);
            this.DeleteSelectedAddress.TabIndex = 12;
            this.DeleteSelectedAddress.Text = "Delete This Address";
            this.ToolTip.SetToolTip(this.DeleteSelectedAddress, "Delete this address from your wallet");
            this.DeleteSelectedAddress.UseVisualStyleBackColor = false;
            this.DeleteSelectedAddress.Click += new System.EventHandler(this.DeleteSelectedAddress_Click);
            // 
            // CreateNewAddress
            // 
            this.CreateNewAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.CreateNewAddress.Enabled = false;
            this.CreateNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewAddress.Location = new System.Drawing.Point(9, 64);
            this.CreateNewAddress.Name = "CreateNewAddress";
            this.CreateNewAddress.Size = new System.Drawing.Size(150, 32);
            this.CreateNewAddress.TabIndex = 11;
            this.CreateNewAddress.Text = "Create New Address";
            this.ToolTip.SetToolTip(this.CreateNewAddress, "Create a new address within your wallet");
            this.CreateNewAddress.UseVisualStyleBackColor = false;
            this.CreateNewAddress.Click += new System.EventHandler(this.CreateNewAddress_Click);
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
            this.ToolTip.SetToolTip(this.BalanceBox, "Your overall wallet balance across all addresses");
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
            this.ToolTip.SetToolTip(this.LockedBalanceBox, "Your overall locked balance across all addresses");
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
            this.WalletTabs.Size = new System.Drawing.Size(609, 441);
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
            this.TransactonLogTab.Size = new System.Drawing.Size(601, 432);
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
            this.TransactionLog.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.TransactionLog.Size = new System.Drawing.Size(595, 426);
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
            this.ContactBookTab.Size = new System.Drawing.Size(601, 432);
            this.ContactBookTab.TabIndex = 4;
            this.ContactBookTab.Text = "Address Book";
            // 
            // EditContact
            // 
            this.EditContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditContact.Location = new System.Drawing.Point(304, 394);
            this.EditContact.Name = "EditContact";
            this.EditContact.Size = new System.Drawing.Size(143, 32);
            this.EditContact.TabIndex = 5;
            this.EditContact.Text = "Edit";
            this.EditContact.UseVisualStyleBackColor = true;
            this.EditContact.Click += new System.EventHandler(this.EditContact_Click);
            // 
            // SendToContact
            // 
            this.SendToContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendToContact.Location = new System.Drawing.Point(453, 394);
            this.SendToContact.Name = "SendToContact";
            this.SendToContact.Size = new System.Drawing.Size(142, 32);
            this.SendToContact.TabIndex = 3;
            this.SendToContact.Text = "Send Transaction";
            this.SendToContact.UseVisualStyleBackColor = true;
            this.SendToContact.Click += new System.EventHandler(this.SendToContact_Click);
            // 
            // RemoveContact
            // 
            this.RemoveContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContact.Location = new System.Drawing.Point(155, 394);
            this.RemoveContact.Name = "RemoveContact";
            this.RemoveContact.Size = new System.Drawing.Size(143, 32);
            this.RemoveContact.TabIndex = 2;
            this.RemoveContact.Text = "Remove";
            this.RemoveContact.UseVisualStyleBackColor = true;
            this.RemoveContact.Click += new System.EventHandler(this.RemoveContact_Click);
            // 
            // AddContact
            // 
            this.AddContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContact.Location = new System.Drawing.Point(6, 394);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(143, 32);
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
            this.AddressGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.AddressGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.AddressColumn,
            this.PaymentIDColumn});
            this.AddressGrid.ContextMenuStrip = this.AddressBookMenu;
            this.AddressGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddressGrid.Location = new System.Drawing.Point(3, 3);
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
            this.AddressGrid.Size = new System.Drawing.Size(595, 385);
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
            this.AddressBookMenu.Size = new System.Drawing.Size(123, 76);
            // 
            // AddressMenuCopyAddress
            // 
            this.AddressMenuCopyAddress.Name = "AddressMenuCopyAddress";
            this.AddressMenuCopyAddress.Size = new System.Drawing.Size(122, 22);
            this.AddressMenuCopyAddress.Text = "Copy Address";
            this.AddressMenuCopyAddress.Click += new System.EventHandler(this.AddressMenuCopyAddress_Click);
            // 
            // AddressMenuEditAddress
            // 
            this.AddressMenuEditAddress.Name = "AddressMenuEditAddress";
            this.AddressMenuEditAddress.Size = new System.Drawing.Size(122, 22);
            this.AddressMenuEditAddress.Text = "Edit";
            this.AddressMenuEditAddress.Click += new System.EventHandler(this.EditContact_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // AddressMenuSendTo
            // 
            this.AddressMenuSendTo.Name = "AddressMenuSendTo";
            this.AddressMenuSendTo.Size = new System.Drawing.Size(122, 22);
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
            this.NetworkTab.Size = new System.Drawing.Size(601, 432);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(589, 346);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TransactionPool);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(583, 123);
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
            this.TransactionPool.Size = new System.Drawing.Size(577, 104);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RecentBlocks);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 211);
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
            this.RecentBlocks.Size = new System.Drawing.Size(577, 192);
            this.RecentBlocks.TabIndex = 0;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(589, 68);
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
            this.groupBox6.Size = new System.Drawing.Size(288, 62);
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
            this.groupBox3.Location = new System.Drawing.Point(297, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 62);
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
            this.BlankTab.Size = new System.Drawing.Size(601, 432);
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
            this.ServerStatus.ForeColor = System.Drawing.Color.Blue;
            this.ServerStatus.Location = new System.Drawing.Point(341, 1);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(259, 13);
            this.ServerStatus.TabIndex = 3;
            this.ServerStatus.Text = "Not Connected";
            this.ServerStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // SavePrivateKeys
            // 
            this.SavePrivateKeys.DefaultExt = "txt";
            this.SavePrivateKeys.FileName = "Keys.txt";
            this.SavePrivateKeys.Filter = "Text Files|*txt";
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
            this.ToolTip.SetToolTip(this.OptionsTabButton, "Open options menu");
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
            this.ToolTip.SetToolTip(this.OptionsTabIcon, "Open options menu");
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
            this.ToolTip.SetToolTip(this.OptionsTabLabel, "Open options menu");
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
            this.ToolTip.SetToolTip(this.NetworkTabButton, "Switch to network tab");
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
            this.ToolTip.SetToolTip(this.NetworkTabIcon, "Switch to network tab");
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
            this.ToolTip.SetToolTip(this.NetworkTabLabel, "Switch to network tab");
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
            this.ToolTip.SetToolTip(this.AddressBookTabButton, "Switch to address book tab");
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
            this.ToolTip.SetToolTip(this.AddressBookTabIcon, "Switch to address book tab");
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
            this.ToolTip.SetToolTip(this.AddressBookTabLabel, "Switch to address book tab");
            this.AddressBookTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.AddressBookTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.AddressBookTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
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
            this.ToolTip.SetToolTip(this.TransactionLogTabButton, "Switch to transaction log tab");
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
            this.ToolTip.SetToolTip(this.TransactionLogTabIcon, "Switch to transaction log tab");
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
            this.ToolTip.SetToolTip(this.TransactionLogTabLabel, "Switch to transaction log tab");
            this.TransactionLogTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.TransactionLogTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.TransactionLogTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
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
            this.ToolTip.SetToolTip(this.WalletTabButton, "Switch to wallet tab");
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
            this.ToolTip.SetToolTip(this.WalletTabIcon, "Switch to wallet tab");
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
            this.ToolTip.SetToolTip(this.WalletTabLabel, "Switch to wallet tab");
            this.WalletTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.WalletTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.WalletTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
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
            this.ToolTip.SetToolTip(this.SendTabButton, "Switch to send tab");
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
            this.ToolTip.SetToolTip(this.SendTabIcon, "Switch to send tab");
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
            this.ToolTip.SetToolTip(this.SendTabLabel, "Switch to send tab");
            this.SendTabLabel.Click += new System.EventHandler(this.MenuItemClicked);
            this.SendTabLabel.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.SendTabLabel.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(51, 6);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(100, 24);
            this.HeaderLabel.TabIndex = 27;
            this.HeaderLabel.Text = "Turtlecoin";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.HeaderLabel, "What the shell?");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Shell_Wallet.Properties.Resources.ShellBlack;
            this.pictureBox3.Location = new System.Drawing.Point(5, 57);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureBox3, "Your overall wallet balance across all addresses");
            // 
            // HeaderLogo
            // 
            this.HeaderLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLogo.Image = global::Shell_Wallet.Properties.Resources.TurtlecoinLogo;
            this.HeaderLogo.Location = new System.Drawing.Point(24, 6);
            this.HeaderLogo.Name = "HeaderLogo";
            this.HeaderLogo.Size = new System.Drawing.Size(24, 24);
            this.HeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderLogo.TabIndex = 28;
            this.HeaderLogo.TabStop = false;
            this.ToolTip.SetToolTip(this.HeaderLogo, "Turtles are nature\'s mobile homes");
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
            this.ToolTip.SetToolTip(this.LockedIcon, "Your overall locked balance across all addresses");
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.Controls.Add(this.pictureBox3);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER6);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER5);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER4);
            this.MenuPanel.Controls.Add(this.SyncPercent);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER7);
            this.MenuPanel.Controls.Add(this.SyncProgress);
            this.MenuPanel.Controls.Add(this.OptionsTabButton);
            this.MenuPanel.Controls.Add(this.NetworkTabButton);
            this.MenuPanel.Controls.Add(this.AddressBookTabButton);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER3);
            this.MenuPanel.Controls.Add(this.TransactionLogTabButton);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER2);
            this.MenuPanel.Controls.Add(this.MENUDIVIDER1);
            this.MenuPanel.Controls.Add(this.WalletTabButton);
            this.MenuPanel.Controls.Add(this.HeaderLogo);
            this.MenuPanel.Controls.Add(this.LockedIcon);
            this.MenuPanel.Controls.Add(this.SendTabButton);
            this.MenuPanel.Controls.Add(this.HeaderLabel);
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
            // MENUDIVIDER6
            // 
            this.MENUDIVIDER6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENUDIVIDER6.BackColor = System.Drawing.Color.DarkGray;
            this.MENUDIVIDER6.Location = new System.Drawing.Point(0, 310);
            this.MENUDIVIDER6.Name = "MENUDIVIDER6";
            this.MENUDIVIDER6.Size = new System.Drawing.Size(169, 1);
            this.MENUDIVIDER6.TabIndex = 40;
            // 
            // MENUDIVIDER5
            // 
            this.MENUDIVIDER5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENUDIVIDER5.BackColor = System.Drawing.Color.DarkGray;
            this.MENUDIVIDER5.Location = new System.Drawing.Point(0, 278);
            this.MENUDIVIDER5.Name = "MENUDIVIDER5";
            this.MENUDIVIDER5.Size = new System.Drawing.Size(169, 1);
            this.MENUDIVIDER5.TabIndex = 39;
            // 
            // MENUDIVIDER4
            // 
            this.MENUDIVIDER4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENUDIVIDER4.BackColor = System.Drawing.Color.DarkGray;
            this.MENUDIVIDER4.Location = new System.Drawing.Point(0, 247);
            this.MENUDIVIDER4.Name = "MENUDIVIDER4";
            this.MENUDIVIDER4.Size = new System.Drawing.Size(169, 1);
            this.MENUDIVIDER4.TabIndex = 38;
            // 
            // MENUDIVIDER7
            // 
            this.MENUDIVIDER7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENUDIVIDER7.BackColor = System.Drawing.Color.DarkGray;
            this.MENUDIVIDER7.Location = new System.Drawing.Point(0, 216);
            this.MENUDIVIDER7.Name = "MENUDIVIDER7";
            this.MENUDIVIDER7.Size = new System.Drawing.Size(169, 1);
            this.MENUDIVIDER7.TabIndex = 37;
            // 
            // MENUDIVIDER3
            // 
            this.MENUDIVIDER3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENUDIVIDER3.BackColor = System.Drawing.Color.DarkGray;
            this.MENUDIVIDER3.Location = new System.Drawing.Point(0, 185);
            this.MENUDIVIDER3.Name = "MENUDIVIDER3";
            this.MENUDIVIDER3.Size = new System.Drawing.Size(169, 1);
            this.MENUDIVIDER3.TabIndex = 33;
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
            this.RightSideTable.Location = new System.Drawing.Point(175, 0);
            this.RightSideTable.Margin = new System.Windows.Forms.Padding(0);
            this.RightSideTable.Name = "RightSideTable";
            this.RightSideTable.RowCount = 2;
            this.RightSideTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightSideTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RightSideTable.Size = new System.Drawing.Size(609, 461);
            this.RightSideTable.TabIndex = 27;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.HeightStatus);
            this.FooterPanel.Controls.Add(this.ServerStatus);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterPanel.Location = new System.Drawing.Point(3, 444);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(603, 14);
            this.FooterPanel.TabIndex = 28;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.MainWindowTable);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
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
            this.SendTabScrollPanel.ResumeLayout(false);
            this.SendTabLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.QuickSendPanel.ResumeLayout(false);
            this.QuickSendPanel.PerformLayout();
            this.AmountFeeTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TextBoxSizer2.ResumeLayout(false);
            this.TextBoxSizer2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TextBoxSizer3.ResumeLayout(false);
            this.TextBoxSizer3.PerformLayout();
            this.TextBoxSizer4.ResumeLayout(false);
            this.TextBoxSizer4.PerformLayout();
            this.TextBoxSizer1.ResumeLayout(false);
            this.TextBoxSizer1.PerformLayout();
            this.ComboBoxSizer1.ResumeLayout(false);
            this.AdvancedSendPanel.ResumeLayout(false);
            this.AdvancedSendPanel.PerformLayout();
            this.UnlockTimeMixinTable.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.TextBoxSizer7.ResumeLayout(false);
            this.TextBoxSizer7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TextBoxSizer8.ResumeLayout(false);
            this.TextBoxSizer8.PerformLayout();
            this.TextBoxSizer6.ResumeLayout(false);
            this.TextBoxSizer6.PerformLayout();
            this.TextBoxSizer5.ResumeLayout(false);
            this.TextBoxSizer5.PerformLayout();
            this.WalletTab.ResumeLayout(false);
            this.WalletTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.TextBoxSizer9.ResumeLayout(false);
            this.TextBoxSizer9.PerformLayout();
            this.ComboBoxSizer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.WalletTabs.ResumeLayout(false);
            this.TransactonLogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ContactBookTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).EndInit();
            this.AddressBookMenu.ResumeLayout(false);
            this.NetworkTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionPool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionPoolBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecentBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentBlocksBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
            this.SendTabButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SendTabIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockedIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.MainWindowTable.ResumeLayout(false);
            this.RightSideTable.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
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
        private System.Windows.Forms.Button SendToContact;
        private System.Windows.Forms.Button RemoveContact;
        private System.Windows.Forms.Button AddContact;
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
        private System.Windows.Forms.ToolStripMenuItem CloseNetworkMenuOption;
        private System.Windows.Forms.BindingSource recentBlocksBindingSource;
        private System.Windows.Forms.ToolStripMenuItem ResyncMenuOption;
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
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TableLayoutPanel SendTabButton;
        private System.Windows.Forms.PictureBox SendTabIcon;
        private System.Windows.Forms.Label SendTabLabel;
        private System.Windows.Forms.PictureBox HeaderLogo;
        private System.Windows.Forms.TableLayoutPanel WalletTabButton;
        private System.Windows.Forms.PictureBox WalletTabIcon;
        private System.Windows.Forms.Label WalletTabLabel;
        private System.Windows.Forms.Panel MENUDIVIDER1;
        private System.Windows.Forms.Panel MENUDIVIDER3;
        private System.Windows.Forms.TableLayoutPanel TransactionLogTabButton;
        private System.Windows.Forms.PictureBox TransactionLogTabIcon;
        private System.Windows.Forms.Label TransactionLogTabLabel;
        private System.Windows.Forms.Panel MENUDIVIDER2;
        private System.Windows.Forms.TabPage BlankTab;
        private System.Windows.Forms.Panel MENUDIVIDER6;
        private System.Windows.Forms.Panel MENUDIVIDER5;
        private System.Windows.Forms.Panel MENUDIVIDER4;
        private System.Windows.Forms.Panel MENUDIVIDER7;
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
        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button ShowKeysButton;
        private System.Windows.Forms.TextBox PrivateSpendKey;
        private System.Windows.Forms.TextBox PublicSpendKey;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox AddressDisplay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel SendTabScrollPanel;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label SendOutputLabel;
        private System.Windows.Forms.Panel TextBoxSizer8;
        private System.Windows.Forms.Panel TextBoxSizer7;
        private System.Windows.Forms.Panel TextBoxSizer6;
        private System.Windows.Forms.Panel TextBoxSizer5;
        private System.Windows.Forms.Label ShowAdvancedSendLabel;
        private System.Windows.Forms.Panel TextBoxSizer4;
        private System.Windows.Forms.Panel TextBoxSizer3;
        private System.Windows.Forms.Panel TextBoxSizer2;
        private System.Windows.Forms.Panel TextBoxSizer1;
        private System.Windows.Forms.Panel ComboBoxSizer1;
        private System.Windows.Forms.Panel AdvancedSendPanel;
        private System.Windows.Forms.Panel ComboBoxSizer2;
        private System.Windows.Forms.Panel TextBoxSizer9;
        private System.Windows.Forms.Button ChangeNickname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel SendTabLayout;
        private System.Windows.Forms.Panel QuickSendPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel AmountFeeTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel UnlockTimeMixinTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

