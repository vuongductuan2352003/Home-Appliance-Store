using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
     

        public DTO_KhachHang(string ma, string ten, string sdt, string dc )
        {
            this.MAKH = ma;
     
            this.TENKH = ten;
            this.SDT = sdt;

            this.DIACHI = dc;
        }
    }
}
