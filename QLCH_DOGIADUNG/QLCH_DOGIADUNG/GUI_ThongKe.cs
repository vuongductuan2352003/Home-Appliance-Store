using BUS;
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
    public partial class GUI_ThongKe : Form
    { 
        BUS_ThanhToan bustt =new BUS_ThanhToan();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void dgv_dshd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            dgv_dshd.DataSource = bustt.getTHANHTOAN();
            dgv_tongdoanthu.DataSource = bustt.getDOANHTHU();
            dgv_tongdoanthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tongdoanthu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_dshd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dshd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_tongdoanthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = GUI_DangNhap.manv;
            if(ma=="tuan"){
 MDI_ChuCuaHang chuCuaHang = new MDI_ChuCuaHang();
            chuCuaHang.Show();
            Visible = false;
            }
            else
            {
  MDI_NhanVien chuCuaHang = new MDI_NhanVien();
            chuCuaHang.Show();
            Visible = false; 
            }
                  
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ns = DateTime.Parse(dtpBN.Value.ToShortDateString());
            DateTime nss = DateTime.Parse(btnNow.Value.ToShortDateString());
            dgv_tongdoanthu.DataSource = bustt.thongkeDTTN(ns,nss);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
