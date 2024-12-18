namespace PC_GUI
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTT = new System.Windows.Forms.DataGridView();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.btnThuchien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(688, 740);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 44);
            this.btnLuu.TabIndex = 65;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(688, 250);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(150, 44);
            this.btnTim.TabIndex = 63;
            this.btnTim.Text = "Tìm hoá đơn";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(446, 740);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(150, 44);
            this.btnCapnhat.TabIndex = 61;
            this.btnCapnhat.Text = "Cập nhật ";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 237);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 49;
            this.dateTimePicker1.Value = new System.DateTime(2024, 12, 9, 22, 17, 11, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày thanh toán ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã hóa đơn ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã thanh toán ";
            // 
            // dataGridViewTT
            // 
            this.dataGridViewTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTT.Location = new System.Drawing.Point(23, 328);
            this.dataGridViewTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTT.Name = "dataGridViewTT";
            this.dataGridViewTT.RowHeadersWidth = 82;
            this.dataGridViewTT.RowTemplate.Height = 33;
            this.dataGridViewTT.Size = new System.Drawing.Size(1332, 352);
            this.dataGridViewTT.TabIndex = 66;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(212, 58);
            this.txtMaTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(274, 31);
            this.txtMaTT.TabIndex = 67;
            this.txtMaTT.TextChanged += new System.EventHandler(this.txtMaTT_TextChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(212, 154);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(274, 31);
            this.txtMaHD.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tổng tiền thanh toán";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Trạng thái ";
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(868, 60);
            this.txtSotien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(274, 31);
            this.txtSotien.TabIndex = 71;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(868, 146);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(274, 31);
            this.txtTrangthai.TabIndex = 72;
            // 
            // btnThuchien
            // 
            this.btnThuchien.Location = new System.Drawing.Point(868, 252);
            this.btnThuchien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(256, 40);
            this.btnThuchien.TabIndex = 74;
            this.btnThuchien.Text = "Thực hiện thanh toán";
            this.btnThuchien.UseVisualStyleBackColor = true;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1259);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.dataGridViewTT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Thanhtoan";
            this.Text = "Thanhtoan";
            this.Load += new System.EventHandler(this.Thanhtoan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTT;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Button btnThuchien;
    }
}