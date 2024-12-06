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
    }
}
