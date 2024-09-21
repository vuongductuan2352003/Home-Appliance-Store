namespace QLCH_DOGIADUNG
{
    partial class GUI_ThongKeHDN
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tongdoanthu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dshd = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.DateTimePicker();
            this.dtpBN = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tongdoanthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshd)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(640, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "TỔNG HÓA ĐƠN NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(162, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "HÓA ĐƠN NHẬP";
            // 
            // dgv_tongdoanthu
            // 
            this.dgv_tongdoanthu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tongdoanthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tongdoanthu.Location = new System.Drawing.Point(560, 92);
            this.dgv_tongdoanthu.Name = "dgv_tongdoanthu";
            this.dgv_tongdoanthu.RowHeadersWidth = 51;
            this.dgv_tongdoanthu.Size = new System.Drawing.Size(415, 262);
            this.dgv_tongdoanthu.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(373, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "THỐNG KÊ HÓA ĐƠN NHẬP";
            // 
            // dgv_dshd
            // 
            this.dgv_dshd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dshd.Location = new System.Drawing.Point(14, 92);
            this.dgv_dshd.Name = "dgv_dshd";
            this.dgv_dshd.RowHeadersWidth = 51;
            this.dgv_dshd.Size = new System.Drawing.Size(503, 262);
            this.dgv_dshd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 145;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 144;
            this.label15.Text = "Ngày Bắt Đầu";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(329, 402);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(415, 40);
            this.btnThongKe.TabIndex = 143;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNow
            // 
            this.btnNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnNow.Location = new System.Drawing.Point(653, 367);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(91, 20);
            this.btnNow.TabIndex = 142;
            // 
            // dtpBN
            // 
            this.dtpBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBN.Location = new System.Drawing.Point(408, 366);
            this.dtpBN.Name = "dtpBN";
            this.dtpBN.Size = new System.Drawing.Size(88, 20);
            this.dtpBN.TabIndex = 141;
            // 
            // GUI_ThongKeHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.dtpBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_tongdoanthu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dshd);
            this.Name = "GUI_ThongKeHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ThongKeHDN";
            this.Load += new System.EventHandler(this.GUI_ThongKeHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tongdoanthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tongdoanthu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dshd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker btnNow;
        private System.Windows.Forms.DateTimePicker dtpBN;
    }
}