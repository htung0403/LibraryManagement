using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FormReturn : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormReturn()
        {
            InitializeComponent();
        }

        private void FormReturnBook_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from CTMuonTra";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoanDetail.DataSource = table;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            string loanID = tbLoanID.Text.Trim();
            string bookID = tbBookID.Text.Trim();
            int amount = int.Parse(tbAmount.Text);
            string note = tbNote.Text;

            string query = "Proc_TraSach";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaMuonTra", loanID);
                command.Parameters.AddWithValue("@MaSach", bookID);
                command.Parameters.AddWithValue("@SoLuongTRA", amount);
                command.Parameters.AddWithValue("@ghichu", note);
                try
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Đã cập nhật thông tin trả sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData();
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
        }

        private void dgvLoanDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    tbLoanID.Text = dgvLoanDetail.Rows[i].Cells[0].Value.ToString();
                    tbBookID.Text = dgvLoanDetail.Rows[i].Cells[1].Value.ToString();
                    tbAmount.Text = dgvLoanDetail.Rows[i].Cells[2].Value.ToString();
                    tbNote.Text = dgvLoanDetail.Rows[i].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
