namespace Hospital
{
    partial class Edit
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
            this.dgvEdit = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEdit
            // 
            this.dgvEdit.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEdit.Location = new System.Drawing.Point(0, 0);
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.RowHeadersWidth = 51;
            this.dgvEdit.Size = new System.Drawing.Size(861, 129);
            this.dgvEdit.TabIndex = 0;
            this.dgvEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdit_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEdit);
            this.panel1.Location = new System.Drawing.Point(15, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 129);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Provided Information";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Tomato;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(761, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 31);
            this.btnLoad.TabIndex = 36;
            this.btnLoad.Text = "New";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.Red;
            this.BtnOk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(416, 205);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 31);
            this.BtnOk.TabIndex = 37;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(895, 265);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button BtnOk;
    }
}