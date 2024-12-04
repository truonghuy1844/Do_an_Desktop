namespace PC_GUI
{
    partial class UI_NhapSua_BaoGia
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
            this.btnXoaBG = new System.Windows.Forms.Button();
            this.btnSuaBG = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.dtgCT_BG = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnThemBG = new System.Windows.Forms.Button();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.txtMaBG = new System.Windows.Forms.TextBox();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaBG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCT_BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaBG
            // 
            this.btnXoaBG.AutoSize = true;
            this.btnXoaBG.Location = new System.Drawing.Point(961, 130);
            this.btnXoaBG.Name = "btnXoaBG";
            this.btnXoaBG.Size = new System.Drawing.Size(161, 35);
            this.btnXoaBG.TabIndex = 121;
            this.btnXoaBG.Text = "Xóa báo giá";
            this.btnXoaBG.UseVisualStyleBackColor = true;
            // 
            // btnSuaBG
            // 
            this.btnSuaBG.AutoSize = true;
            this.btnSuaBG.Location = new System.Drawing.Point(1101, 85);
            this.btnSuaBG.Name = "btnSuaBG";
            this.btnSuaBG.Size = new System.Drawing.Size(161, 35);
            this.btnSuaBG.TabIndex = 120;
            this.btnSuaBG.Text = "Sửa báo giá";
            this.btnSuaBG.UseVisualStyleBackColor = true;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(317, 235);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(325, 31);
            this.txtMaSP.TabIndex = 119;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.AutoSize = true;
            this.btnSuaSP.Location = new System.Drawing.Point(961, 267);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(161, 35);
            this.btnSuaSP.TabIndex = 118;
            this.btnSuaSP.Text = "Sửa sản phẩm";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.AutoSize = true;
            this.btnXoaSP.Location = new System.Drawing.Point(961, 217);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(161, 35);
            this.btnXoaSP.TabIndex = 117;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // dtgCT_BG
            // 
            this.dtgCT_BG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCT_BG.Location = new System.Drawing.Point(467, 380);
            this.dtgCT_BG.Name = "dtgCT_BG";
            this.dtgCT_BG.RowHeadersWidth = 82;
            this.dtgCT_BG.RowTemplate.Height = 33;
            this.dtgCT_BG.Size = new System.Drawing.Size(702, 398);
            this.dtgCT_BG.TabIndex = 116;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(961, 313);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(176, 35);
            this.btnTimKiem.TabIndex = 115;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(317, 317);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(605, 31);
            this.txtTimKiem.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Tìm kiếm sản phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.AutoSize = true;
            this.btnThemSP.Location = new System.Drawing.Point(961, 171);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(176, 35);
            this.btnThemSP.TabIndex = 112;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(317, 277);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(325, 31);
            this.txtDonGia.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "Đơn giá";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(69, 380);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 82;
            this.dgvSanPham.RowTemplate.Height = 33;
            this.dgvSanPham.Size = new System.Drawing.Size(392, 398);
            this.dgvSanPham.TabIndex = 109;
            // 
            // btnThemBG
            // 
            this.btnThemBG.AutoSize = true;
            this.btnThemBG.Location = new System.Drawing.Point(839, 85);
            this.btnThemBG.Name = "btnThemBG";
            this.btnThemBG.Size = new System.Drawing.Size(161, 35);
            this.btnThemBG.TabIndex = 108;
            this.btnThemBG.Text = "Thêm báo giá";
            this.btnThemBG.UseVisualStyleBackColor = true;
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(292, 171);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(630, 33);
            this.cbNCC.TabIndex = 107;
            // 
            // txtMaBG
            // 
            this.txtMaBG.Location = new System.Drawing.Point(292, 111);
            this.txtMaBG.Name = "txtMaBG";
            this.txtMaBG.Size = new System.Drawing.Size(279, 31);
            this.txtMaBG.TabIndex = 106;
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Location = new System.Drawing.Point(112, 241);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(142, 25);
            this.lbSanPham.TabIndex = 105;
            this.lbSanPham.Text = "Mã sản phẩm";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(108, 176);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(178, 25);
            this.lbMaNV.TabIndex = 104;
            this.lbMaNV.Text = "Mã nhà cung cấp";
            // 
            // lbMaBG
            // 
            this.lbMaBG.AutoSize = true;
            this.lbMaBG.Location = new System.Drawing.Point(112, 114);
            this.lbMaBG.Name = "lbMaBG";
            this.lbMaBG.Size = new System.Drawing.Size(119, 25);
            this.lbMaBG.TabIndex = 103;
            this.lbMaBG.Text = "Mã báo giá";
            // 
            // UI_NhapSua_BaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 863);
            this.Controls.Add(this.btnXoaBG);
            this.Controls.Add(this.btnSuaBG);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.dtgCT_BG);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnThemBG);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.txtMaBG);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbMaBG);
            this.Name = "UI_NhapSua_BaoGia";
            this.Text = "UI_NhapSua_BaoGia";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCT_BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaBG;
        private System.Windows.Forms.Button btnSuaBG;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.DataGridView dtgCT_BG;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnThemBG;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.TextBox txtMaBG;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaBG;
    }
}