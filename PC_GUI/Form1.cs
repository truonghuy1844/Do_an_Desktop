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
            UI_View_BaoGia ui = new UI_View_BaoGia();
            ui.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI_NhapSua_BaoGia ui = new UI_NhapSua_BaoGia();
            ui.Show();
        }
    }
}
