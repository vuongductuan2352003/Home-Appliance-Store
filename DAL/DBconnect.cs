using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-DARUFLF\SQLEXPRESS;Initial Catalog=QLCHBDGD;Integrated Security=True");
    }
}
