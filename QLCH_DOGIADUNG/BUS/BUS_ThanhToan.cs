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
    public class BUS_ThanhToan
    {
        DAL_ThanhToan daltt= new DAL_ThanhToan();   
        public DataTable getTHANHTOAN()
        {
            return daltt.getTHANHTOAN();
        }
        public DataTable getDOANHTHU()
        {
            return daltt.getDOANHTHU();
        }
        public bool themTHANHTOAN(DTO_ThanhToan tt)
        {

            return daltt.themTHANHTOAN(tt);
        }
        public DataTable thongkeDTTN(DateTime ngay,DateTime ngayy)
        {
            return daltt.thongkeDTTN(ngay,ngayy);
        }
    }
}
