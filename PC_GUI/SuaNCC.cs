using PC_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PC_GUI
{
    public partial class SuaNCC : Form
    {
        BLLNCC bLLNCC = new BLLNCC();
        public SuaNCC()
        {
            InitializeComponent();
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

        private void SuaNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            btnLuu.Enabled  = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maTim = txtTim.Text.Trim();
            try
            {
                var listNCC = bLLNCC.TimNCC(maTim);
                if (listNCC.Any())
                {
                    var ncc = listNCC.First();
                    txtMaNCC.Text = ncc.MaNCC;
                    txtTenNCC.Text = ncc.TenNCC;
                    txtDiaChi.Text = ncc.DiaChi;
                    txtSDT.Text = ncc.SDT;
                    txtEmail.Text = ncc.Email;

                    txtTenNCC.Enabled = true;
                    txtDiaChi.Enabled = true;
                    txtSDT.Enabled = true;
                    txtEmail.Enabled = true;
                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTONCC suaNCC = new DTONCC
                {
                    MaNCC = txtMaNCC.Text.Trim(),   
                    TenNCC = txtTenNCC.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SDT = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };
                bLLNCC.SuaNCC(suaNCC);
                MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK);
                txtTim.Text = string.Empty;
                txtMaNCC.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtSDT.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtEmail.Text = string.Empty;

                txtTenNCC.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
                txtEmail.Enabled = false;
                btnLuu.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
