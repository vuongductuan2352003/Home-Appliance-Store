using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_ChiTietHoaDonBan
    {
        DAL_ChiTietHoaDonBan dalhdb = new DAL_ChiTietHoaDonBan();
        public DataTable getCHITIETHDB(string ma)
        {
            return dalhdb.getCHITIETHDB(ma);
        }
        public DataTable getCHITIETHDBB()
        {
            return dalhdb.getCHITIETHDBB();
        }
        public bool themCTHDB(DTO_ChiTietHoaBan ma)
        {
            return dalhdb.themCTHDB(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalhdb.kiemtramatrung(ma);
        }
        public DataTable timkiemCTHDB(string ma)
        {
            return dalhdb.timkiemHDB(ma);
        }
        public DataTable getTHANHTOAN(string ma)
        {
            return dalhdb.getTHANHTOAN(ma);
        }
    }
}
