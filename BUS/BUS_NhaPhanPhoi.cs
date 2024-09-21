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
    public class BUS_NhaPhanPhoi
    {

        DAL_NhaPhanPhoi dalnpp = new DAL_NhaPhanPhoi();
        public DataTable getNHAPP()
        {
            return dalnpp.getNHAPP();
        }
        public int kiemtramatrung(string ma)
        {
            return dalnpp.kiemtramatrung(ma);
        }
        public bool themNPP(DTO_NhaPhanPhoi npp)
        {

            return dalnpp.themNPP(npp);
        }
        public bool suaNPP(DTO_NhaPhanPhoi npp)
        {
            return dalnpp.suaNPP(npp);
        }
        public bool xoaNPP(string ma)
        {
            return dalnpp.xoaNPP(ma);
        }
        public DataTable timkiemNPP(string ma)
        {
            return dalnpp.timkiemNPP(ma);

        }
    }
}
