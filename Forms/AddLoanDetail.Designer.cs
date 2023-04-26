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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowing = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCondition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbBookID = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpReturn);
            this.panel1.Controls.Add(this.dtpDueDate);
            this.panel1.Controls.Add(this.dtpBorrowing);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbCondition);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbNote);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbBookID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbMemberID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbLoanID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvLoan);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 465);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(272, 153);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(659, 153);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 40);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Return date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Due date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Borrowing date";
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "dd/MM/yyyy";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(649, 104);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(153, 22);
            this.dtpReturn.TabIndex = 18;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(371, 104);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(153, 22);
            this.dtpDueDate.TabIndex = 17;
            // 
            // dtpBorrowing
            // 
            this.dtpBorrowing.CustomFormat = "";
            this.dtpBorrowing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowing.Location = new System.Drawing.Point(115, 104);
            this.dtpBorrowing.Name = "dtpBorrowing";
            this.dtpBorrowing.Size = new System.Drawing.Size(153, 22);
            this.dtpBorrowing.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(456, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loan detail";
            // 
            // tbCondition
            // 
            this.tbCondition.Location = new System.Drawing.Point(649, 74);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(153, 22);
            this.tbCondition.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Condition";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(649, 46);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(153, 22);
            this.tbNote.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Note";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(371, 74);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(153, 22);
            this.tbAmount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(79, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(371, 46);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(153, 22);
            this.tbBookID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book ID";
            // 
            // tbMemberID
            // 
            this.tbMemberID.Location = new System.Drawing.Point(115, 74);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(153, 22);
            this.tbMemberID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Member ID";
            // 
            // tbLoanID
            // 
            this.tbLoanID.Location = new System.Drawing.Point(115, 46);
            this.tbLoanID.Name = "tbLoanID";
            this.tbLoanID.Size = new System.Drawing.Size(153, 22);
            this.tbLoanID.TabIndex = 2;
            this.tbLoanID.TextChanged += new System.EventHandler(this.tbLoanID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan ID";
            // 
            // dgvLoan
            // 
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoan.Location = new System.Drawing.Point(0, 220);
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.RowHeadersWidth = 51;
            this.dgvLoan.RowTemplate.Height = 24;
            this.dgvLoan.ShowEditingIcon = false;
            this.dgvLoan.Size = new System.Drawing.Size(822, 245);
            this.dgvLoan.TabIndex = 0;
            this.dgvLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoan_CellClick);
            // 
            // AddLoanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 493);
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
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCondition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowing;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEdit;
    }
}