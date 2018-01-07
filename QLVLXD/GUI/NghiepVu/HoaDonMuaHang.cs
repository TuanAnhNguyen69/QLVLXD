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

namespace QLVLXD.GUI
{
    public partial class HoaDonMuaHang : DevExpress.XtraEditors.XtraForm
    {
        BLL.BLL_VatLieu _BLL_VatLieu = new BLL.BLL_VatLieu();
        BLL.BLL_CTHoaDonMuaHang _BLL_CTHoaDonMuaHang = new BLL.BLL_CTHoaDonMuaHang();
        BLL.BLL_HoaDonMuaHang _BLL_HoaDonMuaHang = new BLL.BLL_HoaDonMuaHang();
        BLL.BLL_NhanVien _BLL_NhanVien = new BLL.BLL_NhanVien();
        BLL.BLL_NhaCungCap _BLL_NhaCungCap = new BLL.BLL_NhaCungCap();

        List<DLL.CTHoaDonMuaHang> _ListVatLieuHoaDon = new List<DLL.CTHoaDonMuaHang>();
        List<string> _ListMaCTHDMH_New = new List<string>();
        List<DLL.CTHoaDonMuaHang> _ListCTHoaDonMuaHang = new List<DLL.CTHoaDonMuaHang>();
        List<DLL.HoaDonMuaHang> _List_HoaDonMuaHang = new List<DLL.HoaDonMuaHang>();
        List<DLL.VatLieu> _List_Them = new List<DLL.VatLieu>();
        List<DLL.CTHoaDonMuaHang> _List_Bot = new List<DLL.CTHoaDonMuaHang>();
        DLL.NhanVien _NhanVien = new DLL.NhanVien();
        DLL.VatLieu _VatLieu = new DLL.VatLieu();
        DLL.CTHoaDonMuaHang _CTMua = new DLL.CTHoaDonMuaHang();

        bool IsAddNew;
        decimal TongTien = 0;
        public Main_Form mainform;
        public bool IsReset;

        public HoaDonMuaHang()
        {
            InitializeComponent();

            _List_HoaDonMuaHang = _BLL_HoaDonMuaHang.GetList();
            _ListCTHoaDonMuaHang = _BLL_CTHoaDonMuaHang.GetListAll();

            _NhanVien = _BLL_NhanVien.GetObjectFromID(_BLL_NhanVien.ReadNV());
            lb_TenNhanVien.Text = _NhanVien.TenNV.Trim();
            lb_MaNV.Text = _NhanVien.MaNV.Trim();
            btn_AddVatLieu.Enabled = false;
            btn_AddVatLieu.Enabled = false;

            ResetForNewInsert();
        }

        void ResetForNewInsert()
        {
            lb_MaHDMH.Text = _BLL_HoaDonMuaHang.NewMaHDMH();
            lb_NgayMua.Text = DateTime.Today.ToShortDateString();
            lb_TongTien.Text = "0 VNĐ";
            lb_SoVatLieu.Text = "0";
            nud_SoLuong.Value = 10;
            dt_NgayMua.Visible = false;

            _ListVatLieuHoaDon.Clear();
            _ListMaCTHDMH_New.Clear();
            _List_Bot.Clear();
            _List_Them.Clear();

            IsAddNew = true;
            btn_Them.Visible = true;
            btn_AddVatLieu.Enabled = false;
            btn_DeleteVatLieu.Enabled = false;
            lb_MaHDMH.ForeColor = Color.Green;

            LoadGridVatLieu();
            LoadGridCT();
        }

        private void LoadGridCT()
        {
            try
            {
                for (; grid_vatlieumua.Rows.Count > 0;) // Xóa hết dòng
                    grid_vatlieumua.Rows.RemoveAt(0);
            }
            catch { }

            try { 
            foreach (DLL.CTHoaDonMuaHang var in _ListVatLieuHoaDon)
                {
                    var VL = _BLL_VatLieu.GetObjectFromID(var.MaVL);
                    var DVT = (new BLL_DonViTinhVatLieu()).GetObjectFromID(VL.MaDVT);
                    var NCC = _BLL_NhaCungCap.GetObjectFromID(VL.MaNCC.Trim());
                    grid_vatlieumua.Rows.Add(var.MaCTHDMH, VL.TenVL.Trim(), NCC.TenNCC.Trim(), var.SoLuong, DVT.DVT.Trim(), var.SoLuong * VL.GiaMua);
                }
            } 
            catch { }
       
        }

