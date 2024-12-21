using PC_DTO;
using PC_GUI.BLL;
using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PC_GUI
{
    public partial class UI_NhapSua_BaoGia : Form
    {
        public UI_NhapSua_BaoGia(DTONV nvien)
        {
            InitializeComponent();
            BLL_KiemTraTruyCap kt = new BLL_KiemTraTruyCap();
            bool kiemtraPhongBan = kt.Kiem_Tra_PhongBan(nvien);
            if (!kiemtraPhongBan)
            {
                this.Controls.Remove(btnSuaBG);
                this.Controls.Remove(btnSuaSP);
                this.Controls.Remove(btnXoaBG);
                this.Controls.Remove(btnXoaSP);
                this.Controls.Remove(btnThemBG);
                this.Controls.Remove(btnThemSP);

            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            tooltipMaBG.InitialDelay = 50; // Tooltip xuất hiện sau 0.5 giây
            tooltipMaBG.AutoPopDelay = 5000; // Tooltip ẩn sau 5 giây
            tooltipMaBG.IsBalloon = true; // Hiển thị Tooltip dạng bong bóng
            tooltipMaBG.ToolTipTitle = "Mã báo giá bắt đầu bằng BG";
        }

        //Kiểm tra mã báo giá
        private void txtMaBG_TextChanged(object sender, EventArgs e)
        {
            BLL_BaoGia bll = new BLL_BaoGia();
            DTO_BaoGia dto  = new DTO_BaoGia();
            dto.MaBG = txtMaBG.Text.Trim();
            dtgCT_BG.DataSource = null;
            if (dto.MaBG.Length > 0) 
            {
                if (bll.KiemTraMaBG(dto)) /// kiểm tra mã bg đã tồn tại
                {
                    btnSuaBG.Enabled = false;
                    btnXoaSP.Enabled = false;
                    btnThemSP.Enabled = false;
                    btnSuaSP.Enabled = false;
                    btnXoaBG.Enabled = false;
                    btnXoaSP.Enabled = false;
                    txtDonGia.Text = "";
                    txtMota.Text = "";
                    cbSanPham.SelectedValue = 0;
                    cbNCC.SelectedValue = 0;
                    if (txtMaBG.Text.StartsWith("BG") && !Regex.IsMatch(txtMaBG.Text, @"[^a-zA-Z0-9]"))
                    {
                        tooltipMaBG.ToolTipIcon = ToolTipIcon.Info;
                        tooltipMaBG.SetToolTip(txtMaBG, "Hợp lệ");
                        btnThemBG.Enabled = true;
                    }
                    else
                    {
                        cbNCC.SelectedValue = 0;
                        tooltipMaBG.SetToolTip(txtMaBG, "Không hợp lệ");
                        tooltipMaBG.ToolTipIcon = ToolTipIcon.Error;
                        btnThemBG.Enabled = false;
                    }
                }
                else
                {
                    cbNCC.SelectedValue = 0;
                    tooltipMaBG.SetToolTip(txtMaBG, "Đã tồn tại");
                    tooltipMaBG.ToolTipIcon = ToolTipIcon.Error;
                    btnThemBG.Enabled = false;
                    btnSuaBG.Enabled = true;
                    btnXoaBG.Enabled = true;
                    btnThemSP.Enabled = true;
                    btnSuaSP.Enabled = true;
                    btnXoaSP.Enabled = true;
                    DTO_CT_BaoGia ct = new DTO_CT_BaoGia();
                    ct.MaBG = txtMaBG.Text.Trim();
                    Load_CT_BG(ct);
                }
            } else
            {
                btnSuaBG.Enabled = false;
                btnXoaSP.Enabled = false;
                btnThemSP.Enabled = false;
                btnSuaSP.Enabled = false;
                btnXoaBG.Enabled = false;   
                btnThemBG.Enabled = false;
                txtDonGia.Text = "";
                txtMota.Text = "";
                cbSanPham.SelectedValue = 0;
                cbNCC.SelectedValue = 0;
            }    
        }

        //Load Forrm
        private void UI_NhapSua_BaoGia_Load(object sender, EventArgs e)
        {
            btnThemBG.Enabled = false;
            btnSuaBG.Enabled = false;
            btnThemSP.Enabled = false;
            btnSuaSP.Enabled = false;
            btnXoaBG.Enabled = false;
            btnXoaSP.Enabled = false;
            //Load datagridview
            Load_BaoGia();

            //Load ComboBox
            Load_CB_NCC();
            Load_CB_SP();
            dataGridView1.ReadOnly = true;
            dtgCT_BG.ReadOnly = true;
            toolTip1.InitialDelay = 50; // Tooltip xuất hiện sau 0.5 giây
            toolTip1.AutoPopDelay = 5000; // Tooltip ẩn sau 5 giây
            toolTip1.IsBalloon = true; // Hiển thị Tooltip dạng bong bóng            
            toolTip1.SetToolTip(txtDonGia, "Yêu cầu nhập");
            toolTip1.SetToolTip(cbNCC, "Yêu cầu chọn");
            toolTip1.SetToolTip(cbSanPham, "Yêu cầu chọn");
            txtMota.Text = "";


        }
        //Load Báo giá
        private void Load_CB_SP()
        {
            LoadCB load = new LoadCB();
            cbSanPham.DataSource = load.Load_CB_SanPham();
            cbSanPham.ValueMember = "MaSP";
            cbSanPham.DisplayMember = "TenSP";
            cbSanPham.SelectedValue = 0;
            cbSanPham.MaxDropDownItems = 5;
            cbSanPham.DropDownHeight = cbSanPham.ItemHeight * 5;
        }
        //Load báo giá
        private void Load_CB_NCC()
        {
            LoadCB load = new LoadCB();
            cbNCC.DataSource = load.Load_CB_NCC();
            cbNCC.ValueMember = "MaNCC";
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.SelectedValue = 0;
            cbNCC.MaxDropDownItems = 5;
            cbNCC.DropDownHeight = cbNCC.ItemHeight * 5;
        }

        //Thêm báo giá
        private void btnThemBG_Click(object sender, EventArgs e)
        {
            DTO_BaoGia baoGia = new DTO_BaoGia();
            baoGia.MaBG = txtMaBG.Text.Trim();
            baoGia.MaNCC = cbNCC.SelectedValue.ToString();
            
            baoGia.NgayBG = DateTime.Now;
            DTO_CT_BaoGia ct = new DTO_CT_BaoGia();
            BLL_BaoGia bLL_BaoGia = new BLL_BaoGia();
            ct.MaBG = txtMaBG.Text.Trim();
            if (bLL_BaoGia.Them_BaoGia(baoGia))
            {
                btnThemBG.Enabled = false;
                btnSuaBG.Enabled = true;
                btnXoaBG.Enabled = true;
                btnThemSP.Enabled = true;
                btnSuaSP.Enabled = true;
                btnXoaSP.Enabled = true;
                Load_BaoGia();
                Load_CT_BG(ct);

            }
            else { MessageBox.Show("Xảy ra lỗi thêm báo giá", "Thêm báo giá không thành công"); }

        }
        //Sửa Báo giá
        private void btnSuaBG_Click(object sender, EventArgs e)
        {
            DTO_BaoGia baoGia = new DTO_BaoGia();
            baoGia.MaBG = txtMaBG.Text.Trim();
            baoGia.MaNCC = cbNCC.SelectedValue.ToString();
            BLL_BaoGia bLL_BaoGia = new BLL_BaoGia();
            if (bLL_BaoGia.Sua_BaoGia(baoGia))
            {
                Load_BaoGia();
                return;
            }
            else { MessageBox.Show("Xảy ra lỗi khi sửa báo giá", "Sửa báo giá không thành công"); }
        }
        //Load Datagridview báo giá
        private void Load_BaoGia()
        {
            BLL_BaoGia bll_bg = new BLL_BaoGia();

            dataGridView1.DataSource = bll_bg.Load_BaoGia();
            dataGridView1.Columns["NgayBG"].Visible = false;
            dataGridView1.Columns["MaNCC"].Visible = false;
        }
        //Load datagrid view Chi tiets báo giá
        private void Load_CT_BG(DTO_CT_BaoGia ct)
        {
            BLL_CT_BaoGia bll_ct = new BLL_CT_BaoGia();
            dtgCT_BG.DataSource = bll_ct.Load_CT_BG(ct);
            dtgCT_BG.Columns["MaSP"].Visible = false;
        }
        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        //Chọn dòng trong datagridview báo giá
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaBG.Text = row.Cells["MaBG"].Value.ToString();
                cbNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString();
                txtMota.Text = "";
                cbSanPham.SelectedIndex = 0;
                txtDonGia.Text = "";

            }
            catch { return; }
        }
        //Chọn dòng trong datagridview chi tieetse báo giá
        private void dtgCT_BG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = dtgCT_BG.Rows[e.RowIndex];
                txtMota.Text = row.Cells["MoTa"].Value.ToString();
                cbSanPham.SelectedValue = row.Cells["MaSP"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            }
            catch { return; }
        }

        //Xóa báo giá
        private void btnXoaBG_Click(object sender, EventArgs e)
        {
            DTO_BaoGia baoGia = new DTO_BaoGia();
            DTO_CT_BaoGia ct = new DTO_CT_BaoGia();
            baoGia.MaBG = txtMaBG.Text.Trim();
            baoGia.MaNCC = cbNCC.SelectedValue.ToString();
            BLL_BaoGia bLL_BaoGia = new BLL_BaoGia();
            BLL_CT_BaoGia bll_CT = new BLL_CT_BaoGia();
            ct.MaBG = txtMaBG.Text.Trim();
            //Xóa tất cả chi tiết báo giá
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa báo giá này", "Báo giá sẽ bị xóa vĩnh viễn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (bll_CT.Xoa_CT_BG(ct))
                {
                    if (bLL_BaoGia.Xoa_BaoGia(baoGia))
                    {
                        btnThemBG.Enabled = true;
                        btnSuaBG.Enabled = false;
                        btnXoaBG.Enabled = false;
                        btnThemSP.Enabled = false;
                        btnSuaSP.Enabled = false;
                        btnXoaSP.Enabled = false;
                        cbNCC.SelectedValue = 0;
                        cbSanPham.SelectedValue = 0;
                        txtMota.Text = "";
                        txtDonGia.Text = "";
                        Load_BaoGia();
                        dtgCT_BG.DataSource = null;
                        return;
                    }
                    else { MessageBox.Show("Báo giá đã được thực hiện trong các đơn hàng\n Không thể xóa do ràng buộc", "Xóa báo giá không thành công"); }

                }
                MessageBox.Show("Đã có sản phẩm báo giá được thực hiện mua hàng\nKhông thể xóa do ràng buộc", "Xóa báo giá không thành công");
            }
            

        }
        //Thêm chi tiết báo giá
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            DTO_CT_BaoGia dto = new DTO_CT_BaoGia();
            dto.MaBG = txtMaBG.Text;
            dto.MoTa = txtMota.Text;
            dto.DonGia = int.Parse(txtDonGia.Text);
            dto.MaSP = cbSanPham.SelectedValue.ToString();
            BLL_CT_BaoGia bll = new BLL_CT_BaoGia();
            if (bll.Them_CT_BG(dto))
            {
                Load_CT_BG(dto);
            }
            else { MessageBox.Show("Xảy ra lỗi khi thêm chi tiết báo giá", "Thêm chi tiết báo giá không thành công"); }
        }


        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        //Sửa chi tiết báo giá
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            DTO_CT_BaoGia dto = new DTO_CT_BaoGia();
            dto.MaBG = txtMaBG.Text;
            dto.MoTa = txtMota.Text;
            dto.DonGia = int.Parse(txtDonGia.Text);
            dto.MaSP = cbSanPham.SelectedValue.ToString();
            BLL_CT_BaoGia bll = new BLL_CT_BaoGia();
            if (bll.Sua_CT_BG(dto))
            {
                Load_CT_BG(dto);
            }
            else { MessageBox.Show("Xảy ra lỗi khi sửa chi tiết báo giá", "Sửa chi tiết báo giá không thành công"); }
        }
        /// Xóa 1 chi tiết báo giá
        /// 
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DTO_CT_BaoGia dto = new DTO_CT_BaoGia();
            dto.MaBG = txtMaBG.Text;
            dto.MoTa = txtMota.Text;
            dto.DonGia = int.Parse(txtDonGia.Text);
            dto.MaSP = cbSanPham.SelectedValue.ToString();
            BLL_CT_BaoGia bll = new BLL_CT_BaoGia();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa sản phẩm này khỏ báo giá", "Báo giá sẽ bị xóa vĩnh viễn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (bll.Xoa_CT_BG(dto))
                {
                    Load_CT_BG(dto);
                }
                else { MessageBox.Show("Đã có sản phẩm báo giá được thực hiện mua hàng\nKhông thể xóa do ràng buộc", "Xóa chi tiết báo giá không thành công"); }
            }    
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
