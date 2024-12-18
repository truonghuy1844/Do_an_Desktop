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
    public partial class QLDGNCC : UserControl
    {

        BLLNCC bLLNCC = new BLLNCC();
        public QLDGNCC()
        {
            InitializeComponent();
        }

        private void QLDGNCC_Load(object sender, EventArgs e)
        {
            dataGridViewDGNCC.DataSource = bLLNCC.LoadDGNCC();
            LoadCombobox();
            dataGridViewDGNCC.ReadOnly = true;
            dataGridViewNCC.ReadOnly = true;
            dataGridViewNVDG.ReadOnly = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewDGNCC.DataSource = bLLNCC.LoadDGNCC();
        }

        private void dataGridViewDGNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy MaDanhGia từ dòng được chọn
                string maDanhGia = dataGridViewDGNCC.Rows[e.RowIndex].Cells["MaDGNCC"].Value.ToString();

                var listNhanVien = bLLNCC.LoadNVDGNCC(maDanhGia);
                var listNhaCungCap = bLLNCC.LoadNCCDG(maDanhGia);

                // Cập nhật dữ liệu vào DataGridView bên phải
                dataGridViewNVDG.DataSource = listNhanVien;
                dataGridViewNCC.DataSource = listNhaCungCap;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddDGNCC addDGNCC = new AddDGNCC();
            addDGNCC.Show();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaDGNCC xoaDGNCC = new XoaDGNCC();
            xoaDGNCC.Show();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCombobox()
        {
            comboBoxMucDo.DataSource = bLLNCC.LoadMucDoDG();
            comboBoxMucDo.DisplayMember = "MucDoDanhGia";
            comboBoxMucDo.ValueMember = "MucDoDanhGia";
            comboBoxMucDo.SelectedIndex = -1;

            checkedListBoxTieuChi.DataSource = bLLNCC.TieuChiSearch();
            checkedListBoxTieuChi.DisplayMember = "TieuChiDanhGia";
            checkedListBoxTieuChi.ValueMember = "TieuChiDanhGia";
            checkedListBoxTieuChi.SetItemChecked(0, true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxMucDo.SelectedIndex = -1;

            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;
            checkedListBoxTieuChi.SetItemChecked(0, true);
        }
        private void ApplyFilters()
        {
            string tuKhoa = !string.IsNullOrEmpty(txtTim.Text) ? txtTim.Text.Trim() : null;
            string mucDo = comboBoxMucDo.SelectedIndex >= 0 ? comboBoxMucDo.SelectedValue.ToString().Trim() : null;
            DateTime fromDate = dateTimePickerFrom.Value;
            DateTime toDate = dateTimePickerTo.Value;
            var tieuChiDanhGia = checkedListBoxTieuChi.CheckedItems.Cast<DTOTieuChiSearch>()
              .Select(tc => tc.TieuChiDanhGia)
              .ToList();

            var ketQua = bLLNCC.LocDGNCC(tuKhoa, mucDo, fromDate, toDate, tieuChiDanhGia);
            dataGridViewDGNCC.DataSource = ketQua;
            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void checkedListBoxTieuChi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                bool isChecked = e.NewValue == CheckState.Checked;

                for (int i = 1; i < checkedListBoxTieuChi.Items.Count; i++)
                {
                    checkedListBoxTieuChi.SetItemChecked(i, isChecked);
                }
            }
            else
            {
                bool allChecked = true;
                for (int i = 1; i < checkedListBoxTieuChi.Items.Count; i++)
                {
                    if (!checkedListBoxTieuChi.GetItemChecked(i))
                    {
                        allChecked = false;
                        break;
                    }
                }

                // Cập nhật trạng thái mục "Chọn tất cả"
                checkedListBoxTieuChi.ItemCheck -= checkedListBoxTieuChi_ItemCheck; // Tránh đệ quy
                checkedListBoxTieuChi.SetItemChecked(0, allChecked); // Cập nhật trạng thái "Chọn tất cả"
                checkedListBoxTieuChi.ItemCheck += checkedListBoxTieuChi_ItemCheck;
            }
        }

        private void dataGridViewDGNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewDGNCC.Rows[e.RowIndex];
                string maDGNCC = selectedRow.Cells["maDGNCC"].Value.ToString();

                DSDG_SPDMH dSDG = new DSDG_SPDMH(maDGNCC);
                dSDG.ShowDialog();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ReportDGNCC reportDGNCC = new ReportDGNCC();
            reportDGNCC.ShowDialog();
        }

        
    }
}
