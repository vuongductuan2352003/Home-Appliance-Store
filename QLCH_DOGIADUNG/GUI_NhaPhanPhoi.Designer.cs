namespace QLCH_DOGIADUNG
{
    partial class GUI_NhaPhanPhoi
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
            this.cbMNPP = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNPP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMLSP = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.btnTLDL = new System.Windows.Forms.Button();
            this.dgv_dsnpp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnpp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMNPP
            // 
            this.cbMNPP.FormattingEnabled = true;
            this.cbMNPP.Location = new System.Drawing.Point(185, 321);
            this.cbMNPP.Name = "cbMNPP";
            this.cbMNPP.Size = new System.Drawing.Size(117, 21);
            this.cbMNPP.TabIndex = 210;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 209;
            this.label13.Text = "Mã nhà phân phối";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTimKiem.Location = new System.Drawing.Point(532, 76);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 208;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Location = new System.Drawing.Point(532, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 207;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXoa.Location = new System.Drawing.Point(395, 459);
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
            this.btnSua.Location = new System.Drawing.Point(227, 459);
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
            this.btnThem.Location = new System.Drawing.Point(58, 459);
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
            this.label15.Location = new System.Drawing.Point(361, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 203;
            this.label15.Text = "Mã loại sản phẩm";
            // 
            // txtNPP
            // 
            this.txtNPP.Location = new System.Drawing.Point(185, 366);
            this.txtNPP.Name = "txtNPP";
            this.txtNPP.Size = new System.Drawing.Size(117, 20);
            this.txtNPP.TabIndex = 202;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(179, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(305, 31);
            this.label16.TabIndex = 201;
            this.label16.Text = "Quản lý nhà phân phối";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(54, 79);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(472, 20);
            this.txtTimKiem.TabIndex = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 198;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 211;
            this.label2.Text = "Tên nhà phân phối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 212;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 213;
            this.label4.Text = "Địa chỉ";
            // 
            // cbMLSP
            // 
            this.cbMLSP.FormattingEnabled = true;
            this.cbMLSP.Location = new System.Drawing.Point(457, 321);
            this.cbMLSP.Name = "cbMLSP";
            this.cbMLSP.Size = new System.Drawing.Size(150, 21);
            this.cbMLSP.TabIndex = 214;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(457, 366);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 20);
            this.txtSDT.TabIndex = 215;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(185, 409);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(117, 20);
            this.txtDC.TabIndex = 216;
            // 
            // btnTLDL
            // 
            this.btnTLDL.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTLDL.Location = new System.Drawing.Point(54, 292);
            this.btnTLDL.Name = "btnTLDL";
            this.btnTLDL.Size = new System.Drawing.Size(553, 23);
            this.btnTLDL.TabIndex = 217;
            this.btnTLDL.Text = "Làm mới dữ liệu";
            this.btnTLDL.UseVisualStyleBackColor = false;
            this.btnTLDL.Click += new System.EventHandler(this.btnTLDL_Click);
            // 
            // dgv_dsnpp
            // 
            this.dgv_dsnpp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dsnpp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnpp.Location = new System.Drawing.Point(54, 119);
            this.dgv_dsnpp.Name = "dgv_dsnpp";
            this.dgv_dsnpp.RowHeadersWidth = 51;
            this.dgv_dsnpp.Size = new System.Drawing.Size(553, 167);
            this.dgv_dsnpp.TabIndex = 197;
            this.dgv_dsnpp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnpp_CellClick);
            this.dgv_dsnpp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnpp_CellContentClick);
            // 
            // GUI_NhaPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 534);
            this.Controls.Add(this.btnTLDL);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cbMLSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMNPP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNPP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dsnpp);
            this.Name = "GUI_NhaPhanPhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_NhaPhanPhoi";
            this.Load += new System.EventHandler(this.GUI_NhaPhanPhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnpp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMNPP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNPP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMLSP;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Button btnTLDL;
        private System.Windows.Forms.DataGridView dgv_dsnpp;
    }
}