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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeNgayht
            // 
            this.dateTimeNgayht.Location = new System.Drawing.Point(303, 114);
            this.dateTimeNgayht.Name = "dateTimeNgayht";
            this.dateTimeNgayht.Size = new System.Drawing.Size(181, 20);
            this.dateTimeNgayht.TabIndex = 166;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 165;
            this.label4.Text = "Ngày giao";
            // 
            // dateTimeNgaygiao
            // 
            this.dateTimeNgaygiao.Location = new System.Drawing.Point(303, 74);
            this.dateTimeNgaygiao.Name = "dateTimeNgaygiao";
            this.dateTimeNgaygiao.Size = new System.Drawing.Size(181, 20);
            this.dateTimeNgaygiao.TabIndex = 164;
            // 
            // txtMaPC
            // 
            this.txtMaPC.Location = new System.Drawing.Point(95, 74);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(115, 20);
            this.txtMaPC.TabIndex = 163;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(78, 161);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(48, 23);
            this.btnTim.TabIndex = 162;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(141, 163);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(142, 20);
            this.txtTim.TabIndex = 161;
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(95, 116);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(115, 21);
            this.cbTenNV.TabIndex = 160;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 159;
            this.label3.Text = "Mã nhân viên ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(357, 159);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 23);
            this.btnCapNhat.TabIndex = 158;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(524, 159);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 23);
            this.btnXoa.TabIndex = 157;
            this.btnXoa.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btnXoa, "Nhân viên không thể xóa ");
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 154;
            this.label2.Text = "Thời hạn";
            // 
            // dataGridViewPhancong
            // 
            this.dataGridViewPhancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhancong.Location = new System.Drawing.Point(78, 199);
            this.dataGridViewPhancong.Name = "dataGridViewPhancong";
            this.dataGridViewPhancong.Size = new System.Drawing.Size(636, 226);
            this.dataGridViewPhancong.TabIndex = 153;
            this.dataGridViewPhancong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhancong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 151;
            this.label7.Text = "KLCV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 150;
            this.label6.Text = "Mã phân công";
            // 
            // txtKLCV
            // 
            this.txtKLCV.Location = new System.Drawing.Point(615, 70);
            this.txtKLCV.Name = "txtKLCV";
            this.txtKLCV.Size = new System.Drawing.Size(110, 20);
            this.txtKLCV.TabIndex = 149;
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(722, 301);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(66, 71);
            this.btnchitiet.TabIndex = 169;
            this.btnchitiet.Text = "Chi tiết phân công";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // rBdaht
            // 
            this.rBdaht.AutoSize = true;
            this.rBdaht.Location = new System.Drawing.Point(634, 136);
            this.rBdaht.Name = "rBdaht";
            this.rBdaht.Size = new System.Drawing.Size(84, 17);
            this.rBdaht.TabIndex = 172;
            this.rBdaht.Text = "Hoàn thành ";
            this.rBdaht.UseVisualStyleBackColor = true;
            // 
            // rBdangth
            // 
            this.rBdangth.AutoSize = true;
            this.rBdangth.Location = new System.Drawing.Point(699, 112);
            this.rBdangth.Name = "rBdangth";
            this.rBdangth.Size = new System.Drawing.Size(98, 17);
            this.rBdangth.TabIndex = 171;
            this.rBdangth.Text = "Đang thực hiện";
            this.rBdangth.UseVisualStyleBackColor = true;
            // 
            // rBchuabd
            // 
            this.rBchuabd.AutoSize = true;
            this.rBchuabd.Checked = true;
            this.rBchuabd.Location = new System.Drawing.Point(583, 112);
            this.rBchuabd.Name = "rBchuabd";
            this.rBchuabd.Size = new System.Drawing.Size(90, 17);
            this.rBchuabd.TabIndex = 170;
            this.rBchuabd.TabStop = true;
            this.rBchuabd.Text = "Chưa bắt đầu";
            this.rBchuabd.UseVisualStyleBackColor = true;
            // 
            // PCCV_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBdaht);
            this.Controls.Add(this.rBdangth);
            this.Controls.Add(this.rBchuabd);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dateTimeNgayht);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeNgaygiao);
            this.Controls.Add(this.txtMaPC);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbTenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPhancong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKLCV);
            this.Name = "PCCV_NV";
            this.Text = "PCCV_NV";
            this.Load += new System.EventHandler(this.PCCV_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhancong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}