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
    public class DAL_ThuongHieu:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị nhân viên ngoài màn hình
        public DataTable getTHUONGHIEU()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from THUONGHIEU", _con);
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
            string sql = "select count(*) from THUONGHIEU where MATH='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }


        public bool themTH(DTO_ThuongHieu th)
        {

            string sql = "Insert into THUONGHIEU values('" + th.MATH + "','" + th.TENTH + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaTH(DTO_ThuongHieu th)
        {
            string sql = "Update THUONGHIEU set  TENTH=N'" + th.TENTH + "' Where MATH='" + th.MATH + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaTH(string ma)
        {
            string sql = "Delete from THUONGHIEU where MATH='" + ma + "'";
            thucthisql(sql);
            return true;
        }

        public DataTable timkiemTH(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM THUONGHIEU WHERE MATH = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
