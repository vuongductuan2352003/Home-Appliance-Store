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
    public class BUS_ThuongHieu
    {
        DAL_ThuongHieu dalth = new DAL_ThuongHieu();
        public DataTable getTHUONGHIEU()
        {
            return dalth.getTHUONGHIEU();
        }
        public int kiemtramatrung(string ma)
        {
            return dalth.kiemtramatrung(ma);
        }
        public bool themTH(DTO_ThuongHieu th)
        {

            return dalth.themTH(th);
        }
        public bool suaTH(DTO_ThuongHieu th)
        {
            return dalth.suaTH(th);
        }
        public bool xoaTH(string ma)
        {
            return dalth.xoaTH(ma);
        }
        public DataTable timkiemTH(string ma)
        {
            return dalth.timkiemTH(ma);
        }
       
    }
}
