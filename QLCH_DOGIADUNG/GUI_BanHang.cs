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
using DTO;

namespace QLCH_DOGIADUNG
{
    public partial class GUI_BanHang : Form
    {
        BUS_QuanLySanPham busqlsp = new BUS_QuanLySanPham();
        BUS_KhachHang busqlkh = new BUS_KhachHang();
        BUS_HoaDonBan bushdb =new BUS_HoaDonBan();
        BUS_ChiTietHoaDonBan buscthdb = new BUS_ChiTietHoaDonBan();



        public GUI_BanHang()
        {
            InitializeComponent();
        }

        private void GUI_BanHang_Load(object sender, EventArgs e)
        {
            
            dgv_dssp.DataSource = busqlsp.getSANPHAMM();
            dgv_dskh.DataSource = busqlkh.getKHACHHANG();
            dgv_dskh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dskh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv_dssp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dssp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Chitiethdb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Chitiethdb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
       
       
        

    
        string makh;

        private void dgv_dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            foreach (DataGridViewRow row in dgv_dskh.SelectedRows)
            {
                makh = row.Cells[0].Value.ToString();
                lb_makh.Text = makh;
            }
        }
        string masp;
        float giaban;
        private void dgv_dssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_dssp.SelectedRows)
            {
               
                masp = row.Cells[0].Value.ToString();
                if (float.TryParse(row.Cells[4].Value.ToString(), out float tempGiaban))
                {
                    giaban = tempGiaban;
                }

            }
        }
        string manv = GUI_DangNhap.manv;
        public static string mahdb;
        private void btnTHDB_Click(object sender, EventArgs e)
        {
          
            string ma = tb_mahdb.Text;
            string makh = lb_makh.Text;



            DateTime ngay = DateTime.Now;

            if (ma == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Hóa Đơn Bán");
            }
          
              else if (makh == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }

            else
            {
                DTO_HoaDonBan nv = new DTO_HoaDonBan(ma,ngay ,manv ,makh );
                if (bushdb.themHDB(nv) == true)
                {
                    MessageBox.Show("Thêm hóa đơn thành công, chọn sản phẩm cần mua");
                 
                }

            }
            mahdb = tb_mahdb.Text;

        }

        private void btnTVHD_Click(object sender, EventArgs e)
        {
            int sol = int.Parse(txtSL.Text);
            string ma = tb_mahdb.Text;
            string makh = lb_makh.Text;

            if (sol == 0)
            {
                MessageBox.Show("Vui lòng nhập Số Lượng sản phẩm lớn hơn 0");
            }
            else if (ma == "")
            {
                MessageBox.Show("Bạn chưa thêm mã hóa đơn và khách hàng vui lòng chọn THÊM HÓA ĐƠN BÁN");
            }

            else
            {
 DTO_ChiTietHoaBan nv = new DTO_ChiTietHoaBan(ma, masp,sol , giaban);
                if (buscthdb.themCTHDB(nv) == true)
                {
                    MessageBox.Show("Thêm hóa đơn thành công, chọn sản phẩm cần mua");
                dgv_Chitiethdb.DataSource = buscthdb.getCHITIETHDB(ma);
           
            }
            }
           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = tb_mahdb.Text;
            if (ma == "")
            {
                MessageBox.Show("Bạn chưa có sản phẩm cần thanh toán VUI LÒNG CHỌN THÊM HÓA ĐƠN BÁN");
            }
            else
            {
  GUI_ThanhToan thanhToan = new GUI_ThanhToan();
            thanhToan.Show();
            Visible = false;
            }
          
        }
         BUS_ThanhToan bustt = new BUS_ThanhToan();

        private void button4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
