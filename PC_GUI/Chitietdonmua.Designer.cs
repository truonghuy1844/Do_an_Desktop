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
            this.btnDanhgiasp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(361, 155);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 23);
            this.btnCapNhat.TabIndex = 113;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(528, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 23);
            this.btnXoa.TabIndex = 112;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaoctmua
            // 
            this.btnTaoctmua.Location = new System.Drawing.Point(307, 30);
            this.btnTaoctmua.Name = "btnTaoctmua";
            this.btnTaoctmua.Size = new System.Drawing.Size(148, 23);
            this.btnTaoctmua.TabIndex = 109;
            this.btnTaoctmua.Text = "Tạo mới";
            this.btnTaoctmua.UseVisualStyleBackColor = true;
            this.btnTaoctmua.Click += new System.EventHandler(this.btnTaoctmua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(706, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 108;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbMabaogia
            // 
            this.cbMabaogia.FormattingEnabled = true;
            this.cbMabaogia.Location = new System.Drawing.Point(337, 112);
            this.cbMabaogia.Name = "cbMabaogia";
            this.cbMabaogia.Size = new System.Drawing.Size(152, 21);
            this.cbMabaogia.TabIndex = 107;
            this.cbMabaogia.SelectedIndexChanged += new System.EventHandler(this.cbMabaogia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Mã báo giá";
            // 
            // btnChitietdon
            // 
            this.btnChitietdon.Location = new System.Drawing.Point(735, 269);
            this.btnChitietdon.Name = "btnChitietdon";
            this.btnChitietdon.Size = new System.Drawing.Size(57, 47);
            this.btnChitietdon.TabIndex = 104;
            this.btnChitietdon.Text = "Chi tiết đơn mua";
            this.btnChitietdon.UseVisualStyleBackColor = true;
            this.btnChitietdon.Click += new System.EventHandler(this.btnChitietdon_Click);
            // 
            // dataGridViewChitiet
            // 
            this.dataGridViewChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChitiet.Location = new System.Drawing.Point(82, 195);
            this.dataGridViewChitiet.Name = "dataGridViewChitiet";
            this.dataGridViewChitiet.Size = new System.Drawing.Size(636, 226);
            this.dataGridViewChitiet.TabIndex = 103;
            this.dataGridViewChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChitiet_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Số lượng ";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(574, 109);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(110, 20);
            this.txtSoluong.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Mã đơn hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Tên sản phẩm";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(574, 66);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(110, 20);
            this.txtDongia.TabIndex = 94;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(337, 66);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(152, 20);
            this.txtTensp.TabIndex = 114;
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(99, 112);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(98, 21);
            this.cbMaSP.TabIndex = 116;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 115;
            this.label3.Text = "Mã sản phẩm";
            // 
            // cbMaDH
            // 
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(99, 70);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(98, 21);
            this.cbMaDH.TabIndex = 118;
            this.cbMaDH.SelectedIndexChanged += new System.EventHandler(this.cbMaDH_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTim.Location = new System.Drawing.Point(145, 159);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(142, 20);
            this.txtTim.TabIndex = 119;
            this.toolTip1.SetToolTip(this.txtTim, "Nhập mã đơn hàng để tìm kiếm");
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(82, 157);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(48, 23);
            this.btnTim.TabIndex = 120;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnDanhgiasp
            // 
            this.btnDanhgiasp.Location = new System.Drawing.Point(12, 269);
            this.btnDanhgiasp.Name = "btnDanhgiasp";
            this.btnDanhgiasp.Size = new System.Drawing.Size(64, 47);
            this.btnDanhgiasp.TabIndex = 121;
            this.btnDanhgiasp.Text = "Đánh giá sản phẩm";
            this.btnDanhgiasp.UseVisualStyleBackColor = true;
            this.btnDanhgiasp.Click += new System.EventHandler(this.btnDanhgiasp_Click);
            // 
            // Chitietdonmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDanhgiasp);
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
        private System.Windows.Forms.Button btnDanhgiasp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}