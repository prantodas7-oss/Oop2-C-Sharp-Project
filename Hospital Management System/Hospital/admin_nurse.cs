
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
    public partial class admin_nurse : Form
    {
        public admin_nurse()
        {
            InitializeComponent();
        }

        private void admin_nurse_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
          
                var query = "SELECT * FROM LogSign Where UserType = 'Nurse'";
                var data = DataAccess.GetData(query);
                if (data == null)
                    return;


                dgvnurse.AutoGenerateColumns = true;
                dgvnurse.DataSource = data;
                dgvnurse.Refresh();
                dgvnurse.ClearSelection();
            
        }

        private void btndelete_Click(object sender, EventArgs e)

        {

            if (dgvnurse.SelectedRows.Count > 0)

            {

                // Use the correct column name as defined in the designer

                var idValue = dgvnurse.SelectedRows[0].Cells["ID"].Value;

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

                    btnload_Click(null, null); // Reload data

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


        private void btnback_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void dgvnurse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}