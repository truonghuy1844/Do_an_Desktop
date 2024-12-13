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

namespace PC_GUI
{
    public partial class XoaNV : Form
    {
        public XoaNV()
        {
            InitializeComponent();
        }

        private void XoaNV_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            radioButtonNam.Enabled = false;
            radioButtonNu.Enabled = false;
            comboBoxChucVu.Enabled = false;
            comboBoxPhongBan.Enabled = false;
            btnXoa.Enabled = false;
        }
        BLL_NhanVien bLLNV = new BLL_NhanVien();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maNV = txtTim.Text;
            var listNV = bLLNV.TimNV(maNV);

            if (txtTim.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listNV != null && listNV.Count > 0)
            {
                var nv = listNV.First();
                txtMaNV.Text = nv.MaNV;
                txtTenNV.Text = nv.TenNV;
                txtDiaChi.Text = nv.DiaChi;
                txtSDT.Text = nv.SDT;
                if (nv.GioiTinh == "Nam")
                {
                    radioButtonNam.Checked = true;
                    radioButtonNu.Checked = false;
                }
                else
                {
                    radioButtonNam.Checked = false;
                    radioButtonNu.Checked = true;
                }
                comboBoxChucVu.SelectedValue = nv.ChucVu;
                comboBoxPhongBan.SelectedValue = nv.PhongBan;

                btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTONV xoaNV = new DTONV
            {
                MaNV = txtMaNV.Text,
                TenNV = txtTenNV.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ",
                ChucVu = comboBoxChucVu.SelectedValue.ToString(),
                PhongBan = comboBoxPhongBan.SelectedValue.ToString()
            };
            bLLNV.XoaNV(xoaNV);
            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);
            txtTim.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            comboBoxChucVu.SelectedIndex = -1;
            comboBoxPhongBan.SelectedIndex = -1;
            btnXoa.Enabled = false;
        }
    }
}
