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
            this.txtMucdgia = new System.Windows.Forms.TextBox();
            this.datetime1 = new System.Windows.Forms.DateTimePicker();
            this.btnTaodg = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbDiemdanhgia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMucdgia
            // 
            this.txtMucdgia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMucdgia.Location = new System.Drawing.Point(408, 115);
            this.txtMucdgia.Name = "txtMucdgia";
            this.txtMucdgia.Size = new System.Drawing.Size(91, 20);
            this.txtMucdgia.TabIndex = 112;
            this.txtMucdgia.Text = "Mức đánh giá";
            // 
            // datetime1
            // 
            this.datetime1.Location = new System.Drawing.Point(577, 29);
            this.datetime1.Name = "datetime1";
            this.datetime1.Size = new System.Drawing.Size(200, 20);
            this.datetime1.TabIndex = 111;
            // 
            // btnTaodg
            // 
            this.btnTaodg.Location = new System.Drawing.Point(310, 30);
            this.btnTaodg.Name = "btnTaodg";
            this.btnTaodg.Size = new System.Drawing.Size(148, 23);
            this.btnTaodg.TabIndex = 106;
            this.btnTaodg.Text = "Tạo đánh giá mới";
            this.btnTaodg.UseVisualStyleBackColor = true;
            this.btnTaodg.Click += new System.EventHandler(this.btnTaodg_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(709, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 105;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbDiemdanhgia
            // 
            this.cbDiemdanhgia.FormattingEnabled = true;
            this.cbDiemdanhgia.Location = new System.Drawing.Point(340, 112);
            this.cbDiemdanhgia.Name = "cbDiemdanhgia";
            this.cbDiemdanhgia.Size = new System.Drawing.Size(40, 21);
            this.cbDiemdanhgia.TabIndex = 104;
            this.cbDiemdanhgia.SelectedIndexChanged += new System.EventHandler(this.cbDiemdanhgia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Điểm đánh giá";
            // 
            // dataGridViewChitiet
            // 
            this.dataGridViewChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChitiet.Location = new System.Drawing.Point(85, 195);
            this.dataGridViewChitiet.Name = "dataGridViewChitiet";
            this.dataGridViewChitiet.Size = new System.Drawing.Size(636, 226);
            this.dataGridViewChitiet.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Ghi chú ";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(577, 109);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(218, 20);
            this.txtGhichu.TabIndex = 98;
            // 
            // cbMaDH
            // 
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(112, 112);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(98, 21);
            this.cbMaDH.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "Đánh giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Mã đơn mua hàng";
            // 
            // cbTensp
            // 
            this.cbTensp.FormattingEnabled = true;
            this.cbTensp.Location = new System.Drawing.Point(340, 65);
            this.cbTensp.Name = "cbTensp";
            this.cbTensp.Size = new System.Drawing.Size(159, 21);
            this.cbTensp.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Mã đánh giá SP";
            // 
            // txtDanhgia
            // 
            this.txtDanhgia.Location = new System.Drawing.Point(577, 66);
            this.txtDanhgia.Name = "txtDanhgia";
            this.txtDanhgia.Size = new System.Drawing.Size(218, 20);
            this.txtDanhgia.TabIndex = 91;
            // 
            // txtMaDGSP
            // 
            this.txtMaDGSP.Location = new System.Drawing.Point(110, 66);
            this.txtMaDGSP.Name = "txtMaDGSP";
            this.txtMaDGSP.Size = new System.Drawing.Size(100, 20);
            this.txtMaDGSP.TabIndex = 90;
            this.toolTip1.SetToolTip(this.txtMaDGSP, "Bắt đầu bằng \"DGSP\"");
            // 
            // btnLichsu
            // 
            this.btnLichsu.Location = new System.Drawing.Point(12, 278);
            this.btnLichsu.Name = "btnLichsu";
            this.btnLichsu.Size = new System.Drawing.Size(57, 47);
            this.btnLichsu.TabIndex = 114;
            this.btnLichsu.Text = "Lịch sử đánh giá";
            this.btnLichsu.UseVisualStyleBackColor = true;
            this.btnLichsu.Click += new System.EventHandler(this.btnLichsu_Click);
            // 
            // btnChitietdon
            // 
            this.btnChitietdon.Location = new System.Drawing.Point(735, 266);
            this.btnChitietdon.Name = "btnChitietdon";
            this.btnChitietdon.Size = new System.Drawing.Size(57, 47);
            this.btnChitietdon.TabIndex = 113;
            this.btnChitietdon.Text = "Chi tiết đơn mua";
            this.btnChitietdon.UseVisualStyleBackColor = true;
            this.btnChitietdon.Click += new System.EventHandler(this.btnChitietdon_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(242, 166);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 23);
            this.btnCapNhat.TabIndex = 116;
            this.btnCapNhat.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.btnCapNhat, "Nhân viên không được phép cập nhật");
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(461, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 23);
            this.btnXoa.TabIndex = 115;
            this.btnXoa.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btnXoa, "Nhân viên không được phép xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // Danhgiadonhang_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLichsu);
            this.Controls.Add(this.btnChitietdon);
            this.Controls.Add(this.txtMucdgia);
            this.Controls.Add(this.datetime1);
            this.Controls.Add(this.btnTaodg);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbDiemdanhgia);
            this.Controls.Add(this.label2);
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
            this.Name = "Danhgiadonhang_NV";
            this.Text = "Danhgiadonhang_NV";
            this.Load += new System.EventHandler(this.Danhgiadonhang_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMucdgia;
        private System.Windows.Forms.DateTimePicker datetime1;
        private System.Windows.Forms.Button btnTaodg;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbDiemdanhgia;
        private System.Windows.Forms.Label label2;
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
    }
}