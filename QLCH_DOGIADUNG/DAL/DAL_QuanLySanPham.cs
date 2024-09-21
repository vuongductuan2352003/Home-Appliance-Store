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
    public class DAL_QuanLySanPham : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị nhân viên ngoài màn hình
        public DataTable getSANPHAM()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from SANPHAM", _con);
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
            string sql = "select count(*) from SANPHAM where MASP='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themSP(DTO_QuanLySanPham sp)
        {

            
            string sql = "Insert into SANPHAM values('" + sp.MASP + "','" + sp.TENSP + "','" + sp.MATH + "','" + sp.MALSP + "','" + sp.SOLUONG + "','" + sp.GIANHAP + "','" + sp.GIABAN + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaSP(DTO_QuanLySanPham sp)
        {
           
            string sql = "Update SANPHAM set  TENSP='" + sp.TENSP + "',MATH=N'" + sp.MATH + "',MALSP='" + sp.MALSP + "',SOLUONG='" + sp.SOLUONG + "',GIANHAP=N'" + sp.GIANHAP + "',GIABAN=N'" + sp.GIABAN + "' Where MASP='" + sp.MASP + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaSP(string ma)
        {
            string sql = "Delete from SANPHAM where MASP='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable timkiemSP(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM SANPHAM WHERE MASP = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSANPHAMM()
        {
            _con.Open();
            da = new SqlDataAdapter("Select SANPHAM.MASP,SANPHAM.TENSP,THUONGHIEU.TENTH,LOAISP.TENLSP ,SANPHAM.GIABAN from SANPHAM inner join LOAISP on SANPHAM.MALSP = LOAISP.MALSP  inner join THUONGHIEU on THUONGHIEU.MATH = SANPHAM.MATH \r\n", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
