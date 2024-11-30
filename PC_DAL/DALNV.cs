using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using PC_DTO;

namespace PC_DAL
{
    public class DALNV
    {
        QLMHEntities db = new QLMHEntities();
        public List<DTONV> LoadNV()
        {
            var listNV = from nv in db.NHANVIENs
                         select new DTONV
                         {
                             MaNV = nv.MaNV,
                             TenNV = nv.TenNV,
                             DiaChi = nv.DiaChi,
                             GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                             SDT = nv.DienThoai,
                             ChucVu = nv.ChucVu,
                             PhongBan = nv.PhongBan
                         };
            return listNV.ToList();
        }
    }
}
