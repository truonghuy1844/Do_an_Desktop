using PC_DTO;
using PC_GUI.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_GUI
{
    public partial class UI_NhapSua_YeuCauMH : Form
    {
        public DTO_NhanVien nv = new DTO_NhanVien();
        public UI_NhapSua_YeuCauMH( DTO_NhanVien nvien)
        {
            InitializeComponent();
            nv.MaNV = nvien.MaNV;
            txtMaNV.Text = nvien.MaNV.ToString();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            BLL_CT_YCMH bll = new BLL_CT_YCMH();
            DTO_CT_YeuCauMH dto = new DTO_CT_YeuCauMH();
            dto.MaYC = txtMaYC.Text.Trim();
            if (cbSanPham.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm", "Sửa sản phẩm vào yêu cầu không thành công");
                return;
            }
            dto.MaSP = cbSanPham.SelectedValue.ToString();
            if (txtSoLuong.Text == "" || txtSoLuong.Text == null)
            {
                MessageBox.Show("Vui lòng chọn thêm số lượng sản phẩm", "Sửa sản phẩm vào yêu cầu không thành công");
                return;
            }
            dto.SoLuong = int.Parse(txtSoLuong.Text.Trim());
            if (bll.Sua_CT_YCMH(dto))
            {
                Load_DatagridView_CTYC(dto);
                return;
            }
            MessageBox.Show("Xảy ra lỗi khi Sửa sản phẩm", "Sửa sản phẩm chưa thành công");
            return;
        }

        private void UI_NhapSua_YeuCauMH_Load(object sender, EventArgs e)
        {
            //Load ComboBox
            Load_CB_SP();
            //Load datagridview YCMH
            Load_YCMH();
            btnCapNhat.Enabled = false;
            btnSuaSP.Enabled = false;
            btnThemSP.Enabled = false;
            btnXoaSP.Enabled = false;
            btnYeuCauDuyet.Enabled = false;
            btnXoaYC.Enabled = false;
            //ToolTIP
            toolTipMaYC.InitialDelay = 50; // Tooltip xuất hiện sau 0.5 giây
            toolTipMaYC.AutoPopDelay = 5000; // Tooltip ẩn sau 5 giây
            toolTipMaYC.IsBalloon = true; // Hiển thị Tooltip dạng bong bóng
            toolTipMaYC.ToolTipTitle = "Mã yêu cầu bắt đầu bằng YC";
            txtMaNV.ReadOnly = true;

        }
        private void Load_CB_SP()
        {
            LoadCB load = new LoadCB();
            cbSanPham.DataSource = load.Load_CB_SanPham();
            cbSanPham.ValueMember = "MaSP";
            cbSanPham.DisplayMember = "TenSP";
            cbSanPham.SelectedValue = 0;
            cbSanPham.MaxDropDownItems = 5;
            cbSanPham.DropDownHeight = cbSanPham.ItemHeight * 5;
            ///Load ComboBox Phong Ban
            ///
            List<string> comboBoxPhongBan = new List<string>
            {
                "",
                "Phòng Sản Xuất",
                "Phòng Kinh Doanh",
                "Phòng Tài Chính",
                "Phòng Marketing",
                "Phòng Hành Chính",
                "Phòng Nhân Sự",
                "Phòng Bán Hàng"

            };

            // Gán danh sách làm DataSource
            cbBoPhanYC.DataSource = comboBoxPhongBan;
            cbBoPhanYC.MaxDropDownItems = 5;
           cbBoPhanYC.DropDownHeight = cbBoPhanYC.ItemHeight * 5;

            // Thiết lập giá trị mặc định (nếu cần)
            cbBoPhanYC.SelectedIndex = 0; // Chọn mục đầu tiên
        }
        //Load Datagridview
        private void Load_DatagridView_CTYC(DTO_CT_YeuCauMH ctiet_yc)
        {
            BLL_CT_YCMH bll = new BLL_CT_YCMH();
            dgvCT_YC.DataSource = bll.Load_CT_YC_MH(ctiet_yc);
        }
        private void Load_YCMH()
        {
            BLL_YeuCauMH bll = new BLL_YeuCauMH();
            dgvYCMH.DataSource = bll.Load_YC_MH();
            foreach (DataGridViewColumn column in dgvYCMH.Columns)
            {
                column.Visible = false;
            }
            dgvYCMH.Columns["MaYC"].Visible = true;
            dgvYCMH.Columns["PhongBanYC"].Visible = true;
            dgvYCMH.Columns["TinhTrang"].Visible = true;
        }

        private void dgvYCMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvYCMH.Rows[e.RowIndex];
                txtMaYC.Text = row.Cells["MaYC"].Value.ToString();
                cbBoPhanYC.SelectedItem = row.Cells["PhongBanYC"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                
            }
            catch { return; }
        }

        private void dgvCT_YC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvCT_YC.Rows[e.RowIndex];
                
                cbSanPham.SelectedValue = row.Cells["MaSP"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

            }
            catch { return; }
        }

        private void txtMaYC_TextChanged(object sender, EventArgs e)
        {
            BLL_CT_YCMH ct_yc = new BLL_CT_YCMH();
            BLL_YeuCauMH ycmh = new BLL_YeuCauMH();
            DTO_YeuCauMH dto_ycmh = new DTO_YeuCauMH();

            dto_ycmh.MaYC = txtMaYC.Text.Trim();
            if (txtMaYC.Text.Length > 0) 
            {
                dgvCT_YC.DataSource = null;
                if (ycmh.Kiem_Tra_MaYC(dto_ycmh))
                {
                    
                    
                    btnSuaSP.Enabled = false;
                    btnXoaSP.Enabled = false;
                    btnThemSP.Enabled = false;
                    btnCapNhat.Enabled = false;
                    btnXoaYC.Enabled = false;
                    txtMaNV.Text = "";
                    txtSoLuong.Text = "";
                    
                    cbSanPham.SelectedValue = 0;
                    cbBoPhanYC.SelectedIndex = 0;

                    if (txtMaYC.Text.StartsWith("YC") && !Regex.IsMatch(txtMaYC.Text, @"[^a-zA-Z0-9]"))
                    {
                        toolTipMaYC.ToolTipIcon = ToolTipIcon.Info;
                        toolTipMaYC.SetToolTip(txtMaYC, "Hợp lệ");
                        btnYeuCauDuyet.Enabled = true;
                    }
                    else
                    {
                        cbBoPhanYC.SelectedItem = 0;
                        toolTipMaYC.SetToolTip(txtMaYC, "Không hợp lệ");
                        toolTipMaYC.ToolTipIcon = ToolTipIcon.Error;
                        btnYeuCauDuyet.Enabled = false;
                        
                    }

                }
                else
                {
                    cbSanPham.SelectedValue = 0;
                    toolTipMaYC.SetToolTip(txtMaYC, "Đã tồn tại");
                    toolTipMaYC.ToolTipIcon = ToolTipIcon.Error;
                    btnYeuCauDuyet.Enabled = false;
                    

                    DTO_CT_YeuCauMH ct = new DTO_CT_YeuCauMH();
                    ct.MaYC = txtMaYC.Text.Trim();
                    Load_DatagridView_CTYC(ct);
                    if (!ycmh.KiemTra_TT_Duyet(dto_ycmh))
                    {
                        btnSuaSP.Enabled = false;
                        btnXoaSP.Enabled = false;
                        btnThemSP.Enabled = false;
                        btnCapNhat.Enabled = false;
                        btnXoaYC.Enabled = false;
                    }
                    else
                    {
                        btnCapNhat.Enabled = true;
                        btnThemSP.Enabled = true;
                        btnSuaSP.Enabled = true;
                        btnXoaSP.Enabled = true;
                        btnXoaYC.Enabled = true;
                    }
                   
                }
            }
            else
            {

                btnSuaSP.Enabled = false;
                btnXoaSP.Enabled = false;
                btnThemSP.Enabled = false;
                btnCapNhat.Enabled = false;

                btnYeuCauDuyet.Enabled = false;
                txtMaNV.Text = "";
                txtSoLuong.Text = "";
                cbSanPham.SelectedValue = 0;
                cbBoPhanYC.SelectedIndex = 0;
            }
            
        }

        private void btnYeuCauDuyet_Click(object sender, EventArgs e)
        {
            BLL_YeuCauMH bll = new BLL_YeuCauMH();
            DTO_YeuCauMH dto = new DTO_YeuCauMH();
            dto.MaNV = nv.MaNV;//txtMaNV.Text;
            dto.MaYC = txtMaYC.Text.Trim();
            if (cbBoPhanYC.SelectedIndex == 0) 
            {
                MessageBox.Show("Vui lòng chọn phòng ban yêu cầu", "Yêu cầu duyệt chưa thành công");
                return;
            }
            dto.PhongBanYC = cbBoPhanYC.SelectedItem.ToString();
            dto.TinhTrang = "Chờ duyệt";
            dto.NgayYC = DateTime.Now;
            dto.NgayDuyet = DateTime.MinValue;
            if (bll.Them_YCMH(dto))
            {
                DTO_CT_YeuCauMH ct = new DTO_CT_YeuCauMH();
                ct.MaYC = dto.MaYC;
                Load_YCMH();
                Load_DatagridView_CTYC(ct);
                btnCapNhat.Enabled = true;
                btnYeuCauDuyet.Enabled = false;
                btnXoaSP.Enabled = true;
                btnThemSP.Enabled = true;
                btnSuaSP.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi tạo yêu cầu duyệt", "Yêu cầu duyệt chưa thành công");
                return;
            }
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBoPhanYC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BLL_YeuCauMH bll = new BLL_YeuCauMH();
            DTO_YeuCauMH dto = new DTO_YeuCauMH();
            dto.MaNV = nv.MaNV;
            dto.MaYC = txtMaYC.Text.Trim();
            if (cbBoPhanYC.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng ban yêu cầu", "Yêu cầu duyệt chưa thành công");
                return;
            }
            dto.PhongBanYC = cbBoPhanYC.SelectedItem.ToString();
            dto.TinhTrang = "Chờ duyệt";
            dto.NgayYC = DateTime.Now;
            dto.NgayDuyet = DateTime.MinValue;
            if (bll.Sua_YCMH(dto))
            {
                DTO_CT_YeuCauMH ct = new DTO_CT_YeuCauMH();
                ct.MaYC = dto.MaYC;
                Load_YCMH();
                Load_DatagridView_CTYC(ct);
                btnCapNhat.Enabled = true;
                btnYeuCauDuyet.Enabled = false;
                btnXoaSP.Enabled = true;
                btnThemSP.Enabled = true;
                btnSuaSP.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi cập nhật yêu cầu duyệt", "Cập nhật yêu cầu chưa thành công");
                return;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            BLL_CT_YCMH bll = new BLL_CT_YCMH();
            DTO_CT_YeuCauMH dto = new DTO_CT_YeuCauMH();
            dto.MaYC = txtMaYC.Text.Trim();
            if(cbSanPham.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm", "Thêm sản phẩm vào yêu cầu không thành công");
                return;
            }
            dto.MaSP = cbSanPham.SelectedValue.ToString();
            if (txtSoLuong.Text == "" || txtSoLuong.Text == null) 
            {
                MessageBox.Show("Vui lòng chọn thêm số lượng sản phẩm", "Thêm sản phẩm vào yêu cầu không thành công");
                return;
            }
            dto.SoLuong = int.Parse(txtSoLuong.Text.Trim());
            if (bll.Them_CT_YCMH(dto)) 
            { 
                Load_DatagridView_CTYC(dto);
                return;
            }
            MessageBox.Show("Xảy ra lỗi khi thêm sản phẩm", "Thêm sản phẩm chưa thành công");
            return;

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            BLL_CT_YCMH bll = new BLL_CT_YCMH();
            DTO_CT_YeuCauMH dto = new DTO_CT_YeuCauMH();
            dto.MaYC = txtMaYC.Text.Trim();
            dto.MaSP = cbSanPham.SelectedValue.ToString();
            if (txtSoLuong.Text == "" || txtSoLuong.Text == null)
            {
                MessageBox.Show("Vui lòng chọn thêm số lượng sản phẩm", "Thêm sản phẩm vào yêu cầu không thành công");
                return;
            }
            dto.SoLuong = int.Parse(txtSoLuong.Text.Trim());
            if (bll.Xoa_SP_CT_YCMH(dto))
            {
                Load_DatagridView_CTYC(dto);
                return;
            }
            MessageBox.Show("Xảy ra lỗi khi xóa sản phẩm", "Xóa sản phẩm chưa thành công");
            return;
        }

        private void btnXoaYC_Click(object sender, EventArgs e)
        {
            BLL_YeuCauMH bll = new BLL_YeuCauMH();
            DTO_YeuCauMH dto = new DTO_YeuCauMH();
            dto.MaYC = txtMaYC.Text.Trim();
            DTO_CT_YeuCauMH ct = new DTO_CT_YeuCauMH();
            ct.MaYC = txtMaYC.Text.Trim();
            BLL_CT_YCMH bll_ct = new BLL_CT_YCMH();
            if (bll_ct.Xoa_ALL_CT_YCMH(ct))
            {
                if (bll.Xoa_YCMH(dto))
                {
                    Load_YCMH();
                    dgvCT_YC.DataSource = null;
                    btnCapNhat.Enabled = false;
                    btnYeuCauDuyet.Enabled = true;
                    btnXoaSP.Enabled = false;
                    btnThemSP.Enabled = false;
                    btnSuaSP.Enabled = false;
                    btnXoaYC.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa yêu cầu duyệt", "Xóa yêu cầu chưa thành công");
                    return;
                }
            }
            MessageBox.Show("Lỗi khi xóa chi tiết báo giá");
            
            
        }

        private void btnSPhamMoi_Click(object sender, EventArgs e)
        {
            UI_ThemSP ui    = new UI_ThemSP(nv);
            ui.ShowDialog();
        }
    }
}
