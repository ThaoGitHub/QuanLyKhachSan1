using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Data
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection("server=DESKTOP-TQJ5CVH\\SQLEXPRESS;database=QuanLyKhachSan;integrated security = SSPI");
        }

        //lenh sql tra ve mot bang
        public DataTable GetTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        //lenh sql khong tra ve
        public void NonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
