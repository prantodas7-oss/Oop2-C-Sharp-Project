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

namespace Hospital
{
    public partial class BloodPay : Form
    {
        public BloodPay()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BloodBank b = new BloodBank();
            b.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Ashek1;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        private SqlConnection connection;
        private SqlCommand command;

       

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.userGridView.AutoGenerateColumns = false;
            this.LoadUserData();

        }

        private void LoadUserData()
        {
            string query = "SELECT ID, BloodGroup, Price FROM bBank";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(command);

                        connection.Open();
                        adp.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            userGridView.AutoGenerateColumns = true;
            userGridView.DataSource = dt;
            userGridView.Refresh();
        }



        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.LoadUserData();
        }
    }
}
