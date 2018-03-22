namespace Shell_Wallet
{
    partial class OptionsWindow
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultAddress = new System.Windows.Forms.TextBox();
            this.OpenDefault = new System.Windows.Forms.Button();
            this.AllowBlankPasswords = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LocalDaemonCheckbox = new System.Windows.Forms.CheckBox();
            this.NodePort = new System.Windows.Forms.TextBox();
            this.NodeHost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GeneratePassword = new System.Windows.Forms.CheckBox();
            this.OpenWalletPath = new System.Windows.Forms.OpenFileDialog();
            this.ServerPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenServer = new System.Windows.Forms.Button();
            this.ServerPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.OpenServerPath = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DefaultMixin = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.DefaultFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OptionsTabs = new System.Windows.Forms.TabControl();
            this.ConnectivityTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MiscTab = new System.Windows.Forms.TabPage();
            this.DefaultsTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MobileTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.MobileWalletCheckbox = new System.Windows.Forms.CheckBox();
            this.MobileWalletPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MobileWalletPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.CheckBox();
            this.RemoteTab = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.RemotePassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RemoteAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RemotePort = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.NetworkMonitor = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.OptionsTabs.SuspendLayout();
            this.ConnectivityTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MiscTab.SuspendLayout();
            this.DefaultsTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.MobileTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.RemoteTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ApplyButton.Location = new System.Drawing.Point(9, 306);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(320, 23);
            this.ApplyButton.TabIndex = 7;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wallet";
            // 
            // DefaultAddress
            // 
            this.DefaultAddress.Location = new System.Drawing.Point(65, 21);
            this.DefaultAddress.Name = "DefaultAddress";
            this.DefaultAddress.Size = new System.Drawing.Size(142, 20);
            this.DefaultAddress.TabIndex = 0;
            // 
            // OpenDefault
            // 
            this.OpenDefault.Location = new System.Drawing.Point(213, 21);
            this.OpenDefault.Name = "OpenDefault";
            this.OpenDefault.Size = new System.Drawing.Size(75, 20);
            this.OpenDefault.TabIndex = 1;
            this.OpenDefault.Text = "Browse";
            this.OpenDefault.UseVisualStyleBackColor = true;
            this.OpenDefault.Click += new System.EventHandler(this.OpenDefault_Click);
            // 
            // AllowBlankPasswords
            // 
            this.AllowBlankPasswords.AutoSize = true;
            this.AllowBlankPasswords.Location = new System.Drawing.Point(9, 24);
            this.AllowBlankPasswords.Name = "AllowBlankPasswords";
            this.AllowBlankPasswords.Size = new System.Drawing.Size(192, 17);
            this.AllowBlankPasswords.TabIndex = 0;
            this.AllowBlankPasswords.Text = "Allow blank passwords (not secure)";
            this.AllowBlankPasswords.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LocalDaemonCheckbox);
            this.groupBox1.Controls.Add(this.NodePort);
            this.groupBox1.Controls.Add(this.NodeHost);
            this.groupBox1.Location = new System.Drawing.Point(6, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daemon Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // LocalDaemonCheckbox
            // 
            this.LocalDaemonCheckbox.AutoSize = true;
            this.LocalDaemonCheckbox.Location = new System.Drawing.Point(9, 80);
            this.LocalDaemonCheckbox.Name = "LocalDaemonCheckbox";
            this.LocalDaemonCheckbox.Size = new System.Drawing.Size(111, 17);
            this.LocalDaemonCheckbox.TabIndex = 6;
            this.LocalDaemonCheckbox.Text = "Use local daemon";
            this.LocalDaemonCheckbox.UseVisualStyleBackColor = true;
            this.LocalDaemonCheckbox.CheckedChanged += new System.EventHandler(this.LocalDaemonCheckbox_CheckedChanged);
            // 
            // NodePort
            // 
            this.NodePort.Location = new System.Drawing.Point(62, 45);
            this.NodePort.Name = "NodePort";
            this.NodePort.Size = new System.Drawing.Size(223, 20);
            this.NodePort.TabIndex = 5;
            this.NodePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // NodeHost
            // 
            this.NodeHost.Location = new System.Drawing.Point(62, 19);
            this.NodeHost.Name = "NodeHost";
            this.NodeHost.Size = new System.Drawing.Size(223, 20);
            this.NodeHost.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConfirmPassword);
            this.groupBox2.Controls.Add(this.AllowBlankPasswords);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passwords";
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.AutoSize = true;
            this.GeneratePassword.Location = new System.Drawing.Point(9, 111);
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.Size = new System.Drawing.Size(160, 17);
            this.GeneratePassword.TabIndex = 1;
            this.GeneratePassword.Text = "Generate dynamic password";
            this.GeneratePassword.UseVisualStyleBackColor = true;
            this.GeneratePassword.CheckedChanged += new System.EventHandler(this.GeneratePassword_CheckedChanged);
            // 
            // OpenWalletPath
            // 
            this.OpenWalletPath.FileName = "Default Wallet";
            this.OpenWalletPath.Filter = "Wallet Files|*.wallet|All files|*.*";
            // 
            // ServerPassword
            // 
            this.ServerPassword.Location = new System.Drawing.Point(65, 76);
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.PasswordChar = '*';
            this.ServerPassword.Size = new System.Drawing.Size(223, 20);
            this.ServerPassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // OpenServer
            // 
            this.OpenServer.Location = new System.Drawing.Point(213, 21);
            this.OpenServer.Name = "OpenServer";
            this.OpenServer.Size = new System.Drawing.Size(75, 20);
            this.OpenServer.TabIndex = 1;
            this.OpenServer.Text = "Browse";
            this.OpenServer.UseVisualStyleBackColor = true;
            this.OpenServer.Click += new System.EventHandler(this.OpenServer_Click);
            // 
            // ServerPath
            // 
            this.ServerPath.Location = new System.Drawing.Point(65, 21);
            this.ServerPath.Name = "ServerPath";
            this.ServerPath.Size = new System.Drawing.Size(142, 20);
            this.ServerPath.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // ServerPort
            // 
            this.ServerPort.Location = new System.Drawing.Point(65, 48);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(223, 20);
            this.ServerPort.TabIndex = 2;
            this.ServerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // OpenServerPath
            // 
            this.OpenServerPath.FileName = "walletd.exe";
            this.OpenServerPath.Filter = "Wallet Server|walletd.exe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DefaultMixin);
            this.groupBox4.Controls.Add(this.label99);
            this.groupBox4.Controls.Add(this.DefaultFee);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 80);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transactions";
            // 
            // DefaultMixin
            // 
            this.DefaultMixin.Location = new System.Drawing.Point(65, 48);
            this.DefaultMixin.Name = "DefaultMixin";
            this.DefaultMixin.Size = new System.Drawing.Size(223, 20);
            this.DefaultMixin.TabIndex = 3;
            this.DefaultMixin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(6, 51);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(31, 13);
            this.label99.TabIndex = 7;
            this.label99.Text = "Mixin";
            // 
            // DefaultFee
            // 
            this.DefaultFee.Location = new System.Drawing.Point(65, 21);
            this.DefaultFee.Name = "DefaultFee";
            this.DefaultFee.Size = new System.Drawing.Size(223, 20);
            this.DefaultFee.TabIndex = 2;
            this.DefaultFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalNumberOnly);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fee";
            // 
            // OptionsTabs
            // 
            this.OptionsTabs.Controls.Add(this.ConnectivityTab);
            this.OptionsTabs.Controls.Add(this.DefaultsTab);
            this.OptionsTabs.Controls.Add(this.RemoteTab);
            this.OptionsTabs.Controls.Add(this.MobileTab);
            this.OptionsTabs.Controls.Add(this.MiscTab);
            this.OptionsTabs.Location = new System.Drawing.Point(9, 9);
            this.OptionsTabs.Name = "OptionsTabs";
            this.OptionsTabs.SelectedIndex = 0;
            this.OptionsTabs.Size = new System.Drawing.Size(320, 291);
            this.OptionsTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.OptionsTabs.TabIndex = 11;
            // 
            // ConnectivityTab
            // 
            this.ConnectivityTab.BackColor = System.Drawing.Color.White;
            this.ConnectivityTab.Controls.Add(this.groupBox3);
            this.ConnectivityTab.Controls.Add(this.groupBox1);
            this.ConnectivityTab.Location = new System.Drawing.Point(4, 22);
            this.ConnectivityTab.Name = "ConnectivityTab";
            this.ConnectivityTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectivityTab.Size = new System.Drawing.Size(312, 265);
            this.ConnectivityTab.TabIndex = 0;
            this.ConnectivityTab.Text = "General";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GeneratePassword);
            this.groupBox3.Controls.Add(this.ServerPassword);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.OpenServer);
            this.groupBox3.Controls.Add(this.ServerPath);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ServerPort);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 139);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RPC Wallet Server";
            // 
            // MiscTab
            // 
            this.MiscTab.BackColor = System.Drawing.Color.White;
            this.MiscTab.Controls.Add(this.groupBox8);
            this.MiscTab.Controls.Add(this.groupBox2);
            this.MiscTab.Location = new System.Drawing.Point(4, 22);
            this.MiscTab.Name = "MiscTab";
            this.MiscTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscTab.Size = new System.Drawing.Size(312, 265);
            this.MiscTab.TabIndex = 1;
            this.MiscTab.Text = "Miscellaneous";
            // 
            // DefaultsTab
            // 
            this.DefaultsTab.BackColor = System.Drawing.Color.White;
            this.DefaultsTab.Controls.Add(this.groupBox5);
            this.DefaultsTab.Controls.Add(this.groupBox4);
            this.DefaultsTab.Location = new System.Drawing.Point(4, 22);
            this.DefaultsTab.Name = "DefaultsTab";
            this.DefaultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DefaultsTab.Size = new System.Drawing.Size(312, 265);
            this.DefaultsTab.TabIndex = 2;
            this.DefaultsTab.Text = "Defaults";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.OpenDefault);
            this.groupBox5.Controls.Add(this.DefaultAddress);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 53);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wallet";
            // 
            // MobileTab
            // 
            this.MobileTab.Controls.Add(this.groupBox6);
            this.MobileTab.Location = new System.Drawing.Point(4, 22);
            this.MobileTab.Name = "MobileTab";
            this.MobileTab.Padding = new System.Windows.Forms.Padding(3);
            this.MobileTab.Size = new System.Drawing.Size(312, 265);
            this.MobileTab.TabIndex = 3;
            this.MobileTab.Text = "Mobile";
            this.MobileTab.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.MobileWalletCheckbox);
            this.groupBox6.Controls.Add(this.MobileWalletPassword);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.MobileWalletPort);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(300, 108);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Connectivity";
            // 
            // MobileWalletCheckbox
            // 
            this.MobileWalletCheckbox.AutoSize = true;
            this.MobileWalletCheckbox.Location = new System.Drawing.Point(9, 80);
            this.MobileWalletCheckbox.Name = "MobileWalletCheckbox";
            this.MobileWalletCheckbox.Size = new System.Drawing.Size(126, 17);
            this.MobileWalletCheckbox.TabIndex = 4;
            this.MobileWalletCheckbox.Text = "Enable Mobile Wallet";
            this.MobileWalletCheckbox.UseVisualStyleBackColor = true;
            this.MobileWalletCheckbox.CheckedChanged += new System.EventHandler(this.MobileWalletCheckbox_CheckedChanged);
            // 
            // MobileWalletPassword
            // 
            this.MobileWalletPassword.Enabled = false;
            this.MobileWalletPassword.Location = new System.Drawing.Point(65, 48);
            this.MobileWalletPassword.Name = "MobileWalletPassword";
            this.MobileWalletPassword.PasswordChar = '*';
            this.MobileWalletPassword.Size = new System.Drawing.Size(223, 20);
            this.MobileWalletPassword.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password";
            // 
            // MobileWalletPort
            // 
            this.MobileWalletPort.Enabled = false;
            this.MobileWalletPort.Location = new System.Drawing.Point(65, 21);
            this.MobileWalletPort.Name = "MobileWalletPort";
            this.MobileWalletPort.Size = new System.Drawing.Size(223, 20);
            this.MobileWalletPort.TabIndex = 1;
            this.MobileWalletPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Port";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Location = new System.Drawing.Point(9, 47);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(152, 17);
            this.ConfirmPassword.TabIndex = 1;
            this.ConfirmPassword.Text = "Re-type password required";
            this.ConfirmPassword.UseVisualStyleBackColor = true;
            // 
            // RemoteTab
            // 
            this.RemoteTab.Controls.Add(this.groupBox7);
            this.RemoteTab.Location = new System.Drawing.Point(4, 22);
            this.RemoteTab.Name = "RemoteTab";
            this.RemoteTab.Padding = new System.Windows.Forms.Padding(3);
            this.RemoteTab.Size = new System.Drawing.Size(312, 265);
            this.RemoteTab.TabIndex = 4;
            this.RemoteTab.Text = "Remote RPC";
            this.RemoteTab.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.RemotePassword);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.RemoteAddress);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.RemotePort);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(300, 108);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Remote RPC Connection";
            // 
            // RemotePassword
            // 
            this.RemotePassword.Location = new System.Drawing.Point(65, 76);
            this.RemotePassword.Name = "RemotePassword";
            this.RemotePassword.PasswordChar = '*';
            this.RemotePassword.Size = new System.Drawing.Size(223, 20);
            this.RemotePassword.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Password";
            // 
            // RemoteAddress
            // 
            this.RemoteAddress.Location = new System.Drawing.Point(65, 21);
            this.RemoteAddress.Name = "RemoteAddress";
            this.RemoteAddress.Size = new System.Drawing.Size(223, 20);
            this.RemoteAddress.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Port";
            // 
            // RemotePort
            // 
            this.RemotePort.Location = new System.Drawing.Point(65, 48);
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(223, 20);
            this.RemotePort.TabIndex = 2;
            this.RemotePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.NetworkMonitor);
            this.groupBox8.Location = new System.Drawing.Point(6, 87);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(300, 47);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Network";
            // 
            // NetworkMonitor
            // 
            this.NetworkMonitor.AutoSize = true;
            this.NetworkMonitor.Location = new System.Drawing.Point(9, 19);
            this.NetworkMonitor.Name = "NetworkMonitor";
            this.NetworkMonitor.Size = new System.Drawing.Size(151, 17);
            this.NetworkMonitor.TabIndex = 0;
            this.NetworkMonitor.Text = "Enable network monitoring";
            this.NetworkMonitor.UseVisualStyleBackColor = true;
            // 
            // OptionsWindow
            // 
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 338);
            this.Controls.Add(this.OptionsTabs);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsWindow";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.OptionsTabs.ResumeLayout(false);
            this.ConnectivityTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.MiscTab.ResumeLayout(false);
            this.DefaultsTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.MobileTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.RemoteTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DefaultAddress;
        private System.Windows.Forms.Button OpenDefault;
        private System.Windows.Forms.CheckBox AllowBlankPasswords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NodeHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox LocalDaemonCheckbox;
        private System.Windows.Forms.TextBox NodePort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog OpenWalletPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ServerPort;
        private System.Windows.Forms.TextBox ServerPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OpenServer;
        private System.Windows.Forms.OpenFileDialog OpenServerPath;
        private System.Windows.Forms.TextBox ServerPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox GeneratePassword;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox DefaultFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DefaultMixin;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TabControl OptionsTabs;
        private System.Windows.Forms.TabPage ConnectivityTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage MiscTab;
        private System.Windows.Forms.TabPage DefaultsTab;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabPage MobileTab;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox MobileWalletCheckbox;
        private System.Windows.Forms.TextBox MobileWalletPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MobileWalletPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ConfirmPassword;
        private System.Windows.Forms.TabPage RemoteTab;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox RemotePassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RemoteAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RemotePort;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox NetworkMonitor;
    }
}