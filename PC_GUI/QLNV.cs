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
using PC_GUI.BLL;

namespace PC_GUI
{
    public partial class QLNV : UserControl
    {
        public QLNV(DTONV nvien)
        {
            InitializeComponent();
            nv_DN.MaNV = nvien.MaNV;
            BLL_KiemTraTruyCap kt = new BLL_KiemTraTruyCap();
            
            bool KiemTraChucVu = kt.Kiem_Tra_Chuc_Vu(nv_DN);
            bool KiemTraPhongBan = kt.Kiem_Tra_PhongBan(nv_DN);
            if (!KiemTraPhongBan)
            {
                btnThemNV.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else if (!KiemTraChucVu) 
            { 
                btnXoa.Enabled = false ;
            }
               
        }

        BLL_NhanVien bLLNV = new BLL_NhanVien();
        public DTONV nv_DN = new DTONV();
        private void QLNV_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            dataGridViewDSNV.DataSource = bLLNV.LoadNVBlL();
            dataGridViewDSNV.ReadOnly = true;
        }
        private void LoadComboBox()
        {
            comboBoxChucVu.DataSource = bLLNV.LoadChucVu();
            comboBoxChucVu.DisplayMember = "ChucVu";
            comboBoxChucVu.ValueMember = "ChucVu";
            comboBoxChucVu.SelectedIndex = -1;

            comboBoxPhongBan.DataSource = bLLNV.LoadPhongBan();
            comboBoxPhongBan.DisplayMember = "PhongBan";
            comboBoxPhongBan.ValueMember = "PhongBan";
            comboBoxPhongBan.SelectedIndex = -1;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            AddNV addNV = new AddNV();
            addNV.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaNV suaNV = new SuaNV();
            suaNV.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNV xoaNV = new XoaNV();
            xoaNV.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewDSNV.DataSource = bLLNV.LoadNVBlL();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = string.Empty;
            LoadComboBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtMaNV.Text.Trim();
                string chucVu = comboBoxChucVu.SelectedValue?.ToString();
                string phongBan = comboBoxPhongBan.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(maNV) && string.IsNullOrEmpty(chucVu) && string.IsNullOrEmpty(phongBan))
                {
                    MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<DTONV> result = null;
                int searchCase = 0;

                if (!string.IsNullOrEmpty(maNV)) searchCase += 1;       // Thêm 1 nếu có mã nhân viên
                if (!string.IsNullOrEmpty(chucVu)) searchCase += 2;     // Thêm 2 nếu lọc theo chức vụ
                if (!string.IsNullOrEmpty(phongBan)) searchCase += 4;   // Thêm 4 nếu lọc theo phòng ban

                switch (searchCase)
                {
                    case 1:
                        result = bLLNV.TimNV(maNV);
                        break;
                    case 3:
                        result = bLLNV.TimNVCV(maNV, chucVu);
                        break;
                    case 5:
                        result = bLLNV.TimNVPB(maNV, phongBan);
                        break;
                    case 7:
                        result = bLLNV.TimNVCVPB(maNV, chucVu, phongBan);
                        break;
                    case 6:
                        result = bLLNV.TimCVPB(chucVu, phongBan);
                        break;
                    case 2:
                        result = bLLNV.TimCV(chucVu);
                        break;
                    case 4:
                        result = bLLNV.TimPB(phongBan);
                        break;
                    default:
                        dataGridViewDSNV.DataSource = bLLNV.LoadNVBlL();
                        return;
                }
                dataGridViewDSNV.DataSource = result;

                if (result == null || result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
