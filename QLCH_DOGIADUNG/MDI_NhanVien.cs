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
    public partial class MDI_NhanVien : Form
    {
        public MDI_NhanVien()
        {
            InitializeComponent();
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_KhachHang khachHang =new GUI_KhachHang();
            khachHang.Show();
            
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QuanLySanPhamNhap sanPhamNhap = new GUI_QuanLySanPhamNhap();
            sanPhamNhap.Show();
        
        }

        private void quanLySanPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QuanLySanPham sanPham = new GUI_QuanLySanPham();
            sanPham.Show();
        
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanLyNhaPhânPhôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaPhanPhoi nhaPhanPhoi = new GUI_NhaPhanPhoi();
            nhaPhanPhoi.Show();
          
        }

        private void quanLyLoaiSanPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaPhanPhoi nhaPhanPhoi = new GUI_NhaPhanPhoi();
            nhaPhanPhoi.Show();
        
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_BanHang banHang = new GUI_BanHang();
            banHang.Show();
          
        }

   

      
        private void quanLyThươngHiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThuongHieu gUI_ThuongHieu = new GUI_ThuongHieu();
            gUI_ThuongHieu.Show();
        }

        private void thôngKêDoanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DangNhap dn = new GUI_DangNhap();
            dn.Show();
            Visible = false;
        }
    }
}
