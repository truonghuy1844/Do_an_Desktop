namespace PC_GUI
{
    partial class PCCV_NV
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
            this.dateTimeNgayht = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNgaygiao = new System.Windows.Forms.DateTimePicker();
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPhancong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKLCV = new System.Windows.Forms.TextBox();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rBdaht = new System.Windows.Forms.RadioButton();
            this.rBdangth = new System.Windows.Forms.RadioButton();
            this.rBchuabd = new System.Windows.Forms.RadioButton();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeNgayht
            // 
            this.dateTimeNgayht.Location = new System.Drawing.Point(855, 18);
            this.dateTimeNgayht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeNgayht.Name = "dateTimeNgayht";
            this.dateTimeNgayht.Size = new System.Drawing.Size(240, 22);
            this.dateTimeNgayht.TabIndex = 166;
            this.dateTimeNgayht.ValueChanged += new System.EventHandler(this.dateTimeNgayht_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 165;
            this.label4.Text = "Ngày giao(*)";
            // 
            // dateTimeNgaygiao
            // 
            this.dateTimeNgaygiao.Location = new System.Drawing.Point(470, 24);
            this.dateTimeNgaygiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeNgaygiao.Name = "dateTimeNgaygiao";
            this.dateTimeNgaygiao.Size = new System.Drawing.Size(240, 22);
            this.dateTimeNgaygiao.TabIndex = 164;
            // 
            // txtMaPC
            // 
            this.txtMaPC.Location = new System.Drawing.Point(126, 20);
            this.txtMaPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(152, 22);
            this.txtMaPC.TabIndex = 163;
            this.txtMaPC.TextChanged += new System.EventHandler(this.txtMaPC_TextChanged);
            this.txtMaPC.Leave += new System.EventHandler(this.txtMaPC_Leave);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(563, 14);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(109, 28);
            this.btnTim.TabIndex = 162;
            this.btnTim.Text = "Tìm kiếm ";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(108, 16);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(416, 22);
            this.txtTim.TabIndex = 161;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã phân công hoặc tên nhân viên");
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(126, 63);
            this.cbTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(152, 24);
            this.cbTenNV.TabIndex = 160;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 159;
            this.label3.Text = "Tên nhân viên(*) ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(632, 127);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(199, 35);
            this.btnCapNhat.TabIndex = 158;
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
            this.btnXoa.Location = new System.Drawing.Point(896, 127);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(199, 35);
            this.btnXoa.TabIndex = 157;
            this.btnXoa.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btnXoa, "Nhân viên không thể xóa ");
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 154;
            this.label2.Text = "Thời hạn(*)";
            // 
            // dataGridViewPhancong
            // 
            this.dataGridViewPhancong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhancong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPhancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhancong.Location = new System.Drawing.Point(4, 71);
            this.dataGridViewPhancong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPhancong.Name = "dataGridViewPhancong";
            this.dataGridViewPhancong.RowHeadersWidth = 82;
            this.dataGridViewPhancong.Size = new System.Drawing.Size(1100, 315);
            this.dataGridViewPhancong.TabIndex = 153;
            this.dataGridViewPhancong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhancong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 152;
            this.label1.Text = "Trạng thái(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 151;
            this.label7.Text = "Công việc(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 150;
            this.label6.Text = "Mã phân công(*)";
            // 
            // txtKLCV
            // 
            this.txtKLCV.Location = new System.Drawing.Point(126, 113);
            this.txtKLCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKLCV.Name = "txtKLCV";
            this.txtKLCV.Size = new System.Drawing.Size(451, 22);
            this.txtKLCV.TabIndex = 149;
            this.txtKLCV.TextChanged += new System.EventHandler(this.txtKLCV_TextChanged);
            // 
            // btnchitiet
            // 
            this.btnchitiet.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnchitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchitiet.ForeColor = System.Drawing.Color.White;
            this.btnchitiet.Location = new System.Drawing.Point(896, 412);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(199, 35);
            this.btnchitiet.TabIndex = 169;
            this.btnchitiet.Text = "Chi tiết phân công";
            this.btnchitiet.UseVisualStyleBackColor = false;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // rBdaht
            // 
            this.rBdaht.AutoSize = true;
            this.rBdaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBdaht.Location = new System.Drawing.Point(299, 19);
            this.rBdaht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBdaht.Name = "rBdaht";
            this.rBdaht.Size = new System.Drawing.Size(109, 22);
            this.rBdaht.TabIndex = 172;
            this.rBdaht.Text = "Hoàn thành ";
            this.rBdaht.UseVisualStyleBackColor = true;
            this.rBdaht.CheckedChanged += new System.EventHandler(this.rBdaht_CheckedChanged);
            // 
            // rBdangth
            // 
            this.rBdangth.AutoSize = true;
            this.rBdangth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBdangth.Location = new System.Drawing.Point(148, 19);
            this.rBdangth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBdangth.Name = "rBdangth";
            this.rBdangth.Size = new System.Drawing.Size(127, 22);
            this.rBdangth.TabIndex = 171;
            this.rBdangth.Text = "Đang thực hiện";
            this.rBdangth.UseVisualStyleBackColor = true;
            // 
            // rBchuabd
            // 
            this.rBchuabd.AutoSize = true;
            this.rBchuabd.Checked = true;
            this.rBchuabd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBchuabd.Location = new System.Drawing.Point(8, 19);
            this.rBchuabd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBchuabd.Name = "rBchuabd";
            this.rBchuabd.Size = new System.Drawing.Size(116, 22);
            this.rBchuabd.TabIndex = 170;
            this.rBchuabd.TabStop = true;
            this.rBchuabd.Text = "Chưa bắt đầu";
            this.rBchuabd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBchuabd);
            this.groupBox1.Controls.Add(this.rBdaht);
            this.groupBox1.Controls.Add(this.rBdangth);
            this.groupBox1.Location = new System.Drawing.Point(470, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(420, 43);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 64);
            this.panel3.TabIndex = 174;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(343, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(573, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "PHÂN CÔNG CÔNG VIỆC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dateTimeNgayht);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimeNgaygiao);
            this.panel1.Controls.Add(this.txtMaPC);
            this.panel1.Controls.Add(this.cbTenNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtKLCV);
            this.panel1.Location = new System.Drawing.Point(0, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 176);
            this.panel1.TabIndex = 175;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtTim);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 52);
            this.panel2.TabIndex = 176;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 150;
            this.label8.Text = "Tìm kiếm";
            // 
            // PCCV_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dataGridViewPhancong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PCCV_NV";
            this.Size = new System.Drawing.Size(1107, 778);
            this.Load += new System.EventHandler(this.PCCV_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeNgayht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNgaygiao;
        private System.Windows.Forms.TextBox txtMaPC;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPhancong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKLCV;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rBdaht;
        private System.Windows.Forms.RadioButton rBdangth;
        private System.Windows.Forms.RadioButton rBchuabd;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}