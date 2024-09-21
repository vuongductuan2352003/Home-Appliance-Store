using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;

namespace QLCH_DOGIADUNG
{
    public partial class GUI_DangNhap : Form
    {
        BUS_Login busnv = new BUS_Login();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            txt_MatKhau.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Ẩn mật khẩu
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                // Hiện mật khẩu
                txt_MatKhau.PasswordChar = '*';
            }
        }
        public static string manv;
       
        private void button1_Click(object sender, EventArgs e)
        {
            manv = txt_TaiKhoan.Text;
            string acc = txt_TaiKhoan.Text;
            string pw =txt_MatKhau.Text;
          


            if (busnv.checkLogin(acc, pw) == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
             MDI_NhanVien nhanVien = new MDI_NhanVien();
                nhanVien.Show();
                Visible = false;

            }
         

            else if (txt_TaiKhoan.Text.Equals("tuan") && txt_MatKhau.Text.Equals("tuan123"))
            {
                MDI_ChuCuaHang chuCuaHang = new MDI_ChuCuaHang();
                chuCuaHang.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Tai khoan hoac mat khau khong chinh xac");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MDI_TrangChu trangChu =new MDI_TrangChu();
            trangChu.Show();
            Visible = false;
            this.Close();
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
