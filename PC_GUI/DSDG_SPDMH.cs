using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_GUI.BLL;
using PC_DTO;

namespace PC_GUI
{
    public partial class DSDG_SPDMH : Form
    {
        BLLNCC bLLNCC = new BLLNCC();
        private string maDGNCC;
        //public DSDG_SPDMH(string maDGNCC)
        //{
        //    InitializeComponent();
        //    this.maDGNCC = maDGNCC;
        //    dataGridViewDSDGSP.DataSource = bLLNCC.LoadDGDMH(maDGNCC);
        //}

        private void DSDG_SPDMH_Load(object sender, EventArgs e)
        {

            
        }
    }
}
