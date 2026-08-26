namespace Hospital
{
    partial class Nurse
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
            this.lblp_id = new System.Windows.Forms.Label();
            this.bntPatient = new System.Windows.Forms.Button();
            this.txtp_id = new System.Windows.Forms.TextBox();
            this.dgvLogInfo = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblp_id
            // 
            this.lblp_id.AutoSize = true;
            this.lblp_id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp_id.Location = new System.Drawing.Point(27, 23);
            this.lblp_id.Name = "lblp_id";
            this.lblp_id.Size = new System.Drawing.Size(162, 25);
            this.lblp_id.TabIndex = 0;
            this.lblp_id.Text = "PATIENT_ID :";
            // 
            // bntPatient
            // 
            this.bntPatient.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bntPatient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPatient.Location = new System.Drawing.Point(32, 155);
            this.bntPatient.Name = "bntPatient";
            this.bntPatient.Size = new System.Drawing.Size(140, 52);
            this.bntPatient.TabIndex = 1;
            this.bntPatient.Text = "SEARCH";
            this.bntPatient.UseVisualStyleBackColor = false;
            this.bntPatient.Click += new System.EventHandler(this.bntPatient_Click);
            // 
            // txtp_id
            // 
            this.txtp_id.Location = new System.Drawing.Point(12, 67);
            this.txtp_id.Name = "txtp_id";
            this.txtp_id.Size = new System.Drawing.Size(190, 22);
            this.txtp_id.TabIndex = 2;
            this.txtp_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvLogInfo
            // 
            this.dgvLogInfo.AllowUserToAddRows = false;
            this.dgvLogInfo.AllowUserToDeleteRows = false;
            this.dgvLogInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvRoom,
            this.dgvReason});
            this.dgvLogInfo.Location = new System.Drawing.Point(245, 100);
            this.dgvLogInfo.Name = "dgvLogInfo";
            this.dgvLogInfo.ReadOnly = true;
            this.dgvLogInfo.RowHeadersWidth = 51;
            this.dgvLogInfo.RowTemplate.Height = 24;
            this.dgvLogInfo.Size = new System.Drawing.Size(561, 339);
            this.dgvLogInfo.TabIndex = 3;
            this.dgvLogInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogInfo_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "Patient Id";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 125;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Patient Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 125;
            // 
            // dgvRoom
            // 
            this.dgvRoom.DataPropertyName = "RoomType";
            this.dgvRoom.HeaderText = "Room Type";
            this.dgvRoom.MinimumWidth = 6;
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.Width = 125;
            // 
            // dgvReason
            // 
            this.dgvReason.DataPropertyName = "Reason";
            this.dgvReason.HeaderText = "Reason";
            this.dgvReason.MinimumWidth = 6;
            this.dgvReason.Name = "dgvReason";
            this.dgvReason.ReadOnly = true;
            this.dgvReason.Width = 125;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Orange;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(718, 43);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 39);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Patient Details :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.txtp_id);
            this.panel1.Controls.Add(this.lblp_id);
            this.panel1.Controls.Add(this.bntPatient);
            this.panel1.Location = new System.Drawing.Point(11, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 316);
            this.panel1.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.Location = new System.Drawing.Point(692, 469);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 50);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(818, 531);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvLogInfo);
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.Load += new System.EventHandler(this.Nurse_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblp_id;
        private System.Windows.Forms.Button bntPatient;
        private System.Windows.Forms.TextBox txtp_id;
        private System.Windows.Forms.DataGridView dgvLogInfo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReason;
        private System.Windows.Forms.Button btnLogOut;
    }
}