using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_GUI.BLL;
using PC_DTO;

namespace PC_GUI
{
    public partial class XoaDGNCC : Form
    {
        BLLNCC bLLNCC = new BLLNCC();
        public XoaDGNCC()
        {
            InitializeComponent();
        }

        private void XoaDGNCC_Load(object sender, EventArgs e)
        {
            ResetField();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
           "Bạn có chắc chắn muốn hủy bỏ không?",
           "Xác nhận hủy",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);


            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ResetField()
        {
            txtTim.Text = string.Empty;
            txtMaDGNCC.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtMaNCC.Text = string.Empty;
            txtTieuChiDanhGia.Text = string.Empty;

            txtMaDGNCC.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaNCC.Enabled = false;
            txtTieuChiDanhGia.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maTim = txtTim.Text.Trim();
            try
            {
                var listDG = bLLNCC.TimDGNCC(maTim);
                var dg = listDG.First();
                txtMaDGNCC.Text = dg.MaDGNCC;
                txtMaNCC.Text = dg.MaNCC;
                txtMaNV.Text = dg.MaNV;
                txtTieuChiDanhGia.Text = dg.TieuChiDanhGia;
                btnXoa.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                ResetField();
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ResetField();
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDGNCC = txtMaDGNCC.Text.Trim();
            List<string> listDGSP = new List<string>();
            foreach (DataGridViewRow row in dataGridViewDSDMH.SelectedRows)
            {
                listDGSP.Add(row.Cells["MaDGSP"].Value.ToString());
            }
            var confirmResult = MessageBox.Show(
           "Bạn có chắc chắn muốn xóa đánh giá này không?",
           "Xác nhận xóa",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);


            if (confirmResult == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                DTODGNCC xoaDG = new DTODGNCC
                {
                    MaDGNCC = txtMaDGNCC.Text.Trim(),
                    MaNV = txtMaNV.Text.Trim(),
                    MaNCC = txtMaNCC.Text.Trim(),
                    TieuChiDanhGia = txtTieuChiDanhGia.Text.Trim()
                };
                bLLNCC.XoaDGNCC(maDGNCC, listDGSP);

                MessageBox.Show("Xóa đánh giá nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetField();
            }
        }

        private void txtTieuChiDanhGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string maDGNCC = txtMaDGNCC.Text.Trim();
                dataGridViewDSDMH.DataSource = bLLNCC.LoadDMHChon(maDGNCC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewDSDMH.DataSource = null;
            }
        }
    }
}
