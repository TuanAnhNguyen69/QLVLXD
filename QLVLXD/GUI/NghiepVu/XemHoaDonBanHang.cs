using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLVLXD.BLL;

namespace QLVLXD.GUI.NghiepVu
{
    public partial class XemHoaDonBanHang : DevExpress.XtraEditors.XtraForm
    {
        public ThongKeBanHang main = new ThongKeBanHang();
        BLL_HoaDonBanHang _HoaDon = new BLL_HoaDonBanHang();
        BLL_CTHoaDonBanHang _CT = new BLL_CTHoaDonBanHang();
        BLL_ThongKeBanHang _ThongKe = new BLL_ThongKeBanHang();
        string _MaHDBH;

        public XemHoaDonBanHang(string MaHDBH)
        {
            InitializeComponent();

            // Load thông tin hóa đơn lên
            var listhoadon = _CT.GetListFromHDBH(MaHDBH.Trim());
            var hoadon = _HoaDon.GetObjectFromID(MaHDBH.Trim());
            var thongke = _ThongKe.GetRecord(hoadon);
            if (null == listhoadon || hoadon == null || thongke.MaHDBH == null)
            {
                MessageBox.Show("Hóa đơn này không tồn tại hoặc đã xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          

            this._MaHDBH = MaHDBH;
            this.Text = "Xem Hóa Đơn Bán Hàng (Hóa Đơn " + thongke.MaHDBH + ")";
            lb_MaHDBH.Text = thongke.MaHDBH;
            lb_NgayLap.Text = thongke.NgayLap.ToShortDateString();
            lb_NgayGiao.Text = thongke.NgayGiao.ToShortDateString();
            lb_TenNV.Text = thongke.TenNV;
            lb_TenKH.Text = thongke.TenKH;
            { // Loại KH
                var kh = (new BLL_KhachHang()).GetObjectFromID(thongke.MaKH);
                var loaikh = (new BLL_LoaiKhachHang()).GetObjectFromID(kh.MaLoaiKH.Trim()).TenLoaiKH.Trim();
                if (loaikh == null)
                    lb_LoaiKH.Text = "Khách hàng mới";
                else
                    lb_LoaiKH.Text = loaikh;
                /* Màu */
                if (lb_LoaiKH.Text == "Vàng")
                    lb_LoaiKH.ForeColor = Color.Gold;
                else if (lb_LoaiKH.Text == "Bạc")
                    lb_LoaiKH.ForeColor = Color.DimGray;
                else if (lb_LoaiKH.Text == "Kim Cương")
                    lb_LoaiKH.ForeColor = Color.SteelBlue;
                else
                    lb_LoaiKH.ForeColor = Color.Black;
            }
            lb_SoVatLieu.Text = thongke.SoVatLieu == 0 ? "(Không có vật liệu)" : thongke.SoVatLieu.ToString();
            if (thongke.SoVatLieu == 0)
                return;
            lb_TongTienVatLieu.Text = thongke.TienVatLieu.ToString("# ### ###").Trim() + " VND";
            lb_TongTienKhuyenMai.Text = thongke.TienKhuyenMai == 0 ? "(Không có khuyến mãi)" : thongke.TienKhuyenMai.ToString("# ### ###").Trim() + " VND";
            lb_TongTien.Text = thongke.TongTien.ToString("# ### ###").Trim() + " VND";
            lb_TrangThai.Text = thongke.TrangThai;
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                for (; grid_CT_view.Rows.Count > 0;) // Xóa hết dòng
                    grid_CT_view.Rows.RemoveAt(0);
            }
            catch
            { }
            try
            {
                var listCT = (new BLL_CTHoaDonBanHang()).GetListFromHDBH(_MaHDBH);
                foreach (DLL.CTHoaDonBanHang vari in listCT)
                {
                    var VatLieu = (new BLL_VatLieu()).GetObjectFromID(vari.MaVL);
                    var NCC = (new BLL_NhaCungCap()).GetObjectFromID(VatLieu.MaNCC);
                    var DVT = (new BLL_DonViTinhVatLieu()).GetObjectFromID(VatLieu.MaDVT);
                    grid_CT_view.Rows.Add(VatLieu.TenVL, NCC.TenNCC, DVT.DVT, vari.SoLuong, VatLieu.GiaBan, VatLieu.GiaBan * vari.SoLuong, vari.GhiChu);
                }
            }
            catch (Exception)
            { }
        }

        private void XemHoaDonBanHang_Load(object sender, EventArgs e)
        {

        }

        // [Xóa hóa đơn]
        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main == null) // Form gọi từ form bán hàng
            {
                BLLResult res = _HoaDon.Delete(_MaHDBH.Trim(), false);
                _HoaDon.MakeMessageBox(res);
            }
            else // gọi từ form thống kê bán hàng
                main.XoaHoaDon(_MaHDBH.Trim());
            this.Close();
        }

        private void XemHoaDonBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main != null)
                this.main.ThongKeBanHang_Load(null, null);
        }

        // [Xuất ra File]
        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "";
                FolderBrowserDialog browse = new FolderBrowserDialog();
                browse.Description = "Chọn đường dẫn lưu file:";
                if (browse.ShowDialog() == DialogResult.OK)
                {
                    filepath = browse.SelectedPath; if (filepath[filepath.Length - 1] != '\\') filepath = filepath + "\\"; 
                    string name = DateTime.Now.ToString();
                    name = name.Replace('/', '-');
                    name = name.Replace(':', '-');
                    if (tb_TenThongKe.Text == "")
                        tb_TenThongKe.Text = "Hóa Đơn Bán Hàng";
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Xuất Excel không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            (new PrintDialog()).ShowDialog();
        }

        private void cTHoaDonBanHangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}