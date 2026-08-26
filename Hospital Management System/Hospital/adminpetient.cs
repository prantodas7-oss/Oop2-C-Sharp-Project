using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class adminpetient : Form
    {
        public adminpetient()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM LogSign Where UserType = 'Patient'";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;


            dgvpatientInfo.AutoGenerateColumns = true;
            dgvpatientInfo.DataSource = data;
            dgvpatientInfo.Refresh();
            dgvpatientInfo.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvpatientInfo.SelectedRows.Count > 0)
            {
                // Use the correct column name as defined in the designer
                var idValue = dgvpatientInfo.SelectedRows[0].Cells["ID"].Value;
                if (idValue == null)
                {
                    MessageBox.Show("Selected row does not have a valid ID.");
                    return;
                }

                int id = Convert.ToInt32(idValue);

                // Build and execute the DELETE query
                string query = $"DELETE FROM LogSign WHERE ID = {id}";
                bool success = DataAccess.ExecuteQuery(query);

                if (success)
                {
                    MessageBox.Show("Record deleted successfully!");
                    btnLoad_Click(null, null); // Reload data
                }
                else
                {
                    MessageBox.Show("Failed to delete the record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dgvpatientInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminpetient_Load(object sender, EventArgs e)
        {

        }
    }
}
