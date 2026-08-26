namespace Hospital
{
    partial class Patient
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
            this.btnBlood = new System.Windows.Forms.Button();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBlood
            // 
            this.btnBlood.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBlood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlood.Location = new System.Drawing.Point(32, 188);
            this.btnBlood.Name = "btnBlood";
            this.btnBlood.Size = new System.Drawing.Size(159, 52);
            this.btnBlood.TabIndex = 1;
            this.btnBlood.Text = "Blood Bank";
            this.btnBlood.UseVisualStyleBackColor = false;
            this.btnBlood.Click += new System.EventHandler(this.btnBlood_Click);
            // 
            // btnAdmit
            // 
            this.btnAdmit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmit.Location = new System.Drawing.Point(33, 188);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(159, 52);
            this.btnAdmit.TabIndex = 1;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = false;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.HotPink;
            this.btnAppointment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Location = new System.Drawing.Point(35, 188);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(159, 52);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Piority Work";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAppointment);
            this.panel1.Location = new System.Drawing.Point(73, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 526);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnAdmit);
            this.panel2.Location = new System.Drawing.Point(372, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 526);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnBlood);
            this.panel3.Location = new System.Drawing.Point(682, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 526);
            this.panel3.TabIndex = 4;
            // 
            // btnLogOut1
            // 
            this.btnLogOut1.BackColor = System.Drawing.Color.Teal;
            this.btnLogOut1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut1.Location = new System.Drawing.Point(934, 571);
            this.btnLogOut1.Name = "btnLogOut1";
            this.btnLogOut1.Size = new System.Drawing.Size(119, 44);
            this.btnLogOut1.TabIndex = 5;
            this.btnLogOut1.Text = "LogOut";
            this.btnLogOut1.UseVisualStyleBackColor = false;
            this.btnLogOut1.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1065, 653);
            this.Controls.Add(this.btnLogOut1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBlood;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogOut1;
    }
}