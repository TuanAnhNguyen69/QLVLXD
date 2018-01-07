using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

using QLVLXD.DLL;

namespace QLVLXD.BLL
{
    class BLL_NhanVien : BLL
    {
        public List<QLVLXD.DLL.NhanVien> GetList()
        {
            List<QLVLXD.DLL.NhanVien> list = new List<DLL.NhanVien>();
            foreach (QLVLXD.DLL.NhanVien var in DB.NhanViens)
                    list.Add(var);

            return list;
        }

        public QLVLXD.DLL.NhanVien GetObjectFromID(string MaNV)
        {
            var Return = DB.NhanViens.FirstOrDefault(data => data.MaNV.Trim() == MaNV);
            if (Return != null)
                return Return;
            else
                return null;
        }

        public QLVLXD.DLL.NhanVien GetObjectFromTenNhanVien(string TenNhanVien)
        {
            var Return = DB.NhanViens.FirstOrDefault(data => data.TenNV.Trim() == TenNhanVien);
            if (Return != null)
                return Return;
            else
                return null;
        }

        public bool Insert(string MaNV, string TenNV, string DiaChi, string SDT, DateTime NgaySinh, string GioiTinh, string ChucVu, decimal MucLuong, decimal CMND, string Email)
        {
            try
            {
                List<decimal> DanhSachCMND = new List<decimal>();
                foreach (QLVLXD.DLL.NhanVien nhanvien in DB.NhanViens)
                {
                    DanhSachCMND.Add(nhanvien.CMND);
                    if (CheckCMND(DanhSachCMND, CMND))
                    {
                        MessageBox.Show("Vui lòng nhập CMND khác, CMND đã có trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }


                QLVLXD.DLL.NhanVien var = new QLVLXD.DLL.NhanVien();
                var.MaNV = MaNV;
                var.TenNV = TenNV;
                var.DiaChi = DiaChi;
                var.SDT = SDT;
                var.NgaySinh = NgaySinh;
                var.GioiTinh = GioiTinh;
                var.ChucVu = ChucVu;
                var.MucLuong = MucLuong;
                var.CMND = CMND;
                var.Email = Email;

                DB.NhanViens.InsertOnSubmit(var);
                DB.SubmitChanges();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(string MaNV)
        {
            try
            {
                var row = GetObjectFromID(MaNV);
                if (row == null)
                    return false;
                {
                    var list = (new BLL_HoaDonBanHang()).GetList();
                    foreach (DLL.HoaDonBanHang vari in list)
                        if (vari.MaNV.Trim() == MaNV)
                        {
                            (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Nhân viên này lập cho các hóa đơn bán hàng hiện tại nên không thể xóa!"));
                            return false;
                        }
                    var list2 = (new BLL_HoaDonMuaHang()).GetList();
                    foreach (DLL.HoaDonMuaHang vari in list2)
                        if (vari.MaNV.Trim() == MaNV)
                        {
                            (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Nhân viên này lập cho các hóa đơn mua hàng hiện tại nên không thể xóa!"));
                            return false;
                        }
                    var list3 = (new BLL_User()).GetList();
                    foreach (DLL.User vari in list3)
                        if (vari.MaNV.Trim() == MaNV)
                        {
                            (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Nhân viên này có trong danh sách User của hệ thống nên không thể xóa!"));
                            return false;
                        }
                }
                DialogResult result = MessageBox.Show("Nhấn [Yes] để xác nhận xóa nhân viên " + row.TenNV.Trim() + "-" + row.MaNV.Trim() + ". Hoặc nhấn [No] để hủy xóa.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.No)
                    return false;
                DB.NhanViens.DeleteOnSubmit(row);
                DB.SubmitChanges();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(string MaNV, string TenNV, string DiaChi, string SDT, DateTime NgaySinh, string GioiTinh, string ChucVu, decimal MucLuong, decimal CMND, string Email)
        {
            try
            {
                var old_data = DB.NhanViens.FirstOrDefault(data => data.MaNV.Trim() == MaNV);
                if (old_data == null)
                    return false;

                /* Kiểm tra CMND không được trùng */
                if (old_data.CMND != CMND)
                {
                    List<decimal> DanhSachCMND = new List<decimal>();
                    foreach (QLVLXD.DLL.NhanVien nhanvien in DB.NhanViens)
                    {
                        DanhSachCMND.Add(nhanvien.CMND);
                        if (CheckCMND(DanhSachCMND, CMND))
                        {
                            MessageBox.Show("Vui lòng nhập CMND khác, CMND đã có trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
             
                old_data.TenNV = TenNV;
                old_data.DiaChi = DiaChi;
                old_data.SDT = SDT;
                old_data.NgaySinh = NgaySinh;
                old_data.GioiTinh = GioiTinh;
                old_data.ChucVu = ChucVu;
                old_data.MucLuong = MucLuong;
                old_data.CMND = CMND;
                old_data.Email = Email;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string NewMaNV()
        {
            List<string> danhsach = new List<string>();
            foreach (QLVLXD.DLL.NhanVien var in DB.NhanViens)
                danhsach.Add(var.MaNV.Trim());
            return NewID(danhsach, "NV");
        }
    }
}
