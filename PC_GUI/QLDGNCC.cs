﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_BLL;
using PC_DTO;

namespace PC_GUI
{
    public partial class QLDGNCC : Form
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaDGNCC suaDGNCC = new SuaDGNCC();
            suaDGNCC.Show();
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
            comboBoxChatLuong.DataSource = bLLNCC.LoadDiemChatLuong();
            comboBoxChatLuong.DisplayMember = "DiemChatLuong";
            comboBoxChatLuong.ValueMember = "DiemChatLuong";
            comboBoxChatLuong.SelectedIndex = -1;

            comboBoxHieuQua.DataSource = bLLNCC.LoadDiemHieuQua();
            comboBoxHieuQua.DisplayMember = "DiemHieuQua";
            comboBoxHieuQua.ValueMember = "DiemHieuQua";
            comboBoxHieuQua.SelectedIndex = -1;

            comboBoxGiaCa.DataSource = bLLNCC.LoadDiemGiaCa();
            comboBoxGiaCa.DisplayMember = "DiemGiaCa";
            comboBoxGiaCa.ValueMember = "DiemGiaCa";
            comboBoxGiaCa.SelectedIndex = -1;

            comboBoxMucDo.DataSource = bLLNCC.LoadMucDoDG();
            comboBoxMucDo.DisplayMember = "MucDoDanhGia";
            comboBoxMucDo.ValueMember = "MucDoDanhGia";
            comboBoxMucDo.SelectedIndex = -1;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxChatLuong.SelectedIndex = -1;
            comboBoxHieuQua.SelectedIndex = -1;
            comboBoxGiaCa.SelectedIndex = -1;
            comboBoxMucDo.SelectedIndex = -1;

            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;
        }
        private void ApplyFilters()
        {
            string tuKhoa = !string.IsNullOrEmpty(txtTim.Text) ? txtTim.Text.Trim() : null;
            int? diemChatLuong = comboBoxChatLuong.SelectedIndex >= 0 ? (int?)comboBoxChatLuong.SelectedValue : null;
            int? diemGiaCa = comboBoxGiaCa.SelectedIndex >= 0 ? (int?)comboBoxGiaCa.SelectedValue : null;
            int? diemHieuQua = comboBoxHieuQua.SelectedIndex >= 0 ? (int?)comboBoxHieuQua.SelectedValue : null;
            string mucDo = comboBoxMucDo.SelectedIndex >= 0 ? comboBoxMucDo.SelectedItem.ToString() : null;
            DateTime fromDate = dateTimePickerFrom.Value;
            DateTime toDate = dateTimePickerTo.Value;

            var ketQua = bLLNCC.LocDGNCC(tuKhoa,diemChatLuong, diemGiaCa, diemHieuQua, mucDo, fromDate, toDate);

            dataGridViewDGNCC.DataSource = ketQua;
        }

    }
}
