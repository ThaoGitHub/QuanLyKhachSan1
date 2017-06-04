namespace BTThucTapNhom
{
    partial class frmThemPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhongfrmThemP = new System.Windows.Forms.TextBox();
            this.txtTenLoaiPhongfrmThemP = new System.Windows.Forms.TextBox();
            this.txtDonGiafrmThemP = new System.Windows.Forms.TextBox();
            this.txtTTPhongfrmThemP = new System.Windows.Forms.TextBox();
            this.btnGhiNhanThemPhong = new System.Windows.Forms.Button();
            this.btnHuyThemPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình trạng phòng:";
            // 
            // txtMaPhongfrmThemP
            // 
            this.txtMaPhongfrmThemP.Location = new System.Drawing.Point(141, 53);
            this.txtMaPhongfrmThemP.Name = "txtMaPhongfrmThemP";
            this.txtMaPhongfrmThemP.Size = new System.Drawing.Size(344, 20);
            this.txtMaPhongfrmThemP.TabIndex = 4;
            // 
            // txtTenLoaiPhongfrmThemP
            // 
            this.txtTenLoaiPhongfrmThemP.Location = new System.Drawing.Point(141, 97);
            this.txtTenLoaiPhongfrmThemP.Name = "txtTenLoaiPhongfrmThemP";
            this.txtTenLoaiPhongfrmThemP.Size = new System.Drawing.Size(344, 20);
            this.txtTenLoaiPhongfrmThemP.TabIndex = 5;
            // 
            // txtDonGiafrmThemP
            // 
            this.txtDonGiafrmThemP.Location = new System.Drawing.Point(141, 144);
            this.txtDonGiafrmThemP.Name = "txtDonGiafrmThemP";
            this.txtDonGiafrmThemP.Size = new System.Drawing.Size(344, 20);
            this.txtDonGiafrmThemP.TabIndex = 6;
            // 
            // txtTTPhongfrmThemP
            // 
            this.txtTTPhongfrmThemP.Location = new System.Drawing.Point(141, 184);
            this.txtTTPhongfrmThemP.Name = "txtTTPhongfrmThemP";
            this.txtTTPhongfrmThemP.Size = new System.Drawing.Size(344, 20);
            this.txtTTPhongfrmThemP.TabIndex = 7;
            // 
            // btnGhiNhanThemPhong
            // 
            this.btnGhiNhanThemPhong.Location = new System.Drawing.Point(151, 248);
            this.btnGhiNhanThemPhong.Name = "btnGhiNhanThemPhong";
            this.btnGhiNhanThemPhong.Size = new System.Drawing.Size(101, 37);
            this.btnGhiNhanThemPhong.TabIndex = 8;
            this.btnGhiNhanThemPhong.Text = "GHI NHẬN";
            this.btnGhiNhanThemPhong.UseVisualStyleBackColor = true;
            this.btnGhiNhanThemPhong.Click += new System.EventHandler(this.btnGhiNhanThemPhong_Click);
            // 
            // btnHuyThemPhong
            // 
            this.btnHuyThemPhong.Location = new System.Drawing.Point(305, 248);
            this.btnHuyThemPhong.Name = "btnHuyThemPhong";
            this.btnHuyThemPhong.Size = new System.Drawing.Size(86, 37);
            this.btnHuyThemPhong.TabIndex = 9;
            this.btnHuyThemPhong.Text = "HỦY";
            this.btnHuyThemPhong.UseVisualStyleBackColor = true;
            this.btnHuyThemPhong.Click += new System.EventHandler(this.btnHuyThemPhong_Click);
            // 
            // frmThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 304);
            this.Controls.Add(this.btnHuyThemPhong);
            this.Controls.Add(this.btnGhiNhanThemPhong);
            this.Controls.Add(this.txtTTPhongfrmThemP);
            this.Controls.Add(this.txtDonGiafrmThemP);
            this.Controls.Add(this.txtTenLoaiPhongfrmThemP);
            this.Controls.Add(this.txtMaPhongfrmThemP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemPhong";
            this.Text = "frmThemPhong";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThemPhong_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhongfrmThemP;
        private System.Windows.Forms.TextBox txtTenLoaiPhongfrmThemP;
        private System.Windows.Forms.TextBox txtDonGiafrmThemP;
        private System.Windows.Forms.TextBox txtTTPhongfrmThemP;
        private System.Windows.Forms.Button btnGhiNhanThemPhong;
        private System.Windows.Forms.Button btnHuyThemPhong;
    }
}