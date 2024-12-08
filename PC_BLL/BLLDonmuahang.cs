using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PC_DAL;
using PC_DTO;

namespace PC_BLL
{
    public class BLLDonmuahang
    {
        DALDonmuahang dAlDonmua = new DALDonmuahang();
        //public List<DONMUAHANG> loadDonMua()
        //{
        //    //return dAlDonmua.loadDonMua();
        //}
        public bool Taodonhang(DTODonhang dh)
        {

            return dAlDonmua.Taodonhang(dh);
        }
        public bool Suadonhang(DTODonhang dh)
        {
            return dAlDonmua.Suadonhang(dh);
        }
        public bool Xoadonhang(DTODonhang dh)
        {
            return dAlDonmua.Xoadonhang(dh);
        }
        public DataTable TimDonhang(string tukhoa)
        {
            return dAlDonmua.TimDonhang(tukhoa);
        }
        public bool Kiemtramadmh(string madm)
        { 
            return dAlDonmua.Kiemtramadmh(madm); 
        }
        public bool Kiemtramadgsp(string madg)
        {
            return dAlDonmua.KiemtraMaDGSP(madg);
        }
        public DataTable loaddmh()
        { return dAlDonmua.loaddmh(); }
        public int donhoantat()
        {
            return dAlDonmua.donhoantat();
        }

        public int doncho()
        {
            return dAlDonmua.doncho();
        }

        //Chi tiết đơn mua 
        public bool Kiemtrakhoactdonmua(string maDMH, string maSP, string mabg)
        {
            return dAlDonmua.Kiemtrakhoactdonmua(maDMH, maSP, mabg);    
        }
    }
}
