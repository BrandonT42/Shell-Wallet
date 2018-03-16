using System;
using System.Windows.Forms;

namespace Shell_Wallet
{
    /// <summary>
    /// Creates a window for entering private keys
    /// </summary>
    partial class ImportKeys : Form
    {
        /// <summary>
        /// Init
        /// </summary>
        internal ImportKeys()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets entered view key
        /// </summary>
        internal String ViewKey
        {
            get
            {
                return this.ViewKeyBox.Text;
            }
        }

        /// <summary>
        /// Gets entered spend key
        /// </summary>
        internal String SpendKey
        {
            get
            {
                return this.SpendKeyBox.Text;
            }
        }

        /// <summary>
        /// Submit entered private keys
        /// </summary>
        private void Import_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
