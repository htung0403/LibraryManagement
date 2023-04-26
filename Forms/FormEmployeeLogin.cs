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
    public partial class FormEmployeeLogin : Form
    {
        private Form activeForm;

        SqlConnection conn = new SqlConnection(
        new SqlConnectionStringBuilder()
        {
            DataSource = "hoangtung",
            InitialCatalog = "LIBRARY1",
            IntegratedSecurity = true,
            UserID = "TenDangNhap",
            Password = "MatKhau"
        }.ConnectionString
        );
        public FormEmployeeLogin()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DangNhapC#_2";
            cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            cmd.Connection = conn;
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);

            if (code == 1)
            {
                MessageBox.Show("Chào mừng đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormEmployees f = new FormEmployees();
                OpenChildForm(f, sender);
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
    }
}
