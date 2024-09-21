
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_QuanLySanPham
    {
        DAL_QuanLySanPham dalnv = new DAL_QuanLySanPham();
        public DataTable getSANPHAM()
        {
            return dalnv.getSANPHAM();
        }
        public DataTable getSANPHAMM()
        {
            return dalnv.getSANPHAMM();
        }
        public int kiemtramatrung(string ma)
        {
            return dalnv.kiemtramatrung(ma);
        }
        public bool themSP(DTO_QuanLySanPham sp)
        {

            return dalnv.themSP(sp);
        }
        public bool suaSP(DTO_QuanLySanPham sp)
        {
            return dalnv.suaSP(sp);
        }
        public bool xoaSP(string ma)
        {
            return dalnv.xoaSP(ma);
        }
        public DataTable timkiemSP(string ma)
        {
            return dalnv.timkiemSP(ma);

        }
    }
}
