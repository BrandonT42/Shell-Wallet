namespace Shell_Wallet
{
    partial class DebugWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DebugConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DebugConsole
            // 
            this.DebugConsole.BackColor = System.Drawing.Color.Black;
            this.DebugConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugConsole.ForeColor = System.Drawing.Color.White;
            this.DebugConsole.Location = new System.Drawing.Point(0, 0);
            this.DebugConsole.Multiline = true;
            this.DebugConsole.Name = "DebugConsole";
            this.DebugConsole.ReadOnly = true;
            this.DebugConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugConsole.Size = new System.Drawing.Size(800, 331);
            this.DebugConsole.TabIndex = 0;
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.ControlBox = false;
            this.Controls.Add(this.DebugConsole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugWindow";
            this.ShowIcon = false;
            this.Text = "Debug Console";
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox DebugConsole;
    }
}