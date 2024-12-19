namespace PC_GUI
{
    partial class Danhgiadonhang
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
            this.cbMaDH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTensp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDanhgia = new System.Windows.Forms.TextBox();
            this.txtMaDGSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.dataGridViewChitiet = new System.Windows.Forms.DataGridView();
            this.btnChitietdon = new System.Windows.Forms.Button();
            this.btnLichsu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChatluong = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaodg = new System.Windows.Forms.Button();
            this.datetimedanhgia = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBHieuqua = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGiaca = new System.Windows.Forms.ComboBox();
            this.dateTimebatdau = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeketthuc = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMaDH
            // 
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(155, 109);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(220, 21);
            this.cbMaDH.TabIndex = 65;
            this.cbMaDH.SelectedIndexChanged += new System.EventHandler(this.cbMaDH_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Đánh giá(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Mã đơn hàng(*)";
            // 
            // cbTensp
            // 
            this.cbTensp.FormattingEnabled = true;
            this.cbTensp.Location = new System.Drawing.Point(155, 150);
            this.cbTensp.Name = "cbTensp";
            this.cbTensp.Size = new System.Drawing.Size(220, 21);
            this.cbTensp.TabIndex = 62;
            this.cbTensp.SelectedIndexChanged += new System.EventHandler(this.cbTensp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tên sản phẩm(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Mã đánh giá SP(*)";
            // 
            // txtDanhgia
            // 
            this.txtDanhgia.Location = new System.Drawing.Point(642, 111);
            this.txtDanhgia.Name = "txtDanhgia";
            this.txtDanhgia.Size = new System.Drawing.Size(200, 20);
            this.txtDanhgia.TabIndex = 57;
            // 
            // txtMaDGSP
            // 
            this.txtMaDGSP.Location = new System.Drawing.Point(155, 69);
            this.txtMaDGSP.Name = "txtMaDGSP";
            this.txtMaDGSP.Size = new System.Drawing.Size(222, 20);
            this.txtMaDGSP.TabIndex = 56;
            this.toolTip1.SetToolTip(this.txtMaDGSP, "Bắt đầu bằng \"DGSP\"");
            this.txtMaDGSP.TextChanged += new System.EventHandler(this.txtMaDGSP_TextChanged);
            this.txtMaDGSP.Leave += new System.EventHandler(this.txtMaDGSP_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Ghi chú ";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(642, 152);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(200, 20);
            this.txtGhichu.TabIndex = 68;
            // 
            // dataGridViewChitiet
            // 
            this.dataGridViewChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChitiet.Location = new System.Drawing.Point(24, 320);
            this.dataGridViewChitiet.Name = "dataGridViewChitiet";
            this.dataGridViewChitiet.RowHeadersWidth = 82;
            this.dataGridViewChitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChitiet.Size = new System.Drawing.Size(846, 327);
            this.dataGridViewChitiet.TabIndex = 70;
            this.dataGridViewChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChitiet_CellClick);
            // 
            // btnChitietdon
            // 
            this.btnChitietdon.Location = new System.Drawing.Point(24, 293);
            this.btnChitietdon.Name = "btnChitietdon";
            this.btnChitietdon.Size = new System.Drawing.Size(158, 21);
            this.btnChitietdon.TabIndex = 71;
            this.btnChitietdon.Text = "Chi tiết đơn mua";
            this.btnChitietdon.UseVisualStyleBackColor = true;
            this.btnChitietdon.Click += new System.EventHandler(this.btnChitietdon_Click);
            // 
            // btnLichsu
            // 
            this.btnLichsu.Location = new System.Drawing.Point(708, 293);
            this.btnLichsu.Name = "btnLichsu";
            this.btnLichsu.Size = new System.Drawing.Size(162, 21);
            this.btnLichsu.TabIndex = 74;
            this.btnLichsu.Text = "Lịch sử đánh giá";
            this.btnLichsu.UseVisualStyleBackColor = true;
            this.btnLichsu.Click += new System.EventHandler(this.btnLichsu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Điểm chất lượng";
            // 
            // cbChatluong
            // 
            this.cbChatluong.FormattingEnabled = true;
            this.cbChatluong.Location = new System.Drawing.Point(490, 70);
            this.cbChatluong.Name = "cbChatluong";
            this.cbChatluong.Size = new System.Drawing.Size(62, 21);
            this.cbChatluong.TabIndex = 76;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(352, 194);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(74, 23);
            this.btnLuu.TabIndex = 77;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaodg
            // 
            this.btnTaodg.Location = new System.Drawing.Point(66, 194);
            this.btnTaodg.Name = "btnTaodg";
            this.btnTaodg.Size = new System.Drawing.Size(104, 23);
            this.btnTaodg.TabIndex = 79;
            this.btnTaodg.Text = "Tạo đánh giá mới";
            this.btnTaodg.UseVisualStyleBackColor = true;
            this.btnTaodg.Click += new System.EventHandler(this.btnTaodg_Click);
            // 
            // datetimedanhgia
            // 
            this.datetimedanhgia.Location = new System.Drawing.Point(642, 71);
            this.datetimedanhgia.Name = "datetimedanhgia";
            this.datetimedanhgia.Size = new System.Drawing.Size(200, 20);
            this.datetimedanhgia.TabIndex = 88;
            this.datetimedanhgia.ValueChanged += new System.EventHandler(this.datetime1_ValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(272, 194);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 23);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(178, 194);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 23);
            this.btnCapNhat.TabIndex = 92;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(9, 18);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(336, 20);
            this.txtTim.TabIndex = 142;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã phân công hoặc tên nhân viên");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Điểm hiệu quả";
            // 
            // cBHieuqua
            // 
            this.cBHieuqua.FormattingEnabled = true;
            this.cBHieuqua.Location = new System.Drawing.Point(490, 109);
            this.cBHieuqua.Name = "cBHieuqua";
            this.cBHieuqua.Size = new System.Drawing.Size(62, 21);
            this.cBHieuqua.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Điểm giá cả";
            // 
            // cbGiaca
            // 
            this.cbGiaca.FormattingEnabled = true;
            this.cbGiaca.Location = new System.Drawing.Point(490, 149);
            this.cbGiaca.Name = "cbGiaca";
            this.cbGiaca.Size = new System.Drawing.Size(62, 21);
            this.cbGiaca.TabIndex = 96;
            // 
            // dateTimebatdau
            // 
            this.dateTimebatdau.Location = new System.Drawing.Point(39, 33);
            this.dateTimebatdau.Name = "dateTimebatdau";
            this.dateTimebatdau.Size = new System.Drawing.Size(200, 20);
            this.dateTimebatdau.TabIndex = 97;
            this.dateTimebatdau.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeketthuc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimebatdau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(480, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 87);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian đánh giá";
            // 
            // dateTimeketthuc
            // 
            this.dateTimeketthuc.Location = new System.Drawing.Point(39, 60);
            this.dateTimeketthuc.Name = "dateTimeketthuc";
            this.dateTimeketthuc.Size = new System.Drawing.Size(200, 20);
            this.dateTimeketthuc.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Từ ";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(729, 258);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 23);
            this.btnTim.TabIndex = 143;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 145;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Location = new System.Drawing.Point(90, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 43);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // Danhgiadonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbGiaca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBHieuqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.datetimedanhgia);
            this.Controls.Add(this.btnTaodg);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbChatluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLichsu);
            this.Controls.Add(this.btnChitietdon);
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
            this.Name = "Danhgiadonhang";
            this.Size = new System.Drawing.Size(887, 655);
            this.Load += new System.EventHandler(this.Danhgiadonhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMaDH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTensp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDanhgia;
        private System.Windows.Forms.TextBox txtMaDGSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.DataGridView dataGridViewChitiet;
        private System.Windows.Forms.Button btnChitietdon;
        private System.Windows.Forms.Button btnLichsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChatluong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaodg;
        private System.Windows.Forms.DateTimePicker datetimedanhgia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBHieuqua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGiaca;
        private System.Windows.Forms.DateTimePicker dateTimebatdau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimeketthuc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}