using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FormMembers : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY;Integrated Security=True";
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

        void btnEdit_Click(object sender, EventArgs e)
        {
            int maDocGia = int.Parse(tbID.Text);
            string tenDocGia = tbName.Text;
            string diaChi = tbAddress.Text;

            try
            {
                SqlCommand cmd = new SqlCommand("SuaThongTinDocGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                cmd.Parameters.AddWithValue("@TenDocGia", tenDocGia);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa thông tin đọc giả thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            int maDocGia = int.Parse(tbID.Text);
            string tenDocGia = tbName.Text;
            string diaChi = tbAddress.Text;
            string cmnd = tbPersonalID.Text;
            DateTime ngayBatDau = dtpStart.Value;
            DateTime ngayKetThuc = dtpEnd.Value;

            try
            {
                SqlCommand cmd = new SqlCommand("ThemDocGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                cmd.Parameters.AddWithValue("@TenDocGia", tenDocGia);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@CMND", cmnd);
                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                cmd.Parameters.AddWithValue("@NgayHetHan", ngayKetThuc);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm độc giả thành công!");
                LoadData();
                tbID.Clear();
                tbName.Clear();
                tbAddress.Clear();
                tbPersonalID.Clear();
                dtpStart.Value = DateTime.Now;
                dtpEnd.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
