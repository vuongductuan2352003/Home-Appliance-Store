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
    public partial class GUI_QuanLySanPhamNhap : Form
    {
        BUS_QuanLySanPham SanPham=new BUS_QuanLySanPham();  
        BUS_NhaPhanPhoi nhaPhanPhoi = new BUS_NhaPhanPhoi();
        BUS_HoaDonNhap bushdn = new BUS_HoaDonNhap();
        BUS_ChiTietHoaDonNhap buscthdn = new BUS_ChiTietHoaDonNhap();

        public GUI_QuanLySanPhamNhap()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    

        private void dgv_dssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            masp = dgv_dssp.CurrentRow.Cells[0].Value.ToString();

            gianhap = float.Parse(dgv_dssp.CurrentRow.Cells[5].Value.ToString());
        }
        
        private void GUI_QuanLySanPhamNhap_Load(object sender, EventArgs e)
        {
            dgv_dssp.DataSource = SanPham.getSANPHAM();
            dgv_dssp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dssp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_dsnpp.DataSource = nhaPhanPhoi.getNHAPP();
            dgv_dsnpp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dsnpp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgv_Chitiethoadonnhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Chitiethoadonnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



       
        }
        string nhapp;
        private void dgv_dsnpp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_dsnpp.SelectedRows)
            {
                nhapp = row.Cells[0].Value.ToString();
                lb_manpp.Text = nhapp;
            }
        }
        string masp;
        float gianhap;

        private void dgv_dssp_CellBorderStyleChanged(object sender, EventArgs e)
        {
           
           
        }
        string manv = GUI_DangNhap.manv;
        public static string mahdn;

        private void btnTHDN_Click(object sender, EventArgs e)
        {
            string ma = txtMHDN.Text;
            string manpp = lb_manpp.Text;



            DateTime ngay = DateTime.Now;
            if (ma == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Hóa Đơn Nhập");
            }
            else if (manpp == "")
            {
                MessageBox.Show("Vui lòng chọn Nhà Phân Phối");
            }

            else
            {
                DTO_HoaDonNhap nv = new DTO_HoaDonNhap(ma, manpp, manv, ngay);
                if (bushdn.themHDN(nv) == true)
                {
                    MessageBox.Show("Thêm hóa đơn nhập thành công, chọn sản phẩm cần nhập");

                }

            }
            mahdn = txtMHDN.Text;

        }

        private void btnTVHD_Click(object sender, EventArgs e)
        {
            int sol = int.Parse(txtSL.Text);
            string ma = txtMHDN.Text;
            if (sol == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }
            else
            {
 DTO_ChiTietHoaDonNhap nv = new DTO_ChiTietHoaDonNhap(ma, masp, sol, gianhap);
            if (buscthdn.themCTHDN(nv) == true)
            {
                MessageBox.Show("Thêm hóa đơn thành công, chọn sản phẩm cần mua");
                dgv_Chitiethoadonnhap.DataSource = buscthdn.getCHITIETHDN(ma);

            }
            }
           
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            string ma = txtMHDN.Text;
            if (ma == "")
            {
                MessageBox.Show("Bạn chưa có sản phẩm cần thanh toán VUI LÒNG CHỌN THÊM HÓA ĐƠN BÁN");
            }
            else
            {
                GUI_ThanhToanHoaDonNhap thanhToan = new GUI_ThanhToanHoaDonNhap();
                thanhToan.Show();
                Visible = false;
            }
        }
    }
}
