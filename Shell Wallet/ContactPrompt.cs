using System.Windows.Forms;

namespace Shell_Wallet
{
    /// <summary>
    /// Creates a prompt to create or edit contact in address book
    /// </summary>
    partial class ContactPrompt : Form
    {
        /// <summary>
        /// Init as create prompt
        /// </summary>
        internal ContactPrompt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Init as edit prompt
        /// </summary>
        internal ContactPrompt(Contact c)
        {
            InitializeComponent();
            this.Text = "Edit Address";
            if (c.Name != null) this.NameBox.Text = c.Name;
            if (c.Address != null) this.Address.Text = c.Address;
            if (c.PaymentID != null) this.PaymentID.Text = c.PaymentID;
        }

        /// <summary>
        /// Returns entered contact information
        /// </summary>
        internal Contact GetResult()
        {
            Contact c = new Contact();
            c.Name = this.NameBox.Text;
            c.Address = this.Address.Text;
            c.PaymentID = this.PaymentID.Text;
            return c;
        }
    }
}
