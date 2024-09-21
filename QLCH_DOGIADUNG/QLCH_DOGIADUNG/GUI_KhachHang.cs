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
using System.Net.NetworkInformation;

namespace QLCH_DOGIADUNG
{
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

     
        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            dgvdskh.DataSource = buskh.getKHACHHANG();
            cbKH.DataSource = buskh.getKHACHHANG();
            cbKH.DisplayMember = "MAKH";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {

                string ma = txtTimKiem.Text;
                if (buskh.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgvdskh.DataSource = buskh.timkiemKH(ma);

                }
                else
                {
                    MessageBox.Show("Không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã Khách Hàng cần tìm kiếm", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = cbKH.Text;
      
            string ten = txtTEN.Text;
            string sdt = txtSDT.Text;
            string dc = txtDC.Text;
            if (cbKH.Text == "" || txtTEN.Text == "" || txtSDT.Text == "" || txtDC.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
 DTO_KhachHang kh = new DTO_KhachHang(ma, ten, sdt, dc);
            if (buskh.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Ma Trung");
            }
            else
            {
                if (buskh.themKH(kh) == true)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvdskh.DataSource = buskh.getKHACHHANG();
                }
            }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = cbKH.Text;

            string ten = txtTEN.Text;
            string sdt = txtSDT.Text;
            string dc = txtDC.Text;
            if (cbKH.Text == "" || txtTEN.Text == "" || txtSDT.Text == "" || txtDC.Text == "" )
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
 DTO_KhachHang kh = new DTO_KhachHang(ma, ten, sdt, dc);

            if (buskh.suaKH(kh) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvdskh.DataSource = buskh.getKHACHHANG();
            }
            }

           
            cbKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = cbKH.Text;
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                if (buskh.xoaKH(ma) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgvdskh.DataSource = buskh.getKHACHHANG();
                }

            }
        }

        void loadnew()
        {
            cbKH.Text = "";
            txtTEN.Text = "";
            txtTimKiem.Text = "";
            txtSDT.Text = "";
            txtDC.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbKH.Enabled = true;
            dgvdskh.DataSource = buskh.getKHACHHANG();

        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void dgvdskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbKH.Text = dgvdskh[0, hang].Value.ToString();
            txtTEN.Text = dgvdskh[1, hang].Value.ToString();
            txtSDT.Text = dgvdskh[2, hang].Value.ToString();
            txtDC.Text = dgvdskh[3, hang].Value.ToString();
        }

        private void btnTLDL_Click(object sender, EventArgs e)
        {
            loadnew();
        }
    }
}
