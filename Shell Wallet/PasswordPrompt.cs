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
            AcceptButton = Submit;

            // Don't include confirmation
            if (!Config.PasswordConfirmation)
            {
                Size = new System.Drawing.Size(300, 126);
                ConfirmPasswordBox.Visible = false;
                label2.Visible = false;
            }
        }

        /// <summary>
        /// Submit button was clicked
        /// </summary>
        private void SubmitClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Gets the entered password then clears it from memory
        /// </summary>
        internal String GetResult()
        {
            return PasswordBox.Text;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (Config.PasswordConfirmation && PasswordBox.Text != ConfirmPasswordBox.Text)
                {
                    MessageBox.Show("Passwords don't match!", "Error");
                    e.Cancel = true;
                }
            }
        }
    }
}
