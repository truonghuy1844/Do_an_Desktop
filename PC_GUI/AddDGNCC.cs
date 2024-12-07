using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_BLL;
using PC_DTO;

namespace PC_GUI
{
    public partial class AddDGNCC : Form
    {
        BLLNCC bLLNCC = new BLLNCC();   
        public AddDGNCC()
        {
            InitializeComponent();
        }

        private void AddDGNCC_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            comboBoxChatLuong.DataSource = bLLNCC.LoadDiemChatLuong();
            comboBoxChatLuong.DisplayMember = "DiemChatLuong";
            comboBoxChatLuong.ValueMember = "DiemChatLuong";
            comboBoxChatLuong.SelectedIndex = -1;

            comboBoxHieuQua.DataSource = bLLNCC.LoadDiemHieuQua();
            comboBoxHieuQua.DisplayMember = "DiemHieuQua";
            comboBoxHieuQua.ValueMember = "DiemHieuQua";
            comboBoxHieuQua.SelectedIndex = -1;

            comboBoxGiaCa.DataSource = bLLNCC.LoadDiemGiaCa();
            comboBoxGiaCa.DisplayMember = "DiemGiaCa";
            comboBoxGiaCa.ValueMember = "DiemGiaCa";
            comboBoxGiaCa.SelectedIndex = -1;

            comboBoxMucDo.DataSource = bLLNCC.LoadMucDoDG();
            comboBoxMucDo.DisplayMember = "MucDoDanhGia";
            comboBoxMucDo.ValueMember = "MucDoDanhGia";
            comboBoxMucDo.SelectedIndex = -1;

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

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 6 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaDGNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTODGNCC addDGNCC = new DTODGNCC()
                {
                    MaDGNCC = txtMaDGNCC.Text.Trim(),
                    MaNV = txtMaNV.Text.Trim(),
                    MaNCC = txtMaNCC.Text.Trim(),
                    DiemChatLuong = comboBoxChatLuong.SelectedValue != null ? (int?)int.Parse(comboBoxChatLuong.SelectedValue.ToString()) : null,
                    DiemHieuQua = comboBoxHieuQua.SelectedValue != null ? (int?)int.Parse(comboBoxHieuQua.SelectedValue.ToString()) : null,
                    DiemGiaCa = comboBoxGiaCa.SelectedValue != null ? (int?)int.Parse(comboBoxGiaCa.SelectedValue.ToString()) : null,
                    MucDoDanhGia = comboBoxMucDo.SelectedIndex != -1 ? comboBoxMucDo.SelectedValue.ToString() : null
                };
                bLLNCC.AddDGNCC(addDGNCC);

                MessageBox.Show("Thêm đánh giá mới thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetField();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Chưa đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetField()
        {
            txtMaDGNCC.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtMaNCC.Text = string.Empty;
            comboBoxChatLuong.SelectedIndex = -1;
            comboBoxHieuQua.SelectedIndex = -1;
            comboBoxGiaCa.SelectedIndex = -1;
            comboBoxMucDo.SelectedIndex = -1;
        }
    }
}
