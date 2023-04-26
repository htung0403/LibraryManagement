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
    public partial class FormEmployees : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from NhanVien";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvEmp.DataSource = table;
        }
        public FormEmployees()
        {
            InitializeComponent();
        }
        private void FormEmployees_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hoTen = tbName.Text;
            DateTime ngaySinh = dtpDOB.Value.Date;
            string cmnd = tbPersonalID.Text;
            string sdt = tbPhone.Text;
            bool ttlv = cbStatus.Checked;
            decimal luong = Decimal.Parse(tbSalary.Text);
            string tenNhom = cbPosition.Text;

            try
            {
                SqlCommand cmd = new SqlCommand("ThemNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@CMND", cmnd);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@TTLV", ttlv);
                cmd.Parameters.AddWithValue("@LUONG", luong);
                cmd.Parameters.AddWithValue("@TenNhom", tenNhom);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maNV = string.IsNullOrEmpty(tbID.Text) ? null : tbID.Text;
            string hoTen = string.IsNullOrEmpty(tbName.Text) ? null : tbName.Text;
            string sdt = string.IsNullOrEmpty(tbPhone.Text) ? null : tbPhone.Text;
            string cmnd = string.IsNullOrEmpty(tbPersonalID.Text) ? null : tbPersonalID.Text;
            bool? ttlv = cbStatus.CheckState == CheckState.Indeterminate ? null : (bool?)cbStatus.Checked;

            string query = "SELECT * FROM TimKiemNhanVien(@MaNhanVien, @HoTen, @SDT, @CMND, @TTLV)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", maNV);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@SDT", sdt);
                    command.Parameters.AddWithValue("@CMND", cmnd);
                    command.Parameters.AddWithValue("@TTLV", ttlv);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvEmp.DataSource = table;
                    }
                }
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // kiểm tra có click vào row
            {
                DataGridViewRow row = dgvEmp.Rows[e.RowIndex];
                tbID.Text = row.Cells["MaNhanVien"].Value.ToString();
                tbName.Text = row.Cells["HoTen"].Value.ToString();
                dtpDOB.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                tbPhone.Text = row.Cells["SoDienThoai"].Value.ToString();
                tbPersonalID.Text = row.Cells["MaDinhDanh"].Value.ToString();
                cbStatus.Checked = (bool)row.Cells["TinhTrangLamViec"].Value;
                cbPosition.SelectedValue = row.Cells["TenNhom"].Value.ToString();
                tbSalary.Text = row.Cells["Luong"].Value.ToString();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            FormEmployees_Load(sender, e);
            tbID.Text = null;
            tbName.Text = null;
            dtpDOB.Text = null;
            tbPhone.Text = null;
            tbSalary.Text = null;
            tbPersonalID.Text = null;
            cbStatus.Checked = false;
            cbPosition.Text = null;
        }
    }
}
