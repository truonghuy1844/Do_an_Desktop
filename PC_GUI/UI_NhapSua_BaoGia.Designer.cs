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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCT_BG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaBG
            // 
            this.btnXoaBG.AutoSize = true;
            this.btnXoaBG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBG.ForeColor = System.Drawing.Color.White;
            this.btnXoaBG.Location = new System.Drawing.Point(421, 19);
            this.btnXoaBG.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoaBG.Name = "btnXoaBG";
            this.btnXoaBG.Size = new System.Drawing.Size(172, 41);
            this.btnXoaBG.TabIndex = 121;
            this.btnXoaBG.Text = "Xóa báo giá";
            this.btnXoaBG.UseVisualStyleBackColor = false;
            this.btnXoaBG.Click += new System.EventHandler(this.btnXoaBG_Click);
            // 
            // btnSuaBG
            // 
            this.btnSuaBG.AutoSize = true;
            this.btnSuaBG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSuaBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaBG.ForeColor = System.Drawing.Color.White;
            this.btnSuaBG.Location = new System.Drawing.Point(214, 19);
            this.btnSuaBG.Margin = new System.Windows.Forms.Padding(1);
            this.btnSuaBG.Name = "btnSuaBG";
            this.btnSuaBG.Size = new System.Drawing.Size(192, 41);
            this.btnSuaBG.TabIndex = 120;
            this.btnSuaBG.Text = "Sửa báo giá";
            this.btnSuaBG.UseVisualStyleBackColor = false;
            this.btnSuaBG.Click += new System.EventHandler(this.btnSuaBG_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.AutoSize = true;
            this.btnSuaSP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.Location = new System.Drawing.Point(214, 20);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(1);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(192, 41);
            this.btnSuaSP.TabIndex = 118;
            this.btnSuaSP.Text = "Sửa sản phẩm";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.AutoSize = true;
            this.btnXoaSP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(421, 20);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(191, 41);
            this.btnXoaSP.TabIndex = 117;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // dtgCT_BG
            // 
            this.dtgCT_BG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCT_BG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgCT_BG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCT_BG.Location = new System.Drawing.Point(543, 114);
            this.dtgCT_BG.Margin = new System.Windows.Forms.Padding(1);
            this.dtgCT_BG.Name = "dtgCT_BG";
            this.dtgCT_BG.RowHeadersWidth = 20;
            this.dtgCT_BG.RowTemplate.Height = 33;
            this.dtgCT_BG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCT_BG.Size = new System.Drawing.Size(726, 338);
            this.dtgCT_BG.TabIndex = 116;
            this.dtgCT_BG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCT_BG_CellContentClick);
            this.dtgCT_BG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCT_BG_CellContentClick);
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(207, 626);
            this.txtMota.Margin = new System.Windows.Forms.Padding(1);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(379, 35);
            this.txtMota.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(24, 629);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 113;
            this.label2.Text = "Mô tả";
            // 
            // btnThemSP
            // 
            this.btnThemSP.AutoSize = true;
            this.btnThemSP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(11, 20);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(1);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(211, 41);
            this.btnThemSP.TabIndex = 112;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(207, 588);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(1);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(379, 35);
            this.txtDonGia.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 590);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 110;
            this.label1.Text = "Đơn giá";
            // 
            // btnThemBG
            // 
            this.btnThemBG.AutoSize = true;
            this.btnThemBG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemBG.ForeColor = System.Drawing.Color.White;
            this.btnThemBG.Location = new System.Drawing.Point(11, 19);
            this.btnThemBG.Margin = new System.Windows.Forms.Padding(1);
            this.btnThemBG.Name = "btnThemBG";
            this.btnThemBG.Size = new System.Drawing.Size(188, 41);
            this.btnThemBG.TabIndex = 108;
            this.btnThemBG.Text = "Thêm báo giá";
            this.btnThemBG.UseVisualStyleBackColor = false;
            this.btnThemBG.Click += new System.EventHandler(this.btnThemBG_Click);
            // 
            // cbNCC
            // 
            this.cbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(207, 503);
            this.cbNCC.Margin = new System.Windows.Forms.Padding(1);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(379, 37);
            this.cbNCC.TabIndex = 107;
            this.cbNCC.SelectedIndexChanged += new System.EventHandler(this.cbNCC_SelectedIndexChanged);
            // 
            // txtMaBG
            // 
            this.txtMaBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBG.Location = new System.Drawing.Point(208, 464);
            this.txtMaBG.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBG.Name = "txtMaBG";
            this.txtMaBG.Size = new System.Drawing.Size(378, 35);
            this.txtMaBG.TabIndex = 106;
            this.txtMaBG.TextChanged += new System.EventHandler(this.txtMaBG_TextChanged);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSanPham.Location = new System.Drawing.Point(24, 551);
            this.lbSanPham.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(136, 31);
            this.lbSanPham.TabIndex = 105;
            this.lbSanPham.Text = "Sản phẩm";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMaNV.Location = new System.Drawing.Point(24, 509);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(136, 31);
            this.lbMaNV.TabIndex = 104;
            this.lbMaNV.Text = "Mã NCC *";
            // 
            // lbMaBG
            // 
            this.lbMaBG.AutoSize = true;
            this.lbMaBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMaBG.Location = new System.Drawing.Point(24, 464);
            this.lbMaBG.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbMaBG.Name = "lbMaBG";
            this.lbMaBG.Size = new System.Drawing.Size(157, 31);
            this.lbMaBG.TabIndex = 103;
            this.lbMaBG.Text = "Mã báo giá*";
            // 
            // cbSanPham
            // 
            this.cbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(207, 549);
            this.cbSanPham.Margin = new System.Windows.Forms.Padding(1);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(379, 37);
            this.cbSanPham.TabIndex = 122;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemBG);
            this.groupBox1.Controls.Add(this.btnSuaBG);
            this.groupBox1.Controls.Add(this.btnXoaBG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(632, 475);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(609, 76);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.btnXoaSP);
            this.groupBox2.Controls.Add(this.btnSuaSP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(629, 584);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(630, 77);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            // 
            // tooltipMaBG
            // 
            this.tooltipMaBG.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(491, 338);
            this.dataGridView1.TabIndex = 125;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(43, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 31);
            this.label3.TabIndex = 126;
            this.label3.Text = "Danh sách báo giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(549, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 127;
            this.label4.Text = "Chi tiết báo giá";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(585, 64);
            this.label5.TabIndex = 128;
            this.label5.Text = "CHỈNH SỬA BÁO GIÁ";
            // 
            // UI_NhapSua_BaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 688);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "UI_NhapSua_BaoGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo giá";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}