﻿namespace PC_GUI
{
    partial class XoaKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLoaiKho = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(35, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 73);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(216, 28);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(312, 22);
            this.txtTim.TabIndex = 55;
            this.txtTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim_KeyPress);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(543, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(104, 26);
            this.btnTim.TabIndex = 56;
            this.btnTim.Text = "Nhập";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Nhập mã kho cần xóa:";
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(479, 186);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(219, 22);
            this.txtSucChua.TabIndex = 81;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Tomato;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(389, 304);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 48);
            this.btnHuy.TabIndex = 80;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(213, 304);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 48);
            this.btnXoa.TabIndex = 79;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 78;
            this.label1.Text = "XÓA KHO";
            // 
            // comboBoxLoaiKho
            // 
            this.comboBoxLoaiKho.FormattingEnabled = true;
            this.comboBoxLoaiKho.Location = new System.Drawing.Point(479, 226);
            this.comboBoxLoaiKho.Name = "comboBoxLoaiKho";
            this.comboBoxLoaiKho.Size = new System.Drawing.Size(219, 24);
            this.comboBoxLoaiKho.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Loại kho*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 75;
            this.label7.Text = "Sức chứa*:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(117, 253);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(229, 22);
            this.txtDiaChi.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(117, 209);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(229, 22);
            this.txtTenKho.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tên kho*:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(117, 166);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(229, 22);
            this.txtMaKho.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Mã kho*:";
            // 
            // XoaKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLoaiKho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.label2);
            this.Name = "XoaKho";
            this.Text = "XoaKho";
            this.Load += new System.EventHandler(this.XoaKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLoaiKho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label2;
    }
}