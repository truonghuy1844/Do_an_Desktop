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
    public partial class Danhgiadonhang_NV : Form
    {
        public Danhgiadonhang_NV()
        {
            InitializeComponent();
        }
        BLLDonmuahang bllDonmua = new BLLDonmuahang();
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
        // load danh sách đơn hàng vào datagridview 
        void LoadChitietdon() 
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
        private void btnLichsu_Click(object sender, EventArgs e)
        {
            loadlichsudg();
        }
        private void btnChitietdon_Click(object sender, EventArgs e)
        {
            LoadChitietdon();
        }

        private void Danhgiadonhang_NV_Load(object sender, EventArgs e)
        {
            //LoadSanPham();
            loaddiemdg();
            txtMaDGSP.Enabled = false;
            cbDiemdanhgia.SelectedIndex = -1;
            datetime1.Value = DateTime.Now;
            //load vào comboboxMaDH
            cbMaDH.DataSource = bllDonmua.loaddmh();
            cbMaDH.DisplayMember = "MaDMH";
            cbMaDH.ValueMember = "MaDMH";
            cbMaDH.SelectedIndex = -1;

        }

        private void btnTaodg_Click(object sender, EventArgs e)
        {
            txtMaDGSP.Enabled = true; cbMaDH.Enabled = true; cbTensp.Enabled = true;
            cbDiemdanhgia.Enabled = true; txtDanhgia.Enabled = true; txtGhichu.Enabled = true;
            datetime1.Enabled = true;
            txtMaDGSP.Text = string.Empty; txtMucdgia.Text = string.Empty;
            txtDanhgia.Text = string.Empty; txtGhichu.Text = string.Empty;
            cbMaDH.SelectedIndex = -1; cbDiemdanhgia.SelectedIndex = -1;
            cbTensp.SelectedIndex = -1;
            txtMaDGSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool kiemtra = true;
            if (txtMaDGSP.Text.Length == 0)
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
            if (bllDonmua.Kiemtramadgsp(txtMaDGSP.Text))
            {
                kiemtra = false;
                MessageBox.Show("Mã đánh giá đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
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
            }
        }

        private void cbDiemdanhgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiemdanhgia.SelectedItem != null)
            {
                //int diemdanhgia = Convert.ToInt32(cbDiemdanhgia.SelectedValue);
                switch (cbDiemdanhgia.SelectedValue)
                {
                    case 1:
                        txtMucdgia.Text = "Kém";
                        break;
                    case 2:
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

      
    }
}
