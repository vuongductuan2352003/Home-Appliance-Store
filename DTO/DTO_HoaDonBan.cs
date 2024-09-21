using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBan
    {
        public string MAHDB { get; set; }
        public DateTime NGAYBAN { get; set; }
        public string MANV { get; set; }
        public string MAKH { get; set; }


        public DTO_HoaDonBan(string ma, DateTime ngay, string manv, string makh)
        {
            this.MAHDB = ma;

            this.NGAYBAN = ngay;
            this.MANV = manv;

            this.MAKH = makh;
        }
    }
}
