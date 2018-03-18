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
            this.CloseWalletMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.NetworkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StartNetworkMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseNetworkMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWalletDialog = new System.Windows.Forms.OpenFileDialog();
            this.NewWalletDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenServerPath = new System.Windows.Forms.OpenFileDialog();
            this.SendTab = new System.Windows.Forms.TabPage();
            this.SendFromAddress = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ChangeAddress = new System.Windows.Forms.TextBox();
            this.UnlockTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ExtraBox = new System.Windows.Forms.TextBox();
            this.Mixin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TransactionOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SendTransaction = new System.Windows.Forms.Button();
            this.PaymentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountToSend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SendToAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WalletTab = new System.Windows.Forms.TabPage();
            this.DeleteSelectedAddress = new System.Windows.Forms.Button();
            this.CreateNewAddress = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.LockedBalanceBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectedLockedBalanceBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SelectedBalanceBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.WalletAddresses = new System.Windows.Forms.ComboBox();
            this.SyncPercent = new System.Windows.Forms.Label();
            this.SyncProgress = new System.Windows.Forms.ProgressBar();
            this.CopyAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WalletTabs = new System.Windows.Forms.TabControl();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Difficulty = new System.Windows.Forms.Label();
            this.Reward = new System.Windows.Forms.Label();
            this.GlobalHashrate = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TotalSupply = new System.Windows.Forms.Label();
            this.TotalTransactions = new System.Windows.Forms.Label();
            this.TotalBlocks = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.RecentBlocks = new System.Windows.Forms.DataGridView();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recentBlocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TransactionPool = new System.Windows.Forms.DataGridView();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionPoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeightStatus = new System.Windows.Forms.Label();
            this.ServerStatus = new System.Windows.Forms.Label();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePrivateKeys = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip.SuspendLayout();
            this.SendTab.SuspendLayout();
            this.WalletTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WalletTabs.SuspendLayout();
            this.ContactBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).BeginInit();
            this.AddressBookMenu.SuspendLayout();
            this.NetworkTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecentBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentBlocksBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionPool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionPoolBindingSource)).BeginInit();
            this.TrayIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WalletMenu,
            this.NetworkMenu,
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
            this.CloseWalletMenuOption});
            this.WalletMenu.Name = "WalletMenu";
            this.WalletMenu.Size = new System.Drawing.Size(52, 20);
            this.WalletMenu.Text = "Wallet";
            // 
            // OpenWalletMenuOption
            // 
            this.OpenWalletMenuOption.Name = "OpenWalletMenuOption";
            this.OpenWalletMenuOption.Size = new System.Drawing.Size(173, 22);
            this.OpenWalletMenuOption.Text = "Open Wallet";
            this.OpenWalletMenuOption.Click += new System.EventHandler(this.openWalletToolStripMenuItem_Click);
            // 
            // OpenDefaultMenuOption
            // 
            this.OpenDefaultMenuOption.Name = "OpenDefaultMenuOption";
            this.OpenDefaultMenuOption.Size = new System.Drawing.Size(173, 22);
            this.OpenDefaultMenuOption.Text = "Open Default";
            this.OpenDefaultMenuOption.Click += new System.EventHandler(this.openDefaultWalletToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(170, 6);
            // 
            // CreateWalletMenuOption
            // 
            this.CreateWalletMenuOption.Name = "CreateWalletMenuOption";
            this.CreateWalletMenuOption.Size = new System.Drawing.Size(173, 22);
            this.CreateWalletMenuOption.Text = "Create Wallet";
            this.CreateWalletMenuOption.Click += new System.EventHandler(this.createWalletToolStripMenuItem_Click);
            // 
            // ImportWalletMenuOption
            // 
            this.ImportWalletMenuOption.Name = "ImportWalletMenuOption";
            this.ImportWalletMenuOption.Size = new System.Drawing.Size(173, 22);
            this.ImportWalletMenuOption.Text = "Import Wallet";
            this.ImportWalletMenuOption.Click += new System.EventHandler(this.importWalletToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // ExportPrivateKeysMenuOption
            // 
            this.ExportPrivateKeysMenuOption.Name = "ExportPrivateKeysMenuOption";
            this.ExportPrivateKeysMenuOption.Size = new System.Drawing.Size(173, 22);
            this.ExportPrivateKeysMenuOption.Text = "Export Private Keys";
            this.ExportPrivateKeysMenuOption.Click += new System.EventHandler(this.viewWalletKeysToolStripMenuItem_Click);
            // 
            // ResyncMenuOption
            // 
            this.ResyncMenuOption.Name = "ResyncMenuOption";
            this.ResyncMenuOption.Size = new System.Drawing.Size(173, 22);
            this.ResyncMenuOption.Text = "Resync";
            this.ResyncMenuOption.Click += new System.EventHandler(this.resyncToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(170, 6);
            // 
            // CloseWalletMenuOption
            // 
            this.CloseWalletMenuOption.Enabled = false;
            this.CloseWalletMenuOption.Name = "CloseWalletMenuOption";
            this.CloseWalletMenuOption.Size = new System.Drawing.Size(173, 22);
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
            this.SendTab.Controls.Add(this.SendFromAddress);
            this.SendTab.Controls.Add(this.label20);
            this.SendTab.Controls.Add(this.label17);
            this.SendTab.Controls.Add(this.label16);
            this.SendTab.Controls.Add(this.label15);
            this.SendTab.Controls.Add(this.label14);
            this.SendTab.Controls.Add(this.label13);
            this.SendTab.Controls.Add(this.ChangeAddress);
            this.SendTab.Controls.Add(this.UnlockTime);
            this.SendTab.Controls.Add(this.label12);
            this.SendTab.Controls.Add(this.label11);
            this.SendTab.Controls.Add(this.ExtraBox);
            this.SendTab.Controls.Add(this.Mixin);
            this.SendTab.Controls.Add(this.label10);
            this.SendTab.Controls.Add(this.label9);
            this.SendTab.Controls.Add(this.TransactionOutput);
            this.SendTab.Controls.Add(this.label8);
            this.SendTab.Controls.Add(this.SendTransaction);
            this.SendTab.Controls.Add(this.PaymentID);
            this.SendTab.Controls.Add(this.label7);
            this.SendTab.Controls.Add(this.Fee);
            this.SendTab.Controls.Add(this.label6);
            this.SendTab.Controls.Add(this.AmountToSend);
            this.SendTab.Controls.Add(this.label5);
            this.SendTab.Controls.Add(this.SendToAddress);
            this.SendTab.Controls.Add(this.label4);
            this.SendTab.Location = new System.Drawing.Point(4, 22);
            this.SendTab.Name = "SendTab";
            this.SendTab.Padding = new System.Windows.Forms.Padding(3);
            this.SendTab.Size = new System.Drawing.Size(752, 404);
            this.SendTab.TabIndex = 2;
            this.SendTab.Text = "Send";
            this.SendTab.UseVisualStyleBackColor = true;
            // 
            // SendFromAddress
            // 
            this.SendFromAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendFromAddress.FormattingEnabled = true;
            this.SendFromAddress.Items.AddRange(new object[] {
            "Entire Wallet Balance",
            "Selected Address"});
            this.SendFromAddress.Location = new System.Drawing.Point(6, 19);
            this.SendFromAddress.Name = "SendFromAddress";
            this.SendFromAddress.Size = new System.Drawing.Size(357, 21);
            this.SendFromAddress.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Send From";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(311, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "(Optional)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(311, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "(Optional)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(311, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "(Optional)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(311, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "(Optional)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(311, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "(Optional)";
            // 
            // ChangeAddress
            // 
            this.ChangeAddress.Location = new System.Drawing.Point(6, 253);
            this.ChangeAddress.Name = "ChangeAddress";
            this.ChangeAddress.Size = new System.Drawing.Size(357, 20);
            this.ChangeAddress.TabIndex = 6;
            // 
            // UnlockTime
            // 
            this.UnlockTime.Location = new System.Drawing.Point(6, 214);
            this.UnlockTime.Name = "UnlockTime";
            this.UnlockTime.Size = new System.Drawing.Size(357, 20);
            this.UnlockTime.TabIndex = 5;
            this.UnlockTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Change Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Unlock Time";
            // 
            // ExtraBox
            // 
            this.ExtraBox.Location = new System.Drawing.Point(6, 331);
            this.ExtraBox.Name = "ExtraBox";
            this.ExtraBox.Size = new System.Drawing.Size(357, 20);
            this.ExtraBox.TabIndex = 8;
            // 
            // Mixin
            // 
            this.Mixin.Location = new System.Drawing.Point(6, 292);
            this.Mixin.Name = "Mixin";
            this.Mixin.Size = new System.Drawing.Size(357, 20);
            this.Mixin.TabIndex = 7;
            this.Mixin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mixin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(6, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Extra";
            // 
            // TransactionOutput
            // 
            this.TransactionOutput.Location = new System.Drawing.Point(369, 19);
            this.TransactionOutput.Multiline = true;
            this.TransactionOutput.Name = "TransactionOutput";
            this.TransactionOutput.ReadOnly = true;
            this.TransactionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransactionOutput.Size = new System.Drawing.Size(377, 379);
            this.TransactionOutput.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Output";
            // 
            // SendTransaction
            // 
            this.SendTransaction.Location = new System.Drawing.Point(6, 375);
            this.SendTransaction.Name = "SendTransaction";
            this.SendTransaction.Size = new System.Drawing.Size(357, 23);
            this.SendTransaction.TabIndex = 9;
            this.SendTransaction.Text = "Send Transaction";
            this.SendTransaction.UseVisualStyleBackColor = true;
            this.SendTransaction.Click += new System.EventHandler(this.SendTransaction_Click);
            // 
            // PaymentID
            // 
            this.PaymentID.Location = new System.Drawing.Point(6, 175);
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Size = new System.Drawing.Size(357, 20);
            this.PaymentID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payment ID";
            // 
            // Fee
            // 
            this.Fee.Location = new System.Drawing.Point(6, 136);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(357, 20);
            this.Fee.TabIndex = 3;
            this.Fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalNumberOnly);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fee";
            // 
            // AmountToSend
            // 
            this.AmountToSend.Location = new System.Drawing.Point(6, 97);
            this.AmountToSend.Name = "AmountToSend";
            this.AmountToSend.Size = new System.Drawing.Size(357, 20);
            this.AmountToSend.TabIndex = 2;
            this.AmountToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalNumberOnly);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount";
            // 
            // SendToAddress
            // 
            this.SendToAddress.Location = new System.Drawing.Point(6, 58);
            this.SendToAddress.Name = "SendToAddress";
            this.SendToAddress.Size = new System.Drawing.Size(357, 20);
            this.SendToAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Send To";
            // 
            // WalletTab
            // 
            this.WalletTab.Controls.Add(this.DeleteSelectedAddress);
            this.WalletTab.Controls.Add(this.CreateNewAddress);
            this.WalletTab.Controls.Add(this.groupBox2);
            this.WalletTab.Controls.Add(this.groupBox1);
            this.WalletTab.Controls.Add(this.WalletAddresses);
            this.WalletTab.Controls.Add(this.SyncPercent);
            this.WalletTab.Controls.Add(this.SyncProgress);
            this.WalletTab.Controls.Add(this.CopyAddress);
            this.WalletTab.Controls.Add(this.label1);
            this.WalletTab.Location = new System.Drawing.Point(4, 22);
            this.WalletTab.Name = "WalletTab";
            this.WalletTab.Padding = new System.Windows.Forms.Padding(3);
            this.WalletTab.Size = new System.Drawing.Size(752, 404);
            this.WalletTab.TabIndex = 0;
            this.WalletTab.Text = "Wallet";
            this.WalletTab.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedAddress
            // 
            this.DeleteSelectedAddress.Enabled = false;
            this.DeleteSelectedAddress.Location = new System.Drawing.Point(162, 46);
            this.DeleteSelectedAddress.Name = "DeleteSelectedAddress";
            this.DeleteSelectedAddress.Size = new System.Drawing.Size(150, 23);
            this.DeleteSelectedAddress.TabIndex = 12;
            this.DeleteSelectedAddress.Text = "Delete Selected Address";
            this.DeleteSelectedAddress.UseVisualStyleBackColor = true;
            this.DeleteSelectedAddress.Click += new System.EventHandler(this.DeleteSelectedAddress_Click);
            // 
            // CreateNewAddress
            // 
            this.CreateNewAddress.Enabled = false;
            this.CreateNewAddress.Location = new System.Drawing.Point(6, 46);
            this.CreateNewAddress.Name = "CreateNewAddress";
            this.CreateNewAddress.Size = new System.Drawing.Size(150, 23);
            this.CreateNewAddress.TabIndex = 11;
            this.CreateNewAddress.Text = "Create New Address";
            this.ToolTip.SetToolTip(this.CreateNewAddress, "Create a new address");
            this.CreateNewAddress.UseVisualStyleBackColor = true;
            this.CreateNewAddress.Click += new System.EventHandler(this.CreateNewAddress_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BalanceBox);
            this.groupBox2.Controls.Add(this.LockedBalanceBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(379, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 291);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Addresses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Locked Balance";
            // 
            // BalanceBox
            // 
            this.BalanceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BalanceBox.Location = new System.Drawing.Point(6, 32);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.ReadOnly = true;
            this.BalanceBox.Size = new System.Drawing.Size(355, 20);
            this.BalanceBox.TabIndex = 2;
            // 
            // LockedBalanceBox
            // 
            this.LockedBalanceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LockedBalanceBox.Location = new System.Drawing.Point(6, 71);
            this.LockedBalanceBox.Name = "LockedBalanceBox";
            this.LockedBalanceBox.ReadOnly = true;
            this.LockedBalanceBox.Size = new System.Drawing.Size(355, 20);
            this.LockedBalanceBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectedLockedBalanceBox);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.SelectedBalanceBox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 291);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Address";
            // 
            // SelectedLockedBalanceBox
            // 
            this.SelectedLockedBalanceBox.Location = new System.Drawing.Point(6, 71);
            this.SelectedLockedBalanceBox.Name = "SelectedLockedBalanceBox";
            this.SelectedLockedBalanceBox.Size = new System.Drawing.Size(355, 20);
            this.SelectedLockedBalanceBox.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Locked Balance";
            // 
            // SelectedBalanceBox
            // 
            this.SelectedBalanceBox.Location = new System.Drawing.Point(6, 32);
            this.SelectedBalanceBox.Name = "SelectedBalanceBox";
            this.SelectedBalanceBox.Size = new System.Drawing.Size(355, 20);
            this.SelectedBalanceBox.TabIndex = 3;
            this.ToolTip.SetToolTip(this.SelectedBalanceBox, "Balance of your selected address");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Balance";
            // 
            // WalletAddresses
            // 
            this.WalletAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WalletAddresses.Enabled = false;
            this.WalletAddresses.FormattingEnabled = true;
            this.WalletAddresses.Location = new System.Drawing.Point(6, 19);
            this.WalletAddresses.Name = "WalletAddresses";
            this.WalletAddresses.Size = new System.Drawing.Size(740, 21);
            this.WalletAddresses.TabIndex = 0;
            this.ToolTip.SetToolTip(this.WalletAddresses, "Displays all of your addresses");
            this.WalletAddresses.SelectedIndexChanged += new System.EventHandler(this.WalletAddresses_SelectedIndexChanged);
            // 
            // SyncPercent
            // 
            this.SyncPercent.Location = new System.Drawing.Point(3, 369);
            this.SyncPercent.Name = "SyncPercent";
            this.SyncPercent.Size = new System.Drawing.Size(743, 15);
            this.SyncPercent.TabIndex = 8;
            this.SyncPercent.Text = "Waiting to sync";
            this.SyncPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SyncProgress
            // 
            this.SyncProgress.Location = new System.Drawing.Point(6, 387);
            this.SyncProgress.Name = "SyncProgress";
            this.SyncProgress.Size = new System.Drawing.Size(740, 11);
            this.SyncProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SyncProgress.TabIndex = 7;
            // 
            // CopyAddress
            // 
            this.CopyAddress.Enabled = false;
            this.CopyAddress.Location = new System.Drawing.Point(596, 46);
            this.CopyAddress.Name = "CopyAddress";
            this.CopyAddress.Size = new System.Drawing.Size(150, 23);
            this.CopyAddress.TabIndex = 1;
            this.CopyAddress.Text = "Copy Address to Clipboard";
            this.CopyAddress.UseVisualStyleBackColor = true;
            this.CopyAddress.Click += new System.EventHandler(this.CopyAddress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Public Addresses";
            // 
            // WalletTabs
            // 
            this.WalletTabs.Controls.Add(this.WalletTab);
            this.WalletTabs.Controls.Add(this.SendTab);
            this.WalletTabs.Controls.Add(this.ContactBookTab);
            this.WalletTabs.Controls.Add(this.NetworkTab);
            this.WalletTabs.Location = new System.Drawing.Point(12, 27);
            this.WalletTabs.Multiline = true;
            this.WalletTabs.Name = "WalletTabs";
            this.WalletTabs.SelectedIndex = 0;
            this.WalletTabs.Size = new System.Drawing.Size(760, 430);
            this.WalletTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.WalletTabs.TabIndex = 1;
            // 
            // ContactBookTab
            // 
            this.ContactBookTab.Controls.Add(this.EditContact);
            this.ContactBookTab.Controls.Add(this.SendToContact);
            this.ContactBookTab.Controls.Add(this.RemoveContact);
            this.ContactBookTab.Controls.Add(this.AddContact);
            this.ContactBookTab.Controls.Add(this.AddressGrid);
            this.ContactBookTab.Location = new System.Drawing.Point(4, 22);
            this.ContactBookTab.Name = "ContactBookTab";
            this.ContactBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContactBookTab.Size = new System.Drawing.Size(752, 404);
            this.ContactBookTab.TabIndex = 4;
            this.ContactBookTab.Text = "Address Book";
            this.ContactBookTab.UseVisualStyleBackColor = true;
            // 
            // EditContact
            // 
            this.EditContact.Location = new System.Drawing.Point(218, 375);
            this.EditContact.Name = "EditContact";
            this.EditContact.Size = new System.Drawing.Size(100, 23);
            this.EditContact.TabIndex = 5;
            this.EditContact.Text = "Edit";
            this.EditContact.UseVisualStyleBackColor = true;
            this.EditContact.Click += new System.EventHandler(this.EditContact_Click);
            // 
            // SendToContact
            // 
            this.SendToContact.Location = new System.Drawing.Point(606, 375);
            this.SendToContact.Name = "SendToContact";
            this.SendToContact.Size = new System.Drawing.Size(140, 23);
            this.SendToContact.TabIndex = 3;
            this.SendToContact.Text = "Send Transaction";
            this.SendToContact.UseVisualStyleBackColor = true;
            this.SendToContact.Click += new System.EventHandler(this.SendToContact_Click);
            // 
            // RemoveContact
            // 
            this.RemoveContact.Location = new System.Drawing.Point(112, 375);
            this.RemoveContact.Name = "RemoveContact";
            this.RemoveContact.Size = new System.Drawing.Size(100, 23);
            this.RemoveContact.TabIndex = 2;
            this.RemoveContact.Text = "Remove";
            this.RemoveContact.UseVisualStyleBackColor = true;
            this.RemoveContact.Click += new System.EventHandler(this.RemoveContact_Click);
            // 
            // AddContact
            // 
            this.AddContact.Location = new System.Drawing.Point(6, 375);
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
            this.AddressGrid.AllowUserToResizeColumns = false;
            this.AddressGrid.AllowUserToResizeRows = false;
            this.AddressGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressGrid.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.AddressGrid.Size = new System.Drawing.Size(740, 363);
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
            this.NetworkTab.Controls.Add(this.groupBox3);
            this.NetworkTab.Controls.Add(this.groupBox6);
            this.NetworkTab.Controls.Add(this.groupBox5);
            this.NetworkTab.Controls.Add(this.groupBox4);
            this.NetworkTab.Location = new System.Drawing.Point(4, 22);
            this.NetworkTab.Name = "NetworkTab";
            this.NetworkTab.Padding = new System.Windows.Forms.Padding(3);
            this.NetworkTab.Size = new System.Drawing.Size(752, 404);
            this.NetworkTab.TabIndex = 5;
            this.NetworkTab.Text = "Network";
            this.NetworkTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Difficulty);
            this.groupBox3.Controls.Add(this.Reward);
            this.groupBox3.Controls.Add(this.GlobalHashrate);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(379, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 65);
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
            this.Difficulty.Size = new System.Drawing.Size(13, 13);
            this.Difficulty.TabIndex = 11;
            this.Difficulty.Text = "0";
            // 
            // Reward
            // 
            this.Reward.AutoSize = true;
            this.Reward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reward.Location = new System.Drawing.Point(121, 42);
            this.Reward.Name = "Reward";
            this.Reward.Size = new System.Drawing.Size(13, 13);
            this.Reward.TabIndex = 10;
            this.Reward.Text = "0";
            // 
            // GlobalHashrate
            // 
            this.GlobalHashrate.AutoSize = true;
            this.GlobalHashrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalHashrate.Location = new System.Drawing.Point(121, 16);
            this.GlobalHashrate.Name = "GlobalHashrate";
            this.GlobalHashrate.Size = new System.Drawing.Size(13, 13);
            this.GlobalHashrate.TabIndex = 9;
            this.GlobalHashrate.Text = "0";
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TotalSupply);
            this.groupBox6.Controls.Add(this.TotalTransactions);
            this.groupBox6.Controls.Add(this.TotalBlocks);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(367, 65);
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
            this.TotalSupply.Size = new System.Drawing.Size(13, 13);
            this.TotalSupply.TabIndex = 5;
            this.TotalSupply.Text = "0";
            // 
            // TotalTransactions
            // 
            this.TotalTransactions.AutoSize = true;
            this.TotalTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTransactions.Location = new System.Drawing.Point(121, 42);
            this.TotalTransactions.Name = "TotalTransactions";
            this.TotalTransactions.Size = new System.Drawing.Size(13, 13);
            this.TotalTransactions.TabIndex = 4;
            this.TotalTransactions.Text = "0";
            // 
            // TotalBlocks
            // 
            this.TotalBlocks.AutoSize = true;
            this.TotalBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBlocks.Location = new System.Drawing.Point(121, 16);
            this.TotalBlocks.Name = "TotalBlocks";
            this.TotalBlocks.Size = new System.Drawing.Size(13, 13);
            this.TotalBlocks.TabIndex = 3;
            this.TotalBlocks.Text = "0";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.RecentBlocks);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(740, 207);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recent Blocks";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.SystemColors.Control;
            this.label25.Location = new System.Drawing.Point(9, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(725, 158);
            this.label25.TabIndex = 3;
            this.label25.Text = "Not Added Yet";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.RecentBlocks.Size = new System.Drawing.Size(734, 188);
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
            this.recentBlocksBindingSource.DataSource = typeof(WalletWrapper.RecentBlocks);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.TransactionPool);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(740, 108);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction Pool";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Location = new System.Drawing.Point(6, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(728, 53);
            this.label24.TabIndex = 2;
            this.label24.Text = "Not Added Yet";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TransactionPool.Size = new System.Drawing.Size(734, 89);
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
            this.transactionPoolBindingSource.DataSource = typeof(WalletWrapper.RecentBlocks);
            // 
            // HeightStatus
            // 
            this.HeightStatus.AutoSize = true;
            this.HeightStatus.Location = new System.Drawing.Point(13, 460);
            this.HeightStatus.Name = "HeightStatus";
            this.HeightStatus.Size = new System.Drawing.Size(0, 13);
            this.HeightStatus.TabIndex = 2;
            // 
            // ServerStatus
            // 
            this.ServerStatus.ForeColor = System.Drawing.Color.Blue;
            this.ServerStatus.Location = new System.Drawing.Point(502, 460);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(266, 23);
            this.ServerStatus.TabIndex = 3;
            this.ServerStatus.Text = "Not Connected";
            this.ServerStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayIconContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Shell Wallet";
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.TrayIconContextMenu.Name = "TrayIconContextMenu";
            this.TrayIconContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TrayIconContextMenu.ShowImageMargin = false;
            this.TrayIconContextMenu.Size = new System.Drawing.Size(89, 48);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem4.Text = "Restore";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem5.Text = "Close";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // SavePrivateKeys
            // 
            this.SavePrivateKeys.DefaultExt = "txt";
            this.SavePrivateKeys.FileName = "Keys.txt";
            this.SavePrivateKeys.Filter = "Text Files|*txt";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.HeightStatus);
            this.Controls.Add(this.WalletTabs);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell Wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.SendTab.ResumeLayout(false);
            this.SendTab.PerformLayout();
            this.WalletTab.ResumeLayout(false);
            this.WalletTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WalletTabs.ResumeLayout(false);
            this.ContactBookTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).EndInit();
            this.AddressBookMenu.ResumeLayout(false);
            this.NetworkTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecentBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentBlocksBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionPool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionPoolBindingSource)).EndInit();
            this.TrayIconContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.TextBox ExtraBox;
        private System.Windows.Forms.TextBox Mixin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ChangeAddress;
        private System.Windows.Forms.TextBox UnlockTime;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.BindingSource recentBlocksBindingSource;
        private System.Windows.Forms.ToolStripMenuItem ResyncMenuOption;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

