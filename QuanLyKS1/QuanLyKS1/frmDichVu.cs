using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace BTThucTapNhom
{
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        DichVu dv = new DichVu();
        string ma_dv;

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = dv.ShowDV();
            dtgvDV.DataSource = dt;
        }

        private void btnCapNhatDV_Click(object sender, EventArgs e)
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDonGiaDV.Clear();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (this.txtMaDV.TextLength == 0)
                MessageBox.Show("Mã dịch vụ không được bỏ trống!");
            else
                if (this.txtMaDV.TextLength > 5)
                MessageBox.Show("Mã dịch vụ không được dài quá 5 kí tự!");
            else
                if (this.txtTenDV.TextLength == 0)
                MessageBox.Show("Tên dịch vụ không được bỏ trống!");
            else
            {
                try
                {
                    dv.InsertDV(
                        txtMaDV.Text,
                        txtTenDV.Text,
                        txtDonGiaDV.Text
                        );
                    MessageBox.Show("Đã thêm thành công!");
                    //frmNhanVien_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            LoadData();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            ma_dv = dtgvDV.Rows[dong].Cells[1].Value.ToString();
            this.txtMaDV.Text = dtgvDV.Rows[dong].Cells[1].Value.ToString();
            this.txtTenDV.Text = dtgvDV.Rows[dong].Cells[2].Value.ToString();
            this.txtDonGiaDV.Text = dtgvDV.Rows[dong].Cells[3].Value.ToString();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dtgvDV.RowCount; i++)
            {
                dtgvDV.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmDichVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text.Length == 0)
                MessageBox.Show("Bạn chưa chọn mã dịch vụ để sửa!");
            else
                if (txtMaDV.Text.Length > 5)
                MessageBox.Show("Mã dịch vụ không được dài quá 5 kí tự!");
            else
                if (txtTenDV.Text.Length == 0)
                MessageBox.Show("Tên dịch vụ không được để trống!");
            else
            {
                dv.SuaTTDV(
                ma_dv,
                txtMaDV.Text,
                txtTenDV.Text,
                txtDonGiaDV.Text
                );
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (this.txtMaDV.TextLength == 0)
                MessageBox.Show("Bạn cần chọn dịch vụ để xóa");
            else
            {
                dv.XoaDV(ma_dv);
                MessageBox.Show("Đã xóa thành công!");
                frmDichVu_Load(sender, e);
            }
        }

        private void btnThoatDV_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmChinh frmchinh = new frmChinh();
                    frmchinh.Show();
                    this.Hide();
                }
        }
    }
}
