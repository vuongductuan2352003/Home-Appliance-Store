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
    public class DAL_Login:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //các hàm xử lý
        public DataTable getNHANVIEN()
        {
            // Mở kết nối dbconnect
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM NHANVIEN", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            // mở connect
            _con.Open();
            // dùng đối tượng cmd
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

 
        public int checkLogin(string acc, string pw)
        {
            int i;
            _con.Open();
            string sql = "select count(MANV) from NHANVIEN where MANV = '" + acc + "' and MATKHAU = '" + pw + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }


    }
}
