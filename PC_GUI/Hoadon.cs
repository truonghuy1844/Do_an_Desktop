using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_DTO;
using PC_GUI.BLL;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace PC_GUI
{
    public partial class Hoadon : UserControl
    {
        public Hoadon()
        {
            InitializeComponent();
        }
        public BLL_HoaDon bllHoadon = new BLL_HoaDon();
        private void Hoadon_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = bllHoadon.LoadData();

            dataGridView1.Columns["MaSP"].Visible = false;
            dataGridView1.Columns["DonGia"].Visible = false;
            dataGridView1.Columns["Tonghoadon"].Visible = false;
            dataGridView1.Columns["SoLuong"].Visible = false;
            label10.Text = "Tìm kiếm\nmã DMH và mã HD";





            txtSoluong.ReadOnly = true;
            txtDongia.ReadOnly = true;
            txtMaHD.ReadOnly = true;
            dataGridView1.ReadOnly = true;

            txtThanhtien.Enabled = false;
            cbMaDH.DataSource = bllHoadon.loadmadmh();
            cbMaDH.DisplayMember = "MaDMH";
            cbMaDH.ValueMember = "MaDMH";

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool okTao = true;


               


                if (dateTimePicker1.Value > DateTime.Now)
                {
                    okTao = false;
                    MessageBox.Show("Ngày lập không thể lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK);
                    dateTimePicker1.Focus();
                }
                if (!txtMaHD.Text.All(char.IsDigit))
                {
                    okTao = false;
                    MessageBox.Show("Mã hóa đơn chỉ chứa ký tự số ", "Lỗi dữ liệu", MessageBoxButtons.OK);
                    txtMaHD.Focus();
                }
                if ((txtMaHD.Text.Length < 1) || (txtMaHD.Text.Length > 10))
                {
                    okTao = false;
                    MessageBox.Show("Mã hóa đơn tối thiểu 1 ký tự và không quá 10 ký tự");
                    txtMaHD.Focus();
                }

                if (okTao)
                {
                    DTOHoadon dhmoi = new DTOHoadon();
                    dhmoi.MaHD = int.Parse(txtMaHD.Text);
                    dhmoi.Ngaylap = dateTimePicker1.Value;
                    dhmoi.MaDMH = cbMaDH.SelectedValue.ToString();
                    dhmoi.GhiChu = txtGhichu.Text;
                    if (bllHoadon.Capnhathoadon(dhmoi))
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin đơn hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                    }

                }
                dataGridView1.DataSource = bllHoadon.LoadData();
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }


       

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tukhoa = txtMaHD.Text;
            DataTable dt = bllHoadon.TimHoadon(tukhoa);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả, hãy thử lại!", "Thông báo", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
            }
            else
            {
                MessageBox.Show("Tìm thấy kết quả", "Thông báo", MessageBoxButtons.OK);
                dataGridView1.DataSource = dt;
            }

        }

        
        

        private void btnThanhtoan_Click_1(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtMaHD.Text);
                int b = int.Parse(txtThanhtien.Text);
                if ((txtMaHD != null && txtMaHD.Text != "") && (txtThanhtien != null && txtThanhtien.Text != ""))
                {


                    Thanhtoan tt = new Thanhtoan(a, b);


                    tt.ShowDialog();

                    dataGridView1.DataSource = bllHoadon.LoadData();

                }
                else MessageBox.Show("Vui lòng chọn hóa đơn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { return; }
           
            
        
    }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtMaHD.Enabled = false;
            cbMaDH.Enabled = false;
            cbSP.Enabled = false;
                        

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                cbSP.SelectedValue = row.Cells["MaSP"].Value.ToString();
                txtGhichu.Text = row.Cells["GhiChu"].Value.ToString();
                cbMaDH.SelectedValue = row.Cells["MaDMH"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                txtSoluong.Text = row.Cells["SoLuong"].Value.ToString();
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                txtDongia.Text = row.Cells["DonGia"].Value.ToString();
                txtThanhtien.Text = row.Cells["Tonghoadon"].Value.ToString();
            }
            catch { return; }
        }

       

        private void cbMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaDH.SelectedIndex != -1)
            {   
            string madmh = cbMaDH.SelectedValue.ToString();
            cbSP.DataSource = bllHoadon.loadtensp(madmh);
            cbSP.DisplayMember = "TenSP";
            cbSP.ValueMember = "MaSP";
            }
        }
        private void cbSanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSP.SelectedIndex != -1)
            {
                try
                {
                    string masp = cbSP.SelectedValue.ToString();
                    var result = bllHoadon.loadsldg(masp);

                    if (result is DataTable dt && dt.Rows.Count > 0)
                    {
                        decimal dongia = Convert.ToDecimal(dt.Rows[0]["DonGia"]);
                        int soluong = Convert.ToInt32(dt.Rows[0]["SoLuong"]);

                        txtDongia.Text = dongia.ToString();
                        txtSoluong.Text = soluong.ToString();
                    }
                    else
                    {
                        txtDongia.Text = "0";
                        txtSoluong.Text = "0";
                    }
                }
                catch
                {

                    MessageBox.Show($"Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                BLL_ThanhToan bllThanhtoan = new BLL_ThanhToan();

                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa đơn hàng này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    DTOHoadon dhxoa = new DTOHoadon();
                    dhxoa.MaHD = int.Parse(txtMaHD.Text.Trim());
                    if (bllHoadon.XoaThanhToan(dhxoa))
                    {
                        if (bllHoadon.Xoahoadon(dhxoa))
                        {
                            dataGridView1.DataSource = bllHoadon.LoadData();
                        }
                    }     
                    else
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại\nHóa đơn đã thanh toán hoặc dữ liệu lỗi\n\nVui lòng kiểm tra", "Thông báo", MessageBoxButtons.OK);
                    }
                    txtMaHD.Clear();
                    txtGhichu.Clear();
                    txtDongia.Clear();
                    txtSoluong.Clear();
                    txtThanhtien.Clear();

                }
            }
            else
            { MessageBox.Show("Hãy chọn 1 hàng để thực hiện"); }
        }

        private void btnCapnhat_Click_1(object sender, EventArgs e)
                    {

        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            string tukhoa = txtTim.Text.Trim();
            dataGridView1.DataSource = bllHoadon.TimHoadon(tukhoa);
            
                
            
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllHoadon.LoadData();
        }


        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
