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
    public partial class frmThemPhong : Form
    {
        public frmThemPhong()
        {
            InitializeComponent();
        }

        Phong phong = new Phong();
        private void btnGhiNhanThemPhong_Click(object sender, EventArgs e)
        {
            if (txtMaPhongfrmThemP.Text.Length == 0)
                MessageBox.Show("Mã phòng không được bỏ trống!");
            else
                if (txtMaPhongfrmThemP.Text.Length > 5)
                MessageBox.Show("Mã phòng không được dài quá 5 kí tự!");
            else
                if (txtTenLoaiPhongfrmThemP.Text.Length == 0)
                MessageBox.Show("Tên loại phòng không được bỏ trống!");
                    else 
                    {
                        try
                        {
                    phong.InsertPhong(
                    txtMaPhongfrmThemP.Text, 
                    txtTenLoaiPhongfrmThemP.Text, 
                    txtDonGiafrmThemP.Text, 
                    txtTTPhongfrmThemP.Text);
                    MessageBox.Show("Thêm thành công!");
                        }
                        catch
                        {
                    MessageBox.Show("Thêm phòng thất bại!");
                        }
                    }
        }

        private void frmThemPhong_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnHuyThemPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
