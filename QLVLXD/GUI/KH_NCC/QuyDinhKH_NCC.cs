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
        string maLoaiKH;

        public QuyDinhKH_NCC()
        {
            InitializeComponent();

            ResetGrid();
            Reset();
        }

        void ResetGrid()
        {
            try
            {
                for (; grid_loaiKH.Rows.Count > 0;) 
                    grid_loaiKH.Rows.RemoveAt(0);
            }
            catch
            { }

            var listLoai = _LoaiKhachHang.GetList();
            foreach (DLL.LoaiKhachHang var in listLoai)
            {
                grid_loaiKH.Rows.Add(var.MaLoaiKH, var.TenLoaiKH, var.MocTieuThu, var.PhanTramGiam);
            }
        }

        void Reset()
        {
            ResetGrid();
            num_PhanTramGiam.Value = 0;
            num_TriGiaHoaDonToiThieu.Value = 0;
        }

        private void QuyDinhKH_NCC_Load(object sender, EventArgs e)
        {
        }

    

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_TenLoaiKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BLLResult res = new BLLResult();
         
                if (num_TriGiaHoaDonToiThieu.Value < 1000)
                {
                    MessageBox.Show("Mốc tối thiếu phải từ 1000000 VNĐ trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                BLLResult res = _LoaiKhachHang.Delete(maLoaiKH, false);
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

        private void grid_loaiKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maLoaiKH = grid_loaiKH.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString().Trim();

        }
    }
}