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
    public class BUS_ThanhToanHDN
    {
        DAL_ThanhToanHDN daltt = new DAL_ThanhToanHDN();
        public DataTable getTHANHTOANHDN()
        {
            return daltt.getTHANHTOANHDN();
        }
        public DataTable getDOANHTHU()
        {
            return daltt.getDOANHTHUHDN();
        }
        public bool themTHANHTOAN(DTO_ThanhToanHDN tt)
        {

            return daltt.themTHANHTOANHDN(tt);
        }
        public DataTable thongkeDTTNN(DateTime ngay, DateTime ngayy)
        {
            return daltt.thongkeDTTNN(ngay, ngayy);
        }
    }
}
