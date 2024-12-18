using PC_DAL;
using PC_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_BLL
{
    public class BLLTruycap
    {
        DALChucvu dalchucvu = new DALChucvu();
        public bool Kiemtraquanly(DTONhanvien nv)
        { return dalchucvu.Kiemtraquanly(nv); }
        public bool Kiemtraphongban(DTONhanvien nv)
        {
            return dalchucvu.Kiemtraphongban(nv);
        }
    }
}
