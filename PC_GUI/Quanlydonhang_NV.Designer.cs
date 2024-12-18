namespace PC_GUI
{
    partial class Quanlydonhang_NV
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
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChietkhau = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaDMH = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.btnThongtin = new System.Windows.Forms.Button();
            this.btnTheodoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.txtChoxuly = new System.Windows.Forms.TextBox();
            this.txtDonht = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.cbYcmh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime2
            // 
            this.dateTime2.Location = new System.Drawing.Point(847, 81);
            this.dateTime2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(376, 31);
            this.dateTime2.TabIndex = 91;
            this.dateTime2.ValueChanged += new System.EventHandler(this.dateTime2_ValueChanged);
            // 
            // btnChitiet
            // 
            this.btnChitiet.Location = new System.Drawing.Point(25, 515);
            this.btnChitiet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(209, 47);
            this.btnChitiet.TabIndex = 90;
            this.btnChitiet.Text = "Xem chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = true;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(1252, 1172);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(150, 44);
            this.btnLoc.TabIndex = 89;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(869, 358);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 26);
            this.label11.TabIndex = 88;
            this.label11.Text = "(Nhập mã đơn hàng để tìm kiếm)";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(221, 352);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(128, 44);
            this.btnTim.TabIndex = 87;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(1431, 223);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(194, 33);
            this.cbTrangThai.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1281, 229);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 85;
            this.label10.Text = "Trạng thái(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 84;
            this.label9.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(843, 223);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(378, 31);
            this.txtMoTa.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1275, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 82;
            this.label8.Text = "Chiết khấu(*)";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(845, 150);
            this.cbMaNCC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(376, 33);
            this.cbMaNCC.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1247, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 80;
            this.label7.Text = "Mã nhân viên(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Nhà cung cấp (*)";
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(395, 150);
            this.cbMaHD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(196, 33);
            this.cbMaHD.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mã hợp đồng(*) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Ngày lập (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Mã đơn hàng(*) ";
            // 
            // txtChietkhau
            // 
            this.txtChietkhau.Location = new System.Drawing.Point(1429, 152);
            this.txtChietkhau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtChietkhau.Name = "txtChietkhau";
            this.txtChietkhau.Size = new System.Drawing.Size(196, 31);
            this.txtChietkhau.TabIndex = 74;
            this.toolTip1.SetToolTip(this.txtChietkhau, "Ví dụ: 7.50");
            this.txtChietkhau.Leave += new System.EventHandler(this.txtChietkhau_Leave);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(1429, 77);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(196, 31);
            this.txtMaNV.TabIndex = 73;
            this.toolTip1.SetToolTip(this.txtMaNV, "Bắt đầu bằng \"NV\"");
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            this.txtMaNV.Leave += new System.EventHandler(this.txtMaNV_Leave);
            // 
            // txtMaDMH
            // 
            this.txtMaDMH.Location = new System.Drawing.Point(395, 77);
            this.txtMaDMH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaDMH.Name = "txtMaDMH";
            this.txtMaDMH.Size = new System.Drawing.Size(196, 31);
            this.txtMaDMH.TabIndex = 72;
            this.toolTip1.SetToolTip(this.txtMaDMH, "Bắt đầu bằng \"DMH\"");
            this.txtMaDMH.TextChanged += new System.EventHandler(this.txtMaDMH_TextChanged);
            this.txtMaDMH.Leave += new System.EventHandler(this.txtMaDMH_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 584);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.Size = new System.Drawing.Size(1738, 489);
            this.dataGridView2.TabIndex = 71;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(381, 352);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(446, 31);
            this.txtTimKiem.TabIndex = 70;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Ví dụ: DMH002");
            // 
            // cbLoc
            // 
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Location = new System.Drawing.Point(1200, 1119);
            this.cbLoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(228, 33);
            this.cbLoc.TabIndex = 67;
            // 
            // btnThongtin
            // 
            this.btnThongtin.Location = new System.Drawing.Point(1522, 504);
            this.btnThongtin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThongtin.Name = "btnThongtin";
            this.btnThongtin.Size = new System.Drawing.Size(242, 58);
            this.btnThongtin.TabIndex = 66;
            this.btnThongtin.Text = "Thông tin đơn hàng ";
            this.btnThongtin.UseVisualStyleBackColor = true;
            this.btnThongtin.Click += new System.EventHandler(this.btnThongtin_Click);
            // 
            // btnTheodoi
            // 
            this.btnTheodoi.Location = new System.Drawing.Point(1381, 345);
            this.btnTheodoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTheodoi.Name = "btnTheodoi";
            this.btnTheodoi.Size = new System.Drawing.Size(242, 44);
            this.btnTheodoi.TabIndex = 65;
            this.btnTheodoi.Text = "Theo dõi trạng thái";
            this.btnTheodoi.UseVisualStyleBackColor = true;
            this.btnTheodoi.Click += new System.EventHandler(this.btnTheodoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(203, 298);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 42);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(929, 296);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(232, 44);
            this.btnXoa.TabIndex = 95;
            this.btnXoa.Text = "Xóa đơn hàng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(605, 296);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(232, 44);
            this.btnCapNhat.TabIndex = 94;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(283, 296);
            this.btnTao.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(232, 44);
            this.btnTao.TabIndex = 93;
            this.btnTao.Text = "Tạo đơn hàng ";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // txtChoxuly
            // 
            this.txtChoxuly.Location = new System.Drawing.Point(852, 1172);
            this.txtChoxuly.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtChoxuly.Name = "txtChoxuly";
            this.txtChoxuly.Size = new System.Drawing.Size(26, 31);
            this.txtChoxuly.TabIndex = 102;
            // 
            // txtDonht
            // 
            this.txtDonht.Location = new System.Drawing.Point(448, 1172);
            this.txtDonht.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDonht.Name = "txtDonht";
            this.txtDonht.Size = new System.Drawing.Size(28, 31);
            this.txtDonht.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 1119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 100;
            this.label1.Text = "Đơn hoàn thành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 1119);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 99;
            this.label2.Text = "Đơn chờ xử lý";
            // 
            // cbYcmh
            // 
            this.cbYcmh.FormattingEnabled = true;
            this.cbYcmh.Location = new System.Drawing.Point(395, 223);
            this.cbYcmh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbYcmh.Name = "cbYcmh";
            this.cbYcmh.Size = new System.Drawing.Size(196, 33);
            this.cbYcmh.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 229);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 25);
            this.label12.TabIndex = 103;
            this.label12.Text = "Mã YCMH(*) ";
            // 
            // Quanlydonhang_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbYcmh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtChoxuly);
            this.Controls.Add(this.txtDonht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.btnChitiet);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbMaNCC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChietkhau);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaDMH);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.btnThongtin);
            this.Controls.Add(this.btnTheodoi);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Quanlydonhang_NV";
            this.Size = new System.Drawing.Size(1800, 1330);
            this.Load += new System.EventHandler(this.Quanlydonhang_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Button btnChitiet;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChietkhau;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaDMH;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.Button btnThongtin;
        private System.Windows.Forms.Button btnTheodoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtChoxuly;
        private System.Windows.Forms.TextBox txtDonht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ComboBox cbYcmh;
        private System.Windows.Forms.Label label12;
    }
}