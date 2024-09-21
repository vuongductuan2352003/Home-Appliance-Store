using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThanhToanHDN
    {

        public string MAHDN { get; set; }
        public DateTime NGAYNHAP { get; set; }

        public string TENNPP { get; set; }
        public string TENNV { get; set; }
        public int SOLUONG { get; set; }
        public float TONGTIEN { get; set; }



        public DTO_ThanhToanHDN(string ma, DateTime ngay, string tennpp, string tennv, int sl, float tt)
        {
            this.MAHDN = ma;

            this.NGAYNHAP = ngay;


            this.TENNPP = tennpp;
            this.TENNV = tennv;
            this.SOLUONG = sl;

            this.TONGTIEN = tt;
        }
    }
}
