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

using PC_DTO;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PC_GUI.DAL;

namespace PC_GUI
{
    public partial class Quanlydonhang : UserControl
    {
        BLL_DonMuaHang bllDonmua = new BLL_DonMuaHang();
        public DTONV nv = new DTONV();
        public Quanlydonhang(DTONV nvien)
        {
            InitializeComponent();
            nv.MaNV = nvien.MaNV;
            BLL_KiemTraTruyCap kt = new BLL_KiemTraTruyCap();
            bool KiemTraPhongBan = kt.Kiem_Tra_PhongBan(nv);
            if (!KiemTraPhongBan)
            {
                this.Controls.Remove(btnTao);
                this.Controls.Remove(btnCapNhat);
                this.Controls.Remove(btnLuu);
                this.Controls.Remove(btnXoa);
                this.Controls.Remove(btnHuy);
            }
        }

        //I.Load dữ liệu 
        void LoadDonmua()
        {
            QLMHEntities4 db = new QLMHEntities4();
             
            var listdonmua = from dm in db.DONMUAHANGs
                             orderby dm.NgayLap descending
                             select new
                             {
                                 dm.MaDMH,
                                 dm.NgayLap,
                                 dm.MaHDMH,
                                 dm.MaYC,
                                 dm.MaNV,
                                 dm.MaNCC,
                                 dm.Chietkhau,
                                 dm.MoTa,
                                 dm.TThai
                             };
            dataGridView1.DataSource = listdonmua.ToList();
        }
        List<HOPDONGMH> loadMaHDMH()
        {
            QLMHEntities4 db = new QLMHEntities4();
            var listmahd = from hd in db.HOPDONGMHs
                           select hd;
            return listmahd.ToList();
        }
        void loadNhaCC()
        {
            QLMHEntities4 db = new QLMHEntities4();
            var listNhaCC = from ncc in db.NHACUNGCAPs
                            select ncc;
            cbMaNCC.DataSource = listNhaCC.ToList();
            cbMaNCC.DisplayMember = "TenNCC";
            cbMaNCC.ValueMember = "MaNCC";
        }
        //Load combobox trạng thái 
        void loadcbTrangthai()
        {
            List<DTOTrangthai> dstrangthai1 = new List<DTOTrangthai>
            {
                new DTOTrangthai{ Luu = "Hoàn tất", Hienthi = "Hoàn tất"},
                new DTOTrangthai{ Luu = "Đã hủy", Hienthi = "Đã hủy"},
                new DTOTrangthai{ Luu = "Chờ xử lý", Hienthi = "Chờ xử lý"}
            };
            cbTrangThai.DataSource = dstrangthai1;
            cbTrangThai.DisplayMember = "Hienthi";
            cbTrangThai.ValueMember = "Luu";
        }
        void loadcbLoc()
        {
            List<DTOTrangthai> dstrangthai2 = new List<DTOTrangthai>
            {
                new DTOTrangthai{ Luu = "Hoàn tất", Hienthi = "Hoàn tất"},
                new DTOTrangthai{ Luu = "Đã hủy", Hienthi = "Đã hủy"},
                new DTOTrangthai{ Luu = "Chờ xử lý", Hienthi = "Chờ xử lý"}
            };
            cbLoc.DataSource = dstrangthai2;
            cbLoc.DisplayMember = "Hienthi";
            cbLoc.ValueMember = "Luu";
        }
        //Load combobox yêu cầu mua hàng 
        void loadycmh()
        {
            QLMHEntities4 db = new QLMHEntities4();
            var ycmh = from yc in db.YEUCAU_MUAHANG
                       select yc;
            cbYcmh.DataSource = ycmh.ToList();
            cbYcmh.DisplayMember = "MaYC";
            cbYcmh.ValueMember = "MaYC";
        }
        private void btnThongtindh_Click_1(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            LoadDonmua();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }
        private void Quanlydonhang_Load(object sender, EventArgs e)
        {
            LoadDonmua();
            cbMaHD.DataSource = loadMaHDMH();
            cbMaHD.DisplayMember = "MaHDMH";
            cbMaHD.ValueMember = "MaHDMH";
            loadNhaCC();
            loadcbTrangthai();
            loadcbLoc();
            loadycmh();
            txtMaDMH.Enabled = false;
            cbMaHD.SelectedIndex = -1;
            cbMaNCC.SelectedIndex = -1;
            cbYcmh.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            cbLoc.SelectedIndex = -1;
            btnLuu.Enabled = false;
            dataGridView1.ReadOnly = true;

            //load đơn hoàn tất và chờ xử lý 
            txtDonht.Text = bllDonmua.donhoantat().ToString();
            txtChoxuly.Text = bllDonmua.doncho().ToString();
        }

