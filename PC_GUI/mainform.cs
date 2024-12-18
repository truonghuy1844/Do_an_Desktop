
using PC_DTO;
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

namespace PC_GUI
{
    public partial class frmMainForm : Form
    {
        BLL_NhanVien bLLNhanVien = new BLL_NhanVien();
        public DTONV nv_DN = new DTONV();
        public frmMainForm(DTONV nhanVien)
        {
            InitializeComponent();
            pnMenuDoc.Size = pnMenuDoc.MinimumSize;
            nv_DN = nhanVien;
            this.Size = new System.Drawing.Size(915, 720);
            
        }

        #region Xử lý submenu

        private void btnFormNCC_Click(object sender, EventArgs e)
        {
            if (pnContainerNCC.Size == pnContainerNCC.MinimumSize)
            {
                pnContainerNCC.Size = pnContainerNCC.MaximumSize;
            }
            else pnContainerNCC.Size = MinimumSize;
        }

        private void btnFormDonHang_Click(object sender, EventArgs e)
        {
            //ToggleSubMenu(pnDonHang);
            if (pnDonHang.Size == pnDonHang.MinimumSize)
            {
                pnDonHang.Size = pnDonHang.MaximumSize;
            }
            else pnDonHang.Size = MinimumSize;

        }

        private void btnFormYeuCauMua_Click(object sender, EventArgs e)
        {
            if (pnYeuCauMua.Size == pnYeuCauMua.MinimumSize)
            {
                pnYeuCauMua.Size = pnYeuCauMua.MaximumSize;
            }
            else pnYeuCauMua.Size= pnYeuCauMua.MinimumSize;
        }

        private void btnFormNguonLuc_Click(object sender, EventArgs e)
        {
            if (pnNguonLuc.Size == pnNguonLuc.MinimumSize)
            {
                pnNguonLuc.Size = pnNguonLuc.MaximumSize;
            }
            else pnNguonLuc.Size = pnNguonLuc.MinimumSize;
        }



        #endregion

        #region xử lý ẩn hiện menu
        private void iconMenu_Click(object sender, EventArgs e)
        {
            if (pnMenuDoc.Size == pnMenuDoc.MinimumSize)
            {
                pnMenuDoc.Size = pnMenuDoc.MaximumSize;
                pnMenuDoc.BringToFront();
            }
            else pnMenuDoc.Size = pnMenuDoc.MinimumSize;
            
        }
        #endregion

        public bool IsReopenDangNhap { get; set; } = false;

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có muốn đăng xuất không?","Đăng xuất",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                IsReopenDangNhap = true;
                this.Close();
            }    
        }

        private void pnTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(1200, 1000);
        }

        private void btnFormBG_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UI_View_BaoGia ui_BG = new UI_View_BaoGia(nv_DN);
            panel1.Controls.Add(ui_BG);
            panel1.Dock = DockStyle.Fill;

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UI_ThemSP ui = new UI_ThemSP(nv_DN);
            panel1.Controls.Add(ui);
            panel1.Dock = DockStyle.Fill;
        }

        private void btnFDuyetYCM_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UI_YeuCauMH ui = new UI_YeuCauMH(nv_DN);
            panel1.Controls.Add(ui);
            panel1.Dock = DockStyle.Fill;
        }

        private void btnFDieuChinhYCM_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            
            UI_NhapSua_YeuCauMH ui = new UI_NhapSua_YeuCauMH(nv_DN);
            panel1.Controls.Add(ui);
            panel1.Dock = DockStyle.Fill;
        }

        private void btnFNhanVien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QLNV ui = new QLNV(nv_DN);
            panel1.Controls.Add(ui);
            panel1.Dock = DockStyle.Fill;
        }

        private void btnFKho_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QLKho ui = new QLKho(nv_DN);
            panel1.Controls.Add(ui);
            panel1.Dock = DockStyle.Fill;
        }

        private void btnFTTDonHang_Click(object sender, EventArgs e)
        {
            BLL_KiemTraTruyCap bll = new BLL_KiemTraTruyCap();
            bool checkNV = bll.Kiem_Tra_Chuc_Vu(nv_DN);
            bool checkPhongBan = bll.Kiem_Tra_PhongBan(nv_DN);
            if (checkNV && checkPhongBan) 
            {
                panel1.Controls.Clear();
                Quanlydonhang ui = new Quanlydonhang();
                panel1.Controls.Add(ui);
                panel1.Dock = DockStyle.Fill;
            }
            else
            {
                panel1.Controls.Clear();
                Quanlydonhang ui = new Quanlydonhang();
                panel1.Controls.Add(ui);
                panel1.Dock = DockStyle.Fill;
            }
        }

        private void btnFDGSP_Click(object sender, EventArgs e)
        {
            BLL_KiemTraTruyCap bll = new BLL_KiemTraTruyCap();
            bool checkNV = bll.Kiem_Tra_Chuc_Vu(nv_DN);
            bool checkPhongBan = bll.Kiem_Tra_PhongBan(nv_DN);
            if (checkNV && checkPhongBan)
            {
                panel1.Controls.Clear();
                //Danhgiadonhang ui = new Danhgiadonhang();
                //panel1.Controls.Add(ui);
                panel1.Dock = DockStyle.Fill;
            }
            else
            {
                panel1.Controls.Clear();
                //Danhgiadonhang_NV ui = new Danhgiadonhang_NV();
                //panel1.Controls.Add(ui);
                panel1.Dock = DockStyle.Fill;
            }
        }

        private void btnFPhanCong_Click(object sender, EventArgs e)
        {
            BLL_KiemTraTruyCap bll = new BLL_KiemTraTruyCap();
            bool checkNV = bll.Kiem_Tra_Chuc_Vu(nv_DN);
            bool checkPhongBan = bll.Kiem_Tra_PhongBan(nv_DN);
            if (checkNV && checkPhongBan)
            {
                panel1.Controls.Clear();
                PCCV ui = new PCCV();
                panel1.Controls.Add(ui);
                panel1.Dock = DockStyle.Fill;
            }
            else
            {
                panel1.Controls.Clear();
                PCCV_NV ui = new PCCV_NV();
                panel1.Controls.Add(ui);
                panel1.Dock = DockStyle.Fill;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnFThongTinNCC_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QLNCC ui = new QLNCC(nv_DN);
            panel1.Controls.Add(ui);
            panel1.Dock = DockStyle.Fill;
        }

        private void btnFDanhGiaNCC_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QLDGNCC ui = new QLDGNCC(nv_DN);
            panel1.Controls.Add(ui);
            panel1.Dock = DockStyle.Fill;
        }
    }
}
