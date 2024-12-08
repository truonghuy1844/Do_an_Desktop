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
    public partial class PCCV : Form
    {
        BLLPhancong bllphancong = new BLLPhancong();
        public PCCV()
        {
            InitializeComponent();
        }

        //Load combobox trạng thái
        void Loadtrangthai()
        {
            QLMHDataContext db = new QLMHDataContext();
            var dstt = (from dm in db.PHANCONG_CONGVIEC_LQs
                        select dm.TThai).Distinct().ToList();
            cbTrangthai.DataSource = dstt;
        }
        //Load form 
        private void PCCV_Load(object sender, EventArgs e)
        {
            dataGridViewPhancong.DataSource = bllphancong.loadphancong();
            // Loại bỏ lựa chọn hàng mặc định
            dataGridViewPhancong.ClearSelection();
            dataGridViewPhancong.CurrentCell = null;

            cbTenNV.DataSource = bllphancong.loadtennv();
            cbTenNV.DisplayMember = "TenNV";
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.SelectedIndex = -1;

            txtMaPC.Enabled = false;
            Loadtrangthai();
            cbTrangthai.SelectedIndex = -1;

        }
        //Nút tạo phân công mới 
        private void btnTaopc_Click(object sender, EventArgs e)
        {
            txtMaPC.Enabled = true;
            txtMaPC.Text = string.Empty;
            cbTenNV.SelectedIndex = -1;
            txtKLCV.Text = string.Empty;
        }
        //Nút phân công 
        private void btnPhancong_Click(object sender, EventArgs e)
        {
            bool okPc = true;
            //1.Kiểm tra mã phân công
            if (txtMaPC.Text.Length == 0)
            {
                okPc = false;
                MessageBox.Show("Mã phân công không được trống");
                txtMaPC.Focus();
            }
            if (!txtMaPC.Text.All(char.IsLetterOrDigit) || !txtMaPC.Text.StartsWith("PC"))
            {
                okPc = false;
                MessageBox.Show("Mã phân công phải bắt đầu bằng 'PC' và chi chứa ký tự chữ và số");
                txtMaPC.Focus();
            }
            if (txtMaPC.Text.Length < 5 || txtMaPC.Text.Length > 10)
            {
                okPc = false;
                MessageBox.Show("Mã phân công tối thiểu 5 ký tự và tối đa 10 ký tự");
                txtMaPC.Focus();
            }
            if (bllphancong.kiemtramapc(txtMaPC.Text))
            {
                okPc = false;
                MessageBox.Show("Mã phân công đã tồn tại trong hệ thống");
                txtMaPC.Focus();
            }
            //2.Kiểm tra ngày giao và ngày hoàn thành 
            if (dateTimengayht.Value < DateTime.Now)
            {
                okPc = false;
                MessageBox.Show("Ngày hoàn thành phải sau ngày hiện tại");
                dateTimengayht.Focus();
            }
            if (dateTimengayht.Value < dateTimengaygiao.Value)
            {
                okPc = false;
                MessageBox.Show("Ngày hoàn thành phải sau ngày giao");
                dateTimengayht.Focus();
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
                phancong.Ngaygiao = dateTimengaygiao.Value;
                phancong.Ngayht = dateTimengayht.Value;
                phancong.Kluong = KLCV;

                if (rBchua.Checked)
                {
                    phancong.Tthai = "Chưa hoàn thành";
                }
                else if (rBroi.Checked)
                {
                    phancong.Tthai = "Đã hoàn thành";
                }

                if (bllphancong.Taophancong(phancong))
                {
                    MessageBox.Show("Tạo phân công mới thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tạo phân công mới thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                dataGridViewPhancong.DataSource = bllphancong.loadphancong();
                txtMaPC.Clear();
                txtMaPC.Enabled = false;
                cbTenNV.SelectedIndex = -1;
                txtKLCV.Clear();
            }
        }
        //Chọn hàng trong datagridview 

        private void dataGridViewPhancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow  != null)
            {
                txtMaPC.Text = dataGridViewPhancong.CurrentRow.Cells["MaPC"].Value.ToString();
                cbTenNV.SelectedValue = dataGridViewPhancong.CurrentRow.Cells["MaNV"].Value.ToString();
                dateTimengaygiao.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayGIao"].Value);
                dateTimengayht.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayHT"].Value);
                txtKLCV.Text = dataGridViewPhancong.CurrentRow.Cells["KLuong"].Value.ToString();
                //Trường trạng thái
                string tthai = dataGridViewPhancong.CurrentRow.Cells["TThai"].Value.ToString();
                if (tthai == "Chưa hoàn thành")
                {
                    rBchua.Checked = true;
                    rBroi.Checked = false;
                }
                else if (tthai == "Đã hoàn thành")
                {
                    rBroi.Checked = true;
                    rBchua.Checked = false;
                }    

                txtMaPC.Enabled = false;
                cbTenNV.Enabled = false;
                dateTimengaygiao.Enabled = false;
            }
        }
        //Nút cập nhật 
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow != null)
            {
                bool okPc = true;
                //2.Kiểm tra ngày giao và ngày hoàn thành 
                if (dateTimengayht.Value < dateTimengaygiao.Value)
                {
                    okPc = false;
                    MessageBox.Show("Ngày hoàn thành phải sau ngày giao");
                    dateTimengayht.Focus();
                }
                if (dateTimengayht.Value < DateTime.Now)
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
                    phancong.Ngaygiao = dateTimengaygiao.Value;
                    phancong.Ngayht = dateTimengayht.Value;
                    phancong.Kluong = KLCV;

                    if (rBchua.Checked)
                    {
                        phancong.Tthai = "Chưa hoàn thành";
                    }
                    else if (rBroi.Checked)
                    {
                        phancong.Tthai = "Đã hoàn thành";
                    }
                    if (bllphancong.Suaphancong(phancong))
                    {
                        MessageBox.Show("Cập nhật phân công thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phân công mới thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                    dataGridViewPhancong.DataSource = bllphancong.loadphancong();
                    txtMaPC.Clear();
                    txtMaPC.Enabled = false;
                    cbTenNV.SelectedIndex = -1;
                    txtKLCV.Clear();
                }
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để cập nhật"); }
        }
        //Nút xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow != null)
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    DTOPhancong pcxoa = new DTOPhancong();
                    pcxoa.MaPC = dataGridViewPhancong.CurrentRow.Cells["MaPC"].Value.ToString();
                    if (bllphancong.Xoaphancong(pcxoa))
                    {
                        MessageBox.Show("Xóa phân công thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa phân công thất bại");
                    }
                    dataGridViewPhancong.DataSource = bllphancong.loadphancong();
                    txtMaPC.Clear();
                    txtMaPC.Enabled = false;
                    cbTenNV.SelectedIndex = -1;
                    txtKLCV.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 hàng để xóa");
            }
        }
        //Nút tìm 
        private void btnTim_Click(object sender, EventArgs e)
        {   bool ktra = true;
            if (!txtTim.Text.All(char.IsLetter))
            { 
                MessageBox.Show("Bạn phải nhập ký tự chữ!");
                txtTim.Focus();
            }
            if (ktra)
            {
                DataTable tim = bllphancong.Timphancong(txtTim.Text);
                if (tim == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                }
                else
                {
                    dataGridViewPhancong.DataSource = tim;
                }
            }

        }
        //Nút lọc 
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cbTrangthai.SelectedIndex != -1)
            {
                QLMHDataContext db = new QLMHDataContext();
                var listloc = from dm in db.PHANCONG_CONGVIEC_LQs
                              where dm.TThai == cbTrangthai.SelectedValue.ToString()
                              select new
                              {
                                  dm.MaPC,
                                  dm.MaNV,
                                  dm.NgayGiao,
                                  dm.NgayHT,
                                  dm.KLuong,
                                  dm.TThai,
                              };
                dataGridViewPhancong.DataSource = listloc.ToList();
            }
            else
            {
                MessageBox.Show("Hãy chọn trạng thái!");
            }
        }
        //Nút xem chi tiết phân công 
        private void btnchitiet_Click(object sender, EventArgs e)
        {
            dataGridViewPhancong.DataSource = bllphancong.loadphancong();
        }
        //Bỏ qua 
        private void dataGridViewPhancong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtDongia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
