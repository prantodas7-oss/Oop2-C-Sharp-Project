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
    public partial class DoctorForm1 : Form //Home page 
    {
        public DoctorForm1()
        {
            InitializeComponent();
        }



        private void btnAdmittedPatient_Click(object sender, EventArgs e)
        {
            DoctorForm df = new DoctorForm();
            df.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorForm2 df2 = new DoctorForm2();
            df2.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
