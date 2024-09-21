using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
     
        public DataTable getNHANVIEN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NHANVIEN", _con);
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
            string sql = "select count(*) from NHANVIEN where MANV='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
      
        }
      
        public bool themNV(DTO_NhanVien nv)
        {

            string ngay = string.Format("{0}/{1}/{2}", nv.NGAYSINH.Year, nv.NGAYSINH.Month, nv.NGAYSINH.Day);
            string sql = "Insert into NHANVIEN values('" + nv.MANV + "','" + nv.MATKHAU + "','" + nv.TENNV + "','" + nv.SDT + "','" + ngay + "','" + nv.DIACHI + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNV(DTO_NhanVien nv)
        {
            string ngay = string.Format("{0}/{1}/{2}", nv.NGAYSINH.Year, nv.NGAYSINH.Month, nv.NGAYSINH.Day);
            string sql = "Update NHANVIEN set  MATKHAU='" + nv.MATKHAU + "',TENNV=N'" + nv.TENNV + "',SDT='" + nv.SDT + "',NGAYSINH='" + ngay + "',DIACHI=N'" + nv.DIACHI + "' Where MANV='" + nv.MANV + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNV(string ma)
        {
            string sql = "Delete from NHANVIEN where MANV='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    
        public DataTable timkiemNV(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE MANV = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
