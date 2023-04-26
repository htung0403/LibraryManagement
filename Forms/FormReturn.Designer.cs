namespace LibraryManagement.Forms
{
    partial class FormReturn
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
            this.dgvLoanDetail = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoanID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoanDetail
            // 
            this.dgvLoanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoanDetail.Location = new System.Drawing.Point(0, 124);
            this.dgvLoanDetail.Name = "dgvLoanDetail";
            this.dgvLoanDetail.RowHeadersWidth = 51;
            this.dgvLoanDetail.RowTemplate.Height = 24;
            this.dgvLoanDetail.ShowEditingIcon = false;
            this.dgvLoanDetail.Size = new System.Drawing.Size(1036, 444);
            this.dgvLoanDetail.TabIndex = 0;
            this.dgvLoanDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanDetail_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbBookID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbLoanID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvLoanDetail);
            this.panel1.Location = new System.Drawing.Point(31, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 568);
            this.panel1.TabIndex = 1;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(890, 13);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(138, 22);
            this.tbNote.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Note";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(654, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 45);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(286, 58);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 45);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(635, 13);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(138, 22);
            this.tbAmount.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Amount";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(344, 13);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(138, 22);
            this.tbBookID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Book ID";
            // 
            // tbLoanID
            // 
            this.tbLoanID.Location = new System.Drawing.Point(88, 13);
            this.tbLoanID.Name = "tbLoanID";
            this.tbLoanID.Size = new System.Drawing.Size(138, 22);
            this.tbLoanID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Loan ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Return book";
            // 
            // FormReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReturn";
            this.Text = "FormReturnBook";
            this.Load += new System.EventHandler(this.FormReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoanDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLoanID;
        private System.Windows.Forms.Label label2;
    }
}