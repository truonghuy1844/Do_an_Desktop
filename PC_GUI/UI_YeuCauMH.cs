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
    public partial class UI_YeuCauMH : Form
    {
        public UI_YeuCauMH()
        {
            InitializeComponent();
        }

        //Load FORM
        private void UI_YeuCauMH_Load(object sender, EventArgs e)
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

        }
        ///Chuyển trạng thái
        ///



    }
}
