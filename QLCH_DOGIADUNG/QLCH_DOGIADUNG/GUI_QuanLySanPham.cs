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
    public partial class GUI_QuanLySanPham : Form
    {
        BUS_QuanLySanPham busqlsp = new BUS_QuanLySanPham();

        public GUI_QuanLySanPham()
        {
            InitializeComponent();
        }

        private void GUI_QuanLySanPham_Load(object sender, EventArgs e)
        {
            
            dgvDSSP.DataSource = busqlsp.getSANPHAM();
            cbMSP.DataSource = busqlsp.getSANPHAM();
            cbMSP.DisplayMember = "MASP";
            cbMTH.DataSource = busqlsp.getSANPHAM();
            cbMTH.DisplayMember = "MATH";
            cbMLSP.DataSource = busqlsp.getSANPHAM();
            cbMLSP.DisplayMember = "MALSP";
            dgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = cbMSP.Text;
            string ten = txtTSP.Text;
            string math = cbMTH.Text;
            string malsp = cbMLSP.Text;
            int sl = int.Parse(txtSL.Text);
            float gianhap = float.Parse(txtGN.Text);
            float giaban= float.Parse(txtGB.Text);
            if (cbMSP.Text == "" || txtTSP.Text == "" || cbMTH.Text == "" || cbMLSP.Text == "" || txtSL.Text == "" || txtGN.Text == "" || txtGB.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
 DTO_QuanLySanPham sp = new DTO_QuanLySanPham(ma, ten, math,malsp,sl,gianhap,giaban);
            if (busqlsp.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Ma Trung");
            }
            else
            {
                if (busqlsp.themSP(sp) == true)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvDSSP.DataSource = busqlsp.getSANPHAM();
                }
            }
            }
           
        }

       
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = cbMSP.Text;
            string ten = txtTSP.Text;
            string math = cbMTH.Text;
            string malsp = cbMLSP.Text;
            int sl = int.Parse(txtSL.Text);
            float gianhap = float.Parse(txtGN.Text);
            float giaban = float.Parse(txtGB.Text);
            if (cbMSP.Text == "" || txtTSP.Text == "" || cbMTH.Text == "" || cbMLSP.Text == "" || txtSL.Text == "" || txtGN.Text == "" || txtGB.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
  DTO_QuanLySanPham sp = new DTO_QuanLySanPham(ma, ten, math, malsp, sl, gianhap, giaban);
            if (busqlsp.suaSP(sp) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvDSSP.DataSource = busqlsp.getSANPHAM();
            }
            }
            cbMSP.Enabled = false;
            cbMTH.Enabled = false;
            cbMLSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = cbMSP.Text;
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                if (busqlsp.xoaSP(ma) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgvDSSP.DataSource = busqlsp.getSANPHAM();
                }

            }
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {


            if (txtTimKiem.Text != "")
            {

                string ma = txtTimKiem.Text;
                if (busqlsp.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgvDSSP.DataSource = busqlsp.timkiemSP(ma);

                }
                else
                {
                    MessageBox.Show("Không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã Sản Phẩm cần tìm kiếm", "Thông báo");
            }
        }


        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbMSP.Text = dgvDSSP[0, hang].Value.ToString();
            txtTSP.Text = dgvDSSP[1, hang].Value.ToString();
            cbMTH.Text = dgvDSSP[2, hang].Value.ToString();
            cbMLSP.Text = dgvDSSP[3, hang].Value.ToString();
            txtSL.Text = dgvDSSP[4, hang].Value.ToString();
            txtGN.Text = dgvDSSP[5, hang].Value.ToString();
            txtGB.Text = dgvDSSP[6, hang].Value.ToString();
        }
        void loadnew()
        {
            cbMSP.Text = "";
            txtTSP.Text = "";
            cbMTH.Text = "";
            cbMLSP.Text = "";
            txtSL.Text = "";
            txtGN.Text = "";
            txtGB.Text = "";
            txtTimKiem.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbMLSP.Enabled = true;

            dgvDSSP.DataSource = busqlsp.getSANPHAM();

        }
        private void btnTLDL_Click(object sender, EventArgs e)
        {
            loadnew();
        }

        private void cbMTH_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void cbMSP_SelectedIndexChanged(object sender, EventArgs e)
        {
        ;
        }
    }
}
