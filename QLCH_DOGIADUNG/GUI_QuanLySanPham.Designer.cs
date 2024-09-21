namespace QLCH_DOGIADUNG
{
    partial class GUI_QuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGB = new System.Windows.Forms.TextBox();
            this.txtGN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMTH = new System.Windows.Forms.ComboBox();
            this.cbMLSP = new System.Windows.Forms.ComboBox();
            this.btnTLDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(113, 468);
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(227, 20);
            this.txtGB.TabIndex = 73;
            // 
            // txtGN
            // 
            this.txtGN.Location = new System.Drawing.Point(580, 431);
            this.txtGN.Name = "txtGN";
            this.txtGN.Size = new System.Drawing.Size(208, 20);
            this.txtGN.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Giá nhập";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(113, 428);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(227, 20);
            this.txtSL.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Mã Thương Hiệu";
            // 
            // cbMSP
            // 
            this.cbMSP.FormattingEnabled = true;
            this.cbMSP.Location = new System.Drawing.Point(113, 346);
            this.cbMSP.Name = "cbMSP";
            this.cbMSP.Size = new System.Drawing.Size(227, 21);
            this.cbMSP.TabIndex = 65;
            this.cbMSP.SelectedIndexChanged += new System.EventHandler(this.cbMSP_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Mã sản phẩm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTimKiem.Location = new System.Drawing.Point(713, 73);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 63;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 73);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(679, 20);
            this.txtTimKiem.TabIndex = 62;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.Location = new System.Drawing.Point(713, 512);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXoa.Location = new System.Drawing.Point(482, 512);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSua.Location = new System.Drawing.Point(282, 512);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 59;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Location = new System.Drawing.Point(15, 512);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // txtTSP
            // 
            this.txtTSP.Location = new System.Drawing.Point(580, 342);
            this.txtTSP.Name = "txtTSP";
            this.txtTSP.Size = new System.Drawing.Size(208, 20);
            this.txtTSP.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 53;
            this.label1.Text = "Quản lý sán phẩm";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(12, 102);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersWidth = 51;
            this.dgvDSSP.Size = new System.Drawing.Size(779, 193);
            this.dgvDSSP.TabIndex = 52;
            this.dgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Mã Loại Sản Phẩm";
            // 
            // cbMTH
            // 
            this.cbMTH.FormattingEnabled = true;
            this.cbMTH.Location = new System.Drawing.Point(113, 384);
            this.cbMTH.Name = "cbMTH";
            this.cbMTH.Size = new System.Drawing.Size(227, 21);
            this.cbMTH.TabIndex = 76;
            this.cbMTH.SelectedIndexChanged += new System.EventHandler(this.cbMTH_SelectedIndexChanged);
            // 
            // cbMLSP
            // 
            this.cbMLSP.FormattingEnabled = true;
            this.cbMLSP.Location = new System.Drawing.Point(580, 384);
            this.cbMLSP.Name = "cbMLSP";
            this.cbMLSP.Size = new System.Drawing.Size(208, 21);
            this.cbMLSP.TabIndex = 78;
            // 
            // btnTLDL
            // 
            this.btnTLDL.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTLDL.Location = new System.Drawing.Point(12, 301);
            this.btnTLDL.Name = "btnTLDL";
            this.btnTLDL.Size = new System.Drawing.Size(779, 23);
            this.btnTLDL.TabIndex = 219;
            this.btnTLDL.Text = "Làm mới dữ liệu";
            this.btnTLDL.UseVisualStyleBackColor = false;
            this.btnTLDL.Click += new System.EventHandler(this.btnTLDL_Click);
            // 
            // GUI_QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnTLDL);
            this.Controls.Add(this.cbMLSP);
            this.Controls.Add(this.cbMTH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGB);
            this.Controls.Add(this.txtGN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSSP);
            this.Name = "GUI_QuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QuanLySanPham";
            this.Load += new System.EventHandler(this.GUI_QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.TextBox txtGN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMTH;
        private System.Windows.Forms.ComboBox cbMLSP;
        private System.Windows.Forms.Button btnTLDL;
    }
}