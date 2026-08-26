
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
    public partial class Edit : Form
    {
        private string userPhone;
        public Edit(string userPhone)
        {
            InitializeComponent();
            this.userPhone = userPhone;
        }

        private void Edit_Load(object sender, EventArgs e)
        {


            try
            {
                // Filter by phone number
                string query = $"select * from pBlood where Phone = '{userPhone}'";
                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvEdit.AutoGenerateColumns = true;
                dgvEdit.DataSource = data;
                dgvEdit.Refresh();
                dgvEdit.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvEdit.ClearSelection();
            this.Close();
            dgvEdit.DataSource = null;
            /*
            if(userPhone== "")
            {
                MessageBox.Show("Fill Your Inro First ");
                return;
            }
            try
            {
                String query = $"select * from pBlood where Phone = '{userPhone}'";
                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvEdit.AutoGenerateColumns = true;
                dgvEdit.DataSource = data;
                dgvEdit.Refresh();
                dgvEdit.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}