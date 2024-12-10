using PC_DTO;
using PC_GUI.BLL;
using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_GUI
{
    public partial class UI_ThemSP : Form
    {
        public DTO_NhanVien nv = new DTO_NhanVien();
        public UI_ThemSP(DTO_NhanVien nvien)
        {
            InitializeComponent();
            nv = nvien;
            BLL_KiemTraTruyCap bll = new BLL_KiemTraTruyCap();
            if (!bll.Kiem_Tra_PhongBan(nv))
            {
                this.Controls.Remove(btnSua);
                this.Controls.Remove(btnXoa);
                this.Controls.Remove(btnThem);
            }
        }

        private void Load_CBB()
        {
            
            List<string> comboBox_LoaiSP = new List<string>
            {
                "",
                "Nguyên liệu",
                "Bao bì",
                "Hàng tiêu dùng",
                "Thiết bị - máy móc",
                "Hóa chất"                
            };

            // Gán danh sách làm DataSource
            cbLoaiSP.DataSource = comboBox_LoaiSP;
            cbLoaiSP.MaxDropDownItems = 5;
            cbLoaiSP.DropDownHeight = cbLoaiSP.ItemHeight * 5;

            // Thiết lập giá trị mặc định (nếu cần)
            cbLoaiSP.SelectedIndex = 0; // Chọn mục đầu tiên


            List<string> comboBox_DVT = new List<string>
            {
                "",
                "Kg",
                "Lit",
                "Cái",
                "Kg",
                "Hộp",
                "gam",
                "gói",
                "combo"
            };

            // Gán danh sách làm DataSource
            cbDVT.DataSource = comboBox_DVT;
            cbDVT.MaxDropDownItems = 5;
            cbDVT.DropDownHeight = cbDVT.ItemHeight * 5;

            // Thiết lập giá trị mặc định (nếu cần)
            cbDVT.SelectedIndex = 0; // Chọn mục đầu tiên
        }
        private void UI_ThemSP_Load(object sender, EventArgs e)
        {
            Load_DGV_SP();
            //ToolTIP
            toolTip1.InitialDelay = 50; // Tooltip xuất hiện sau 0.5 giây
            toolTip1.AutoPopDelay = 5000; // Tooltip ẩn sau 5 giây
            toolTip1.IsBalloon = true; // Hiển thị Tooltip dạng bong bóng
            toolTip1.ToolTipTitle = "Mã sản phẩm bắt đầu bằng SP";
            Load_CBB();
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            
        }
        private void Load_DGV_SP()
        {
            dataGridView1.Rows.Clear();
            BLL_SanPham bll = new BLL_SanPham();
            dataGridView1.DataSource = bll.Load_SP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BLL_SanPham bll = new BLL_SanPham();
            DTO_SanPham sp = new DTO_SanPham();
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.LoaiSanPham = cbLoaiSP.SelectedItem.ToString();
            sp.DVT = cbDVT.SelectedItem.ToString();
            
            if (bll.Them_SP(sp))
            {
                Load_DGV_SP();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu", "Thêm sản phẩm không thành công");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BLL_SanPham bll = new BLL_SanPham();
            DTO_SanPham sp = new DTO_SanPham();
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.LoaiSanPham = cbLoaiSP.SelectedItem.ToString();
            sp.DVT = cbDVT.SelectedItem.ToString();

            if (bll.Sua_SP(sp))
            {
                Load_DGV_SP();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu", "Sửa sản phẩm không thành công");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLL_SanPham bll = new BLL_SanPham();
            DTO_SanPham sp = new DTO_SanPham();
            sp.MaSanPham = txtMaSP.Text;
            

            if (bll.Xoa_SP(sp))
            {
                Load_DGV_SP();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu", "Xóa sản phẩm không thành công");
                return;
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            BLL_SanPham bLL = new BLL_SanPham();
            
            DTO_SanPham sanPham = new DTO_SanPham();

            sanPham.MaSanPham = txtMaSP.Text.Trim();
            if (txtMaSP.Text.Trim().Length > 0)
            {
                
                if (bLL.KiemTra_MaSP(sanPham))
                {


                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    
                    cbDVT.SelectedIndex = 0;
                    cbLoaiSP.SelectedIndex = 0;
                                        
                    if (txtMaSP.Text.StartsWith("SP") && !Regex.IsMatch(txtMaSP.Text, @"[^a-zA-Z0-9]"))
                    {
                        toolTip1.ToolTipIcon = ToolTipIcon.Info;
                        toolTip1.SetToolTip(txtMaSP, "Hợp lệ");
                        btnThem.Enabled = true;
                    }
                    else
                    {
                        toolTip1.SetToolTip(txtMaSP, "Không hợp lệ");
                        toolTip1.ToolTipIcon = ToolTipIcon.Error;
                        btnThem.Enabled = false;

                    }

                }
                else
                {
                    toolTip1.SetToolTip(txtMaSP, "Đã tồn tại");
                    toolTip1.ToolTipIcon = ToolTipIcon.Error;
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    

                }
                
            }
            else
            {
                btnXoa.Enabled = false ;
                btnSua.Enabled = false ;
                btnThem.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                cbDVT.SelectedItem = row.Cells["DVT"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                cbLoaiSP.SelectedItem = row.Cells["LoaiSP"].Value.ToString();

            }
            catch { return; }
        }
    }
}
