﻿namespace PC_GUI
{
    partial class Thanhtoan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.btnThuchien = new System.Windows.Forms.Button();
            this.txtNgayTT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày thanh toán ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã hóa đơn ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã thanh toán ";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(133, 75);
            this.txtMaTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(139, 20);
            this.txtMaTT.TabIndex = 67;
            this.txtMaTT.TextChanged += new System.EventHandler(this.txtMaTT_TextChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(133, 115);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(139, 20);
            this.txtMaHD.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(293, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tổng tiền thanh toán";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(325, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Trạng thái ";
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(451, 75);
            this.txtSotien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(139, 20);
            this.txtSotien.TabIndex = 71;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(451, 114);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(139, 20);
            this.txtTrangthai.TabIndex = 72;
            // 
            // btnThuchien
            // 
            this.btnThuchien.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThuchien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuchien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuchien.ForeColor = System.Drawing.Color.White;
            this.btnThuchien.Location = new System.Drawing.Point(328, 156);
            this.btnThuchien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(261, 35);
            this.btnThuchien.TabIndex = 74;
            this.btnThuchien.Text = "Thanh toán";
            this.btnThuchien.UseVisualStyleBackColor = false;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // txtNgayTT
            // 
            this.txtNgayTT.Location = new System.Drawing.Point(133, 156);
            this.txtNgayTT.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayTT.Name = "txtNgayTT";
            this.txtNgayTT.Size = new System.Drawing.Size(140, 20);
            this.txtNgayTT.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 33);
            this.label6.TabIndex = 76;
            this.label6.Text = "THANH TOÁN";
            // 
            // Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 219);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNgayTT);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Thanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.Thanhtoan_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Button btnThuchien;
        private System.Windows.Forms.TextBox txtNgayTT;
        private System.Windows.Forms.Label label6;
    }
}