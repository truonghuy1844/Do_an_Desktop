namespace PC_GUI
{
    partial class Danhgiadonhang_NV
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
            this.components = new System.ComponentModel.Container();
            this.datetime1 = new System.Windows.Forms.DateTimePicker();
            this.btnTaodg = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridViewChitiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.cbMaDH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTensp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDanhgia = new System.Windows.Forms.TextBox();
            this.txtMaDGSP = new System.Windows.Forms.TextBox();
            this.btnLichsu = new System.Windows.Forms.Button();
            this.btnChitietdon = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbGiaca = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBHieuqua = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChatluong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeketthuc = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimebatdau = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datetime1
            // 
            this.datetime1.Location = new System.Drawing.Point(1304, 92);
            this.datetime1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datetime1.Name = "datetime1";
            this.datetime1.Size = new System.Drawing.Size(396, 31);
            this.datetime1.TabIndex = 111;
            // 
            // btnTaodg
            // 
            this.btnTaodg.Location = new System.Drawing.Point(145, 364);
            this.btnTaodg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTaodg.Name = "btnTaodg";
            this.btnTaodg.Size = new System.Drawing.Size(225, 44);
            this.btnTaodg.TabIndex = 106;
            this.btnTaodg.Text = "Tạo đánh giá mới";
            this.btnTaodg.UseVisualStyleBackColor = true;
            this.btnTaodg.Click += new System.EventHandler(this.btnTaodg_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(803, 364);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(162, 44);
            this.btnLuu.TabIndex = 105;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridViewChitiet
            // 
            this.dataGridViewChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChitiet.Location = new System.Drawing.Point(37, 628);
            this.dataGridViewChitiet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewChitiet.Name = "dataGridViewChitiet";
            this.dataGridViewChitiet.RowHeadersWidth = 82;
            this.dataGridViewChitiet.Size = new System.Drawing.Size(1695, 588);
            this.dataGridViewChitiet.TabIndex = 100;
            this.dataGridViewChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChitiet_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1161, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "Ghi chú ";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(1277, 253);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(423, 31);
            this.txtGhichu.TabIndex = 98;
            // 
            // cbMaDH
            // 
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(336, 172);
            this.cbMaDH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(423, 33);
            this.cbMaDH.TabIndex = 97;
            this.cbMaDH.SelectedIndexChanged += new System.EventHandler(this.cbMaDH_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1145, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 96;
            this.label7.Text = "Đánh giá(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Mã đơn mua hàng(*)";
            // 
            // cbTensp
            // 
            this.cbTensp.FormattingEnabled = true;
            this.cbTensp.Location = new System.Drawing.Point(336, 249);
            this.cbTensp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbTensp.Name = "cbTensp";
            this.cbTensp.Size = new System.Drawing.Size(423, 33);
            this.cbTensp.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 93;
            this.label5.Text = "Tên sản phẩm(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "Mã đánh giá SP(*)";
            // 
            // txtDanhgia
            // 
            this.txtDanhgia.Location = new System.Drawing.Point(1277, 163);
            this.txtDanhgia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDanhgia.Name = "txtDanhgia";
            this.txtDanhgia.Size = new System.Drawing.Size(423, 31);
            this.txtDanhgia.TabIndex = 91;
            // 
            // txtMaDGSP
            // 
            this.txtMaDGSP.Location = new System.Drawing.Point(336, 92);
            this.txtMaDGSP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaDGSP.Name = "txtMaDGSP";
            this.txtMaDGSP.Size = new System.Drawing.Size(423, 31);
            this.txtMaDGSP.TabIndex = 90;
            this.toolTip1.SetToolTip(this.txtMaDGSP, "Bắt đầu bằng \"DGSP\"");
            this.txtMaDGSP.TextChanged += new System.EventHandler(this.txtMaDGSP_TextChanged);
            this.txtMaDGSP.Leave += new System.EventHandler(this.txtMaDGSP_Leave);
            // 
            // btnLichsu
            // 
            this.btnLichsu.Location = new System.Drawing.Point(1509, 570);
            this.btnLichsu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLichsu.Name = "btnLichsu";
            this.btnLichsu.Size = new System.Drawing.Size(223, 46);
            this.btnLichsu.TabIndex = 114;
            this.btnLichsu.Text = "Lịch sử đánh giá";
            this.btnLichsu.UseVisualStyleBackColor = true;
            this.btnLichsu.Click += new System.EventHandler(this.btnLichsu_Click);
            // 
            // btnChitietdon
            // 
            this.btnChitietdon.Location = new System.Drawing.Point(37, 559);
            this.btnChitietdon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChitietdon.Name = "btnChitietdon";
            this.btnChitietdon.Size = new System.Drawing.Size(202, 46);
            this.btnChitietdon.TabIndex = 113;
            this.btnChitietdon.Text = "Chi tiết đơn mua";
            this.btnChitietdon.UseVisualStyleBackColor = true;
            this.btnChitietdon.Click += new System.EventHandler(this.btnChitietdon_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(403, 364);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(168, 44);
            this.btnCapNhat.TabIndex = 116;
            this.btnCapNhat.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.btnCapNhat, "Nhân viên không được phép cập nhật");
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(604, 364);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 44);
            this.btnXoa.TabIndex = 115;
            this.btnXoa.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btnXoa, "Nhân viên không được phép xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(18, 40);
            this.txtTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(814, 31);
            this.txtTim.TabIndex = 142;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã phân công hoặc tên nhân viên");
            // 
            // cbGiaca
            // 
            this.cbGiaca.FormattingEnabled = true;
            this.cbGiaca.Location = new System.Drawing.Point(978, 251);
            this.cbGiaca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbGiaca.Name = "cbGiaca";
            this.cbGiaca.Size = new System.Drawing.Size(120, 33);
            this.cbGiaca.TabIndex = 122;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(825, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 121;
            this.label8.Text = "Điểm giá cả";
            // 
            // cBHieuqua
            // 
            this.cBHieuqua.FormattingEnabled = true;
            this.cBHieuqua.Location = new System.Drawing.Point(978, 169);
            this.cBHieuqua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cBHieuqua.Name = "cBHieuqua";
            this.cBHieuqua.Size = new System.Drawing.Size(120, 33);
            this.cBHieuqua.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "Điểm hiệu quả";
            // 
            // cbChatluong
            // 
            this.cbChatluong.FormattingEnabled = true;
            this.cbChatluong.Location = new System.Drawing.Point(978, 92);
            this.cbChatluong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbChatluong.Name = "cbChatluong";
            this.cbChatluong.Size = new System.Drawing.Size(120, 33);
            this.cbChatluong.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 117;
            this.label2.Text = "Điểm chất lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeketthuc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimebatdau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1012, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(506, 159);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian đánh giá";
            // 
            // dateTimeketthuc
            // 
            this.dateTimeketthuc.Location = new System.Drawing.Point(68, 113);
            this.dateTimeketthuc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimeketthuc.Name = "dateTimeketthuc";
            this.dateTimeketthuc.Size = new System.Drawing.Size(396, 32);
            this.dateTimeketthuc.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 26);
            this.label10.TabIndex = 100;
            this.label10.Text = "Đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 26);
            this.label9.TabIndex = 99;
            this.label9.Text = "Từ ";
            // 
            // dateTimebatdau
            // 
            this.dateTimebatdau.Location = new System.Drawing.Point(68, 60);
            this.dateTimebatdau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimebatdau.Name = "dateTimebatdau";
            this.dateTimebatdau.Size = new System.Drawing.Size(396, 32);
            this.dateTimebatdau.TabIndex = 97;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Location = new System.Drawing.Point(145, 427);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(844, 83);
            this.groupBox2.TabIndex = 147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 145;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1543, 449);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(146, 44);
            this.btnTim.TabIndex = 148;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Danhgiadonhang_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1259);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbGiaca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBHieuqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbChatluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLichsu);
            this.Controls.Add(this.btnChitietdon);
            this.Controls.Add(this.datetime1);
            this.Controls.Add(this.btnTaodg);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridViewChitiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.cbMaDH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTensp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDanhgia);
            this.Controls.Add(this.txtMaDGSP);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Danhgiadonhang_NV";
            this.Text = "Danhgiadonhang_NV";
            this.Load += new System.EventHandler(this.Danhgiadonhang_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datetime1;
        private System.Windows.Forms.Button btnTaodg;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridViewChitiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.ComboBox cbMaDH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTensp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDanhgia;
        private System.Windows.Forms.TextBox txtMaDGSP;
        private System.Windows.Forms.Button btnLichsu;
        private System.Windows.Forms.Button btnChitietdon;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbGiaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBHieuqua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbChatluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeketthuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimebatdau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}