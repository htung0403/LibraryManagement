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
using System.Diagnostics;
using System.Security.Policy;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class FormBooks : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
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
        // Check if the publisher ID already exists in the database
        private bool CheckPublisherIDExists(string publisherID)
        {
            bool exists = false;
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhaXuatBan WHERE MaNXB = @MaNXB", conn))
            {
                cmd.Parameters.AddWithValue("@MaNXB", publisherID);
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            return exists;
        }
        private bool CheckImportIDExists(string importID)
        {
            bool exists = false;
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PhieuNhap WHERE MaPhieu = @MaPhieu", conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieu", importID);
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            return exists;
        }
        private void AddBooks(string tenSach, string maTheLoai, string maNXB, int namXuatBan, string maTG, int soLuong, decimal gia)
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
        //Add Books
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
            bool publisherID = CheckPublisherIDExists(maNXB);
            // Kiểm tra mã phiếu nhập trong cơ sở dữ liệu
            bool importID = CheckImportIDExists(maNXB);
            // Nếu mã NXB không tồn tại, hiển thị hộp thoại cho phép thêm mới NXB
            if (!publisherID)
            {
                DialogResult result = MessageBox.Show("Mã NXB không tồn tại trong cơ sở dữ liệu. Bạn có muốn thêm mới NXB này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AddPublisherForm addNewPublisherForm = new AddPublisherForm(maNXB);
                    addNewPublisherForm.ShowDialog();
                    // Sau khi thêm mới NXB, kiểm tra lại mã NXB trong cơ sở dữ liệu
                    publisherID = CheckPublisherIDExists(maNXB);
                }
            }
            if (!importID)
            {
                DialogResult result = MessageBox.Show("Mã NXB không tồn tại trong cơ sở dữ liệu. Bạn có muốn thêm mới NXB này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AddPublisherForm addNewPublisherForm = new AddPublisherForm(maNXB);
                    addNewPublisherForm.ShowDialog();
                    // Sau khi thêm mới NXB, kiểm tra lại mã NXB trong cơ sở dữ liệu
                    publisherID = CheckPublisherIDExists(maNXB);
                }
            }
            // Thực hiện thêm sách mới vào cơ sở dữ liệu
            if (publisherID == true && importID == true)
            {
                AddBooks(tenSach, maTheLoai, maNXB, namXuatBan, maTG, soLuong, gia);
            }            
        }
        //Click to show infomation in textbox
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
        //Edit info of books
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
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    string query = "SuaThongTinSach";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaSach", id);
                        command.Parameters.AddWithValue("@TenSach", name);
                        command.Parameters.AddWithValue("@MaTheLoai", category);
                        command.Parameters.AddWithValue("@MaNXB", publisherId);
                        command.Parameters.AddWithValue("@NamXuatBan", publishYear);
                        command.Parameters.AddWithValue("@MaTG", authorId);
                        command.Parameters.AddWithValue("@SoLuong", amount);
                        command.Parameters.AddWithValue("@Gia", price);
                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Đã cập nhật thông tin sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Delete books
        private void btnDel_Click(object sender, EventArgs e)
        {
            string maSach = tbID.Text;

            using (SqlCommand command = new SqlCommand("XOA_SACH", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaSach", maSach);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa sách thành công!");
            }
            LoadData();
        }
        //Search Books
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string id = tbID.Text.Trim();
            string name = tbName.Text.Trim();
            string category = cbCategory.Text.Trim();
            string publisherID = tbPublisherID.Text.Trim();
            int? year = null;
            if (!string.IsNullOrEmpty(tbPublishYear.Text.Trim()))
            {
                year = int.Parse(tbPublishYear.Text.Trim());
            }
            string authorID = tbAutID.Text.Trim();
            int? amount = null;
            if (!string.IsNullOrEmpty(tbAmount.Text.Trim()))
            {
                amount = int.Parse(tbAmount.Text.Trim());
            }
            decimal? price = null;
            if (!string.IsNullOrEmpty(tbPrice.Text.Trim()))
            {
                price = decimal.Parse(tbPrice.Text.Trim());
            }
            // Tạo câu lệnh SQL để truy vấn sử dụng function
            string query = "SELECT * FROM dbo.TimKiemSach(@MaSach, @TenSach, @MaTheLoai, @MaNXB, @NamXuatBan, @MaTG, @SoLuong, @GiaBan)";

            // Thực hiện truy vấn SQL
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Truyền tham số vào function
                command.Parameters.AddWithValue("@MaSach", string.IsNullOrEmpty(id) ? (object)DBNull.Value : id);
                command.Parameters.AddWithValue("@TenSach", string.IsNullOrEmpty(name) ? (object)DBNull.Value : name);
                command.Parameters.AddWithValue("@MaTheLoai", string.IsNullOrEmpty(category) ? (object)DBNull.Value : category);
                command.Parameters.AddWithValue("@MaNXB", string.IsNullOrEmpty(publisherID) ? (object)DBNull.Value : publisherID);
                command.Parameters.AddWithValue("@NamXuatBan", year.HasValue ? (object)year.Value : (object)DBNull.Value);
                command.Parameters.AddWithValue("@MaTG", string.IsNullOrEmpty(authorID) ? (object)DBNull.Value : authorID);
                command.Parameters.AddWithValue("@SoLuong", amount.HasValue ? (object)amount.Value : (object)DBNull.Value);
                command.Parameters.AddWithValue("@GiaBan", price.HasValue ? (object)price.Value : (object)DBNull.Value);

                DataTable dt = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }

                if (dt.Rows.Count > 0)
                {
                    // Nếu tìm thấy kết quả thì hiển thị lên DataGridView
                    dgvBook.DataSource = dt;
                }
                else
                {
                    // Nếu không tìm thấy kết quả thì hiển thị thông báo
                    MessageBox.Show("Không tìm thấy sách nào phù hợp với từ khóa tìm kiếm");
                }
            }
        }
    }
}
