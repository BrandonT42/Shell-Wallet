using System;
using System.Threading;
using System.Windows.Forms;
using RPCWrapper;

namespace Shell_Wallet
{
    public partial class LoadingPrompt : Form
    {
        private String Path, Password;

        public LoadingPrompt(String Path, String Password)
        {
            InitializeComponent();
            this.Path = Path;
            this.Password = Password;
            DialogResult = DialogResult.None;
        }

        private void LoadingPrompt_Shown(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer
            {
                Interval = 100
            };
            t.Tick += Update;
            t.Start();

            Thread h = new Thread(CheckPassword);
            h.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            // Check if result has been found
            if (DialogResult != DialogResult.None)
                this.Close();
        }

        private void CheckPassword()
        {
            if (Wallet.CheckPassword(Config.ServerPath, this.Path, this.Password))
                DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }
    }
}
