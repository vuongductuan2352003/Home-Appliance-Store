using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuanLySanPham
    {
        public string MASP { get; set; }
        public string TENSP { get; set; }
        public string MATH { get; set; }
  
        public string MALSP { get; set; }
        public int SOLUONG { get; set; }
        public float GIANHAP { get; set; }
        public float GIABAN { get; set; }


        public DTO_QuanLySanPham()
        {
        }

        public DTO_QuanLySanPham(string ma, string ten, string math, string malsp, int sl, float gianhap,float giaban)
        {
           this.MASP = ma;
            this.TENSP = ten;
            this.MATH=math;
          
            this.MALSP = malsp;
            this.SOLUONG=sl;
            this.GIANHAP = gianhap;
            this.GIABAN = giaban;

        }
    }
}
