using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLVLXD.BLL;

namespace QLVLXD
{
    public partial class VatLieu : Form
    {
        BLL_NhaCungCap _BLL_NhaCungCap = new BLL_NhaCungCap();
        BLL_VatLieu _BLL_VatLieu = new BLL_VatLieu();
        BLL_DonViTinhVatLieu _DonViTinhVatLieu = new BLL_DonViTinhVatLieu();

        public Main_Form mainform;
        public bool IsReset;

        bool IsAddNew;

        DLL.VatLieu _VatLieuGridViewSelected = new DLL.VatLieu();

        public VatLieu()
        {
            InitializeComponent();
            LoadDataToForm();
            ResetForNewInsert();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        void LoadGridView()
        {
            var listvl = _BLL_VatLieu.GetList();

            for (; grid_VatLieu.Rows.Count > 0;) 
                grid_VatLieu.Rows.RemoveAt(0);

            foreach (DLL.VatLieu var in listvl)
            {
                var DVT = _DonViTinhVatLieu.GetObjectFromID(var.MaDVT);
                var NCC = _BLL_NhaCungCap.GetObjectFromID(var.MaNCC.Trim());
                grid_VatLieu.Rows.Add(var.MaVL.Trim(), var.TenVL.Trim(), NCC.TenNCC.Trim(), var.SoLuong, DVT.DVT.Trim(), var.GiaMua, var.GiaBan, var.GhiChu);
            }
        }

        private void VatLieu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            if (!IsAddNew || !CheckInput())
                return;

            BLLResult result;

          
            string GhiChu = tb_GhiChu.Text;
            if (GhiChu == null || GhiChu == "")
                GhiChu = "<Không có ghi chú>";
          

            result = _BLL_VatLieu.CheckData(true, lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, cb_DonViTinh.Text.Trim(), num_GiaMua.Value, num_GiaBan.Value, GhiChu);

            if (result._Code == 111)
            {
                _BLL_VatLieu.MakeMessageBox(result);
                return;
            }

            var DVT = _DonViTinhVatLieu.GetDonViTinhTuTen(cb_DonViTinh.Text.Trim());
            result = _BLL_VatLieu.Insert(lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, DVT.MaDVT.Trim(), Decimal.Round(num_GiaMua.Value, 0), Decimal.Round(num_GiaBan.Value), GhiChu);
            _BLL_VatLieu.MakeMessageBox(result);

            if (result._Code == (int)BLLResultType.S_ADD) 
            {
                ResetForNewInsert();
                LoadGridView();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_muahang.IsReset = true; } catch {}
            }
        }

        void LoadDataToForm()
        {
            List<DLL.DonViTinhVatLieu> listdvt = _DonViTinhVatLieu.GetList();
            foreach(DLL.DonViTinhVatLieu var in listdvt)
            {
                cb_DonViTinh.Items.Add(var.DVT.Trim());
            }

            List<string> listtenncc = new List<string>();
            List<DLL.NhaCungCap> listncc = _BLL_NhaCungCap.GetList();
            foreach (DLL.NhaCungCap mem in listncc)
            {
                cb_TenNhaCungCap.Items.Add(mem.TenNCC.Trim());
            }

            LoadGridView();
        }

        void ResetForNewInsert()
        {
            tb_TenVatLieu.Text = "";
            lb_MaVatLieu.Text = _BLL_VatLieu.NewMaVL();
            tb_GhiChu.Text = "<Không có ghi chú>";
           
            cb_DonViTinh.SelectedIndex = 0;

            num_GiaMua.Value = 0;
            num_GiaBan.Value = 0;
            num_SoLuong.Value = (new BLL_CTHoaDonBanHang()).ReadConfig()._SoLuongToiThieu;

            num_SoLuong.Value = 1;

            IsAddNew = true;
            btn_Them.Visible = true;
            btn_CapNhat.Visible = false;
            btn_Xoa.Visible = false;
            lb_MaVatLieu.ForeColor = Color.Green;
        }

