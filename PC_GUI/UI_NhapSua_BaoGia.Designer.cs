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
            this.components = new System.ComponentModel.Container();
            this.btnXoaBG = new System.Windows.Forms.Button();
            this.btnSuaBG = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.dtgCT_BG = new System.Windows.Forms.DataGridView();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemBG = new System.Windows.Forms.Button();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.txtMaBG = new System.Windows.Forms.TextBox();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaBG = new System.Windows.Forms.Label();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tooltipMaBG = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCT_BG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaBG
            // 
            this.btnXoaBG.AutoSize = true;
            this.btnXoaBG.Location = new System.Drawing.Point(6, 178);
            this.btnXoaBG.Name = "btnXoaBG";
            this.btnXoaBG.Size = new System.Drawing.Size(184, 35);
            this.btnXoaBG.TabIndex = 121;
            this.btnXoaBG.Text = "Xóa báo giá";
            this.btnXoaBG.UseVisualStyleBackColor = true;
            this.btnXoaBG.Click += new System.EventHandler(this.btnXoaBG_Click);
            // 
            // btnSuaBG
            // 
            this.btnSuaBG.AutoSize = true;
            this.btnSuaBG.Location = new System.Drawing.Point(6, 104);
            this.btnSuaBG.Name = "btnSuaBG";
            this.btnSuaBG.Size = new System.Drawing.Size(184, 35);
            this.btnSuaBG.TabIndex = 120;
            this.btnSuaBG.Text = "Sửa báo giá";
            this.btnSuaBG.UseVisualStyleBackColor = true;
            this.btnSuaBG.Click += new System.EventHandler(this.btnSuaBG_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.AutoSize = true;
            this.btnSuaSP.Location = new System.Drawing.Point(6, 104);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(176, 35);
            this.btnSuaSP.TabIndex = 118;
            this.btnSuaSP.Text = "Sửa sản phẩm";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.AutoSize = true;
            this.btnXoaSP.Location = new System.Drawing.Point(6, 178);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(176, 35);
            this.btnXoaSP.TabIndex = 117;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // dtgCT_BG
            // 
            this.dtgCT_BG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCT_BG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgCT_BG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCT_BG.Location = new System.Drawing.Point(516, 410);
            this.dtgCT_BG.Name = "dtgCT_BG";
            this.dtgCT_BG.RowHeadersWidth = 20;
            this.dtgCT_BG.RowTemplate.Height = 33;
            this.dtgCT_BG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCT_BG.Size = new System.Drawing.Size(803, 441);
            this.dtgCT_BG.TabIndex = 116;
            this.dtgCT_BG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCT_BG_CellContentClick);
            this.dtgCT_BG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCT_BG_CellContentClick);
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(292, 315);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(544, 31);
            this.txtMota.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Mô tả";
            // 
            // btnThemSP
            // 
            this.btnThemSP.AutoSize = true;
            this.btnThemSP.Location = new System.Drawing.Point(6, 30);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(176, 35);
            this.btnThemSP.TabIndex = 112;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(292, 255);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(544, 31);
            this.txtDonGia.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "Đơn giá";
            // 
            // btnThemBG
            // 
            this.btnThemBG.AutoSize = true;
            this.btnThemBG.Location = new System.Drawing.Point(6, 30);
            this.btnThemBG.Name = "btnThemBG";
            this.btnThemBG.Size = new System.Drawing.Size(184, 35);
            this.btnThemBG.TabIndex = 108;
            this.btnThemBG.Text = "Thêm báo giá";
            this.btnThemBG.UseVisualStyleBackColor = true;
            this.btnThemBG.Click += new System.EventHandler(this.btnThemBG_Click);
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(292, 131);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(544, 33);
            this.cbNCC.TabIndex = 107;
            this.cbNCC.SelectedIndexChanged += new System.EventHandler(this.cbNCC_SelectedIndexChanged);
            // 
            // txtMaBG
            // 
            this.txtMaBG.Location = new System.Drawing.Point(292, 71);
            this.txtMaBG.Name = "txtMaBG";
            this.txtMaBG.Size = new System.Drawing.Size(541, 31);
            this.txtMaBG.TabIndex = 106;
            this.txtMaBG.TextChanged += new System.EventHandler(this.txtMaBG_TextChanged);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Location = new System.Drawing.Point(112, 197);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(109, 25);
            this.lbSanPham.TabIndex = 105;
            this.lbSanPham.Text = "Sản phẩm";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(108, 134);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(178, 25);
            this.lbMaNV.TabIndex = 104;
            this.lbMaNV.Text = "Mã nhà cung cấp";
            // 
            // lbMaBG
            // 
            this.lbMaBG.AutoSize = true;
            this.lbMaBG.Location = new System.Drawing.Point(112, 71);
            this.lbMaBG.Name = "lbMaBG";
            this.lbMaBG.Size = new System.Drawing.Size(119, 25);
            this.lbMaBG.TabIndex = 103;
            this.lbMaBG.Text = "Mã báo giá";
            // 
            // cbSanPham
            // 
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(292, 193);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(544, 33);
            this.cbSanPham.TabIndex = 122;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemBG);
            this.groupBox1.Controls.Add(this.btnSuaBG);
            this.groupBox1.Controls.Add(this.btnXoaBG);
            this.groupBox1.Location = new System.Drawing.Point(1078, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 234);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.btnXoaSP);
            this.groupBox2.Controls.Add(this.btnSuaSP);
            this.groupBox2.Location = new System.Drawing.Point(869, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 234);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            // 
            // tooltipMaBG
            // 
            this.tooltipMaBG.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 441);
            this.dataGridView1.TabIndex = 125;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // UI_NhapSua_BaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 863);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbSanPham);
            this.Controls.Add(this.dtgCT_BG);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.txtMaBG);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbMaBG);
            this.Name = "UI_NhapSua_BaoGia";
            this.Text = "UI_NhapSua_BaoGia";
            this.Load += new System.EventHandler(this.UI_NhapSua_BaoGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCT_BG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaBG;
        private System.Windows.Forms.Button btnSuaBG;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.DataGridView dtgCT_BG;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemBG;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.TextBox txtMaBG;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaBG;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip tooltipMaBG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}