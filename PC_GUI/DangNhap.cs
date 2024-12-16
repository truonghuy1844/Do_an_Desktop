using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI
{
    public class DangNhap
    {
        string tenDangNhap;
        string matKhau;

        public DangNhap(string tenDangNhap, string matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    }
}
