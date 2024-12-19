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
        public DALThanhtoan dalThanhtoan = new DALThanhtoan();
       
        public bool Kiemtramatt(string matt)
        {
            return dalThanhtoan.Kiemtramatt(matt);
        }
        public bool Capnhatthanhtoan(DTOThanhtoan tt)
        {
            return dalThanhtoan.Capnhatthanhtoan(tt);
        }

       
        public DataTable Thuchien(string mahd)
        {
            return dalThanhtoan.Thuchien(mahd);
        }
        public DTOThanhtoan  LoadThanhtoan (string mahd)
        {
            return dalThanhtoan.LoadThanhtoan(mahd);
        }
    }
   
}
