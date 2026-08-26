namespace Hospital
{
    partial class DoctorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblDiagonsedID = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.lblvt = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVisitTime = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.dgvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVisitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagonsedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblVisitTime);
            this.panel1.Controls.Add(this.txtRoom);
            this.panel1.Controls.Add(this.lblRoom);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.lblPatientName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 576);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.lblPatientID);
            this.panel5.Controls.Add(this.lblDiagonsedID);
            this.panel5.Controls.Add(this.lblt);
            this.panel5.Controls.Add(this.lblvt);
            this.panel5.Controls.Add(this.txtR);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtPN);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 576);
            this.panel5.TabIndex = 9;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPatientID.Location = new System.Drawing.Point(188, 400);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(84, 20);
            this.lblPatientID.TabIndex = 10;
            this.lblPatientID.Text = "PatientID";
            this.lblPatientID.Visible = false;
            // 
            // lblDiagonsedID
            // 
            this.lblDiagonsedID.AutoSize = true;
            this.lblDiagonsedID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonsedID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiagonsedID.Location = new System.Drawing.Point(20, 440);
            this.lblDiagonsedID.Name = "lblDiagonsedID";
            this.lblDiagonsedID.Size = new System.Drawing.Size(110, 20);
            this.lblDiagonsedID.TabIndex = 9;
            this.lblDiagonsedID.Text = "DiagonsedID";
            this.lblDiagonsedID.Visible = false;
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblt.Location = new System.Drawing.Point(38, 400);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(53, 20);
            this.lblt.TabIndex = 8;
            this.lblt.Text = "Time:";
            this.lblt.Visible = false;
            // 
            // lblvt
            // 
            this.lblvt.AutoSize = true;
            this.lblvt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblvt.Location = new System.Drawing.Point(28, 494);
            this.lblvt.Name = "lblvt";
            this.lblvt.Size = new System.Drawing.Size(93, 20);
            this.lblvt.TabIndex = 4;
            this.lblvt.Text = "Visit Time:";
            this.lblvt.Visible = false;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(145, 280);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(280, 22);
            this.txtR.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(77, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room:";
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(145, 203);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(280, 22);
            this.txtPN.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Patient Name:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(38, 400);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 20);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time:";
            this.lblTime.Visible = false;
            // 
            // lblVisitTime
            // 
            this.lblVisitTime.AutoSize = true;
            this.lblVisitTime.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVisitTime.Location = new System.Drawing.Point(28, 494);
            this.lblVisitTime.Name = "lblVisitTime";
            this.lblVisitTime.Size = new System.Drawing.Size(93, 20);
            this.lblVisitTime.TabIndex = 4;
            this.lblVisitTime.Text = "Visit Time:";
            this.lblVisitTime.Visible = false;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(145, 280);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(280, 22);
            this.txtRoom.TabIndex = 3;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoom.Location = new System.Drawing.Point(77, 282);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(62, 20);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Room:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(145, 203);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(280, 22);
            this.txtPatientName.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPatientName.Location = new System.Drawing.Point(28, 203);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(119, 20);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvDoctor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(453, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 576);
            this.panel2.TabIndex = 1;
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDoctor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPatientName,
            this.dgvTime,
            this.dgvRoom,
            this.dgvVisitTime,
            this.ID,
            this.DiagonsedID});
            this.dgvDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctor.Location = new System.Drawing.Point(0, 0);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.RowHeadersWidth = 51;
            this.dgvDoctor.RowTemplate.Height = 24;
            this.dgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctor.Size = new System.Drawing.Size(700, 574);
            this.dgvDoctor.TabIndex = 0;
            this.dgvDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctor_CellClick);
            this.dgvDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctor_CellContentClick);
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
            // dgvTime
            // 
            this.dgvTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTime.DataPropertyName = "Admit Time";
            this.dgvTime.HeaderText = "Admit Time";
            this.dgvTime.MinimumWidth = 6;
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.ReadOnly = true;
            this.dgvTime.Width = 150;
            // 
            // dgvRoom
            // 
            this.dgvRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvRoom.DataPropertyName = "Room";
            this.dgvRoom.HeaderText = "Room";
            this.dgvRoom.MinimumWidth = 6;
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.Width = 150;
            // 
            // dgvVisitTime
            // 
            this.dgvVisitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvVisitTime.DataPropertyName = "VisitTime";
            this.dgvVisitTime.HeaderText = "Visit Time";
            this.dgvVisitTime.MinimumWidth = 6;
            this.dgvVisitTime.Name = "dgvVisitTime";
            this.dgvVisitTime.ReadOnly = true;
            this.dgvVisitTime.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PatientID";
            this.ID.HeaderText = "Patient ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 93;
            // 
            // DiagonsedID
            // 
            this.DiagonsedID.DataPropertyName = "DiagonsedID";
            this.DiagonsedID.HeaderText = "DiagonsedID";
            this.DiagonsedID.MinimumWidth = 6;
            this.DiagonsedID.Name = "DiagonsedID";
            this.DiagonsedID.ReadOnly = true;
            this.DiagonsedID.Visible = false;
            this.DiagonsedID.Width = 116;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(453, 585);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 73);
            this.panel4.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBack.Location = new System.Drawing.Point(587, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(50, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 42);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(228, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 73);
            this.panel3.TabIndex = 4;
            // 
            // DoctorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1158, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblVisitTime;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDiagonsedID;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label lblvt;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVisitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagonsedID;
        private System.Windows.Forms.Button btnBack;
    }
}