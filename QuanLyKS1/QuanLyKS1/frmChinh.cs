using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTThucTapNhom
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnNVfrmChinh_Click(object sender, EventArgs e)
        {
            frmNhanVien NV = new frmNhanVien();
            NV.Show();
        }

        private void btnPhongfrmChinh_Click(object sender, EventArgs e)
        {
            frmPhong frmphong = new frmPhong();
            frmphong.Show();
        }

        private void btnKHfrmChinh_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.Show();
        }

        private void btnTBCfrmChinh_Click(object sender, EventArgs e)
        {
            frmThietBi frmtb = new frmThietBi();
            frmtb.Show();
        }

        private void btnDVfrmChinh_Click(object sender, EventArgs e)
        {
            frmDichVu frmdv = new frmDichVu();
            frmdv.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHelp frmhelp = new frmHelp();
            frmhelp.Show();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            frmThuePhong frmthuephong = new frmThuePhong();
            frmthuephong.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmDangNhap frmdangnhap = new frmDangNhap();
            this.Hide();
            frmdangnhap.Show();
        }
    }
}
