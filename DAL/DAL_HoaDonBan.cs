using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HoaDonBan:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getHOADONBAN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HOADONBAN", _con);
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
      
        public DataTable hoaDonBan(string ma)
        {
            _con.Open();
          
            da = new SqlDataAdapter("SELECT HOADONBAN.MAHDB,HOADONBAN.NGAYBAN,CHITIETHDB.MASP,CHITIETHDB.SOLUONG FROM HOADONBAN,CHITIETHDB WHERE HOADONBAN.MAHDB = '" + ma + "' AND HOADONBAN.MAHDB = CHITIETHDB.MAHDB", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool themHDB(DTO_HoaDonBan hdb)
        {

            string ngay = string.Format("{0:yyyy/MM/dd HH:mm:ss}", hdb.NGAYBAN);
            string sql = "Insert into HOADONBAN values('" + hdb.MAHDB + "','" + ngay + "','" + hdb.MANV + "','" + hdb.MAKH + "')";

            thucthisql(sql);
            return true;
        }

    }
}
