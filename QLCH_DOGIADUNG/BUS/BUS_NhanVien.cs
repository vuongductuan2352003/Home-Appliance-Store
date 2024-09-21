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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public DataTable getNHANVIEN()
        {
            return dalnv.getNHANVIEN();
        }
        public int kiemtramatrung(string ma)
        {
            return dalnv.kiemtramatrung(ma);
        }
        public bool themNV(DTO_NhanVien nv)
        {

            return dalnv.themNV(nv);
        }
        public bool suaNV(DTO_NhanVien nv)
        {
            return dalnv.suaNV(nv);
        }
        public bool xoaNV(string ma)
        {
            return dalnv.xoaNV(ma);
        }
        public DataTable timkiemNV(string ma)
        {
            return dalnv.timkiemNV(ma);
        }


    }

}
