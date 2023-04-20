﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement.Forms
{
    public partial class AddLoanDetail : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public AddLoanDetail(string loanID, string memberID)
        {
            InitializeComponent();
            tbLoanID.Text = loanID;
            tbMemberID.Text = memberID;

        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from CTMuonTra";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoan.DataSource = table;
        }

        private void AddNewLoanID_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhập từ người dùng
            string loanID = tbLoanID.Text.Trim();
            string memberID = tbMemberID.Text.Trim();
            string bookID = tbBookID.Text.Trim();
            int amount = int.Parse(tbAmount.Text);
            string note = tbNote.Text;
            string condition = tbCondition.Text;

            string query = "CTMuonSach";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaMT", loanID);
                command.Parameters.AddWithValue("@MaS", bookID);
                command.Parameters.AddWithValue("@SLuong", amount);
                command.Parameters.AddWithValue("@tinhtrang", condition);
                command.Parameters.AddWithValue("@ghichu", note);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin mượn sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
