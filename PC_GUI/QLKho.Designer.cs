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
            this.dataGridViewDSKho = new System.Windows.Forms.DataGridView();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSucChua = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLoaiKho = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnSua1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKho)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDSKho
            // 
            this.dataGridViewDSKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSKho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDSKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSKho.Location = new System.Drawing.Point(3, 72);
            this.dataGridViewDSKho.Name = "dataGridViewDSKho";
            this.dataGridViewDSKho.RowHeadersWidth = 51;
            this.dataGridViewDSKho.RowTemplate.Height = 24;
            this.dataGridViewDSKho.Size = new System.Drawing.Size(1105, 433);
            this.dataGridViewDSKho.TabIndex = 0;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(480, 83);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(144, 33);
            this.btnResetFilter.TabIndex = 33;
            this.btnResetFilter.Text = "Reset bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sức chứa";
            // 
            // comboBoxSucChua
            // 
            this.comboBoxSucChua.FormattingEnabled = true;
            this.comboBoxSucChua.Location = new System.Drawing.Point(250, 86);
            this.comboBoxSucChua.Name = "comboBoxSucChua";
            this.comboBoxSucChua.Size = new System.Drawing.Size(193, 26);
            this.comboBoxSucChua.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Loại kho";
            // 
            // comboBoxLoaiKho
            // 
            this.comboBoxLoaiKho.FormattingEnabled = true;
            this.comboBoxLoaiKho.Location = new System.Drawing.Point(1, 86);
            this.comboBoxLoaiKho.Name = "comboBoxLoaiKho";
            this.comboBoxLoaiKho.Size = new System.Drawing.Size(193, 26);
            this.comboBoxLoaiKho.TabIndex = 28;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(480, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(144, 33);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(3, 32);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(440, 24);
            this.txtTim.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nhập từ khóa để tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnResetFilter);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxSucChua);
            this.panel1.Controls.Add(this.comboBoxLoaiKho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 156);
            this.panel1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(351, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnLoad1);
            this.panel2.Controls.Add(this.btnXoa1);
            this.panel2.Controls.Add(this.btnThem1);
            this.panel2.Controls.Add(this.btnSua1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.panel2.Location = new System.Drawing.Point(655, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 156);
            this.panel2.TabIndex = 34;
            // 
            // btnLoad1
            // 
            this.btnLoad1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad1.ForeColor = System.Drawing.Color.White;
            this.btnLoad1.Location = new System.Drawing.Point(21, 19);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(181, 36);
            this.btnLoad1.TabIndex = 39;
            this.btnLoad1.Text = "Load/ Refresh";
            this.btnLoad1.UseVisualStyleBackColor = false;
            this.btnLoad1.Click += new System.EventHandler(this.btnLoad1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa1.ForeColor = System.Drawing.Color.White;
            this.btnXoa1.Location = new System.Drawing.Point(240, 19);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(181, 36);
            this.btnXoa1.TabIndex = 38;
            this.btnXoa1.Text = "- Xóa kho";
            this.btnXoa1.UseVisualStyleBackColor = false;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem1.ForeColor = System.Drawing.Color.White;
            this.btnThem1.Location = new System.Drawing.Point(21, 86);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(181, 36);
            this.btnThem1.TabIndex = 36;
            this.btnThem1.Text = "+ Thêm kho";
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnSua1
            // 
            this.btnSua1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua1.ForeColor = System.Drawing.Color.White;
            this.btnSua1.Location = new System.Drawing.Point(240, 83);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(181, 36);
            this.btnSua1.TabIndex = 37;
            this.btnSua1.Text = "Sửa thông tin";
            this.btnSua1.UseVisualStyleBackColor = false;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 64);
            this.panel3.TabIndex = 35;
            // 
            // QLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDSKho);
            this.Name = "QLKho";
            this.Size = new System.Drawing.Size(1107, 778);
            this.Load += new System.EventHandler(this.QLKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSKho;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSucChua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLoaiKho;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnSua1;
    }
}