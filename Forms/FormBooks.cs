using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Configuration;
using System.Data.SqlClient;
using LibraryManagement.Forms;

namespace LibraryManagement
{
    public partial class FormBooks : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Sach";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvBook.DataSource = table;
        }

        public FormBooks()
        {
            InitializeComponent();
        }
        private void FormBooks_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i;
            //i = dgvBook.CurrentRow.Index;
            //tbID.Text = dgvBook.Rows[i].Cells[0].Value.ToString();
            //tbName.Text = dgvBook.Rows[i].Cells[1].Value.ToString();
            //cbCategory.Text = dgvBook.Rows[i].Cells[2].Value.ToString();
            //tbPublisherID.Text = dgvBook.Rows[i].Cells[3].Value.ToString();
            //tbPublishYear.Text = dgvBook.Rows[i].Cells[4].Value.ToString();
            //tbAutID.Text = dgvBook.Rows[i].Cells[5].Value.ToString();
            //tbAmount.Text = dgvBook.Rows[i].Cells[6].Value.ToString();
            //tbPrice.Text = dgvBook.Rows[i].Cells[7].Value.ToString();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhập từ người dùng
            string tenSach = tbName.Text;
            string maTheLoai = cbCategory.Text;
            string maNXB = tbPublisherID.Text;
            int namXuatBan = int.Parse(tbPublishYear.Text);
            string maTG = tbAutID.Text;
            int soLuong = int.Parse(tbAmount.Text);
            decimal gia = decimal.Parse(tbPrice.Text);

            // Kiểm tra mã NXB trong cơ sở dữ liệu
            bool nxbExists = CheckMaNXBExists(maNXB);

            // Nếu mã NXB không tồn tại, hiển thị hộp thoại cho phép thêm mới NXB
            if (!nxbExists)
            {
                DialogResult result = MessageBox.Show("Mã NXB không tồn tại trong cơ sở dữ liệu. Bạn có muốn thêm mới NXB này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AddPublisherForm addNewPublisherForm = new AddPublisherForm(maNXB);
                    addNewPublisherForm.ShowDialog();
                    // Sau khi thêm mới NXB, kiểm tra lại mã NXB trong cơ sở dữ liệu
                    nxbExists = CheckMaNXBExists(maNXB);
                }
            }

            // Thực hiện thêm sách mới vào cơ sở dữ liệu
            if (nxbExists)
            {
                try
                {

                    using (SqlCommand cmd = new SqlCommand("ThemSach", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                        cmd.Parameters.AddWithValue("@MaNXB", maNXB);
                        cmd.Parameters.AddWithValue("@NamXuatBan", namXuatBan);
                        cmd.Parameters.AddWithValue("@MaTG", maTG);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@Gia", gia);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm sách mới thành công!", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        // Kiểm tra mã NXB đã tồn tại trong cơ sở dữ liệu hay chưa
        private bool CheckMaNXBExists(string maNXB)
        {
            bool exists = false;
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhaXuatBan WHERE MaNXB = @MaNXB", conn))
            {
                cmd.Parameters.AddWithValue("@MaNXB", maNXB);
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            return exists;
        }


        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    tbID.Text = dgvBook.Rows[i].Cells[0].Value.ToString();
                    tbName.Text = dgvBook.Rows[i].Cells[1].Value.ToString();
                    cbCategory.Text = dgvBook.Rows[i].Cells[2].Value.ToString();
                    tbPublisherID.Text = dgvBook.Rows[i].Cells[3].Value.ToString();
                    tbPublishYear.Text = dgvBook.Rows[i].Cells[4].Value.ToString();
                    tbAutID.Text = dgvBook.Rows[i].Cells[5].Value.ToString();
                    tbAmount.Text = dgvBook.Rows[i].Cells[6].Value.ToString();
                    tbPrice.Text = dgvBook.Rows[i].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin sách từ các điều khiển trên form
                string id = tbID.Text;
                string name = tbName.Text;
                string category = cbCategory.Text;
                string publisherId = tbPublisherID.Text;
                int publishYear = int.Parse(tbPublishYear.Text);
                string authorId = tbAutID.Text;
                int amount = int.Parse(tbAmount.Text);
                decimal price = decimal.Parse(tbPrice.Text);

                // Cập nhật thông tin sách trong bảng SQL
                string connectionString = "Data Source=.;Initial Catalog=LIBRARY;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Sach SET TenSach = @Name, MaTheLoai = @Category, MaNXB = @PublisherID, " +
                        "NamXuatBan = @PublishYear, MaTG = @AuthorID, SoLuong = @Amount, Gia = @Price WHERE MaSach = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@PublisherID", publisherId);
                        command.Parameters.AddWithValue("@PublishYear", publishYear);
                        command.Parameters.AddWithValue("@AuthorID", authorId);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Price", price);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
