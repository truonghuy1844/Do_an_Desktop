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
using PC_GUI.DAL;

namespace PC_GUI
{
    public partial class Quanlydonhang_NV : UserControl
    {
        BLL_DonMuaHang bllDonmua = new BLL_DonMuaHang();
        public DTONV nv = new DTONV();
        public Quanlydonhang_NV(DTONV nvien)
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
            }
        }

        //I.Load dữ liệu 
        //Load combobox lọc theo trạng thái 
        void loadloctt()
        {
            QLMHEntities4 db = new QLMHEntities4();
            var dstt = (from dm in db.DONMUAHANGs
                        select dm.TThai).Distinct().ToList();
            cbLoc.DataSource = dstt;
        }
        //Load đơn mua 
        void loaddonmua()
        {
            QLMHEntities4 db = new QLMHEntities4();
            var donMua = from dm in db.DONMUAHANGs
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
                             dm.TThai,
                             dm.MoTa
                         };
            dataGridView2.DataSource = donMua.ToList();
        }
        //Load mã hợp đồng 
        void loadhopdong()
        {
            QLMHEntities4 db = new QLMHEntities4();
            cbMaHD.DataSource = db.HOPDONGMHs.ToList();
            cbMaHD.DisplayMember = "MaHDMH";
            cbMaHD.ValueMember = "MaHDMH";
        }
        //Load nhà cung cấp 
        List<NHACUNGCAP> loadnhacc()
        {
            QLMHEntities4 db = new QLMHEntities4();
            
            var listncc = from ncc in db.NHACUNGCAPs
                          select ncc;
            
            listncc.Append(new NHACUNGCAP());
            return listncc.ToList();
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
        //Load cb lọc 
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
        private void Quanlydonhang_NV_Load(object sender, EventArgs e)
        {
            loaddonmua();
            loadloctt();
            loadhopdong();
            loadcbTrangthai();
            loadcbLoc();
            loadycmh();
            //load NCC 
            cbMaNCC.DataSource = loadnhacc();
            cbMaNCC.DisplayMember = "TenNCC";
            cbMaNCC.ValueMember = "MaNCC";
            dataGridView2.ReadOnly = true;

            cbLoc.SelectedIndex = -1;
            btnLuu.Enabled = false;
            txtMaDMH.Enabled = false;
            cbMaHD.SelectedIndex = -1;
            cbMaNCC.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            cbYcmh.SelectedIndex = -1;
            cbLoc.SelectedIndex = -1;

            //load đơn hoàn tất và chờ xử lý 
            txtDonht.Text = bllDonmua.donhoantat().ToString();
            txtChoxuly.Text = bllDonmua.doncho().ToString();

        }
        //II.Xử lý các nút 
        //LinQ 
        private void btnThongtin_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
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
                                 dm.TThai,
                                 dm.MoTa
                             };
            dataGridView2.DataSource = listdonmua.ToList();                  
        }

        private void btnTheodoi_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            QLMHEntities4 db = new QLMHEntities4();
            var listtheodoi = from dm in db.DONMUAHANGs
                              orderby dm.NgayLap descending
                              select new
                              {
                                  dm.MaDMH,
                                  dm.NgayLap,
                                  dm.TThai
                              };
            dataGridView2 .DataSource = listtheodoi.ToList();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            QLMHEntities4 db = new QLMHEntities4();
            var listloc = from dm in db.DONMUAHANGs
                          where dm.TThai == cbLoc.SelectedValue.ToString()
                          select new
                          {
                              dm.MaDMH,
                              dm.NgayLap,
                              dm.MaHDMH,
                              dm.MaYC,
                              dm.MaNV,
                              dm.MaNCC,
                              dm.Chietkhau,
                              dm.TThai,
                              dm.MoTa
                          };
            dataGridView2.DataSource = listloc.ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HideAllTooltips(); //ẩn tooltip 
            QLMHEntities4 db = new QLMHEntities4();
            
            var listtim = from dm in db.DONMUAHANGs
                          where dm.MaDMH.Contains(txtTimKiem.Text) || dm.MoTa.Contains(txtTimKiem.Text)
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
                              dm.TThai,
                              dm.MoTa
                          };
            if (listtim == null)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
            else
            {
                dataGridView2.DataSource = listtim.ToList();
            }
            
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                txtMaDMH.Text = dataGridView2.CurrentRow.Cells["MaDMH"].Value.ToString();
                dateTime2.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells["NgayLap"].Value);
                cbMaHD.SelectedValue = dataGridView2.CurrentRow.Cells["MaHDMH"].Value.ToString();
                cbMaNCC.SelectedValue = dataGridView2.CurrentRow.Cells["MaNCC"].Value.ToString();
                cbYcmh.SelectedValue = dataGridView2.CurrentRow.Cells["MaYC"].Value.ToString();
                txtMaNV.Text = dataGridView2.CurrentRow.Cells["MaNV"].Value.ToString();
                txtChietkhau.Text = dataGridView2.CurrentRow.Cells["Chietkhau"].Value.ToString();
                txtMoTa.Text = dataGridView2.CurrentRow.Cells["MoTa"].Value.ToString();
                cbTrangThai.SelectedValue = dataGridView2.CurrentRow.Cells["TThai"].Value.ToString();

                txtMaDMH.Enabled = false;
                if (cbTrangThai.SelectedValue.ToString() == "Hoàn tất" || cbTrangThai.SelectedValue.ToString() == "Đã hủy")
                {
                    cbTrangThai.Enabled = false;
                }
                else
                {
                    cbTrangThai.Enabled = true;
                }
                cbLoc.SelectedIndex = -1;
                HideAllTooltips();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            HideAllTooltips();
            //Mở khóa các textbox 
            txtMaDMH.Enabled = true;
            dateTime2.Enabled = true;
            txtMaNV.Enabled = true; cbMaNCC.Enabled = true;
            cbMaHD.Enabled = true; cbTrangThai.Enabled = true;
            txtMoTa.Enabled = true; txtChietkhau.Enabled = true;
            //Làm trống dữ liệu 
            txtMaDMH.Focus();
            txtMaDMH.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtChietkhau.Text = string.Empty;
            dateTime2.Value = DateTime.Now;
            cbMaNCC.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            cbMaHD.SelectedIndex = -1;
            cbYcmh.SelectedIndex = -1;
            //Mở lưu
            btnLuu.Enabled = true;

        }
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

        private void txtMaDMH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDMH.Text.Length >= 6 &&
               txtMaDMH.Text.Length <= 10 &&
               txtMaDMH.Text.All(char.IsLetterOrDigit) &&
               txtMaDMH.Text.StartsWith("DMH"))
            {
                toolTip1.Hide(txtMaDMH);
            }
        }

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

        private void dateTime2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime2.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                dateTime2.Value = DateTime.Now;
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
                return;
            }
            //1.3 Mã trường tối thiểu 6, tối đa 10 
            if ((txtMaDMH.Text.Length < 6) || (txtMaDMH.Text.Length > 10))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng tối thiểu 6 ký tự và không quá 10 ký tự");
                txtMaDMH.Focus();
                return;
            }
            //1.4 Mã trường không được lặp lại 
            if (bllDonmua.Kiemtramadmh(txtMaDMH.Text))
            {
                okTao = false;
                MessageBox.Show("Mã đơn hàng đã tồn tại trong hệ thống, hãy nhập mã khác");
                txtMaDMH.Focus();
                return;
            }
            //2.Kiêm tra trường mã nhân viên 
            //2.1 Mã nhân viên không được trống 
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                okTao = false;
                MessageBox.Show("Mã nhân viên không được để trống !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            //2.2 Mã nhân viên chỉ được chứa ký tự chữ và số 
            if (!txtMaNV.Text.All(char.IsLetterOrDigit) || !txtMaNV.Text.StartsWith("NV"))
            {
                okTao = false;
                MessageBox.Show("Mã nhân viên chỉ chứa ký tự chữ, số và bắt đầu bằng 'NV'!", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            //2.3 Mã nhân viên tối thiểu 5, tối đa 10 
            if ((txtMaDMH.Text.Length < 5) || (txtMaDMH.Text.Length > 10))
            {
                okTao = false;
                MessageBox.Show("Mã nhân viên tối thiểu 5 ký tự và không quá 10 ký tự");
                txtMaNV.Focus();
                return;
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
                    MessageBox.Show("Chiết khấu là số thực lớn hơn 0 và nhỏ hơn 1000! Nếu không có, hãy điền '0'", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtChietkhau.Focus();
                    return;
                }
            }
            if (okTao)
            {
                DONMUAHANG donmua = new DONMUAHANG();
                donmua.MaDMH = txtMaDMH.Text;
                donmua.NgayLap = dateTime2.Value;
                donmua.MaHDMH = cbMaHD.SelectedValue.ToString();
                donmua.MaYC = cbYcmh.SelectedValue.ToString();
                donmua.MaNV = txtMaNV.Text;
                donmua.MaNCC = cbMaNCC.SelectedValue.ToString();
                donmua.Chietkhau = chietkhau;
                donmua.MoTa = txtMoTa.Text;
                donmua.TThai = cbTrangThai.SelectedValue.ToString();

                QLMHEntities4 db = new QLMHEntities4();
                
                
                try
                {
                    db.DONMUAHANGs.Add(donmua);
                    db.SaveChanges();
                    MessageBox.Show("Tạo đơn hàng mới thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch ( Exception ex)
                {
                    MessageBox.Show("Tạo đơn hàng mới thất bại", ex.Message );
                }
                
                loaddonmua();
                btnLuu.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool okSua = true;
            //2.Kiêm tra trường mã nhân viên 
            //2.1 Mã nhân viên không được trống 
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                okSua = false;
                MessageBox.Show("Mã nhân viên không được để trống !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaNV.Text = dataGridView2.CurrentRow.Cells["MaNV"].Value.ToString();
                txtMaNV.Focus();
                return;
            }
            //2.2 Mã nhân viên chỉ được chứa ký tự chữ và số 
            if (!txtMaNV.Text.All(char.IsLetterOrDigit) || !txtMaNV.Text.StartsWith("NV"))
            {
                okSua = false;
                MessageBox.Show("Mã nhân viên chỉ chứa ký tự chữ, số và bắt đầu bằng 'NV'!", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaNV.Text = dataGridView2.CurrentRow.Cells["MaNV"].Value.ToString();
                txtMaNV.Focus();
                return;
            }
            //2.3 Mã nhân viên tối thiểu 5, tối đa 10 
            if ((txtMaDMH.Text.Length < 5) || (txtMaDMH.Text.Length > 10))
            {
                okSua = false;
                MessageBox.Show("Mã nhân viên tối thiểu 5 ký tự và không quá 10 ký tự");
                txtMaNV.Text = dataGridView2.CurrentRow.Cells["MaNV"].Value.ToString();
                txtMaNV.Focus();
                return;
            }
            //3.NV không thể cập nhật trạng thái "Chờ xử lý" -> "Đã hủy" 
            if (cbTrangThai.SelectedValue.ToString() == "Đã hủy" && dataGridView2.CurrentRow.Cells["TThai"].Value.ToString() == "Chờ xử lý")
            {
                okSua = false;
                MessageBox.Show("Nhân viên không thể hủy đơn hàng"); 
                return;
            }
            //3.Không để trống các combobox 
            if (cbMaHD.SelectedIndex == -1 || cbMaNCC.SelectedIndex == -1 || cbYcmh.SelectedIndex == -1 || cbTrangThai.SelectedIndex == -1)
            {
                okSua = false;
                MessageBox.Show("Không được để trống các trường bắt buộc");
                return;
            }
            //4.Chiết khấu là số thực và > 0 
            decimal chietkhau = 0;
            string input = txtChietkhau.Text.Replace(",",".");
            if (!string.IsNullOrEmpty(txtChietkhau.Text))
            {
                if (!decimal.TryParse(input, out chietkhau) || chietkhau < 0 || chietkhau >= 1000)
                {
                    okSua = false;
                    MessageBox.Show("Chiết khấu là số thực lớn hơn 0 và nhỏ hơn 1000! Nếu không có, hãy điền '0'", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtChietkhau.Focus();
                    return;
                }
            }
            if (okSua)
            {
                QLMHEntities4 db = new QLMHEntities4();
                
                try
                {
                    //DONMUAHANG donmua = (from dm in db.DONMUAHANGs
                    //                        where dm.MaDMH == txtMaDMH.Text
                    //                        select dm).Single<DONMUAHANG>();
                    DONMUAHANG donmua = db.DONMUAHANGs.Find(txtMaDMH.Text.Trim());
                    if (donmua != null)
                    {
                        donmua.NgayLap = dateTime2.Value;
                        donmua.MaHDMH = cbMaHD.SelectedValue.ToString();
                        donmua.MaNV = txtMaNV.Text;
                        donmua.MaNCC = cbMaNCC.SelectedValue.ToString();
                        donmua.MaYC = cbYcmh.SelectedValue.ToString();
                        donmua.Chietkhau = chietkhau;
                        donmua.TThai = cbTrangThai.SelectedValue.ToString();
                        donmua.MoTa = txtMoTa.Text;

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex) { MessageBox.Show("Cập nhật đơn hàng thất bại", ex.Message); }
                finally {  }
                loaddonmua();
            }

        }
        private void btnChitiet_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string madonmua = dataGridView2.CurrentRow.Cells["MaDMH"].Value.ToString();
                Chitietdonmua_NV ctdm_nv = new Chitietdonmua_NV(madonmua);
                ctdm_nv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn đơn hàng để xem chi tiết");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhân viên không được xóa đơn hàng","Thông báo",MessageBoxButtons.OK);
            //NV không được xóa 
        }

        //Ẩn tooltip khi nhấn vào các nút khác 
        private void HideAllTooltips()
        {
            toolTip1.Hide(txtMaDMH);
            toolTip2.Hide(txtMaNV);
            toolTip3.Hide(txtChietkhau);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
