using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_GUI.BLL;
using PC_DTO;

namespace PC_GUI
{
    public partial class AddDGNCC : Form
    {

        BLLNCC bLLNCC = new BLLNCC();
        private DataGridView dataGridViewDSDMH;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label labelStartDate;
        private Label labelEndDate;
        public AddDGNCC()
        {
            InitializeComponent();
            InitializeDynamicUI();
        }

        private void AddDGNCC_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }
        private void InitializeDynamicUI()
        {
            // DataGridView hiển thị đơn hàng
            dataGridViewDSDMH = new DataGridView
            {
                Location = new System.Drawing.Point(390, 100),
                Size = new System.Drawing.Size(360, 90),
                Visible = false,
                Name = "dataGridViewDSDMH",
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                MultiSelect = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            Controls.Add(dataGridViewDSDMH);

            labelStartDate = new Label
            {
                Text = "Ngày bắt đầu:",
                Location = new System.Drawing.Point(390, 110),
                Visible = false
            };
            Controls.Add(labelStartDate);

            dateTimePickerStart = new DateTimePicker
            {
                Location = new System.Drawing.Point(490, 110),
                Visible = false
            };
            Controls.Add(dateTimePickerStart);

            labelEndDate = new Label
            {
                Text = "Ngày kết thúc:",
                Location = new System.Drawing.Point(390, 130),
                Visible = false
            };
            Controls.Add(labelEndDate);

            dateTimePickerEnd = new DateTimePicker
            {
                Location = new System.Drawing.Point(490, 130),
                Visible = false
            };
            Controls.Add(dateTimePickerEnd);
        }

        private void LoadCombobox()
        {
            comboBoxTieuChiDanhGia.DataSource = bLLNCC.LoadTieuChi();
            comboBoxTieuChiDanhGia.DisplayMember = "TieuChiDanhGia";
            comboBoxTieuChiDanhGia.ValueMember = "TieuChiDanhGia";
            comboBoxTieuChiDanhGia.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
           "Bạn có chắc chắn muốn hủy bỏ không?",
           "Xác nhận hủy",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);


            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaDGNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ResetField()
        {
            txtMaDGNCC.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtMaNCC.Text = string.Empty;
            comboBoxTieuChiDanhGia.SelectedIndex = -1;
        }

        private void comboBoxTieuChiDanhGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedTieuChi = comboBoxTieuChiDanhGia.SelectedValue?.ToString();

                if (selectedTieuChi == "Theo đánh giá đơn hàng tùy chọn" || selectedTieuChi == "Theo tất cả đơn hàng")
                {
                    string maNCC = txtMaNCC.Text.Trim();

                    if (string.IsNullOrEmpty(maNCC))
                    {
                        MessageBox.Show("Vui lòng nhập mã nhà cung cấp trước khi chọn tiêu chí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBoxTieuChiDanhGia.SelectedIndex = -1;
                        HideDynamicControls();
                        txtMaNCC.Focus();
                        return;
                    }
                    HideDynamicControls();
                    dataGridViewDSDMH.Visible = true;
                    dataGridViewDSDMH.DataSource = bLLNCC.LoadTieuChiDMH(maNCC);
                    if (selectedTieuChi == "Theo tất cả đơn hàng" && dataGridViewDSDMH.Rows.Count > 0)
                    {
                        dataGridViewDSDMH.ClearSelection();
                        foreach (DataGridViewRow row in dataGridViewDSDMH.Rows)
                        {
                            row.Selected = true;
                        }
                        dataGridViewDSDMH.Enabled = false;
                    }
                }
                else if (selectedTieuChi == "Theo ngày tùy chọn")
                {
                    string maNCC = txtMaNCC.Text.Trim();
                    if (string.IsNullOrEmpty(maNCC))
                    {
                        MessageBox.Show("Vui lòng nhập mã nhà cung cấp trước khi chọn tiêu chí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBoxTieuChiDanhGia.SelectedIndex = -1;
                        HideDynamicControls();
                        txtMaNCC.Focus();
                        return;
                    }
                    HideDynamicControls();
                    labelStartDate.Visible = true;
                    dateTimePickerStart.Visible = true;
                    labelEndDate.Visible = true;
                    dateTimePickerEnd.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNCC.Text = string.Empty;
                dataGridViewDSDMH.DataSource = null;
            }
        }
        private void HideDynamicControls()
        {
            dataGridViewDSDMH.Visible = false;
            labelStartDate.Visible = false;
            dateTimePickerStart.Visible = false;
            labelEndDate.Visible = false;
            dateTimePickerEnd.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maDGNCC = txtMaDGNCC.Text.Trim();
                string maNCC = txtMaNCC.Text.Trim();
                DTODGNCC addDGNCC = new DTODGNCC()
                {
                    MaDGNCC = txtMaDGNCC.Text.Trim(),
                    MaNCC = txtMaNCC.Text.Trim(),
                    MaNV = txtMaNV.Text.Trim(),
                    TieuChiDanhGia = comboBoxTieuChiDanhGia.SelectedValue?.ToString()
                };
                List<string> listDGSP = new List<string>();
                if (comboBoxTieuChiDanhGia.SelectedValue?.ToString() == "Theo đánh giá đơn hàng tùy chọn" ||
                    comboBoxTieuChiDanhGia.SelectedValue?.ToString() == "Theo tất cả đơn hàng")
                {
                    if (dataGridViewDSDMH.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn ít nhất một đơn mua hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    foreach (DataGridViewRow row in dataGridViewDSDMH.SelectedRows)
                    {
                        listDGSP.Add(row.Cells["MaDGSP"].Value.ToString());
                    }
                }
                DateTime? frmDate = null, toDate = null;
                if (comboBoxTieuChiDanhGia.SelectedValue?.ToString() == "Theo ngày tùy chọn")
                {
                    frmDate = dateTimePickerStart.Value;
                    toDate = dateTimePickerEnd.Value;
                }
                bLLNCC.AddDGNCC(addDGNCC, maNCC, listDGSP, frmDate, toDate);
                bLLNCC.AddDGNCC_SPDMH(maDGNCC, maNCC, listDGSP, frmDate, toDate);

                MessageBox.Show("Thêm đánh giá nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetField();
                HideDynamicControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chưa đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
