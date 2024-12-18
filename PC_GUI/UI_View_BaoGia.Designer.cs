namespace PC_GUI
{
    partial class UI_View_BaoGia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbMaYC = new System.Windows.Forms.Label();
            this.cbbLocSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtNgayBG = new System.Windows.Forms.TextBox();
            this.txtMaBG = new System.Windows.Forms.TextBox();
            this.cbLoc_NCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimepickerEnd = new System.Windows.Forms.DateTimePicker();
            this.datetimepickerStart = new System.Windows.Forms.DateTimePicker();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocKoTG = new System.Windows.Forms.Button();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.btnTuyChinhBG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1759, 874);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Ngày báo giá";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(359, 159);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(112, 20);
            this.lb.TabIndex = 70;
            this.lb.Text = "Nhà cung cấp";
            // 
            // lbMaYC
            // 
            this.lbMaYC.AutoSize = true;
            this.lbMaYC.Location = new System.Drawing.Point(359, 101);
            this.lbMaYC.Name = "lbMaYC";
            this.lbMaYC.Size = new System.Drawing.Size(91, 20);
            this.lbMaYC.TabIndex = 69;
            this.lbMaYC.Text = "Mã báo giá";
            // 
            // cbbLocSP
            // 
            this.cbbLocSP.AllowDrop = true;
            this.cbbLocSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocSP.DropDownWidth = 150;
            this.cbbLocSP.FormattingEnabled = true;
            this.cbbLocSP.ItemHeight = 20;
            this.cbbLocSP.Location = new System.Drawing.Point(162, 64);
            this.cbbLocSP.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLocSP.MaxDropDownItems = 5;
            this.cbbLocSP.Name = "cbbLocSP";
            this.cbbLocSP.Size = new System.Drawing.Size(242, 28);
            this.cbbLocSP.Sorted = true;
            this.cbbLocSP.TabIndex = 23;
            this.cbbLocSP.SelectedIndexChanged += new System.EventHandler(this.cbbLocSP_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sản phẩm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.AutoSize = true;
            this.btnLoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(835, 28);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(205, 35);
            this.btnLoc.TabIndex = 21;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtNgayBG
            // 
            this.txtNgayBG.Location = new System.Drawing.Point(539, 211);
            this.txtNgayBG.Name = "txtNgayBG";
            this.txtNgayBG.Size = new System.Drawing.Size(629, 31);
            this.txtNgayBG.TabIndex = 76;
            // 
            // txtMaBG
            // 
            this.txtMaBG.Location = new System.Drawing.Point(539, 101);
            this.txtMaBG.Name = "txtMaBG";
            this.txtMaBG.Size = new System.Drawing.Size(629, 31);
            this.txtMaBG.TabIndex = 75;
            // 
            // cbLoc_NCC
            // 
            this.cbLoc_NCC.FormattingEnabled = true;
            this.cbLoc_NCC.Location = new System.Drawing.Point(162, 28);
            this.cbLoc_NCC.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoc_NCC.Name = "cbLoc_NCC";
            this.cbLoc_NCC.Size = new System.Drawing.Size(242, 28);
            this.cbLoc_NCC.TabIndex = 10;
            this.cbLoc_NCC.SelectedIndexChanged += new System.EventHandler(this.cbLoc_NCC_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ";
            // 
            // datetimepickerEnd
            // 
            this.datetimepickerEnd.Location = new System.Drawing.Point(506, 64);
            this.datetimepickerEnd.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerEnd.Name = "datetimepickerEnd";
            this.datetimepickerEnd.Size = new System.Drawing.Size(288, 26);
            this.datetimepickerEnd.TabIndex = 1;
            this.datetimepickerEnd.ValueChanged += new System.EventHandler(this.datetimepickerEnd_ValueChanged);
            // 
            // datetimepickerStart
            // 
            this.datetimepickerStart.Location = new System.Drawing.Point(506, 28);
            this.datetimepickerStart.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerStart.Name = "datetimepickerStart";
            this.datetimepickerStart.Size = new System.Drawing.Size(288, 26);
            this.datetimepickerStart.TabIndex = 0;
            this.datetimepickerStart.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.datetimepickerStart.ValueChanged += new System.EventHandler(this.datetimepickerStart_ValueChanged);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(1244, 93);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(271, 49);
            this.btnHienThi.TabIndex = 77;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLocKoTG);
            this.groupBox1.Controls.Add(this.cbbLocSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.cbLoc_NCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datetimepickerEnd);
            this.groupBox1.Controls.Add(this.datetimepickerStart);
            this.groupBox1.Location = new System.Drawing.Point(261, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1296, 129);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // btnLocKoTG
            // 
            this.btnLocKoTG.AutoSize = true;
            this.btnLocKoTG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLocKoTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocKoTG.ForeColor = System.Drawing.Color.White;
            this.btnLocKoTG.Location = new System.Drawing.Point(835, 64);
            this.btnLocKoTG.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocKoTG.Name = "btnLocKoTG";
            this.btnLocKoTG.Size = new System.Drawing.Size(205, 35);
            this.btnLocKoTG.TabIndex = 24;
            this.btnLocKoTG.Text = "Lọc bỏ thời gian";
            this.btnLocKoTG.UseVisualStyleBackColor = false;
            this.btnLocKoTG.Click += new System.EventHandler(this.btnLocKoTG_Click);
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(539, 156);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(629, 31);
            this.txtNCC.TabIndex = 80;
            // 
            // btnTuyChinhBG
            // 
            this.btnTuyChinhBG.Location = new System.Drawing.Point(1244, 154);
            this.btnTuyChinhBG.Name = "btnTuyChinhBG";
            this.btnTuyChinhBG.Size = new System.Drawing.Size(271, 50);
            this.btnTuyChinhBG.TabIndex = 81;
            this.btnTuyChinhBG.Text = "Tùy chỉnh báo giá";
            this.btnTuyChinhBG.UseVisualStyleBackColor = false;
            this.btnTuyChinhBG.Click += new System.EventHandler(this.btnTuyChinhBG_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTuyChinhBG);
            this.panel1.Controls.Add(this.txtNCC);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.txtNgayBG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbMaYC);
            this.panel1.Controls.Add(this.txtMaBG);
            this.panel1.Location = new System.Drawing.Point(1, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 182);
            this.panel1.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(2, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 70);
            this.panel2.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(482, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "QUẢN LÝ BÁO GIÁ";
            // 
            // UI_View_BaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTuyChinhBG);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI_View_BaoGia";
            this.Size = new System.Drawing.Size(1800, 1330);
            this.Load += new System.EventHandler(this.UI_View_BaoGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbMaYC;
        private System.Windows.Forms.ComboBox cbbLocSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtNgayBG;
        private System.Windows.Forms.TextBox txtMaBG;
        private System.Windows.Forms.ComboBox cbLoc_NCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimepickerEnd;
        private System.Windows.Forms.DateTimePicker datetimepickerStart;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Button btnLocKoTG;
        private System.Windows.Forms.Button btnTuyChinhBG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}