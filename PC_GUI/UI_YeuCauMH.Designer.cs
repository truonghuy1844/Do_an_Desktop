namespace PC_GUI
{
    partial class UI_YeuCauMH
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
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.txtSoSP = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoPhanYC = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtMaYC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoc_BoTG = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbtinhTrang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPhongBanYC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimepickerStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimepickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbMaYC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayDuyet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaTriUocTinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.AutoSize = true;
            this.btnTuChoi.Location = new System.Drawing.Point(42, 180);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(264, 48);
            this.btnTuChoi.TabIndex = 81;
            this.btnTuChoi.Text = "Từ chối";
            this.btnTuChoi.UseVisualStyleBackColor = false;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.AutoSize = true;
            this.btnDuyet.Location = new System.Drawing.Point(42, 116);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(264, 41);
            this.btnDuyet.TabIndex = 80;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // txtSoSP
            // 
            this.txtSoSP.Location = new System.Drawing.Point(362, 221);
            this.txtSoSP.Name = "txtSoSP";
            this.txtSoSP.Size = new System.Drawing.Size(370, 31);
            this.txtSoSP.TabIndex = 87;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(42, 43);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(264, 47);
            this.btnHienThi.TabIndex = 82;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 86;
            this.label8.Text = "Số sản phẩm";
            // 
            // txtBoPhanYC
            // 
            this.txtBoPhanYC.Location = new System.Drawing.Point(943, 172);
            this.txtBoPhanYC.Name = "txtBoPhanYC";
            this.txtBoPhanYC.Size = new System.Drawing.Size(364, 31);
            this.txtBoPhanYC.TabIndex = 84;
            this.txtBoPhanYC.TextChanged += new System.EventHandler(this.txtBoPhanYC_TextChanged);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(362, 279);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(371, 31);
            this.txtTinhTrang.TabIndex = 79;
            this.txtTinhTrang.TextChanged += new System.EventHandler(this.txtTinhTrang_TextChanged);
            // 
            // txtMaYC
            // 
            this.txtMaYC.Location = new System.Drawing.Point(363, 169);
            this.txtMaYC.Name = "txtMaYC";
            this.txtMaYC.Size = new System.Drawing.Size(370, 31);
            this.txtMaYC.TabIndex = 78;
            this.txtMaYC.TextChanged += new System.EventHandler(this.txtMaYC_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLoc_BoTG);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.cbtinhTrang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPhongBanYC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datetimepickerStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datetimepickerEnd);
            this.groupBox1.Location = new System.Drawing.Point(214, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(997, 196);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // btnLoc_BoTG
            // 
            this.btnLoc_BoTG.AutoSize = true;
            this.btnLoc_BoTG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc_BoTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc_BoTG.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoc_BoTG.Location = new System.Drawing.Point(625, 128);
            this.btnLoc_BoTG.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc_BoTG.Name = "btnLoc_BoTG";
            this.btnLoc_BoTG.Size = new System.Drawing.Size(199, 37);
            this.btnLoc_BoTG.TabIndex = 22;
            this.btnLoc_BoTG.Text = "Lọc bỏ qua thời gian";
            this.btnLoc_BoTG.UseVisualStyleBackColor = false;
            this.btnLoc_BoTG.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.AutoSize = true;
            this.btnLoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoc.Location = new System.Drawing.Point(257, 128);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(145, 37);
            this.btnLoc.TabIndex = 21;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbtinhTrang
            // 
            this.cbtinhTrang.FormattingEnabled = true;
            this.cbtinhTrang.Location = new System.Drawing.Point(232, 67);
            this.cbtinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbtinhTrang.Name = "cbtinhTrang";
            this.cbtinhTrang.Size = new System.Drawing.Size(215, 33);
            this.cbtinhTrang.TabIndex = 12;
            this.cbtinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbtinhTrang_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(82, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tình trạng";
            // 
            // cbPhongBanYC
            // 
            this.cbPhongBanYC.FormattingEnabled = true;
            this.cbPhongBanYC.Location = new System.Drawing.Point(233, 21);
            this.cbPhongBanYC.Margin = new System.Windows.Forms.Padding(2);
            this.cbPhongBanYC.Name = "cbPhongBanYC";
            this.cbPhongBanYC.Size = new System.Drawing.Size(214, 33);
            this.cbPhongBanYC.TabIndex = 10;
            this.cbPhongBanYC.SelectedIndexChanged += new System.EventHandler(this.cbPhongBanYC_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(82, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bộ phận YC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(514, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đến";
            // 
            // datetimepickerStart
            // 
            this.datetimepickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datetimepickerStart.Location = new System.Drawing.Point(572, 27);
            this.datetimepickerStart.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerStart.Name = "datetimepickerStart";
            this.datetimepickerStart.Size = new System.Drawing.Size(315, 26);
            this.datetimepickerStart.TabIndex = 0;
            this.datetimepickerStart.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.datetimepickerStart.ValueChanged += new System.EventHandler(this.datetimepickerStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(514, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ";
            // 
            // datetimepickerEnd
            // 
            this.datetimepickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datetimepickerEnd.Location = new System.Drawing.Point(572, 74);
            this.datetimepickerEnd.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerEnd.Name = "datetimepickerEnd";
            this.datetimepickerEnd.Size = new System.Drawing.Size(315, 26);
            this.datetimepickerEnd.TabIndex = 1;
            this.datetimepickerEnd.ValueChanged += new System.EventHandler(this.datetimepickerEnd_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 533);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1747, 748);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Tình trạng duyệt";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(751, 172);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(134, 20);
            this.lb.TabIndex = 74;
            this.lb.Text = "Bộ phận yêu cầu";
            // 
            // lbMaYC
            // 
            this.lbMaYC.AutoSize = true;
            this.lbMaYC.Location = new System.Drawing.Point(218, 172);
            this.lbMaYC.Name = "lbMaYC";
            this.lbMaYC.Size = new System.Drawing.Size(95, 20);
            this.lbMaYC.TabIndex = 73;
            this.lbMaYC.Text = "Mã yêu cầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(804, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Ngày duyệt";
            // 
            // txtNgayDuyet
            // 
            this.txtNgayDuyet.Location = new System.Drawing.Point(943, 279);
            this.txtNgayDuyet.Name = "txtNgayDuyet";
            this.txtNgayDuyet.Size = new System.Drawing.Size(364, 31);
            this.txtNgayDuyet.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 91;
            this.label7.Text = "Giá trị ước tính";
            // 
            // txtGiaTriUocTinh
            // 
            this.txtGiaTriUocTinh.Location = new System.Drawing.Point(943, 221);
            this.txtGiaTriUocTinh.Name = "txtGiaTriUocTinh";
            this.txtGiaTriUocTinh.Size = new System.Drawing.Size(364, 31);
            this.txtGiaTriUocTinh.TabIndex = 92;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHienThi);
            this.groupBox2.Controls.Add(this.btnDuyet);
            this.groupBox2.Controls.Add(this.btnTuChoi);
            this.groupBox2.Location = new System.Drawing.Point(1334, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 240);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            // 
            // UI_YeuCauMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtGiaTriUocTinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayDuyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoPhanYC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbMaYC);
            //this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI_YeuCauMH";
            this.Size = new System.Drawing.Size(1800, 1330);
            this.Load += new System.EventHandler(this.UI_YeuCauMH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTuChoi;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.TextBox txtSoSP;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoPhanYC;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtMaYC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbtinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPhongBanYC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimepickerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimepickerEnd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbMaYC;
        private System.Windows.Forms.Button btnLoc_BoTG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayDuyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaTriUocTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}