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
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryManagement.Forms
{
    public partial class FormDashBoard : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormDashBoard()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            string query = "select Sum(SoLuong) from Sach";
            SqlCommand cmd = new SqlCommand(query, conn);
            int amount = (int)cmd.ExecuteScalar();
            labelAmount.Text = amount.ToString();

            query = "Select Count(*) From NhaXuatBan";
            cmd = new SqlCommand(query, conn);
            amount= (int)cmd.ExecuteScalar();
            labelPublisher.Text = amount.ToString();

            query = "Select Sum(SLSachMuon) from CTMuonTra";
            cmd = new SqlCommand(query, conn);
            amount = (int)cmd.ExecuteScalar();
            labelBookBorrowed.Text = amount.ToString();

            query = "SELECT COUNT(DISTINCT MaDocGia) AS SoLuongDocGiaChuaTraSach FROM MuonTra WHERE MaMuonTra NOT IN (SELECT MaMuonTra FROM CTMuonTra WHERE NgayTra IS NOT NULL);";
            cmd = new SqlCommand(query, conn);
            amount = (int)cmd.ExecuteScalar();
            labelReaderNotReturned.Text = amount.ToString();

            query = "SELECT COUNT(*) AS SoLuongSachQuaHan\r\nFROM CTMuonTra\r\nWHERE NgayTra IS NULL AND NgayHenTra < GETDATE();\r\n";
            cmd = new SqlCommand(query, conn);
            amount = (int)cmd.ExecuteScalar();
            labelOverdueBooks.Text = amount.ToString();
        }
        // Cập nhật số lượng sách vào label trong form
        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            ShowData();
        }

        private void panelAmount_MouseClick(object sender, MouseEventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM Sach", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panelPublisher_MouseClick(object sender, MouseEventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM NhaXuatBan", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panelBookBorrowed_MouseClick(object sender, MouseEventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM ThongTinSachDaMuon", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panelNotReturned_MouseClick(object sender, MouseEventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM ThongTinDocGiaChuaTraSach", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panelOverdueBooks_MouseClick(object sender, MouseEventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM DanhSachSachQuaHanChuaTra", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
