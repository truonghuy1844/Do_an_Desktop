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
using PC_DAL;

namespace PC_GUI
{
    public partial class SuaNV : Form
    {
        public SuaNV()
        {
            InitializeComponent();
        }

        private void SuaNV_Load(object sender, EventArgs e)
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
            btnLuu.Enabled = false; 
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
                if (nv.GioiTinh)
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
                txtTenNV.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
                radioButtonNam.Enabled = true;
                radioButtonNu.Enabled = true;
                comboBoxChucVu.Enabled = true;
                comboBoxPhongBan.Enabled = true;
                btnLuu.Enabled = true;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool okChange = true;
                if (txtTenNV.Text.Length == 0)
                {
                    okChange = false;
                    MessageBox.Show("Tên nhân viên không được để trống!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                    txtTenNV.Focus();
                }
                if (txtSDT.Text.Length == 0)
                {
                    okChange = false;
                    MessageBox.Show("Số điện thoại của nhân viên không được để trống!", "Chưa đủ thông tin", MessageBoxButtons.OK);
                    txtSDT.Focus();
                }
                if (okChange)
                {
                    DTONV suaNV = new DTONV
                    {
                        MaNV = txtMaNV.Text,
                        TenNV = txtTenNV.Text,
                        SDT = txtSDT.Text,
                        DiaChi = txtDiaChi.Text,
                        GioiTinh = radioButtonNam.Checked ? true : false,
                        ChucVu = comboBoxChucVu.SelectedValue.ToString(),
                        PhongBan = comboBoxPhongBan.SelectedValue.ToString()
                    };
                    bLLNV.SuaNV(suaNV);

                    MessageBox.Show("Sửa thông tin của nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong lúc sửa thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

