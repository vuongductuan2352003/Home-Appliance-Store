using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaBan
    {
        public string MAHDB { get; set; }
        public string MASP { get; set; }
        public int SOLUONG { get; set; }
        public float GIABAN { get; set; }


        public DTO_ChiTietHoaBan(string ma, string masp, int sl, float gb)
        {
            this.MAHDB = ma;

            this.MASP = masp;
            this.SOLUONG = sl;

            this.GIABAN = gb;
        }
    }
}
