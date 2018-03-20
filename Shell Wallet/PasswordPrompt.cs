using RPCWrapper;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shell_Wallet
{
    /// <summary>
    /// Prompts the user for a password
    /// </summary>
    partial class PasswordPrompt : Form
    {
        /// <summary>
        /// Init
        /// </summary>
        internal PasswordPrompt()
        {
            InitializeComponent();
            this.AcceptButton = this.Submit;
        }

        /// <summary>
        /// Submit button was clicked
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Gets the entered password then clears it from memory
        /// </summary>
        internal String GetResult()
        {
            return PasswordBox.Text;
        }

        private void PasswordPrompt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK && PasswordBox.Text != ConfirmPasswordBox.Text)
                {
                    MessageBox.Show("Passwords don't match!", "Error");
                    e.Cancel = true;
            }
        }
    }
}
