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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PC_GUI
{
    public partial class UI_YeuCauMH : UserControl
    {
        public DTONV nv = new DTONV();
        public UI_YeuCauMH( DTONV nvien)
        {
            InitializeComponent();
            nv.MaNV = nvien.MaNV;
            BLL_KiemTraTruyCap kt = new BLL_KiemTraTruyCap();

            bool KiemTraChucVu = kt.Kiem_Tra_Chuc_Vu(nv);
            bool KiemTraPhongBan = kt.Kiem_Tra_PhongBan(nv);
            if(!KiemTraChucVu || !KiemTraPhongBan)
            {
                groupBox2.Controls.Remove(btnDuyet);
                groupBox2.Controls.Remove(btnTuChoi);
            }
            
        }
        //Điều chỉnh theo đăng nhập
       

        //Load FORM
        private void UI_YeuCauMH_Load(object sender, EventArgs e)
        {
            // Kiểu hiển thị lọc
            
            //HIển thị ngày bắt đầu
            DateTime dateTime = datetimepickerEnd.Value;
            DateTime datetimeStart = dateTime.AddYears(-1);
            datetimepickerStart.Value = datetimeStart;
            
            btnHienThi.Enabled = false;

            txtBoPhanYC.ReadOnly = true;
            txtSoSP.ReadOnly = true;
            txtTinhTrang.ReadOnly = true;
            txtMaYC.ReadOnly = true;
            txtGiaTriUocTinh.ReadOnly = true;
            txtNgayDuyet.ReadOnly = true;

            dataGridView1.ReadOnly = true;
            datetimepickerStart.MaxDate = datetimepickerEnd.Value;
            datetimepickerEnd.MinDate = datetimepickerStart.Value;
            Load_Combo_box();
           
            

            //Load dữ liệu
            ChuyenTrangThai();

        }
        //Load Combobox
        private void Load_Combo_box()
        {
            List<string> comboBoxTinhTrang = new List<string>
            {
                "",
                "Chờ duyệt",
                "Hủy yêu cầu",
                "Đã duyệt"
                
            };

            // Gán danh sách làm DataSource
            cbtinhTrang.DataSource = comboBoxTinhTrang;

            // Thiết lập giá trị mặc định (nếu cần)
            cbtinhTrang.SelectedIndex = 0; // Chọn mục đầu tiên

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
            cbPhongBanYC.DataSource = comboBoxPhongBan;

            // Thiết lập giá trị mặc định (nếu cần)
            cbPhongBanYC.SelectedIndex = 0; // Chọn mục đầu tiên
        }
        bool trangthaiHienThi = false;


        //Chuyển đổi trạng thái hiển thị
        private void ChuyenTrangThai()
        {
            BLL_YeuCauMH ycau = new BLL_YeuCauMH();
            BLL_CT_YCMH ctiet = new BLL_CT_YCMH();

            if (trangthaiHienThi == true)
            {
                DTO_CT_YeuCauMH dto = new DTO_CT_YeuCauMH();
                dto.MaYC = txtMaYC.Text;
                btnHienThi.Text = "Quay lại";
                trangthaiHienThi = false;

                dataGridView1.DataSource = ctiet.Load_CT_YC_MH(dto);
                

            }
            else
            {
                btnHienThi.Text = "Xem chi tiết yêu cầu";
                trangthaiHienThi = true;
                dataGridView1.DataSource = ycau.Load_YC_MH();
                dataGridView1.Columns["MaNV"].Visible = false;
                //Format cho Datagridview

            }
        }
        private void Load_Yeu_Cau_MH()
        {
            BLL_YeuCauMH yc = new BLL_YeuCauMH();
            dataGridView1.DataSource = yc.Load_YC_MH();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date_Start = new DateTime();
            DateTime date_End = new DateTime();
            date_Start = datetimepickerStart.Value;
            date_End = datetimepickerEnd.Value;
            Loc_YCMH loc = new Loc_YCMH();
            DTO_YeuCauMH dto = new DTO_YeuCauMH();
            dto.TinhTrang = cbtinhTrang.SelectedItem.ToString().Trim();
            dto.PhongBanYC = cbPhongBanYC.SelectedItem.ToString().Trim();

            if (cbPhongBanYC.SelectedIndex == 0 && cbtinhTrang.SelectedIndex == 0)
            {
                Load_Yeu_Cau_MH();
                return;
            }    
            if(cbPhongBanYC.SelectedIndex == 0)
            {
                dataGridView1.DataSource = loc.Loc_YC_TT( dto);
                return;
            }
            if (cbtinhTrang.SelectedIndex == 0)
            {
                dataGridView1.DataSource = loc.Loc_YC_PB( dto);
                return;
            }
            dataGridView1.DataSource = loc.Loc_YC_TT_PB( dto);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime date_Start = new DateTime();
            DateTime date_End = new DateTime();
            date_Start = datetimepickerStart.Value;
            date_End = datetimepickerEnd.Value;
            Loc_YCMH loc = new Loc_YCMH();
            DTO_YeuCauMH dto = new DTO_YeuCauMH();
            dto.TinhTrang = cbtinhTrang.SelectedItem.ToString().Trim();
            dto.PhongBanYC = cbPhongBanYC.SelectedItem.ToString().Trim();

            if (cbPhongBanYC.SelectedIndex == 0 && cbtinhTrang.SelectedIndex == 0)
            {
                dataGridView1.DataSource = loc.Loc_YC_TG(date_Start, date_End);
                return;
            }    
            if(cbPhongBanYC.SelectedIndex == 0)
            {
                dataGridView1.DataSource = loc.Loc_YC_TG_TT(date_Start, date_End, dto);
                return;
            }
            if (cbtinhTrang.SelectedIndex == 0)
            {
                dataGridView1.DataSource = loc.Loc_YC_TG_PB(date_Start, date_End, dto);
                return;
            }
            dataGridView1.DataSource = loc.Loc_YC_TG_TT_PB(date_Start, date_End, dto);

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai();
           
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn duyệt yêu cầu mua hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DTO_YeuCauMH dto = new DTO_YeuCauMH();
                dto.MaYC = txtMaYC.Text;
                dto.NgayDuyet = DateTime.Now;
                dto.TinhTrang = "Đã duyệt";
                BLL_YeuCauMH bll = new BLL_YeuCauMH();
                if (txtTinhTrang.Text != "Chờ duyệt")
                {
                    MessageBox.Show("Yêu cầu đã được duyệt/ từ chối");
                    return;
                }
                if (bll.Duyet_YCMH(dto))
                {
                    Load_Yeu_Cau_MH();
                    txtTinhTrang.Text = "Đã duyệt";
                }
                else { MessageBox.Show("Xảy ra lỗi khi duyệt", "Duyệt yêu cầu chưa thành công"); }
            }
                
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn từ chối/hủy yêu cầu mua hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DTO_YeuCauMH dto = new DTO_YeuCauMH();
                dto.MaYC = txtMaYC.Text;
                dto.NgayDuyet = DateTime.Now;
                dto.TinhTrang = "Hủy yêu cầu";
                BLL_YeuCauMH bll = new BLL_YeuCauMH();
                if (txtTinhTrang.Text != "Chờ duyệt")
                {
                    MessageBox.Show("Yêu cầu đã được duyệt/ từ chối");
                    return;
                }
                if (bll.Duyet_YCMH(dto))
                {
                    Load_Yeu_Cau_MH();
                    txtTinhTrang.Text = "Hủy yêu cầu";
                }
                else { MessageBox.Show("Xảy ra lỗi khi duyệt", "Duyệt yêu cầu chưa thành công"); }
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loc_YCMH loc = new Loc_YCMH();
            BLL_YeuCauMH bll = new BLL_YeuCauMH();
            if (!trangthaiHienThi)
            {

                return;
            }
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtBoPhanYC.Text = row.Cells["PhongBanYC"].Value.ToString();
                txtMaYC.Text = row.Cells["MaYC"].Value.ToString();
                txtTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
                txtNgayDuyet.Text = row.Cells["NgayDuyet"].Value.ToString();

                DTO_YeuCauMH dto = new DTO_YeuCauMH();
                dto.MaYC = row.Cells["MaYC"].Value.ToString();
                txtSoSP.Text = loc.Count_CT_YC(dto).ToString();
                txtGiaTriUocTinh.Text = bll.Gia_Uoc_Tinh(dto).ToString("N", System.Globalization.CultureInfo.InvariantCulture) + " đ";
                


                btnHienThi.Enabled = true;
            }
            catch { return; }
            
        }

        private void cbPhongBanYC_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cbtinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaYC_TextChanged(object sender, EventArgs e)
        {
            DTO_YeuCauMH dto = new DTO_YeuCauMH();
            BLL_YeuCauMH ycmh = new BLL_YeuCauMH();
            dto.MaYC = txtMaYC.Text.Trim();
            if (!ycmh.KiemTra_TT_Duyet(dto))
            {
                btnDuyet.Enabled = false;
                btnTuChoi.Enabled = false;
                
            }
            else
            {
                btnDuyet.Enabled = true;
                btnTuChoi.Enabled = true;
            }


        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoPhanYC_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (trangthaiHienThi)
            {

                return;
            }
            try
            {
                DTO_CT_BaoGia ct_bg = new DTO_CT_BaoGia();
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ct_bg.MaSP = row.Cells["MaSP"].Value.ToString().Trim();
                BangCT_BG ui = new BangCT_BG(ct_bg);
                ui.ShowDialog();
                
            }
            catch { return; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        ///Chuyển trạng thái
        ///



    }
}
