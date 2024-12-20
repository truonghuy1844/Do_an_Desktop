namespace PC_GUI
{
    partial class QLKho
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua1 = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSucChua = new System.Windows.Forms.ComboBox();
            this.comboBoxLoaiKho = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDSKho = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(42, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 61);
            this.panel3.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(344, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 48);
            this.label4.TabIndex = 20;
            this.label4.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // btnSua1
            // 
            this.btnSua1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua1.ForeColor = System.Drawing.Color.White;
            this.btnSua1.Location = new System.Drawing.Point(202, 7);
            this.btnSua1.Margin = new System.Windows.Forms.Padding(1);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(143, 46);
            this.btnSua1.TabIndex = 37;
            this.btnSua1.Text = "Sửa thông tin";
            this.btnSua1.UseVisualStyleBackColor = false;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem1.ForeColor = System.Drawing.Color.White;
            this.btnThem1.Location = new System.Drawing.Point(27, 7);
            this.btnThem1.Margin = new System.Windows.Forms.Padding(1);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(143, 46);
            this.btnThem1.TabIndex = 36;
            this.btnThem1.Text = "+ Thêm kho";
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa1.ForeColor = System.Drawing.Color.White;
            this.btnXoa1.Location = new System.Drawing.Point(381, 7);
            this.btnXoa1.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(143, 46);
            this.btnXoa1.TabIndex = 38;
            this.btnXoa1.Text = "- Xóa kho";
            this.btnXoa1.UseVisualStyleBackColor = false;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnLoad1
            // 
            this.btnLoad1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad1.ForeColor = System.Drawing.Color.White;
            this.btnLoad1.Location = new System.Drawing.Point(567, 7);
            this.btnLoad1.Margin = new System.Windows.Forms.Padding(1);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(143, 46);
            this.btnLoad1.TabIndex = 39;
            this.btnLoad1.Text = "Load/ Refresh";
            this.btnLoad1.UseVisualStyleBackColor = false;
            this.btnLoad1.Click += new System.EventHandler(this.btnLoad1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnLoad1);
            this.panel2.Controls.Add(this.btnXoa1);
            this.panel2.Controls.Add(this.btnThem1);
            this.panel2.Controls.Add(this.btnSua1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.panel2.Location = new System.Drawing.Point(195, 689);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 66);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnResetFilter);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxSucChua);
            this.panel1.Controls.Add(this.comboBoxLoaiKho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(42, 448);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 226);
            this.panel1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nhập từ khóa để tìm kiếm";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.Location = new System.Drawing.Point(867, 87);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(1);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(116, 47);
            this.btnResetFilter.TabIndex = 33;
            this.btnResetFilter.Text = "Reset bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(53, 61);
            this.txtTim.Margin = new System.Windows.Forms.Padding(1);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(753, 24);
            this.txtTim.TabIndex = 21;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(867, 29);
            this.btnTim.Margin = new System.Windows.Forms.Padding(1);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 33);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sức chứa";
            // 
            // comboBoxSucChua
            // 
            this.comboBoxSucChua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSucChua.FormattingEnabled = true;
            this.comboBoxSucChua.Location = new System.Drawing.Point(433, 147);
            this.comboBoxSucChua.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxSucChua.Name = "comboBoxSucChua";
            this.comboBoxSucChua.Size = new System.Drawing.Size(229, 26);
            this.comboBoxSucChua.TabIndex = 31;
            // 
            // comboBoxLoaiKho
            // 
            this.comboBoxLoaiKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLoaiKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiKho.FormattingEnabled = true;
            this.comboBoxLoaiKho.Location = new System.Drawing.Point(53, 147);
            this.comboBoxLoaiKho.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxLoaiKho.Name = "comboBoxLoaiKho";
            this.comboBoxLoaiKho.Size = new System.Drawing.Size(263, 26);
            this.comboBoxLoaiKho.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Loại kho";
            // 
            // dataGridViewDSKho
            // 
            this.dataGridViewDSKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSKho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDSKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSKho.Location = new System.Drawing.Point(42, 95);
            this.dataGridViewDSKho.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewDSKho.Name = "dataGridViewDSKho";
            this.dataGridViewDSKho.RowHeadersWidth = 51;
            this.dataGridViewDSKho.RowTemplate.Height = 24;
            this.dataGridViewDSKho.Size = new System.Drawing.Size(1009, 334);
            this.dataGridViewDSKho.TabIndex = 0;
            // 
            // QLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDSKho);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "QLKho";
            this.Size = new System.Drawing.Size(1107, 778);
            this.Load += new System.EventHandler(this.QLKho_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua1;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSucChua;
        private System.Windows.Forms.ComboBox comboBoxLoaiKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDSKho;
    }
}