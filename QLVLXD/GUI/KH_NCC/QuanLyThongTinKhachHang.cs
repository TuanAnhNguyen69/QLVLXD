using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVLXD.BLL;

namespace QLVLXD
{
    public partial class KhachHang : Form
    {
        BLL_KhachHang khachhang = new BLL_KhachHang();
        BLL_LoaiKhachHang bll_loaikh = new BLL_LoaiKhachHang();
        public Main_Form mainform;
        public bool IsReset;

        public KhachHang()
        {
            InitializeComponent();

            List<string> listgioitinh = new List<string>();
            listgioitinh.Add("Nam");
            listgioitinh.Add("Nữ");
            khachhang.MakeComboBoxNoAuto(cbb_GioiTinh, listgioitinh.ToList());

            var listloaikh = bll_loaikh.GetList();
            List<string> nameloaikh = new List<string>();
            foreach (DLL.LoaiKhachHang mem in listloaikh)
                nameloaikh.Add(mem.TenLoaiKH.Trim());
            bll_loaikh.MakeComboBoxNoAuto(cbb_LoaiKH, nameloaikh);

            ResetThongTin();
            Refresh_Grid();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
        }

        private void Refresh_Grid()
        {

            try
            {
                for (; grid_khachhang.Rows.Count > 0;)
                    grid_khachhang.Rows.RemoveAt(0);
            }
            catch
            { }
            try
            {
                var listKH = khachhang.GetList();
                foreach (DLL.KhachHang vari in listKH)
                {
                    grid_khachhang.Rows.Add(vari.MaKH, vari.TenKH, vari.NgaySinh, vari.GioiTinh, vari.DiaChi, vari.SDT, vari.CMND, vari.Email, bll_loaikh.GetObjectFromID( vari.MaLoaiKH).TenLoaiKH, vari.CongNo);
                }
            }
            catch (Exception)
            { }
        }

        private void ResetThongTin()
        {
            lb_MaKH.Text = khachhang.NewMaKH();
            txt_TenKH.Text = null;
            dtP_NgaySinh.Value = DateTime.Now;
            cbb_GioiTinh.SelectedIndex = 0;
            txt_DiaChi.Text = null;
            txt_SDT.Text = null;
            txt_CMND.Text = null;
            txt_Email.Text = null;
            cbb_LoaiKH.SelectedIndex = 0;
            lb_CongNo.Text = "0 VNĐ";
            btn_Xoa.Visible = false;
            btn_CapNhat.Visible = false;
            btn_Them.Visible = true;
        }

        private bool KiemTraDuLieuNhap()
        {
            if (lb_MaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_TenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DateTime.Today.Year - dtP_NgaySinh.Value.Year < 4)
            {
                MessageBox.Show("Tuổi của khách hàng phải lớn hơn 3!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbb_GioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giới tính không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("SDT không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_CMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_Email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbb_LoaiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Loại khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            var kh = bll_loaikh.GetObjectFromTenLoaiKH(cbb_LoaiKH.Text.Trim());
            if (kh == null)
                return;

            if (khachhang.Insert(lb_MaKH.Text, txt_TenKH.Text, dtP_NgaySinh.Value, cbb_GioiTinh.Text, txt_DiaChi.Text, txt_SDT.Text, decimal.Parse(txt_CMND.Text), txt_Email.Text, kh.MaLoaiKH.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_thongkebanhang.IsReset = true; } catch {}
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var kh = khachhang.GetObjectFromID(lb_MaKH.Text.Trim());
       

            if (khachhang.Delete(lb_MaKH.Text.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_thongkebanhang.IsReset = true; } catch {}
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var khor = khachhang.GetObjectFromID(lb_MaKH.Text.Trim());
           

            if (!KiemTraDuLieuNhap())
                return;

            var kh = bll_loaikh.GetObjectFromTenLoaiKH(cbb_LoaiKH.Text.Trim());
            if (kh == null)
                return;

            if (khachhang.Update(lb_MaKH.Text, txt_TenKH.Text, dtP_NgaySinh.Value, cbb_GioiTinh.Text, txt_DiaChi.Text, txt_SDT.Text, decimal.Parse(txt_CMND.Text), txt_Email.Text, kh.MaLoaiKH.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_thongkebanhang.IsReset = true; } catch {}
            }
        }

        private void btn_ResetThongTin_Click(object sender, EventArgs e)
        {
            ResetThongTin();
            btn_Them.Enabled = true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txt_SDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_CMND_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void gridControl_KhachHang_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.KHACHHANG));
                    IsReset = false;
                }
        }

        private void grid_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Xoa.Visible = true;
            btn_CapNhat.Visible = true;
            btn_Them.Visible = false;

            lb_MaKH.Text = grid_khachhang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString().Trim();
            txt_TenKH.Text = grid_khachhang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString().Trim();
            dtP_NgaySinh.Text = grid_khachhang.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString().Trim();
            cbb_GioiTinh.Text = grid_khachhang.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString().Trim();
            txt_DiaChi.Text = grid_khachhang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString().Trim();
            txt_SDT.Text = grid_khachhang.Rows[e.RowIndex].Cells["SDT"].Value.ToString().Trim();
            txt_CMND.Text = grid_khachhang.Rows[e.RowIndex].Cells["CMND"].Value.ToString().Trim();
            txt_Email.Text = grid_khachhang.Rows[e.RowIndex].Cells["Email"].Value.ToString().Trim();
            int congno = Int32.Parse(grid_khachhang.Rows[e.RowIndex].Cells["CongNo"].Value.ToString().Trim());
            lb_CongNo.Text = (congno == 0 ? "0" : congno.ToString("# ### ###").Trim()) + " VNĐ";
            cbb_LoaiKH.Text = grid_khachhang.Rows[e.RowIndex].Cells["LoaiKH"].Value.ToString().Trim();
        }
    }
}