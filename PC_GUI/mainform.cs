
using PC_DTO;
using PC_GUI.BLL;
using PC_GUI.DAL;
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
        DTONV nv = new DTONV();
        public frmMainForm()
        {
            InitializeComponent();
            pnMenuDoc.Size = pnMenuDoc.MinimumSize;
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

        private Form formCon;
        private void moFormCon(Form tenFormCon)
        {
            if (formCon != null)
            {
                formCon.Close();
            }
            formCon = tenFormCon;
            tenFormCon.TopLevel = false;
            tenFormCon.ControlBox = false;
            tenFormCon.Dock = DockStyle.Fill;
            pnThan.Dock = DockStyle.Fill;
            tenFormCon.FormBorderStyle = FormBorderStyle.None;
            pnThan.Controls.Add(tenFormCon);
            pnThan.Tag = tenFormCon;
            tenFormCon.BringToFront();
            tenFormCon.Show();
        }

        #region xử lý ẩn hiện menu
        private void iconMenu_Click(object sender, EventArgs e)
        {
            if (pnMenuDoc.Size == pnMenuDoc.MinimumSize)
            {
                pnMenuDoc.Size = pnMenuDoc.MaximumSize;
            }
            else pnMenuDoc.Size = pnMenuDoc.MinimumSize;
            
        }
        #endregion

        #region Xử lý nút trên menu
        
        // Nút logout
        private void btnLogOut_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmdangNhap dn = new frmdangNhap();
                dn.Show();
            }
        }

        // Báo giá
        private void btnFormBG_Click(object sender, EventArgs e)
        {
            DTONV nvien = new DTONV();
            nvien.MaNV = "NV020";
            UI_View_BaoGia ui_BG = new UI_View_BaoGia(nvien);
            moFormCon(ui_BG);

        }

        #region Nguồn lực

        private void btnFKho_Click(object sender, EventArgs e)
        {
            moFormCon(new QLKho());
        }

        private void btnFNhanVien_Click(object sender, EventArgs e)
        {
            moFormCon(new QLNV());
        }
        #endregion

        #region Yêu cầu mua hàng
        private void btnFDieuChinhYCM_Click(object sender, EventArgs e)
        {
            UI_NhapSua_YeuCauMH ui = new UI_NhapSua_YeuCauMH(nv);
            moFormCon(ui);
        }

        private void btnFDuyetYCM_Click(object sender, EventArgs e)
        {

            UI_YeuCauMH _YeuCauMH = new UI_YeuCauMH(nv);
            moFormCon(_YeuCauMH);
        }

        #endregion

        // Sản phẩm
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            UI_ThemSP uI_ThemSP = new UI_ThemSP(nv);
            moFormCon(uI_ThemSP);
        }






        #endregion

        private void btnFPhanCong_Click(object sender, EventArgs e)
        {
            PHANCONG_CONGVIEC pccv = new PHANCONG_CONGVIEC();
            
        }

        
    }
}
