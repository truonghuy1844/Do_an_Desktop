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
using PC_GUI.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PC_GUI
{
    public partial class SuaKho : Form
    {
        BLL_Kho bLLKho = new BLL_Kho();
        public SuaKho()
        {
            InitializeComponent();
        }

        private void SuaKho_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            txtMaKho.Enabled = false;
            txtTenKho.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSucChua.Enabled = false;
            comboBoxLoaiKho.Enabled = false;
            btnLuu.Enabled = false;
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
        private void LoadComboBox()
        {
            comboBoxLoaiKho.DataSource = bLLKho.LoadLoaiKho();
            comboBoxLoaiKho.DisplayMember = "LoaiKho";
            comboBoxLoaiKho.ValueMember = "LoaiKho";
            comboBoxLoaiKho.SelectedIndex = -1;
        }

        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTOKho suaKho = new DTOKho
                {
                    MaKho = txtMaKho.Text.Trim(),
                    TenKho = txtTenKho.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SucChuaTanSo = double.Parse(txtSucChua.Text.Trim()),
                    LoaiKho = comboBoxLoaiKho.SelectedValue?.ToString()
                };
                bLLKho.SuaKho(suaKho);
                MessageBox.Show("Cập nhật thông tin kho thành công!", "Thông báo", MessageBoxButtons.OK);

                txtTim.Text = string.Empty;
                txtMaKho.Text = string.Empty;
                txtTenKho.Text = string.Empty;
                txtSucChua.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                comboBoxLoaiKho.SelectedIndex = -1;

                btnLuu.Enabled = false;
                txtMaKho.Enabled = false;
                txtTenKho.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSucChua.Enabled = false;
                comboBoxLoaiKho.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maTim= txtTim.Text;
            var listKho = bLLKho.TimKho(maTim);

            if (txtTim.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listKho != null && listKho.Count > 0)
            {
                var kh = listKho.First();
                txtMaKho.Text = kh.MaKho;
                txtTenKho.Text= kh.TenKho;
                txtSucChua.Text = kh.SucChuaTanSo.ToString();
                txtDiaChi.Text = kh.DiaChi;
                comboBoxLoaiKho.SelectedValue = kh.LoaiKho;

                txtTenKho.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSucChua.Enabled = true;
                comboBoxLoaiKho.Enabled = true;
                btnLuu.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kho nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
