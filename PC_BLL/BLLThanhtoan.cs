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
        public bool Capnhatthanhtoan(DTOThanhtoan tt)
        {
            return dalThanhtoan.Capnhatthanhtoan(tt);
        }

        public bool Xoathanhtoan(DTOThanhtoan tt)
        {
            return dalThanhtoan.Xoathanhtoan(tt);
        }

        public DataTable Timthanhtoan(string tukhoa)
        {
            return dalThanhtoan.Timthanhtoan(tukhoa);
        }
        public DataTable Thuchien(string matt)
        {
            return dalThanhtoan.Thuchien(matt);
        }
    }
   
}
