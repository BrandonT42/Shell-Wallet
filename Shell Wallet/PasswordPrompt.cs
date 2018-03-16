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
            this.AcceptButton = this.button1;
        }

        /// <summary>
        /// Submit button was clicked
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Gets the entered password then clears it from memory
        /// </summary>
        internal String GetResult()
        {
            return this.PasswordBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }
    }
}
