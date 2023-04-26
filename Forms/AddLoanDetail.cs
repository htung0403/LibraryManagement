using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string loanID = tbLoanID.Text.Trim();
            string memberID = tbMemberID.Text.Trim();
            string bookID = tbBookID.Text.Trim();
            string note = tbNote.Text;
            string condition = tbCondition.Text;
            string query = "SELECT * FROM dbo.TimCTMuonTra(@MaMT, @MaS, @TinhTrang, @GhiChu)";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;

                adapter.SelectCommand.Parameters.AddWithValue("@MaMT", string.IsNullOrEmpty(loanID) ? (object)DBNull.Value : loanID);
                adapter.SelectCommand.Parameters.AddWithValue("@MaS", string.IsNullOrEmpty(bookID) ? (object)DBNull.Value : bookID);
                adapter.SelectCommand.Parameters.AddWithValue("@TinhTrang", string.IsNullOrEmpty(condition) ? (object)DBNull.Value : condition);
                adapter.SelectCommand.Parameters.AddWithValue("@GhiChu", string.IsNullOrEmpty(note) ? (object)DBNull.Value : note);
                // Thực hiện truy vấn SQL
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvLoan.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả nào phù hợp với từ khóa tìm kiếm");
                }
            }
        }
        private void dgvLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    tbLoanID.Text = dgvLoan.Rows[i].Cells[0].Value.ToString();
                    tbBookID.Text = dgvLoan.Rows[i].Cells[1].Value.ToString();
                    tbAmount.Text = dgvLoan.Rows[i].Cells[2].Value.ToString();
                    dtpBorrowing.Text = dgvLoan.Rows[i].Cells[3].Value.ToString();
                    dtpDueDate.Text = dgvLoan.Rows[i].Cells[4].Value.ToString();
                    dtpReturn.Text = dgvLoan.Rows[i].Cells[5].Value.ToString();
                    tbCondition.Text = dgvLoan.Rows[i].Cells[6].Value.ToString();
                    tbNote.Text = dgvLoan.Rows[i].Cells[7].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            AddNewLoanID_Load(sender, e);
            tbLoanID.Text = null;
            tbAmount.Text = null;
            tbCondition.Text = null;
            tbMemberID.Text = null;
            tbNote.Text = null;
            tbBookID.Text = null;
            dtpBorrowing.Text = null;
            dtpDueDate.Text = null;
            dtpReturn.Text = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Lấy thông tin từ các textbox
            string loanID = tbLoanID.Text.Trim();
            string memberID = tbMemberID.Text.Trim();
            string bookID = tbBookID.Text.Trim();
            string note = tbNote.Text;
            string condition = tbCondition.Text;
            int amount = 0;
            if (!int.TryParse(tbAmount.Text.Trim(), out amount))
            {
                amount = 0;
            }
            //Kết nối đến CSDL

            try
            {
                //Tạo command và truyền thông tin
                using (SqlCommand cmd = new SqlCommand("SuaThongTin_CTMuonTra", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaMT", loanID);
                    cmd.Parameters.AddWithValue("@MaS", bookID);
                    cmd.Parameters.AddWithValue("@Sluong", amount);
                    cmd.Parameters.AddWithValue("@tinhtrang", condition);
                    cmd.Parameters.AddWithValue("@ghichu", note);
                    //Thực thi command
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbLoanID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
