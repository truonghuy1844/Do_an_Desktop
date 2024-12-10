namespace PC_GUI
{
    partial class Hoadon
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGhichu = new System.Windows.Forms.MaskedTextBox();
            this.txtThanhtien = new System.Windows.Forms.MaskedTextBox();
            this.txtDongia = new System.Windows.Forms.MaskedTextBox();
            this.txtSoluong = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.MaskedTextBox();
            this.txtMaHD = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(662, 756);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 44);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(1300, 348);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(150, 44);
            this.btnThanhtoan.TabIndex = 42;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click_1);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1130, 756);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(150, 44);
            this.btnTim.TabIndex = 41;
            this.btnTim.Text = "Tìm hoá đơn";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(892, 756);
            this.btnTaomoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(150, 44);
            this.btnTaomoi.TabIndex = 40;
            this.btnTaomoi.Text = "Clear";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(500, 756);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(150, 44);
            this.btnCapnhat.TabIndex = 39;
            this.btnCapnhat.Text = "Cập nhật ";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(338, 756);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 44);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(176, 756);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 44);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Tạo hoá đơn mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 431);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 288);
            this.dataGridView1.TabIndex = 36;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(310, 354);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(404, 31);
            this.txtGhichu.TabIndex = 35;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(1044, 265);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(404, 31);
            this.txtThanhtien.TabIndex = 34;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(1044, 156);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(404, 31);
            this.txtDongia.TabIndex = 33;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(1044, 67);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(404, 31);
            this.txtSoluong.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(886, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(886, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(886, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ghi chú";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 252);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày lập";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(310, 169);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(404, 31);
            this.txtMaDH.TabIndex = 25;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(310, 67);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(404, 31);
            this.txtMaHD.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã đơn hàng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã hoá đơn";
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Hoadon";
            this.Text = "Hoadon";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txtGhichu;
        private System.Windows.Forms.MaskedTextBox txtThanhtien;
        private System.Windows.Forms.MaskedTextBox txtDongia;
        private System.Windows.Forms.MaskedTextBox txtSoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtMaDH;
        private System.Windows.Forms.MaskedTextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}