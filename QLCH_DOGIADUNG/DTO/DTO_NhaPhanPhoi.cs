using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaPhanPhoi
    {

        public string MANPP { get; set; }
        public string MALSP { get; set; }
        public string TENNPP { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }


        public DTO_NhaPhanPhoi(string ma,string malsp,string ten, string sdt, string dc)
        {
            this.MANPP = ma;
            this.MALSP = malsp;
            this.TENNPP = ten;
          
            this.SDT = sdt;

            this.DIACHI = dc;
        }
    }
}
