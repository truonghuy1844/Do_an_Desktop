namespace PC_GUI
{
    partial class QLDGNCC
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
            this.lbTT = new System.Windows.Forms.Label();
            this.dataGridViewDGNCC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.comboBoxMucDo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewNVDG = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBoxTieuChi = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDGNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNVDG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Location = new System.Drawing.Point(58, 212);
            this.lbTT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(327, 25);
            this.lbTT.TabIndex = 3;
            this.lbTT.Text = "Thông tin đánh giá nhà cung cấp";
            this.lbTT.UseWaitCursor = true;
            // 
            // dataGridViewDGNCC
            // 
            this.dataGridViewDGNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDGNCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDGNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDGNCC.Location = new System.Drawing.Point(63, 245);
            this.dataGridViewDGNCC.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridViewDGNCC.Name = "dataGridViewDGNCC";
            this.dataGridViewDGNCC.RowHeadersWidth = 51;
            this.dataGridViewDGNCC.RowTemplate.Height = 24;
            this.dataGridViewDGNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDGNCC.Size = new System.Drawing.Size(937, 736);
            this.dataGridViewDGNCC.TabIndex = 2;
            this.dataGridViewDGNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDGNCC_CellClick);
            this.dataGridViewDGNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDGNCC_CellClick);
            this.dataGridViewDGNCC.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDGNCC_CellDoubleClick);
            this.dataGridViewDGNCC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDGNCC_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 1058);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hiển thị theo:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(1851, 1130);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(336, 31);
            this.dateTimePickerFrom.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1857, 1064);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Từ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(396, 1602);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1384, 166);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý thông tin đánh giá nhà cung cấp";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Olive;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(1024, 55);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(254, 66);
            this.btnThongKe.TabIndex = 32;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(700, 55);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(254, 66);
            this.btnLoad.TabIndex = 31;
            this.btnLoad.Text = "Load/ Refresh";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(378, 55);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(254, 66);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "- Xóa đánh giá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(48, 55);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(273, 66);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "+ Thêm đánh giá";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1940, 1408);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(177, 36);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(418, 1411);
            this.txtTim.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(966, 31);
            this.txtTim.TabIndex = 32;
            // 
            // comboBoxMucDo
            // 
            this.comboBoxMucDo.FormattingEnabled = true;
            this.comboBoxMucDo.Location = new System.Drawing.Point(1420, 1091);
            this.comboBoxMucDo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBoxMucDo.Name = "comboBoxMucDo";
            this.comboBoxMucDo.Size = new System.Drawing.Size(157, 33);
            this.comboBoxMucDo.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1415, 1058);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mức độ đánh giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 1362);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(670, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tra cứu theo mã đánh giá, mã nhà cung cấp, mã nhân viên đánh giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1059, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Thông tin nhà cung cấp";
            this.label8.UseWaitCursor = true;
            // 
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Location = new System.Drawing.Point(1048, 245);
            this.dataGridViewNCC.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.RowHeadersWidth = 51;
            this.dataGridViewNCC.RowTemplate.Height = 24;
            this.dataGridViewNCC.Size = new System.Drawing.Size(723, 330);
            this.dataGridViewNCC.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1059, 606);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Thông tin nhân viên đánh giá";
            this.label9.UseWaitCursor = true;
            // 
            // dataGridViewNVDG
            // 
            this.dataGridViewNVDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNVDG.Location = new System.Drawing.Point(1057, 639);
            this.dataGridViewNVDG.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridViewNVDG.Name = "dataGridViewNVDG";
            this.dataGridViewNVDG.RowHeadersWidth = 51;
            this.dataGridViewNVDG.RowTemplate.Height = 24;
            this.dataGridViewNVDG.Size = new System.Drawing.Size(714, 342);
            this.dataGridViewNVDG.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1857, 1206);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Đến:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(1851, 1255);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(336, 31);
            this.dateTimePickerTo.TabIndex = 41;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(209, 1058);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(270, 59);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Reset bộ lọc";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(861, 1058);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "Tiêu chí đánh giá:";
            // 
            // checkedListBoxTieuChi
            // 
            this.checkedListBoxTieuChi.FormattingEnabled = true;
            this.checkedListBoxTieuChi.Location = new System.Drawing.Point(866, 1091);
            this.checkedListBoxTieuChi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkedListBoxTieuChi.Name = "checkedListBoxTieuChi";
            this.checkedListBoxTieuChi.Size = new System.Drawing.Size(391, 88);
            this.checkedListBoxTieuChi.TabIndex = 45;
            this.checkedListBoxTieuChi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxTieuChi_ItemCheck);
            // 
            // QLDGNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBoxTieuChi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewNVDG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewNCC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMucDo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.dataGridViewDGNCC);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QLDGNCC";
            this.Size = new System.Drawing.Size(1800, 1330);
            this.Load += new System.EventHandler(this.QLDGNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDGNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNVDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.DataGridView dataGridViewDGNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox comboBoxMucDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewNVDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListBoxTieuChi;
        private System.Windows.Forms.Button btnThongKe;
    }
}