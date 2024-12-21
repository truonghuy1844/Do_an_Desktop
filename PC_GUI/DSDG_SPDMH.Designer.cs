namespace PC_GUI
{
    partial class DSDG_SPDMH
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
            this.dataGridViewDSDGSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDGSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSDGSP
            // 
            this.dataGridViewDSDGSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSDGSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSDGSP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDSDGSP.Name = "dataGridViewDSDGSP";
            this.dataGridViewDSDGSP.RowHeadersWidth = 51;
            this.dataGridViewDSDGSP.RowTemplate.Height = 24;
            this.dataGridViewDSDGSP.Size = new System.Drawing.Size(695, 552);
            this.dataGridViewDSDGSP.TabIndex = 1;
            // 
            // DSDG_SPDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 552);
            this.Controls.Add(this.dataGridViewDSDGSP);
            this.Name = "DSDG_SPDMH";
            this.Text = "DSDG_SPDMH";
            this.Load += new System.EventHandler(this.DSDG_SPDMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDGSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDSDGSP;
    }
}