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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PC_GUI
{
    public partial class AddKho : Form
    {
        public AddKho()
        {
            InitializeComponent();
        }
        BLL_Kho bLLKho = new BLL_Kho();
        private void AddKho_Load(object sender, EventArgs e)
        {
            LoadComboBox();
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

        private void txtMaKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoadComboBox()
        {
            comboBoxLoaiKho.DataSource = bLLKho.LoadLoaiKho();
            comboBoxLoaiKho.DisplayMember = "LoaiKho";
            comboBoxLoaiKho.ValueMember = "LoaiKho";
            comboBoxLoaiKho.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTOKho addKho = new DTOKho()
                {
                    MaKho = txtMaKho.Text.Trim(),
                    TenKho = txtTenKho.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SucChuaTanSo = double.Parse(txtSucChua.Text.Trim()),
                    LoaiKho = comboBoxLoaiKho.SelectedValue?.ToString()
                };

                bLLKho.AddKho(addKho);

                MessageBox.Show("Thêm kho mới thành công!", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Text = string.Empty;
                txtTenKho.Text = string.Empty;
                txtSucChua.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                comboBoxLoaiKho.SelectedIndex = -1;
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



        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
