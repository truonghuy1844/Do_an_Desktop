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
    {BLLThanhtoan bllThanhtoan = new BLLThanhtoan();
        public DTOThanhtoan dto = new DTOThanhtoan();
        public Thanhtoan(DTOThanhtoan thanhToan)
        {
            InitializeComponent();
            dto = thanhToan;
        }
        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            dataGridViewTT.DataSource = bllThanhtoan.LoadData();

            txtSotien.Enabled = false;
            txtTrangthai.Enabled = false;
            txtMaTT.Enabled = false;
            txtMaHD.Enabled = false;
            btnLuu.Enabled = false;



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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewTT.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa thanh toán này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    DTOThanhtoan ttxoa = new DTOThanhtoan();
                    ttxoa.MaTT = dataGridViewTT.CurrentRow.Cells["MaDMH"].Value.ToString();
                    if (bllThanhtoan.Xoathanhtoan(ttxoa))
                    {
                        MessageBox.Show("Xóa thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
                        dataGridViewTT.DataSource = bllThanhtoan.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thanh toán thất bại, kiểm tra dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    }
                    txtMaHD.Clear();
                    txtMaTT.Clear();
                    txtSotien.Clear();
                    txtTrangthai.Clear();

                }
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }


        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (dataGridViewTT.SelectedRows.Count > 0)
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
                dataGridViewTT.DataSource = bllThanhtoan.LoadData();
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            string tukhoa = txtMaHD.Text;
                DataTable dt = bllThanhtoan.Timthanhtoan(tukhoa);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả, hãy thử lại!", "Thông báo", MessageBoxButtons.OK);
                    dataGridViewTT.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Tìm thấy kết quả", "Thông báo", MessageBoxButtons.OK);
                    dataGridViewTT.DataSource = dt;
                }

            }
        private void dataGridViewTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTT.SelectedRows != null)
            {
                txtMaHD.Text = dataGridViewTT.CurrentRow.Cells["MaHD"].Value.ToString();
                txtMaTT.Text = dataGridViewTT.CurrentRow.Cells["MaTT"].Value.ToString();
                txtTrangthai.Text = dataGridViewTT.CurrentRow.Cells["TrangThai"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewTT.CurrentRow.Cells["NgayTT"].Value);


            }
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
