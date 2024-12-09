using PC_DTO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nvien = new DTO_NhanVien();
            nvien.MaNV = "NV003";
            UI_View_BaoGia ui = new UI_View_BaoGia(nvien);
            ui.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nvien = new DTO_NhanVien();
            nvien.MaNV = "NV002";
            UI_NhapSua_BaoGia ui = new UI_NhapSua_BaoGia(nvien);
            ui.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nvien = new DTO_NhanVien();
            nvien.MaNV = "NV003";
            UI_YeuCauMH ui = new UI_YeuCauMH(nvien);
            ui.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nvien = new DTO_NhanVien();
            nvien.MaNV = "NV003";
            UI_NhapSua_YeuCauMH ui = new UI_NhapSua_YeuCauMH(nvien);
            ui.Show();
        }
    }
}
