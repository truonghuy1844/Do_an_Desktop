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
            bool okInsert = true;
            if (txtMaNV.Text.Length == 0)
            {
                okInsert = false;
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            if (txtMaNV.Text.Length < 5)
            {
                okInsert = false;
                MessageBox.Show("Mã của nhân viên phải đủ 5 số!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            if (txtTenNV.Text.Length == 0)
            {
                okInsert = false;
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                txtTenNV.Focus();
            }
            if (!radioButtonNam.Checked && !radioButtonNu.Checked)
            {
                okInsert = false;
                MessageBox.Show("Vui lòng chọn giới tính!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                lbGioiTinh.Focus();
            }
            if (txtSDT.Text.Length == 0)
            {
                okInsert = false;
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            if (txtSDT.Text.Length < 10)
            {
                okInsert = false;
                MessageBox.Show("Số điện thoại của nhân viên phải đủ 10 số!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            if (comboBoxChucVu.SelectedIndex == -1)
            {
                okInsert = false;
                MessageBox.Show("Vui lòng chọn chức vụ!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                comboBoxChucVu.Focus();
            }
            if (comboBoxChucVu.SelectedIndex == -1)
            {
                okInsert = false;
                MessageBox.Show("Vui lòng chọn phòng ban!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                comboBoxPhongBan.Focus();
            }
            if(okInsert)
            {
                try
                {
                    DTONV dTONV = new DTONV()
                    {
                        MaNV = txtMaNV.Text,
                        TenNV = txtTenNV.Text,
                        DiaChi = txtDiaChi.Text,
                        GioiTinh = radioButtonNam.Checked ? "Nam": "Nữ",
                        SDT = txtSDT.Text,
                        ChucVu = comboBoxChucVu.SelectedValue.ToString(),
                        PhongBan = comboBoxPhongBan.SelectedValue.ToString()
                    };
                    bLLNV.AddNhanVien(dTONV);

                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong lúc thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
