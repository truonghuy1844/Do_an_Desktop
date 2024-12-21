namespace PC_GUI
{
    partial class PCCV
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaopc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPhancong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKLCV = new System.Windows.Forms.TextBox();
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.dateTimengaygiao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimengayht = new System.Windows.Forms.DateTimePicker();
            this.rBchuabd = new System.Windows.Forms.RadioButton();
            this.rBdangth = new System.Windows.Forms.RadioButton();
            this.btnPhancong = new System.Windows.Forms.Button();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.rBdaht = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(323, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(71, 26);
            this.btnTim.TabIndex = 141;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(167, 12);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(136, 20);
            this.txtTim.TabIndex = 140;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã phân công hoặc tên nhân viên");
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(109, 52);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(115, 21);
            this.cbTenNV.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 137;
            this.label3.Text = "Tên nhân viên(*) ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(551, 134);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(106, 28);
            this.btnCapNhat.TabIndex = 135;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(682, 134);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 28);
            this.btnXoa.TabIndex = 134;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaopc
            // 
            this.btnTaopc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaopc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaopc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaopc.ForeColor = System.Drawing.Color.White;
            this.btnTaopc.Location = new System.Drawing.Point(551, 90);
            this.btnTaopc.Name = "btnTaopc";
            this.btnTaopc.Size = new System.Drawing.Size(106, 28);
            this.btnTaopc.TabIndex = 133;
            this.btnTaopc.Text = "Tạo mới";
            this.btnTaopc.UseVisualStyleBackColor = false;
            this.btnTaopc.Click += new System.EventHandler(this.btnTaopc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 130;
            this.label2.Text = "Thời hạn(*)";
            // 
            // dataGridViewPhancong
            // 
            this.dataGridViewPhancong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhancong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPhancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhancong.Location = new System.Drawing.Point(0, 350);
            this.dataGridViewPhancong.Name = "dataGridViewPhancong";
            this.dataGridViewPhancong.RowHeadersWidth = 82;
            this.dataGridViewPhancong.Size = new System.Drawing.Size(827, 282);
            this.dataGridViewPhancong.TabIndex = 128;
            this.dataGridViewPhancong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhancong_CellClick);
            this.dataGridViewPhancong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhancong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 127;
            this.label1.Text = "Trạng thái(*)";
            // 
            // lbCv
            // 
            this.lbCv.AutoSize = true;
            this.lbCv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCv.Location = new System.Drawing.Point(27, 96);
            this.lbCv.Name = "lbCv";
            this.lbCv.Size = new System.Drawing.Size(76, 15);
            this.lbCv.TabIndex = 125;
            this.lbCv.Text = "Công việc (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 124;
            this.label6.Text = "Mã phân công(*)";
            // 
            // txtKLCV
            // 
            this.txtKLCV.Location = new System.Drawing.Point(109, 96);
            this.txtKLCV.Name = "txtKLCV";
            this.txtKLCV.Size = new System.Drawing.Size(389, 20);
            this.txtKLCV.TabIndex = 122;
            this.txtKLCV.TextChanged += new System.EventHandler(this.txtDongia_TextChanged);
            // 
            // txtMaPC
            // 
            this.txtMaPC.Location = new System.Drawing.Point(109, 11);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(115, 20);
            this.txtMaPC.TabIndex = 143;
            this.toolTip1.SetToolTip(this.txtMaPC, "Bắt đầu bằng \"PC\"");
            this.txtMaPC.TextChanged += new System.EventHandler(this.txtMaPC_TextChanged);
            this.txtMaPC.Leave += new System.EventHandler(this.txtMaPC_Leave);
            // 
            // dateTimengaygiao
            // 
            this.dateTimengaygiao.Location = new System.Drawing.Point(316, 11);
            this.dateTimengaygiao.Name = "dateTimengaygiao";
            this.dateTimengaygiao.Size = new System.Drawing.Size(181, 20);
            this.dateTimengaygiao.TabIndex = 144;
            this.dateTimengaygiao.ValueChanged += new System.EventHandler(this.dateTimengaygiao_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 145;
            this.label4.Text = "Ngày giao(*)";
            // 
            // dateTimengayht
            // 
            this.dateTimengayht.Location = new System.Drawing.Point(595, 11);
            this.dateTimengayht.Name = "dateTimengayht";
            this.dateTimengayht.Size = new System.Drawing.Size(181, 20);
            this.dateTimengayht.TabIndex = 146;
            this.dateTimengayht.ValueChanged += new System.EventHandler(this.dateTimengayht_ValueChanged);
            // 
            // rBchuabd
            // 
            this.rBchuabd.AutoSize = true;
            this.rBchuabd.Checked = true;
            this.rBchuabd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBchuabd.Location = new System.Drawing.Point(6, 17);
            this.rBchuabd.Name = "rBchuabd";
            this.rBchuabd.Size = new System.Drawing.Size(98, 19);
            this.rBchuabd.TabIndex = 147;
            this.rBchuabd.TabStop = true;
            this.rBchuabd.Text = "Chưa bắt đầu";
            this.rBchuabd.UseVisualStyleBackColor = true;
            this.rBchuabd.CheckedChanged += new System.EventHandler(this.rBchuabd_CheckedChanged);
            // 
            // rBdangth
            // 
            this.rBdangth.AutoSize = true;
            this.rBdangth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBdangth.Location = new System.Drawing.Point(117, 17);
            this.rBdangth.Name = "rBdangth";
            this.rBdangth.Size = new System.Drawing.Size(108, 19);
            this.rBdangth.TabIndex = 148;
            this.rBdangth.Text = "Đang thực hiện";
            this.rBdangth.UseVisualStyleBackColor = true;
            // 
            // btnPhancong
            // 
            this.btnPhancong.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhancong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhancong.ForeColor = System.Drawing.Color.White;
            this.btnPhancong.Location = new System.Drawing.Point(682, 90);
            this.btnPhancong.Name = "btnPhancong";
            this.btnPhancong.Size = new System.Drawing.Size(106, 28);
            this.btnPhancong.TabIndex = 149;
            this.btnPhancong.Text = "Phân công";
            this.btnPhancong.UseVisualStyleBackColor = false;
            this.btnPhancong.Click += new System.EventHandler(this.btnPhancong_Click);
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Location = new System.Drawing.Point(10, 12);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(165, 21);
            this.cbTrangthai.TabIndex = 150;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(223, 6);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(81, 29);
            this.btnLoc.TabIndex = 152;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnchitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchitiet.ForeColor = System.Drawing.Color.White;
            this.btnchitiet.Location = new System.Drawing.Point(685, 319);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(142, 25);
            this.btnchitiet.TabIndex = 153;
            this.btnchitiet.Text = "Chi tiết phân công";
            this.btnchitiet.UseVisualStyleBackColor = false;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // rBdaht
            // 
            this.rBdaht.AutoSize = true;
            this.rBdaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBdaht.Location = new System.Drawing.Point(235, 17);
            this.rBdaht.Name = "rBdaht";
            this.rBdaht.Size = new System.Drawing.Size(92, 19);
            this.rBdaht.TabIndex = 154;
            this.rBdaht.Text = "Hoàn thành ";
            this.rBdaht.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBchuabd);
            this.groupBox1.Controls.Add(this.rBdaht);
            this.groupBox1.Controls.Add(this.rBdangth);
            this.groupBox1.Location = new System.Drawing.Point(316, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 43);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnPhancong);
            this.panel1.Controls.Add(this.dateTimengayht);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTaopc);
            this.panel1.Controls.Add(this.dateTimengaygiao);
            this.panel1.Controls.Add(this.txtMaPC);
            this.panel1.Controls.Add(this.cbTenNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbCv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtKLCV);
            this.panel1.Location = new System.Drawing.Point(4, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 168);
            this.panel1.TabIndex = 156;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtTim);
            this.panel2.Location = new System.Drawing.Point(42, 258);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 41);
            this.panel2.TabIndex = 157;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 52);
            this.panel3.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(273, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(435, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "PHÂN CÔNG CÔNG VIỆC";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbTrangthai);
            this.panel4.Controls.Add(this.btnLoc);
            this.panel4.Location = new System.Drawing.Point(488, 258);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 41);
            this.panel4.TabIndex = 176;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 142;
            this.label7.Text = "Nhập tên NV / mã phân công";
            // 
            // PCCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dataGridViewPhancong);
            this.Controls.Add(this.panel2);
            this.Name = "PCCV";
            this.Size = new System.Drawing.Size(830, 632);
            this.Load += new System.EventHandler(this.PCCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaopc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPhancong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKLCV;
        private System.Windows.Forms.TextBox txtMaPC;
        private System.Windows.Forms.DateTimePicker dateTimengaygiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimengayht;
        private System.Windows.Forms.RadioButton rBchuabd;
        private System.Windows.Forms.RadioButton rBdangth;
        private System.Windows.Forms.Button btnPhancong;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.RadioButton rBdaht;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
    }
}