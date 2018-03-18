using System;
using System.Windows.Forms;

namespace Shell_Wallet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            // Set up application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(args));

            // Log output
            ConsoleWriter.FlushOutput();
        }
    }
}
