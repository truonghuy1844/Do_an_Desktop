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
    public class BLLThanhtoan
    {
        DALThanhtoan dalThanhtoan = new DALThanhtoan();
        public DataTable LoadData()
        {
            return dalThanhtoan.LoadData();
        }
        public bool Taothanhtoan(DTOThanhtoan tt)
        {

            return dalThanhtoan.Taothanhtoan (tt);
        }
        public bool Kiemtramatt(string matt)
        {
            return dalThanhtoan.Kiemtramatt(matt);
        }
        public bool Capnhatthanhtoan(DTOThanhtoan hd)
        {
            return dalThanhtoan.Capnhatthanhtoan(hd);
        }

        public bool Xoathanhtoan(DTOThanhtoan hd)
        {
            return dalThanhtoan.Xoathanhtoan(hd);
        }

        public DataTable Timthanhtoan(string tukhoa)
        {
            return dalThanhtoan.Timthanhtoan(tukhoa);
        }
    }
   
}
