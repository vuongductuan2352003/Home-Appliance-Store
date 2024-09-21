using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MANV { get; set; }
        public string MATKHAU { get; set; }
        public string TENNV { get; set; }
        public string SDT { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public DTO_NhanVien()
        {
        }

        public DTO_NhanVien(string ma, string mk, string ten, string sdt, DateTime ns, string dc)
        {
            this.MANV = ma;
            this.MATKHAU = mk;
            this.TENNV = ten;
            this.SDT = sdt;
            this.NGAYSINH = ns;
            this.DIACHI = dc;
        }
    }
}
