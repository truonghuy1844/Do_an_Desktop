﻿namespace PC_GUI
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMaDH
            // 
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(169, 50);
            this.cbMaDH.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(274, 24);
            this.cbMaDH.TabIndex = 65;
            this.cbMaDH.SelectedIndexChanged += new System.EventHandler(this.cbMaDH_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(723, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Đánh giá(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Mã đơn hàng(*)";
            // 
            // cbTensp
            // 
            this.cbTensp.FormattingEnabled = true;
            this.cbTensp.Location = new System.Drawing.Point(169, 92);
            this.cbTensp.Margin = new System.Windows.Forms.Padding(4);
            this.cbTensp.Name = "cbTensp";
            this.cbTensp.Size = new System.Drawing.Size(274, 24);
            this.cbTensp.TabIndex = 62;
            this.cbTensp.SelectedIndexChanged += new System.EventHandler(this.cbTensp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tên sản phẩm(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Mã đánh giá SP(*)";
            // 
            // txtDanhgia
            // 
            this.txtDanhgia.Location = new System.Drawing.Point(813, 53);
            this.txtDanhgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDanhgia.Name = "txtDanhgia";
            this.txtDanhgia.Size = new System.Drawing.Size(247, 22);
            this.txtDanhgia.TabIndex = 57;
            // 
            // txtMaDGSP
            // 
            this.txtMaDGSP.Location = new System.Drawing.Point(169, 8);
            this.txtMaDGSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDGSP.Name = "txtMaDGSP";
            this.txtMaDGSP.Size = new System.Drawing.Size(274, 22);
            this.txtMaDGSP.TabIndex = 56;
            this.toolTip1.SetToolTip(this.txtMaDGSP, "Bắt đầu bằng \"DGSP\"");
            this.txtMaDGSP.TextChanged += new System.EventHandler(this.txtMaDGSP_TextChanged);
            this.txtMaDGSP.Leave += new System.EventHandler(this.txtMaDGSP_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Ghi chú ";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(813, 98);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(247, 22);
            this.txtGhichu.TabIndex = 68;
            // 
            // dataGridViewChitiet
            // 
            this.dataGridViewChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChitiet.Location = new System.Drawing.Point(0, 423);
            this.dataGridViewChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewChitiet.Name = "dataGridViewChitiet";
            this.dataGridViewChitiet.RowHeadersWidth = 82;
            this.dataGridViewChitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChitiet.Size = new System.Drawing.Size(1103, 355);
            this.dataGridViewChitiet.TabIndex = 70;
            this.dataGridViewChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChitiet_CellClick);
            // 
            // btnChitietdon
            // 
            this.btnChitietdon.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChitietdon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChitietdon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitietdon.ForeColor = System.Drawing.Color.White;
            this.btnChitietdon.Location = new System.Drawing.Point(-4, 389);
            this.btnChitietdon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChitietdon.Name = "btnChitietdon";
            this.btnChitietdon.Size = new System.Drawing.Size(211, 26);
            this.btnChitietdon.TabIndex = 71;
            this.btnChitietdon.Text = "Chi tiết đơn mua";
            this.btnChitietdon.UseVisualStyleBackColor = false;
            this.btnChitietdon.Click += new System.EventHandler(this.btnChitietdon_Click);
            // 
            // btnLichsu
            // 
            this.btnLichsu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLichsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichsu.ForeColor = System.Drawing.Color.White;
            this.btnLichsu.Location = new System.Drawing.Point(887, 389);
            this.btnLichsu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLichsu.Name = "btnLichsu";
            this.btnLichsu.Size = new System.Drawing.Size(216, 26);
            this.btnLichsu.TabIndex = 74;
            this.btnLichsu.Text = "Lịch sử đánh giá";
            this.btnLichsu.UseVisualStyleBackColor = false;
            this.btnLichsu.Click += new System.EventHandler(this.btnLichsu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Điểm chất lượng";
            // 
            // cbChatluong
            // 
            this.cbChatluong.FormattingEnabled = true;
            this.cbChatluong.Location = new System.Drawing.Point(608, 8);
            this.cbChatluong.Margin = new System.Windows.Forms.Padding(4);
            this.cbChatluong.Name = "cbChatluong";
            this.cbChatluong.Size = new System.Drawing.Size(81, 24);
            this.cbChatluong.TabIndex = 76;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(910, 215);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(139, 28);
            this.btnLuu.TabIndex = 77;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaodg
            // 
            this.btnTaodg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaodg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaodg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaodg.ForeColor = System.Drawing.Color.White;
            this.btnTaodg.Location = new System.Drawing.Point(56, 215);
            this.btnTaodg.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaodg.Name = "btnTaodg";
            this.btnTaodg.Size = new System.Drawing.Size(139, 28);
            this.btnTaodg.TabIndex = 79;
            this.btnTaodg.Text = "Tạo đánh giá mới";
            this.btnTaodg.UseVisualStyleBackColor = false;
            this.btnTaodg.Click += new System.EventHandler(this.btnTaodg_Click);
            // 
            // datetimedanhgia
            // 
            this.datetimedanhgia.Location = new System.Drawing.Point(813, 10);
            this.datetimedanhgia.Margin = new System.Windows.Forms.Padding(4);
            this.datetimedanhgia.Name = "datetimedanhgia";
            this.datetimedanhgia.Size = new System.Drawing.Size(247, 22);
            this.datetimedanhgia.TabIndex = 88;
            this.datetimedanhgia.ValueChanged += new System.EventHandler(this.datetime1_ValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(626, 215);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 28);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(320, 215);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(139, 28);
            this.btnCapNhat.TabIndex = 92;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(12, 22);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(252, 22);
            this.txtTim.TabIndex = 142;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã phân công hoặc tên nhân viên");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "Điểm hiệu quả";
            // 
            // cBHieuqua
            // 
            this.cBHieuqua.FormattingEnabled = true;
            this.cBHieuqua.Location = new System.Drawing.Point(608, 52);
            this.cBHieuqua.Margin = new System.Windows.Forms.Padding(4);
            this.cBHieuqua.Name = "cBHieuqua";
            this.cBHieuqua.Size = new System.Drawing.Size(81, 24);
            this.cBHieuqua.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 95;
            this.label8.Text = "Điểm giá cả";
            // 
            // cbGiaca
            // 
            this.cbGiaca.FormattingEnabled = true;
            this.cbGiaca.Location = new System.Drawing.Point(608, 93);
            this.cbGiaca.Margin = new System.Windows.Forms.Padding(4);
            this.cbGiaca.Name = "cbGiaca";
            this.cbGiaca.Size = new System.Drawing.Size(81, 24);
            this.cbGiaca.TabIndex = 96;
            // 
            // dateTimebatdau
            // 
            this.dateTimebatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimebatdau.Location = new System.Drawing.Point(67, 22);
            this.dateTimebatdau.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimebatdau.Name = "dateTimebatdau";
            this.dateTimebatdau.Size = new System.Drawing.Size(118, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(429, 53);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian đánh giá";
            // 
            // dateTimeketthuc
            // 
            this.dateTimeketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeketthuc.Location = new System.Drawing.Point(283, 22);
            this.dateTimeketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeketthuc.Name = "dateTimeketthuc";
            this.dateTimeketthuc.Size = new System.Drawing.Size(118, 23);
            this.dateTimeketthuc.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 100;
            this.label10.Text = "Đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 18);
            this.label9.TabIndex = 99;
            this.label9.Text = "Từ ";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(306, 17);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(139, 28);
            this.btnTim.TabIndex = 143;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 145;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Location = new System.Drawing.Point(336, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(449, 53);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 64);
            this.panel3.TabIndex = 176;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(358, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(577, 39);
            this.label12.TabIndex = 20;
            this.label12.Text = "ĐÁNH GIÁ ĐƠN HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGiaca);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cBHieuqua);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.cbChatluong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTaodg);
            this.panel1.Controls.Add(this.datetimedanhgia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMaDH);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGhichu);
            this.panel1.Controls.Add(this.cbTensp);
            this.panel1.Controls.Add(this.txtDanhgia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaDGSP);
            this.panel1.Location = new System.Drawing.Point(15, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 265);
            this.panel1.TabIndex = 177;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(723, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 18);
            this.label13.TabIndex = 64;
            this.label13.Text = "Ngày";
            // 
            // Danhgiadonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLichsu);
            this.Controls.Add(this.btnChitietdon);
            this.Controls.Add(this.dataGridViewChitiet);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Danhgiadonhang";
            this.Size = new System.Drawing.Size(1107, 778);
            this.Load += new System.EventHandler(this.Danhgiadonhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
    }
}