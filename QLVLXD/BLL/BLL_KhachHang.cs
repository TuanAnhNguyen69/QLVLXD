﻿using System;
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
    class BLL_KhachHang : BLL
    {
        public List<QLVLXD.DLL.KhachHang> GetList()
        {
            List<QLVLXD.DLL.KhachHang> list = new List<DLL.KhachHang>();
            foreach (QLVLXD.DLL.KhachHang var in DB.KhachHangs)
                    list.Add(var);

            return list;
        }

        public QLVLXD.DLL.KhachHang GetObjectFromID(string MaKH)
        {
            var Return = DB.KhachHangs.FirstOrDefault(data => data.MaKH.Trim() == MaKH);
            if (Return != null)
                return Return;
            else
                return null;
        }

        public BLLResult CongNoPlus(long Add, string TenKH)
        {
            try
            {
                DLL.KhachHang tmp = GetObjectFromTenKhachHang(TenKH.Trim());
                if (tmp == null)
                    return new BLLResult((int)BLLResultType.NOT_EXIST);
                tmp.CongNo = tmp.CongNo + Add;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(0);
            }
        }

        public QLVLXD.DLL.KhachHang GetObjectFromTenKhachHang(string TenKhachHang)
        {
            var Return = DB.KhachHangs.FirstOrDefault(data => data.TenKH.Trim() == TenKhachHang);
            if (Return != null)
                return Return;
            else
                return null;
        }

        public bool Insert(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string DiaChi,
           string SDT, decimal CMND, string Email, string LoaiKH)
        {
            try
            {
                List<decimal> DanhSachCMND = new List<decimal>();
                foreach (QLVLXD.DLL.KhachHang khachhang in DB.KhachHangs)
                {
                    DanhSachCMND.Add(khachhang.CMND);
                    if (CheckCMND(DanhSachCMND, CMND))
                    {
                        MessageBox.Show("Vui lòng nhập CMND khác, CMND đã có trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

              
                QLVLXD.DLL.KhachHang var = new QLVLXD.DLL.KhachHang();

                var.MaKH = MaKH;
                var.TenKH = TenKH;
                var.NgaySinh = NgaySinh;
                var.GioiTinh = GioiTinh;
                var.DiaChi = DiaChi;
                var.SDT = SDT;
                var.CMND = CMND;
                var.Email = Email;
                var.MaLoaiKH = LoaiKH;
                var.CongNo = 0;

                DB.KhachHangs.InsertOnSubmit(var);
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

        public bool Delete(string MaKH)
        {
            try
            {
                var row = GetObjectFromID(MaKH);
                if (row == null)
                    return false;
                {
                    /* BH */
                    var list = (new BLL_HoaDonBanHang()).GetList();
                    foreach (DLL.HoaDonBanHang vari in list)
                        if (vari.MaKH.Trim() == MaKH)
                        {
                            (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Khách hàng này đã mua các hóa đơn bán hàng cửa cửa hàng nên không thể xóa!"));
                            return false;
                        }                   
                }
                DialogResult result = MessageBox.Show("Nhấn [Yes] để xác nhận xóa nhân viên " + row.TenKH.Trim() + " (" + row.MaKH.Trim() + "). Hoặc nhấn [No] để hủy xóa.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.No)
                    return false;

                DB.KhachHangs.DeleteOnSubmit(row);
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

        public bool Update(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string DiaChi, string SDT, decimal CMND, string Email, string LoaiKH)
        {
            try
            {
                var old_data = DB.KhachHangs.FirstOrDefault(data => data.MaKH.Trim() == MaKH);

                /* Kiểm tra CMND không được trùng */
                if (old_data.CMND != CMND)
                {
                    List<decimal> DanhSachCMND = new List<decimal>();
                    foreach (QLVLXD.DLL.KhachHang khachhang in DB.KhachHangs)
                    {
                        DanhSachCMND.Add(khachhang.CMND);
                        if (CheckCMND(DanhSachCMND, CMND))
                        {
                            MessageBox.Show("Vui lòng nhập CMND khác, CMND đã có trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                old_data.TenKH = TenKH;
                old_data.NgaySinh = NgaySinh;
                old_data.GioiTinh = GioiTinh;
                old_data.DiaChi = DiaChi;
                old_data.SDT = SDT;
                old_data.CMND = CMND;
                old_data.Email = Email;
                old_data.MaLoaiKH = LoaiKH;
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

        public string NewMaKH()
        {
            List<string> danhsach = new List<string>();
            foreach (QLVLXD.DLL.KhachHang var in DB.KhachHangs)
                danhsach.Add(var.MaKH.Trim());
            return NewID(danhsach, "KH");
        }
    }
}
