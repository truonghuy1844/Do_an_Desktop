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
    public partial class PCCV : UserControl
    {
        public DTONV nv = new DTONV();
        BLL_PhanCong bllphancong = new BLL_PhanCong();
        public PCCV(DTONV nvien)
        {
            InitializeComponent();
            nv.MaNV = nvien.MaNV;
            BLL_KiemTraTruyCap kt = new BLL_KiemTraTruyCap();
            bool KiemTraPhongBan = kt.Kiem_Tra_PhongBan(nv);
            if (!KiemTraPhongBan)
            {
                this.Controls.Remove(btnXoa);
            }
        }

        //Load combobox trạng thái
        void Loadtrangthai()
        {
            QLMHEntities3 db = new QLMHEntities3();
            var dstt = (from dm in db.PHANCONG_CONGVIEC
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
            dataGridViewPhancong.ReadOnly = true;

            cbTenNV.DataSource = bllphancong.loadtennv();
            cbTenNV.DisplayMember = "TenNV";
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.SelectedIndex = -1;

            txtMaPC.Enabled = false;
            Loadtrangthai();
            cbTrangthai.SelectedIndex = -1;
            btnPhancong.Enabled = false;

        }
        //Nút tạo phân công mới 
        private void btnTaopc_Click(object sender, EventArgs e)
        {
            HideAllTooltips();
            txtMaPC.Enabled = true;
            txtMaPC.Text = string.Empty;
            cbTenNV.Enabled = true;
            cbTenNV.SelectedIndex = -1;
            txtKLCV.Text = string.Empty;
            btnPhancong.Enabled = true;
            rBchuabd.Enabled = true;
            rBdaht.Enabled = true;
            rBdangth.Enabled = true;
            dateTimengaygiao.Enabled = true;
            rBchuabd.Checked = true; 
        }
        //Kiểm tra mã phân công 
        private void txtMaPC_Leave(object sender, EventArgs e)
        {
            //1.Kiểm tra mã phân công
            if (txtMaPC.Text.Length == 0)
            {
                toolTip1.Show("Mã phân công không được trống", txtMaPC, 0 , txtMaPC.Height);
            }
            else if (!txtMaPC.Text.All(char.IsLetterOrDigit) || !txtMaPC.Text.StartsWith("PC"))
            {
                toolTip1.Show("Mã phân công phải bắt đầu bằng 'PC' và chi chứa ký tự chữ và số", txtMaPC, 0, txtMaPC.Height);
            }
            else if (txtMaPC.Text.Length < 5 || txtMaPC.Text.Length > 10)
            {
                toolTip1.Show("Mã phân công tối thiểu 5 ký tự và tối đa 10 ký tự", txtMaPC, 0, txtMaPC.Height);
            }
            else
            {
                toolTip1.Hide(txtMaPC);
            }
        }

        private void txtMaPC_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPC.Text.Length > 0 &&
                txtMaPC.Text.All(char.IsLetterOrDigit) &&
                txtMaPC.Text.StartsWith("PC") &&
                txtMaPC.Text.Length >= 5  &&
                txtMaPC.Text.Length < 11 )
            {
                toolTip1.Hide(txtMaPC);
            }    
        }
        //Kiểm tra KLCV 
        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            if (!txtKLCV.Focused) return;
            if (string.IsNullOrWhiteSpace(txtKLCV.Text))
            {
                toolTip2.Show("Công việc không được trống", txtKLCV, 0, txtKLCV.Height);
            }
            else if (txtKLCV.Text.Any(c => char.IsDigit(c) || (!char.IsLetter(c) && c != ' ' && c != '-' && c != ',' && c != '.')))
            {
                toolTip2.Show("Thông tin công việc không hợp lệ", txtKLCV, 0, txtKLCV.Height);
            }
            else
            {
                toolTip2.Hide(txtKLCV); 
            } 
                
        }
        //Nút phân công 
        private void btnPhancong_Click(object sender, EventArgs e)
        {
            bool okPc = true;
            //1.Kiểm tra mã phân công
            if (string.IsNullOrWhiteSpace(txtMaPC.Text))
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
            //2.Kiểm tra tên nhân viên 
            if (cbTenNV.SelectedIndex == -1)
            {
                okPc = false;
                MessageBox.Show("Tên nhân viên không được trống");
                cbTenNV.Focus();
            }
            //3.Kiểm tra trường công việc
            if (string.IsNullOrWhiteSpace(txtKLCV.Text))
            {
                okPc = false;
                MessageBox.Show("Công việc không được để trống");
                txtKLCV.Focus();
            }
            else if (txtKLCV.Text.Any(c => char.IsDigit(c) || (!char.IsLetter(c) && c != ' ' && c != '-' && c != ',' && c != '.')))
            {
                okPc = false;
                MessageBox.Show("Thông tin công việc không hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtKLCV.Focus();
            }

            //4.Kiểm tra ngày 
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
            if (okPc)
            {
                DTOPhancong phancong = new DTOPhancong();
                phancong.MaPC = txtMaPC.Text;
                phancong.MaNV = cbTenNV.SelectedValue.ToString();
                phancong.Ngaygiao = dateTimengaygiao.Value;
                phancong.Ngayht = dateTimengayht.Value;
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
                btnPhancong.Enabled = false;
            }
        }
        //Chọn hàng trong datagridview 

        private void dataGridViewPhancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow  != null)
            {
                txtMaPC.Text = dataGridViewPhancong.CurrentRow.Cells["MaPC"].Value.ToString();
                cbTenNV.SelectedValue = dataGridViewPhancong.CurrentRow.Cells["MaNV"].Value.ToString();
                dateTimengaygiao.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayGiao"].Value);
                dateTimengayht.Value = Convert.ToDateTime(dataGridViewPhancong.CurrentRow.Cells["NgayHT"].Value);
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
                dateTimengaygiao.Enabled = false;
            }
        }
        //Nút cập nhật 
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhancong.CurrentRow != null)
            {
                bool okPc = true;
                //2.Kiểm tra trường ngày hết hạn 
                if (dateTimengayht.Value < DateTime.Now && rBdaht.Checked == false)
                {
                    okPc = false;
                    MessageBox.Show("Đã quá hạn, không thể cập nhật");
                }
                //3.Kiểm tra trường công việc
                if (string.IsNullOrWhiteSpace(txtKLCV.Text))
                {
                    okPc = false;
                    MessageBox.Show("Công việc không được để trống");
                    txtKLCV.Focus();
                }
                else if (txtKLCV.Text.Any(c => char.IsDigit(c) || (!char.IsLetter(c) && c != ' ' && c != '-' && c != ',' && c != '.')))
                {
                    okPc = false;
                    MessageBox.Show("Thông tin công việc không hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtKLCV.Focus();
                }
                if (okPc)
                {
                    DTOPhancong phancong = new DTOPhancong();
                    phancong.MaPC = txtMaPC.Text;
                    phancong.MaNV = cbTenNV.SelectedValue.ToString();
                    phancong.Ngaygiao = dateTimengaygiao.Value;
                    phancong.Ngayht = dateTimengayht.Value;
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
                    if (bllphancong.Suaphancong(phancong))
                    {
                        MessageBox.Show("Cập nhật phân công thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phân công thất bại", "Thông báo", MessageBoxButtons.OK);
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
        {
            HideAllTooltips();
            bool ktra = true;
            if (!txtTim.Text.All(char.IsLetterOrDigit))
            { 
                MessageBox.Show("Bạn phải nhập ký tự chữ hoặc số !");
                txtTim.Focus();
            }
            if (ktra)
            {
                DataTable tim = bllphancong.Timphancong(txtTim.Text);
                if (tim == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
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
            HideAllTooltips();
            if (cbTrangthai.SelectedIndex != -1)
            {
                QLMHEntities3 db = new QLMHEntities3();
                var listloc = from dm in db.PHANCONG_CONGVIEC
                              where dm.TThai == cbTrangthai.SelectedValue.ToString()
                              select new
                              {
                                  dm.MaPC,
                                  dm.MaNV,
                                  dm.NgayGiao,
                                  dm.NgayHT,
                                  dm.Congviec,
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
            HideAllTooltips();
            dataGridViewPhancong.DataSource = bllphancong.loadphancong();
        }

        private void HideAllTooltips()
        {
            toolTip1.Hide(txtMaPC);
            toolTip2.Hide(txtKLCV);

        }
        //Bỏ qua 
        private void dataGridViewPhancong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimengaygiao_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dateTimengayht_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rBchuabd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
