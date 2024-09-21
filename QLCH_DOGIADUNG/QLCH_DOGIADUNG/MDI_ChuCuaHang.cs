using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_DOGIADUNG
{
    public partial class MDI_ChuCuaHang : Form
    {
        public MDI_ChuCuaHang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quanLyNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhanVien nhanVien = new GUI_NhanVien(); 
            nhanVien.Show();
           
        }

      

     
        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_KhachHang khachHang = new GUI_KhachHang();
            khachHang.Show();
         
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI_DangNhap dangNhap = new GUI_DangNhap();
            dangNhap.Show();
            Visible = false;    
        }

        private void quanLySanPhâmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GUI_QuanLySanPham sanPham = new GUI_QuanLySanPham();
            sanPham.Show();
        }

        private void quanLyNhaPhânPhôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaPhanPhoi nhaPhanPhoi = new GUI_NhaPhanPhoi();
            nhaPhanPhoi.Show();
        }

        private void quanLyThươngHiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThuongHieu thuongHieu = new GUI_ThuongHieu();
            thuongHieu.Show();
        }

        private void quanLyLoaiSanPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_loaiSanPham loaiSanPham = new GUI_loaiSanPham();
            loaiSanPham.Show();
        }

        private void quanLyKhachHangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GUI_KhachHang khachHang = new GUI_KhachHang();
            khachHang.Show();
        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThongKe thongKe = new GUI_ThongKe();
            thongKe.Show();
        }

        private void thôngKêHoaĐơnNhâpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI_ThongKeHDN thongKe = new GUI_ThongKeHDN();
            thongKe.Show();
        }

        private void xemChiTiêtHoaĐơnBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChiTietHDB chiTietHDB = new GUI_ChiTietHDB();
            chiTietHDB.Show();
        }

        private void xemChiTiêtHoaĐơnNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChiTietHDN chiTietHDN = new GUI_ChiTietHDN();
            chiTietHDN.Show();
        }
    }
}
