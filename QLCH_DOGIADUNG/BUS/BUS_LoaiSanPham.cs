using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_LoaiSanPham
    {
        DAL_LoaiSanPham dalsap = new DAL_LoaiSanPham();
        public DataTable getLOAISP()
        {
            return dalsap.getLOAISP();
        }
        public int kiemtramatrung(string ma)
        {
            return dalsap.kiemtramatrung(ma);
        }
        public bool themLSP(DTO_LoaiSanPham lsp)
        {

            return dalsap.themLSP(lsp);
        }
        public bool suaLSP(DTO_LoaiSanPham lsp)
        {
            return dalsap.suaLSP(lsp);
        }
        public bool xoaLSP(string ma)
        {
            return dalsap.xoaLSP(ma);
        }
        public DataTable timkiemLSP(string ma)
        {
            return dalsap.timkiemLSP(ma);
        }
    }
}
