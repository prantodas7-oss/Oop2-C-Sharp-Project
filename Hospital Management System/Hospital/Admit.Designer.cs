namespace Hospital
{
    partial class Admit
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblbill = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAdmit = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmit)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(941, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(403, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Admission Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtBill);
            this.panel2.Controls.Add(this.cmbType);
            this.panel2.Controls.Add(this.lblbill);
            this.panel2.Controls.Add(this.lblroomtype);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.rtxtDesc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbReason);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 565);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBill.Location = new System.Drawing.Point(137, 239);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(247, 22);
            this.txtBill.TabIndex = 21;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(137, 194);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(247, 24);
            this.cmbType.TabIndex = 20;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblbill
            // 
            this.lblbill.AutoSize = true;
            this.lblbill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblbill.Location = new System.Drawing.Point(51, 239);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(45, 23);
            this.lblbill.TabIndex = 19;
            this.lblbill.Text = "Bill:";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblroomtype.Location = new System.Drawing.Point(12, 195);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(113, 23);
            this.lblroomtype.TabIndex = 17;
            this.lblroomtype.Text = "Room Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Fill Up Your Infromation";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(148, 511);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 33);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtxtDesc.Location = new System.Drawing.Point(137, 415);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(244, 58);
            this.rtxtDesc.TabIndex = 14;
            this.rtxtDesc.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(12, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Description :";
            // 
            // cmbReason
            // 
            this.cmbReason.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Items.AddRange(new object[] {
            "Dengue Fever",
            "Typhoid",
            "Pneumonia",
            "Diarrhea ",
            "Heart Attack"});
            this.cmbReason.Location = new System.Drawing.Point(137, 371);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(247, 24);
            this.cmbReason.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(45, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Reason :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.rbtnFemale);
            this.panel3.Controls.Add(this.rbtnMale);
            this.panel3.Location = new System.Drawing.Point(137, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 24);
            this.panel3.TabIndex = 10;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(149, 2);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(74, 20);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(11, 3);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(47, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender :";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAge.Location = new System.Drawing.Point(137, 106);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(247, 22);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(78, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age :";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPhone.Location = new System.Drawing.Point(137, 329);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(247, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(55, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(137, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(45, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.Location = new System.Drawing.Point(137, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvAdmit);
            this.panel4.Location = new System.Drawing.Point(448, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 436);
            this.panel4.TabIndex = 3;
            // 
            // dgvAdmit
            // 
            this.dgvAdmit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmit.Location = new System.Drawing.Point(0, 0);
            this.dgvAdmit.Name = "dgvAdmit";
            this.dgvAdmit.RowHeadersWidth = 51;
            this.dgvAdmit.Size = new System.Drawing.Size(585, 436);
            this.dgvAdmit.TabIndex = 0;
            this.dgvAdmit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmit_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(448, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 39);
            this.panel5.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Please Check Your Data :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Location = new System.Drawing.Point(448, 576);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(586, 65);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(477, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(140, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(20, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Admit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 695);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admit";
            this.Text = "Admit";
            this.Load += new System.EventHandler(this.Admit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmit)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvAdmit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.TextBox txtBill;
    }
}