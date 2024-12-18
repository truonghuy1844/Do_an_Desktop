using PC_GUI.BLL;
using PC_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PC_GUI.DAL;

namespace PC_GUI
{
    public partial class Danhgiadonhang : UserControl
    {
        
        public Danhgiadonhang()
        {
            InitializeComponent();
            
        }
        BLL_DonMuaHang bllDonmmua = new BLL_DonMuaHang();

        //Load danh sách đơn mua
        void load_DS_DMH()
        {
            QLMHEntities3 db = new QLMHEntities3();
            var ctdg = from ds in db.DONMUAHANGs
                       join ncc in db.NHACUNGCAPs
                       on ds.MaNCC equals ncc.MaNCC                       
                       select new
                       {
                           MaDMH = ds.MaDMH,
                           MaNCC = ds.MaNCC,
                           TenNCC = ncc.TenNCC,
                           MoTa = ds.MoTa,
                           TrangThai = ds.TThai
                       };
            dataGridViewChitiet.DataSource = ctdg.ToList();
        }

        //Load đánh giá theo chi tiết đơn mua 
        void loaddgtheodonmua(string maDMH, string maSP)
        {
            QLMHEntities3 db = new QLMHEntities3();
            var ctdg = from ls in db.DANHGIASP_TRONGDON
                       where ls.MaDMH == maDMH && ls.MaSP == maSP
                       select new
                       {
                           ls.MaDGSP,
                           ls.NgayDG,
                           ls.MaSP,
                           ls.MaDMH,
                           ls.MoTaDG,
                           ls.DiemChatLuong,
                           ls.DiemHieuQua,
                           ls.DiemGiaCa,
                           ls.GhiChu
                       };
            dataGridViewChitiet.DataSource = ctdg.ToList();
        }
        void LoadChitietdon(string maDMH) // load danh sách đơn hàng vào datagridview 
        {
            QLMHEntities3 db = new QLMHEntities3();
            var listchitiet = from dm in db.CT_DONMUAHANG
                              where dm.MaDMH == maDMH
                              select new
                              {
                                  dm.MaDMH,
                                  dm.MaSP,  
                                  dm.SANPHAM.TenSP,
                                  dm.MaBG,
                                  dm.SoLuong
                              };
            dataGridViewChitiet.DataSource = listchitiet.ToList();
        }

        void loadlichsudg()
        {
            QLMHEntities3 db = new QLMHEntities3();
            var lichsu = from ls in db.DANHGIASP_TRONGDON
                         orderby ls.NgayDG descending 
                         select new
                         {
                             ls.MaDGSP,
                             ls.NgayDG,
                             ls.MaSP,
                             ls.MaDMH,
                             ls.MoTaDG,
                             ls.DiemChatLuong,
                             ls.DiemHieuQua,
                             ls.DiemGiaCa,
                             ls.GhiChu
                         };
            dataGridViewChitiet.DataSource = lichsu.ToList();
        }
        //loaddiemdanhgia
        void loaddiemdg()
        {
            List<DTODiemDG> diemdg = new List<DTODiemDG>
            {
                new DTODiemDG { Thutu = 1, Diemdg = 1},
                new DTODiemDG { Thutu = 2, Diemdg = 2},
                new DTODiemDG { Thutu = 3, Diemdg = 3},
                new DTODiemDG { Thutu = 4, Diemdg = 4},
                new DTODiemDG { Thutu = 5, Diemdg = 5},
            };
            cbChatluong.DataSource = diemdg;
            cbChatluong.DisplayMember = "Diemdg";
            cbChatluong.ValueMember = "Thutu";

            cBHieuqua.DataSource = diemdg;
            cBHieuqua.DisplayMember = "Diemdg";
            cBHieuqua.ValueMember = "Thutu";

            cbGiaca.DataSource = diemdg;
            cbGiaca.DisplayMember = "Diemdg";
            cbGiaca.ValueMember = "Thutu";

        }


