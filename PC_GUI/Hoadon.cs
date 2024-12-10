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
    public partial class Hoadon : Form
    {BLLHoadon bllHoadon= new BLLHoadon();
        public Hoadon()
        {
            InitializeComponent();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllHoadon.LoadData();

            txtSoluong.Enabled = false;
            txtDongia.Enabled = false;
            txtMaHD.Enabled = false;
            btnLuu.Enabled = false;

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            dateTimePicker1.Enabled = true;

            txtMaHD.Focus();
            txtMaHD.Text = string.Empty;
            txtGhichu.Text = string.Empty;
            txtSoluong.Text = string.Empty;
            txtDongia.Text = string.Empty;

            btnLuu.Enabled = true;



        }
        private void ButtonXoa_Click(object sender, EventArgs e)
        {

        }




        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool okTao = true;


                int soluong;


                if (dateTimePicker1.Value > DateTime.Now)
                {
                    okTao = false;
                    MessageBox.Show("Ngày lập không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                    dateTimePicker1.Focus();
                }
                if (!txtMaDH.Text.All(char.IsLetterOrDigit) || !txtMaDH.Text.StartsWith("DMH"))
                {
                    okTao = false;
                    MessageBox.Show("Mã đơn hàng chỉ chứa ký tự chữ, số và bắt đầu bằng 'DMH' !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtMaDH.Focus();
                }
                if ((txtMaDH.Text.Length < 6) || (txtMaDH.Text.Length > 10))
                {
                    okTao = false;
                    MessageBox.Show("Mã đơn hàng tối thiểu 6 ký tự và không quá 10 ký tự");
                    txtMaDH.Focus();
                }
                decimal dongia;
                if (!string.IsNullOrEmpty(txtDongia.Text))
                {
                    if (!decimal.TryParse(txtDongia.Text, out dongia) || dongia <= 0)
                    {
                        okTao = false;
                        MessageBox.Show("Đơn giá phải là số dương", "Lỗi dữ liệu", MessageBoxButtons.OK);
                        txtDongia.Focus();
                    }
                }
                if (!string.IsNullOrEmpty(txtSoluong.Text))
                {
                    if (!int.TryParse(txtSoluong.Text, out soluong) || soluong <= 0)
                    {
                        okTao = false;
                        MessageBox.Show("Số lượng phải là số dương", "Lỗi dữ liệu", MessageBoxButtons.OK);
                        txtSoluong.Focus();
                    }
                }

                if (okTao)
                {
                    DTOHoadon dhmoi = new DTOHoadon();
                    dhmoi.MaHD = txtMaHD.Text;
                    dhmoi.Ngaylap = dateTimePicker1.Value;
                    dhmoi.MaDMH = txtMaDH.Text;
                    dhmoi.GhiChu = txtGhichu.Text;
                    if (bllHoadon.Capnhathoadon(dhmoi))
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                    }

                }
                dataGridView1.DataSource = bllHoadon.LoadData();
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }


        private void btnTaomoi_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tukhoa = txtMaHD.Text;
            DataTable dt = bllHoadon.TimHoadon(tukhoa);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả, hãy thử lại!", "Thông báo", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
            }
            else
            {
                MessageBox.Show("Tìm thấy kết quả", "Thông báo", MessageBoxButtons.OK);
                dataGridView1.DataSource = dt;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool okTao = true;

            if (txtMaHD.Text.Length == 0)
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng không được để trống !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaHD.Focus();
            }

            if (!txtMaDH.Text.All(char.IsLetterOrDigit) || !txtMaDH.Text.StartsWith("DMH"))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng chỉ chứa ký tự chữ, số và bắt đầu bằng 'DMH' !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaDH.Focus();
            }
            if ((txtMaDH.Text.Length < 6) || (txtMaDH.Text.Length > 10))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng tối thiểu 6 ký tự và không quá 10 ký tự");
                txtMaDH.Focus();
            }
            if (bllHoadon.Kiemtramahd(txtMaHD.Text))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng đã tồn tại trong hệ thống, hãy nhập mã khác");
                txtMaHD.Focus();
            }

            //3 Ngày lập không được lớn hơn ngày hiện tại 
            if (dateTimePicker1.Value > DateTime.Now)
            {
                okTao = false;
                MessageBox.Show("Ngày lập không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                dateTimePicker1.Focus();
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa đơn hàng này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    DTOHoadon dhxoa = new DTOHoadon();
                    dhxoa.MaDMH = dataGridView1.CurrentRow.Cells["MaDMH"].Value.ToString();
                    if (bllHoadon.Xoahoadon(dhxoa))
                    {
                        MessageBox.Show("Xóa đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                        dataGridView1.DataSource = bllHoadon.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại, kiểm tra dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    }
                    txtMaHD.Clear();
                    txtGhichu.Clear();
                    txtDongia.Clear();
                    txtSoluong.Clear();
                    txtThanhtien.Clear();

                }
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                txtMaHD.Text = dataGridView1.CurrentRow.Cells["MaHD"].Value.ToString();
                txtMaDH.Text = dataGridView1.CurrentRow.Cells["MaDMH"].Value.ToString();
                txtGhichu.Text = dataGridView1.CurrentRow.Cells["GhiChu"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["NgayLap"].Value);
                txtSoluong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtDongia.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
                txtThanhtien.Text= dataGridView1.CurrentRow.Cells["ThanhTien"].Value.ToString();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThanhtoan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
