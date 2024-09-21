using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        public string MAHDN { get; set; }
      
        public string MANPP { get; set; }
        public string MANV { get; set; }
         public DateTime NGAYNHAP{ get; set; }

        public DTO_HoaDonNhap(string ma, string MANPP, string manv, DateTime ngay)
        {
            this.MAHDN = ma;
             this.MANPP = MANPP;
           
            this.MANV = manv; 
            this.NGAYNHAP = ngay;

          
        }
    }
}
