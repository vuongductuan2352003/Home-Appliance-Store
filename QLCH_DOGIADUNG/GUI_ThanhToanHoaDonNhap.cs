using BUS;
using DTO;
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
    public partial class GUI_ThanhToanHoaDonNhap : Form
    {
        BUS_ChiTietHoaDonNhap buscthdn = new BUS_ChiTietHoaDonNhap();
        BUS_ThanhToanHDN bustt = new BUS_ThanhToanHDN();
        BUS_HoaDonNhap bushdn = new BUS_HoaDonNhap();
        string mahdn = GUI_QuanLySanPhamNhap.mahdn;
        public GUI_ThanhToanHoaDonNhap()
        {
            InitializeComponent();
        }

        private void GUI_ThanhToanHoaDonNhap_Load(object sender, EventArgs e)
        {

            dgv_dsspban.DataSource = buscthdn.getCHITIETHDN(mahdn);
            dgv_thanhtoan.DataSource = buscthdn.getTHANHTOAN(mahdn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công,Mời bạn mua tiếp sản phẩm");
            GUI_QuanLySanPhamNhap quanLySanPhamNhap = new GUI_QuanLySanPhamNhap();
            quanLySanPhamNhap.Show();
            Visible = false;
        }

        private void txtTT_Click(object sender, EventArgs e)
        {
            string mahdbn = dgv_thanhtoan.CurrentRow.Cells[0].Value.ToString();
            DateTime ngay = DateTime.Parse(dgv_thanhtoan.CurrentRow.Cells[1].Value.ToString());
            string tennhapp = dgv_thanhtoan.CurrentRow.Cells[2].Value.ToString();
            string tennv = dgv_thanhtoan.CurrentRow.Cells[3].Value.ToString();
            int sl = int.Parse(dgv_thanhtoan.CurrentRow.Cells[4].Value.ToString());
            float tt = float.Parse(dgv_thanhtoan.CurrentRow.Cells[5].Value.ToString());

            DTO_ThanhToanHDN nv = new DTO_ThanhToanHDN(mahdbn, ngay, tennhapp, tennv, sl, tt);
            if (bustt.themTHANHTOAN(nv) == true)
            {
                MessageBox.Show("Lưu hóa đơn thành công");


            }
        }
    }
}
