namespace Hospital
{
    partial class AppointPatient
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
            this.tableLayoutPanelappointment = new System.Windows.Forms.TableLayoutPanel();
            this.panel1apoint = new System.Windows.Forms.Panel();
            this.lblappointmenttitle = new System.Windows.Forms.Label();
            this.btnappointmentback = new System.Windows.Forms.Button();
            this.panel2apoint = new System.Windows.Forms.Panel();
            this.btnappointsave = new System.Windows.Forms.Button();
            this.btnappointmentdelete = new System.Windows.Forms.Button();
            this.btnappointload = new System.Windows.Forms.Button();
            this.panel3apoint = new System.Windows.Forms.Panel();
            this.textBoxpatientid = new System.Windows.Forms.TextBox();
            this.lblpatientid = new System.Windows.Forms.Label();
            this.comboBoxdoctorbill = new System.Windows.Forms.ComboBox();
            this.radioButtonpatientfemale = new System.Windows.Forms.RadioButton();
            this.radioButtonpatientmale = new System.Windows.Forms.RadioButton();
            this.lblpatientgender = new System.Windows.Forms.Label();
            this.btnappointmentcancelreq = new System.Windows.Forms.Button();
            this.comboBoxcheckuptime = new System.Windows.Forms.ComboBox();
            this.btnappointmentsubmitreq = new System.Windows.Forms.Button();
            this.comboBoxdoctorname = new System.Windows.Forms.ComboBox();
            this.comboBoxdoctordepartment = new System.Windows.Forms.ComboBox();
            this.textBoxpatientage = new System.Windows.Forms.TextBox();
            this.textBoxpatientnumber = new System.Windows.Forms.TextBox();
            this.textBoxpatientname = new System.Windows.Forms.TextBox();
            this.lblbill = new System.Windows.Forms.Label();
            this.lbldoctortime = new System.Windows.Forms.Label();
            this.lbldoctorname = new System.Windows.Forms.Label();
            this.lbldoctordepartment = new System.Windows.Forms.Label();
            this.lblpatientage = new System.Windows.Forms.Label();
            this.lblpatientnumber = new System.Windows.Forms.Label();
            this.lblpatientname = new System.Windows.Forms.Label();
            this.panel4apoint = new System.Windows.Forms.Panel();
            this.dgvappoint = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdoctordept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdoctorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcheckuptime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelappointment.SuspendLayout();
            this.panel1apoint.SuspendLayout();
            this.panel2apoint.SuspendLayout();
            this.panel3apoint.SuspendLayout();
            this.panel4apoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappoint)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelappointment
            // 
            this.tableLayoutPanelappointment.ColumnCount = 2;
            this.tableLayoutPanelappointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelappointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelappointment.Controls.Add(this.panel1apoint, 0, 0);
            this.tableLayoutPanelappointment.Controls.Add(this.panel2apoint, 1, 0);
            this.tableLayoutPanelappointment.Controls.Add(this.panel3apoint, 0, 1);
            this.tableLayoutPanelappointment.Controls.Add(this.panel4apoint, 1, 1);
            this.tableLayoutPanelappointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelappointment.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelappointment.Name = "tableLayoutPanelappointment";
            this.tableLayoutPanelappointment.RowCount = 2;
            this.tableLayoutPanelappointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelappointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelappointment.Size = new System.Drawing.Size(1380, 730);
            this.tableLayoutPanelappointment.TabIndex = 0;
            // 
            // panel1apoint
            // 
            this.panel1apoint.BackColor = System.Drawing.Color.Snow;
            this.panel1apoint.Controls.Add(this.lblappointmenttitle);
            this.panel1apoint.Controls.Add(this.btnappointmentback);
            this.panel1apoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1apoint.Location = new System.Drawing.Point(3, 3);
            this.panel1apoint.Name = "panel1apoint";
            this.panel1apoint.Size = new System.Drawing.Size(546, 140);
            this.panel1apoint.TabIndex = 0;
            this.panel1apoint.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1apoint_Paint);
            // 
            // lblappointmenttitle
            // 
            this.lblappointmenttitle.AutoSize = true;
            this.lblappointmenttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappointmenttitle.ForeColor = System.Drawing.Color.Green;
            this.lblappointmenttitle.Location = new System.Drawing.Point(311, 42);
            this.lblappointmenttitle.Name = "lblappointmenttitle";
            this.lblappointmenttitle.Size = new System.Drawing.Size(342, 36);
            this.lblappointmenttitle.TabIndex = 2;
            this.lblappointmenttitle.Text = "APPOINTMENT FORM";
            // 
            // btnappointmentback
            // 
            this.btnappointmentback.BackColor = System.Drawing.Color.SeaShell;
            this.btnappointmentback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappointmentback.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnappointmentback.Location = new System.Drawing.Point(20, 28);
            this.btnappointmentback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnappointmentback.Name = "btnappointmentback";
            this.btnappointmentback.Size = new System.Drawing.Size(121, 61);
            this.btnappointmentback.TabIndex = 1;
            this.btnappointmentback.Text = "BACK";
            this.btnappointmentback.UseVisualStyleBackColor = false;
            this.btnappointmentback.Click += new System.EventHandler(this.btnappointmentback_Click);
            // 
            // panel2apoint
            // 
            this.panel2apoint.BackColor = System.Drawing.Color.Snow;
            this.panel2apoint.Controls.Add(this.btnappointsave);
            this.panel2apoint.Controls.Add(this.btnappointmentdelete);
            this.panel2apoint.Controls.Add(this.btnappointload);
            this.panel2apoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2apoint.Location = new System.Drawing.Point(555, 3);
            this.panel2apoint.Name = "panel2apoint";
            this.panel2apoint.Size = new System.Drawing.Size(822, 140);
            this.panel2apoint.TabIndex = 1;
            this.panel2apoint.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2apoint_Paint);
            // 
            // btnappointsave
            // 
            this.btnappointsave.BackColor = System.Drawing.Color.SeaShell;
            this.btnappointsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappointsave.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnappointsave.Location = new System.Drawing.Point(455, 42);
            this.btnappointsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnappointsave.Name = "btnappointsave";
            this.btnappointsave.Size = new System.Drawing.Size(87, 38);
            this.btnappointsave.TabIndex = 6;
            this.btnappointsave.Text = "SAVE";
            this.btnappointsave.UseVisualStyleBackColor = false;
            this.btnappointsave.Click += new System.EventHandler(this.btnappointsave_Click);
            // 
            // btnappointmentdelete
            // 
            this.btnappointmentdelete.BackColor = System.Drawing.Color.SeaShell;
            this.btnappointmentdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappointmentdelete.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnappointmentdelete.Location = new System.Drawing.Point(213, 45);
            this.btnappointmentdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnappointmentdelete.Name = "btnappointmentdelete";
            this.btnappointmentdelete.Size = new System.Drawing.Size(118, 38);
            this.btnappointmentdelete.TabIndex = 3;
            this.btnappointmentdelete.Text = "DELETE";
            this.btnappointmentdelete.UseVisualStyleBackColor = false;
            this.btnappointmentdelete.Click += new System.EventHandler(this.btnappointmentdelete_Click);
            // 
            // btnappointload
            // 
            this.btnappointload.BackColor = System.Drawing.Color.SeaShell;
            this.btnappointload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappointload.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnappointload.Location = new System.Drawing.Point(29, 42);
            this.btnappointload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnappointload.Name = "btnappointload";
            this.btnappointload.Size = new System.Drawing.Size(87, 38);
            this.btnappointload.TabIndex = 5;
            this.btnappointload.Text = "LOAD";
            this.btnappointload.UseVisualStyleBackColor = false;
            this.btnappointload.Click += new System.EventHandler(this.btnappointload_Click);
            // 
            // panel3apoint
            // 
            this.panel3apoint.BackColor = System.Drawing.Color.Snow;
            this.panel3apoint.Controls.Add(this.textBoxpatientid);
            this.panel3apoint.Controls.Add(this.lblpatientid);
            this.panel3apoint.Controls.Add(this.comboBoxdoctorbill);
            this.panel3apoint.Controls.Add(this.radioButtonpatientfemale);
            this.panel3apoint.Controls.Add(this.radioButtonpatientmale);
            this.panel3apoint.Controls.Add(this.lblpatientgender);
            this.panel3apoint.Controls.Add(this.btnappointmentcancelreq);
            this.panel3apoint.Controls.Add(this.comboBoxcheckuptime);
            this.panel3apoint.Controls.Add(this.btnappointmentsubmitreq);
            this.panel3apoint.Controls.Add(this.comboBoxdoctorname);
            this.panel3apoint.Controls.Add(this.comboBoxdoctordepartment);
            this.panel3apoint.Controls.Add(this.textBoxpatientage);
            this.panel3apoint.Controls.Add(this.textBoxpatientnumber);
            this.panel3apoint.Controls.Add(this.textBoxpatientname);
            this.panel3apoint.Controls.Add(this.lblbill);
            this.panel3apoint.Controls.Add(this.lbldoctortime);
            this.panel3apoint.Controls.Add(this.lbldoctorname);
            this.panel3apoint.Controls.Add(this.lbldoctordepartment);
            this.panel3apoint.Controls.Add(this.lblpatientage);
            this.panel3apoint.Controls.Add(this.lblpatientnumber);
            this.panel3apoint.Controls.Add(this.lblpatientname);
            this.panel3apoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3apoint.Location = new System.Drawing.Point(3, 149);
            this.panel3apoint.Name = "panel3apoint";
            this.panel3apoint.Size = new System.Drawing.Size(546, 578);
            this.panel3apoint.TabIndex = 2;
            this.panel3apoint.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3apoint_Paint);
            // 
            // textBoxpatientid
            // 
            this.textBoxpatientid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpatientid.Location = new System.Drawing.Point(245, 1);
            this.textBoxpatientid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpatientid.Name = "textBoxpatientid";
            this.textBoxpatientid.ReadOnly = true;
            this.textBoxpatientid.Size = new System.Drawing.Size(287, 30);
            this.textBoxpatientid.TabIndex = 44;
            this.textBoxpatientid.TextChanged += new System.EventHandler(this.textBoxpatientid_TextChanged);
            // 
            // lblpatientid
            // 
            this.lblpatientid.AutoSize = true;
            this.lblpatientid.BackColor = System.Drawing.Color.SeaShell;
            this.lblpatientid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientid.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblpatientid.Location = new System.Drawing.Point(75, 6);
            this.lblpatientid.Name = "lblpatientid";
            this.lblpatientid.Size = new System.Drawing.Size(124, 25);
            this.lblpatientid.TabIndex = 43;
            this.lblpatientid.Text = "Patient ID:";
            // 
            // comboBoxdoctorbill
            // 
            this.comboBoxdoctorbill.FormattingEnabled = true;
            this.comboBoxdoctorbill.Location = new System.Drawing.Point(251, 448);
            this.comboBoxdoctorbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxdoctorbill.Name = "comboBoxdoctorbill";
            this.comboBoxdoctorbill.Size = new System.Drawing.Size(212, 24);
            this.comboBoxdoctorbill.TabIndex = 42;
            // 
            // radioButtonpatientfemale
            // 
            this.radioButtonpatientfemale.AutoSize = true;
            this.radioButtonpatientfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonpatientfemale.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radioButtonpatientfemale.Location = new System.Drawing.Point(348, 224);
            this.radioButtonpatientfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonpatientfemale.Name = "radioButtonpatientfemale";
            this.radioButtonpatientfemale.Size = new System.Drawing.Size(104, 29);
            this.radioButtonpatientfemale.TabIndex = 41;
            this.radioButtonpatientfemale.TabStop = true;
            this.radioButtonpatientfemale.Text = "Female";
            this.radioButtonpatientfemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonpatientmale
            // 
            this.radioButtonpatientmale.AutoSize = true;
            this.radioButtonpatientmale.BackColor = System.Drawing.Color.Snow;
            this.radioButtonpatientmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonpatientmale.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radioButtonpatientmale.Location = new System.Drawing.Point(251, 224);
            this.radioButtonpatientmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonpatientmale.Name = "radioButtonpatientmale";
            this.radioButtonpatientmale.Size = new System.Drawing.Size(80, 29);
            this.radioButtonpatientmale.TabIndex = 40;
            this.radioButtonpatientmale.TabStop = true;
            this.radioButtonpatientmale.Text = "Male";
            this.radioButtonpatientmale.UseVisualStyleBackColor = false;
            this.radioButtonpatientmale.CheckedChanged += new System.EventHandler(this.radioButtonpatientmale_CheckedChanged);
            // 
            // lblpatientgender
            // 
            this.lblpatientgender.AutoSize = true;
            this.lblpatientgender.BackColor = System.Drawing.Color.SeaShell;
            this.lblpatientgender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientgender.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblpatientgender.Location = new System.Drawing.Point(59, 223);
            this.lblpatientgender.Name = "lblpatientgender";
            this.lblpatientgender.Size = new System.Drawing.Size(174, 25);
            this.lblpatientgender.TabIndex = 39;
            this.lblpatientgender.Text = "Patient Gender:";
            // 
            // btnappointmentcancelreq
            // 
            this.btnappointmentcancelreq.BackColor = System.Drawing.Color.Tomato;
            this.btnappointmentcancelreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappointmentcancelreq.ForeColor = System.Drawing.Color.Black;
            this.btnappointmentcancelreq.Location = new System.Drawing.Point(314, 507);
            this.btnappointmentcancelreq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnappointmentcancelreq.Name = "btnappointmentcancelreq";
            this.btnappointmentcancelreq.Size = new System.Drawing.Size(139, 64);
            this.btnappointmentcancelreq.TabIndex = 38;
            this.btnappointmentcancelreq.Text = "Cancel Request";
            this.btnappointmentcancelreq.UseVisualStyleBackColor = false;
            this.btnappointmentcancelreq.Click += new System.EventHandler(this.btnappointmentcancelreq_Click);
            // 
            // comboBoxcheckuptime
            // 
            this.comboBoxcheckuptime.FormattingEnabled = true;
            this.comboBoxcheckuptime.Items.AddRange(new object[] {
            "01. DAY ( 8:00am  - 12:00 am )",
            "02. NIGHT ( 7:00pm - 10:00pm )"});
            this.comboBoxcheckuptime.Location = new System.Drawing.Point(245, 386);
            this.comboBoxcheckuptime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxcheckuptime.Name = "comboBoxcheckuptime";
            this.comboBoxcheckuptime.Size = new System.Drawing.Size(233, 24);
            this.comboBoxcheckuptime.TabIndex = 37;
            // 
            // btnappointmentsubmitreq
            // 
            this.btnappointmentsubmitreq.BackColor = System.Drawing.Color.PaleGreen;
            this.btnappointmentsubmitreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappointmentsubmitreq.ForeColor = System.Drawing.Color.Black;
            this.btnappointmentsubmitreq.Location = new System.Drawing.Point(82, 506);
            this.btnappointmentsubmitreq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnappointmentsubmitreq.Name = "btnappointmentsubmitreq";
            this.btnappointmentsubmitreq.Size = new System.Drawing.Size(140, 64);
            this.btnappointmentsubmitreq.TabIndex = 25;
            this.btnappointmentsubmitreq.Text = "Submit Request";
            this.btnappointmentsubmitreq.UseVisualStyleBackColor = false;
            this.btnappointmentsubmitreq.Click += new System.EventHandler(this.btnappointmentsubmitreq_Click);
            // 
            // comboBoxdoctorname
            // 
            this.comboBoxdoctorname.FormattingEnabled = true;
            this.comboBoxdoctorname.Location = new System.Drawing.Point(245, 325);
            this.comboBoxdoctorname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxdoctorname.Name = "comboBoxdoctorname";
            this.comboBoxdoctorname.Size = new System.Drawing.Size(233, 24);
            this.comboBoxdoctorname.TabIndex = 36;
            // 
            // comboBoxdoctordepartment
            // 
            this.comboBoxdoctordepartment.FormattingEnabled = true;
            this.comboBoxdoctordepartment.Items.AddRange(new object[] {
            "01.  Emergency Medicine ",
            "02.  Internal Medicine",
            "03.  General Surgery",
            "04.  Pediatrics",
            "05.  Obstetrics and Gynecology (OB/GYN)",
            "06.  Cardiology",
            "07.  Orthopedics",
            "08.  Neurology",
            "09.  Gastroenterology",
            "10.  Nephrology"});
            this.comboBoxdoctordepartment.Location = new System.Drawing.Point(245, 269);
            this.comboBoxdoctordepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxdoctordepartment.Name = "comboBoxdoctordepartment";
            this.comboBoxdoctordepartment.Size = new System.Drawing.Size(233, 24);
            this.comboBoxdoctordepartment.TabIndex = 35;
            this.comboBoxdoctordepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxdoctordepartment_SelectedIndexChanged);
            // 
            // textBoxpatientage
            // 
            this.textBoxpatientage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpatientage.Location = new System.Drawing.Point(245, 173);
            this.textBoxpatientage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpatientage.Name = "textBoxpatientage";
            this.textBoxpatientage.Size = new System.Drawing.Size(105, 30);
            this.textBoxpatientage.TabIndex = 34;
            this.textBoxpatientage.TextChanged += new System.EventHandler(this.textBoxpatientage_TextChanged);
            // 
            // textBoxpatientnumber
            // 
            this.textBoxpatientnumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpatientnumber.Location = new System.Drawing.Point(245, 117);
            this.textBoxpatientnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpatientnumber.Name = "textBoxpatientnumber";
            this.textBoxpatientnumber.Size = new System.Drawing.Size(287, 30);
            this.textBoxpatientnumber.TabIndex = 33;
            this.textBoxpatientnumber.TextChanged += new System.EventHandler(this.textBoxpatientnumber_TextChanged);
            // 
            // textBoxpatientname
            // 
            this.textBoxpatientname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpatientname.Location = new System.Drawing.Point(245, 52);
            this.textBoxpatientname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpatientname.Name = "textBoxpatientname";
            this.textBoxpatientname.Size = new System.Drawing.Size(287, 30);
            this.textBoxpatientname.TabIndex = 32;
            this.textBoxpatientname.TextChanged += new System.EventHandler(this.textBoxpatientname_TextChanged);
            // 
            // lblbill
            // 
            this.lblbill.AutoSize = true;
            this.lblbill.BackColor = System.Drawing.Color.SeaShell;
            this.lblbill.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblbill.Location = new System.Drawing.Point(181, 448);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(51, 25);
            this.lblbill.TabIndex = 31;
            this.lblbill.Text = "Bill:";
            // 
            // lbldoctortime
            // 
            this.lbldoctortime.AutoSize = true;
            this.lbldoctortime.BackColor = System.Drawing.Color.SeaShell;
            this.lbldoctortime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctortime.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbldoctortime.Location = new System.Drawing.Point(59, 386);
            this.lbldoctortime.Name = "lbldoctortime";
            this.lbldoctortime.Size = new System.Drawing.Size(174, 25);
            this.lbldoctortime.TabIndex = 30;
            this.lbldoctortime.Text = "Check-up Time:";
            // 
            // lbldoctorname
            // 
            this.lbldoctorname.AutoSize = true;
            this.lbldoctorname.BackColor = System.Drawing.Color.SeaShell;
            this.lbldoctorname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctorname.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbldoctorname.Location = new System.Drawing.Point(77, 323);
            this.lbldoctorname.Name = "lbldoctorname";
            this.lbldoctorname.Size = new System.Drawing.Size(155, 25);
            this.lbldoctorname.TabIndex = 29;
            this.lbldoctorname.Text = "Doctor Name:";
            // 
            // lbldoctordepartment
            // 
            this.lbldoctordepartment.AutoSize = true;
            this.lbldoctordepartment.BackColor = System.Drawing.Color.SeaShell;
            this.lbldoctordepartment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctordepartment.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbldoctordepartment.Location = new System.Drawing.Point(15, 267);
            this.lbldoctordepartment.Name = "lbldoctordepartment";
            this.lbldoctordepartment.Size = new System.Drawing.Size(218, 25);
            this.lbldoctordepartment.TabIndex = 28;
            this.lbldoctordepartment.Text = "Doctor Department:";
            // 
            // lblpatientage
            // 
            this.lblpatientage.AutoSize = true;
            this.lblpatientage.BackColor = System.Drawing.Color.SeaShell;
            this.lblpatientage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientage.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblpatientage.Location = new System.Drawing.Point(97, 173);
            this.lblpatientage.Name = "lblpatientage";
            this.lblpatientage.Size = new System.Drawing.Size(136, 25);
            this.lblpatientage.TabIndex = 27;
            this.lblpatientage.Text = "Patient Age:";
            // 
            // lblpatientnumber
            // 
            this.lblpatientnumber.AutoSize = true;
            this.lblpatientnumber.BackColor = System.Drawing.Color.SeaShell;
            this.lblpatientnumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientnumber.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblpatientnumber.Location = new System.Drawing.Point(52, 117);
            this.lblpatientnumber.Name = "lblpatientnumber";
            this.lblpatientnumber.Size = new System.Drawing.Size(181, 25);
            this.lblpatientnumber.TabIndex = 26;
            this.lblpatientnumber.Text = "Patient Number:";
            // 
            // lblpatientname
            // 
            this.lblpatientname.AutoSize = true;
            this.lblpatientname.BackColor = System.Drawing.Color.SeaShell;
            this.lblpatientname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientname.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblpatientname.Location = new System.Drawing.Point(76, 52);
            this.lblpatientname.Name = "lblpatientname";
            this.lblpatientname.Size = new System.Drawing.Size(157, 25);
            this.lblpatientname.TabIndex = 24;
            this.lblpatientname.Text = "Patient Name:";
            // 
            // panel4apoint
            // 
            this.panel4apoint.BackColor = System.Drawing.Color.Snow;
            this.panel4apoint.Controls.Add(this.dgvappoint);
            this.panel4apoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4apoint.Location = new System.Drawing.Point(555, 149);
            this.panel4apoint.Name = "panel4apoint";
            this.panel4apoint.Size = new System.Drawing.Size(822, 578);
            this.panel4apoint.TabIndex = 3;
            // 
            // dgvappoint
            // 
            this.dgvappoint.AllowUserToAddRows = false;
            this.dgvappoint.AllowUserToDeleteRows = false;
            this.dgvappoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvappoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvname,
            this.dgvnumber,
            this.dgvage,
            this.dgvgender,
            this.dgvdoctordept,
            this.dgvdoctorname,
            this.dgvcheckuptime,
            this.dgvbill});
            this.dgvappoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvappoint.Location = new System.Drawing.Point(0, 0);
            this.dgvappoint.Name = "dgvappoint";
            this.dgvappoint.ReadOnly = true;
            this.dgvappoint.RowHeadersWidth = 51;
            this.dgvappoint.RowTemplate.Height = 24;
            this.dgvappoint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvappoint.Size = new System.Drawing.Size(822, 578);
            this.dgvappoint.TabIndex = 0;
            this.dgvappoint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvappoint_CellClick);
            this.dgvappoint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvid
            // 
            this.dgvid.DataPropertyName = "ApID";
            this.dgvid.HeaderText = "ID";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 25;
            // 
            // dgvname
            // 
            this.dgvname.DataPropertyName = "ApPatientname";
            this.dgvname.HeaderText = "Name";
            this.dgvname.MinimumWidth = 6;
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            this.dgvname.Width = 125;
            // 
            // dgvnumber
            // 
            this.dgvnumber.DataPropertyName = "ApPatientNumber";
            this.dgvnumber.HeaderText = "Number";
            this.dgvnumber.MinimumWidth = 6;
            this.dgvnumber.Name = "dgvnumber";
            this.dgvnumber.ReadOnly = true;
            this.dgvnumber.Width = 125;
            // 
            // dgvage
            // 
            this.dgvage.DataPropertyName = "ApPatientAge";
            this.dgvage.HeaderText = "Age";
            this.dgvage.MinimumWidth = 6;
            this.dgvage.Name = "dgvage";
            this.dgvage.ReadOnly = true;
            this.dgvage.Width = 30;
            // 
            // dgvgender
            // 
            this.dgvgender.DataPropertyName = "ApPatientGender";
            this.dgvgender.HeaderText = "Gender";
            this.dgvgender.MinimumWidth = 6;
            this.dgvgender.Name = "dgvgender";
            this.dgvgender.ReadOnly = true;
            this.dgvgender.Width = 70;
            // 
            // dgvdoctordept
            // 
            this.dgvdoctordept.DataPropertyName = "ApDoctorDepartment";
            this.dgvdoctordept.HeaderText = "D.dept";
            this.dgvdoctordept.MinimumWidth = 6;
            this.dgvdoctordept.Name = "dgvdoctordept";
            this.dgvdoctordept.ReadOnly = true;
            this.dgvdoctordept.Width = 130;
            // 
            // dgvdoctorname
            // 
            this.dgvdoctorname.DataPropertyName = "ApDoctorName";
            this.dgvdoctorname.HeaderText = "D.Name";
            this.dgvdoctorname.MinimumWidth = 6;
            this.dgvdoctorname.Name = "dgvdoctorname";
            this.dgvdoctorname.ReadOnly = true;
            this.dgvdoctorname.Width = 125;
            // 
            // dgvcheckuptime
            // 
            this.dgvcheckuptime.DataPropertyName = "ApCheckupTime";
            this.dgvcheckuptime.HeaderText = "Time";
            this.dgvcheckuptime.MinimumWidth = 6;
            this.dgvcheckuptime.Name = "dgvcheckuptime";
            this.dgvcheckuptime.ReadOnly = true;
            this.dgvcheckuptime.Width = 180;
            // 
            // dgvbill
            // 
            this.dgvbill.DataPropertyName = "ApBill";
            this.dgvbill.HeaderText = "Bill";
            this.dgvbill.MinimumWidth = 6;
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.ReadOnly = true;
            this.dgvbill.Width = 125;
            // 
            // AppointPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 730);
            this.Controls.Add(this.tableLayoutPanelappointment);
            this.Name = "AppointPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointPatient";
            this.tableLayoutPanelappointment.ResumeLayout(false);
            this.panel1apoint.ResumeLayout(false);
            this.panel1apoint.PerformLayout();
            this.panel2apoint.ResumeLayout(false);
            this.panel3apoint.ResumeLayout(false);
            this.panel3apoint.PerformLayout();
            this.panel4apoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvappoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelappointment;
        private System.Windows.Forms.Panel panel1apoint;
        private System.Windows.Forms.Panel panel2apoint;
        private System.Windows.Forms.Panel panel3apoint;
        private System.Windows.Forms.Panel panel4apoint;
        private System.Windows.Forms.Button btnappointmentback;
        private System.Windows.Forms.Label lblappointmenttitle;
        private System.Windows.Forms.TextBox textBoxpatientid;
        private System.Windows.Forms.Label lblpatientid;
        private System.Windows.Forms.ComboBox comboBoxdoctorbill;
        private System.Windows.Forms.RadioButton radioButtonpatientfemale;
        private System.Windows.Forms.RadioButton radioButtonpatientmale;
        private System.Windows.Forms.Label lblpatientgender;
        private System.Windows.Forms.Button btnappointmentcancelreq;
        private System.Windows.Forms.ComboBox comboBoxcheckuptime;
        private System.Windows.Forms.Button btnappointmentsubmitreq;
        private System.Windows.Forms.ComboBox comboBoxdoctorname;
        private System.Windows.Forms.ComboBox comboBoxdoctordepartment;
        private System.Windows.Forms.TextBox textBoxpatientage;
        private System.Windows.Forms.TextBox textBoxpatientnumber;
        private System.Windows.Forms.TextBox textBoxpatientname;
        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.Label lbldoctortime;
        private System.Windows.Forms.Label lbldoctorname;
        private System.Windows.Forms.Label lbldoctordepartment;
        private System.Windows.Forms.Label lblpatientage;
        private System.Windows.Forms.Label lblpatientnumber;
        private System.Windows.Forms.Label lblpatientname;
        private System.Windows.Forms.DataGridView dgvappoint;
        private System.Windows.Forms.Button btnappointload;
        private System.Windows.Forms.Button btnappointmentdelete;
        private System.Windows.Forms.Button btnappointsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdoctordept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdoctorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcheckuptime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvbill;
    }
}