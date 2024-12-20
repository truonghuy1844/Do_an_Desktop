using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;

namespace PC_GUI.BLL
{
    public class BLL_HoaDon
    {
            DAL_HoaDon dalHoadon = new DAL_HoaDon();
        public bool XoaThanhToan(DTOHoadon hdon)
        {
            return dalHoadon.XoaThanhToan(hdon);
        }
            public DataTable LoadData()
            {
                return dalHoadon.LoadData();
            }
            public bool Taohoadon(DTOHoadon hd)
            {

                return dalHoadon.Taohoadon(hd);
            }
            public bool Kiemtramahd(string mahd)
            {
                return dalHoadon.Kiemtramahd(mahd);
            }
            public bool Capnhathoadon(DTOHoadon hd)
            {
                return dalHoadon.Capnhathoadon(hd);
            }

            public bool Xoahoadon(DTOHoadon hd)
            {
                return dalHoadon.Xoahoadon(hd);
            }

            public DataTable TimHoadon(string tukhoa)
            {
                return dalHoadon.TimHoadon(tukhoa);
            }
            public DataTable loadmadmh()
            {
                return dalHoadon.loadmadmh();
            }
            public bool Kiemtramadmh(string madmh)
            {
                return dalHoadon.Kiemtramahd(madmh);
            }
            public DataTable loadtensp(string madm)
            {
                return dalHoadon.loadtensp(madm);
            }
            public DataTable loadsldg(string tensp)
            {
                return dalHoadon.loadsldg(tensp);
            }
        }
    }

