using PC_DTO;
using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.BLL
{
    public class BLL_KiemTraTruyCap
    {
        public bool Kiem_Tra_Chuc_Vu (DTONV dTO_NhanVien)
        {
            if(dTO_NhanVien == null && dTO_NhanVien.MaNV =="" && dTO_NhanVien.MaNV == null) return false;
            KiemTraChucVu kt = new KiemTraChucVu();
            return kt.Kiem_Tra_QuanLy(dTO_NhanVien);
        }
        public bool Kiem_Tra_PhongBan(DTONV dTO_NhanVien)
        {
            if (dTO_NhanVien == null && dTO_NhanVien.MaNV == "" && dTO_NhanVien.MaNV == null) return false;
            KiemTraChucVu kt = new KiemTraChucVu();
            return kt.Kiem_Tra_PhongBan(dTO_NhanVien);
        }
        public bool Kiem_Tra_KeToan(DTONV dTO_NhanVien)
        {
            if (dTO_NhanVien == null && dTO_NhanVien.MaNV == "" && dTO_NhanVien.MaNV == null) return false;
            KiemTraChucVu kt = new KiemTraChucVu();
            return kt.Kiem_Tra_KeToan(dTO_NhanVien);
        }


    }
}
