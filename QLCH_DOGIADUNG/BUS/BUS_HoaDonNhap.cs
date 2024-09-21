using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dalhdn = new DAL_HoaDonNhap();
        public DataTable getHOADONNHAP()
        {
            return dalhdn.getHOADONNHAP();
        }
        public bool themHDN(DTO_HoaDonNhap ma)
        {
            return dalhdn.themHDN(ma);
        }
    }
}
