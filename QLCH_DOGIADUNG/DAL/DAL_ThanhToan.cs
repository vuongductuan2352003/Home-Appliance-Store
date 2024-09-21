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
    public class DAL_ThanhToan:DBConnect
    {

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTHANHTOAN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from THANHTOAN", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getDOANHTHU()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT SUM(THANHTOAN.SOLUONG) AS[TỔNG SẢN PHẨM ĐÃ BÁN],SUM(THANHTOAN.TONGTIEN*THANHTOAN.SOLUONG) AS [TỔNG DOANH THU] FROM THANHTOAN", _con);
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

        public bool themTHANHTOAN(DTO_ThanhToan tt)
        {

       
      
            string ngay = string.Format("{0:yyyy/MM/dd HH:mm:ss}", tt.NGAYBAN);
            string sql = "Insert into THANHTOAN values('" + tt.MAHDB + "','" + ngay + "','" + tt.TENKH + "','" + tt.TENNV + "','" + tt.SOLUONG + "','" + tt.TONGTIEN + "')";
            thucthisql(sql);
            return true;
        }
        public DataTable thongkeDTTN(DateTime ma, DateTime maa)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            string ngay = string.Format("{0}/{1}/{2}", ma.Year, ma.Month, ma.Day);
            string ngayy = string.Format("{0}/{1}/{2}", maa.Year, maa.Month, maa.Day);
            da = new SqlDataAdapter("SELECT SUM(THANHTOAN.SOLUONG) AS[TỔNG SẢN PHẨM ĐÃ BÁN],SUM(THANHTOAN.TONGTIEN*THANHTOAN.SOLUONG) AS [TỔNG DOANH THU] FROM THANHTOAN WHERE NGAYBAN  BETWEEN '" + ngay+"'  AND '"+ngayy+"';", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

    }
}
