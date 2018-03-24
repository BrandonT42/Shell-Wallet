using RPCWrapper;
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
    public partial class NicknamePrompt : Form
    {
        public String Result;

        public NicknamePrompt()
        {
            InitializeComponent();
            Nickname.Text = Nicknames.Get(Wallet.SelectedAddress);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Result = Nickname.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
