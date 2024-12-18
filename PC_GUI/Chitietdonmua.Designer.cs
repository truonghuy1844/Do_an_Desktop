namespace PC_GUI
{
    partial class Chitietdonmua
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoctmua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbMabaogia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChitietdon = new System.Windows.Forms.Button();
            this.dataGridViewChitiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaDH = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(497, 319);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(188, 44);
            this.btnCapNhat.TabIndex = 113;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(722, 319);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(188, 44);
            this.btnXoa.TabIndex = 112;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaoctmua
            // 
            this.btnTaoctmua.Location = new System.Drawing.Point(614, 58);
            this.btnTaoctmua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTaoctmua.Name = "btnTaoctmua";
            this.btnTaoctmua.Size = new System.Drawing.Size(296, 44);
            this.btnTaoctmua.TabIndex = 109;
            this.btnTaoctmua.Text = "Tạo mới";
            this.btnTaoctmua.UseVisualStyleBackColor = true;
            this.btnTaoctmua.Click += new System.EventHandler(this.btnTaoctmua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(939, 319);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(170, 44);
            this.btnLuu.TabIndex = 108;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbMabaogia
            // 
            this.cbMabaogia.FormattingEnabled = true;
            this.cbMabaogia.Location = new System.Drawing.Point(674, 215);
            this.cbMabaogia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMabaogia.Name = "cbMabaogia";
            this.cbMabaogia.Size = new System.Drawing.Size(300, 33);
            this.cbMabaogia.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 106;
            this.label2.Text = "Mã báo giá";
            // 
            // btnChitietdon
            // 
            this.btnChitietdon.Location = new System.Drawing.Point(1315, 319);
            this.btnChitietdon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChitietdon.Name = "btnChitietdon";
            this.btnChitietdon.Size = new System.Drawing.Size(252, 44);
            this.btnChitietdon.TabIndex = 104;
            this.btnChitietdon.Text = "Chi tiết đơn mua";
            this.btnChitietdon.UseVisualStyleBackColor = true;
            this.btnChitietdon.Click += new System.EventHandler(this.btnChitietdon_Click);
            // 
            // dataGridViewChitiet
            // 
            this.dataGridViewChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChitiet.Location = new System.Drawing.Point(29, 389);
            this.dataGridViewChitiet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewChitiet.Name = "dataGridViewChitiet";
            this.dataGridViewChitiet.RowHeadersWidth = 82;
            this.dataGridViewChitiet.Size = new System.Drawing.Size(1538, 461);
            this.dataGridViewChitiet.TabIndex = 103;
            this.dataGridViewChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChitiet_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1010, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 102;
            this.label1.Text = "Số lượng (*)";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(1148, 210);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(216, 31);
            this.txtSoluong.TabIndex = 101;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            this.txtSoluong.Leave += new System.EventHandler(this.txtSoluong_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1046, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 98;
            this.label6.Text = "Mã đơn hàng(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "Tên sản phẩm";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(1148, 127);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(216, 31);
            this.txtDongia.TabIndex = 94;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(674, 127);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(300, 31);
            this.txtTensp.TabIndex = 114;
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(198, 215);
            this.cbMaSP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(192, 33);
            this.cbMaSP.TabIndex = 116;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 115;
            this.label3.Text = "Mã sản phẩm(*)";
            // 
            // cbMaDH
            // 
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(198, 135);
            this.cbMaDH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(192, 33);
            this.cbMaDH.TabIndex = 118;
            this.cbMaDH.SelectedIndexChanged += new System.EventHandler(this.cbMaDH_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(151, 326);
            this.txtTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(280, 31);
            this.txtTim.TabIndex = 119;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã đơn hàng để tìm kiếm");
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(43, 319);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 44);
            this.btnTim.TabIndex = 120;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Chitietdonmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbMaDH);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaoctmua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbMabaogia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChitietdon);
            this.Controls.Add(this.dataGridViewChitiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDongia);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Chitietdonmua";
            this.Text = "Chitietdonmua";
            this.Load += new System.EventHandler(this.Chitietdonmua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoctmua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbMabaogia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChitietdon;
        private System.Windows.Forms.DataGridView dataGridViewChitiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaDH;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}