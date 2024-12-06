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
    public partial class QLKho : Form
    {
        BLLKho bLLKho = new BLLKho();
        public QLKho()
        {
            InitializeComponent();
        }

        private void QLKho_Load(object sender, EventArgs e)
        {
            dataGridViewDSKho.DataSource = bLLKho.LoadKho();
            LoadComboBox();

        }
        private void LoadComboBox()
        {
            comboBoxLoaiKho.DataSource = bLLKho.LoadLoaiKho();
            comboBoxLoaiKho.DisplayMember = "LoaiKho";
            comboBoxLoaiKho.ValueMember = "LoaiKho";
            comboBoxLoaiKho.SelectedIndex = -1;

            comboBoxSucChua.Items.Add("< 80 tấn");
            comboBoxSucChua.Items.Add("80 - 150 tấn");
            comboBoxSucChua.Items.Add("> 150 tấn");
            comboBoxSucChua.SelectedIndex = -1;
        }
        private void ApplyFilters()
        {
            string loaiKho = comboBoxLoaiKho.SelectedIndex >= 0 ? comboBoxLoaiKho.SelectedValue.ToString() : null;
            int? sucChuaFilter = comboBoxSucChua.SelectedIndex >= 0 ? comboBoxSucChua.SelectedIndex : (int?)null;
            string keyword = !string.IsNullOrEmpty(txtTim.Text) ? txtTim.Text.Trim() : null;

            var ketQua = bLLKho.LocKho(loaiKho, keyword, sucChuaFilter);

            dataGridViewDSKho.DataSource = ketQua;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddKho addKho = new AddKho();
            addKho.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaKho suaKho = new SuaKho();
            suaKho.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaKho xoaKho = new XoaKho();
            xoaKho.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewDSKho.DataSource = bLLKho.LoadKho();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text;
            

            if (string.IsNullOrEmpty(tuKhoa) && comboBoxLoaiKho.SelectedIndex == -1 && comboBoxSucChua.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập từ khóa hoặc lọc theo loại kho hoặc sức chứa để tìm kiếm.","Lời nhắc", MessageBoxButtons.OK);
                return;
            }
            try
            {
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtTim.Text = string.Empty;
            comboBoxLoaiKho.SelectedIndex = -1;
            comboBoxSucChua.SelectedIndex = -1;

            dataGridViewDSKho.DataSource = bLLKho.LoadKho();
        }

        
    }
}
