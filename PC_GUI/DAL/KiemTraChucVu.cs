using PC_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class KiemTraChucVu
    {
        public bool Kiem_Tra_QuanLy(DTONV nvien)
        {
            QLMHEntities4 qlmh = new QLMHEntities4();
            
            NHANVIEN check = qlmh.NHANVIENs.FirstOrDefault(s => s.MaNV == nvien.MaNV);
            if (check != null) 
            {
                if (check.ChucVu != "Nhân viên") return true;
            } return false; 
        }
        public bool Kiem_Tra_PhongBan(DTONV nvien) 
        {
            QLMHEntities4 qlmh = new QLMHEntities4();

            NHANVIEN check = qlmh.NHANVIENs.FirstOrDefault(s => s.MaNV == nvien.MaNV);
            if (check != null)
            {

                if (check.PhongBan == "Mua hàng") return true;
            }
            return false;
        }
        public bool Kiem_Tra_KeToan(DTONV nvien)
        {
            QLMHEntities4 qlmh = new QLMHEntities4();

            NHANVIEN check = qlmh.NHANVIENs.FirstOrDefault(s => s.MaNV == nvien.MaNV);
            if (check != null)
            {

                if (check.PhongBan == "Kế toán") return true;
            }
            return false;
        }
    }
}
