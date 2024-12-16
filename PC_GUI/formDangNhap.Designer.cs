namespace PC_GUI
{
    partial class frmdangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangNhap));
            this.txttenDangNhap = new System.Windows.Forms.TextBox();
            this.lbmatKhau = new System.Windows.Forms.Label();
            this.txtmatKhau = new System.Windows.Forms.TextBox();
            this.lbtenDangNhap = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pnDangNhap = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chcbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.pnDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttenDangNhap
            // 
            this.txttenDangNhap.Location = new System.Drawing.Point(42, 224);
            this.txttenDangNhap.Name = "txttenDangNhap";
            this.txttenDangNhap.Size = new System.Drawing.Size(283, 22);
            this.txttenDangNhap.TabIndex = 0;
            // 
            // lbmatKhau
            // 
            this.lbmatKhau.AutoSize = true;
            this.lbmatKhau.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lbmatKhau.Location = new System.Drawing.Point(38, 254);
            this.lbmatKhau.Name = "lbmatKhau";
            this.lbmatKhau.Size = new System.Drawing.Size(89, 24);
            this.lbmatKhau.TabIndex = 1;
            this.lbmatKhau.Text = "Mật khẩu";
            // 
            // txtmatKhau
            // 
            this.txtmatKhau.Location = new System.Drawing.Point(42, 281);
            this.txtmatKhau.Name = "txtmatKhau";
            this.txtmatKhau.PasswordChar = '*';
            this.txtmatKhau.Size = new System.Drawing.Size(283, 22);
            this.txtmatKhau.TabIndex = 1;
            // 
            // lbtenDangNhap
            // 
            this.lbtenDangNhap.AutoSize = true;
            this.lbtenDangNhap.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lbtenDangNhap.Location = new System.Drawing.Point(38, 197);
            this.lbtenDangNhap.Name = "lbtenDangNhap";
            this.lbtenDangNhap.Size = new System.Drawing.Size(137, 24);
            this.lbtenDangNhap.TabIndex = 2;
            this.lbtenDangNhap.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(210)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(93, 367);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(198, 44);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // pnDangNhap
            // 
            this.pnDangNhap.BackColor = System.Drawing.Color.White;
            this.pnDangNhap.Controls.Add(this.chcbHienMatKhau);
            this.pnDangNhap.Controls.Add(this.pictureBox2);
            this.pnDangNhap.Controls.Add(this.txttenDangNhap);
            this.pnDangNhap.Controls.Add(this.label2);
            this.pnDangNhap.Controls.Add(this.label1);
            this.pnDangNhap.Controls.Add(this.lbtenDangNhap);
            this.pnDangNhap.Controls.Add(this.btnDangNhap);
            this.pnDangNhap.Controls.Add(this.lbmatKhau);
            this.pnDangNhap.Controls.Add(this.txtmatKhau);
            this.pnDangNhap.Location = new System.Drawing.Point(445, 31);
            this.pnDangNhap.Name = "pnDangNhap";
            this.pnDangNhap.Size = new System.Drawing.Size(368, 440);
            this.pnDangNhap.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mỗi ngày làm việc là một niềm vui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHÀO MỪNG BẠN TRỞ LẠI!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // chcbHienMatKhau
            // 
            this.chcbHienMatKhau.AutoSize = true;
            this.chcbHienMatKhau.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcbHienMatKhau.Location = new System.Drawing.Point(42, 309);
            this.chcbHienMatKhau.Name = "chcbHienMatKhau";
            this.chcbHienMatKhau.Size = new System.Drawing.Size(148, 22);
            this.chcbHienMatKhau.TabIndex = 2;
            this.chcbHienMatKhau.Text = "Hiển thị mật khẩu";
            this.chcbHienMatKhau.UseVisualStyleBackColor = true;
            this.chcbHienMatKhau.CheckedChanged += new System.EventHandler(this.chcbHienMatKhau_CheckedChanged);
            // 
            // frmdangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 500);
            this.Controls.Add(this.pnDangNhap);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmdangNhap_Load);
            this.pnDangNhap.ResumeLayout(false);
            this.pnDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txttenDangNhap;
        private System.Windows.Forms.Label lbmatKhau;
        private System.Windows.Forms.TextBox txtmatKhau;
        private System.Windows.Forms.Label lbtenDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnDangNhap;
        private System.Windows.Forms.CheckBox chcbHienMatKhau;
    }
}

