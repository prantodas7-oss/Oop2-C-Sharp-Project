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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }


        private void Admin_Load(object sender, EventArgs e)
        {

        }




        private void btnDoctor_Click(object sender, EventArgs e)
        {
            admindoctor ad = new admindoctor();
            ad.Show();
            this.Hide();

            /*
            var query = "SELECT * FROM LogInfo Where UserType = ' Doctor'";/// doctor
            var data = DataAccess.GetData(query);
            if (data == null)
                return;


            dgvadminblood.AutoGenerateColumns = true;
            dgvadminblood.DataSource = data;
            dgvadminblood.Refresh();
            dgvadminblood.ClearSelection();*/
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnPetient_Click(object sender, EventArgs e)
        {/*
            var query = "SELECT * FROM LogInfo Where UserType = 'Patient'";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;


            dgvadminblood.AutoGenerateColumns = true;
            dgvadminblood.DataSource = data;
            dgvadminblood.Refresh();
            dgvadminblood.ClearSelection();


*/



        }

        private void btnBlood_Click(object sender, EventArgs e)
        {
            adminbloodbank ab = new adminbloodbank();
            ab.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnPetient_Click_1(object sender, EventArgs e)
        {
            adminpetient ap = new adminpetient();
            ap.Show();
            this.Hide();
        }

        private void btnAppointment_Click_1(object sender, EventArgs e)
        {
            adminappointment app = new adminappointment();
            app.Show();
            this.Hide();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            admin_nurse an = new admin_nurse();
            an.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();  // Hide the current form
        }
    }

}


