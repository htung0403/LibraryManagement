namespace LibraryManagement.Forms
{
    partial class FormLibraryLoan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muonToolStripMenuItem,
            this.traToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muonToolStripMenuItem
            // 
            this.muonToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muonToolStripMenuItem.Name = "muonToolStripMenuItem";
            this.muonToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.muonToolStripMenuItem.Text = "Loan Management";
            this.muonToolStripMenuItem.Click += new System.EventHandler(this.muonToolStripMenuItem_Click);
            // 
            // traToolStripMenuItem
            // 
            this.traToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traToolStripMenuItem.Name = "traToolStripMenuItem";
            this.traToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.traToolStripMenuItem.Text = "Return Management";
            this.traToolStripMenuItem.Click += new System.EventHandler(this.traToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1094, 657);
            this.panelMain.TabIndex = 1;
            // 
            // FormLibraryLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 687);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLibraryLoan";
            this.Text = "FormLibraryLoan";
            this.Load += new System.EventHandler(this.FormLibraryLoan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
    }
}