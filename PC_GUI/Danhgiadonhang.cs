using PC_BLL;
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

namespace PC_GUI
{
    public partial class Danhgiadonhang : Form
    {
        public Danhgiadonhang()
        {
            InitializeComponent();
        }
        BLLDonmuahang bllDonmmua = new BLLDonmuahang();
        void LoadChitietdon() // load danh sách đơn hàng vào datagridview 
        {
            QLMHEntities db = new QLMHEntities();
            var listchitiet = from dm in db.CT_DONMUAHANG
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
            QLMHEntities db = new QLMHEntities();
            var lichsu = from ls in db.DANHGIASP_TRONGDON
                         select new
                         {
                             ls.MaDGSP,
                             ls.NgayDG,
                             ls.MaSP,
                             ls.MaDMH,
                             ls.MoTaDG,
                             ls.DiemDG,
                             ls.MucdoDG,
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
            cbDiemdanhgia.DataSource = diemdg;
            cbDiemdanhgia.DisplayMember = "Diemdg";
            cbDiemdanhgia.ValueMember = "Thutu";
        }


        private void Danhgiadonhang_Load(object sender, EventArgs e)
        {
            //LoadSanPham();
            loaddiemdg();
            txtMaDGSP.Enabled = false; 
            cbDiemdanhgia.SelectedIndex = -1;  
            datetime1.Value = DateTime.Now;
            //load vào comboboxMaDH
            cbMaDH.DataSource = bllDonmmua.loaddmh();
            cbMaDH.DisplayMember = "MaDMH";
            cbMaDH.ValueMember = "MaDMH";
            cbMaDH.SelectedIndex = -1;

            btnLuu.Enabled = false;
        }

        private void btnChitietdon_Click(object sender, EventArgs e)
        {
            LoadChitietdon();
        }


        private void btnLichsu_Click(object sender, EventArgs e)
        {
            loadlichsudg();
        }

        private void btnTaodg_Click(object sender, EventArgs e)
        {
            txtMaDGSP.Enabled = true; cbMaDH.Enabled = true; cbTensp.Enabled = true; 
            cbDiemdanhgia.Enabled = true; txtDanhgia.Enabled = true; txtGhichu.Enabled = true;
            datetime1.Enabled = true;
            txtMaDGSP.Text = string.Empty;   txtMucdgia.Text = string.Empty;
            txtDanhgia.Text = string.Empty; txtGhichu.Text = string.Empty;
            cbMaDH.SelectedIndex = -1; cbDiemdanhgia.SelectedIndex = -1;
            cbTensp.SelectedIndex = -1; 
            txtMaDGSP.Focus();
            btnLuu.Enabled = true;
            btnTaodg.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool kiemtra = true;
            if ( txtMaDGSP.Text.Length == 0)
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
                MessageBox.Show("Mã đánh giá đã tồn tại trong hệ thống","Thông báo", MessageBoxButtons.OK);
                txtMaDGSP.Focus();
            }
            //2.Ngày không được lớn hơn ngày hiện tại 
            if (datetime1.Value > DateTime.Now)
            {
                kiemtra = false;
                MessageBox.Show("Ngày tạo đánh giá không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                datetime1.Focus();
            }
            if (kiemtra)
            {
                DANHGIASP_TRONGDON_LQ dgsp = new DANHGIASP_TRONGDON_LQ();
                dgsp.MaDGSP = txtMaDGSP.Text;
                dgsp.NgayDG = datetime1.Value;
                dgsp.MaSP = cbTensp.SelectedValue.ToString();
                dgsp.MaDMH = cbMaDH.SelectedValue.ToString();
                dgsp.MoTaDG = txtDanhgia.Text;
                dgsp.DiemDG = Convert.ToInt32(cbDiemdanhgia.SelectedValue);
                dgsp.MucdoDG = txtMucdgia.Text;
                dgsp.GhiChu = txtGhichu.Text;
                QLMHDataContext da = new QLMHDataContext();
                da.Connection.Open(); // mở 
                try
                {
                    da.DANHGIASP_TRONGDON_LQs.InsertOnSubmit(dgsp);
                    da.SubmitChanges();
                    MessageBox.Show("Đánh giá thành công!");
                }
                catch (Exception ex)
                { MessageBox.Show("Lỗi", ex.Message); }
                da.Connection.Close(); // đóng 

                loadlichsudg();
                btnLuu.Enabled = false;
                btnTaodg.Enabled = true;
            }
        }
        //Viết bằng EF 

        private void cbDiemdanhgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiemdanhgia.SelectedItem != null)
            {
                //int diemdanhgia = Convert.ToInt32(cbDiemdanhgia.SelectedValue);
                switch (cbDiemdanhgia.SelectedValue)
                {
                    case 1 :
                        txtMucdgia.Text = "Kém";
                        break;
                    case 2 :
                        txtMucdgia.Text = "Kém";
                        break;
                    case 3:
                        txtMucdgia.Text = "Trung bình";
                        break;
                    case 4:
                        txtMucdgia.Text = "Tốt";
                        break;
                    case 5:
                        txtMucdgia.Text = "Tốt";
                        break;
                    default:
                        txtMucdgia.Text = string.Empty;
                        break;
                }
            }    
        }
        //Nút cập nhật 
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool okSua = true;
            //1.Mã đơn mua hàng không được trống 
            if (cbMaDH.SelectedIndex == -1)
            {
                okSua = false;
                MessageBox.Show("Mã đơn mua hàng không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                cbMaDH.Focus();
            }
            //2.Điểm đánh giá không được trống 
            if (cbDiemdanhgia.SelectedIndex == -1)
            {
                okSua = false;
                MessageBox.Show("Hãy chọn điểm đánh giá cho sản phẩm", "Thông báo", MessageBoxButtons.OK);
                cbDiemdanhgia.Focus();
            }
            //3.Ngày không được lớn hơn ngày hiện tại 
            if (datetime1.Value > DateTime.Now)
            {
                okSua = false;
                MessageBox.Show("Ngày tạo đánh giá không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                datetime1.Focus();
            }
            if (okSua)
            {
                QLMHEntities db = new QLMHEntities();
                DANHGIASP_TRONGDON dg = db.DANHGIASP_TRONGDON.Find(txtMaDGSP.Text);
                if (dg != null)
                {
                    dg.NgayDG = datetime1.Value;
                    dg.DiemDG = Convert.ToInt32(cbDiemdanhgia.SelectedValue);
                    dg.MucdoDG = txtMucdgia.Text;
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
                QLMHEntities db = new QLMHEntities();
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
                cbTensp.SelectedValue = dataGridViewChitiet.CurrentRow.Cells["MaSP"].Value.ToString();
                cbDiemdanhgia.SelectedValue = Convert.ToInt32(dataGridViewChitiet.CurrentRow.Cells["DiemDG"].Value);
                txtMucdgia.Text = dataGridViewChitiet.CurrentRow.Cells["MucdoDG"].Value.ToString();
                txtDanhgia.Text = dataGridViewChitiet.CurrentRow.Cells["MoTaDG"].Value.ToString();
                txtGhichu.Text = dataGridViewChitiet.CurrentRow.Cells["GhiChu"].Value ==null? string.Empty :
                dataGridViewChitiet.CurrentRow.Cells["GhiChu"].Value.ToString();

                cbMaDH.Enabled = false;
                cbTensp.Enabled = false;
            }    
        }
        //Cbtensp tự động hiển thị theo cbMaDH 
        private void cbMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLMHEntities db = new QLMHEntities();
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
    }
}
