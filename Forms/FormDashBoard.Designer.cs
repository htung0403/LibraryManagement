namespace LibraryManagement.Forms
{
    partial class FormDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPublisher = new System.Windows.Forms.Panel();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelBookBorrowed = new System.Windows.Forms.Panel();
            this.labelBookBorrowed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelNotReturned = new System.Windows.Forms.Panel();
            this.labelReaderNotReturned = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelOverdueBooks = new System.Windows.Forms.Panel();
            this.labelOverdueBooks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAmount.SuspendLayout();
            this.panelPublisher.SuspendLayout();
            this.panelBookBorrowed.SuspendLayout();
            this.panelNotReturned.SuspendLayout();
            this.panelOverdueBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(37, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 396);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelAmount
            // 
            this.panelAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelAmount.Controls.Add(this.labelAmount);
            this.panelAmount.Controls.Add(this.label2);
            this.panelAmount.Location = new System.Drawing.Point(22, 100);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(127, 72);
            this.panelAmount.TabIndex = 25;
            this.panelAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAmount_MouseClick);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(38, 37);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 32);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount ";
            // 
            // panelPublisher
            // 
            this.panelPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelPublisher.Controls.Add(this.labelPublisher);
            this.panelPublisher.Controls.Add(this.label7);
            this.panelPublisher.Location = new System.Drawing.Point(201, 100);
            this.panelPublisher.Name = "panelPublisher";
            this.panelPublisher.Size = new System.Drawing.Size(127, 72);
            this.panelPublisher.TabIndex = 27;
            this.panelPublisher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPublisher_MouseClick);
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.Location = new System.Drawing.Point(43, 37);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(48, 32);
            this.labelPublisher.TabIndex = 1;
            this.labelPublisher.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Publisher";
            // 
            // panelBookBorrowed
            // 
            this.panelBookBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelBookBorrowed.Controls.Add(this.labelBookBorrowed);
            this.panelBookBorrowed.Controls.Add(this.label9);
            this.panelBookBorrowed.Location = new System.Drawing.Point(375, 100);
            this.panelBookBorrowed.Name = "panelBookBorrowed";
            this.panelBookBorrowed.Size = new System.Drawing.Size(247, 72);
            this.panelBookBorrowed.TabIndex = 28;
            this.panelBookBorrowed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBookBorrowed_MouseClick);
            // 
            // labelBookBorrowed
            // 
            this.labelBookBorrowed.AutoSize = true;
            this.labelBookBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookBorrowed.Location = new System.Drawing.Point(89, 37);
            this.labelBookBorrowed.Name = "labelBookBorrowed";
            this.labelBookBorrowed.Size = new System.Drawing.Size(48, 32);
            this.labelBookBorrowed.TabIndex = 1;
            this.labelBookBorrowed.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Number of book borrowed";
            // 
            // panelNotReturned
            // 
            this.panelNotReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelNotReturned.Controls.Add(this.labelReaderNotReturned);
            this.panelNotReturned.Controls.Add(this.label4);
            this.panelNotReturned.Location = new System.Drawing.Point(663, 100);
            this.panelNotReturned.Name = "panelNotReturned";
            this.panelNotReturned.Size = new System.Drawing.Size(199, 72);
            this.panelNotReturned.TabIndex = 29;
            this.panelNotReturned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelNotReturned_MouseClick);
            // 
            // labelReaderNotReturned
            // 
            this.labelReaderNotReturned.AutoSize = true;
            this.labelReaderNotReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReaderNotReturned.Location = new System.Drawing.Point(75, 37);
            this.labelReaderNotReturned.Name = "labelReaderNotReturned";
            this.labelReaderNotReturned.Size = new System.Drawing.Size(48, 32);
            this.labelReaderNotReturned.TabIndex = 1;
            this.labelReaderNotReturned.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reader not returned";
            // 
            // panelOverdueBooks
            // 
            this.panelOverdueBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelOverdueBooks.Controls.Add(this.labelOverdueBooks);
            this.panelOverdueBooks.Controls.Add(this.label6);
            this.panelOverdueBooks.Location = new System.Drawing.Point(895, 97);
            this.panelOverdueBooks.Name = "panelOverdueBooks";
            this.panelOverdueBooks.Size = new System.Drawing.Size(154, 72);
            this.panelOverdueBooks.TabIndex = 30;
            this.panelOverdueBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOverdueBooks_MouseClick);
            // 
            // labelOverdueBooks
            // 
            this.labelOverdueBooks.AutoSize = true;
            this.labelOverdueBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverdueBooks.Location = new System.Drawing.Point(48, 37);
            this.labelOverdueBooks.Name = "labelOverdueBooks";
            this.labelOverdueBooks.Size = new System.Drawing.Size(48, 32);
            this.labelOverdueBooks.TabIndex = 1;
            this.labelOverdueBooks.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Overdue books";
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 640);
            this.Controls.Add(this.panelOverdueBooks);
            this.Controls.Add(this.panelNotReturned);
            this.Controls.Add(this.panelBookBorrowed);
            this.Controls.Add(this.panelPublisher);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashBoard";
            this.Text = "FormDashBoard";
            this.Load += new System.EventHandler(this.FormDashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAmount.ResumeLayout(false);
            this.panelAmount.PerformLayout();
            this.panelPublisher.ResumeLayout(false);
            this.panelPublisher.PerformLayout();
            this.panelBookBorrowed.ResumeLayout(false);
            this.panelBookBorrowed.PerformLayout();
            this.panelNotReturned.ResumeLayout(false);
            this.panelNotReturned.PerformLayout();
            this.panelOverdueBooks.ResumeLayout(false);
            this.panelOverdueBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPublisher;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelBookBorrowed;
        private System.Windows.Forms.Label labelBookBorrowed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelNotReturned;
        private System.Windows.Forms.Label labelReaderNotReturned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelOverdueBooks;
        private System.Windows.Forms.Label labelOverdueBooks;
        private System.Windows.Forms.Label label6;
    }
}