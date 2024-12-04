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
using PC_BLL;

namespace PC_GUI
{
    public partial class XoaNCC : Form
    {
        BLLNCC bLLNCC = new BLLNCC();
        public XoaNCC()
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

        private void XoaNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            btnXoa.Enabled = false;
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

                    btnXoa.Enabled = true;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
           "Bạn có chắc chắn muốn xóa nhà cung cấp này không?",
           "Xác nhận xóa",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);


            if (confirmResult == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                DTONCC xoaNCC = new DTONCC
                {
                    MaNCC = txtMaNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text
                };
                bLLNCC.XoaNCC(xoaNCC);
                MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK);
                txtTim.Text = string.Empty;
                txtMaNCC.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtSDT.Text = string.Empty;
            }
        }
    }
}
