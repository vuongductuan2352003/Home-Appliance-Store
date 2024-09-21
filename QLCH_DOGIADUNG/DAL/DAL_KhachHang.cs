using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị nhân viên ngoài màn hình
        public DataTable getKHACHHANG()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from KHACHHANG", _con);
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
            string sql = "select count(*) from KHACHHANG where MAKH='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }
        

        public bool themKH(DTO_KhachHang kh)
        {

            string sql = "Insert into KHACHHANG values('" + kh.MAKH + "','" + kh.TENKH + "','" + kh.SDT + "','" + kh.DIACHI + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaKH(DTO_KhachHang kh)
        {
            string sql = "Update KHACHHANG set  TENKH=N'" + kh.TENKH + "',SDT='" + kh.SDT + "',DIACHI='" + kh.DIACHI + "' Where MAKH='" + kh.MAKH + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaKH(string ma)
        {
            string sql = "Delete from KHACHHANG where MAKH='" + ma + "'";
            thucthisql(sql);
            return true;
        }

        public DataTable timkiemKH(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE MAKH = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
