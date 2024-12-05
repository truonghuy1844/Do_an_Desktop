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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PC_GUI
{
    public partial class AddNV : Form
    {
        public AddNV()
        {
            InitializeComponent();
        }

        private void AddNV_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
        BLLNV bLLNV = new BLLNV();  
        
        private void LoadComboBox()
        {
            comboBoxChucVu.DataSource = bLLNV.LoadChucVu();
            comboBoxChucVu.DisplayMember = "ChucVu";
            comboBoxChucVu.ValueMember = "ChucVu";
            comboBoxChucVu.SelectedIndex = -1;

            comboBoxPhongBan.DataSource = bLLNV.LoadPhongBan();
            comboBoxPhongBan.DisplayMember = "PhongBan";
            comboBoxPhongBan.ValueMember = "PhongBan";
            comboBoxPhongBan.SelectedIndex = -1;
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
                string maNV = txtMaNV.Text.Trim();
                if (!string.IsNullOrWhiteSpace(maNV) &&
                    string.IsNullOrWhiteSpace(txtTenNV.Text) &&
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) &&
                    string.IsNullOrWhiteSpace(txtSDT.Text) &&
                    comboBoxChucVu.SelectedValue == null &&
                    comboBoxPhongBan.SelectedValue == null)
                {
                    List<DTONV> exists = bLLNV.TimNV(maNV);

                    if (exists != null && exists.Any())
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập thêm thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
                DTONV addNV = new DTONV()
                {
                    MaNV = txtMaNV.Text.Trim(),
                    TenNV = txtTenNV.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ",
                    SDT = txtSDT.Text.Trim(),
                    ChucVu = comboBoxChucVu.SelectedValue?.ToString(),
                    PhongBan = comboBoxPhongBan.SelectedValue?.ToString()
                };
                bLLNV.AddNhanVien(addNV);

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Text = string.Empty;
                txtTenNV.Text = string.Empty;
                txtSDT.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                radioButtonNam.Checked = false;
                radioButtonNu.Checked = false;
                comboBoxChucVu.SelectedIndex = -1;
                comboBoxPhongBan.SelectedIndex = -1;
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
        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
