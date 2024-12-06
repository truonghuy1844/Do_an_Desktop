using PC_DTO;
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
    public partial class BangCT_BG : Form
    {
       
        public BangCT_BG(DTO_CT_BaoGia dto)
        {
            InitializeComponent();
            DTO_CT_BaoGia ct = new DTO_CT_BaoGia();
            ct.MaSP = dto.MaSP;
            Loc_Bao_Gia bll = new Loc_Bao_Gia();
            dataGridView1.DataSource = bll.Loc_CTBG_TheoSP(ct);
        }
        
        private void BangCT_BG_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
