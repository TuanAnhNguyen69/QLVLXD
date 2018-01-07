using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVLXD.DLL;
using System.Windows.Forms;

namespace QLVLXD.BLL
{
    class BLL_LoaiKhachHang : BLL
    {
        public List<QLVLXD.DLL.LoaiKhachHang> GetList()
        {
            try
            {
                List<QLVLXD.DLL.LoaiKhachHang> list = new List<DLL.LoaiKhachHang>();
                foreach (QLVLXD.DLL.LoaiKhachHang var in DB.LoaiKhachHangs)
                        list.Add(var);

                return list;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.LoaiKhachHang GetObjectFromTenLoaiKH(string TenLoaiKH)
        {
            try
            {
                if (TenLoaiKH == null || TenLoaiKH == "")
                    return null;

                var list = GetList();
                foreach (DLL.LoaiKhachHang vari in list)
                    if (vari.TenLoaiKH.Trim() == TenLoaiKH.Trim())
                        return vari;
                return null;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.LoaiKhachHang GetObjectFromID(string MaLKH)
        {
            try
            {
                var Return = DB.LoaiKhachHangs.FirstOrDefault(data => data.MaLoaiKH.Trim() == MaLKH.Trim());
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
        public bool CheckData(string TenLoaiKH)
        {
            var list = GetList();
            foreach (DLL.LoaiKhachHang vari in list)
                if (vari.TenLoaiKH.Trim() == TenLoaiKH.Trim())
                    return false;
                 
            return true;
        }

        public BLLResult Insert(string TenLoai, decimal MocTieuThu, decimal PhanTramGiam)
        {
            try
            {
                if (!CheckData(TenLoai))
                    return new BLLResult("Đã tồn tại loại khách hàng này!");

                QLVLXD.DLL.LoaiKhachHang loai = new QLVLXD.DLL.LoaiKhachHang();
                loai.TenLoaiKH = TenLoai.Trim();
                loai.MaLoaiKH = NewMaLoaiKH();
                loai.PhanTramGiam = PhanTramGiam;
                loai.MocTieuThu = MocTieuThu;

                DB.LoaiKhachHangs.InsertOnSubmit(loai);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(14000852);
            }
        }

        //public BLLResult Insert(string TenLoai, decimal SoLanMuaToiThieu, decimal TriGiaMoiLanMua, decimal PhanTramGiamLanMuaCuoi)
        //{
        //    try
        //    {
        //        if (!CheckData(TenLoai)
        //            return new BLLResult("Đã tồn tại loại khách hàng này!");

        //        QLVLXD.DLL.LoaiKhachHang loai = new QLVLXD.DLL.LoaiKhachHang();
        //        loai.TenLoaiKH = TenLoai.Trim();
        //        loai.MaLoaiKH = NewMaLoaiKH();
        //        loai.PhanTramGiam = null;
        //        loai.TriGiaHoaDonToiThieu = null;
        //        loai.SoLanMuaToiThieu = SoLanMuaToiThieu;
        //        loai.PhanTramGiamLanMuaCuoi = PhanTramGiamLanMuaCuoi;
        //        loai.TriGiaToiThieuMoiLanMua = TriGiaMoiLanMua;
        //        loai.Live = "True";

        //        DB.LoaiKhachHangs.InsertOnSubmit(loai);
        //        DB.SubmitChanges();
        //        return new BLLResult((int)BLLResultType.S_ADD);
        //    }
        //    catch
        //    {
        //        return new BLLResult(14000852);
        //    }
        //}

        //public List<QLVLXD.DLL.LoaiKhachHang> GetDanhSachLoaiKhachHang(string MaLoaiKH)
        //{
        //    try
        //    {
        //        List<QLVLXD.DLL.LoaiKhachHang> list = new List<QLVLXD.DLL.LoaiKhachHang>();
        //        foreach (QLVLXD.DLL.LoaiKhachHang var in DB.LoaiKhachHangs)
        //            if (var.MaLoaiKH.Trim() == MaLoaiKH.Trim())
        //                list.Add(var);

        //        return list;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        public decimal GetKhuyenMai(string MaLoaiKH)
        {
            try
            {
                var loai = GetObjectFromID(MaLoaiKH);
                if (loai != null)
                {
                    return loai.PhanTramGiam.Value;
                }
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public BLLResult Delete(string MaLoaiKH, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaLoaiKH);
                if (row != null)
                {
                    if (row.TenLoaiKH.Trim() == "Thường")
                    {
                        return new BLLResult("Đây là loại khách hàng mặc định, không được xóa!");
                    }
                    {// Kiểm tra loại KH này có sử dụng hay không
                        var list = (new BLL_KhachHang()).GetList();
                        foreach (DLL.KhachHang vari in list)
                            if (vari.MaLoaiKH.Trim() == MaLoaiKH)
                                return new BLLResult("Có khách hàng thuộc loại khách hàng này, không xóa được!");
                    }
                    var listkh = (new BLL_KhachHang()).GetList();
                    foreach (DLL.KhachHang vari in listkh)
                    {
                        if (vari.MaLoaiKH.Trim() == MaLoaiKH)
                            return new BLLResult("Vui lòng cập nhật khách hàng có có loại khách hàng này trước khi xóa!");
                    }

                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa loại khách hàng \"" + row.TenLoaiKH.Trim() + "\" ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }

                    DB.LoaiKhachHangs.DeleteOnSubmit(row);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_DELETE);
                }
                return new BLLResult((int)BLLResultType.NOT_EXIST);
            }
            catch
            {
                return new BLLResult(140008521);
            }
        }

        public string NewMaLoaiKH()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.LoaiKhachHang var in DB.LoaiKhachHangs)
                    danhsach.Add(var.MaLoaiKH.Trim());
                return NewID(danhsach, "MaLoaiKH");
            }
            catch
            {
                return null;
            }
        }
    }
}
