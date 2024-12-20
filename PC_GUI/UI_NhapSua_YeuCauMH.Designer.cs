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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_YC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYCMH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.AutoSize = true;
            this.btnSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSuaSP.Location = new System.Drawing.Point(727, 138);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(140, 39);
            this.btnSuaSP.TabIndex = 109;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.AutoSize = true;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoaSP.Location = new System.Drawing.Point(907, 138);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(133, 39);
            this.btnXoaSP.TabIndex = 108;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // dgvCT_YC
            // 
            this.dgvCT_YC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_YC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCT_YC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_YC.Location = new System.Drawing.Point(681, 522);
            this.dgvCT_YC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCT_YC.Name = "dgvCT_YC";
            this.dgvCT_YC.RowHeadersWidth = 82;
            this.dgvCT_YC.RowTemplate.Height = 33;
            this.dgvCT_YC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_YC.Size = new System.Drawing.Size(975, 688);
            this.dgvCT_YC.TabIndex = 107;
            this.dgvCT_YC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_YC_CellContentClick);
            this.dgvCT_YC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_YC_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(94, 877);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 102;
            // 
            // btnThemSP
            // 
            this.btnThemSP.AutoSize = true;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemSP.Location = new System.Drawing.Point(547, 138);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(153, 39);
            this.btnThemSP.TabIndex = 101;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(761, 46);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(279, 35);
            this.txtSoLuong.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(591, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 99;
            this.label1.Text = "Số lượng";
            // 
            // dgvYCMH
            // 
            this.dgvYCMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYCMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvYCMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYCMH.Location = new System.Drawing.Point(4, 522);
            this.dgvYCMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvYCMH.Name = "dgvYCMH";
            this.dgvYCMH.RowHeadersWidth = 20;
            this.dgvYCMH.RowTemplate.Height = 33;
            this.dgvYCMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYCMH.Size = new System.Drawing.Size(669, 688);
            this.dgvYCMH.TabIndex = 97;
            this.dgvYCMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYCMH_CellContentClick);
            this.dgvYCMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYCMH_CellContentClick);
            // 
            // btnYeuCauDuyet
            // 
            this.btnYeuCauDuyet.AutoSize = true;
            this.btnYeuCauDuyet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYeuCauDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnYeuCauDuyet.Location = new System.Drawing.Point(24, 27);
            this.btnYeuCauDuyet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYeuCauDuyet.Name = "btnYeuCauDuyet";
            this.btnYeuCauDuyet.Size = new System.Drawing.Size(280, 43);
            this.btnYeuCauDuyet.TabIndex = 96;
            this.btnYeuCauDuyet.Text = "Tạo yêu cầu duyệt";
            this.btnYeuCauDuyet.UseVisualStyleBackColor = false;
            this.btnYeuCauDuyet.Click += new System.EventHandler(this.btnYeuCauDuyet_Click);
            // 
            // cbBoPhanYC
            // 
            this.cbBoPhanYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoPhanYC.FormattingEnabled = true;
            this.cbBoPhanYC.Location = new System.Drawing.Point(340, 169);
            this.cbBoPhanYC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBoPhanYC.Name = "cbBoPhanYC";
            this.cbBoPhanYC.Size = new System.Drawing.Size(326, 37);
            this.cbBoPhanYC.TabIndex = 95;
            this.cbBoPhanYC.SelectedIndexChanged += new System.EventHandler(this.cbBoPhanYC_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(862, 77);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(279, 35);
            this.txtMaNV.TabIndex = 94;
            // 
            // txtMaYC
            // 
            this.txtMaYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaYC.Location = new System.Drawing.Point(339, 77);
            this.txtMaYC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaYC.Name = "txtMaYC";
            this.txtMaYC.Size = new System.Drawing.Size(327, 35);
            this.txtMaYC.TabIndex = 93;
            this.txtMaYC.TextChanged += new System.EventHandler(this.txtMaYC_TextChanged);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbSanPham.Location = new System.Drawing.Point(31, 44);
            this.lbSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(121, 29);
            this.lbSanPham.TabIndex = 92;
            this.lbSanPham.Text = "Sản phẩm";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(132, 172);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(200, 29);
            this.lb.TabIndex = 91;
            this.lb.Text = "Bộ phận yêu cầu*";
            this.lb.Click += new System.EventHandler(this.lb_Click);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(692, 80);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(154, 29);
            this.lbMaNV.TabIndex = 90;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbMaYC
            // 
            this.lbMaYC.AutoSize = true;
            this.lbMaYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaYC.Location = new System.Drawing.Point(132, 80);
            this.lbMaYC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaYC.Name = "lbMaYC";
            this.lbMaYC.Size = new System.Drawing.Size(144, 29);
            this.lbMaYC.TabIndex = 89;
            this.lbMaYC.Text = "Mã yêu cầu*";
            // 
            // cbSanPham
            // 
            this.cbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(238, 44);
            this.cbSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(327, 37);
            this.cbSanPham.TabIndex = 110;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnCapNhat.Location = new System.Drawing.Point(24, 80);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(280, 42);
            this.btnCapNhat.TabIndex = 111;
            this.btnCapNhat.Text = "Cập nhật yêu cầu";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaYC
            // 
            this.btnXoaYC.AutoSize = true;
            this.btnXoaYC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoaYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnXoaYC.Location = new System.Drawing.Point(24, 132);
            this.btnXoaYC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaYC.Name = "btnXoaYC";
            this.btnXoaYC.Size = new System.Drawing.Size(280, 41);
            this.btnXoaYC.TabIndex = 112;
            this.btnXoaYC.Text = "Xóa yêu cầu";
            this.btnXoaYC.UseVisualStyleBackColor = false;
            this.btnXoaYC.Click += new System.EventHandler(this.btnXoaYC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.btnXoaSP);
            this.groupBox1.Controls.Add(this.btnSuaSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSanPham);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.lbSanPham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1061, 210);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sản phẩm vào yêu cầu mua hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 114;
            this.label3.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(862, 169);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(279, 35);
            this.txtTinhTrang.TabIndex = 115;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYeuCauDuyet);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnXoaYC);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(1195, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(326, 193);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 29);
            this.label4.TabIndex = 117;
            this.label4.Text = "Danh sách yêu cầu mua hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(731, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 29);
            this.label5.TabIndex = 118;
            this.label5.Text = "Chi tiết yêu cầu mua hàng";
            // 
            // UI_NhapSua_YeuCauMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCT_YC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvYCMH);
            this.Controls.Add(this.cbBoPhanYC);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaYC);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbMaYC);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UI_NhapSua_YeuCauMH";
            this.Size = new System.Drawing.Size(1660, 1215);
            this.Load += new System.EventHandler(this.UI_NhapSua_YeuCauMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_YC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYCMH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}