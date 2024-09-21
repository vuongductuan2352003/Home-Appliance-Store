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
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = busnv.getNHANVIEN();
            cbMNV.DataSource = busnv.getNHANVIEN();
            cbMNV.DisplayMember = "MANV";

        }
        void loadnew()
        {
            cbMNV.Text = "";
            txtMK.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            dtpBir.Text = "";
            txtDC.Text = "";
            txtTimKiem.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbMNV.Enabled = true;
            dgvDSNV.DataSource = busnv.getNHANVIEN();


        }
     

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = cbMNV.Text;
            string mk = txtMK.Text;
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            DateTime ns = DateTime.Parse(dtpBir.Value.ToShortDateString());
            string dc = txtDC.Text;
            if (cbMNV.Text == "" || txtMK.Text == "" || txtTen.Text == "" || txtSDT.Text == "" || dtpBir.Text == "" || txtDC.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
 DTO_NhanVien nv = new DTO_NhanVien(ma, mk, ten, sdt, ns, dc);
            if (busnv.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Ma Trung");
            }
            else
            {
                if (busnv.themNV(nv) == true)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvDSNV.DataSource = busnv.getNHANVIEN();
                }
            }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = cbMNV.Text;
            string mk = txtMK.Text;
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            DateTime ns = DateTime.Parse(dtpBir.Value.ToShortDateString());
            string dc = txtDC.Text;
            if (cbMNV.Text == "" || txtMK.Text == "" || txtTen.Text == "" || txtSDT.Text == "" || dtpBir.Text == "" || txtDC.Text == "" )
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else { DTO_NhanVien nv = new DTO_NhanVien(ma, mk, ten, sdt, ns, dc);

            if (busnv.suaNV(nv) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvDSNV.DataSource = busnv.getNHANVIEN();
            }}
            
            cbMNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = cbMNV.Text;
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                if (busnv.xoaNV(ma) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgvDSNV.DataSource = busnv.getNHANVIEN();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MDI_ChuCuaHang chuCuaHang = new MDI_ChuCuaHang();
            chuCuaHang.Show();
            Visible=false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            

          

            if (txtTimKiem.Text != "")
            {

                string ma = txtTimKiem.Text;
                if (busnv.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Tìm Thành Công");
                    dgvDSNV.DataSource = busnv.timkiemNV(ma);

                }
                else
                {
                    MessageBox.Show("Không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã Nhân Viên cần tìm kiếm", "Thông báo");
            }

        }

        private void btnTLDL_Click(object sender, EventArgs e)
        {
            loadnew();
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbMNV.Text = dgvDSNV[0, hang].Value.ToString();
            txtMK.Text = dgvDSNV[1, hang].Value.ToString();
            txtTen.Text = dgvDSNV[2, hang].Value.ToString();
            txtSDT.Text = dgvDSNV[3, hang].Value.ToString();
            dtpBir.Text = dgvDSNV[4, hang].Value.ToString();
            txtDC.Text = dgvDSNV[5, hang].Value.ToString();

        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F2");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã nhân viên";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mật khẩu";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Tên Nhân Viên";
            cl3.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Số điện thoại";

            cl4.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Ngày sinh";

            cl5.ColumnWidth = 25;


            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Địa chỉ";

            cl6.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 7;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    if (dataTable.Columns[col].DataType == typeof(DateTime))
                    {
                        DateTime dateValue = (DateTime)dataRow[col];
                        arr[row, col] = dateValue.ToShortDateString();

                    }

                    else
                    {
                        arr[row, col] = dataRow[col];
                    }
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

           
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportFile(busnv.getNHANVIEN(), "Thông tin nhân viên ", "Danh Sách Thông Tin Nhân Viên");
        }
    }
}
