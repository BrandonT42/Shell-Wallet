using RPCWrapper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shell_Wallet
{
    public partial class TransactionInfo : Form
    {
        public TransactionInfo(Transaction Transaction)
        {
            // Initialize
            InitializeComponent();

            // Populate variables
            Hash.Text = Transaction.Hash;
            Amount.Text = Transaction.Amount.ToString();
            Date.Text = Transaction.TimeStamp;
            Fee.Text = Transaction.Fee.ToString();
            BlockIndex.Text = Transaction.BlockIndex;
            PaymentID.Text = Transaction.PaymentID;
            Extra.Text = Transaction.Extra;
            Transfers.DataSource = Transaction.Transfers;
        }
    }
}
