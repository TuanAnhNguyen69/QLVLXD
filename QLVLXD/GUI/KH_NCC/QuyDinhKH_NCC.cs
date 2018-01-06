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

namespace QLVLXD.GUI.KH_NCC
{
    public partial class QuyDinhKH_NCC : DevExpress.XtraEditors.XtraForm
    {
        BLL_LoaiKhachHang _LoaiKhachHang = new BLL_LoaiKhachHang();
        public Main_Form mainform;

        public QuyDinhKH_NCC()
        {
            InitializeComponent();

            ResetGrid();
            Reset();
        }

        void ResetGrid()
        {
            grid.DataSource = null;
            grid.DataSource = _LoaiKhachHang.GetList();
        }

        void Reset()
        {
            ResetGrid();
           // r_TriGia.Checked = true;
            //num_PhanGiamGiamLanMuaCuoi.Value = 0;
            //num_SoLanMuaToiThieu.Value = 0;
            //num_TriGiaHoaDonToiThieuMoiLanMua.Value = 0;
            num_PhanTramGiam.Value = 0;
            num_TriGiaHoaDonToiThieu.Value = 0;
        }

        private void QuyDinhKH_NCC_Load(object sender, EventArgs e)
        {
        }

        private void r_SoLanMua_CheckedChanged(object sender, EventArgs e)
        {
            num_PhanTramGiam.Enabled = false;
            num_TriGiaHoaDonToiThieu.Enabled = false;
            //num_PhanGiamGiamLanMuaCuoi.Enabled = true;
           // num_SoLanMuaToiThieu.Enabled = true;
           // num_TriGiaHoaDonToiThieuMoiLanMua.Enabled = true;
        }

        private void r_TriGia_CheckedChanged(object sender, EventArgs e)
        {
          //  num_PhanGiamGiamLanMuaCuoi.Enabled = false;
           // num_SoLanMuaToiThieu.Enabled = false;
           // num_TriGiaHoaDonToiThieuMoiLanMua.Enabled = false;
            num_PhanTramGiam.Enabled = true;
            num_TriGiaHoaDonToiThieu.Enabled = true;
        }

        // [Thêm]
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_TenLoaiKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BLLResult res = new BLLResult();
            /*if (r_SoLanMua.Checked) // Km dựa trên số lượng8
            {
                if (num_SoLanMuaToiThieu.Value == 0)
                {
                    MessageBox.Show("Số lần mua tối thiểu phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (num_TriGiaHoaDonToiThieuMoiLanMua.Value < 1000)
                {
                    MessageBox.Show("Trị giá hóa đơn mỗi lần mua phải từ 1000 VNĐ trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (num_PhanGiamGiamLanMuaCuoi.Value == 0)
                {
                    MessageBox.Show("Phần trăm giảm lần mua cuối phải lớn hơn 0%!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                res = _LoaiKhachHang.Insert(tb_TenLoaiKH.Text.Trim(), num_SoLanMuaToiThieu.Value, num_TriGiaHoaDonToiThieuMoiLanMua.Value, num_PhanGiamGiamLanMuaCuoi.Value);
                _LoaiKhachHang.MakeMessageBox(res);
                if (res._Code == (int)BLLResultType.S_ADD)
                     try {mainform.frm_khachhang.IsReset = true; } catch {}
            }*/
         
                if (num_TriGiaHoaDonToiThieu.Value < 1000)
                {
                    MessageBox.Show("Trị giá hóa đơn tối thiếu phải từ 1000 VNĐ trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (num_PhanTramGiam.Value == 0)
                {
                    MessageBox.Show("Phần trăm giảm phải lớn hơn 0%!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                res = _LoaiKhachHang.Insert(tb_TenLoaiKH.Text.Trim(), num_TriGiaHoaDonToiThieu.Value, num_PhanTramGiam.Value);
                _LoaiKhachHang.MakeMessageBox(res);
                if (res._Code == (int)BLLResultType.S_ADD)
                     try {mainform.frm_khachhang.IsReset = true; } catch {}
            
            Reset();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selectedindex = gridView1.GetSelectedRows();
                var loai = gridView1.GetRow(selectedindex[0]);
                BLLResult res = _LoaiKhachHang.Delete(((DLL.LoaiKhachHang)loai).MaLoaiKH.ToString().Trim(), false);
                _LoaiKhachHang.MakeMessageBox(res);
                if (res._Code == (int)BLLResultType.S_DELETE)
                {
                    try { try {mainform.frm_khachhang.IsReset = true; } catch {} } catch {}
                    Reset();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}