using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace BTThucTapNhom
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-TQJ5CVH\\SQLEXPRESS;database=QuanLyKhachSan;integrated security = SSPI");
            string sqlSelect = "select *from TaiKhoan where username='" + txtUsername.Text + "' and pass= '" +txtPassword.Text+ "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read() == true)
            {
                this.Hide();
                frmChinh frmchinh = new frmChinh();
                frmchinh.Show();
            }
            else
            {
                MessageBox.Show("Bạn đăng nhập không thành công!");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
