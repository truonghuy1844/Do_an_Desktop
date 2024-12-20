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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dataGridViewDSNV
            // 
            this.dataGridViewDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNV.Location = new System.Drawing.Point(10, 331);
            this.dataGridViewDSNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewDSNV.Name = "dataGridViewDSNV";
            this.dataGridViewDSNV.RowHeadersWidth = 51;
            this.dataGridViewDSNV.RowTemplate.Height = 24;
            this.dataGridViewDSNV.Size = new System.Drawing.Size(869, 344);
            this.dataGridViewDSNV.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(133, 27);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(311, 20);
            this.txtMaNV.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(454, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 34);
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
            this.groupBox1.Location = new System.Drawing.Point(160, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(569, 164);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(454, 74);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(98, 34);
            this.btnResetFilter.TabIndex = 30;
            this.btnResetFilter.Text = "Reset bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(133, 88);
            this.comboBoxPhongBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(311, 21);
            this.comboBoxPhongBan.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lọc theo phòng ban:";
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(133, 60);
            this.comboBoxChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(208, 21);
            this.comboBoxChucVu.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lọc theo chức vụ:";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(872, 241);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(232, 66);
            this.btnLoad.TabIndex = 27;
            this.btnLoad.Text = "Load/ Refresh";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(602, 241);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(232, 66);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "- Xóa nhân viên";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(318, 241);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(252, 66);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa nhân viên";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(32, 241);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(252, 66);
            this.btnThemNV.TabIndex = 24;
            this.btnThemNV.Text = "+ Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDSNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "QLNV";
            this.Size = new System.Drawing.Size(900, 692);
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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