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
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.btnXoaNV1 = new System.Windows.Forms.Button();
            this.btnThemNV1 = new System.Windows.Forms.Button();
            this.btnSuaNV1 = new System.Windows.Forms.Button();
            this.comboBoxChucVu1 = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDSNV
            // 
            this.dataGridViewDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNV.Location = new System.Drawing.Point(13, 407);
            this.dataGridViewDSNV.Name = "dataGridViewDSNV";
            this.dataGridViewDSNV.RowHeadersWidth = 51;
            this.dataGridViewDSNV.RowTemplate.Height = 24;
            this.dataGridViewDSNV.Size = new System.Drawing.Size(1159, 423);
            this.dataGridViewDSNV.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(177, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(413, 22);
            this.txtMaNV.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(606, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 42);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Tìm kiếm nhân viên";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLoad1);
            this.groupBox1.Controls.Add(this.btnXoaNV1);
            this.groupBox1.Controls.Add(this.btnThemNV1);
            this.groupBox1.Controls.Add(this.btnSuaNV1);
            this.groupBox1.Controls.Add(this.comboBoxChucVu1);
            this.groupBox1.Controls.Add(this.btnResetFilter);
            this.groupBox1.Controls.Add(this.comboBoxPhongBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(213, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 231);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnLoad1
            // 
            this.btnLoad1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad1.ForeColor = System.Drawing.Color.White;
            this.btnLoad1.Location = new System.Drawing.Point(579, 158);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(169, 42);
            this.btnLoad1.TabIndex = 35;
            this.btnLoad1.Text = "Load/ Refresh";
            this.btnLoad1.UseVisualStyleBackColor = false;
            this.btnLoad1.Click += new System.EventHandler(this.btnLoad1_Click);
            // 
            // btnXoaNV1
            // 
            this.btnXoaNV1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaNV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV1.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV1.Location = new System.Drawing.Point(398, 158);
            this.btnXoaNV1.Name = "btnXoaNV1";
            this.btnXoaNV1.Size = new System.Drawing.Size(169, 42);
            this.btnXoaNV1.TabIndex = 34;
            this.btnXoaNV1.Text = "- Xóa nhân viên";
            this.btnXoaNV1.UseVisualStyleBackColor = false;
            this.btnXoaNV1.Click += new System.EventHandler(this.btnXoaNV1_Click);
            // 
            // btnThemNV1
            // 
            this.btnThemNV1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemNV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV1.ForeColor = System.Drawing.Color.White;
            this.btnThemNV1.Location = new System.Drawing.Point(19, 158);
            this.btnThemNV1.Name = "btnThemNV1";
            this.btnThemNV1.Size = new System.Drawing.Size(182, 42);
            this.btnThemNV1.TabIndex = 32;
            this.btnThemNV1.Text = "+ Thêm nhân viên";
            this.btnThemNV1.UseVisualStyleBackColor = false;
            this.btnThemNV1.Click += new System.EventHandler(this.btnThemNV1_Click);
            // 
            // btnSuaNV1
            // 
            this.btnSuaNV1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSuaNV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV1.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV1.Location = new System.Drawing.Point(210, 158);
            this.btnSuaNV1.Name = "btnSuaNV1";
            this.btnSuaNV1.Size = new System.Drawing.Size(182, 42);
            this.btnSuaNV1.TabIndex = 33;
            this.btnSuaNV1.Text = "Sửa thông tin";
            this.btnSuaNV1.UseVisualStyleBackColor = false;
            this.btnSuaNV1.Click += new System.EventHandler(this.btnSuaNV1_Click);
            // 
            // comboBoxChucVu1
            // 
            this.comboBoxChucVu1.FormattingEnabled = true;
            this.comboBoxChucVu1.Location = new System.Drawing.Point(177, 70);
            this.comboBoxChucVu1.Name = "comboBoxChucVu1";
            this.comboBoxChucVu1.Size = new System.Drawing.Size(412, 24);
            this.comboBoxChucVu1.TabIndex = 31;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(606, 91);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(130, 42);
            this.btnResetFilter.TabIndex = 30;
            this.btnResetFilter.Text = "Reset bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(177, 109);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(413, 24);
            this.comboBoxPhongBan.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lọc theo phòng ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDSNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QLNV";
            this.Size = new System.Drawing.Size(1200, 851);
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
        private System.Windows.Forms.ComboBox comboBoxChucVu1;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.Button btnXoaNV1;
        private System.Windows.Forms.Button btnThemNV1;
        private System.Windows.Forms.Button btnSuaNV1;
    }
}