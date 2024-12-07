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
using PC_DAL;
using PC_DTO;

namespace PC_GUI
{
    public partial class SuaDGNCC : Form
    {
        BLLNCC bLLNCC = new BLLNCC();
        public SuaDGNCC()
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

        private void SuaDGNCC_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            ResetField();
        }
        private void ResetField()
        {
            txtTim.Text = string.Empty;
            txtMaDGNCC.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtMaNCC.Text = string.Empty;
            comboBoxChatLuong.SelectedIndex = -1;
            comboBoxHieuQua.SelectedIndex = -1;
            comboBoxGiaCa.SelectedIndex = -1;
            comboBoxMucDo.SelectedIndex = -1;

            txtMaDGNCC.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaNCC.Enabled = false;
            comboBoxChatLuong.Enabled = false;
            comboBoxHieuQua.Enabled = false;
            comboBoxGiaCa.Enabled = false;
            comboBoxMucDo.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void UnlockField()
        {
            txtMaNV.Enabled = true;
            txtMaNCC.Enabled = true;
            comboBoxChatLuong.Enabled = true;
            comboBoxHieuQua.Enabled = true;
            comboBoxGiaCa.Enabled = true;
            comboBoxMucDo.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
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
                if (dg.DiemChatLuong == null)
                {
                    comboBoxChatLuong.SelectedIndex = -1;
                }
                else
                {
                    comboBoxChatLuong.SelectedValue = dg.DiemChatLuong;
                }
                if (dg.DiemHieuQua == null)
                {
                    comboBoxHieuQua.SelectedIndex = -1;
                }
                else
                {
                    comboBoxHieuQua.SelectedValue = dg.DiemHieuQua;
                }
                if (dg.DiemGiaCa == null)
                {
                    comboBoxGiaCa.SelectedIndex = -1;
                }
                else
                {
                    comboBoxGiaCa.SelectedValue = dg.DiemGiaCa;
                }
                if (dg.MucDoDanhGia == null)
                {
                    comboBoxMucDo.SelectedIndex = -1;
                }
                else
                {
                    comboBoxMucDo.SelectedValue = dg.MucDoDanhGia;
                }
                UnlockField();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetField();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTODGNCC suaDG = new DTODGNCC
                {
                    MaDGNCC = txtMaDGNCC.Text.Trim(),
                    MaNV = txtMaNV.Text.Trim(),
                    MaNCC = txtMaNCC.Text.Trim(),
                    DiemChatLuong = comboBoxChatLuong.SelectedValue != null ? (int?)int.Parse(comboBoxChatLuong.SelectedValue.ToString()) : null,
                    DiemHieuQua = comboBoxHieuQua.SelectedValue != null ? (int?)int.Parse(comboBoxHieuQua.SelectedValue.ToString()) : null,
                    DiemGiaCa = comboBoxGiaCa.SelectedValue != null ? (int?)int.Parse(comboBoxGiaCa.SelectedValue.ToString()) : null,
                    MucDoDanhGia = comboBoxMucDo.SelectedIndex != -1 ? comboBoxMucDo.SelectedValue.ToString() : null
                };
                bLLNCC.SuaDGNCC(suaDG);
                MessageBox.Show("Cập nhật thông tin đánh giá nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetField();
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
    }
}
