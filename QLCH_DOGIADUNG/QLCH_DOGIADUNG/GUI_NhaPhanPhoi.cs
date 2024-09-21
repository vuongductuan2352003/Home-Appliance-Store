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
    public partial class GUI_NhaPhanPhoi : Form
    {
        BUS_NhaPhanPhoi busnpp = new BUS_NhaPhanPhoi();

        public GUI_NhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void GUI_NhaPhanPhoi_Load(object sender, EventArgs e)
        {
            dgv_dsnpp.DataSource = busnpp.getNHAPP();
            cbMNPP.DataSource = busnpp.getNHAPP();
            cbMNPP.DisplayMember = "MANPP";
            cbMLSP.DataSource = busnpp.getNHAPP();
            cbMLSP.DisplayMember = "MALSP";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = cbMNPP.Text;
            string malsp = cbMLSP.Text;
            string ten = txtNPP.Text;
            string sdt = txtSDT.Text;
            string dc = txtDC.Text;
            if (cbMNPP.Text == "" || cbMLSP.Text == "" || txtNPP.Text == "" || txtSDT.Text == "" || txtDC.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else
            {
                DTO_NhaPhanPhoi npp = new DTO_NhaPhanPhoi(ma, malsp,ten, sdt, dc);
                if (busnpp.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Ma Trung");
                }
                else
                {
                    if (busnpp.themNPP(npp) == true)
                    {
                        MessageBox.Show("Them thanh cong");
                        dgv_dsnpp.DataSource = busnpp.getNHAPP();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = cbMNPP.Text;
            string malsp = cbMLSP.Text;
            string ten = txtNPP.Text;
            string sdt = txtSDT.Text;
            string dc = txtDC.Text;
            if (cbMNPP.Text == "" || cbMLSP.Text == "" || txtNPP.Text == "" || txtSDT.Text == "" || txtDC.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DTO_NhaPhanPhoi npp = new DTO_NhaPhanPhoi(ma, malsp, ten, sdt, dc);
                if (busnpp.suaNPP(npp) == true)
                {
                    MessageBox.Show("Sua thanh cong");
                    dgv_dsnpp.DataSource = busnpp.getNHAPP();
                }

            }
            cbMNPP.Enabled = false;
            cbMLSP.Enabled = false;
        }

        private void dgv_dsnpp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbMNPP.Text = dgv_dsnpp[0, hang].Value.ToString();
            cbMLSP.Text = dgv_dsnpp[1, hang].Value.ToString();
            txtNPP.Text = dgv_dsnpp[2, hang].Value.ToString();
            txtSDT.Text = dgv_dsnpp[3, hang].Value.ToString();
            txtDC.Text = dgv_dsnpp[4, hang].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = cbMNPP.Text;
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                if (busnpp.xoaNPP(ma) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgv_dsnpp.DataSource = busnpp.getNHAPP();
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {

                string ma = txtTimKiem.Text;
                if (busnpp.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgv_dsnpp.DataSource = busnpp.timkiemNPP(ma);

                }
                else
                {
                    MessageBox.Show("Không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã Nhà Phân Phối cần tìm kiếm", "Thông báo");
            }
        }

        private void btnTLDL_Click(object sender, EventArgs e)
        {
            loadnew();
        }
        void loadnew()
        {
            cbMNPP.Text = "";
            cbMLSP.Text = "";
            txtNPP.Text = "";
            txtSDT.Text = "";
            txtDC.Text = "";
            txtTimKiem.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbMLSP.Enabled = true;

            dgv_dsnpp.DataSource = busnpp.getNHAPP();

        }

        private void dgv_dsnpp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbMNPP.Text = dgv_dsnpp[0, hang].Value.ToString();
            cbMLSP.Text = dgv_dsnpp[1, hang].Value.ToString();
            txtNPP.Text = dgv_dsnpp[2, hang].Value.ToString();
            txtSDT.Text = dgv_dsnpp[3, hang].Value.ToString();
            txtDC.Text = dgv_dsnpp[4, hang].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
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
