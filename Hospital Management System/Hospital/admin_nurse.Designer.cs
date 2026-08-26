namespace Hospital
{
    partial class admin_nurse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvnurse = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnurse)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.375F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 444);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnback.Location = new System.Drawing.Point(3, 409);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 30);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btndelete.Location = new System.Drawing.Point(51, 166);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(191, 73);
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
            this.btnload.Location = new System.Drawing.Point(51, 59);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(191, 73);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "LOAD";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvnurse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(408, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 444);
            this.panel2.TabIndex = 1;
            // 
            // dgvnurse
            // 
            this.dgvnurse.AllowUserToAddRows = false;
            this.dgvnurse.AllowUserToDeleteRows = false;
            this.dgvnurse.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvnurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnurse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnurse.Location = new System.Drawing.Point(0, 0);
            this.dgvnurse.Name = "dgvnurse";
            this.dgvnurse.ReadOnly = true;
            this.dgvnurse.RowHeadersWidth = 51;
            this.dgvnurse.RowTemplate.Height = 24;
            this.dgvnurse.Size = new System.Drawing.Size(387, 442);
            this.dgvnurse.TabIndex = 0;
            this.dgvnurse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnurse_CellContentClick);
            // 
            // admin_nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "admin_nurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_nurse";
            this.Load += new System.EventHandler(this.admin_nurse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnurse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.DataGridView dgvnurse;
        private System.Windows.Forms.Button btnback;
    }
}