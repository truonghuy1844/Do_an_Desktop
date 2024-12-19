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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(65, 259);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(71, 23);
            this.btnTim.TabIndex = 141;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(150, 262);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(234, 20);
            this.txtTim.TabIndex = 140;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã phân công hoặc tên nhân viên");
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(150, 155);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(115, 21);
            this.cbTenNV.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Tên nhân viên(*) ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(592, 196);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 23);
            this.btnCapNhat.TabIndex = 135;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(723, 196);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 23);
            this.btnXoa.TabIndex = 134;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaopc
            // 
            this.btnTaopc.Location = new System.Drawing.Point(367, 66);
            this.btnTaopc.Name = "btnTaopc";
            this.btnTaopc.Size = new System.Drawing.Size(148, 23);
            this.btnTaopc.TabIndex = 133;
            this.btnTaopc.Text = "Tạo mới";
            this.btnTaopc.UseVisualStyleBackColor = true;
            this.btnTaopc.Click += new System.EventHandler(this.btnTaopc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "Thời hạn(*)";
            // 
            // dataGridViewPhancong
            // 
            this.dataGridViewPhancong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhancong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPhancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhancong.Location = new System.Drawing.Point(12, 365);
            this.dataGridViewPhancong.Name = "dataGridViewPhancong";
            this.dataGridViewPhancong.RowHeadersWidth = 82;
            this.dataGridViewPhancong.Size = new System.Drawing.Size(872, 304);
            this.dataGridViewPhancong.TabIndex = 128;
            this.dataGridViewPhancong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhancong_CellClick);
            this.dataGridViewPhancong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhancong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "Trạng thái(*)";
            // 
            // lbCv
            // 
            this.lbCv.AutoSize = true;
            this.lbCv.Location = new System.Drawing.Point(80, 202);
            this.lbCv.Name = "lbCv";
            this.lbCv.Size = new System.Drawing.Size(68, 13);
            this.lbCv.TabIndex = 125;
            this.lbCv.Text = "Công việc (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "Mã phân công(*)";
            // 
            // txtKLCV
            // 
            this.txtKLCV.Location = new System.Drawing.Point(150, 199);
            this.txtKLCV.Name = "txtKLCV";
            this.txtKLCV.Size = new System.Drawing.Size(389, 20);
            this.txtKLCV.TabIndex = 122;
            this.txtKLCV.TextChanged += new System.EventHandler(this.txtDongia_TextChanged);
            // 
            // txtMaPC
            // 
            this.txtMaPC.Location = new System.Drawing.Point(150, 114);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(115, 20);
            this.txtMaPC.TabIndex = 143;
            this.toolTip1.SetToolTip(this.txtMaPC, "Bắt đầu bằng \"PC\"");
            this.txtMaPC.TextChanged += new System.EventHandler(this.txtMaPC_TextChanged);
            this.txtMaPC.Leave += new System.EventHandler(this.txtMaPC_Leave);
            // 
            // dateTimengaygiao
            // 
            this.dateTimengaygiao.Location = new System.Drawing.Point(358, 114);
            this.dateTimengaygiao.Name = "dateTimengaygiao";
            this.dateTimengaygiao.Size = new System.Drawing.Size(181, 20);
            this.dateTimengaygiao.TabIndex = 144;
            this.dateTimengaygiao.ValueChanged += new System.EventHandler(this.dateTimengaygiao_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 145;
            this.label4.Text = "Ngày giao(*)";
            // 
            // dateTimengayht
            // 
            this.dateTimengayht.Location = new System.Drawing.Point(636, 114);
            this.dateTimengayht.Name = "dateTimengayht";
            this.dateTimengayht.Size = new System.Drawing.Size(181, 20);
            this.dateTimengayht.TabIndex = 146;
            this.dateTimengayht.ValueChanged += new System.EventHandler(this.dateTimengayht_ValueChanged);
            // 
            // rBchuabd
            // 
            this.rBchuabd.AutoSize = true;
            this.rBchuabd.Checked = true;
            this.rBchuabd.Location = new System.Drawing.Point(6, 17);
            this.rBchuabd.Name = "rBchuabd";
            this.rBchuabd.Size = new System.Drawing.Size(90, 17);
            this.rBchuabd.TabIndex = 147;
            this.rBchuabd.TabStop = true;
            this.rBchuabd.Text = "Chưa bắt đầu";
            this.rBchuabd.UseVisualStyleBackColor = true;
            this.rBchuabd.CheckedChanged += new System.EventHandler(this.rBchuabd_CheckedChanged);
            // 
            // rBdangth
            // 
            this.rBdangth.AutoSize = true;
            this.rBdangth.Location = new System.Drawing.Point(117, 17);
            this.rBdangth.Name = "rBdangth";
            this.rBdangth.Size = new System.Drawing.Size(98, 17);
            this.rBdangth.TabIndex = 148;
            this.rBdangth.Text = "Đang thực hiện";
            this.rBdangth.UseVisualStyleBackColor = true;
            // 
            // btnPhancong
            // 
            this.btnPhancong.Location = new System.Drawing.Point(723, 154);
            this.btnPhancong.Name = "btnPhancong";
            this.btnPhancong.Size = new System.Drawing.Size(94, 23);
            this.btnPhancong.TabIndex = 149;
            this.btnPhancong.Text = "Phân công";
            this.btnPhancong.UseVisualStyleBackColor = true;
            this.btnPhancong.Click += new System.EventHandler(this.btnPhancong_Click);
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Location = new System.Drawing.Point(651, 262);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(121, 21);
            this.cbTrangthai.TabIndex = 150;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(800, 262);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(71, 23);
            this.btnLoc.TabIndex = 152;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(742, 333);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(142, 25);
            this.btnchitiet.TabIndex = 153;
            this.btnchitiet.Text = "Chi tiết phân công";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // rBdaht
            // 
            this.rBdaht.AutoSize = true;
            this.rBdaht.Location = new System.Drawing.Point(235, 17);
            this.rBdaht.Name = "rBdaht";
            this.rBdaht.Size = new System.Drawing.Size(84, 17);
            this.rBdaht.TabIndex = 154;
            this.rBdaht.Text = "Hoàn thành ";
            this.rBdaht.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBchuabd);
            this.groupBox1.Controls.Add(this.rBdaht);
            this.groupBox1.Controls.Add(this.rBdangth);
            this.groupBox1.Location = new System.Drawing.Point(358, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 43);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            // 
            // PCCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbTrangthai);
            this.Controls.Add(this.btnPhancong);
            this.Controls.Add(this.dateTimengayht);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimengaygiao);
            this.Controls.Add(this.txtMaPC);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbTenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaopc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPhancong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKLCV);
            this.Name = "PCCV";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.PCCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}