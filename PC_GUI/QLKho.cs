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
    public partial class QLKho : Form
    {
        public QLKho()
        {
            InitializeComponent();
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            AddKho addKho = new AddKho();
            addKho.Show();
            
        }
    }
}
