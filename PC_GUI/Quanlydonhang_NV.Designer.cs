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
            this.btnDanhgia = new System.Windows.Forms.Button();
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
            this.btnLichSu = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime2
            // 
            this.dateTime2.Location = new System.Drawing.Point(80, 57);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(190, 20);
            this.dateTime2.TabIndex = 91;
            // 
            // btnDanhgia
            // 
            this.btnDanhgia.Location = new System.Drawing.Point(723, 285);
            this.btnDanhgia.Name = "btnDanhgia";
            this.btnDanhgia.Size = new System.Drawing.Size(65, 66);
            this.btnDanhgia.TabIndex = 90;
            this.btnDanhgia.Text = "Chi tiết đơn hàng";
            this.btnDanhgia.UseVisualStyleBackColor = true;
            this.btnDanhgia.Click += new System.EventHandler(this.btnDanhgia_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(690, 157);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
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
            this.label11.Location = new System.Drawing.Point(337, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "(Nhập mã đơn hàng để tìm kiếm)";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(13, 155);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(64, 23);
            this.btnTim.TabIndex = 87;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(501, 88);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(99, 21);
            this.cbTrangThai.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(202, 88);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(218, 20);
            this.txtMoTa.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Chiết khấu";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(389, 56);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(191, 21);
            this.cbMaNCC.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Nhà cung cấp ";
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(389, 17);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(123, 21);
            this.cbMaHD.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mã hợp đồng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Ngày lập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Mã đơn hàng ";
            // 
            // txtChietkhau
            // 
            this.txtChietkhau.Location = new System.Drawing.Point(681, 53);
            this.txtChietkhau.Name = "txtChietkhau";
            this.txtChietkhau.Size = new System.Drawing.Size(100, 20);
            this.txtChietkhau.TabIndex = 74;
            this.toolTip1.SetToolTip(this.txtChietkhau, "Ví dụ: 7.50");
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(681, 14);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 73;
            this.toolTip1.SetToolTip(this.txtMaNV, "Bắt đầu bằng \"NV\"");
            // 
            // txtMaDMH
            // 
            this.txtMaDMH.Location = new System.Drawing.Point(80, 14);
            this.txtMaDMH.Name = "txtMaDMH";
            this.txtMaDMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaDMH.TabIndex = 72;
            this.toolTip1.SetToolTip(this.txtMaDMH, "Bắt đầu bằng \"DMH\"");
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 200);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(704, 237);
            this.dataGridView2.TabIndex = 71;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(93, 155);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 20);
            this.txtTimKiem.TabIndex = 70;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Ví dụ: DMH002");
            // 
            // cbLoc
            // 
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Location = new System.Drawing.Point(541, 157);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(116, 21);
            this.cbLoc.TabIndex = 67;
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(669, 88);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(119, 44);
            this.btnLichSu.TabIndex = 66;
            this.btnLichSu.Text = "Thông tin đơn hàng ";
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnTheodoi
            // 
            this.btnTheodoi.Location = new System.Drawing.Point(541, 128);
            this.btnTheodoi.Name = "btnTheodoi";
            this.btnTheodoi.Size = new System.Drawing.Size(121, 23);
            this.btnTheodoi.TabIndex = 65;
            this.btnTheodoi.Text = "Theo dõi trạng thái";
            this.btnTheodoi.UseVisualStyleBackColor = true;
            this.btnTheodoi.Click += new System.EventHandler(this.btnTheodoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(4, 127);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(34, 22);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(367, 126);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 23);
            this.btnXoa.TabIndex = 95;
            this.btnXoa.Text = "Xóa đơn hàng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(205, 126);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(116, 23);
            this.btnCapNhat.TabIndex = 94;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(44, 126);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(116, 23);
            this.btnTao.TabIndex = 93;
            this.btnTao.Text = "Tạo đơn hàng ";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // txtChoxuly
            // 
            this.txtChoxuly.Location = new System.Drawing.Point(515, 483);
            this.txtChoxuly.Name = "txtChoxuly";
            this.txtChoxuly.Size = new System.Drawing.Size(15, 20);
            this.txtChoxuly.TabIndex = 102;
            // 
            // txtDonht
            // 
            this.txtDonht.Location = new System.Drawing.Point(238, 483);
            this.txtDonht.Name = "txtDonht";
            this.txtDonht.Size = new System.Drawing.Size(16, 20);
            this.txtDonht.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Đơn hoàn thành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Đơn chờ xử lý";
            // 
            // Quanlydonhang_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.txtChoxuly);
            this.Controls.Add(this.txtDonht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.btnDanhgia);
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
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.btnTheodoi);
            this.Name = "Quanlydonhang_NV";
            this.Text = "Quanlydonhang_NV";
            this.Load += new System.EventHandler(this.Quanlydonhang_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Button btnDanhgia;
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
        private System.Windows.Forms.Button btnLichSu;
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
    }
}