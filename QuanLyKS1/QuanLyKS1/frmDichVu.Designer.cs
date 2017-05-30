namespace BTThucTapNhom
{
    partial class frmDichVu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonGiaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnThoatDV = new System.Windows.Forms.Button();
            this.btnCapNhatDV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonGiaDV);
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txtDonGiaDV
            // 
            this.txtDonGiaDV.Location = new System.Drawing.Point(125, 128);
            this.txtDonGiaDV.Name = "txtDonGiaDV";
            this.txtDonGiaDV.Size = new System.Drawing.Size(317, 20);
            this.txtDonGiaDV.TabIndex = 5;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(125, 75);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(317, 20);
            this.txtTenDV.TabIndex = 4;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(125, 25);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(317, 20);
            this.txtMaDV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(289, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DỊCH VỤ";
            // 
            // dtgvDV
            // 
            this.dtgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dtgvDV.Location = new System.Drawing.Point(3, 242);
            this.dtgvDV.Name = "dtgvDV";
            this.dtgvDV.Size = new System.Drawing.Size(678, 231);
            this.dtgvDV.TabIndex = 2;
            this.dtgvDV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dtgvDV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(492, 63);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(75, 23);
            this.btnThemDV.TabIndex = 3;
            this.btnThemDV.Text = "THÊM";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Location = new System.Drawing.Point(492, 108);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDV.TabIndex = 4;
            this.btnSuaDV.Text = "SỬA";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Location = new System.Drawing.Point(492, 152);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDV.TabIndex = 5;
            this.btnXoaDV.Text = "XÓA";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnThoatDV
            // 
            this.btnThoatDV.Location = new System.Drawing.Point(492, 198);
            this.btnThoatDV.Name = "btnThoatDV";
            this.btnThoatDV.Size = new System.Drawing.Size(75, 23);
            this.btnThoatDV.TabIndex = 6;
            this.btnThoatDV.Text = "THOÁT";
            this.btnThoatDV.UseVisualStyleBackColor = true;
            this.btnThoatDV.Click += new System.EventHandler(this.btnThoatDV_Click);
            // 
            // btnCapNhatDV
            // 
            this.btnCapNhatDV.Location = new System.Drawing.Point(492, 21);
            this.btnCapNhatDV.Name = "btnCapNhatDV";
            this.btnCapNhatDV.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatDV.TabIndex = 7;
            this.btnCapNhatDV.Text = "CẬP NHẬT";
            this.btnCapNhatDV.UseVisualStyleBackColor = true;
            this.btnCapNhatDV.Click += new System.EventHandler(this.btnCapNhatDV_Click);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 475);
            this.Controls.Add(this.btnCapNhatDV);
            this.Controls.Add(this.btnThoatDV);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.dtgvDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDichVu_FormClosed);
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonGiaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnThoatDV;
        private System.Windows.Forms.Button btnCapNhatDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}