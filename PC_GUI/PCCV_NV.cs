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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PC_GUI.DAL;

namespace PC_GUI
{
    public partial class PCCV_NV : UserControl
    {
        public DTONV nv = new DTONV();
        public PCCV_NV(DTONV nvien)
        {
            InitializeComponent();
        }
        BLL_PhanCong bllPhancong = new BLL_PhanCong();
        private void PCCV_NV_Load(object sender, EventArgs e)
        {
            dataGridViewPhancong.DataSource = bllPhancong.loadphancong();
            // Loại bỏ lựa chọn hàng mặc định
            dataGridViewPhancong.ClearSelection();
            dataGridViewPhancong.CurrentCell = null;
            dataGridViewPhancong.ReadOnly = true;

            cbTenNV.DataSource = bllPhancong.loadtennv();
            cbTenNV.DisplayMember = "TenNV";
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.SelectedIndex = -1;

            txtMaPC.Enabled = false;
            btnXoa.Enabled = false;

        }
        //Kiểm tra khối lượng công việc 
        private void txtKLCV_TextChanged(object sender, EventArgs e)
        {

        }
        //Kiểm tra ngày hoàn thành 
        private void dateTimeNgayht_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow != null)
            {
                    DTOPhancong phancong = new DTOPhancong();
                    phancong.MaPC = txtMaPC.Text;
                    phancong.MaNV = cbTenNV.SelectedValue.ToString();
                    phancong.Ngaygiao = dateTimeNgaygiao.Value;
                    phancong.Ngayht = dateTimeNgayht.Value;
                    phancong.Congviec = txtKLCV.Text;

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
                if (tim == null || tim.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                }
                else
                {
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
                MessageBox.Show("Phân công đã được chọn, cập nhật tiến độ công việc nhé!");
                txtMaPC.Text = dataGridViewPhancong.CurrentRow.Cells["MaPC"].Value.ToString();
                cbTenNV.SelectedValue = dataGridViewPhancong.CurrentRow.Cells["MaNV"].Value.ToString();
                dateTimeNgaygiao.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayGiao"].Value);
                dateTimeNgayht.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayHT"].Value);
                txtKLCV.Text = dataGridViewPhancong.CurrentRow.Cells["Congviec"].Value.ToString();
                //Trường trạng thái
                string tthai = dataGridViewPhancong.CurrentRow.Cells["TThai"].Value.ToString();
                if (tthai == "Chưa bắt đầu")
                {
                    rBchuabd.Checked = true;
                    rBdangth.Checked = false;
                    rBdaht.Checked = false;
                    rBdaht.Enabled = true;
                    rBchuabd.Enabled = true;
                    rBdangth.Enabled = true;
                }
                else if (tthai == "Đang thực hiện")
                {
                    rBdangth.Checked = true;
                    rBchuabd.Checked = false;
                    rBdaht.Checked = false;
                    rBdaht.Enabled = true;
                    rBchuabd.Enabled = false;
                    rBdangth.Enabled = true;
                }
                else if (tthai == "Hoàn thành")
                {
                    rBdaht.Checked = true;
                    rBchuabd.Checked = false;
                    rBdangth.Checked = false;
                    // Không cho đổi sang trạng thái khác
                    rBdaht.Enabled = true;
                    rBchuabd.Enabled = false;
                    rBdangth.Enabled = false;
                }

                txtMaPC.Enabled = false;
                cbTenNV.Enabled = false;
                dateTimeNgaygiao.Enabled = false;
                dateTimeNgayht.Enabled = false;
                txtKLCV.Enabled = false;
            }
        }

        private void txtMaPC_Leave(object sender, EventArgs e)
        {

        }

        private void txtMaPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void rBdaht_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}