using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement.Forms
{
    public partial class FormLoan : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormLoan()
        {
            InitializeComponent();
        }
        private void FormLoan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from MuonTra";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoan.DataSource = table;
        }
        private bool CheckLoanIDExists(string maMT)
        {
            bool exists = false;
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MuonTra WHERE MaMuonTra = @MaMuonTra", conn))
            {
                cmd.Parameters.AddWithValue("@MaMuonTra", maMT);
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            return exists;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string loanID = tbLoanID.Text.Trim();
            string memberID = tbMemberID.Text.Trim();
            string empID = tbEmployeeID.Text.Trim();

            bool loanIDexist = CheckLoanIDExists(loanID);

            if (!loanIDexist)
            {
                try
                {

                    using (SqlCommand cmd = new SqlCommand("MuonSach", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaDocGia", memberID);
                        cmd.Parameters.AddWithValue("@MaNhanVien", empID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm mượn trả mới thành công!", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }

            // Thực hiện thêm sách mới vào cơ sở dữ liệu
            if (loanIDexist)
            {
                DialogResult result = MessageBox.Show("Tiến hành thực hiện thêm phiếu mượn", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AddLoanDetail addLoanDetail = new AddLoanDetail(loanID,memberID);
                    addLoanDetail.ShowDialog();
                    LoadData();
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
                    tbMemberID.Text = dgvLoan.Rows[i].Cells[1].Value.ToString();
                    tbEmployeeID.Text = dgvLoan.Rows[i].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string loanID = tbLoanID.Text.Trim();
            int memberID = 0;
            if (!int.TryParse(tbMemberID.Text.Trim(), out memberID))
            {
                memberID = 0;
            }
            string empID = tbEmployeeID.Text.Trim();

            string query = "SELECT * FROM dbo.TimKiemMuonTra(@MaMT, @MaDG, @MaNV)";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;

                adapter.SelectCommand.Parameters.AddWithValue("@MaMT", string.IsNullOrEmpty(loanID) ? (object)DBNull.Value : loanID);
                adapter.SelectCommand.Parameters.AddWithValue("@MaDG", memberID == 0 ? (object)DBNull.Value : memberID);
                adapter.SelectCommand.Parameters.AddWithValue("@MaNV", string.IsNullOrEmpty(empID) ? (object)DBNull.Value : empID);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvLoan.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã mượn trả nào phù hợp với từ khóa tìm kiếm");
                }
            }
        }

        private void btnLoanDetail_Click(object sender, EventArgs e)
        {
            AddLoanDetail addLoanDetail = new AddLoanDetail("","");
            addLoanDetail.ShowDialog();
        }
    }
}
