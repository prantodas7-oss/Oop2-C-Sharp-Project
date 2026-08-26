using Hospital;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hospital
{
    public partial class AppointPatient : Form
    {
        public AppointPatient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxpatientid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxpatientname_TextChanged(object sender, EventArgs e)
        {
            string patientName = textBoxpatientname.Text;
            if (patientName == " ")
            {
                MessageBox.Show("Invalid patientName ");
                textBoxpatientname.Focus();
                return;
            }
        }
        private bool numberWarningShown = false;
        private void textBoxpatientnumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxpatientnumber.Text))
            {
                numberWarningShown = false; // Reset warning clear korbay
                return;
            }

            int age;
            if (!int.TryParse(textBoxpatientnumber.Text, out age))
            {
                if (!numberWarningShown)
                {
                    MessageBox.Show("Please enter a valid integer for Number.");
                    numberWarningShown = true;
                }
            }
            else
            {
                numberWarningShown = false; // input value reset korbay .
            }





        }
        private bool ageWarningShown = false;

        private void textBoxpatientage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxpatientage.Text))
            {
                ageWarningShown = false; // Reset warning clear korbay
                return;
            }

            int age;
            if (!int.TryParse(textBoxpatientage.Text, out age))
            {
                if (!ageWarningShown)
                {
                    MessageBox.Show("Please enter a valid integer for age.");
                    ageWarningShown = true;
                }
            }
            else
            {
                ageWarningShown = false; // input value reset korbay .
            }

        }

        private void radioButtonpatientmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxdoctordepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxdoctordepartment == null)
                return;


            var doctordepartment = comboBoxdoctordepartment.SelectedItem?.ToString();


            string[] doctorname;
            if (doctordepartment == "01.  Emergency Medicine ")
                doctorname = new string[] { "Dr. John Doe", "Dr. Jane Smith", "Dr. Emily Johnson" };
            else if (doctordepartment == "02.  Cardiology")
                doctorname = new string[] { "Dr. Michael Brown", "Dr. Sarah Davis" };
            else if (doctordepartment == "03.  Neurology")
                doctorname = new string[] { "Dr. William Wilson", "Dr. Olivia Martinez" };
            else if (doctordepartment == "04.  Orthopedics")
                doctorname = new string[] { "Dr. James Anderson", "Dr. Emma Taylor" };
            else if (doctordepartment == "05.  Pediatrics")
                doctorname = new string[] { "Dr. Benjamin Thomas", "Dr. Ava Jackson" };
            else if (doctordepartment == "06.  Dermatology")
                doctorname = new string[] { "Dr. Lucas White", "Dr. Mia Harris" };
            else if (doctordepartment == "07.  Psychiatry")
                doctorname = new string[] { "Dr. Alexander Martin", "Dr. Sophia Thompson" };
            else if (doctordepartment == "08.  General Surgery")
                doctorname = new string[] { "Dr. Daniel Garcia", "Dr. Isabella Martinez" };
            else if (doctordepartment == "09.  Obstetrics and Gynecology")
                doctorname = new string[] { "Dr. Matthew Rodriguez", "Dr. Charlotte Lee" };
            else
                doctorname = new string[] { "Dr. Elijah Walker", "Dr. Amelia Hall" };

            comboBoxdoctorname.DataSource = doctorname;

            string[] doctordeptbill;
            if (doctordepartment == "01.  Emergency Medicine ")
                doctordeptbill = new string[] { "500" };
            else if (doctordepartment == "02.  Cardiology")
                doctordeptbill = new string[] { "600" };
            else if (doctordepartment == "03.  Neurology")
                doctordeptbill = new string[] { "700" };
            else if (doctordepartment == "04.  Orthopedics")
                doctordeptbill = new string[] { "800" };
            else if (doctordepartment == "05.  Pediatrics")
                doctordeptbill = new string[] { "900" };
            else if (doctordepartment == "06.  Dermatology")
                doctordeptbill = new string[] { "650" };
            else if (doctordepartment == "07.  Psychiatry")
                doctordeptbill = new string[] { "750" };
            else if (doctordepartment == "08.  General Surgery")
                doctordeptbill = new string[] { "800" };
            else if (doctordepartment == "09.  Obstetrics and Gynecology")
                doctordeptbill = new string[] { "900" };
            else
                doctordeptbill = new string[] { "800" };

            comboBoxdoctorbill.DataSource = doctordeptbill;


        }

        private void btnappointmentsubmitreq_Click(object sender, EventArgs e)
        {

            string gender = "";
            if (radioButtonpatientmale.Checked == true)
                gender = "Male";
            else if (radioButtonpatientfemale.Checked == true)
                gender = "Female";
            if (gender == "")
            {
                MessageBox.Show("Invalid gender");
                return;
            }
            string patientID = textBoxpatientid.Text;
            string patientName = textBoxpatientname.Text;
            string patientNumber = textBoxpatientnumber.Text;
            string ageWarningShown = textBoxpatientage.Text;
            string doctorDepartment = comboBoxdoctordepartment.SelectedItem?.ToString();
            string doctorName = comboBoxdoctorname.SelectedItem?.ToString();
            string checkupTime = comboBoxcheckuptime.SelectedItem?.ToString();
            string doctordeptbill = comboBoxdoctorbill.SelectedItem?.ToString();


            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=Ashek1; Integrated Security=True; Encrypt=False; TrustServerCertificate=True;";

                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"insert into Appointmentpatient VALUES ('{patientName}','{patientNumber}','{ageWarningShown}','{gender}','{doctorDepartment}','{doctorName}','{checkupTime}',{doctordeptbill})";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Request Submitted Successfully");
                con.Close();

                NewData();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnappointmentcancelreq_Click(object sender, EventArgs e)
        {
            textBoxpatientid.Clear();
            textBoxpatientname.Clear();
            textBoxpatientnumber.Clear();
            textBoxpatientage.Clear();


            radioButtonpatientmale.Checked = false;
            radioButtonpatientfemale.Checked = false;

            comboBoxdoctordepartment.SelectedIndex = -1;
            comboBoxdoctorname.SelectedIndex = -1;
            comboBoxcheckuptime.SelectedIndex = -1;
            comboBoxdoctorbill.SelectedIndex = -1;
        }

        private void panel2apoint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3apoint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnappointload_Click(object sender, EventArgs e)
        {

            var query = "SELECT * FROM Appointmentpatient";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;

            dgvappoint.AutoGenerateColumns = false;
            dgvappoint.DataSource = data;
            dgvappoint.Refresh();
            dgvappoint.ClearSelection();

        }

        private void dgvappoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvappoint.Rows[e.RowIndex];

                textBoxpatientid.Text = dgvappoint.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxpatientname.Text = dgvappoint.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxpatientnumber.Text = dgvappoint.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxpatientage.Text = dgvappoint.Rows[e.RowIndex].Cells[3].Value.ToString();

                string genderFromTable = dgvappoint.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (!string.IsNullOrEmpty(genderFromTable))
                {
                    if (genderFromTable.Equals("Male", StringComparison.OrdinalIgnoreCase))
                    {
                        radioButtonpatientmale.Checked = true;
                        radioButtonpatientfemale.Checked = false;
                    }
                    else if (genderFromTable.Equals("Female", StringComparison.OrdinalIgnoreCase))
                    {
                        radioButtonpatientmale.Checked = false;
                        radioButtonpatientfemale.Checked = true;
                    }
                    else
                    {
                        radioButtonpatientmale.Checked = false;
                        radioButtonpatientfemale.Checked = false;
                    }
                }
                else
                {

                    radioButtonpatientmale.Checked = false;
                    radioButtonpatientfemale.Checked = false;
                }

                comboBoxdoctordepartment.SelectedItem = dgvappoint.Rows[e.RowIndex].Cells[5].Value.ToString();
                comboBoxdoctorname.SelectedItem = dgvappoint.Rows[e.RowIndex].Cells[6].Value.ToString();
                comboBoxcheckuptime.SelectedItem = dgvappoint.Rows[e.RowIndex].Cells[7].Value.ToString();
                comboBoxdoctorbill.SelectedItem = dgvappoint.Rows[e.RowIndex].Cells[8].Value.ToString();
            }

        }

        private void btnappointsave_Click(object sender, EventArgs e)
        {
            string patientID = textBoxpatientid.Text;
            if (patientID == "")
            {
                MessageBox.Show("Invalid name");
                textBoxpatientid.Focus();
                return;
            }

            string patientName = textBoxpatientname.Text;
            if (patientName == "")
            {
                MessageBox.Show("Invalid patient name");
                textBoxpatientname.Focus();
                return;
            }
            string patientNumber = textBoxpatientnumber.Text;
            if (patientNumber == "")
            {
                MessageBox.Show("Invalid patient number");
                textBoxpatientnumber.Focus();
                return;
            }
            string patientAge = textBoxpatientage.Text;
            if (patientAge == "")
            {
                MessageBox.Show("Invalid patient age");
                textBoxpatientage.Focus();
                return;
            }
            // gender selection
            string gender = "";
            if (radioButtonpatientmale.Checked == true)
            {
                gender = "Male";
            }
            else if (radioButtonpatientfemale.Checked == true)
            {
                gender = "Female";
            }

            if (gender == "")
            {
                MessageBox.Show("Invalid gender");
                return;
            }

            string doctorDepartment = comboBoxdoctordepartment.Text;
            if (doctorDepartment == "")
            {
                MessageBox.Show("Please select a doctor department");
                return;
            }
            string doctorName = comboBoxdoctorname.Text;
            if (doctorName == "")
            {
                MessageBox.Show("Please select a doctor name");
                return;
            }
            string checkupTime = comboBoxcheckuptime.Text;
            if (checkupTime == "")
            {
                MessageBox.Show("Please select a checkup time");
                return;
            }
            string doctordeptbill = comboBoxdoctorbill.Text;
            if (doctordeptbill == "")
            {
                MessageBox.Show("Please select a doctor bill");
                return;
            }

            string updateQuery = $"UPDATE Appointmentpatient SET " +
                 $"apPatientname = '{textBoxpatientname.Text}', " +
                 $"apPatientNumber = '{textBoxpatientnumber.Text}', " +
                 $"apPatientAge = '{textBoxpatientage.Text}', " +
                 $"apPatientGender = '{(radioButtonpatientmale.Checked ? "Male" : "Female")}', " +
                 $"apDoctorDepartment = '{comboBoxdoctordepartment.SelectedItem?.ToString()}', " +
                 $"apDoctorName = '{comboBoxdoctorname.SelectedItem?.ToString()}', " +
                 $"apCheckupTime = '{comboBoxcheckuptime.SelectedItem?.ToString()}', " +
                 $"apBill = '{comboBoxdoctorbill.SelectedItem?.ToString()}' " +
                 $"WHERE ApID = '{textBoxpatientid.Text}'";
            bool success = DataAccess.ExecuteQuery(updateQuery);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");

                LoadData();
                NewData();
                return;
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            dgvappoint.Refresh();



            string insertQuery = $"INSERT INTO Appointmentpatient VALUES ('{patientName}','{patientNumber}','{patientAge}','{gender}','{doctorDepartment}','{doctorName}','{checkupTime}',{doctordeptbill})";

            if (DataAccess.ExecuteQuery(insertQuery) == true)
            {
                MessageBox.Show("Operation Completed");
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }


        }

        private void btnappointmentdelete_Click(object sender, EventArgs e)
        {
            string id = textBoxpatientid.Text;
            if (id == string.Empty)
            {
                MessageBox.Show("Please Select a row first");
                return;
            }
            var result = MessageBox.Show("Are you sure that you what to delete ? ", "Confimation?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            var query = $"delete from Appointmentpatient where ApID={id}";
            if (DataAccess.ExecuteQuery(query) == false)
                return;

            MessageBox.Show("Deleted");
            this.LoadData();
            this.NewData();
        }

        private void LoadData()
        {
            var query = "select * from Appointmentpatient";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;

            dgvappoint.AutoGenerateColumns = false;
            dgvappoint.DataSource = data;
            dgvappoint.Refresh();
            dgvappoint.ClearSelection();
        }
        private void NewData()
        {
            dgvappoint.ClearSelection();
            textBoxpatientid.Clear();
            textBoxpatientname.Clear();
            textBoxpatientnumber.Clear();
            textBoxpatientage.Clear();
            comboBoxdoctordepartment.SelectedIndex = -1;
            comboBoxdoctorname.SelectedIndex = -1;
            comboBoxcheckuptime.SelectedIndex = -1;
            comboBoxdoctorbill.SelectedIndex = -1;
            radioButtonpatientmale.Checked = false;
            radioButtonpatientfemale.Checked = false;
        }

        private void btnappointmentback_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void panel1apoint_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


