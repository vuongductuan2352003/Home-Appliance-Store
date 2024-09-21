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
    public partial class GUI_loaiSanPham : Form
    {
        BUS_LoaiSanPham buslsp = new BUS_LoaiSanPham();

        public GUI_loaiSanPham()
        {
            InitializeComponent();
        }

     

        private void GUI_loaiSanPham_Load(object sender, EventArgs e)
        {
            dgv_dslsp.DataSource = buslsp.getLOAISP();
            cbMLSP.DataSource = buslsp.getLOAISP();
            cbMLSP.DisplayMember = "MALSP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = cbMLSP.Text;

            string ten = txtTLSP.Text;
            if (cbMLSP.Text == "" || txtTLSP.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else
            {
                DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(ma, ten);
                if (buslsp.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Ma Trung");
                }
                else
                {
                    if (buslsp.themLSP(lsp) == true)
                    {
                        MessageBox.Show("Them thanh cong");
                        dgv_dslsp.DataSource = buslsp.getLOAISP();
                    }
                }
            }
        }
        void loadnew()
        {
            txtTimKiem.Text = "";

            cbMLSP.Text = "";
            txtTLSP.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbMLSP.Enabled = true;
            dgv_dslsp.DataSource = buslsp.getLOAISP();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = cbMLSP.Text;

            string ten = txtTLSP.Text;
            if (cbMLSP.Text == "" || txtTLSP.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(ma, ten);
                if (buslsp.suaLSP(lsp) == true)
                {
                    MessageBox.Show("Sua thanh cong");
                    dgv_dslsp.DataSource = buslsp.getLOAISP();
                }

            }
            cbMLSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = cbMLSP.Text;
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                if (buslsp.xoaLSP(ma) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgv_dslsp.DataSource = buslsp.getLOAISP();
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {

                string ma = txtTimKiem.Text;
                if (buslsp.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgv_dslsp.DataSource = buslsp.timkiemLSP(ma);

                }
                else
                {
                    MessageBox.Show("Không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã Loại Sản Phẩm cần tìm kiếm", "Thông báo");
            }
        }

        private void dgv_dslsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbMLSP.Text = dgv_dslsp[0, hang].Value.ToString();
            txtTLSP.Text = dgv_dslsp[1, hang].Value.ToString();
        }

        private void btnTLDL_Click(object sender, EventArgs e)
        {
            loadnew();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
