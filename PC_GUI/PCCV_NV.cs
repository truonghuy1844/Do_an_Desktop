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
    public partial class PCCV_NV : Form
    {
        public PCCV_NV()
        {
            InitializeComponent();
        }
        BLLPhancong bllPhancong = new BLLPhancong();
        private void PCCV_NV_Load(object sender, EventArgs e)
        {
            dataGridViewPhancong.DataSource = bllPhancong.loadphancong();
            // Loại bỏ lựa chọn hàng mặc định
            dataGridViewPhancong.ClearSelection();
            dataGridViewPhancong.CurrentCell = null;

            cbTenNV.DataSource = bllPhancong.loadtennv();
            cbTenNV.DisplayMember = "TenNV";
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.SelectedIndex = -1;

            txtMaPC.Enabled = false;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow != null)
            {
                bool okPc = true;
                //2.Kiểm tra trường ngày hết hạn 
                if (dateTimeNgayht.Value < DateTime.Now)
                {
                    okPc = false;
                    MessageBox.Show("Đã quá hạn, không thể cập nhật");
                }
                //3.Kiểm tra trường số lượng 
                if (txtKLCV.Text.Length == 0)
                {
                    okPc = false;
                    MessageBox.Show("Khối lượng công việc không được trống");
                    txtKLCV.Focus();
                }
                int KLCV;
                if (!int.TryParse(txtKLCV.Text, out KLCV) || KLCV <= 0 || KLCV >= 1000)
                {
                    okPc = false;
                    MessageBox.Show("Khối lượng công việc phải là số nguyên dương. Ví dụ: 13", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtKLCV.Focus();
                }

                if (okPc)
                {
                    DTOPhancong phancong = new DTOPhancong();
                    phancong.MaPC = txtMaPC.Text;
                    phancong.MaNV = cbTenNV.SelectedValue.ToString();
                    phancong.Ngaygiao = dateTimeNgaygiao.Value;
                    phancong.Ngayht = dateTimeNgayht.Value;
                    phancong.Kluong = KLCV;

                    if (rBchuabd.Checked)
                    {
                        phancong.Tthai = "Chưa bắt đầu";
                    }
                    else if (rBdangth.Checked)
                    {
                        phancong.Tthai = "Đang thực hiện";
                    }
                    else if (rBdaht.Checked)
                    {
                        phancong.Tthai = "Hoàn thành";
                    }
                    if (bllPhancong.Suaphancong(phancong))
                    {
                        MessageBox.Show("Cập nhật phân công thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phân công mới thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                    dataGridViewPhancong.DataSource = bllPhancong.loadphancong();
                    txtMaPC.Clear();
                    txtMaPC.Enabled = false;
                    cbTenNV.SelectedIndex = -1;
                    txtKLCV.Clear();
                }
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để cập nhật"); }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            bool ktra = true;
            if (!txtTim.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Bạn phải nhập ký tự chữ hoặc số!");
                txtTim.Focus();
            }
            if (ktra)
            {
                DataTable tim = bllPhancong.Timphancong(txtTim.Text);
                if (tim == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                }
                else
                {
                    MessageBox.Show("Tìm thấy kết quả");
                    dataGridViewPhancong.DataSource = tim;
                }
            }
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            dataGridViewPhancong.DataSource = bllPhancong.loadphancong();
        }

        private void dataGridViewPhancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow != null)
            {
                txtMaPC.Text = dataGridViewPhancong.CurrentRow.Cells["MaPC"].Value.ToString();
                cbTenNV.SelectedValue = dataGridViewPhancong.CurrentRow.Cells["MaNV"].Value.ToString();
                dateTimeNgaygiao.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayGIao"].Value);
                dateTimeNgayht.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayHT"].Value);
                txtKLCV.Text = dataGridViewPhancong.CurrentRow.Cells["KLuong"].Value.ToString();
                //Trường trạng thái
                string tthai = dataGridViewPhancong.CurrentRow.Cells["TThai"].Value.ToString();
                if (tthai == "Chưa bắt đầu")
                {
                    rBchuabd.Checked = true;
                    rBdangth.Checked = false;
                    rBdaht.Checked = false;
                }
                else if (tthai == "Đang thực hiện")
                {
                    rBdangth.Checked = true;
                    rBchuabd.Checked = false;
                    rBdaht.Checked = false;
                }
                else if (tthai == "Hoàn thành")
                {
                    rBdaht.Checked = true;
                    rBchuabd.Checked = false;
                    rBdangth.Checked = false;
                }

                txtMaPC.Enabled = false;
                cbTenNV.Enabled = false;
                dateTimeNgaygiao.Enabled = false;
                dateTimeNgayht.Enabled = false;
            }
        }
    }
}