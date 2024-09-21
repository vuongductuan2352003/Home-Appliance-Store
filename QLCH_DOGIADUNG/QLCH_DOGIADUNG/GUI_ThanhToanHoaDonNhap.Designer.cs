namespace QLCH_DOGIADUNG
{
    partial class GUI_ThanhToanHoaDonNhap
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
            this.txtTT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_thanhtoan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_dsspban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thanhtoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsspban)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(441, 406);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(106, 39);
            this.txtTT.TabIndex = 25;
            this.txtTT.Text = "Lưu Thanh Toán";
            this.txtTT.UseVisualStyleBackColor = true;
            this.txtTT.Click += new System.EventHandler(this.txtTT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thông tin hóa đơn nhập";
            // 
            // dgv_thanhtoan
            // 
            this.dgv_thanhtoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_thanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thanhtoan.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_thanhtoan.Location = new System.Drawing.Point(106, 266);
            this.dgv_thanhtoan.Name = "dgv_thanhtoan";
            this.dgv_thanhtoan.Size = new System.Drawing.Size(588, 134);
            this.dgv_thanhtoan.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danh sách sản phẩm";
            // 
            // dgv_dsspban
            // 
            this.dgv_dsspban.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dsspban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsspban.Location = new System.Drawing.Point(106, 68);
            this.dgv_dsspban.Name = "dgv_dsspban";
            this.dgv_dsspban.Size = new System.Drawing.Size(588, 170);
            this.dgv_dsspban.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN NHẬP";
            // 
            // GUI_ThanhToanHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_thanhtoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_dsspban);
            this.Controls.Add(this.label1);
            this.Name = "GUI_ThanhToanHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ThanhToanHoaDonNhap";
            this.Load += new System.EventHandler(this.GUI_ThanhToanHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thanhtoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsspban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtTT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_thanhtoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_dsspban;
        private System.Windows.Forms.Label label1;
    }
}