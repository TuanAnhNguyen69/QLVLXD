using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVLXD.DLL;
using System.Windows.Forms;

namespace QLVLXD.BLL
{
    class BLL_DonViTinhVatLieu : BLL
    {      
        public List<QLVLXD.DLL.DonViTinhVatLieu> GetList()
        {
            try 
            {
                List<QLVLXD.DLL.DonViTinhVatLieu> list = new List<DLL.DonViTinhVatLieu>();
                foreach (QLVLXD.DLL.DonViTinhVatLieu var in DB.DonViTinhVatLieus)
                        list.Add(var);
        
                return list;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.DonViTinhVatLieu GetObjectFromID(string MaDVTVL)
        {
            try
            {  
                var Return = DB.DonViTinhVatLieus.FirstOrDefault(data => data.MaDVT.Trim() == MaDVTVL.Trim());      
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

        public QLVLXD.DLL.DonViTinhVatLieu GetDonViTinhTuTen(string DVT)
        {
            try
            {
                var Return = DB.DonViTinhVatLieus.FirstOrDefault(data => data.DVT.Trim() == DVT.Trim());
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

        public bool ExistDonViTinh(string TenDVT)
        {
            try
            {
                string MaDVT =  GetDonViTinhTuTen(TenDVT.Trim()).MaDVT;

                List<QLVLXD.DLL.DonViTinhVatLieu> listdvt = GetList();
                foreach (QLVLXD.DLL.DonViTinhVatLieu var in listdvt)
                    if (var.MaDVT.Trim() == MaDVT.Trim())
                    {
                        return true;
                    }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string NewMaDVTTT()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.DonViTinhVatLieu var in DB.DonViTinhVatLieus)
                    danhsach.Add(var.MaDVT.Trim());
                return NewID(danhsach, "DVTVL");
            }
            catch
            {
                return null;
            }
        }

        public BLLResult Insert(string DVT, string MaDVT)
        {
            try
            {
                if (ExistDonViTinh(DVT.Trim())) // Đã tồn tại
                    return new BLLResult("Đơn vị tính đã tồn tại!");
                else // K tồn tại thì thêm vào
                {
                    DonViTinhVatLieu dvt = new DonViTinhVatLieu();
                    dvt.DVT = NewMaDVTTT();
                    dvt.MaDVT = MaDVT;
                    DB.DonViTinhVatLieus.InsertOnSubmit(dvt);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_ADD);
                }
            }
            catch (Exception)
            {
                return new BLLResult(9000521);
            }
        }

        //public BLLResult Insert(string MaVL, string TenDVT1, decimal TiLe1, string TenDVT2, decimal TiLe2)
        //{
        //    try
        //    {
        //        BLLResult res;
        //        if (TenDVT1.Length > 1)
        //        {
        //            res = Insert(MaVL, TenDVT1, TiLe1);
        //            if (res._Code != (int)BLLResultType.S_ADD)
        //                return new BLLResult("Lỗi thêm đơn vị tính 2");
        //        }

        //        if (TenDVT2.Length > 1)
        //        {
        //            res = Insert(MaVL, TenDVT2, TiLe2);
        //            if (res._Code != (int)BLLResultType.S_ADD)
        //                return new BLLResult("Lỗi thêm đơn vị tính 3");
        //        }

        //        return new BLLResult((int)BLLResultType.S_ADD);
        //    }
        //    catch (Exception)
        //    {
        //        return new BLLResult(9000456);
        //    }
        //}

        public BLLResult Update(string MaDVT, string TenDVT)
        {
            try
            {
                List<DonViTinhVatLieu> listdvt = GetList();
                BLLResult res = new BLLResult((int)BLLResultType.S_ADD);
                var dvt = GetObjectFromID(MaDVT);
                if (dvt == null)
                    throw new Exception();

                if (dvt.DVT.Trim() != TenDVT)
                {
                    dvt.DVT = TenDVT;
                    //DB.SubmitChanges();
                }

                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch (Exception)
            {
                return new BLLResult(9000456);
            }
        }

        //public QLVLXD.DLL.DonViTinhVatLieu GetObject(string MaVL, string TenDVT)
        //{
        //    try
        //    {
        //        string MaDVT = _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT);

        //        foreach (QLVLXD.DLL.DonViTinhVatLieu var in DB.DonViTinhVatLieus)
        //            if (VarLive(var.Live) && var.MaVL.Trim() == MaVL.Trim() && var.MaDVT.Trim() == MaDVT.Trim())
        //                return var;

        //        return null;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        public BLLResult Delete(string MaDVt, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaDVt);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa đơn vị tính này?", "Chú ý", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_DELETE);
                }
                return new BLLResult((int)BLLResultType.NOT_EXIST);
            }
            catch
            {
                return new BLLResult(9000587);
            }
        }
    }
}
