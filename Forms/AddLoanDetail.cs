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
using System.Xml.Linq;

namespace LibraryManagement.Forms
{
    public partial class AddLoanDetail : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.;Initial Catalog=LIBRARY1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public AddLoanDetail(string loanID,string memberID)
        {
            InitializeComponent();
            tbLoanID.Text = loanID;
            tbMemberID.Text = memberID;

        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from MuonTra";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoan.DataSource = table;
        }

        private void AddNewLoanID_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }

        private void btnAddLoanID_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhập từ người dùng
            string loanID = tbLoanID.Text;
            string memberID = tbMemberID.Text;
            string empID = tbEmpID.Text;
            
        }
    }
}
