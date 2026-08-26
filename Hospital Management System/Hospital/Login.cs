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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string password = txtPassword.Text;

            String query = $"select * from LogSign where Email ='{Email}' and Password='{password}'";
            var data = DataAccess.GetData(query);

            if (data == null)
                return;
            if (data.Rows.Count != 1)
            {
                MessageBox.Show("Invalid UserId or Password");
                return;
            }
            String type = data.Rows[0]["UserType"].ToString();
            if (type == "Patient")
            {
                Patient p = new Patient();
                p.Show();
                this.Hide();
            }
            if (type == "Doctor")
            {
                DoctorForm1 doctorForm1 = new DoctorForm1();
                doctorForm1.Show();
                this.Hide();
            }
            if (type == "Nurse")
            {
                Nurse n = new Nurse();
                n.Show();
                this.Hide();
            }
            if (type == "Admin")
            {
                Admin a = new Admin();
                a.Show();
                this.Hide();
            }
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELP LINE NUMBER :01752-52****", "EMERGENY?");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            timer1.Stop();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

