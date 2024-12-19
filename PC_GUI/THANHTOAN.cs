using PC_GUI.BLL;
using PC_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;

namespace PC_GUI
{
    public partial class Thanhtoan : Form
    {
        BLL_ThanhToan bllThanhtoan = new BLL_ThanhToan();
        public int maHoaDon;
        public Thanhtoan(int maHD, int tongTien)
        {
            InitializeComponent();

            txtMaHD.Text = maHD.ToString();
            txtSotien.Text = tongTien.ToString();
            maHoaDon = maHD;
            DTOThanhtoan result = bllThanhtoan.LoadThanhtoan(maHoaDon);

            txtMaTT.Text = result.MaTT.ToString();
            txtNgayTT.Text = result.NgayTT.ToString();
            txtTrangthai.Text = result.TrangThai.ToString();
            if (txtTrangthai.Text == "Đã thanh toán")
            {

                btnThuchien.Enabled = false;

            }
            else
            {
                btnThuchien.Enabled = true;

            }

        }
        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            txtTrangthai.ReadOnly = true;
            txtMaHD.ReadOnly = true;
            txtSotien.ReadOnly = true;
            txtNgayTT.ReadOnly = true;
            
            

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void txtMaTT_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            {
                bool okTao = true;

                DateTime.TryParse(txtNgayTT.Text, out DateTime ngayThanhToan);

                if (ngayThanhToan>DateTime.Now)
                    
                      
                {
                    okTao = false;
                    MessageBox.Show("Ngày không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                    txtNgayTT.Focus();
                }
                if (!txtMaHD.Text.All(char.IsDigit))
                {
                    okTao = false;
                    MessageBox.Show("Mã hóa đơn chỉ chứa ký tự số ", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtMaHD.Focus();
                }
                if ((txtMaHD.Text.Length < 1) || (txtMaHD.Text.Length > 10))
                {
                    okTao = false;
                    MessageBox.Show("Mã hóa đơn tối thiểu 1 ký tự và không quá 10 ký tự");
                    txtMaHD.Focus();
                }

                if (okTao)
                {
                    DTOThanhtoan ttmoi = new DTOThanhtoan();
                    ttmoi.MaHD = int.Parse(txtMaHD.Text);
                    ttmoi.NgayTT = ngayThanhToan;
                    ttmoi.MaTT = txtMaTT.Text;
                    ttmoi.TrangThai = txtTrangthai.Text;
                    if (bllThanhtoan.Capnhatthanhtoan(ttmoi))
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                    }

                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        
       

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            
            string mahd = txtMaHD.Text;
            DataTable dt = bllThanhtoan.Thuchien(mahd);
            this.Close();

            



        }

        private void Thanhtoan_Load_1(object sender, EventArgs e)
        {

        }
    }
   
    
}
