using RPCWrapper;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shell_Wallet
{
    /// <summary>
    /// Opens the options window
    /// </summary>
    partial class OptionsWindow : Form
    {
        /// <summary>
        /// Init
        /// </summary>
        internal OptionsWindow()
        {
            InitializeComponent();
            AcceptButton = ApplyButton;

            DefaultAddress.Text = Config.DefaultWalletPath;
            ServerPath.Text = Config.ServerPath;
            ServerPort.Text = Config.ServerPort.ToString();
            NodeHost.Text = Config.NodeHost;
            NodePort.Text = Config.NodePort.ToString();
            AllowBlankPasswords.Checked = Config.AllowBlankPasswords;
            LocalDaemonCheckbox.Checked = Config.LocalDaemon;
            LocalDaemonCheckbox_CheckedChanged(null, null);
            GeneratePassword.Checked = Config.GeneratePassword;
            GeneratePassword_CheckedChanged(null, null);
            if (Config.GeneratePassword) ServerPassword.Text = Config.OriginalServerPassword;
            else ServerPassword.Text = Config.ServerPassword;
            DefaultFee.Text = Config.DefaultFee;
            DefaultMixin.Text = Config.DefaultMixin;
            MobileWalletCheckbox.Checked = Config.EnableMobile;
            MobileWalletPassword.Text = Config.MobilePassword;
            MobileWalletPort.Text = Config.MobilePort;
            ConfirmPassword.Checked = Config.PasswordConfirmation;
            RemoteAddress.Text = Config.RemotePath;
            RemotePort.Text = Config.RemotePort.ToString();
            RemotePassword.Text = Config.RemotePassword;
            NetworkMonitor.Checked = Config.NetworkMonitor;
        }

        /// <summary>
        /// Use local daemon option changed
        /// </summary>
        private void LocalDaemonCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalDaemonCheckbox.Checked)
            {
                NodeHost.ReadOnly = true;
            }
            else
            {
                NodeHost.ReadOnly = false;
            }
        }

        /// <summary>
        /// Open default wallet file search dialog
        /// </summary>
        private void OpenDefault_Click(object sender, EventArgs e)
        {
            if (OpenWalletPath.ShowDialog() == DialogResult.OK)
            {
                if (OpenWalletPath.CheckFileExists) DefaultAddress.Text = OpenWalletPath.FileName;
                else MessageBox.Show("Please select a file that exists", "Error!");
            }
        }

        /// <summary>
        /// Apply option changes
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // Check if password is blank
            if (!this.GeneratePassword.Checked && ServerPassword.Text.Length < 1)
            {
                MessageBox.Show("Server password must be entered if one is not being generated", "Error");
                return;
            }

            // Ask if they really want to allow blank passwords
            if (this.AllowBlankPasswords.Checked)
                if (MessageBox.Show("You are choosing to allow creation of wallets without passwords, which is not secure. Are you sure you wish to continue?",
                    "Security Notice", MessageBoxButtons.YesNo) == DialogResult.No) return;

            // Flush choices to config then save file
            Config.DefaultWalletPath = DefaultAddress.Text;
            Config.ServerPath = ServerPath.Text;
            Config.ServerPort = int.Parse(this.ServerPort.Text);
            Config.GeneratePassword = GeneratePassword.Checked;
            if (Config.GeneratePassword) Config.OriginalServerPassword = ServerPassword.Text;
            else Config.ServerPassword = ServerPassword.Text;
            Config.NodeHost = NodeHost.Text;
            Config.NodePort = int.Parse(this.NodePort.Text);
            Config.AllowBlankPasswords = AllowBlankPasswords.Checked;
            Config.LocalDaemon = LocalDaemonCheckbox.Checked;
            Config.DefaultFee = DefaultFee.Text;
            Config.DefaultMixin = DefaultMixin.Text;
            Config.EnableMobile = MobileWalletCheckbox.Checked;
            Config.MobilePassword = MobileWalletPassword.Text;
            Config.MobilePort = MobileWalletPort.Text;
            Config.PasswordConfirmation = ConfirmPassword.Checked;
            Config.NetworkMonitor = NetworkMonitor.Checked;
            Config.RemotePath = RemoteAddress.Text;
            Config.RemotePort = int.Parse(RemotePort.Text);
            Config.RemotePassword = RemotePassword.Text;
            Config.Save();

            // Update network monitoring
            Server.NetworkMonitor = Config.NetworkMonitor;

            // Close Dialog
            Close();
        }

        /// <summary>
        /// Cancel any changes 
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close Dialog
            Close();
        }

        /// <summary>
        /// Open server file search dialog
        /// </summary>
        private void OpenServer_Click(object sender, EventArgs e)
        {
            if (OpenServerPath.ShowDialog() == DialogResult.OK)
            {
                if (OpenServerPath.CheckFileExists) DefaultAddress.Text = OpenServerPath.FileName;
                else MessageBox.Show("Please select a file that exists", "Error!");
            }
        }

        /// <summary>
        /// Generate password option changed
        /// </summary>
        private void GeneratePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (GeneratePassword.Checked) ServerPassword.ReadOnly = true;
            else ServerPassword.ReadOnly = false;
        }

        /// <summary>
        /// Lets numbers be input
        /// </summary>
        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (sender as TextBox).Text.Length <= 5)e.Handled = true;
        }

        /// <summary>
        /// Lets only numbers with a single decimal place be input
        /// </summary>
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

        /// <summary>
        /// Mobile wallet enabled or disabled
        /// </summary>
        private void MobileWalletCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (MobileWalletCheckbox.Checked)
            {
                MobileWalletPort.Enabled = true;
                MobileWalletPassword.Enabled = true;
            }
            else if (!MobileWalletCheckbox.Checked)
            {
                MobileWalletPort.Enabled = false;
                MobileWalletPassword.Enabled = false;
            }
        }
    }
}
