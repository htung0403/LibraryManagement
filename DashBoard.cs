using LibraryManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class DashBoard : Form
    {
        private Form activeForm;
        public DashBoard()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                //if (currentButton != (Button)btnSender)
                //{
                //    DisableButton();
                //    Color color = SelectThemeColor();
                //    currentButton = (Button)btnSender;
                //    currentButton.BackColor = color;
                //    currentButton.ForeColor = Color.White;
                //    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //    panelTitleBar.BackColor = color;
                //    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                //    ThemeColor.PrimaryColor = color;
                //    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                //    btnCloseChildForm.Visible = true;
                //}
            }
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
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormBooks f = new FormBooks();
            OpenChildForm(f, null);
        }

        private void btnLibraryLoan_Click(object sender, EventArgs e)
        {
            FormLibraryLoan f = new FormLibraryLoan();
            OpenChildForm(f, null);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashBoard f = new FormDashBoard();
            OpenChildForm(f, null);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            FormMembers f = new FormMembers();
            OpenChildForm(f, null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
