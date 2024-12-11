using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.BLL
{
    public class LoadCB
    {
        public DataTable Load_CB_SanPham()
        {
            LoadComboBox load = new LoadComboBox();
            return load.Load_ComboBox_SanPham();
        }
        public DataTable Load_CB_NCC()
        {
            LoadComboBox load = new LoadComboBox();
            return load.Load_Cb_NCC();
        }
    }
}
