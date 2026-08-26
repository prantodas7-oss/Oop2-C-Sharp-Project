namespace Hospital
{
    partial class DoctorForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvdctr = new System.Windows.Forms.DataGridView();
            this.dgvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDisease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLastDiagonsedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDiagonsedID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPrescription = new System.Windows.Forms.TextBox();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdctr)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvdctr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(453, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 544);
            this.panel2.TabIndex = 1;
            // 
            // dgvdctr
            // 
            this.dgvdctr.AllowUserToAddRows = false;
            this.dgvdctr.AllowUserToDeleteRows = false;
            this.dgvdctr.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdctr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdctr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPatientName,
            this.dgvDisease,
            this.dgvPrescription,
            this.PatientID,
            this.dgvLastDiagonsedDate});
            this.dgvdctr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdctr.Location = new System.Drawing.Point(0, 0);
            this.dgvdctr.Name = "dgvdctr";
            this.dgvdctr.ReadOnly = true;
            this.dgvdctr.RowHeadersWidth = 51;
            this.dgvdctr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdctr.Size = new System.Drawing.Size(712, 542);
            this.dgvdctr.TabIndex = 0;
            this.dgvdctr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdctr_CellClick);
            this.dgvdctr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdctr_CellContentClick);
            // 
            // dgvPatientName
            // 
            this.dgvPatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPatientName.DataPropertyName = "Patient Name";
            this.dgvPatientName.HeaderText = "Patient Name";
            this.dgvPatientName.MinimumWidth = 6;
            this.dgvPatientName.Name = "dgvPatientName";
            this.dgvPatientName.ReadOnly = true;
            // 
            // dgvDisease
            // 
            this.dgvDisease.DataPropertyName = "Disease";
            this.dgvDisease.HeaderText = "Disease";
            this.dgvDisease.MinimumWidth = 6;
            this.dgvDisease.Name = "dgvDisease";
            this.dgvDisease.ReadOnly = true;
            this.dgvDisease.Width = 200;
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.DataPropertyName = "Prescription";
            this.dgvPrescription.HeaderText = "Prescription";
            this.dgvPrescription.MinimumWidth = 6;
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.ReadOnly = true;
            this.dgvPrescription.Width = 200;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Visible = false;
            this.PatientID.Width = 125;
            // 
            // dgvLastDiagonsedDate
            // 
            this.dgvLastDiagonsedDate.DataPropertyName = "LastDiagonsedDate";
            this.dgvLastDiagonsedDate.HeaderText = "LastDiagonsedDate";
            this.dgvLastDiagonsedDate.MinimumWidth = 6;
            this.dgvLastDiagonsedDate.Name = "dgvLastDiagonsedDate";
            this.dgvLastDiagonsedDate.ReadOnly = true;
            this.dgvLastDiagonsedDate.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDiagonsedID);
            this.panel1.Controls.Add(this.lblPatientID);
            this.panel1.Controls.Add(this.txtPrescription);
            this.panel1.Controls.Add(this.txtDisease);
            this.panel1.Controls.Add(this.lblPrescription);
            this.panel1.Controls.Add(this.lblDisease);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.lblPatientName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 544);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDiagonsedID
            // 
            this.lblDiagonsedID.AutoSize = true;
            this.lblDiagonsedID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonsedID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiagonsedID.Location = new System.Drawing.Point(40, 439);
            this.lblDiagonsedID.Name = "lblDiagonsedID";
            this.lblDiagonsedID.Size = new System.Drawing.Size(103, 20);
            this.lblDiagonsedID.TabIndex = 9;
            this.lblDiagonsedID.Text = "DiagonsedID";
            this.lblDiagonsedID.Visible = false;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPatientID.Location = new System.Drawing.Point(40, 395);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(78, 20);
            this.lblPatientID.TabIndex = 8;
            this.lblPatientID.Text = "PatientID";
            this.lblPatientID.Visible = false;
            // 
            // txtPrescription
            // 
            this.txtPrescription.Location = new System.Drawing.Point(145, 277);
            this.txtPrescription.Name = "txtPrescription";
            this.txtPrescription.Size = new System.Drawing.Size(280, 22);
            this.txtPrescription.TabIndex = 7;
            // 
            // txtDisease
            // 
            this.txtDisease.Location = new System.Drawing.Point(145, 196);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(280, 22);
            this.txtDisease.TabIndex = 6;
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrescription.Location = new System.Drawing.Point(31, 277);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(108, 20);
            this.lblPrescription.TabIndex = 5;
            this.lblPrescription.Text = "Prescription:";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisease.Location = new System.Drawing.Point(68, 196);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(71, 20);
            this.lblDisease.TabIndex = 4;
            this.lblDisease.Text = "Disease:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(145, 119);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(280, 22);
            this.txtPatientName.TabIndex = 3;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPatientName.Location = new System.Drawing.Point(20, 121);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(119, 20);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 553);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 85);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(453, 553);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(714, 85);
            this.panel4.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(569, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(45, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 42);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(244, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DoctorForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1170, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoctorForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorForm2_FormClosing);
            this.Load += new System.EventHandler(this.DoctorForm2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdctr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvdctr;
        private System.Windows.Forms.TextBox txtPrescription;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDisease;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastDiagonsedDate;
        private System.Windows.Forms.Label lblDiagonsedID;
        private System.Windows.Forms.Button btnBack;
    }
}