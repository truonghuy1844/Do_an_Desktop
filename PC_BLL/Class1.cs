using PC_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PC_BLL
{
    public class BLLNhanVien
    {
        DALNhanVien dALNhanVien = new DALNhanVien();
        public bool CheckDangNhap(string tenDangNhap, string matKhau)
        {

                List<NHANVIEN> lnv = new List<NHANVIEN>();
                lnv = dALNhanVien.DangNhap();

            foreach (var nv in lnv)
            {
                if (nv.MaNV == tenDangNhap && nv.DienThoai == matKhau)
                    return true;
            }
            return false;
            
        }

    }
}
