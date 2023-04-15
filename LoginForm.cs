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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibraryManagement
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection(
        new SqlConnectionStringBuilder()
        {
            DataSource = "hoangtung",
            InitialCatalog = "LIBRARY",
            IntegratedSecurity = true,
            UserID = "TenDangNhap",
            Password = "MatKhau"
        }.ConnectionString
        );
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DangNhapC#";
            cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            cmd.Connection = conn;
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);

            if (code == 1)
            {
                MessageBox.Show("Chào mừng đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                DashBoard f1 = new DashBoard();
                f1.Visible = true;
                f1.Show();
                this.Hide();

            }
            else if (code == 2)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Text = "";
                txtUsername.Text = "";
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Text = "";
                txtUsername.Text = "";
                txtUsername.Focus();
            }
            conn.Close();
            
            //conn.Open();
            //string s = conn.State.ToString();
            //MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (picBoxShow.Image != eye_image)
            {
                txtPass.PasswordChar = '*';
            }
            else
            {
                txtPass.PasswordChar = (char)0;
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Clear();
            }
        }
        Image eye_image = Image.FromFile(@"D:\\DBMS\\LibraryManagement\\Resource\\eye.png");
        Image hide_image = Image.FromFile(@"D:\\DBMS\\LibraryManagement\\Resource\\hide.png");
        private void picBoxShow_Click(object sender, EventArgs e)
        {
            if (picBoxShow.Image != eye_image)
            {
                // Hiển thị mật khẩu
                txtPass.PasswordChar = (char)0;

                // Tải hình ảnh mới từ đường dẫn hide_image_path vào PictureBox
                picBoxShow.Image = eye_image;
            }
            else if (picBoxShow.Image != hide_image)
            {
                //MessageBox.Show("Bạn vừa nhấp vào hình ảnh!");
                // Ẩn mật khẩu
                txtPass.PasswordChar = '*';

                // Tải hình ảnh mới từ đường dẫn eye_image_path vào PictureBox
                picBoxShow.Image = hide_image;
            }        
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
