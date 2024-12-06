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
    public partial class UI_NhapSua_YeuCauMH : Form
    {
        public UI_NhapSua_YeuCauMH()
        {
            InitializeComponent();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {

        }

        private void UI_NhapSua_YeuCauMH_Load(object sender, EventArgs e)
        {
            Load_CB_SP();
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
        }
        
    }
}
