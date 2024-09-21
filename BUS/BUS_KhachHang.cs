using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalnv = new DAL_KhachHang();
        public DataTable getKHACHHANG()
        {
            return dalnv.getKHACHHANG();
        }
        public int kiemtramatrung(string ma)
        {
            return dalnv.kiemtramatrung(ma);
        }
        public bool themKH(DTO_KhachHang kh)
        {

            return dalnv.themKH(kh);
        }
        public bool suaKH(DTO_KhachHang kh)
        {
            return dalnv.suaKH(kh);
        }
        public bool xoaKH(string ma)
        {
            return dalnv.xoaKH(ma);
        }
        public DataTable timkiemKH(string ma)
        {
            return dalnv.timkiemKH(ma);
        }

    }
}
