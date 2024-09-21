using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_Login
    {
        DAL_Login dalnv = new DAL_Login();
        public DataTable getNHANVIEN()
        {
            return dalnv.getNHANVIEN();
        }
        public int checkLogin(string acc, string pw) 
        {
            return dalnv.checkLogin(acc,pw);
        }

    }
}
