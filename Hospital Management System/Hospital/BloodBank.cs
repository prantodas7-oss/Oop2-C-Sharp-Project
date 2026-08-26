using Hospital;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital
{
    public partial class BloodBank : Form
    {
        public BloodBank()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BloodBank_Load(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from bBank";
                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvBloodInfo.AutoGenerateColumns = false;
                dgvBloodInfo.DataSource = data;
                dgvBloodInfo.Refresh();
                dgvBloodInfo.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBloodInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvBloodInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtGroup.Text = dgvBloodInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = ""; // Clear quantity for new input
                txtPrice.Text = "";    // Clear price for new input
            }
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            NewData();
        }
        private void NewData()
        {
            dgvBloodInfo.ClearSelection();
            txtId.Text = "";
            txtGroup.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Invalid name");
                txtName.Focus();
                return;
            }
            string phone = txtPhone.Text;
            if (phone == "")
            {
                MessageBox.Show("Give your Phone Number");
                txtPhone.Focus();
                return;
            }
            string bGroup = txtGroup.Text;
            if (bGroup == "")
            {
                MessageBox.Show("Select Blood Group");
                txtGroup.Focus();
                return;
            }
            string quantity = txtQuantity.Text;
            if (quantity == "")
            {
                MessageBox.Show("Select a Quantity Amount");
                txtQuantity.Focus();
                return;
            }
            // if (string.IsNullOrEmpty(txtId.Text) || dgvBloodInfo.CurrentRow == null)
            string id = txtId.Text;
            if (id == string.Empty || dgvBloodInfo.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Row First.", "Invalid");
                return;
            }

            int availableQuantity = Convert.ToInt32(dgvBloodInfo.CurrentRow.Cells[2].Value);
            int requestedQuantity = 0;
            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                requestedQuantity = Convert.ToInt32(txtQuantity.Text);
            }

            if (requestedQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (requestedQuantity > availableQuantity)
            {
                MessageBox.Show("Requested quantity exceeds available quantity.");
                return;
            }

            // Deduct the quantity
            int newAvailableQuantity = availableQuantity - requestedQuantity;
            dgvBloodInfo.CurrentRow.Cells[2].Value = newAvailableQuantity;

            // Calculate total price
            int pricePerUnit = Convert.ToInt32(dgvBloodInfo.CurrentRow.Cells[3].Value);
            int totalPrice = pricePerUnit * requestedQuantity;
            txtPrice.Text = totalPrice.ToString();

            //(Optional)Update the database
            string query = $"UPDATE bBank SET Quantity = {newAvailableQuantity} WHERE ID = {txtId.Text}";
            DataAccess.ExecuteQuery(query);
            MessageBox.Show("Request submitted.");

            string insertQuery = $"insert into pBlood values ({id},'{name}','{phone}','{bGroup}',{requestedQuantity},{totalPrice})";
            if (DataAccess.ExecuteQuery(insertQuery) == true)
            {
                MessageBox.Show("Operation Completed");
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }
            



        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (dgvBloodInfo.CurrentRow == null)
            {
                txtPrice.Text = "";
                return;
            }

            int pricePerUnit = Convert.ToInt32(dgvBloodInfo.CurrentRow.Cells[3].Value);

            try
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);

                if (quantity > 0)
                {
                    int totalPrice = pricePerUnit * quantity;
                    txtPrice.Text = totalPrice.ToString();
                }
                else
                {
                    txtPrice.Text = "";
                }
            }
            catch
            {
                txtPrice.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();  // Hide the current form  
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            var query = $"SELECT * FROM pBlood WHERE Phone = '{phone}'";
            var data = DataAccess.GetData(query);
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Please submit your request first.");
                return;
            }

            Edit eF = new Edit(txtPhone.Text);
            eF.Show();

        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            BloodPay bP = new BloodPay();
            bP.Show();
            this.Hide();  // Hide the current form
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBloodInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