        private void LoadGridVatLieu()
        {
            var listvl = _BLL_VatLieu.GetList();
            try
            {
                for (; grid_vatlieu.Rows.Count > 0;) // Xóa hết dòng
                    grid_vatlieu.Rows.RemoveAt(0);
            }
            catch { }

            foreach (DLL.VatLieu var in listvl)
            {
                var DVT = (new BLL_DonViTinhVatLieu()).GetObjectFromID(var.MaDVT);
                var NCC = _BLL_NhaCungCap.GetObjectFromID(var.MaNCC.Trim());
                grid_vatlieu.Rows.Add(var.MaVL.Trim(), var.TenVL.Trim(), NCC.TenNCC.Trim(), DVT.DVT.Trim(), var.GiaMua);
            }
        }

        bool MakeBreak()
        {
            if (_List_Them.Count == 0 && _List_Bot.Count == 0)
                return true;

            DialogResult res = MessageBox.Show("Hủy những vật liệu đã chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                foreach (DLL.VatLieu mem in _List_Them)
                {
                    _BLL_VatLieu.UpdateSoLuongPlus(mem.MaVL.Trim(), (decimal)mem.SoLuong);

                    foreach (DLL.CTHoaDonMuaHang mem2 in _ListVatLieuHoaDon)
                        if (mem2.MaVL.Trim() == mem.MaVL.Trim())
                        {
                            mem2.SoLuong -= (decimal)mem.SoLuong;
                            break;
                        }
                }

                _List_Them.Clear();

                foreach (DLL.CTHoaDonMuaHang mem in _List_Bot)
                {
                    _BLL_VatLieu.UpdateSoLuongPlus(mem.MaVL.Trim(), -mem.SoLuong);
                }

                _List_Bot.Clear();

                LoadGridVatLieu();
                return true;
            }
            else
                return false;
        }

        private void HoaDonMuaHang_Load(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        

            if (nud_SoLuong.Value < 1)
            {
                MessageBox.Show("Vui lòng nhập số lượng vật liệu lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


         
            bool haveinlist = false;
            decimal tientang = nud_SoLuong.Value * (decimal)_VatLieu.GiaMua;

            foreach (DLL.CTHoaDonMuaHang mem in _ListVatLieuHoaDon)
                if (_VatLieu.MaVL.Trim() == mem.MaVL.Trim())
                {
                    mem.SoLuong += nud_SoLuong.Value;
                    haveinlist = true;
                    break;
                }

            if (!haveinlist)
            {
                DLL.CTHoaDonMuaHang add = new DLL.CTHoaDonMuaHang();
                add.MaHDMH = lb_MaHDMH.Text;
                add.MaVL = _VatLieu.MaVL;
                add.SoLuong = nud_SoLuong.Value;
                add.GhiChu = _VatLieu.GhiChu;

                List<string> DS_MaCTHDMH = new List<string>();
                foreach (DLL.CTHoaDonMuaHang mem in _ListCTHoaDonMuaHang)
                    DS_MaCTHDMH.Add(mem.MaCTHDMH.Trim());

                if (_ListMaCTHDMH_New.Count > 0)
                    foreach (string mem in _ListMaCTHDMH_New)
                        DS_MaCTHDMH.Add(mem);

                add.MaCTHDMH = _BLL_CTHoaDonMuaHang.NewMaCTHDMH(DS_MaCTHDMH);
                _ListMaCTHDMH_New.Add(add.MaCTHDMH);

                _ListVatLieuHoaDon.Add(add);
            }

            TongTien += tientang;
            lb_TongTien.Text = ((long)TongTien).ToString("### ### ### ###").Trim() + " VNĐ";
            lb_SoVatLieu.Text = _ListVatLieuHoaDon.Count.ToString();

            LoadGridCT();

        }

       

        private void btn_Reset_Click(object sender, EventArgs e)
        {

            if (!MakeBreak())
                return;

            ResetForNewInsert();
        }

        private void HoaDonMuaHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MakeBreak())
                e.Cancel = true;
        }

