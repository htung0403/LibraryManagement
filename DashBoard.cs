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
        private void pbClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            FormEmployees f = new FormEmployees();
            OpenChildForm(f, null);
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            FormDashBoard f = new FormDashBoard();
            OpenChildForm(f, null);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeLogin f = new FormEmployeeLogin();
            OpenChildForm(f, null);
        }
    }
}
