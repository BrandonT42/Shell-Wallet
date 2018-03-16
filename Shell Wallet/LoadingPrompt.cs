using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletWrapper;

namespace Shell_Wallet
{
    public partial class LoadingPrompt : Form
    {
        private static DialogResult Result;
        private String Path, Password;

        public LoadingPrompt(String Path, String Password)
        {
            InitializeComponent();
            this.Path = Path;
            this.Password = Password;
            this.label1.Text = "Opening wallet...";
            Result = DialogResult.None;
        }

        private void LoadingPrompt_Shown(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 500;
            t.Tick += Update;
            t.Start();

            Thread h = new Thread(CheckPassword);
            h.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            // Check if result has been found
            if (Result != DialogResult.None)
            {
                this.DialogResult = Result;
                this.Close();
            }
        }

        private void CheckPassword()
        {
            if (Server.CheckPassword(Config.ServerPath, this.Path, this.Password))
            {
                Result = DialogResult.OK;
            }
            else Result = DialogResult.Cancel;
        }
    }
}
