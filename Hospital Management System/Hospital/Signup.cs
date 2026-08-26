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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnRegester_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Invalid name");
                txtName.Focus();
                return;
            }
            string email = txtEmail.Text;
            if (email == "" || email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Invalid email");
                txtEmail.Focus();
                return;
            }
            string password = txtPassword.Text;
            if (password == "")
            {
                MessageBox.Show("Password Cannot be Empty");
                txtPassword.Focus();
                return;
            }

            string confirmPassword = txtCPassword.Text;
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Check if email already exists
            string checkQuery = $"select * from LogSign where Email = '{email}'";
            var checkData = DataAccess.GetData(checkQuery);
            if (checkData != null && checkData.Rows.Count > 0)
            {
                MessageBox.Show("This email is already registered.");
                txtEmail.Focus();
                return;
            }

            string query = $"insert into LogSign (Email, Password, UserType, Name) values('{email}','{password}','Patient','{name}')";
            var Data = DataAccess.ExecuteQuery(query);
            MessageBox.Show("Sign Up Completed");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
