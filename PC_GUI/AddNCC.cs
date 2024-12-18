using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_BLL;
using PC_DTO;

namespace PC_GUI
{
    public partial class AddNCC : Form
    {
        BLLNCC bLLNCC = new BLLNCC();
        public AddNCC()
        {
            InitializeComponent();
        }

        private void AddNCC_Load(object sender, EventArgs e)
        {

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTONCC addNCC = new DTONCC()
                {
                    MaNCC = txtMaNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text
                };
                bLLNCC.AddNCC(addNCC);

                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK);
                txtMaNCC.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtSDT.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chưa đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
