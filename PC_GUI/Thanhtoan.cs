using PC_BLL;
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

namespace PC_GUI
{
    public partial class Thanhtoan : Form
    {
        BLLThanhtoan bllThanhtoan = new BLLThanhtoan();
        public DTOHoadon dto = new DTOHoadon();
        public decimal tien;
        
        public Thanhtoan(string maHD, string thanhTien)
        {
            InitializeComponent();

            txtMaHD.Text = maHD;
            txtSotien.Text = thanhTien;


        }
        private void Thanhtoan_Load(object sender, EventArgs e)
        {
           ///// Truy vấn hóa đơn có mã hóa đơn là mahd => Gán DTOThanhToan
           ///Từ DTO gán Gán text box

            txtSotien.Enabled = false;
            txtTrangthai.Enabled = false;
            txtTrangthai.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtMaTT.Enabled = false;
            txtMaHD.Enabled = false;

            string mahd = txtMaHD.Text;
            DataTable dt = bllThanhtoan.LoadThanhtoan(mahd);

            {
                txtMaTT.Text= dt.Rows[0]["MaTT"].ToString();
                txtTrangthai.Text= dt.Rows[0]["TrangThai"].ToString();
                

            }



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



                if (dateTimePicker1.Value > DateTime.Now)
                {
                    okTao = false;
                    MessageBox.Show("Ngày không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                    dateTimePicker1.Focus();
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
                    ttmoi.MaHD = txtMaHD.Text;
                    ttmoi.NgayTT = dateTimePicker1.Value;
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
            MessageBox.Show("Thanh toán thành công");
            
        }

        private void Thanhtoan_Load_1(object sender, EventArgs e)
        {

        }
    }
   
    
}
