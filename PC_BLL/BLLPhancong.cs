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
    public class BLLPhancong
    {
        DALPhancong dalPhancong = new DALPhancong();
        public DataTable loadphancong()
        { return dalPhancong.loadphancong(); }

        public DataTable loadtennv()
        {
            return dalPhancong.loadtennv(); 
        }
        public bool Taophancong(DTOPhancong pc)
        {
            return dalPhancong.Taophancong(pc);
        }

        public bool kiemtramapc(string mapc)
        {
            return dalPhancong.kiemtramapc(mapc);
        }

        public bool Suaphancong(DTOPhancong pc)
        {
            return dalPhancong.Suaphancong(pc);
        }

        public bool Xoaphancong(DTOPhancong pc)
        {
            return dalPhancong.Xoaphancong(pc);
        }

        public DataTable Timphancong(string tukhoa)
        { 
            return dalPhancong.Timphancong(tukhoa);
        }

        public DataTable loadcbtt()
        {
            return dalPhancong.loadcbtt();
        }
        public DataTable hoanthanh(string trangthai)
        {
            return dalPhancong.hoanthanh(trangthai);
        }

        //public DataTable dahoanthanh()
        //{
        //    return dalPhancong.dahoanthanh();
        //}
    }
}
