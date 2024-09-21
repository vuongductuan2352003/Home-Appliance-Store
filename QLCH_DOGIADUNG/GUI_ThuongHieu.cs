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
    public partial class GUI_ThuongHieu : Form
    {
        BUS_ThuongHieu busth = new BUS_ThuongHieu();
        public GUI_ThuongHieu()
        {
            InitializeComponent();
        }

        private void GUI_ThuongHieu_Load(object sender, EventArgs e)
        {
            dgv_dsth.DataSource = busth.getTHUONGHIEU();
            cbTH.DataSource = busth.getTHUONGHIEU();
            cbTH.DisplayMember = "MATH";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = cbTH.Text;

            string ten = txtTH.Text;
            if (cbTH.Text == "" || txtTH.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           
            else
            { DTO_ThuongHieu th = new DTO_ThuongHieu(ma, ten);
                if (busth.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Ma Trung");
                }
                else
                {
                    if (busth.themTH(th) == true)
                    {
                        MessageBox.Show("Them thanh cong");
                        dgv_dsth.DataSource = busth.getTHUONGHIEU();
                    }
                }
            }
        }

        private void dgv_dsth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbTH.Text = dgv_dsth[0, hang].Value.ToString();
            txtTH.Text = dgv_dsth[1, hang].Value.ToString();
        }
        void loadnew()
        {
            cbTH.Text = "";
            txtTH.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbTH.Enabled = true;
            txt_timkiem.Text = "";

            dgv_dsth.DataSource = busth.getTHUONGHIEU();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = cbTH.Text;

            string ten = txtTH.Text;
            if (cbTH.Text == "" || txtTH.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DTO_ThuongHieu kh = new DTO_ThuongHieu(ma, ten);
                if (busth.suaTH(kh) == true)
                {
                    MessageBox.Show("Sua thanh cong");
                    dgv_dsth.DataSource = busth.getTHUONGHIEU();
                }

            }
            cbTH.Enabled= false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = cbTH.Text;
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                if (busth.xoaTH(ma) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgv_dsth.DataSource = busth.getTHUONGHIEU();
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {

                string ma = txt_timkiem.Text;
                if (busth.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgv_dsth.DataSource = busth.timkiemTH(ma);

                }
                else
                {
                    MessageBox.Show("Không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã Thương Hiệu cần tìm kiếm", "Thông báo");
            }
        }

        private void cbTH_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgv_dsth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTLDL_Click(object sender, EventArgs e)
        {
            loadnew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
