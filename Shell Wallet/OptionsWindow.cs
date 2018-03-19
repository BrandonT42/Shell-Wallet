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
            this.AcceptButton = this.ApplyButton;

            this.DefaultAddress.Text = Config.DefaultWalletPath;
            this.ServerPath.Text = Config.ServerPath;
            this.ServerPort.Text = Config.ServerPort;
            this.NodeHost.Text = Config.NodeHost;
            this.NodePort.Text = Config.NodePort;
            this.AllowBlankPasswords.Checked = Config.AllowBlankPasswords;
            this.LocalDaemonCheckbox.Checked = Config.LocalDaemon;
            this.LocalDaemonCheckbox_CheckedChanged(null, null);
            this.GeneratePassword.Checked = Config.GeneratePassword;
            this.GeneratePassword_CheckedChanged(null, null);
            if (Config.GeneratePassword) this.ServerPassword.Text = Config.OriginalServerPassword;
            else this.ServerPassword.Text = Config.ServerPassword;
            this.DefaultFee.Text = Config.DefaultFee;
            this.DefaultMixin.Text = Config.DefaultMixin;
            this.MobileWalletCheckbox.Checked = Config.EnableMobile;
            this.MobileWalletPassword.Text = Config.MobilePassword;
            this.MobileWalletPort.Text = Config.MobilePort;

        }

        /// <summary>
        /// Use local daemon option changed
        /// </summary>
        private void LocalDaemonCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalDaemonCheckbox.Checked)
            {
                this.NodeHost.ReadOnly = true;
                this.NodePort.ReadOnly = true;
            }
            else
            {
                this.NodeHost.ReadOnly = false;
                this.NodePort.ReadOnly = false;
            }
        }

        /// <summary>
        /// Open default wallet file search dialog
        /// </summary>
        private void OpenDefault_Click(object sender, EventArgs e)
        {
            if (OpenWalletPath.ShowDialog() == DialogResult.OK)
            {
                if (OpenWalletPath.CheckFileExists) this.DefaultAddress.Text = OpenWalletPath.FileName;
                else MessageBox.Show("Please select a file that exists", "Error!");
            }
        }

        /// <summary>
        /// Apply option changes
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // Check if password is blank
            if (!this.GeneratePassword.Checked && this.ServerPassword.Text.Length < 1)
            {
                MessageBox.Show("Server password must be entered if one is not being generated", "Error");
                return;
            }

            // Ask if they really want to allow blank passwords
            if (this.AllowBlankPasswords.Checked)
                if (MessageBox.Show("You are choosing to allow creation of wallets without passwords, which is not secure. Are you sure you wish to continue?",
                    "Security Notice", MessageBoxButtons.YesNo) == DialogResult.No) return;

            // Flush choices to config then save file
            Config.DefaultWalletPath = this.DefaultAddress.Text;
            Config.ServerPath = this.ServerPath.Text;
            Config.ServerPort = this.ServerPort.Text;
            Config.GeneratePassword = this.GeneratePassword.Checked;
            if (Config.GeneratePassword) Config.OriginalServerPassword = this.ServerPassword.Text;
            else Config.ServerPassword = this.ServerPassword.Text;
            Config.NodeHost = this.NodeHost.Text;
            Config.NodePort = this.NodePort.Text;
            Config.AllowBlankPasswords = this.AllowBlankPasswords.Checked;
            Config.LocalDaemon = this.LocalDaemonCheckbox.Checked;
            Config.DefaultFee = this.DefaultFee.Text;
            Config.DefaultMixin = this.DefaultMixin.Text;
            Config.EnableMobile = this.MobileWalletCheckbox.Checked;
            Config.MobilePassword = this.MobileWalletPassword.Text;
            Config.MobilePort = this.MobileWalletPort.Text;
            Config.Save();

            // Close Dialog
            this.Close();
        }

        /// <summary>
        /// Cancel any changes 
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close Dialog
            this.Close();
        }

        /// <summary>
        /// Open server file search dialog
        /// </summary>
        private void OpenServer_Click(object sender, EventArgs e)
        {
            if (OpenServerPath.ShowDialog() == DialogResult.OK)
            {
                if (OpenServerPath.CheckFileExists) this.DefaultAddress.Text = OpenServerPath.FileName;
                else MessageBox.Show("Please select a file that exists", "Error!");
            }
        }

        /// <summary>
        /// Generate password option changed
        /// </summary>
        private void GeneratePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (GeneratePassword.Checked) this.ServerPassword.ReadOnly = true;
            else this.ServerPassword.ReadOnly = false;
        }

        /// <summary>
        /// Lets numbers be input
        /// </summary>
        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))e.Handled = true;
        }

        /// <summary>
        /// Lets only numbers with a single decimal place be input
        /// </summary>
        private void DecimalNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        /// <summary>
        /// Server password changes
        /// </summary>
        private void ServerPassword_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        /// <summary>
        /// Disables spaces in password input
        /// </summary>
        private void ServerPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

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
