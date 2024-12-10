using PC_BLL;
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
        BLLNhanVien bLLNhanVien = new BLLNhanVien();
        public frmMainForm()
        {
            InitializeComponent();
        }

        #region Xử lý toggle nhà cung cấp và đơn hàng

        private void btnFormNCC_Click(object sender, EventArgs e)
        {
            if (pnContainerNCC.Size == pnContainerNCC.MinimumSize)
            {
                pnContainerNCC.Size = pnContainerNCC.MaximumSize;
            }
            else pnContainerNCC.Size = MinimumSize;
        }

        #endregion

        #region xử lý ẩn hiện menu
        private void iconMenu_Click(object sender, EventArgs e)
        {
            //if (pnMenuDoc.Size == pnMenuDoc.MaximumSize)
            //{
            //    pnMenuDoc.Size = pnMenuDoc.MinimumSize;
            //    pnTop.Size = pnTop.MaximumSize;
            //    ptLogo.Size = pnMenuDoc.MinimumSize;

            //}
            //else
            //{
            //    pnMenuDoc.Size = pnMenuDoc.MaximumSize;
            //    pnTop.Size = pnTop.MinimumSize;
            //    ptLogo.Size = pnMenuDoc.MaximumSize;
            //}
        }
        #endregion
        private void btnFormDonHang_Click(object sender, EventArgs e)
        {
            //ToggleSubMenu(pnDonHang);
            if (pnDonHang.Size == pnDonHang.MinimumSize)
            {
                pnDonHang.Size = pnDonHang.MaximumSize;
            }
            else pnDonHang.Size = MinimumSize;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có muốn đăng xuất không?","Đăng xuất",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                this.Hide();
                frmdangNhap dn = new frmdangNhap();
                dn.Show();
            }    
        }
    }
}
