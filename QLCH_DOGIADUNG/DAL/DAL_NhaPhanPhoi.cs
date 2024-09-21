using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_NhaPhanPhoi:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getNHAPP()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NHAPP", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from NHAPP where MANPP='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }


        public bool themNPP(DTO_NhaPhanPhoi npp)
        {

            string sql = "Insert into NHAPP values('" + npp.MANPP + "','" + npp.MALSP + "','" + npp.TENNPP + "','" + npp.SDT + "','" + npp.DIACHI + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNPP(DTO_NhaPhanPhoi npp)
        {
            string sql = "Update NHAPP set MALSP='" + npp.MALSP + "', TENNPP=N'" + npp.TENNPP + "' ,SDT='" + npp.SDT + "',DIACHI='" + npp.DIACHI + "' Where MANPP='" + npp.MANPP + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNPP(string ma)
        {
            string sql = "Delete from NHAPP where MANPP='" + ma + "'";
            thucthisql(sql);
            return true;
        }

        public DataTable timkiemNPP(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM NHAPP WHERE MANPP = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