        private bool CheckInput()
        {
            #region Phần tên vật liệu
            if (tb_TenVatLieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên vật liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_BLL_VatLieu.CheckNotInComboBox(cb_TenNhaCungCap))
            {
                MessageBox.Show("Vui lòng chọn tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
   
            if (tb_GhiChu.Text.Length >= 99)
            {
                MessageBox.Show("Vui lòng viết Ghi chú ít hơn 100 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            #endregion

            if (_BLL_VatLieu.CheckNotInComboBox(cb_DonViTinh))
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
          

            return true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetForNewInsert();
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (IsAddNew)
                return;

            BLLResult result = _BLL_VatLieu.Delete(lb_MaVatLieu.Text.Trim(), false);

            if (result._Code != (int)BLLResultType.NOT_DELETE)
                _BLL_NhaCungCap.MakeMessageBox(result);

            if (result._Code == (int)BLLResultType.S_DELETE)
            {
                LoadGridView();
                ResetForNewInsert();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_muahang.IsReset = true; } catch {}
            }
        }


        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (IsAddNew || !CheckInput())
                return;

            BLLResult result;

            #region Chuẩn bị data để insert
         
            string GhiChu = tb_GhiChu.Text;
            if (GhiChu == null || GhiChu == "")
                GhiChu = "<Không có ghi chú>";
            #endregion

            result = _BLL_VatLieu.CheckData(false, lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, cb_DonViTinh.Text.Trim(), num_GiaMua.Value, num_GiaBan.Value, GhiChu);

            if (result._Code == 111)
            {
                _BLL_VatLieu.MakeMessageBox(result);
                return;
            }


            result = _BLL_VatLieu.Update(lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, _DonViTinhVatLieu.GetDonViTinhTuTen(cb_DonViTinh.Text).MaDVT, num_GiaMua.Value, num_GiaBan.Value, GhiChu);

            if (result._Code == (int)BLLResultType.S_UPDATE)
            {
                ResetForNewInsert();
                LoadGridView();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_muahang.IsReset = true; } catch {}
                try { mainform.frm_thongkebanhang.IsReset = true; } catch { }
            }
        }

        private void cb_TenNhaCungCap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DLL.NhaCungCap data = _BLL_NhaCungCap.GetObjectFromTenNhaCungCap(cb_TenNhaCungCap.Text.Trim());
            if (data != null)
            {
                lb_MaNhaCungCap.Text = data.MaNCC.Trim();
            }
        }


      

        private void grid_VatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsAddNew)
                ResetForNewInsert();
            int rowindex = grid_VatLieu.SelectedCells[0].RowIndex;
            grid_VatLieu.Rows[rowindex].Selected = true;

            #region Load vào biến _VatLieuGridViewSelected
            _VatLieuGridViewSelected.MaVL = grid_VatLieu.Rows[rowindex].Cells[0].Value.ToString().Trim();
            _VatLieuGridViewSelected.TenVL = grid_VatLieu.Rows[rowindex].Cells[1].Value.ToString().Trim();
            _VatLieuGridViewSelected.MaNCC = _BLL_NhaCungCap.GetObjectFromTenNhaCungCap(grid_VatLieu.Rows[rowindex].Cells[2].Value.ToString().Trim()).MaNCC;
            _VatLieuGridViewSelected.SoLuong = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[3].Value.ToString().Trim());
            _VatLieuGridViewSelected.MaDVT = _DonViTinhVatLieu.GetDonViTinhTuTen(grid_VatLieu.Rows[rowindex].Cells[4].Value.ToString().Trim()).MaDVT;
            _VatLieuGridViewSelected.GiaMua = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[5].Value.ToString().Trim());
            _VatLieuGridViewSelected.GiaBan = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[6].Value.ToString().Trim());


            {
                var tmp = grid_VatLieu.Rows[rowindex].Cells[7].Value;
                string ghichu = tmp == null ? "" : tmp.ToString().Trim();
                _VatLieuGridViewSelected.GhiChu = ghichu;
            }
            #endregion

            #region Load thông tin lên form
            IsAddNew = false;
            btn_Them.Visible = false;
            btn_CapNhat.Visible = true;
            btn_Xoa.Visible = true;
            lb_MaVatLieu.ForeColor = Color.Red;

            tb_TenVatLieu.Text = _VatLieuGridViewSelected.TenVL.Trim();
            lb_MaVatLieu.Text = _VatLieuGridViewSelected.MaVL.Trim();
            cb_TenNhaCungCap.Text = _BLL_NhaCungCap.GetTenNCCFromMaNCC(_VatLieuGridViewSelected.MaNCC.Trim());
            lb_MaNhaCungCap.Text = _VatLieuGridViewSelected.MaNCC.Trim();
            tb_GhiChu.Text = _VatLieuGridViewSelected.GhiChu;

            num_GiaMua.Value = (decimal)_VatLieuGridViewSelected.GiaMua;
            num_GiaBan.Value = (decimal)_VatLieuGridViewSelected.GiaBan;

            cb_DonViTinh.Text = _DonViTinhVatLieu.GetObjectFromID(_VatLieuGridViewSelected.MaDVT).DVT.Trim();

            num_SoLuong.Value = (decimal)_VatLieuGridViewSelected.SoLuong;
            #endregion

        }

        private void VatLieu_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.VATLIEU));
                    IsReset = false;
                }
        }
    }
}
