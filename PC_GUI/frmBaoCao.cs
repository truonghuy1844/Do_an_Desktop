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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quanlydonhang formqldh = new Quanlydonhang();
            formqldh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlydonhang_NV formqldhnv = new Quanlydonhang_NV();   
            formqldhnv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PCCV pccv = new PCCV();
            pccv.Show();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PCCV_NV pccvnv = new PCCV_NV();
            pccvnv.Show();
        }
    }
}
