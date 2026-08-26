namespace Hospital
{
    partial class BloodBank
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPay = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvBloodInfo = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodInfo)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(127, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Blood Bank";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.71749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.28251F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvBloodInfo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.49511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.50489F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 487);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtGroup);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 371);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 22);
            this.txtName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Provide Your Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(144, 179);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(133, 22);
            this.txtPhone.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Phone :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(143, 95);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(133, 22);
            this.txtId.TabIndex = 19;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(143, 258);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(133, 22);
            this.txtQuantity.TabIndex = 17;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(143, 215);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(133, 22);
            this.txtGroup.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blood Group:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnPay);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(301, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 104);
            this.panel3.TabIndex = 2;
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnPay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.Location = new System.Drawing.Point(541, 6);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(110, 60);
            this.BtnPay.TabIndex = 22;
            this.BtnPay.Text = "Make Payment";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(386, 21);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(133, 22);
            this.txtPrice.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Price :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCancle);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 104);
            this.panel4.TabIndex = 3;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(156, 3);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(120, 53);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancel Request";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 53);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvBloodInfo
            // 
            this.dgvBloodInfo.AllowUserToAddRows = false;
            this.dgvBloodInfo.AllowUserToDeleteRows = false;
            this.dgvBloodInfo.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvBloodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvBgroup,
            this.dgvQuantity,
            this.dgvPrice});
            this.dgvBloodInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBloodInfo.Location = new System.Drawing.Point(301, 3);
            this.dgvBloodInfo.Name = "dgvBloodInfo";
            this.dgvBloodInfo.ReadOnly = true;
            this.dgvBloodInfo.RowHeadersWidth = 51;
            this.dgvBloodInfo.RowTemplate.Height = 24;
            this.dgvBloodInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloodInfo.Size = new System.Drawing.Size(668, 371);
            this.dgvBloodInfo.TabIndex = 0;
            this.dgvBloodInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBloodInfo_CellClick);
            this.dgvBloodInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBloodInfo_CellContentClick);
            // 
            // dgvId
            // 
            this.dgvId.DataPropertyName = "ID";
            this.dgvId.HeaderText = "ID";
            this.dgvId.MinimumWidth = 6;
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 75;
            // 
            // dgvBgroup
            // 
            this.dgvBgroup.DataPropertyName = "Blood_Group";
            this.dgvBgroup.HeaderText = "Blood Group";
            this.dgvBgroup.MinimumWidth = 6;
            this.dgvBgroup.Name = "dgvBgroup";
            this.dgvBgroup.ReadOnly = true;
            this.dgvBgroup.Width = 150;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.DataPropertyName = "Quantity";
            this.dgvQuantity.HeaderText = "Available Quantity ";
            this.dgvQuantity.MinimumWidth = 6;
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            this.dgvQuantity.Width = 150;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPrice.DataPropertyName = "Price";
            this.dgvPrice.HeaderText = "Unit Price ";
            this.dgvPrice.MinimumWidth = 6;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(12, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(972, 57);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(228, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "** NOTED ! Quantity Is in unit,Where 1 Unit  = 500 ml Blood";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select Your blood Group and Quantity Of Blood";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(909, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BloodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1006, 638);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "BloodBank";
            this.Text = "BloodBank";
            this.Load += new System.EventHandler(this.BloodBank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodInfo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvBloodInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnPay;
    }
}