        private void Danhgiadonhang_Load(object sender, EventArgs e)
        {
            loadlichsudg();
            //loaddgtheodonmua();
            loaddiemdg();
            txtMaDGSP.Enabled = false; 
            datetimedanhgia.Value = DateTime.Now;
            //load vào comboboxMaDH
            cbMaDH.DataSource = bllDonmmua.loaddmh();
            cbMaDH.DisplayMember = "MaDMH";
            cbMaDH.ValueMember = "MaDMH";
            cbMaDH.SelectedIndex = -1;

            btnLuu.Enabled = false;
            //cb Đánh giá 
            cbChatluong.SelectedIndex = -1;
            cBHieuqua.SelectedIndex = -1;
            cbGiaca.SelectedIndex = -1;
        }

        private void btnChitietdon_Click(object sender, EventArgs e)
        {
            //HideAllTooltips();
            //LoadChitietdon();
        }


        private void btnLichsu_Click(object sender, EventArgs e)
        {
            HideAllTooltips();
            loadlichsudg();
        }

        private void btnTaodg_Click(object sender, EventArgs e)
        {
            HideAllTooltips();
            txtMaDGSP.Enabled = true; cbMaDH.Enabled = true; cbTensp.Enabled = true; 
            cbChatluong.Enabled = true; txtDanhgia.Enabled = true; txtGhichu.Enabled = true;
            datetimedanhgia.Enabled = true;
            txtMaDGSP.Text = string.Empty;  
            txtDanhgia.Text = string.Empty; txtGhichu.Text = string.Empty;
            cbMaDH.SelectedIndex = -1; 
            cbChatluong.SelectedIndex = -1;
            cbGiaca.SelectedIndex = -1;
            cBHieuqua.SelectedIndex = -1;
            cbTensp.SelectedIndex = -1; 
            txtMaDGSP.Focus();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool kiemtra = true;

            //1.Mã đánh giá không được trống 
            if (string.IsNullOrWhiteSpace(txtMaDGSP.Text))
            {
                kiemtra = false;
                MessageBox.Show("Mã đánh giá không được để trống !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaDGSP.Focus();
            }
            //1.2 Mã trường chỉ được chứa ký tự chữ và số 
            if (!txtMaDGSP.Text.All(char.IsLetterOrDigit) || !txtMaDGSP.Text.StartsWith("DGSP"))
            {
                kiemtra = false;
                MessageBox.Show("Mã đánh giá chỉ chứa ký tự chữ, số và bắt đầu bằng 'DGSP' !", "Lỗi dữ liệu", MessageBoxButtons.OK);
                txtMaDGSP.Focus();
            }
            //1.3 Mã trường tối thiểu 7, tối đa 10 
            if ((txtMaDGSP.Text.Length < 6) || (txtMaDGSP.Text.Length > 10))
            {
                kiemtra = false;
                MessageBox.Show("Mã đánh giá tối thiểu 7 ký tự và không quá 10 ký tự");
                txtMaDGSP.Focus();
            }
            //1.4 Mã trường không được lặp lại 
            if (bllDonmmua.Kiemtramadgsp(txtMaDGSP.Text))
            {
                kiemtra = false;
                MessageBox.Show("Mã đánh giá đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                txtMaDGSP.Focus();
            }
            //2.Mã đơn mua hàng không được trống 
            if (cbMaDH.SelectedIndex == -1)
            {
                kiemtra = false;
                MessageBox.Show("Mã đơn mua hàng không được để trống", "Thông báo", MessageBoxButtons.OK);
                cbMaDH.Focus();

            }
            //3.Điểm đánh giá 
            if (cbChatluong.SelectedIndex == -1 && cBHieuqua.SelectedIndex == -1 && cbGiaca.SelectedIndex == -1)
            {
                kiemtra = false;
                MessageBox.Show("Đánh giá tối thiểu một tiêu chí", "Thông báo", MessageBoxButtons.OK);
            }
            if (kiemtra)
            {
                DANHGIASP_TRONGDON dgsp = new DANHGIASP_TRONGDON();
                dgsp.MaDGSP = txtMaDGSP.Text;
                dgsp.NgayDG = datetimedanhgia.Value;
                dgsp.MaSP = cbTensp.SelectedValue.ToString();
                dgsp.MaDMH = cbMaDH.SelectedValue.ToString();
                dgsp.MoTaDG = txtDanhgia.Text;
                dgsp.DiemChatLuong = Convert.ToInt32(cbChatluong.SelectedValue);
                dgsp.DiemHieuQua = Convert.ToInt32(cBHieuqua.SelectedValue);
                dgsp.DiemGiaCa = Convert.ToInt32(cbGiaca.SelectedValue);
                dgsp.GhiChu = txtGhichu.Text;
                QLMHEntities3 da = new QLMHEntities3();
                
                try
                {
                    da.DANHGIASP_TRONGDON.Add(dgsp);
                    da.SaveChanges();
                    MessageBox.Show("Đánh giá thành công!");
                }
                catch (Exception ex)
                { MessageBox.Show("Lỗi", ex.Message); }
                

                loadlichsudg();
                btnLuu.Enabled = false;
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Nút cập nhật 
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool okSua = true;
            //1 Mô tả đánh giá không được trống 
            if (string.IsNullOrWhiteSpace(txtDanhgia.Text))
            {
                okSua = false;
                MessageBox.Show("Mô tả đánh giá không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                cbMaDH.Focus();
            }
            //3.Điểm đánh giá 
            if (cbChatluong.SelectedIndex == -1 && cBHieuqua.SelectedIndex == -1 && cbGiaca.SelectedIndex == -1)
            {
                okSua = false;
                MessageBox.Show("Đánh giá tối thiểu một tiêu chí", "Thông báo", MessageBoxButtons.OK);
            }
            if (okSua)
            {
                QLMHEntities3 db = new QLMHEntities3();
                DANHGIASP_TRONGDON dg = db.DANHGIASP_TRONGDON.Find(txtMaDGSP.Text);
                if (dg != null)
                {
                    dg.NgayDG = datetimedanhgia.Value;
                    dg.DiemChatLuong = Convert.ToInt32(cbChatluong.SelectedValue);
                    dg.DiemHieuQua= Convert.ToInt32(cBHieuqua.SelectedValue);
                    dg.DiemGiaCa = Convert.ToInt32(cbGiaca.SelectedValue);
                    dg.MoTaDG = txtDanhgia.Text;
                    dg.GhiChu = txtGhichu.Text;
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật đánh giá thành công");
                        loadlichsudg();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Cập nhật đánh giá thất bại", ex.Message); }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một đánh giá để sửa");
                }
            }    
        }
        //Nút xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn xóa đánh giá này không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                QLMHEntities3 db = new QLMHEntities3();
                DANHGIASP_TRONGDON dg = db.DANHGIASP_TRONGDON.Find(txtMaDGSP.Text);
                if (dg != null)
                {
                    try
                    {
                        db.DANHGIASP_TRONGDON.Remove(dg);
                        db.SaveChanges();
                        MessageBox.Show("Xóa đánh giá thành công");
                        loadlichsudg();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Xóa đánh giá thất bại", ex.Message); }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một đánh giá để xóa! ");
                }
            }
        }
        //Click vào hàng hiện dữ liệu 
        private void dataGridViewChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewChitiet.CurrentRow != null)
            {
                txtMaDGSP.Text = dataGridViewChitiet.CurrentRow.Cells["MaDGSP"].Value.ToString();
                cbMaDH.SelectedValue = dataGridViewChitiet.CurrentRow.Cells["MaDMH"].Value.ToString();
                //Gọi tên sp theo MaDH 
                cbMaDH_SelectedIndexChanged(sender, e);
                cbTensp.SelectedValue = dataGridViewChitiet.CurrentRow.Cells["MaSP"].Value.ToString();
                cbChatluong.SelectedValue = Convert.ToInt32(dataGridViewChitiet.CurrentRow.Cells["DiemChatLuong"].Value);
                cBHieuqua.SelectedValue = Convert.ToInt32(dataGridViewChitiet.CurrentRow.Cells["DiemHieuQua"].Value);
                cbGiaca.SelectedValue = Convert.ToInt32(dataGridViewChitiet.CurrentRow.Cells["DiemGiaCa"].Value);
                txtDanhgia.Text = dataGridViewChitiet.CurrentRow.Cells["MoTaDG"].Value.ToString();
                txtGhichu.Text = dataGridViewChitiet.CurrentRow.Cells["GhiChu"].Value == null ? string.Empty :
                dataGridViewChitiet.CurrentRow.Cells["GhiChu"].Value.ToString();
                datetimedanhgia.Value = Convert.ToDateTime(dataGridViewChitiet.CurrentRow.Cells["NgayDG"].Value);

                cbMaDH.Enabled = false;
                cbTensp.Enabled = false;
                txtMaDGSP.Enabled = false;
            }
        }
        //Cbtensp tự động hiển thị theo cbMaDH 
        private void cbMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLMHEntities3 db = new QLMHEntities3();
            if (cbMaDH.SelectedIndex != -1)
            {
                string madhchon = cbMaDH.SelectedValue.ToString();
                var listsanpham = (from sp in db.CT_DONMUAHANG
                                   where sp.MaDMH == madhchon
                                   select new
                                   {
                                       sp.MaSP,
                                       sp.SANPHAM.TenSP,
                                   }).ToList();
                cbTensp.DataSource = listsanpham;
                cbTensp.DisplayMember = "TenSP";
                cbTensp.ValueMember = "MaSP";
            }
        }
        private void cbTensp_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void txtMucdgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDGSP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDGSP.Text))
            {
                toolTip1.Show("Mã đánh giá không được để trống !", txtMaDGSP, 0, txtMaDGSP.Height);
            }
            //1.2 Mã trường chỉ được chứa ký tự chữ và số 
            else if (!txtMaDGSP.Text.All(char.IsLetterOrDigit) || !txtMaDGSP.Text.StartsWith("DGSP"))
            {
                toolTip1.Show("Mã đánh giá chỉ chứa ký tự chữ, số và bắt đầu bằng 'DGSP' !",txtMaDGSP, 0, txtMaDGSP.Height);
            }
            //1.3 Mã trường tối thiểu 7, tối đa 10 
            else if ((txtMaDGSP.Text.Length < 7) || (txtMaDGSP.Text.Length > 10))
            {
                toolTip1.Show("Mã đánh giá tối thiểu 7 ký tự và không quá 10 ký tự! ",txtMaDGSP, 0, txtMaDGSP.Height);
            }
            else
            {
                toolTip1.Hide(txtMaDGSP);
            }    
        }

        private void txtMaDGSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDGSP.Text.Length > 0 &&
                txtMaDGSP.Text.All(char.IsLetterOrDigit) && 
                txtMaDGSP.Text.StartsWith("DGSP") &&
                txtMaDGSP.Text.Length >= 7 && 
                txtMaDGSP.Text.Length <= 10 )
            {
                toolTip1.Hide(txtMaDGSP);
            }    
        }

        private void datetime1_ValueChanged(object sender, EventArgs e)
        {
            if (datetimedanhgia.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày tạo đánh giá không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                datetimedanhgia.Value = DateTime.Now;
            }
        }

        private void HideAllTooltips()
        {
            toolTip1.Hide(txtMaDGSP);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                QLMHEntities3 db = new QLMHEntities3();
                var listtim = from dg in db.DANHGIASP_TRONGDON
                              where dg.NgayDG >= dateTimebatdau.Value && dg.NgayDG <= dateTimeketthuc.Value
                              select new
                              {
                                  dg.MaDGSP,
                                  dg.NgayDG,
                                  dg.MaSP,
                                  dg.MaDMH,
                                  dg.MoTaDG,
                                  dg.DiemChatLuong,
                                  dg.DiemHieuQua,
                                  dg.DiemGiaCa,
                                  dg.GhiChu
                              };
                dataGridViewChitiet.DataSource = listtim.ToList();
                if (!listtim.ToList().Any())
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    loadlichsudg();
                }
                else
                {
                    dataGridViewChitiet.DataSource = listtim.ToList();
                }

            }
            else
            {
                QLMHEntities3 db = new QLMHEntities3();
                var listtimp = from dg in db.DANHGIASP_TRONGDON
                               where dg.SANPHAM.TenSP.Contains(txtTim.Text.Trim())
                               && dg.NgayDG >= dateTimebatdau.Value
                               && dg.NgayDG <= dateTimeketthuc.Value
                               select new
                               {
                                   dg.MaDGSP,
                                   dg.NgayDG,
                                   dg.MaSP,
                                   dg.MaDMH,
                                   dg.MoTaDG,
                                   dg.DiemChatLuong,
                                   dg.DiemHieuQua,
                                   dg.DiemGiaCa,
                                   dg.GhiChu
                               };
                if (!listtimp.ToList().Any())
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    loadlichsudg();
                }
                else
                {
                    dataGridViewChitiet.DataSource = listtimp.ToList();
                }
                
            }    
        }
    }
}
