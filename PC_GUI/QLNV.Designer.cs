namespace PC_GUI
{
    partial class QLNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDSNV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dataGridViewDSNV
            // 
            this.dataGridViewDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNV.Location = new System.Drawing.Point(0, 96);
            this.dataGridViewDSNV.Name = "dataGridViewDSNV";
            this.dataGridViewDSNV.RowHeadersWidth = 51;
            this.dataGridViewDSNV.RowTemplate.Height = 24;
            this.dataGridViewDSNV.Size = new System.Drawing.Size(997, 344);
            this.dataGridViewDSNV.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(286, 30);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(266, 30);
            this.txtMaNV.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(676, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 42);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Tìm kiếm nhân viên";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnResetFilter);
            this.groupBox1.Controls.Add(this.comboBoxPhongBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxChucVu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 179);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.Color.Transparent;
            this.btnResetFilter.Location = new System.Drawing.Point(676, 109);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(212, 42);
            this.btnResetFilter.TabIndex = 30;
            this.btnResetFilter.Text = "Reset bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(286, 129);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(266, 33);
            this.comboBoxPhongBan.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lọc theo phòng ban:";
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(286, 78);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(266, 33);
            this.comboBoxChucVu.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lọc theo chức vụ:";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoad.Location = new System.Drawing.Point(787, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(187, 42);
            this.btnLoad.TabIndex = 27;
            this.btnLoad.Text = "Load/ Refresh";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(532, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 42);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "- Xóa nhân viên";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(277, 39);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(187, 42);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa nhân viên";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemNV.Location = new System.Drawing.Point(22, 39);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(187, 42);
            this.btnThemNV.TabIndex = 24;
            this.btnThemNV.Text = "+ Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 70);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThemNV);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(0, 665);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 106);
            this.panel3.TabIndex = 28;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDSNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "QLNV";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDSNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}