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
using QLVLXD.BLL;

namespace QLVLXD.BLL
{
    class BLL_HoaDonBanHang : BLL
    {
        BLL_CTHoaDonBanHang _BLL_CTHoaDonBanHang = new BLL_CTHoaDonBanHang();
        BLL_KhachHang _BLL_KhachHang = new BLL_KhachHang();
        BLL_LoaiKhachHang _LoaiKhachHang = new BLL_LoaiKhachHang();

        public BLLResult CheckData(bool IsInsert, string MaHDBH)
        {
            if (IsInsert && GetObjectFromID(MaHDBH) != null)
            {
                return new BLLResult("Mã hóa đơn bán hàng đã tồn tại");
            }

            return new BLLResult((int)BLLResultType.SUCCESS);
        }

        public BLLResult Insert(string MaHDBH, DateTime NgayGiao, string MaNV, string MaKH, DateTime NgayLap, decimal TongTien, decimal KhuyenMai, string TrangThai)
        {
            try
            {
                QLVLXD.DLL.HoaDonBanHang hdbh = new QLVLXD.DLL.HoaDonBanHang();
                hdbh.MaHDBH = MaHDBH;
                hdbh.NgayLap = NgayGiao;
                hdbh.MaNV = MaNV;
                hdbh.MaKH = MaKH;
                hdbh.NgayLap = NgayLap;
                hdbh.TrangThai = TrangThai;
                hdbh.TienKM = KhuyenMai;
                hdbh.TongTien = TongTien;
                DB.HoaDonBanHangs.InsertOnSubmit(hdbh);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public BLLResult Update(string MaHDBH, DateTime NgayGiao, string MaNV, string MaKH, DateTime NgayLap, string GhiChu, string TrangThai)
        {
            try
            {
                var old_data = GetObjectFromID(MaHDBH);
                old_data.NgayLap = NgayGiao;
                old_data.MaNV = MaNV;
                old_data.MaKH = MaKH;
                old_data.NgayLap = NgayLap;
                old_data.TrangThai = TrangThai;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch
            {
                return new BLLResult(0);
            }
        }

        public BLLResult Delete(string MaHDBH, bool IsSure)
        {
            try
            {
                MaHDBH = MaHDBH.Trim();
                var row = GetObjectFromID(MaHDBH);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa hóa đơn này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }
                    {// Phần xóa các CT
                        var listct = (new BLL_CTHoaDonBanHang()).GetListFromHDBH(MaHDBH);
                        foreach (CTHoaDonBanHang vari in listct)
                            (new BLL_CTHoaDonBanHang()).Delete(vari.MaCTHDBH.Trim(), true);
                    }
                    DB.HoaDonBanHangs.DeleteOnSubmit(row);
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

      
        public BLLResult SetTrangThai(string TenTrangThai, string MaHDBH)
        {
            try
            {
                var hd = GetObjectFromID(MaHDBH.Trim());
                if (hd == null)
                    throw new Exception();
                hd.TrangThai = TenTrangThai;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(0);
            }
        }

        public string NewMaHDBH()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.HoaDonBanHang var in DB.HoaDonBanHangs)
                    danhsach.Add(var.MaHDBH.Trim());
                return NewID(danhsach, "HDBH");
            }
            catch (Exception)
            {

                return null;
            }
        }

    

        public string GetHanGiao()
        {
            try
            {
                string name = "";
                var list = GetList();
                foreach (DLL.HoaDonBanHang vari in list)
                    if (vari.TrangThai.Trim() == "Chưa Giao" && vari.NgayLap.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
                        name = name + (new BLL_KhachHang()).GetObjectFromID(vari.MaKH.Trim()).TenKH.Trim() + ", ";
                if (name == "")
                    return null;
                else
                {
                    name = name.Substring(0, name.Length - 2);
                    return "Hôm nay là ngày giao hàng của các khách hàng:" + name + " (Nhấp vào để thiết lập trạng thái cho các hóa đơn này)";
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.HoaDonBanHang> GetList()
        {
            try
            {
                List<QLVLXD.DLL.HoaDonBanHang> list = new List<DLL.HoaDonBanHang>();
                foreach (QLVLXD.DLL.HoaDonBanHang var in DB.HoaDonBanHangs)
                        list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.HoaDonBanHang> GetListAll()
        {
            try
            {
                List<QLVLXD.DLL.HoaDonBanHang> list = new List<DLL.HoaDonBanHang>();
                foreach (QLVLXD.DLL.HoaDonBanHang var in DB.HoaDonBanHangs)
                    list.Add(var);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public QLVLXD.DLL.HoaDonBanHang GetObjectFromID(string MaHDBH)
        {
            try
            {
                var Return = DB.HoaDonBanHangs.FirstOrDefault(data => data.MaHDBH.Trim() == MaHDBH.Trim());
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
