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
    public class BUS_ChiTietHoaDonNhap
    {
        DAL_ChiTietHoaDonNhap dalhdn = new DAL_ChiTietHoaDonNhap();
        public DataTable getCHITIETHDN(string ma)
        {
            return dalhdn.getCHITIETHDN(ma);
        }
        public DataTable getCHITIETHDNN()
        {
            return dalhdn.getCHITIETHDNN();
        }
        public bool themCTHDN(DTO_ChiTietHoaDonNhap ma)
        {
            return dalhdn.themCTHDN(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalhdn.kiemtramatrung(ma);
        }
        public DataTable timkiemCTHDN(string ma)
        {
            return dalhdn.timkiemHDN(ma);
        }
        public DataTable getTHANHTOAN(string ma)
        {
            return dalhdn.getTHANHTOAN(ma);
        }
    }
}
