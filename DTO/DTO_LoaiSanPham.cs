using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiSanPham
    {
        public string MALSP { get; set; }
        public string TENLSP { get; set; }



        public DTO_LoaiSanPham(string ma, string ten)
        {
            this.MALSP = ma;

            this.TENLSP = ten;

        }
    }
}
