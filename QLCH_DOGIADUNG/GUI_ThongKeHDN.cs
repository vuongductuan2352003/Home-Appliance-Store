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
    public partial class GUI_ThongKeHDN : Form
    {
        BUS_ThanhToanHDN bustt = new BUS_ThanhToanHDN();
        public GUI_ThongKeHDN()
        {
            InitializeComponent();
        }

        private void GUI_ThongKeHDN_Load(object sender, EventArgs e)
        {
            dgv_dshd.DataSource = bustt.getTHANHTOANHDN();
            dgv_tongdoanthu.DataSource = bustt.getDOANHTHU();
            dgv_tongdoanthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tongdoanthu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_dshd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dshd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ns = DateTime.Parse(dtpBN.Value.ToShortDateString());
            DateTime nss = DateTime.Parse(btnNow.Value.ToShortDateString());
            dgv_tongdoanthu.DataSource = bustt.thongkeDTTNN(ns, nss);
        }
    }
}
