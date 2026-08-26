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
    public partial class DoctorForm2 : Form //Non-Admitted Patient
    {
        public DoctorForm2()
        {
            InitializeComponent();
        }

        private void DoctorForm2_Load(object sender, EventArgs e)
        {
            this.LoadData();

        }
        private void btnRefresh_Click(object sender, EventArgs e)//refresh button
        {
            this.LoadData();
            this.NewData();
        }

        private void LoadData()//data load korbe
        {
            ////**var query = "SELECT dAppointment.*, Appointmentpatient.ApPatientName AS [Patient Name], Appointmentpatient.ApID AS PatientID FROM dAppointment INNER JOIN Appointmentpatient ON dAppointment.AppointmentpatientApID = Appointmentpatient.ApID";//load er por data ashbe
            var query = "SELECT dAppointment.*, Appointmentpatient.ApPatientName AS [Patient Name], Appointmentpatient.ApID AS PatientID FROM Appointmentpatient LEFT JOIN dAppointment ON Appointmentpatient.ApID = dAppointment.AppointmentpatientApID";

            var data = DataAccess.GetData(query);
            if (data == null)
            {
                return;
            }

            dgvdctr.AutoGenerateColumns = false;
            dgvdctr.DataSource = data;
            if (dgvdctr.Columns.Contains("PatientID"))
            {
                dgvdctr.Columns["PatientID"].Visible = false;
            }
            dgvdctr.Refresh();
            dgvdctr.ClearSelection();//selection remove
        }

        private void dgvdctr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPatientName.Text = dgvdctr.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDisease.Text = dgvdctr.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrescription.Text = dgvdctr.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblPatientID.Text = dgvdctr.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblDiagonsedID.Text = dgvdctr.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void NewData()
        {
            dgvdctr.ClearSelection();
            txtPatientName.Text = "";
            txtDisease.Text = "";
            txtPrescription.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string patientID = lblPatientID.Text;
            if (patientID == string.Empty)
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            var result = MessageBox.Show("Are you sure about that?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            var query = $"DELETE FROM dAppointment WHERE AppointmentpatientApID = {patientID} ";
            if (DataAccess.ExecuteQuery(query) == false)
            {
                return;
            }
            var deletePatientQuery = $"DELETE FROM Appointmentpatient WHERE ApID = {patientID}";
            if (DataAccess.ExecuteQuery(deletePatientQuery) == false)
            {
                MessageBox.Show("Failed to delete patient data.");
                return;
            }

            MessageBox.Show("Deleted");

            this.LoadData();
            this.NewData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string patientID = lblPatientID.Text;
            string diagonsedID = lblDiagonsedID.Text;
            string disease = txtDisease.Text;
            string prescription = txtPrescription.Text;
            string lastDiagonsedDate = DateTime.Now.ToString();

            if (string.IsNullOrWhiteSpace(disease) || string.IsNullOrWhiteSpace(prescription))
            {
                MessageBox.Show("Please fill in all fields before saving.");
                return;
            }
            string query = string.Empty;
            if (diagonsedID == string.Empty)
            {
                //query = $"INSERT INTO dAppointment VALUES ({patientID}, '{disease}', '{prescription}', '{lastDiagonsedDate}')";
                query = $"INSERT INTO dAppointment (AppointmentpatientApID, Disease, Prescription, LastDiagonsedDate) VALUES ({patientID}, '{disease}', '{prescription}', '{lastDiagonsedDate}')";
                MessageBox.Show("Insert successfully!");
            }
            else
            {
                query = $"UPDATE dAppointment SET Disease = '{disease}', Prescription = '{prescription}', LastDiagonsedDate = '{lastDiagonsedDate}' WHERE AppointmentpatientApID = {patientID}";
                MessageBox.Show("Updated successfully!");
            }
            if (DataAccess.ExecuteQuery(query) == false)
            {
                MessageBox.Show("Update failed.");
                return;
            }


            this.LoadData();
            this.NewData();
        }

        private void DoctorForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoctorForm1 doctorForm1 = new DoctorForm1();
            doctorForm1.Show();
        }

        private void dgvdctr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorForm1 d = new DoctorForm1();
            d.Show();
            this.Hide();  // Hide the current form
        }
    }
}

