namespace PC_GUI
{
    partial class UI_NhapSua_YeuCauMH
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
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.dgvCT_YC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYCMH = new System.Windows.Forms.DataGridView();
            this.btnYeuCauDuyet = new System.Windows.Forms.Button();
            this.cbBoPhanYC = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaYC = new System.Windows.Forms.TextBox();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaYC = new System.Windows.Forms.Label();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.toolTipMaYC = new System.Windows.Forms.ToolTip(this.components);
            this.btnXoaYC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.toolTipTT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_YC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYCMH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.AutoSize = true;
            this.btnSuaSP.Location = new System.Drawing.Point(652, 35);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(176, 35);
            this.btnSuaSP.TabIndex = 109;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.AutoSize = true;
            this.btnXoaSP.Location = new System.Drawing.Point(381, 33);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(176, 39);
            this.btnXoaSP.TabIndex = 108;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // dgvCT_YC
            // 
            this.dgvCT_YC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_YC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCT_YC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_YC.Location = new System.Drawing.Point(456, 372);
            this.dgvCT_YC.Name = "dgvCT_YC";
            this.dgvCT_YC.RowHeadersWidth = 82;
            this.dgvCT_YC.RowTemplate.Height = 33;
            this.dgvCT_YC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_YC.Size = new System.Drawing.Size(850, 452);
            this.dgvCT_YC.TabIndex = 107;
            this.dgvCT_YC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_YC_CellContentClick);
            this.dgvCT_YC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_YC_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 102;
            // 
            // btnThemSP
            // 
            this.btnThemSP.AutoSize = true;
            this.btnThemSP.Location = new System.Drawing.Point(110, 35);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(176, 40);
            this.btnThemSP.TabIndex = 101;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(765, 202);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(197, 31);
            this.txtSoLuong.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "Số lượng";
            // 
            // dgvYCMH
            // 
            this.dgvYCMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvYCMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYCMH.Location = new System.Drawing.Point(12, 372);
            this.dgvYCMH.Name = "dgvYCMH";
            this.dgvYCMH.RowHeadersWidth = 20;
            this.dgvYCMH.RowTemplate.Height = 33;
            this.dgvYCMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYCMH.Size = new System.Drawing.Size(438, 452);
            this.dgvYCMH.TabIndex = 97;
            this.dgvYCMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYCMH_CellContentClick);
            this.dgvYCMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYCMH_CellContentClick);
            // 
            // btnYeuCauDuyet
            // 
            this.btnYeuCauDuyet.AutoSize = true;
            this.btnYeuCauDuyet.Location = new System.Drawing.Point(1001, 81);
            this.btnYeuCauDuyet.Name = "btnYeuCauDuyet";
            this.btnYeuCauDuyet.Size = new System.Drawing.Size(213, 39);
            this.btnYeuCauDuyet.TabIndex = 96;
            this.btnYeuCauDuyet.Text = "Tạo yêu cầu duyệt";
            this.btnYeuCauDuyet.UseVisualStyleBackColor = true;
            this.btnYeuCauDuyet.Click += new System.EventHandler(this.btnYeuCauDuyet_Click);
            // 
            // cbBoPhanYC
            // 
            this.cbBoPhanYC.FormattingEnabled = true;
            this.cbBoPhanYC.Location = new System.Drawing.Point(244, 145);
            this.cbBoPhanYC.Name = "cbBoPhanYC";
            this.cbBoPhanYC.Size = new System.Drawing.Size(367, 33);
            this.cbBoPhanYC.TabIndex = 95;
            this.cbBoPhanYC.SelectedIndexChanged += new System.EventHandler(this.cbBoPhanYC_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(765, 85);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(197, 31);
            this.txtMaNV.TabIndex = 94;
            // 
            // txtMaYC
            // 
            this.txtMaYC.Location = new System.Drawing.Point(244, 85);
            this.txtMaYC.Name = "txtMaYC";
            this.txtMaYC.Size = new System.Drawing.Size(367, 31);
            this.txtMaYC.TabIndex = 93;
            this.txtMaYC.TextChanged += new System.EventHandler(this.txtMaYC_TextChanged);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Location = new System.Drawing.Point(129, 200);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(109, 25);
            this.lbSanPham.TabIndex = 92;
            this.lbSanPham.Text = "Sản phẩm";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(64, 145);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(174, 25);
            this.lb.TabIndex = 91;
            this.lb.Text = "Bộ phận yêu cầu";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(617, 88);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(142, 25);
            this.lbMaNV.TabIndex = 90;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbMaYC
            // 
            this.lbMaYC.AutoSize = true;
            this.lbMaYC.Location = new System.Drawing.Point(114, 88);
            this.lbMaYC.Name = "lbMaYC";
            this.lbMaYC.Size = new System.Drawing.Size(124, 25);
            this.lbMaYC.TabIndex = 89;
            this.lbMaYC.Text = "Mã yêu cầu";
            // 
            // cbSanPham
            // 
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(244, 200);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(367, 33);
            this.cbSanPham.TabIndex = 110;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.Location = new System.Drawing.Point(1001, 149);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(213, 39);
            this.btnCapNhat.TabIndex = 111;
            this.btnCapNhat.Text = "Cập nhật yêu cầu";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaYC
            // 
            this.btnXoaYC.AutoSize = true;
            this.btnXoaYC.Location = new System.Drawing.Point(1001, 217);
            this.btnXoaYC.Name = "btnXoaYC";
            this.btnXoaYC.Size = new System.Drawing.Size(213, 39);
            this.btnXoaYC.TabIndex = 112;
            this.btnXoaYC.Text = "Xóa yêu cầu";
            this.btnXoaYC.UseVisualStyleBackColor = true;
            this.btnXoaYC.Click += new System.EventHandler(this.btnXoaYC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.btnXoaSP);
            this.groupBox1.Controls.Add(this.btnSuaSP);
            this.groupBox1.Location = new System.Drawing.Point(134, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 94);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sản phẩm vào yêu cầu mua hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 114;
            this.label3.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(765, 145);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(197, 31);
            this.txtTinhTrang.TabIndex = 115;
            // 
            // UI_NhapSua_YeuCauMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoaYC);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cbSanPham);
            this.Controls.Add(this.dgvCT_YC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvYCMH);
            this.Controls.Add(this.btnYeuCauDuyet);
            this.Controls.Add(this.cbBoPhanYC);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaYC);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbMaYC);
            this.Name = "UI_NhapSua_YeuCauMH";
            this.Size = new System.Drawing.Size(1318, 836);
            this.Load += new System.EventHandler(this.UI_NhapSua_YeuCauMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_YC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYCMH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.DataGridView dgvCT_YC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvYCMH;
        private System.Windows.Forms.Button btnYeuCauDuyet;
        private System.Windows.Forms.ComboBox cbBoPhanYC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaYC;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaYC;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ToolTip toolTipMaYC;
        private System.Windows.Forms.Button btnXoaYC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.ToolTip toolTipTT;
    }
}