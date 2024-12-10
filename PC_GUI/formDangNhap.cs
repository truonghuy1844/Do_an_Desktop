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


namespace PC_GUI
{
    public partial class frmdangNhap : Form
    {
        BLLNhanVien bLLNhanVien = new BLLNhanVien();
        public frmdangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {

                if (txttenDangNhap.Text != "" && txtmatKhau.Text != "")
                {

                    if (bLLNhanVien.CheckDangNhap(txttenDangNhap.Text.Trim(),txtmatKhau.Text.Trim()))
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK);

                        this.Hide();
                        frmMainForm dn = new frmMainForm();
                        dn.ShowDialog();

                        

                    }

                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txttenDangNhap.Focus();
                    }


                }
                else 
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                    txttenDangNhap.Focus();
                }
        }

        private void chcbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chcbHienMatKhau.Checked == true)
            {
                txtmatKhau.PasswordChar = '\0'; // ký tự rỗng để hiển thị văn bản 
            }
            else txtmatKhau.PasswordChar = '*';
        }

        private void frmdangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
