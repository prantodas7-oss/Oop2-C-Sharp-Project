using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class DoctorForm : Form //Admitted Patient
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }
        private void LoadData()//data load korbe
        {
            //**var query = "SELECT dAppointment.*, Appointmentpatient.ApPatientName AS [Patient Name], Appointmentpatient.ApID AS PatientID FROM dAppointment INNER JOIN Appointmentpatient ON dAppointment.AppointmentpatientApID = Appointmentpatient.ApID";//load er por data ashbe
            var query = "SELECT dAdmitted.*, Admit.Name AS [Patient Name], Admit.ID AS PatientID FROM Admit LEFT JOIN dAdmitted ON Admit.ID = dAdmitted.AdmitID";
            //***var query = "SELECT dAdmitted.*, Admit.Name AS [Patient Name], Admit.ID AS PatientID FROM Admit  JOIN dAdmitted ON Admit.ID = dAdmitted.AdmitID";
            var data = DataAccess.GetData(query);
            if (data == null)
            {
                return;
            }

            dgvDoctor.AutoGenerateColumns = false;
            dgvDoctor.DataSource = data;
            if (dgvDoctor.Columns.Contains("PatientID"))
            {
                dgvDoctor.Columns["PatientID"].Visible = false;
            }
            dgvDoctor.Refresh();
            dgvDoctor.ClearSelection();//selection remove
        }

        private void dgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPN.Text = dgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblt.Text = dgvDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
                //MessageBox.Show(lblTime.Text);
                txtR.Text = dgvDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblvt.Text = dgvDoctor.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblDiagonsedID.Text = dgvDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblPatientID.Text = dgvDoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            dgvDoctor.ClearSelection();
            txtPN.Text = "";
            txtR.Text = "";

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

            var query = $"DELETE FROM dAdmitted WHERE AdmitID = {patientID} ";//child table
            if (DataAccess.ExecuteQuery(query) == false)
            {
                return;
            }
            var deletePatientQuery = $"DELETE FROM Admit WHERE ID = {patientID}";//parent table
            if (DataAccess.ExecuteQuery(deletePatientQuery) == false)
            {
                MessageBox.Show("Failed to delete from Admit.");
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
            string room = txtR.Text;
            string admittime = DateTime.Now.ToString();
            string visittime = DateTime.Now.ToString();

            if (string.IsNullOrWhiteSpace(room))
            {
                MessageBox.Show("Please fill in all fields before saving.");
                return;
            }
            string query = string.Empty;
            if (diagonsedID == string.Empty)
            {
                //query = $"INSERT INTO dAppointment VALUES ({patientID}, '{disease}', '{prescription}', '{lastDiagonsedDate}')";
                query = $"INSERT INTO dAdmitted (AdmitID,[Admit Time],Room,VisitTime) VALUES ({patientID}, '{admittime}', '{room}', '{visittime}')";
            }
            else
            {
                query = $"UPDATE dAdmitted SET [Admit Time] = '{admittime}', Room = '{room}', VisitTime = '{visittime}' WHERE AdmitID = {patientID}";
            }
            if (DataAccess.ExecuteQuery(query) == false)
            {
                MessageBox.Show("Update failed.");
                return;
            }

            MessageBox.Show("Updated successfully!");
            this.LoadData();
            this.NewData();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoctorForm1 doctorForm1 = new DoctorForm1();
            doctorForm1.Show();

        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorForm1 d = new DoctorForm1();
            d.Show();
            this.Hide();  // Hide the current form
        }
    }
}