        private void lb_TenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool CheckInput()
        {
            if (_ListVatLieuHoaDon.Count < 1)
            {
                MessageBox.Show("Vui lòng thêm vật liệu cho hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsAddNew && dt_NgayMua.DateTime > DateTime.Today)
            {
                MessageBox.Show("Vui lòng chọn ngày mua là từ ngày hiện tại trở về trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {


            if (!IsAddNew || !CheckInput())
            {
                return;
            }


            string result = _BLL_HoaDonMuaHang.Insert(lb_MaHDMH.Text, DateTime.Today, lb_MaNV.Text, TongTien);

            if (result != "Success")
            {
                if (result != "Error")
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else 
                    MessageBox.Show("Không thể thêm mới! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            result = _BLL_CTHoaDonMuaHang.Insert(_ListVatLieuHoaDon);

            if (result == "Error")
            {
                MessageBox.Show("Không thể thêm mới! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _BLL_HoaDonMuaHang.Delete(lb_MaHDMH.Text);

                return;
            }

            _ListCTHoaDonMuaHang = _BLL_CTHoaDonMuaHang.GetListAll();
            _List_HoaDonMuaHang.Clear();
            _List_HoaDonMuaHang = _BLL_HoaDonMuaHang.GetList();

            ResetForNewInsert();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            try { mainform.frm_banhang.IsReset = true; } catch { }
        }

       
        private void btn_DeleteVatLieu_Click(object sender, EventArgs e)
        {

            if (_BLL_VatLieu.GetObjectFromID(_CTMua.MaVL) == null)
            {
                MessageBox.Show("Vậy liệu bạn chọn không còn trong Cơ sở dữ liệu, vui lòng chọn vật liệu khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool haveinlist = false;
            foreach (string mem in _ListMaCTHDMH_New)
                if (_CTMua.MaCTHDMH.Trim() == mem)
                {
                    haveinlist = true;
                    _ListMaCTHDMH_New.Remove(mem);
                    break;
                }

            DLL.CTHoaDonMuaHang ct = new DLL.CTHoaDonMuaHang();
            ct.MaVL = _CTMua.MaVL;
            ct.MaHDMH = _CTMua.MaHDMH;
            ct.MaCTHDMH = _CTMua.MaCTHDMH;
            ct.SoLuong = _CTMua.SoLuong;
            _List_Bot.Add(ct);

            TongTien -= _CTMua.SoLuong * _BLL_VatLieu.GetObjectFromID(_CTMua.MaVL).GiaMua.Value;
            lb_TongTien.Text = ((long)TongTien).ToString("### ### ### ###").Trim() + " VNĐ";
            lb_SoVatLieu.Text = (_ListVatLieuHoaDon.Count - 1).ToString();

            if (!haveinlist)
            {
                foreach (DLL.VatLieu vl in _List_Them)
                    if (vl.MaVL.Trim() == _CTMua.MaVL.Trim())
                        _CTMua.SoLuong -= (decimal)vl.SoLuong;
            }

            foreach (DLL.CTHoaDonMuaHang var in _ListVatLieuHoaDon)
            {
                if (var.MaCTHDMH.Trim().Equals(_CTMua.MaCTHDMH.Trim()))
                {
                    _ListVatLieuHoaDon.Remove(var);
                }
                break;
            }

            LoadGridCT();

        }

        private void lb_TenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void lb_TenNhanVien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DLL.NhanVien data = _BLL_NhanVien.GetObjectFromTenNhanVien(lb_TenNhanVien.Text);
            if (data != null)
            {
                lb_MaNV.Text = data.MaNV.Trim();
            }
        }

       
        private void HoaDonMuaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!MakeBreak())
                return;
        }


        private void HoaDonMuaHang_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.MUAHANG));
                    IsReset = false;
                }
        }

        private void grid_vatlieumua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _CTMua.MaCTHDMH = grid_vatlieumua.Rows[e.RowIndex].Cells["CTMaCT"].Value.ToString().Trim();
            _CTMua.MaVL = _BLL_VatLieu.GetObjectFromTenVL(grid_vatlieumua.Rows[e.RowIndex].Cells["CTTenVL"].Value.ToString().Trim()).MaVL;
            _CTMua.SoLuong = (decimal) (grid_vatlieumua.Rows[e.RowIndex].Cells["SL"].Value);
            _CTMua.MaHDMH = lb_MaHDMH.Text;
            _CTMua.GhiChu = _BLL_VatLieu.GetObjectFromID(_CTMua.MaVL).GhiChu;
            btn_DeleteVatLieu.Enabled = true;

        }

        private void grid_vatlieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_AddVatLieu.Enabled = true;
            _VatLieu = _BLL_VatLieu.GetObjectFromTenVL(grid_vatlieu.Rows[e.RowIndex].Cells["TenVL"].Value.ToString().Trim());
        }
    }
}