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
    public class DAL_ThanhToanHDN:DBConnect
    {

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTHANHTOANHDN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from THANHTOANHDN", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getDOANHTHUHDN()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT SUM(THANHTOANHDN.SOLUONG) AS[TỔNG SẢN PHẨM ĐÃ NHẬP],SUM(THANHTOANHDN.TONGTIEN*THANHTOANHDN.SOLUONG) AS [TỔNG TIỀN HÓA ĐƠN NHẬP] FROM THANHTOANHDN", _con);
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

        public bool themTHANHTOANHDN(DTO_ThanhToanHDN tt)
        {



            string ngay = string.Format("{0:yyyy/MM/dd HH:mm:ss}", tt.NGAYNHAP);
            string sql = "Insert into THANHTOANHDN values('" + tt.MAHDN + "','" + ngay + "','" + tt.TENNPP + "','" + tt.TENNV + "','" + tt.SOLUONG + "','" + tt.TONGTIEN + "')";
            thucthisql(sql);
            return true;
        }
        public DataTable thongkeDTTNN(DateTime ma, DateTime maa)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            string ngay = string.Format("{0}/{1}/{2}", ma.Year, ma.Month, ma.Day);
            string ngayy = string.Format("{0}/{1}/{2}", maa.Year, maa.Month, maa.Day);
            da = new SqlDataAdapter("SELECT SUM(THANHTOANHDN.SOLUONG) AS[TỔNG SẢN PHẨM ĐÃ NHẬP],SUM(THANHTOANHDN.TONGTIEN*THANHTOANHDN.SOLUONG) AS [TỔNG HÓA ĐƠN NHẬP] FROM THANHTOANHDN WHERE NGAYNHAP  BETWEEN '" + ngay + "'  AND '" + ngayy + "';", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

    }
}
