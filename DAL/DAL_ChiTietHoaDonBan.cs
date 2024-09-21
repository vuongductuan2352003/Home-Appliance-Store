using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_ChiTietHoaDonBan:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
    
        DataTable dt;

        public DataTable getCHITIETHDB(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("select HOADONBAN.MAHDB,CHITIETHDB.MASP,HOADONBAN.NGAYBAN,HOADONBAN.MANV,HOADONBAN.MAKH,CHITIETHDB.SOLUONG,CHITIETHDB.GIABAN from HOADONBAN inner join CHITIETHDB on HOADONBAN.MAHDB = CHITIETHDB.MAHDB  where HOADONBAN.MAHDB = '" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getCHITIETHDBB()
        {
        
            _con.Open();
            da = new SqlDataAdapter("select HOADONBAN.MAHDB,CHITIETHDB.MASP,HOADONBAN.NGAYBAN,HOADONBAN.MANV,HOADONBAN.MAKH,CHITIETHDB.SOLUONG,CHITIETHDB.GIABAN from HOADONBAN inner join CHITIETHDB on HOADONBAN.MAHDB = CHITIETHDB.MAHDB ", _con);
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
        public bool themCTHDB(DTO_ChiTietHoaBan hdb)
        {


            string sql = "Insert into CHITIETHDB values('" + hdb.MAHDB + "','" + hdb.MASP + "','" + hdb.SOLUONG + "','" + hdb.GIABAN + "')";
            thucthisql(sql);
            return true;
        }
       

        public DataTable getTHANHTOAN(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT HOADONBAN.MAHDB,  HOADONBAN.NGAYBAN, KHACHHANG.TENKH,NHANVIEN.TENNV AS [NHÂN VIÊN BÁN],SUM(CHITIETHDB.SoLuong) AS TongSanPham ,SUM(CHITIETHDB.SOLUONG * CHITIETHDB.GIABAN) AS [TONG THANH TOAN]FROM HOADONBAN JOIN CHITIETHDB ON HOADONBAN.MAHDB = CHITIETHDB.MAHDB JOIN KHACHHANG ON HOADONBAN.MAKH = KHACHHANG.MAKH JOIN NHANVIEN ON NHANVIEN.MANV=HOADONBAN.MANV WHERE HOADONBAN.MAHDB =  '" + ma + "' GROUP BY HOADONBAN.MAHDB,HOADONBAN.NGAYBAN,KHACHHANG.TENKH,NHANVIEN.TENNV;", _con);


            dt = new DataTable();
            da.Fill(dt);
       
            _con.Close();
            return dt;
        }
        public DataTable timkiemHDB(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM CHITIETHDB WHERE MAHDB = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from CHITIETHDB where MA='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }


    }
}
