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
using PC_BLL;

namespace PC_GUI
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        BLLNV bLLNV = new BLLNV();
        private void QLNV_Load(object sender, EventArgs e)
        {
            LoadComboBox();
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
            addNV.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaNV suaNV = new SuaNV();
            suaNV.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNV xoaNV = new XoaNV();
            xoaNV.Show();
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
                List<DTONV> result;
                int searchCase = 0;
                if (!string.IsNullOrEmpty(maNV)) searchCase += 1;       //Thêm 1 nếu có mã nhân viên
                if (!string.IsNullOrEmpty(chucVu)) searchCase += 2;     //Thêm 2 nếu lọc theo chức vụ
                if (!string.IsNullOrEmpty(phongBan)) searchCase += 4;   //Thêm 3 nếu lọc theo phòng ban
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
                if (result == null && result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewDSNV.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
