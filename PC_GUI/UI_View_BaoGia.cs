using PC_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_GUI
{
    public partial class UI_View_BaoGia : Form
    {
        public UI_View_BaoGia()
        {
            InitializeComponent();
        }

        private void UI_View_BaoGia_Load(object sender, EventArgs e)
        {
            // Kiểu hiển thị lọc
            datetimepickerStart.Format = DateTimePickerFormat.Custom;
            datetimepickerStart.CustomFormat = "dd/MM/yyyy";
            //HIển thị ngày bắt đầu
            DateTime dateTime = datetimepickerEnd.Value;
            DateTime datetimeStart = dateTime.AddYears(-1);
            datetimepickerStart.Value = datetimeStart;
            datetimepickerEnd.Format = DateTimePickerFormat.Custom;
            datetimepickerEnd.CustomFormat = "dd/MM/yyyy";
            ChuyenTrangThai();
        }
   
        bool trangthaiHienThi = false;
        //Chuyển đổi trạng thái hiển thị
        private void ChuyenTrangThai()
        {
            BLL_BaoGia bll_bg = new BLL_BaoGia();
            BLL_CT_BaoGia bll_ct_bg = new BLL_CT_BaoGia();

            if (trangthaiHienThi == true)
            {
                btnHienThi.Text = "Xem báo giá khác";
                trangthaiHienThi = false;

                dataGridView1.DataSource = bll_ct_bg.Load_CT_BG();
            }
            else
            {
                btnHienThi.Text = "Xem chi tiết báo giá";
                trangthaiHienThi = true;
                dataGridView1.DataSource = bll_bg.Load_BaoGia();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai();
        }
    }
}
