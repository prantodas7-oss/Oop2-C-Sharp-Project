using Hospital;
using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class admindoctor : Form
    {
        public admindoctor()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM LogSign Where UserType = 'Doctor'";/// doctor
            var data = DataAccess.GetData(query);
            if (data == null)
                return;


            dgvDoctorInfo.AutoGenerateColumns = true;
            dgvDoctorInfo.DataSource = data;
            dgvDoctorInfo.Refresh();
            dgvDoctorInfo.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctorInfo.SelectedRows.Count > 0)
            {
                // Use the correct column name as defined in the designer
                var idValue = dgvDoctorInfo.SelectedRows[0].Cells["ID"].Value;
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
        }

        private void dgvDoctorInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admindoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
