using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_DOGIADUNG
{
    public partial class GUI_ThanhToan : Form
    {
        BUS_ChiTietHoaDonBan buscthdb = new BUS_ChiTietHoaDonBan();
        BUS_ThanhToan bustt = new BUS_ThanhToan();
        BUS_HoaDonBan bushdb =new BUS_HoaDonBan();
        public GUI_ThanhToan()
        {
            InitializeComponent();
        }

        string mahdb = GUI_BanHang.mahdb;
       
        private void GUI_ThanhToan_Load(object sender, EventArgs e)
        {
            dgv_dsspban.DataSource = buscthdb.getCHITIETHDB(mahdb);
            dgv_thanhtoan.DataSource = buscthdb.getTHANHTOAN(mahdb);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công,Mời bạn mua tiếp sản phẩm");
            GUI_BanHang banHang = new GUI_BanHang();
            banHang.Show();
            Visible = false;
        }

       

        private void txtTT_Click(object sender, EventArgs e)
        {
            string mahdbb = dgv_thanhtoan.CurrentRow.Cells[0].Value.ToString();
            DateTime ngay = DateTime.Parse(dgv_thanhtoan.CurrentRow.Cells[1].Value.ToString()); 
            string tenKhachHang = dgv_thanhtoan.CurrentRow.Cells[2].Value.ToString();
            string tennv = dgv_thanhtoan.CurrentRow.Cells[3].Value.ToString();
            int sl = int.Parse(dgv_thanhtoan.CurrentRow.Cells[4].Value.ToString());
            float tt = float.Parse(dgv_thanhtoan.CurrentRow.Cells[5].Value.ToString());
          
            DTO_ThanhToan nv = new DTO_ThanhToan(mahdbb, ngay, tenKhachHang, tennv,sl,tt);
            if (bustt.themTHANHTOAN(nv) == true)
            {
                MessageBox.Show("Lưu hóa đơn thành công");
      

            }
        }

        private void dgv_dsspban_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   
   

        private void dgv_thanhtoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
