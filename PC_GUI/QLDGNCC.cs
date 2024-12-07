using System;
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
    }
}
