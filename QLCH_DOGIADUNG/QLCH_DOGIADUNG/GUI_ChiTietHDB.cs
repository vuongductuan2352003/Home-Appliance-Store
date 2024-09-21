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
    public partial class GUI_ChiTietHDB : Form
    {
        BUS_ChiTietHoaDonBan buscthdb=new BUS_ChiTietHoaDonBan();
        public GUI_ChiTietHDB()
        {
            InitializeComponent();
        }

        private void dgv_dsCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_ChiTietHDB_Load(object sender, EventArgs e)
        {
            dgv_dsCTHDB.DataSource = buscthdb.getCHITIETHDBB();

            dgv_dsCTHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dsCTHDB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {

                string ma = txtTimKiem.Text;
                if (buscthdb.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgv_dsCTHDB.DataSource = buscthdb.timkiemCTHDB(ma);

                }
                else
                {
                    MessageBox.Show("Không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã Hóa Đơn Bán cần tìm kiếm", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = GUI_DangNhap.manv;
            if (ma == "tuan")
            {
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
    }
}
