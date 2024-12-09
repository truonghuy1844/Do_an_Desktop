using PC_DAL;
using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_BLL
{
    public class BLLHoadon
    {
        DALHoadon dalHoadon = new DALHoadon();
        public DataTable LoadData()
        {
            return dalHoadon.LoadData();
        }
        public bool Taohoadon(DTOHoadon hd)
        {

            return dalHoadon.Taohoadon(hd);
        }
        public bool Kiemtramahd(string mahd)
        {
            return dalHoadon.Kiemtramahd(mahd);
        }
        public bool Capnhathoadon(DTOHoadon hd)
        {
            return dalHoadon.Capnhathoadon(hd);
        }

        public bool Xoahoadon(DTOHoadon hd)
        {
            return dalHoadon.Xoahoadon(hd);
        }

        public DataTable TimHoadon(string tukhoa)
        {
            return dalHoadon.TimHoadon(tukhoa);
        }
    }
}
