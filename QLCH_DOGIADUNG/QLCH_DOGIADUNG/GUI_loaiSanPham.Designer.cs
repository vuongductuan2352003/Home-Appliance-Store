namespace QLCH_DOGIADUNG
{
    partial class GUI_loaiSanPham
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
            this.cbMLSP = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTLSP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dslsp = new System.Windows.Forms.DataGridView();
            this.btnTLDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dslsp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMLSP
            // 
            this.cbMLSP.FormattingEnabled = true;
            this.cbMLSP.Location = new System.Drawing.Point(163, 321);
            this.cbMLSP.Name = "cbMLSP";
            this.cbMLSP.Size = new System.Drawing.Size(178, 21);
            this.cbMLSP.TabIndex = 210;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 209;
            this.label13.Text = "Mã loại sản phẩm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTimKiem.Location = new System.Drawing.Point(266, 76);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 208;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.Location = new System.Drawing.Point(275, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 207;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXoa.Location = new System.Drawing.Point(194, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 206;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSua.Location = new System.Drawing.Point(113, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 205;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Location = new System.Drawing.Point(32, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 204;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 363);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 203;
            this.label15.Text = "Tên loại sản phẩm";
            // 
            // txtTLSP
            // 
            this.txtTLSP.Location = new System.Drawing.Point(163, 363);
            this.txtTLSP.Name = "txtTLSP";
            this.txtTLSP.Size = new System.Drawing.Size(178, 20);
            this.txtTLSP.TabIndex = 202;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(302, 31);
            this.label16.TabIndex = 201;
            this.label16.Text = "Quản lý loại sản phẩm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(32, 79);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 20);
            this.txtTimKiem.TabIndex = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 199;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 198;
            // 
            // dgv_dslsp
            // 
            this.dgv_dslsp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dslsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dslsp.Location = new System.Drawing.Point(32, 119);
            this.dgv_dslsp.Name = "dgv_dslsp";
            this.dgv_dslsp.RowHeadersWidth = 51;
            this.dgv_dslsp.Size = new System.Drawing.Size(309, 167);
            this.dgv_dslsp.TabIndex = 197;
            this.dgv_dslsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dslsp_CellClick);
            // 
            // btnTLDL
            // 
            this.btnTLDL.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTLDL.Location = new System.Drawing.Point(32, 292);
            this.btnTLDL.Name = "btnTLDL";
            this.btnTLDL.Size = new System.Drawing.Size(309, 23);
            this.btnTLDL.TabIndex = 211;
            this.btnTLDL.Text = "Tải lại dữ liệu";
            this.btnTLDL.UseVisualStyleBackColor = false;
            this.btnTLDL.Click += new System.EventHandler(this.btnTLDL_Click);
            // 
            // GUI_loaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.btnTLDL);
            this.Controls.Add(this.cbMLSP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTLSP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dslsp);
            this.Name = "GUI_loaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_loaiSanPham";
            this.Load += new System.EventHandler(this.GUI_loaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dslsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMLSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTLSP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dslsp;
        private System.Windows.Forms.Button btnTLDL;
    }
}