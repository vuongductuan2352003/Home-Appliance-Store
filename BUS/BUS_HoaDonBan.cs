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
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dalhdb = new DAL_HoaDonBan();
        public DataTable getHOADONBAN()
        {
            return dalhdb.getHOADONBAN();
        }
        public bool themHDB(DTO_HoaDonBan ma)
        {
            return dalhdb.themHDB(ma);
        }
    }
}
