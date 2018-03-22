using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell_Wallet
{
    public partial class RemoteReminder : Form
    {
        public RemoteReminder()
        {
            InitializeComponent();
        }

        private void RemoteReminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DoNotShow.Checked) Config.RemoteReminder = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
