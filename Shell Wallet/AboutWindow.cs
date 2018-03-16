using System;
using System.Reflection;
using System.Windows.Forms;

namespace Shell_Wallet
{
    /// <summary>
    /// Opens application about window
    /// </summary>
    partial class AboutWindow : Form
    {
        #region Variables
        internal string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        internal string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        #endregion

        /// <summary>
        /// Init
        /// </summary>
        internal AboutWindow()
        {
            InitializeComponent();
            this.VersionLabel.Text = this.AssemblyVersion;
            this.CoprightLabel.Text = this.AssemblyCopyright;
            this.BuildRevisionLabel.Text = Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
            this.BuildDateLabel.Text = buildDate.ToString();
        }

        /// <summary>
        /// Close button clicked
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
