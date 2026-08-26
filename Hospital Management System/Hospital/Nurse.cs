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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Hospital
{
    public partial class Nurse : Form
    {
        private string Email;
        public Nurse()
        {
            InitializeComponent();
            // string sql = "select * from PatientInfo;";
            //this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql = "select * from PatientInfo;")
        {
            try
            {
                var dt = DataAccess.GetData(sql);
                this.dgvLogInfo.AutoGenerateColumns = false;
                this.dgvLogInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void bntPatient_Click(object sender, EventArgs e)
        {
            string id = this.txtp_id.Text.Trim(); // read user input

            if (id == "")
            {
                MessageBox.Show("Please enter a Patient ID.");
                txtp_id.Focus();
                return;
            }

            string sql = $"SELECT * FROM Nurse WHERE pid = '{id}'";

            DataTable dt = DataAccess.GetData(sql);

            dgvLogInfo.AutoGenerateColumns = true;
            dgvLogInfo.DataSource = sql;
            dgvLogInfo.Refresh();
            dgvLogInfo.ClearSelection();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nurse_Load(object sender, EventArgs e)
        {

        }

        private void dgvLogInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var query = @"
        SELECT 
            Admit.ID AS [PatientId], 
            Admit.Name AS [PatientName], 
            Admit.RoomType, 
            Admit.Reason
        FROM Admit;";

            var data = DataAccess.GetData(query);
            if (data == null)
                return;

            dgvLogInfo.AutoGenerateColumns = false;
            dgvLogInfo.DataSource = data;
            dgvLogInfo.Refresh();
            dgvLogInfo.ClearSelection();

        }
        private void LoadData()
        {


        }

        private void Nurse_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
