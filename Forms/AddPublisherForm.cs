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
    public partial class AddPublisherForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public AddPublisherForm(string maNXB)
        {
            InitializeComponent();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from NhaXuatBan";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvPublisher.DataSource = table;
        }

        private void AddPublisherForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO NhaXuatBan (MaNXB, TenNXB, DiaChi, SDTNguoiDaiDien) VALUES (@MaNXB, @TenNXB, @DiaChi, @SDTNguoiDaiDien)";

            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                // Lấy mã NXB lớn nhất hiện có trong bảng NXB
                string getMaxMaNXBQuery = "SELECT MAX(MaNXB) FROM NhaXuatBan";
                SqlCommand getMaxMaNXBCmd = new SqlCommand(getMaxMaNXBQuery, conn);
                object result1 = getMaxMaNXBCmd.ExecuteScalar();
                string maxMaNXB = Convert.IsDBNull(result1) ? "" : result1.ToString();

                // Tạo mã NXB mới dựa trên mã NXB lớn nhất hiện có
                string newMaNXB;
                if (string.IsNullOrEmpty(maxMaNXB))
                {
                    newMaNXB = "NXB001";
                }
                else
                {
                    int nextId = int.Parse(maxMaNXB.Replace("NXB", "")) + 1;
                    newMaNXB = "NXB" + nextId.ToString("D3");
                }

                // Thực hiện truy vấn INSERT INTO với mã NXB mới
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNXB", newMaNXB);
                cmd.Parameters.AddWithValue("@TenNXB", tbName.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tbAddress.Text);
                cmd.Parameters.AddWithValue("@SDTNguoiDaiDien", tbPhoneNum.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm NXB thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm NXB thất bại");
                }
            }
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Kiểm tra nếu chỉ số hàng hợp lệ
                {
                    int i = e.RowIndex;
                    tbPublisherID.Text = dgvPublisher.Rows[i].Cells[0].Value.ToString();
                    tbName.Text = dgvPublisher.Rows[i].Cells[1].Value.ToString();
                    tbAddress.Text = dgvPublisher.Rows[i].Cells[2].Value.ToString();
                    tbPhoneNum.Text = dgvPublisher.Rows[i].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không hợp lệ: " + ex.Message);
            }
        }
    }
}
