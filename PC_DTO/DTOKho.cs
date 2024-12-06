using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTOKho
    {
        private string maKho;
        private string tenKho;
        private string loaiKho;
        private string diaChi;
        private string sucChua;

        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string LoaiKho { get; set; }
        public string DiaChi { get; set; }
        public string SucChua { get; set; }

        [Browsable(false)]
        public double SucChuaKg 
        {
            get
            {
                if (!string.IsNullOrEmpty(SucChua))
                {
                    string cleanValue = SucChua.Replace("tấn", "").Trim();
                    if (double.TryParse(cleanValue, out double tons))
                    {
                        return (double)(tons * 1000);
                    }
                }
                return 0; 
            }
        }


    }
    public class DTOLoaiKho
    {
        private string loaiKho;
        public string LoaiKho { get; set; }
    }
}
