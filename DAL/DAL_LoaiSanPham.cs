using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_LoaiSanPham:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
      
        public DataTable getLOAISP()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from LOAISP", _con);
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
            string sql = "select count(*) from LOAISP where MALSP='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }


        public bool themLSP(DTO_LoaiSanPham lsp)
        {

            string sql = "Insert into LOAISP values('" + lsp.MALSP + "','" + lsp.TENLSP + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaLSP(DTO_LoaiSanPham lsp)
        {
            string sql = "Update LOAISP set  TENLSP=N'" + lsp.TENLSP + "' Where MALSP='" + lsp.MALSP + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaLSP(string ma)
        {
            string sql = "Delete from LOAISP where MALSP='" + ma + "'";
            thucthisql(sql);
            return true;
        }

        public DataTable timkiemLSP(string ma)
        {
            _con.Open();
            // dùng dataadapter truyền câu truy vấn
            da = new SqlDataAdapter("SELECT * FROM LOAISP WHERE MALSP = N'" + ma + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
