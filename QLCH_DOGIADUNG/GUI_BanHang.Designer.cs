namespace QLCH_DOGIADUNG
{
    partial class GUI_BanHang
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnTVHD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTHDB = new System.Windows.Forms.Button();
            this.lb_makh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mahdb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dskh = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Chitiethdb = new System.Windows.Forms.DataGridView();
            this.dgv_dssp = new System.Windows.Forms.DataGridView();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chitiethdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssp)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(8, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 22);
            this.button4.TabIndex = 52;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTVHD
            // 
            this.btnTVHD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTVHD.Location = new System.Drawing.Point(515, 527);
            this.btnTVHD.Name = "btnTVHD";
            this.btnTVHD.Size = new System.Drawing.Size(117, 25);
            this.btnTVHD.TabIndex = 51;
            this.btnTVHD.Text = "Thêm vào hóa đơn";
            this.btnTVHD.UseVisualStyleBackColor = false;
            this.btnTVHD.Click += new System.EventHandler(this.btnTVHD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(1107, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Tiến hành thanh toán";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTHDB
            // 
            this.btnTHDB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTHDB.Location = new System.Drawing.Point(600, 109);
            this.btnTHDB.Name = "btnTHDB";
            this.btnTHDB.Size = new System.Drawing.Size(117, 25);
            this.btnTHDB.TabIndex = 49;
            this.btnTHDB.Text = "Thêm hóa đơn bán";
            this.btnTHDB.UseVisualStyleBackColor = false;
            this.btnTHDB.Click += new System.EventHandler(this.btnTHDB_Click);
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Location = new System.Drawing.Point(497, 117);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(82, 13);
            this.lb_makh.TabIndex = 48;
            this.lb_makh.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã khách hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Mã hóa đơn bán";
            // 
            // tb_mahdb
            // 
            this.tb_mahdb.Location = new System.Drawing.Point(109, 114);
            this.tb_mahdb.Name = "tb_mahdb";
            this.tb_mahdb.Size = new System.Drawing.Size(131, 20);
            this.tb_mahdb.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // dgv_dskh
            // 
            this.dgv_dskh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dskh.Location = new System.Drawing.Point(8, 172);
            this.dgv_dskh.Name = "dgv_dskh";
            this.dgv_dskh.RowHeadersWidth = 51;
            this.dgv_dskh.Size = new System.Drawing.Size(341, 339);
            this.dgv_dskh.TabIndex = 43;
            this.dgv_dskh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dskh_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Thông tin hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Danh sách sản phẩm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgv_Chitiethdb
            // 
            this.dgv_Chitiethdb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Chitiethdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chitiethdb.Location = new System.Drawing.Point(950, 172);
            this.dgv_Chitiethdb.Name = "dgv_Chitiethdb";
            this.dgv_Chitiethdb.RowHeadersWidth = 51;
            this.dgv_Chitiethdb.Size = new System.Drawing.Size(339, 339);
            this.dgv_Chitiethdb.TabIndex = 40;
            // 
            // dgv_dssp
            // 
            this.dgv_dssp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dssp.Location = new System.Drawing.Point(355, 172);
            this.dgv_dssp.Name = "dgv_dssp";
            this.dgv_dssp.RowHeadersWidth = 51;
            this.dgv_dssp.Size = new System.Drawing.Size(589, 339);
            this.dgv_dssp.TabIndex = 39;
            this.dgv_dssp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dssp_CellClick);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(719, 530);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(131, 20);
            this.txtSL.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 37);
            this.label7.TabIndex = 55;
            this.label7.Text = "BÁN HÀNG";
            // 
            // GUI_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 575);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTVHD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTHDB);
            this.Controls.Add(this.lb_makh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mahdb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dskh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Chitiethdb);
            this.Controls.Add(this.dgv_dssp);
            this.Name = "GUI_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_BanHang";
            this.Load += new System.EventHandler(this.GUI_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chitiethdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTVHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTHDB;
        private System.Windows.Forms.Label lb_makh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mahdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dskh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Chitiethdb;
        private System.Windows.Forms.DataGridView dgv_dssp;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}