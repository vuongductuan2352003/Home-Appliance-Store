using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonNhap
    {

        public string MAHDN { get; set; }
        public string MASP { get; set; }
        public int SOLUONG { get; set; }
        public float GIANHAP { get; set; }


        public DTO_ChiTietHoaDonNhap(string ma, string masp, int sl, float gn)
        {
            this.MAHDN = ma;

            this.MASP = masp;
            this.SOLUONG = sl;

            this.GIANHAP = gn;
        }
    }
}
