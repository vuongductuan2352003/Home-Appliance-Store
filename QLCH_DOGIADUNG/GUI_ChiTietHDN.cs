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
    public partial class GUI_ChiTietHDN : Form
    {
        BUS_ChiTietHoaDonNhap buscthdn = new BUS_ChiTietHoaDonNhap();

        public GUI_ChiTietHDN()
        {
            InitializeComponent();
        }

        private void GUI_ChiTietHDN_Load(object sender, EventArgs e)
        {
            dgv_dsCTHDB.DataSource = buscthdn.getCHITIETHDNN();

            dgv_dsCTHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dsCTHDB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {

                string ma = txtTimKiem.Text;
                if (buscthdn.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgv_dsCTHDB.DataSource = buscthdn.timkiemCTHDN(ma);

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
           this.Close();

        }
    }
}
