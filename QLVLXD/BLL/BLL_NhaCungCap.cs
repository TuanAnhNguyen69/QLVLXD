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
    class BLL_NhaCungCap : BLL
    {
        public List<QLVLXD.DLL.NhaCungCap> GetList()
        {
            List<QLVLXD.DLL.NhaCungCap> list = new List<DLL.NhaCungCap>();
            foreach (QLVLXD.DLL.NhaCungCap var in DB.NhaCungCaps)
                    list.Add(var);

            return list;
        }

        public QLVLXD.DLL.NhaCungCap GetObjectFromID(string MaNCC)
        {
            var Return = DB.NhaCungCaps.FirstOrDefault(data => data.MaNCC.Trim() == MaNCC);
            if (Return != null)
                return Return;
            else
                return null;
        }

        public QLVLXD.DLL.NhaCungCap GetObjectFromTenNhaCungCap(string TenNhaCungCap)
        {
            var Return = DB.NhaCungCaps.FirstOrDefault(data => data.TenNCC.Trim() == TenNhaCungCap);
            if (Return != null)
                return Return;
            else
                return null;
        }

        public string NewMaNCC()
        {
            List<string> danhsach = new List<string>();
            foreach (QLVLXD.DLL.NhaCungCap var in DB.NhaCungCaps)
                danhsach.Add(var.MaNCC.Trim());
            return NewID(danhsach, "NCC");
        }

        public bool Delete(string MaNCC)
        {
            try
            {
                var row = GetObjectFromID(MaNCC);
                if (row == null)
                    return false;

                var list = (new BLL_CTHoaDonBanHang()).GetList();
                foreach (DLL.CTHoaDonBanHang vari in list)
                {
                    var vatlieu = (new BLL_VatLieu()).GetObjectFromID(vari.MaVL);
                    if (vatlieu.MaNCC.Trim() == MaNCC)
                    {
                        (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Nhà cung cấp này cung cấp vật liệu cho các hóa đơn bán hàng hiện tại nên không thể xóa!"));
                        return false;
                    }
                }

                var list2 = (new BLL_VatLieu()).GetList();
                foreach (DLL.VatLieu vari in list2)
                    if (vari.MaNCC.Trim() == MaNCC)
                    {
                        (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Nhà cung cấp này cung cấp vật liệu cho kho hàng hiện tại nên không thể xóa!"));
                        return false;
                    }
                DialogResult result = MessageBox.Show("Nhấn [Yes] để xác nhận xóa nhà cung cấp " + row.TenNCC.Trim() + " - " + row.MaNCC.Trim() + "Hoặc nhấn [No] để hủy xóa.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.No)
                    return false;

                DB.NhaCungCaps.DeleteOnSubmit(row);
                DB.SubmitChanges();

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(string MaNCC, string TenNCC, string SDT, string DiaChi)
        {
            try
            {
                var old_data = DB.NhaCungCaps.FirstOrDefault(data => data.MaNCC.Trim() == MaNCC);  

                if (old_data.TenNCC.Trim() != TenNCC)
                {
                    List<string> DanhSachTen = new List<string>();
                    foreach (QLVLXD.DLL.NhaCungCap ncc in DB.NhaCungCaps)
                    {
                        DanhSachTen.Add(ncc.TenNCC.Trim());
                        if (CheckSameName(DanhSachTen, TenNCC))
                        {
                            MessageBox.Show("Vui lòng nhập tên nhà cung cấp khác, tên nhà cung cấp đã có trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                old_data.TenNCC = TenNCC;
                old_data.SDT = SDT;
                old_data.DiaChi = DiaChi;
                DB.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public bool Insert(string MaNCC, string TenNCC, string SDT, string DiaChi)
        {
            try
            {
                List<string> DanhSachTen = new List<string>();
                foreach (QLVLXD.DLL.NhaCungCap ncc in DB.NhaCungCaps)
                {
                    DanhSachTen.Add(ncc.TenNCC.Trim());
                    if (CheckSameName(DanhSachTen, MaNCC))
                    {
                        MessageBox.Show("Vui lòng nhập tên nhà cung cấp khác, tên nhà cung cấp đã có trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // ---------------------------------------------------------
                // Nếu hợp lệ thì thêm vào CSDL:
                // ---------------------------------------------------------

                QLVLXD.DLL.NhaCungCap var = new QLVLXD.DLL.NhaCungCap();
                var.MaNCC = MaNCC;
                var.TenNCC = TenNCC;
                var.SDT = SDT;
                var.DiaChi = DiaChi;

                DB.NhaCungCaps.InsertOnSubmit(var);
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

        public string GetTenNCCFromMaNCC(string MaNCC)
        {
            var Return = DB.NhaCungCaps.FirstOrDefault(data => data.MaNCC.Trim() == MaNCC.Trim());
            if (Return != null)
                return Return.TenNCC.Trim();
            else
                return null;
        }
    }
}
