namespace LibraryManagement.Forms
{
    partial class AddLoanDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddLoanID = new System.Windows.Forms.Button();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLoanID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddLoanID);
            this.panel1.Controls.Add(this.tbEmpID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbMemberID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbLoanID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvLoan);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 404);
            this.panel1.TabIndex = 0;
            // 
            // btnAddLoanID
            // 
            this.btnAddLoanID.Location = new System.Drawing.Point(243, 52);
            this.btnAddLoanID.Name = "btnAddLoanID";
            this.btnAddLoanID.Size = new System.Drawing.Size(120, 40);
            this.btnAddLoanID.TabIndex = 7;
            this.btnAddLoanID.Text = "Add";
            this.btnAddLoanID.UseVisualStyleBackColor = true;
            this.btnAddLoanID.Click += new System.EventHandler(this.btnAddLoanID_Click);
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(502, 15);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(100, 22);
            this.tbEmpID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee ID";
            // 
            // tbMemberID
            // 
            this.tbMemberID.Location = new System.Drawing.Point(287, 15);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(100, 22);
            this.tbMemberID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Member ID";
            // 
            // tbLoanID
            // 
            this.tbLoanID.Location = new System.Drawing.Point(72, 15);
            this.tbLoanID.Name = "tbLoanID";
            this.tbLoanID.Size = new System.Drawing.Size(100, 22);
            this.tbLoanID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan ID";
            // 
            // dgvLoan
            // 
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoan.Location = new System.Drawing.Point(0, 186);
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.RowHeadersWidth = 51;
            this.dgvLoan.RowTemplate.Height = 24;
            this.dgvLoan.Size = new System.Drawing.Size(1129, 218);
            this.dgvLoan.TabIndex = 0;
            // 
            // AddLoanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 428);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddLoanDetail";
            this.Text = "Add new loan detail";
            this.Load += new System.EventHandler(this.AddNewLoanID_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLoanID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoan;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddLoanID;
    }
}