﻿namespace PC_GUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTuyChinhBG = new System.Windows.Forms.Button();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtNgayBG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaYC = new System.Windows.Forms.Label();
            this.txtMaBG = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocKoTG = new System.Windows.Forms.Button();
            this.cbbLocSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbLoc_NCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimepickerEnd = new System.Windows.Forms.DateTimePicker();
            this.datetimepickerStart = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1659, 561);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTuyChinhBG
            // 
            this.btnTuyChinhBG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTuyChinhBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuyChinhBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyChinhBG.ForeColor = System.Drawing.Color.White;
            this.btnTuyChinhBG.Location = new System.Drawing.Point(1221, 95);
            this.btnTuyChinhBG.Name = "btnTuyChinhBG";
            this.btnTuyChinhBG.Size = new System.Drawing.Size(238, 54);
            this.btnTuyChinhBG.TabIndex = 90;
            this.btnTuyChinhBG.Text = "Tùy chỉnh báo giá";
            this.btnTuyChinhBG.UseVisualStyleBackColor = false;
            this.btnTuyChinhBG.Click += new System.EventHandler(this.btnTuyChinhBG_Click);
            // 
            // txtNCC
            // 
            this.txtNCC.BackColor = System.Drawing.Color.White;
            this.txtNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCC.Location = new System.Drawing.Point(438, 98);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(630, 35);
            this.txtNCC.TabIndex = 89;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(255, 98);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(160, 29);
            this.lb.TabIndex = 83;
            this.lb.Text = "Nhà cung cấp";
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.White;
            this.btnHienThi.Location = new System.Drawing.Point(1221, 23);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(238, 52);
            this.btnHienThi.TabIndex = 88;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtNgayBG
            // 
            this.txtNgayBG.BackColor = System.Drawing.Color.White;
            this.txtNgayBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayBG.Location = new System.Drawing.Point(438, 166);
            this.txtNgayBG.Name = "txtNgayBG";
            this.txtNgayBG.Size = new System.Drawing.Size(630, 35);
            this.txtNgayBG.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ngày báo giá";
            // 
            // lbMaYC
            // 
            this.lbMaYC.AutoSize = true;
            this.lbMaYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaYC.Location = new System.Drawing.Point(255, 31);
            this.lbMaYC.Name = "lbMaYC";
            this.lbMaYC.Size = new System.Drawing.Size(132, 29);
            this.lbMaYC.TabIndex = 82;
            this.lbMaYC.Text = "Mã báo giá";
            // 
            // txtMaBG
            // 
            this.txtMaBG.BackColor = System.Drawing.Color.White;
            this.txtMaBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBG.Location = new System.Drawing.Point(438, 27);
            this.txtMaBG.Name = "txtMaBG";
            this.txtMaBG.Size = new System.Drawing.Size(630, 35);
            this.txtMaBG.TabIndex = 86;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 680);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1653, 189);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc báo giá";
            // 
            // btnLocKoTG
            // 
            this.btnLocKoTG.AutoSize = true;
            this.btnLocKoTG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLocKoTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocKoTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocKoTG.ForeColor = System.Drawing.Color.White;
            this.btnLocKoTG.Location = new System.Drawing.Point(1055, 73);
            this.btnLocKoTG.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocKoTG.Name = "btnLocKoTG";
            this.btnLocKoTG.Size = new System.Drawing.Size(259, 54);
            this.btnLocKoTG.TabIndex = 110;
            this.btnLocKoTG.Text = "Lọc bỏ thời gian";
            this.btnLocKoTG.UseVisualStyleBackColor = false;
            this.btnLocKoTG.Click += new System.EventHandler(this.btnLocKoTG_Click);
            // 
            // cbbLocSP
            // 
            this.cbbLocSP.AllowDrop = true;
            this.cbbLocSP.BackColor = System.Drawing.Color.White;
            this.cbbLocSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocSP.DropDownWidth = 150;
            this.cbbLocSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLocSP.FormattingEnabled = true;
            this.cbbLocSP.ItemHeight = 29;
            this.cbbLocSP.Location = new System.Drawing.Point(435, 81);
            this.cbbLocSP.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLocSP.MaxDropDownItems = 5;
            this.cbbLocSP.Name = "cbbLocSP";
            this.cbbLocSP.Size = new System.Drawing.Size(361, 37);
            this.cbbLocSP.Sorted = true;
            this.cbbLocSP.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 108;
            this.label5.Text = "Sản phẩm";
            // 
            // btnLoc
            // 
            this.btnLoc.AutoSize = true;
            this.btnLoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(1347, 73);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(238, 54);
            this.btnLoc.TabIndex = 107;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbLoc_NCC
            // 
            this.cbLoc_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoc_NCC.FormattingEnabled = true;
            this.cbLoc_NCC.Location = new System.Drawing.Point(438, 28);
            this.cbLoc_NCC.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoc_NCC.Name = "cbLoc_NCC";
            this.cbLoc_NCC.Size = new System.Drawing.Size(358, 37);
            this.cbLoc_NCC.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 105;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1215, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 104;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(870, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 103;
            this.label2.Text = "Từ";
            // 
            // datetimepickerEnd
            // 
            this.datetimepickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepickerEnd.Location = new System.Drawing.Point(1299, 28);
            this.datetimepickerEnd.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerEnd.Name = "datetimepickerEnd";
            this.datetimepickerEnd.Size = new System.Drawing.Size(286, 35);
            this.datetimepickerEnd.TabIndex = 102;
            this.datetimepickerEnd.ValueChanged += new System.EventHandler(this.datetimepickerEnd_ValueChanged);
            // 
            // datetimepickerStart
            // 
            this.datetimepickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepickerStart.Location = new System.Drawing.Point(924, 26);
            this.datetimepickerStart.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerStart.Name = "datetimepickerStart";
            this.datetimepickerStart.Size = new System.Drawing.Size(272, 35);
            this.datetimepickerStart.TabIndex = 101;
            this.datetimepickerStart.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.datetimepickerStart.ValueChanged += new System.EventHandler(this.datetimepickerStart_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNCC);
            this.panel1.Controls.Add(this.btnTuyChinhBG);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.txtNgayBG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbMaYC);
            this.panel1.Controls.Add(this.txtMaBG);
            this.panel1.Location = new System.Drawing.Point(3, 877);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1653, 220);
            this.panel1.TabIndex = 102;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1658, 100);
            this.panel3.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(694, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 62);
            this.label9.TabIndex = 0;
            this.label9.Text = "BÁO GIÁ";
            // 
            // UI_View_BaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UI_View_BaoGia";
            this.Size = new System.Drawing.Size(1660, 1216);
            this.Load += new System.EventHandler(this.UI_View_BaoGia_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTuyChinhBG;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtNgayBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaYC;
        private System.Windows.Forms.TextBox txtMaBG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLocKoTG;
        private System.Windows.Forms.ComboBox cbbLocSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbLoc_NCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimepickerEnd;
        private System.Windows.Forms.DateTimePicker datetimepickerStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
    }
}