﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FormLibraryLoan : Form
    {
        private Form activeForm;
        public FormLibraryLoan()
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
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void muonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoan f = new FormLoan();
            OpenChildForm(f, null);
        }

        private void traToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReturn f = new FormReturn();
            OpenChildForm(f, null);
        }
    }
}
