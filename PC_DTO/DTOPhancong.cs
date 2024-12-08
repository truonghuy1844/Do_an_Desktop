using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTOPhancong
    {
        private string maPC;
        private string maNV;
        private DateTime ngaygiao;
        private DateTime ngayht;
        private int kluong;
        private string tthai;

        public string MaPC { get => maPC; set => maPC = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime Ngaygiao { get => ngaygiao; set => ngaygiao = value; }
        public DateTime Ngayht { get => ngayht; set => ngayht = value; }
        public int Kluong { get => kluong; set => kluong = value; }
        public string Tthai { get => tthai; set => tthai = value; }
    }
}
