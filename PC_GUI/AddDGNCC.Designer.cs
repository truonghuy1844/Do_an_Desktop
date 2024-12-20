namespace PC_GUI
{
    partial class AddDGNCC
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDGNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTieuChiDanhGia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(549, 243);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 48);
            this.btnHuy.TabIndex = 66;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(368, 243);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 48);
            this.btnLuu.TabIndex = 65;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 40);
            this.label1.TabIndex = 64;
            this.label1.Text = "THÊM ĐÁNH GIÁ NHÀ CUNG CẤP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Tiêu chí đánh giá:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(235, 183);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(204, 22);
            this.txtMaNCC.TabIndex = 61;
            this.txtMaNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNCC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Mã nhà cung cấp*:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(235, 140);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(204, 22);
            this.txtMaNV.TabIndex = 59;
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Mã nhân viên đánh giá*:";
            // 
            // txtMaDGNCC
            // 
            this.txtMaDGNCC.Location = new System.Drawing.Point(235, 99);
            this.txtMaDGNCC.Name = "txtMaDGNCC";
            this.txtMaDGNCC.Size = new System.Drawing.Size(204, 22);
            this.txtMaDGNCC.TabIndex = 57;
            this.txtMaDGNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDGNCC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã đánh giá nhà cung cấp*:";
            // 
            // comboBoxTieuChiDanhGia
            // 
            this.comboBoxTieuChiDanhGia.FormattingEnabled = true;
            this.comboBoxTieuChiDanhGia.Location = new System.Drawing.Point(686, 94);
            this.comboBoxTieuChiDanhGia.Name = "comboBoxTieuChiDanhGia";
            this.comboBoxTieuChiDanhGia.Size = new System.Drawing.Size(313, 24);
            this.comboBoxTieuChiDanhGia.TabIndex = 70;
            this.comboBoxTieuChiDanhGia.SelectedIndexChanged += new System.EventHandler(this.comboBoxTieuChiDanhGia_SelectedIndexChanged);
            // 
            // AddDGNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 356);
            this.Controls.Add(this.comboBoxTieuChiDanhGia);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDGNCC);
            this.Controls.Add(this.label2);
            this.Name = "AddDGNCC";
            this.Text = "AddDGNCC";
            this.Load += new System.EventHandler(this.AddDGNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDGNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTieuChiDanhGia;
    }
}