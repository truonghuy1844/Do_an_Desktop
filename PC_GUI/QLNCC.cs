using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_GUI.BLL;
using PC_DTO;

namespace PC_GUI
{
    public partial class QLNCC : UserControl
    {
        BLLNCC bLLNCC = new BLLNCC();
        public DTONV nv_DN = new DTONV();
        public QLNCC(DTONV nvien)
        {
            InitializeComponent();
            nv_DN.MaNV = nvien.MaNV;
            BLL_KiemTraTruyCap kt = new BLL_KiemTraTruyCap();

            bool KiemTraChucVu = kt.Kiem_Tra_Chuc_Vu(nv_DN);
            bool KiemTraPhongBan = kt.Kiem_Tra_PhongBan(nv_DN);
            if (!KiemTraPhongBan)
            {
                btnThemNCC.Enabled = false;
                btnXoaNCC.Enabled = false;
                btnSuaNCC.Enabled = false;
            }
            else if (!KiemTraChucVu)
            {
                btnXoaNCC.Enabled = false;
            }
        }

        private void QLNCC_Load(object sender, EventArgs e)
        {
            dataGridViewDSNCC.DataSource = bLLNCC.LoadNCC();
            dataGridViewDSNCC.ReadOnly = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewDSNCC.DataSource = bLLNCC.LoadNCC();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            AddNCC addNCC = new AddNCC();
            addNCC.Show();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            SuaNCC suaNCC = new SuaNCC();
            suaNCC.Show();
        }
        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            XoaNCC xoaNCC = new XoaNCC();
            xoaNCC.Show();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text;

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.");
                return;
            }
            try
            {
                var ketQua = bLLNCC.TimTuKhoaNCC(tuKhoa);
                dataGridViewDSNCC.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
