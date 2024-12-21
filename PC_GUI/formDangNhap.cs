
using PC_DTO;
using PC_GUI.BLL;
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
        BLL_NhanVien bLLNhanVien = new BLL_NhanVien();
        
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
                       
                        this.Hide();
                        DTONV nvien = new DTONV();
                        nvien.MaNV = txttenDangNhap.Text;
                        frmMainForm dn = new frmMainForm(nvien);
                        txtmatKhau.Text = null;
                        txttenDangNhap.Text = null;

                    dn.FormClosed += (s, args) =>
                          {       
                                if (dn.IsReopenDangNhap) // Điều kiện mở lại đăng nhập
                                {
                                    this.Show(); // Hiển thị lại Form đăng nhập
                                  
                                }
                                else
                                {
                                    this.Close(); // Đóng nếu không cần mở lại
                                }
                          };
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
