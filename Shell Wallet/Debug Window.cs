using System;
using System.Windows.Forms;

namespace Shell_Wallet
{
    public partial class DebugWindow : Form
    {
        public DebugWindow()
        {
            InitializeComponent();
        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {
            // Assign update timer
            Timer t = new Timer();
            t.Tick += OnTimerTick;
            t.Interval = Config.GUIRefreshRate;
            t.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            this.DebugConsole.Text = ConsoleWriter.Output;
        }
    }
}
