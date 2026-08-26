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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AppointPatient ap = new AppointPatient();
            ap.Show();
            this.Hide();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            Admit ad = new Admit();
            ad.Show();
            this.Hide();
        }

        private void btnBlood_Click(object sender, EventArgs e)
        {
            BloodBank b = new BloodBank();
            b.Show();
            this.Hide();
        }

        private void btnAmb_Click(object sender, EventArgs e)
        {
            Ambulance am = new Ambulance();
            am.Show();
            this.Hide();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Login login = new Login();
        //    login.Show();
        //    this.Hide();
        //}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
