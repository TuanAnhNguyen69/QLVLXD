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
using QLVLXD.BLL;
using QLVLXD.DLL;

namespace QLVLXD.BLL
{
    class BLL_CTHoaDonBanHang : BLL
    {
        public BLLResult CheckData(bool IsInsert, string MaCTHDBH, string MaHDBH, string TenVL, decimal SoLuongMua, string DonviTinh, decimal TongTien, string TinhTrangVL, string TenNCC, decimal SoLuongKM, decimal TongSL, decimal GiaLe, decimal GiaSi, decimal SoLuongBanSi, decimal TienKM, decimal TienKMKH, string GhiChu)
        {
            try
            {
                if (IsInsert && GetObjectFromID(MaCTHDBH) != null)
                {
                    return new BLLResult("Mã chi tiết hóa đơn đã tồn tại");
                }

                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(0);
            }
        }

        public BLLResult CheckData(bool IsInsert, CTHoaDonBanHang CT)
        {
            try
            {
                if (IsInsert && GetObjectFromID(CT.MaCTHDBH.Trim()) != null)
                {
                    return new BLLResult("Mã chi tiết hóa đơn đã tồn tại");
                }

                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(0);
            }
        }

        public BLLResult Insert(string MaCTHDBH, string MaHDBH, string MaVL, decimal SoLuongMua, string DonviTinh, decimal TongTien, string TinhTrangVL, string TenNCC, decimal SoLuongKM, decimal TongSL, decimal GiaLe, decimal GiaSi, decimal SoLuongBanSi, decimal TienKM, decimal TienKMKH, string GhiChu)
        {
            try
            {
                QLVLXD.DLL.CTHoaDonBanHang ct = new QLVLXD.DLL.CTHoaDonBanHang();
                ct.MaVL = MaVL;
                ct.MaCTHDBH = MaCTHDBH;
                ct.MaHDBH = MaHDBH;
                ct.GhiChu = GhiChu;
                ct.SoLuong = TongSL;
                DB.CTHoaDonBanHangs.InsertOnSubmit(ct);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public BLLResult Insert(DLL.CTHoaDonBanHang ct)
        {
            try
            {
                DB.CTHoaDonBanHangs.InsertOnSubmit(ct);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public BLLResult Delete(string MaCTHDBH, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaCTHDBH);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa chi tiết hóa đơn \"" + row.MaVL.Trim() + "\" ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }
                    DB.CTHoaDonBanHangs.DeleteOnSubmit(row);
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

        public BLLResult Update(string MaCTHDBH, string MaHDBH, string TenVL, decimal SoLuongMua, string DonviTinh, decimal TongTien, string TinhTrangVL, string TenNCC, decimal SoLuongKM, decimal TongSL, decimal GiaLe, decimal GiaSi, decimal SoLuongBanSi, decimal TienKM, decimal TienKMKH, string GhiChu)
        {
            try
            {
                var old_data = GetObjectFromID(MaCTHDBH);
                old_data.MaVL = TenVL;
                old_data.MaHDBH = MaHDBH;
                old_data.GhiChu = GhiChu;
                old_data.SoLuong = TongSL;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public string NewMaCTHDBH()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                    danhsach.Add(var.MaCTHDBH.Trim());
                return NewID(danhsach, "CTHDBH");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string NewMaCTHDBH(List<CTHoaDonBanHang> ListOtherCTHDBH)
        {
            try
            {
                List<string> danhsach = new List<string>();
                List<CTHoaDonBanHang> listhd = new List<CTHoaDonBanHang>(ListOtherCTHDBH);
                listhd.AddRange(GetListAll());
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in listhd)
                    danhsach.Add(var.MaCTHDBH.Trim());
                return NewID(danhsach, "CTHDBH");
            }
            catch (Exception)
            {
                return null;
            }
        }


        public List<QLVLXD.DLL.CTHoaDonBanHang> GetList()
        {
            try
            {
                List<QLVLXD.DLL.CTHoaDonBanHang> list = new List<DLL.CTHoaDonBanHang>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                        list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.CTHoaDonBanHang> GetListAll()
        {
            try
            {
                List<QLVLXD.DLL.CTHoaDonBanHang> list = new List<DLL.CTHoaDonBanHang>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                    list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public QLVLXD.DLL.CTHoaDonBanHang GetObjectFromID(string MaCTHDBH)
        {
            try
            {
                var var = DB.CTHoaDonBanHangs.FirstOrDefault(data => data.MaCTHDBH.Trim() == MaCTHDBH.Trim());
                if (var != null)
                    return var;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.CTHoaDonBanHang> GetListFromHDBH(string MaHDBH)
        {
            try
            {
                List<QLVLXD.DLL.CTHoaDonBanHang> list = new List<DLL.CTHoaDonBanHang>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                    if (var.MaHDBH.Trim() == MaHDBH.Trim())
                        list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int GetTongTienHDBH(string MaHDBH)
        {
            try
            {
                var ds = GetListFromHDBH(MaHDBH);
                int TongTien = 0;
                foreach (DLL.CTHoaDonBanHang var in ds)
                {
                    var vatlieu = (new BLL_VatLieu()).GetObjectFromID(var.MaVL);
                    TongTien += (int)(var.SoLuong * vatlieu.GiaBan.Value);
                }
                return TongTien;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
