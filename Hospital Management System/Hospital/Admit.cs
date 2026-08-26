using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital
{
    public partial class Admit : Form
    {
        public Admit()
        {
            InitializeComponent();
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {///NAME
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Invalid name");
                txtName.Focus();
                return;
            }
            ///Age
            string Age = txtAge.Text;
            if (Age == string.Empty)
            {
                MessageBox.Show("Please enter your age.");
                return;
            }
            try
            {
                int age = Convert.ToInt32(Age);

                if (age < 0 || age > 120)
                {
                    MessageBox.Show("Please enter a realistic age.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Age must be a number.");
            }
            //
            string gender = "";
            if (rbtnMale.Checked == true)
                gender = "Male";
            else if (rbtnFemale.Checked == true)
                gender = "Female";
            if (gender == "")
            {
                MessageBox.Show("Invalid gender");
                return;
            }
            ///Email
            string email = txtEmail.Text;
            if (name == " " || email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Invalid email");
                txtEmail.Focus();
                return;
            }
            ///phone 
            string phone = txtPhone.Text;
            if (phone == "")
            {
                MessageBox.Show("Give The Phone Number 1st");
                txtPhone.Focus();
                return;
            }
            /// Reason
            if (cmbReason.SelectedItem == null)
            {
                MessageBox.Show("Select Your Admit Reason 1st ");
                cmbReason.Focus();
                return;
            }
            string Reason = cmbReason.SelectedItem.ToString();
            ///Description
            String description = rtxtDesc.Text;

            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Invalid Division");
                cmbType.Focus();
                return;
            }
            string type = cmbType.SelectedItem.ToString();
            string bill = txtBill.Text;
            var query = $@"INSERT INTO Admit
                        (
                          Name, Age, Gender, Email, Phone, Reason, Description, RoomType, Bill
                        )
                        VALUES
                        ('{name}',{Age},'{gender}','{email}','{phone}','{Reason}','{description}','{type}', {bill})";

            bool success = DataAccess.ExecuteQuery(query);

            if (!success)
            {
                MessageBox.Show("Insert failed. Check numeric values.");
                return;
            }

            MessageBox.Show("Operation Completed");

            var selectQuery = $"SELECT * FROM Admit WHERE Email = '{email}'";
            DataTable data = DataAccess.GetData(selectQuery);

            if (data == null)
                return;

            dgvAdmit.AutoGenerateColumns = true;
            dgvAdmit.DataSource = data;
            dgvAdmit.Refresh();
            dgvAdmit.ClearSelection();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            var result = MessageBox.Show("Are you sure that you want to delete ? ", "Confimation?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            var query = $"delete from Admit where Email='{email}'";
            if (DataAccess.ExecuteQuery(query) == false)
                return;

            MessageBox.Show("Deleted");
            this.LoadData();
            //dgvAdmit.Refresh();
            this.NewData();
        }
        private void NewData()
        {
            dgvAdmit.ClearSelection();
            txtName.Text = "";
            txtAge.Text = "";
            txtAge.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtEmail.Text = "";
            txtPhone.Text = "";
            cmbReason.SelectedIndex = -1; // Clear the selected item
            rtxtDesc.Text = "";
            cmbType.SelectedIndex = -1;
            txtBill.Text = "";

        }

        private void LoadData()
        {
            string email = txtEmail.Text;
            var query = "select * from Admit  where Email='{email}' ";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;

            dgvAdmit.AutoGenerateColumns = false;
            dgvAdmit.DataSource = data;
            dgvAdmit.Refresh();
            dgvAdmit.ClearSelection();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.NewData();
            this.LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void dgvAdmit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbType.SelectedItem == null)
                return;

            string selectedRoomType = cmbType.SelectedItem.ToString();

            if (selectedRoomType == "AC")
            {
                txtBill.Text = "3000";  // AC room bill
            }
            else if (selectedRoomType == "Non-AC")
            {
                txtBill.Text = "2000";  // Non-AC room bill
            }
            else
            {
                txtBill.Text = "";
            }
        }

        private void Admit_Load(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("AC");
            cmbType.Items.Add("Non-AC");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    this.LoadData();
        //    this.NewData();
        //}
    }

}

