using PC_BLL;
using PC_DTO;
using PC_GUI.BLL;
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
    public partial class UI_View_BaoGia : Form
    {
        public UI_View_BaoGia()
        {
            InitializeComponent();
        }

        private void UI_View_BaoGia_Load(object sender, EventArgs e)
        {
            // Kiểu hiển thị lọc
            
            //HIển thị ngày bắt đầu
            DateTime dateTime = datetimepickerEnd.Value;
            DateTime datetimeStart = dateTime.AddYears(-1);
            datetimepickerStart.Value = datetimeStart;
            
            txtNgayBG.ReadOnly = true;
            txtMaBG.ReadOnly = true;
            txtNCC.ReadOnly = true;
            btnHienThi.Enabled = false;
            Load_CB_SP();
            Load_CB_NCC();
            datetimepickerStart.MaxDate = datetimepickerEnd.Value;
            datetimepickerEnd.MinDate = datetimepickerStart.Value;

            //Load dữ liệu
            ChuyenTrangThai();
            dataGridView1.ReadOnly = true;
            
            

        }
        // Biến chuyển trạng thái
        bool trangthaiHienThi = false;
        
        
        //Chuyển đổi trạng thái hiển thị
        private void ChuyenTrangThai()
        {
            BLL_BaoGia bll_bg = new BLL_BaoGia();
            BLL_CT_BaoGia bll_ct_bg = new BLL_CT_BaoGia();

            if (trangthaiHienThi == true)
            {
                DTO_CT_BaoGia dto = new DTO_CT_BaoGia();
                dto.MaBG = txtMaBG.Text;
                btnHienThi.Text = "Quay lại";
                trangthaiHienThi = false;

                dataGridView1.DataSource = bll_ct_bg.Load_CT_BG(dto);
                dataGridView1.Columns["MaSP"].Visible = false;

            }
            else
            {
                btnHienThi.Text = "Xem chi tiết báo giá";
                trangthaiHienThi = true;
                dataGridView1.DataSource = bll_bg.Load_BaoGia();
                //Format cho Datagridview
                
            }
        }
        

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!trangthaiHienThi)
            {
                return;
            }
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaBG.Text = row.Cells["MaBG"].Value.ToString();
                txtNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txtNgayBG.Text = row.Cells["NgayBG"].FormattedValue.ToString();

                btnHienThi.Enabled = true;
            }
            catch { return;  }
            
            
        }
        private void Load_CB_SP()
        {
            LoadCB load = new LoadCB();
            cbbLocSP.DataSource = load.Load_CB_SanPham();
            cbbLocSP.ValueMember = "MaSP";
            cbbLocSP.DisplayMember = "TenSP";
            cbbLocSP.SelectedValue = 0;
            cbbLocSP.MaxDropDownItems = 5;
            cbbLocSP.DropDownHeight = cbbLocSP.ItemHeight * 5;
        }
        private void Load_CB_NCC()
        {
            LoadCB load = new LoadCB();
            cbLoc_NCC.DataSource = load.Load_CB_NCC();
            cbLoc_NCC.ValueMember = "MaNCC";
            cbLoc_NCC.DisplayMember = "TenNCC";
            cbLoc_NCC.SelectedValue = 0;
            cbLoc_NCC.MaxDropDownItems = 5;
            cbLoc_NCC.DropDownHeight = cbLoc_NCC.ItemHeight * 5;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime date_Selected_Start = new DateTime();
            DateTime date_Selected_End = new DateTime();
            date_Selected_Start = datetimepickerStart.Value;
            date_Selected_End = datetimepickerEnd.Value;
            string maSP, maNCC;
            maSP = cbbLocSP.SelectedValue.ToString();
            maNCC = cbLoc_NCC.SelectedValue.ToString();
            DTO_BaoGia bg = new DTO_BaoGia();
            DTO_CT_BaoGia ct = new DTO_CT_BaoGia();
            bg.MaNCC = maNCC;
            ct.MaSP = maSP;

            Loc_Bao_Gia bll = new Loc_Bao_Gia();
            dataGridView1.DataSource = bll.Loc_BG(bg,ct,date_Selected_Start,date_Selected_End); 


            
        }

        private void cbLoc_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbLocSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datetimepickerStart_ValueChanged(object sender, EventArgs e)
        {
            datetimepickerEnd.MinDate = datetimepickerStart.Value;
        }

        private void datetimepickerEnd_ValueChanged(object sender, EventArgs e)
        {
            datetimepickerStart.MaxDate = datetimepickerEnd.Value;
        }

        private void btnLocKoTG_Click(object sender, EventArgs e)
        {
            DateTime date_Selected_Start = new DateTime();
            DateTime date_Selected_End = new DateTime();
            date_Selected_Start = datetimepickerStart.Value;
            date_Selected_End = datetimepickerEnd.Value;
            string maSP, maNCC;
            maSP = cbbLocSP.SelectedValue.ToString();
            maNCC = cbLoc_NCC.SelectedValue.ToString();
            DTO_BaoGia bg = new DTO_BaoGia();
            DTO_CT_BaoGia ct = new DTO_CT_BaoGia();
            bg.MaNCC = maNCC;
            ct.MaSP = maSP;

            Loc_Bao_Gia bll = new Loc_Bao_Gia();
            dataGridView1.DataSource = bll.Loc_BoTG_BG(bg,ct);
        }

        private void btnTuyChinhBG_Click(object sender, EventArgs e)
        {
            UI_NhapSua_BaoGia ui = new UI_NhapSua_BaoGia();
            ui.ShowDialog();
        }
    }
}
