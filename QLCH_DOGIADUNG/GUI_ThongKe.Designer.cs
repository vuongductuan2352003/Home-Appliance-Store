namespace QLCH_DOGIADUNG
{
    partial class GUI_ThongKe
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dshd = new System.Windows.Forms.DataGridView();
            this.dgv_tongdoanthu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBN = new System.Windows.Forms.DateTimePicker();
            this.btnNow = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tongdoanthu)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(876, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(371, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // dgv_dshd
            // 
            this.dgv_dshd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dshd.Location = new System.Drawing.Point(12, 86);
            this.dgv_dshd.Name = "dgv_dshd";
            this.dgv_dshd.RowHeadersWidth = 51;
            this.dgv_dshd.Size = new System.Drawing.Size(503, 262);
            this.dgv_dshd.TabIndex = 4;
            this.dgv_dshd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dshd_CellClick);
            // 
            // dgv_tongdoanthu
            // 
            this.dgv_tongdoanthu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tongdoanthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tongdoanthu.Location = new System.Drawing.Point(558, 86);
            this.dgv_tongdoanthu.Name = "dgv_tongdoanthu";
            this.dgv_tongdoanthu.RowHeadersWidth = 51;
            this.dgv_tongdoanthu.Size = new System.Drawing.Size(415, 262);
            this.dgv_tongdoanthu.TabIndex = 7;
            this.dgv_tongdoanthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tongdoanthu_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(160, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "HÓA ĐƠN BÁN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(665, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "TỔNG DOANH THU";
            // 
            // dtpBN
            // 
            this.dtpBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBN.Location = new System.Drawing.Point(397, 363);
            this.dtpBN.Name = "dtpBN";
            this.dtpBN.Size = new System.Drawing.Size(88, 20);
            this.dtpBN.TabIndex = 134;
            this.dtpBN.ValueChanged += new System.EventHandler(this.dtpBN_ValueChanged);
            // 
            // btnNow
            // 
            this.btnNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnNow.Location = new System.Drawing.Point(642, 364);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(91, 20);
            this.btnNow.TabIndex = 135;
            this.btnNow.ValueChanged += new System.EventHandler(this.btnNow_ValueChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(318, 399);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(415, 40);
            this.btnThongKe.TabIndex = 136;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 139;
            this.label15.Text = "Ngày Bắt Đầu";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Ngày kết thúc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GUI_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
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
            this.Name = "GUI_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ThongKe";
            this.Load += new System.EventHandler(this.GUI_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tongdoanthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dshd;
        private System.Windows.Forms.DataGridView dgv_tongdoanthu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBN;
        private System.Windows.Forms.DateTimePicker btnNow;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
    }
}