        //II.Xử lý các nút 
        private void btnTao_Click(object sender, EventArgs e)
        {
            HideAllTooltips();
            //Mở khóa các textbox 
            txtMaDMH.Enabled = true;
            dateTime.Enabled = true;
            txtMaNV.Enabled = true; cbMaNCC.Enabled = true;
            cbMaHD.Enabled = true; cbTrangThai.Enabled = true;
            txtMoTa.Enabled = true;  txtChietkhau.Enabled = true;
            //Làm trống dữ liệu 
            txtMaDMH.Focus();
            txtMaDMH.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtChietkhau.Text = string.Empty;
            dateTime.Value = DateTime.Now;
            cbMaNCC.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            cbMaHD.SelectedIndex = -1;
            cbYcmh.SelectedIndex = -1;
            //Mở lưu
            btnLuu.Enabled = true;
        }
        //Kiểm tra mã đơn mua hàng 
        
        private void txtMaDMH_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDMH.Text))
            {
                toolTip1.Show("Mã đơn hàng không được để trống!", txtMaDMH, 0, txtMaDMH.Height); // Hiển thị tooltip trong 3 giây
            }
            else if (!txtMaDMH.Text.All(char.IsLetterOrDigit) || !txtMaDMH.Text.StartsWith("DMH"))
            {
                toolTip1.Show("Mã đơn hàng chỉ chứa ký tự chữ, số và bắt đầu bằng 'DMH'!", txtMaDMH, 0, txtMaDMH.Height);
            }
            else if (txtMaDMH.Text.Length < 6 || txtMaDMH.Text.Length > 10)
            {
                toolTip1.Show("Mã đơn hàng tối thiểu 6 ký tự và không quá 10 ký tự!", txtMaDMH, 0, txtMaDMH.Height);
            }
            else
            {
                toolTip1.Hide(txtMaDMH); // Ẩn tooltip 
            }

        }
        //Tắt tooltip khi thỏa mãn điều kiện 
        private void txtMaDMH_TextChanged_1(object sender, EventArgs e)
        {
            if (txtMaDMH.Text.Length >= 6 &&
                txtMaDMH.Text.Length <= 10 &&
                txtMaDMH.Text.All(char.IsLetterOrDigit) &&
                txtMaDMH.Text.StartsWith("DMH"))
            {
                toolTip1.Hide(txtMaDMH);
            }
        }


        //Kiểm tra mã nhân viên
        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            //2.1 Mã nhân viên không được trống 
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                toolTip2.Show("Mã nhân viên không được để trống!", txtMaNV, 0, txtMaNV.Height);

            }
            //2.2 Mã nhân viên chỉ được chứa ký tự chữ và số 
            else if (!txtMaNV.Text.All(char.IsLetterOrDigit) || !txtMaNV.Text.StartsWith("NV"))
            {
                toolTip2.Show("Mã nhân viên chỉ chứa ký tự chữ, số và bắt đầu bằng 'NV'!", txtMaNV, 0, txtMaNV.Height);
            }
            //2.3 Mã nhân viên tối thiểu 5, tối đa 10 
            else if ((txtMaNV.Text.Length < 5) || (txtMaNV.Text.Length > 10))
            {
                toolTip2.Show("Mã nhân viên tối thiểu 5 ký tự và không quá 10 ký tự!", txtMaNV, 0, txtMaNV.Height);
            }
            else
            {
                toolTip2.Hide(txtMaNV); //ẩn đi 
            }
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length >= 5 &&
               txtMaNV.Text.Length <= 10 &&
               txtMaNV.Text.All(char.IsLetterOrDigit) &&
               txtMaNV.Text.StartsWith("NV"))
            {
                toolTip2.Hide(txtMaNV);
            }
        }
        //Kiểm tra ngày tháng 
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                dateTime.Value = DateTime.Now;
            }
        }
        //Kiểm tra chiết khấu 
        private void txtChietkhau_Leave(object sender, EventArgs e)
        {
            decimal chietkhau;
            if (!string.IsNullOrEmpty(txtChietkhau.Text))
            {
                if (!decimal.TryParse(txtChietkhau.Text, out chietkhau) || chietkhau < 0 || chietkhau >= 1000)
                {
                    toolTip3.Show("Chiết khấu phải là số thực lớn hơn 0 và nhỏ hơn 1000", txtChietkhau, 0, txtChietkhau.Height);
                }
                else
                {
                    toolTip3.Hide(txtChietkhau);
                }
            }
            else
            {
                toolTip3.Show("Vui lòng nhập chiết khấu!", txtChietkhau, 0, txtChietkhau.Height);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool okTao = true;
            //1.Kiểm tra trường mã đơn hàng 
            //1.1 Mã trường không được trống 
            if (string.IsNullOrWhiteSpace(txtMaDMH.Text))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng không được để trống !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaDMH.Focus();
                return;
            }
            //1.2 Mã trường chỉ được chứa ký tự chữ và số 
            if (!txtMaDMH.Text.All(char.IsLetterOrDigit) || !txtMaDMH.Text.StartsWith("DMH"))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng chỉ chứa ký tự chữ, số và bắt đầu bằng 'DMH' !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaDMH.Focus();
            }
            //1.3 Mã trường tối thiểu 6, tối đa 10 
            if ((txtMaDMH.Text.Length < 6) || (txtMaDMH.Text.Length > 10))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng tối thiểu 6 ký tự và không quá 10 ký tự");
                txtMaDMH.Focus();
            }
            //1.4 Mã trường không được lặp lại 
            if (bllDonmua.Kiemtramadmh(txtMaDMH.Text))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng đã tồn tại trong hệ thống, hãy nhập mã khác");
                txtMaDMH.Focus();
            }
            //2.Kiêm tra trường mã nhân viên 
            //2.1 Mã nhân viên không được trống 
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                okTao = false;
                MessageBox.Show("Mã nhân viên không được để trống !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            //2.2 Mã nhân viên chỉ được chứa ký tự chữ và số 
            if (!txtMaNV.Text.All(char.IsLetterOrDigit) || !txtMaNV.Text.StartsWith("NV"))
            {
                okTao = false;
                MessageBox.Show("Mã nhân viên chỉ chứa ký tự chữ, số và bắt đầu bằng 'NV'!", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            //2.3 Mã nhân viên tối thiểu 5, tối đa 10 
            if ((txtMaDMH.Text.Length < 5) || (txtMaDMH.Text.Length > 10))
            {
                okTao = false;
                MessageBox.Show("Mã nhân viên tối thiểu 5 ký tự và không quá 10 ký tự","Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            //3.
            if (cbMaHD.SelectedIndex == -1 || cbMaNCC.SelectedIndex == -1 || cbYcmh.SelectedIndex == -1 || cbTrangThai.SelectedIndex == -1)
            {
                okTao = false;
                MessageBox.Show("Không được để trống các trường bắt buộc");
                return;
            }
            //4.Chiết khấu là số thực và > 0 
            decimal chietkhau = 0;
            string input = txtChietkhau.Text.Replace(",", ".");
            if (!string.IsNullOrEmpty(txtChietkhau.Text))
            {
                if (!decimal.TryParse(input, out chietkhau) || chietkhau < 0 || chietkhau >= 1000)
                {
                    okTao = false;
                    MessageBox.Show("Không được để trống chiết khấu! Nếu không có, hãy điền '0'", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtChietkhau.Focus();
                }
            }
            if (okTao)
            {
                try
                {
                    DONMUAHANG dhmoi = new DONMUAHANG();
                    dhmoi.MaDMH = txtMaDMH.Text;
                    dhmoi.NgayLap = dateTime.Value;
                    dhmoi.MaHDMH = cbMaHD.SelectedValue.ToString();
                    dhmoi.MaNV = txtMaNV.Text;
                    dhmoi.MaNCC = cbMaNCC.SelectedValue.ToString();
                    dhmoi.MaYC = cbYcmh.SelectedValue.ToString();
                    dhmoi.Chietkhau = chietkhau;
                    dhmoi.TThai = cbTrangThai.SelectedValue.ToString();
                    dhmoi.MoTa = txtMoTa.Text;
                    
                    QLMHEntities4 db = new QLMHEntities4();
                    db.DONMUAHANGs.Add(dhmoi);
                    db.SaveChanges();
                    MessageBox.Show("Tạo đơn hàng mới thành công", "Thông báo", MessageBoxButtons.OK);

                    LoadDonmua();
                }

                catch
                {
                    MessageBox.Show("Tạo đơn hàng mới thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                finally 
                {
                    btnLuu.Enabled = false;
                    txtMaDMH.Enabled = false;
                    cbLoc.SelectedIndex = -1;
                }
                txtMaDMH.Clear();
                txtMaNV.Clear();
                txtMoTa.Clear();
                txtChietkhau.Clear();
                txtMaDMH.Focus();
                btnLuu.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool okTao = true;
                //2.Kiêm tra trường mã nhân viên 
                //2.1 Mã nhân viên không được trống 
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {

                    okTao = false;
                    MessageBox.Show("Mã nhân viên không được để trống !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtMaNV.Focus();
                }
                //2.2 Mã nhân viên chỉ được chứa ký tự chữ và số 
                if (!txtMaNV.Text.All(char.IsLetterOrDigit) || !txtMaNV.Text.StartsWith("NV"))
                {
                    okTao = false;
                    MessageBox.Show("Mã nhân viên chỉ chứa ký tự chữ, số và bắt đầu bằng 'NV'!", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtMaNV.Focus();
                }
                //2.3 Mã nhân viên tối thiểu 5, tối đa 10 
                if ((txtMaDMH.Text.Length < 5) || (txtMaDMH.Text.Length > 10))
                {
                    okTao = false;
                    MessageBox.Show("Mã nhân viên tối thiểu 5 ký tự và không quá 10 ký tự");
                    txtMaNV.Focus();
                }
                //3 Kiểm tra trường ngày lập
                //3.2 Ngày lập không được lớn hơn ngày hiện tại 
                if (dateTime.Value > DateTime.Now)
                {
                    okTao = false;
                    MessageBox.Show("Ngày lập không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                    dateTime.Focus();
                }
                //3.3
                if (cbMaHD.SelectedIndex == -1 || cbMaNCC.SelectedIndex == -1 || cbYcmh.SelectedIndex == -1 || cbTrangThai.SelectedIndex == -1)
                {
                    okTao = false;
                    MessageBox.Show("Không được để trống các trường bắt buộc");
                    return;
                }
                //4.Chiết khấu là số thực và > 0 
                decimal chietkhau = 0;
                string input = txtChietkhau.Text.Replace(",", ".");
                if (!string.IsNullOrEmpty(txtChietkhau.Text))
                {
                    if (!decimal.TryParse(input, out chietkhau) || chietkhau <= 0 || chietkhau >= 1000) 
                    {
                        okTao = false;
                        MessageBox.Show("Chiết khấu phải là số thực lớn hơn 0 và nhỏ hơn 1000", "Lỗi dữ liệu", MessageBoxButtons.OK);
                        txtChietkhau.Focus();
                    }
                }
                if (okTao)
                {
                    DTODonhang dhmoi = new DTODonhang();
                    dhmoi.MaDMH = txtMaDMH.Text;
                    dhmoi.Ngaylap = dateTime.Value;
                    dhmoi.MaHDMH = cbMaHD.SelectedValue.ToString();
                    dhmoi.MaNV = txtMaNV.Text;
                    dhmoi.MaNCC = cbMaNCC.SelectedValue.ToString();
                    dhmoi.MaYC = cbYcmh.SelectedValue.ToString();
                    dhmoi.Tthai = cbTrangThai.SelectedValue.ToString();
                    dhmoi.Chietkhau = chietkhau;
                    dhmoi.Mota = txtMoTa.Text;
                    if (bllDonmua.Suadonhang(dhmoi))
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                    LoadDonmua();
                    txtMaDMH.Clear();
                    txtMaNV.Clear();
                    txtMoTa.Clear();
                    txtChietkhau.Clear();
                    txtMaDMH.Focus();
                }
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)    //gồm đưa dữ liệu vào ô và chỉnh sửa 
            {
                
                txtMaDMH.Text = dataGridView1.CurrentRow.Cells["MaDMH"].Value.ToString();
                dateTime.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["NgayLap"].Value);
                cbMaHD.SelectedValue = dataGridView1.CurrentRow.Cells["MaHDMH"].Value.ToString();
                txtMaNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
                cbYcmh.SelectedValue = dataGridView1.CurrentRow.Cells["MaYC"].Value.ToString();
                cbMaNCC.SelectedValue = dataGridView1.CurrentRow.Cells["MaNCC"].Value.ToString();
                cbTrangThai.SelectedValue = dataGridView1.CurrentRow.Cells["TThai"].Value.ToString();
                txtMoTa.Text = dataGridView1.CurrentRow.Cells["MoTa"].Value.ToString();
                txtChietkhau.Text = dataGridView1.CurrentRow.Cells["Chietkhau"].Value.ToString();
                txtMaDMH.Enabled = false;
                if (cbTrangThai.SelectedValue.ToString() == "Hoàn tất")
                {
                    cbTrangThai.Enabled = false;
                }
                else
                {
                    cbTrangThai.Enabled = true;
                }
                txtMaDMH.Enabled = false;
                cbLoc.SelectedIndex = -1;

             }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa đơn hàng này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    DTODonhang dhxoa = new DTODonhang();
                    dhxoa.MaDMH = dataGridView1.CurrentRow.Cells["MaDMH"].Value.ToString();
                    if (bllDonmua.Xoadonhang(dhxoa))
                    {
                        MessageBox.Show("Xóa đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadDonmua();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại, kiểm tra dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    }
                    txtMaDMH.Clear();
                    txtMaNV.Clear();
                    txtMoTa.Clear();
                    txtChietkhau.Clear();
                    txtMaDMH.Focus();
                }
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            string tukhoa = txtTimKiem.Text;
            DataTable dt = bllDonmua.TimDonhang(tukhoa);
            if (dt == null || dt.Rows.Count ==0)
            {
                MessageBox.Show("Không tìm thấy kết quả, hãy thử lại!", "Thông báo", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
            }    
            else
            {
                dataGridView1.DataSource = dt;
            }    
        }

        private void btnTheodoi_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            try
            {
                QLMHEntities4 db = new QLMHEntities4();
                var trangthaidon = from dm in db.DONMUAHANGs
                                   orderby dm.NgayLap descending 
                                   select new
                                   {
                                       dm.MaDMH,
                                       dm.NgayLap,
                                       dm.TThai
                                   };
                dataGridView1.DataSource = trangthaidon.ToList();
            }
            catch { MessageBox.Show("Không tìm thấy dữ liệu"); };
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            try
            {
                QLMHEntities4 db = new QLMHEntities4();
                var ttloc = from dm in db.DONMUAHANGs
                            where dm.TThai.Contains(cbLoc.SelectedValue.ToString())
                            select new 
                            {   dm.MaDMH,
                                dm.NgayLap,
                                dm.MaHDMH,
                                dm.MaYC,
                                dm.MaNV,
                                dm.MaNCC,
                                dm.Chietkhau,
                                dm.MoTa,
                                dm.TThai
                            };
                dataGridView1.DataSource = ttloc.ToList();  
            }
            catch { MessageBox.Show("Không tìm thấy dữ liệu"); };
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn hủy đơn mua hàng này không", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                QLMHEntities4 db = new QLMHEntities4();
                DONMUAHANG donmua = db.DONMUAHANGs.Find(txtMaDMH.Text);
                if (donmua != null)
                {
                    donmua.TThai = "Đã hủy";
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Hủy đơn mua hàng thành công");
                        LoadDonmua();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể hủy đơn hàng này!");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn 1 đơn hàng bạn muốn hủy");
                }
            }
        }

        private void btnChitietdm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 )
            {
                string madonmua = txtMaDMH.Text;    
                Chitietdonmua ctdonmua = new Chitietdonmua(madonmua);
                ctdonmua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn đơn hàng để xem chi tiết");
            } 
                
            
        }

        //Ẩn tooltip khi nhấn vào các nút khác 
        private void HideAllTooltips()
        {
            toolTip1.Hide(txtMaDMH);
            toolTip2.Hide(txtMaNV);
            toolTip3.Hide(txtChietkhau);
        }

        //Bỏ qua 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
        private void txtMaDMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
