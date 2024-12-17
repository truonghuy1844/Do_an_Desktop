﻿
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
        public DTONV nv_DN = new DTONV();
        public frmMainForm(DTONV nhanVien)
        {
            InitializeComponent();
            pnMenuDoc.Size = pnMenuDoc.MinimumSize;
            nv_DN = nhanVien;
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
                pnMenuDoc.BringToFront();
            }
            else pnMenuDoc.Size = pnMenuDoc.MinimumSize;
            
        }
        #endregion

        public bool IsReopenDangNhap { get; set; } = false;

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                IsReopenDangNhap = true;
                this.Close();
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

        
    }
}
