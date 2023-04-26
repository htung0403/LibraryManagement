using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FormMembers : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormMembers()
        {
            InitializeComponent();
        }
        private void FormMembers_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from DocGia";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvMember.DataSource = table;
        }
        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Kiểm tra nếu chỉ số hàng hợp lệ
                {
                    int i = e.RowIndex;
                    tbID.Text = dgvMember.Rows[i].Cells[0].Value.ToString();
                    tbName.Text = dgvMember.Rows[i].Cells[1].Value.ToString();
                    tbAddress.Text = dgvMember.Rows[i].Cells[2].Value.ToString();
                    tbPersonalID.Text = dgvMember.Rows[i].Cells[3].Value.ToString();
                    dtpStart.Value = Convert.ToDateTime(dgvMember.Rows[i].Cells[4].Value);
                    dtpEnd.Value = Convert.ToDateTime(dgvMember.Rows[i].Cells[5].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không hợp lệ: " + ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(tbID.Text.Trim(), out id))
            {
                id = 0;
            }
            string name = tbName.Text.Trim();
            string addr = tbAddress.Text.Trim();
            string personalID = tbPersonalID.Text.Trim();

            DateTime? startDate = null;
            if (!string.IsNullOrEmpty(dtpStart.Text.Trim()))
            {
                startDate = DateTime.Parse(dtpStart.Text.Trim());
            }

            DateTime? endDate = null;
            if (!string.IsNullOrEmpty(dtpEnd.Text.Trim()))
            {
                endDate = DateTime.Parse(dtpEnd.Text.Trim());
            }

            // Tạo câu lệnh SQL để truy vấn sử dụng function
            string query = "SELECT * FROM dbo.TimKiemDocGia(@MaDG, @TenDG, @DiaChi, @CMND, @NgayBatDau, @NgayKetThuc)";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;

                adapter.SelectCommand.Parameters.AddWithValue("@MaDG", id == 0 ? (object)DBNull.Value : id);
                adapter.SelectCommand.Parameters.AddWithValue("@TenDG", string.IsNullOrEmpty(name) ? (object)DBNull.Value : name);
                adapter.SelectCommand.Parameters.AddWithValue("@DiaChi", string.IsNullOrEmpty(addr) ? (object)DBNull.Value : addr);
                adapter.SelectCommand.Parameters.AddWithValue("@CMND", string.IsNullOrEmpty(personalID) ? (object)DBNull.Value : personalID);
                adapter.SelectCommand.Parameters.AddWithValue("@NgayBatDau", startDate.HasValue ? (object)startDate.Value : DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@NgayKetThuc", endDate.HasValue ? (object)endDate.Value : DBNull.Value);
                // Thực hiện truy vấn SQL
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvMember.DataSource = dt;
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả nào phù hợp với từ khóa tìm kiếm");
                }
            }
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM DocGiaQuaHan", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvMember.DataSource = dt;
        }

        private void btnEngaged_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM DocGiaThamGia", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvMember.DataSource = dt;
        }
    }
}
