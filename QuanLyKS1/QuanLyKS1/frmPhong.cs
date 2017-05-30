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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        Phong phong = new Phong();
        string ma_phong;

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = phong.ShowPhong();
            dtgvPhong.DataSource = dt;
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvPhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dtgvPhong.RowCount; i++)
            {
                dtgvPhong.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dtgvPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            ma_phong = dtgvPhong.Rows[dong].Cells[1].Value.ToString();
            this.txtMaPhong.Text = dtgvPhong.Rows[dong].Cells[1].Value.ToString();
            this.txtTenLoaiPhong.Text = dtgvPhong.Rows[dong].Cells[2].Value.ToString();
            this.txtDonGia.Text = dtgvPhong.Rows[dong].Cells[3].Value.ToString();
            this.txtTinhTrang.Text = dtgvPhong.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            frmThemPhong frmthemphong = new frmThemPhong();
            frmthemphong.FormClosed += frmPhong_FormClosed;
            frmthemphong.Show();
        }

        private void frmPhong_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Length == 0)
                MessageBox.Show("Bạn chưa chọn mã phòng để sửa!");
            else
                if (txtMaPhong.Text.Length > 5)
                MessageBox.Show("Mã phòng không được dài quá 5 kí tự!");
            else
                if (txtTenLoaiPhong.Text.Length == 0)
                MessageBox.Show("Tên loại phòng không được bỏ trống!");
            else
            {
                    phong.SuaPhong(
                    ma_phong,
                    txtMaPhong.Text,
                    txtTenLoaiPhong.Text,
                    txtDonGia.Text,
                    txtTinhTrang.Text);
                    MessageBox.Show("Sửa thành công!");
                    LoadData();
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (this.txtMaPhong.TextLength == 0)
                MessageBox.Show("Bạn cần chọn nhân viên để xóa");
            else
            {
                phong.XoaPhong(ma_phong);
                MessageBox.Show("Đã xóa thành công!");
                frmPhong_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmChinh frmchinh = new frmChinh();
                frmchinh.Show();
                this.Hide();
            }
        }
    }
}
