using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BUS
{
    public class Phong
    {
        Data da = new Data();
        public DataTable ShowPhong()
        {
            string sql = "select *from Phong";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertPhong(string MaPhong, string TenLoaiPhong, string DonGia, string TinhTrang)
        {
            string sql = "insert into Phong values ('"+MaPhong+"',N'"+TenLoaiPhong+"','"+DonGia+"',N'"+TinhTrang+"')";
            da.NonQuery(sql);
        }

        public void SuaPhong(string ma_phong, string MaPhong, string Ten_loaiPhong, string dongia, string tinhtrang)
        {
            string sql = "update Phong set MaPhong='" + MaPhong + "', TenLoaiPhong=N'" + Ten_loaiPhong + "', DonGia='" + dongia + "', TinhTrang=N'" + tinhtrang + "'  where MaPhong='" + ma_phong + "'";
            da.NonQuery(sql);
        }

        public void XoaPhong(string MaPhong)
        {
            string sql = "delete Phong where MaPhong='" + MaPhong + "'";
            da.NonQuery(sql);
        }
    }
}
