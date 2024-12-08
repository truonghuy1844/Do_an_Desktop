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
    public partial class Chitietdonmua_NV : Form
    {
        public Chitietdonmua_NV()
        {
            InitializeComponent();
        }
        BLLDonmuahang bllDonmua = new BLLDonmuahang();

        private void Chitietdonmua_NV_Load(object sender, EventArgs e)
        {
            loadmadh();
            loadmasp();
            cbMaDH.SelectedIndex = -1;
            cbMaSP.SelectedIndex = -1;
            cbMabaogia.SelectedIndex = -1;
            txtTensp.Text = string.Empty;
            txtDongia.Text = string.Empty;
            txtTensp.Enabled = false;
            txtDongia.Enabled = false;

            cbMaDH.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;

        }
        void loadmadh()
        {
            QLMHDataContext db = new QLMHDataContext();
            cbMaDH.DataSource = db.DONMUAHANG_LQs.ToList();
            cbMaDH.DisplayMember = "MaDMH";
            cbMaDH.ValueMember = "MaDMH";
        }
        //Load mã đơn hàng mới 
        void loadmadhtao()
        {
            QLMHDataContext db = new QLMHDataContext();
            var mactdm = db.CT_DONMUAHANG_LQs.Select(ct => ct.MaDMH).ToList();
            var ctdonmoi = from dm in db.DONMUAHANG_LQs
                           select dm;
            cbMaDH.DataSource = ctdonmoi.ToList();
            cbMaDH.DisplayMember = "MaDMH";
            cbMaDH.ValueMember = "MaDMH";
        }
        void loadmasp()
        {
            QLMHDataContext db = new QLMHDataContext();
            cbMaSP.DataSource = db.CT_BAOGIA_LQs.ToList();
            cbMaSP.DisplayMember = "MaSP";
            cbMaSP.ValueMember = "MaSP";
        }
        //Load chi tiết đơn mua 
        void loadchitietdm()
        {
            QLMHDataContext db = new QLMHDataContext();
            db.Connection.Open();
            var listdm = from dm in db.CT_DONMUAHANG_LQs
                         join sp in db.SANPHAM_LQs on dm.MaSP equals sp.MaSP
                         select new
                         {
                             dm.MaDMH,
                             dm.MaSP,
                             sp.TenSP,
                             dm.MaBG,
                             dm.SoLuong
                         };

            dataGridViewChitiet.DataSource = listdm.ToList();
            db.Connection.Close();
        }

        private void btnChitietdon_Click(object sender, EventArgs e)
        {
            QLMHDataContext db = new QLMHDataContext();
            var listdm = from dm in db.CT_DONMUAHANG_LQs
                         join sp in db.SANPHAM_LQs on dm.MaSP equals sp.MaSP
                         select new
                         {
                             dm.MaDMH,
                             dm.MaSP,
                             sp.TenSP,
                             dm.MaBG,
                             dm.SoLuong
                         };
            dataGridViewChitiet.DataSource = listdm.ToList();
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaSP.SelectedIndex != -1)
            {
                QLMHDataContext db = new QLMHDataContext();
                var tenSP = (from sp in db.SANPHAM_LQs
                             where sp.MaSP == cbMaSP.SelectedValue.ToString()
                             select sp.TenSP).FirstOrDefault();
                txtTensp.Text = tenSP;
                var mabg = from bg in db.CT_BAOGIA_LQs
                           where bg.MaSP == cbMaSP.SelectedValue.ToString()
                           select bg;
                cbMabaogia.DataSource = mabg;
                cbMabaogia.DisplayMember = "MaBG";
                cbMabaogia.ValueMember = "MaBG";
            }
        }

        private void cbMabaogia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMabaogia.SelectedIndex != -1)
            {
                QLMHDataContext db = new QLMHDataContext();
                var dongia = (from bg in db.CT_BAOGIA_LQs
                              where bg.MaBG == cbMabaogia.SelectedValue.ToString()
                              select bg.DonGia).FirstOrDefault();
                txtDongia.Text = dongia.ToString();
            }
        }

        private void btnTaoctmua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            loadmadhtao();
            cbMaDH.Enabled = true;
            cbMaSP.Enabled = true;
            txtSoluong.Text = string.Empty;
            txtDongia.Text = string.Empty;
            txtTensp.Text = string.Empty;
            cbMaDH.SelectedIndex = -1;
            cbMaSP.SelectedIndex = -1;
            cbMabaogia.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool okTao = true;
            //1.Kiểm tra đã chọn mã đơn hàng 
            if (cbMaDH.SelectedIndex == -1)
            {
                okTao = false;
                MessageBox.Show("Hãy chọn mã đơn hàng!", "Thông báo", MessageBoxButtons.OK);
                cbMaDH.Focus();
            }
            //2.Kiểm tra số lượng 
            if (txtSoluong.Text.Length == 0 || !txtSoluong.Text.All(char.IsDigit))
            {
                okTao = false;
                MessageBox.Show("Hãy nhập số lượng, số lượng phải là số nguyên. Ví dụ: 13", "Thông báo", MessageBoxButtons.OK);
                txtSoluong.Focus();
            }
            //3.Kiểm tra khóa chính 
            if (bllDonmua.Kiemtrakhoactdonmua(cbMaDH.SelectedValue.ToString(), cbMaSP.SelectedValue.ToString(), cbMabaogia.SelectedValue.ToString()))
            {
                okTao = false;
                MessageBox.Show("Chi tiết đơn mua đã tồn tại trong hệ thống. Hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                cbMaDH.Focus();
            }
            if (okTao)
            {
                CT_DONMUAHANG_LQ ctiet = new CT_DONMUAHANG_LQ(); // tạo mới 
                ctiet.MaDMH = cbMaDH.SelectedValue.ToString();
                ctiet.MaSP = cbMaSP.SelectedValue.ToString();
                ctiet.MaBG = cbMabaogia.SelectedValue.ToString();
                ctiet.SoLuong = Convert.ToInt32(txtSoluong.Text);

                QLMHDataContext db = new QLMHDataContext();
                db.Connection.Open();
                try
                {
                    db.CT_DONMUAHANG_LQs.InsertOnSubmit(ctiet);
                    db.SubmitChanges();
                    MessageBox.Show("Tạo mới chi tiết đơn mua thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo mới chi tiết đơn mua thất bại", ex.Message);
                }
                finally { db.Connection.Close(); }
                loadchitietdm();
            }
        }

        private void dataGridViewChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewChitiet.CurrentRow != null)
            {
                cbMaDH.SelectedValue = dataGridViewChitiet.CurrentRow.Cells["MaDMH"].Value.ToString();
                cbMaSP.SelectedValue = dataGridViewChitiet.CurrentRow.Cells["MaSP"].Value.ToString();
                cbMabaogia.SelectedValue = dataGridViewChitiet.CurrentRow.Cells["MaBG"].Value.ToString();
                txtSoluong.Text = dataGridViewChitiet.CurrentRow.Cells["SoLuong"].Value.ToString();

                cbMaDH.Enabled = false;
                cbMaSP.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        { // NV không cập nhật và xóa
        }

        private void btnDanhgiasp_Click(object sender, EventArgs e)
        {
            Danhgiadonhang_NV danhgia1 = new Danhgiadonhang_NV();
            danhgia1.Show();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QLMHDataContext db = new QLMHDataContext();
            db.Connection.Close();
            try
            {
                var listtim = (from dm in db.CT_DONMUAHANG_LQs
                               join sp in db.SANPHAM_LQs on dm.MaSP equals sp.MaSP
                               where dm.MaDMH.Contains(txtTim.Text.Trim()) || sp.TenSP.Contains(txtTim.Text.Trim())
                              || dm.MaBG.Contains(txtTim.Text.Trim()) || dm.MaSP.Contains(txtTim.Text.Trim())
                               select new
                               {
                                   dm.MaDMH,
                                   dm.MaSP,
                                   sp.TenSP,
                                   dm.MaBG,
                                   dm.SoLuong
                               }).ToList();
                if (listtim.Count > 0)
                {
                    MessageBox.Show("Tìm thấy dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                    dataGridViewChitiet.DataSource = listtim;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                    dataGridViewChitiet = null;
                }
            }
            catch (Exception ex) { MessageBox.Show("Không tìm thấy dữ liệu", ex.Message); }
            finally
            {
                db.Connection.Close();
            }
        }
    }
}

