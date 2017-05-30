using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BUS
{
    public class DichVu
    {
        Data da = new Data();
        public DataTable ShowDV()
        {
            string sql = "select *from DichVu";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertDV(string MaDV, string TenDV, string DonGia)
        {
            string sql = "insert into DichVu values ('" + MaDV + "',N'" + TenDV + "','" + DonGia + "')";
            da.NonQuery(sql);
        }

        public void SuaTTDV(string ma_dv, string MaDV, string TenDV, string DonGia)
        {
            string sql = "update DichVu set MaDV='" + MaDV + "', TenDV=N'" + TenDV + "', DonGia=N'" + DonGia + "' where MaKH='" + ma_dv + "'";
            da.NonQuery(sql);
        }

        public void XoaDV(string MaDV)
        {
            string sql = "delete DichVu where MaDV='" + MaDV + "'";
            da.NonQuery(sql);
        }
    }
}
