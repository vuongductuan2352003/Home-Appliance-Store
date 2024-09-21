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
    public class DAL_HoaDonNhap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getHOADONNHAP()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HOADONNHAP", _con);
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
        public DataTable hoaDonNhap(string ma)
        {
            _con.Open();

            da = new SqlDataAdapter("SELECT HOADONNHAP.MAHDN,HOADONNHAP.NGAYNHAP,CHITIETHDN.MASP,CHITIETHDN.SOLUONG FROM HOADONNHAP,CHITIETHDN WHERE HOADONNHAP.MAHDN = '" + ma + "' AND HOADONNHAP.MAHDN = CHITIETHDN.MAHDN", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool themHDN(DTO_HoaDonNhap hdn)
        {

            string ngay = string.Format("{0:yyyy/MM/dd HH:mm:ss}", hdn.NGAYNHAP);
            string sql = "Insert into HOADONNHAP values('" + hdn.MAHDN + "','" + hdn.MANPP + "','" + hdn.MANV + "','" + ngay + "')";

            thucthisql(sql);
            return true;
        }
    }
}
