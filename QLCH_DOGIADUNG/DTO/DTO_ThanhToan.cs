using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThanhToan
    {
        public string MAHDB { get; set; }
        public DateTime NGAYBAN { get; set; }

        public string TENKH { get; set; }
        public string TENNV { get; set; }
        public int SOLUONG { get; set; }
        public float TONGTIEN { get; set; }



        public DTO_ThanhToan(string ma, DateTime ngay, string tenkh, string tennv, int sl, float tt)
        {
            this.MAHDB = ma;

            this.NGAYBAN = ngay;
        

            this.TENKH = tenkh;
             this.TENNV = tennv;
            this.SOLUONG = sl;

            this.TONGTIEN = tt;
        }
    }
}
