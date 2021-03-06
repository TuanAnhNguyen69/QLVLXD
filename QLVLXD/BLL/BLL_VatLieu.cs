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
using QLVLXD.BLL;
using QLVLXD.DLL;

namespace QLVLXD.BLL
{
    class BLL_VatLieu : BLL
    {
        public BLLResult CheckData(bool IsInsert, string MaVL, string TenVL, string MaNCC, decimal SoLuong, string DonviTinh, decimal GiaMua, decimal GiaBan, string GhiChu)
        {
            // Mã VL
            if (IsInsert && GetObjectFromID(MaVL) != null)
            {
                return new BLLResult("Mã vật liệu đã tồn tại");
            }

            // Tên VL
            List<string> DanhSachTen = new List<string>();
            foreach (QLVLXD.DLL.VatLieu vl in DB.VatLieus)
                if ((IsInsert || vl.MaVL.Trim() != MaVL.Trim()))
                    DanhSachTen.Add(vl.TenVL.Trim());
            if (CheckSameName(DanhSachTen, TenVL))
            {
                return new BLLResult("Vui lòng nhập tên vật liệu khác, tên bạn nhập đã có trong cơ sở dữ liệu!");
            }

            return new BLLResult((int)BLLResultType.SUCCESS);
        }

        public BLLResult Insert(string MaVL, string TenVL, string MaNCC, decimal SoLuong, string DonviTinh, decimal GiaMua, decimal GiaBan, string GhiChu)
        {
            try
            {
                QLVLXD.DLL.VatLieu vl = new QLVLXD.DLL.VatLieu();
                vl.TenVL = TenVL;
                vl.MaVL = MaVL;
                vl.MaNCC = MaNCC;
                vl.SoLuong = SoLuong;
                vl.MaDVT = DonviTinh;
                vl.GiaMua = GiaMua;
                vl.GiaBan = GiaBan;
                vl.GhiChu = GhiChu;
                DB.VatLieus.InsertOnSubmit(vl);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(0);
            }
}

        public BLLResult UpdateSoLuong(string MaVL, decimal SoLuong)
        {
            try
            {
                var vl = GetObjectFromID(MaVL.Trim());
                if (vl == null)
                    throw new Exception();

                vl.SoLuong = SoLuong;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch
            {
                return new BLLResult(0);
            }
        }


        public BLLResult UpdateSoLuongSub(string MaVL, decimal SoLuongSub)
        {
            try
            {
                var vl = GetObjectFromID(MaVL.Trim());
                if (vl == null)
                    throw new Exception();

                vl.SoLuong -= SoLuongSub;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public void UpdateSoLuongPlus(string MaVL, decimal Plus)
        {
            try
            {
                var vl = GetObjectFromID(MaVL);
                if (vl == null)
                    return;

                vl.SoLuong = vl.SoLuong + Plus;
                DB.SubmitChanges();
            }
            catch
            {
                return;
            }
        }

        public BLLResult Delete(string MaVL, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaVL);
                if (row != null)
                {
                    {
                        /* CTHDBH */
                        var list2 = (new BLL_CTHoaDonBanHang()).GetList();
                        foreach (DLL.CTHoaDonBanHang vari in list2)
                            if (vari.MaVL.Trim() == row.MaVL.Trim())
                                return new BLLResult("Có hóa đơn bán hàng chứa vật liệu này, không xóa được!");
                        /* Bảng CTHDMH */
                        var list3 = (new BLL_CTHoaDonMuaHang()).GetList();
                        foreach (DLL.CTHoaDonMuaHang vari in list3)
                            if (vari.MaVL.Trim() == MaVL)
                                return new BLLResult("Có hóa đơn mua hàng chứa vật liệu này, không xóa được!");
                    }
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa vật liệu \"" + row.TenVL.Trim() + "\" ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }
                    DB.VatLieus.DeleteOnSubmit(row);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_DELETE);
                }
                return new BLLResult((int)BLLResultType.NOT_EXIST);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public BLLResult Update(string MaVL, string TenVL, string MaNCC, decimal SoLuong, string MaDVT, decimal GiaMua, decimal GiaBan, string GhiChu)
        {
            try
            {
                var old_data = GetObjectFromID(MaVL);
                if (old_data == null)
                    throw new Exception();

                if (old_data.MaNCC.Trim() != MaNCC)
                {
                    old_data.MaNCC = MaNCC;
                }
                
                if (old_data.GhiChu.Trim() != GhiChu)
                {
                    old_data.GhiChu = GhiChu;
                }

                // Phần DVT
                if (old_data.MaDVT.Trim() != MaDVT)
                {
                    old_data.MaDVT = MaDVT;
                }

                // Phần giá
                if (old_data.GiaMua != GiaMua)
                {
                    old_data.GiaMua = GiaMua;
                }
                if (old_data.GiaBan != GiaBan)
                {
                    old_data.GiaBan = GiaBan;
                }
      

                if (old_data.SoLuong != SoLuong)
                {
                    old_data.SoLuong = SoLuong;
                }

                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public string NewMaVL()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.VatLieu var in DB.VatLieus)
                    danhsach.Add(var.MaVL.Trim());
                return NewID(danhsach, "VL");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<QLVLXD.DLL.VatLieu> GetList()
        {
            try
            {
                List<QLVLXD.DLL.VatLieu> list = new List<DLL.VatLieu>();
                foreach (QLVLXD.DLL.VatLieu var in DB.VatLieus)
                        list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.VatLieu> GetListForBanHang()
        {
            try
            {
                List<QLVLXD.DLL.VatLieu> list = new List<DLL.VatLieu>();
                foreach (QLVLXD.DLL.VatLieu var in DB.VatLieus)
                    if (var.SoLuong > 0)
                        list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public QLVLXD.DLL.VatLieu GetObjectFromID(string MaVL)
        {
            try
            {
                var Return = DB.VatLieus.FirstOrDefault(data => data.MaVL.Trim() == MaVL.Trim());
                if (Return != null)
                    return Return;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.VatLieu GetObjectFromTenVL(string TenVL)
        {
            try
            {
                var Return = DB.VatLieus.FirstOrDefault(data => data.TenVL.Trim() == TenVL.Trim());
                if (Return != null)
                    return Return;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
