namespace Shell_Wallet
{
    partial class ImportKeys
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewKeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpendKeyBox = new System.Windows.Forms.TextBox();
            this.Import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Key";
            // 
            // ViewKeyBox
            // 
            this.ViewKeyBox.Location = new System.Drawing.Point(9, 25);
            this.ViewKeyBox.Name = "ViewKeyBox";
            this.ViewKeyBox.Size = new System.Drawing.Size(363, 20);
            this.ViewKeyBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spend Key";
            // 
            // SpendKeyBox
            // 
            this.SpendKeyBox.Location = new System.Drawing.Point(9, 64);
            this.SpendKeyBox.Name = "SpendKeyBox";
            this.SpendKeyBox.Size = new System.Drawing.Size(366, 20);
            this.SpendKeyBox.TabIndex = 3;
            // 
            // Import
            // 
            this.Import.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Import.Location = new System.Drawing.Point(9, 92);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(366, 23);
            this.Import.TabIndex = 4;
            this.Import.Text = "Import Keys";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // ImportKeys
            // 
            this.AcceptButton = this.Import;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 124);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.SpendKeyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewKeyBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportKeys";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ViewKeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpendKeyBox;
        private System.Windows.Forms.Button Import;
    }
}