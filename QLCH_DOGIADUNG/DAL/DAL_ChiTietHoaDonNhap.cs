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
    public class DAL_ChiTietHoaDonNhap:DBConnect
    {

        SqlCommand cmd;
        SqlDataAdapter da;

        DataTable dt;

        public DataTable getCHITIETHDN(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("select HOADONNHAP.MAHDN,CHITIETHDN.MASP,HOADONNHAP.NGAYNHAP,HOADONNHAP.MANV,HOADONNHAP.MANPP,CHITIETHDN.SOLUONG,CHITIETHDN.GIANHAP from HOADONNHAP inner join CHITIETHDN on HOADONNHAP.MAHDN = CHITIETHDN.MAHDN  where HOADONNHAP.MAHDN = '" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getCHITIETHDNN()
        {

            _con.Open();
            da = new SqlDataAdapter("select HOADONNHAP.MAHDN,CHITIETHDN.MASP,HOADONNHAP.NGAYNHAP,HOADONNHAP.MANV,HOADONNHAP.MANPP,CHITIETHDN.SOLUONG,CHITIETHDN.GIANHAP from HOADONNHAP inner join CHITIETHDN on HOADONNHAP.MAHDN = CHITIETHDN.MAHDN ", _con);
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
        public bool themCTHDN(DTO_ChiTietHoaDonNhap hdn)
        {


            string sql = "Insert into CHITIETHDN values('" + hdn.MAHDN + "','" + hdn.MASP + "','" + hdn.SOLUONG + "','" + hdn.GIANHAP + "')";
            thucthisql(sql);
            return true;
        }

       
        public DataTable getTHANHTOAN(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT HOADONNHAP.MAHDN,  HOADONNHAP.NGAYNHAP, NHAPP.TENNPP,NHANVIEN.TENNV AS [NHÂN VIÊN NHẬP],SUM(CHITIETHDN.SoLuong) AS [TỔNG SẢN PHẨM NHẬP] ,SUM(CHITIETHDN.SOLUONG * CHITIETHDN.GIANHAP) AS [TỔNG THANH TOÁN]FROM HOADONNHAP JOIN CHITIETHDN ON HOADONNHAP.MAHDN = CHITIETHDN.MAHDN JOIN NHAPP ON HOADONNHAP.MANPP = NHAPP.MANPP JOIN NHANVIEN ON NHANVIEN.MANV=HOADONNHAP.MANV WHERE HOADONNHAP.MAHDN =  '"+ma+"' GROUP BY HOADONNHAP.MAHDN,HOADONNHAP.NGAYNHAP,NHAPP.TENNPP,NHANVIEN.TENNV;\r\n", _con);


            dt = new DataTable();
            da.Fill(dt);

            _con.Close();
            return dt;
        }
        public DataTable timkiemHDN(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM CHITIETHDN WHERE MAHDN = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from CHITIETHDN where MAHDN='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }
    }
}
