namespace Hospital
{
    partial class adminbloodbank
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
            this.dgvadbloodbk = new System.Windows.Forms.DataGridView();
            this.paneladminblood02 = new System.Windows.Forms.Panel();
            this.dgvadminblood = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBlood_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneladmin001 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.paneladmin002 = new System.Windows.Forms.Panel();
            this.btnPrice = new System.Windows.Forms.Button();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.paneladmin003 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadbloodbk)).BeginInit();
            this.paneladminblood02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminblood)).BeginInit();
            this.paneladmin001.SuspendLayout();
            this.paneladmin002.SuspendLayout();
            this.paneladmin003.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvadbloodbk
            // 
            this.dgvadbloodbk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadbloodbk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvadbloodbk.Location = new System.Drawing.Point(0, 0);
            this.dgvadbloodbk.Name = "dgvadbloodbk";
            this.dgvadbloodbk.RowHeadersWidth = 51;
            this.dgvadbloodbk.RowTemplate.Height = 24;
            this.dgvadbloodbk.Size = new System.Drawing.Size(1193, 557);
            this.dgvadbloodbk.TabIndex = 0;
            // 
            // paneladminblood02
            // 
            this.paneladminblood02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneladminblood02.Controls.Add(this.dgvadminblood);
            this.paneladminblood02.Location = new System.Drawing.Point(596, 14);
            this.paneladminblood02.Name = "paneladminblood02";
            this.paneladminblood02.Size = new System.Drawing.Size(584, 530);
            this.paneladminblood02.TabIndex = 2;
            // 
            // dgvadminblood
            // 
            this.dgvadminblood.AllowUserToAddRows = false;
            this.dgvadminblood.AllowUserToDeleteRows = false;
            this.dgvadminblood.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvadminblood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadminblood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvPhone,
            this.dgvBlood_Group,
            this.dgvQuantity,
            this.dgvPrice});
            this.dgvadminblood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvadminblood.Location = new System.Drawing.Point(0, 0);
            this.dgvadminblood.Name = "dgvadminblood";
            this.dgvadminblood.ReadOnly = true;
            this.dgvadminblood.RowHeadersWidth = 51;
            this.dgvadminblood.RowTemplate.Height = 24;
            this.dgvadminblood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadminblood.Size = new System.Drawing.Size(582, 528);
            this.dgvadminblood.TabIndex = 0;
            this.dgvadminblood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadminblood_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 25;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 130;
            // 
            // dgvPhone
            // 
            this.dgvPhone.DataPropertyName = "Phone";
            this.dgvPhone.HeaderText = "Phone";
            this.dgvPhone.MinimumWidth = 6;
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            this.dgvPhone.Width = 125;
            // 
            // dgvBlood_Group
            // 
            this.dgvBlood_Group.DataPropertyName = "Blood_Group";
            this.dgvBlood_Group.HeaderText = "Blood_Group";
            this.dgvBlood_Group.MinimumWidth = 6;
            this.dgvBlood_Group.Name = "dgvBlood_Group";
            this.dgvBlood_Group.ReadOnly = true;
            this.dgvBlood_Group.Width = 150;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.DataPropertyName = "Quantity";
            this.dgvQuantity.HeaderText = "Quantity";
            this.dgvQuantity.MinimumWidth = 6;
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            this.dgvQuantity.Width = 125;
            // 
            // dgvPrice
            // 
            this.dgvPrice.DataPropertyName = "Price";
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 6;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 125;
            // 
            // paneladmin001
            // 
            this.paneladmin001.BackColor = System.Drawing.Color.PapayaWhip;
            this.paneladmin001.Controls.Add(this.btndelete);
            this.paneladmin001.Controls.Add(this.btnload);
            this.paneladmin001.Location = new System.Drawing.Point(12, 14);
            this.paneladmin001.Name = "paneladmin001";
            this.paneladmin001.Size = new System.Drawing.Size(585, 127);
            this.paneladmin001.TabIndex = 3;
            this.paneladmin001.Paint += new System.Windows.Forms.PaintEventHandler(this.paneladmin001_Paint);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btndelete.Location = new System.Drawing.Point(192, 13);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(156, 101);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnload.Location = new System.Drawing.Point(12, 13);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(136, 101);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "LOAD";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // paneladmin002
            // 
            this.paneladmin002.BackColor = System.Drawing.Color.PapayaWhip;
            this.paneladmin002.Controls.Add(this.btnPrice);
            this.paneladmin002.Controls.Add(this.txttotalprice);
            this.paneladmin002.Controls.Add(this.lbltotalprice);
            this.paneladmin002.Location = new System.Drawing.Point(12, 147);
            this.paneladmin002.Name = "paneladmin002";
            this.paneladmin002.Size = new System.Drawing.Size(582, 176);
            this.paneladmin002.TabIndex = 4;
            this.paneladmin002.Paint += new System.Windows.Forms.PaintEventHandler(this.paneladmin002_Paint);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.DeepPink;
            this.btnPrice.Location = new System.Drawing.Point(262, 79);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(136, 34);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "Calculate";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(10, 85);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(214, 22);
            this.txttotalprice.TabIndex = 1;
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbltotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbltotalprice.Location = new System.Drawing.Point(4, 30);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(170, 32);
            this.lbltotalprice.TabIndex = 0;
            this.lbltotalprice.Text = "Total Price:";
            // 
            // paneladmin003
            // 
            this.paneladmin003.BackColor = System.Drawing.Color.PapayaWhip;
            this.paneladmin003.Controls.Add(this.button1);
            this.paneladmin003.Location = new System.Drawing.Point(13, 330);
            this.paneladmin003.Name = "paneladmin003";
            this.paneladmin003.Size = new System.Drawing.Size(577, 180);
            this.paneladmin003.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(9, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminbloodbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 557);
            this.Controls.Add(this.paneladmin003);
            this.Controls.Add(this.paneladmin002);
            this.Controls.Add(this.paneladmin001);
            this.Controls.Add(this.paneladminblood02);
            this.Controls.Add(this.dgvadbloodbk);
            this.Name = "adminbloodbank";
            this.Text = "adminbloodbank";
            ((System.ComponentModel.ISupportInitialize)(this.dgvadbloodbk)).EndInit();
            this.paneladminblood02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminblood)).EndInit();
            this.paneladmin001.ResumeLayout(false);
            this.paneladmin002.ResumeLayout(false);
            this.paneladmin002.PerformLayout();
            this.paneladmin003.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvadbloodbk;
        private System.Windows.Forms.Panel paneladminblood02;
        private System.Windows.Forms.DataGridView dgvadminblood;
        private System.Windows.Forms.Panel paneladmin001;
        private System.Windows.Forms.Panel paneladmin002;
        private System.Windows.Forms.Panel paneladmin003;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBlood_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button button1;
    }
}