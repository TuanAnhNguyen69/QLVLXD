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

namespace QLVLXD.GUI.NghiepVu
{
    public partial class DonViTinh : DevExpress.XtraEditors.XtraForm
    {
        BLL_DonViTinhVatLieu _DVT = new BLL_DonViTinhVatLieu();
        public Main_Form mainform;
        public bool IsReset;
        string maDVT;

        public DonViTinh()
        {
            InitializeComponent();
            UpdateGridDVT();
        }

        private void TienTeDonViTinhLoaiVatLieu_Load(object sender, EventArgs e)
        {

        }

        void UpdateGridDVT()
        {
            try
            {
                for (; grid_DVT.Rows.Count > 0;) // Xóa hết dòng
                    grid_DVT.Rows.RemoveAt(0);
            }
            catch
            { }
            try
            {
                var listDV = _DVT.GetList();
                foreach (DLL.DonViTinhVatLieu vari in listDV)
                {
                    grid_DVT.Rows.Add(vari.MaDVT, vari.DVT);
                }
            }
            catch (Exception)
            { }
        }



        private void btn_ThemDVT_Click(object sender, EventArgs e)
        {
            if (tb_DonViTinh.Text == "")
            {
                _DVT.MakeMessageBox(new BLLResult("Vui lòng nhập đơn vị tính mới!"));
                return;
            }

          
            BLLResult res = _DVT.Insert(tb_DonViTinh.Text.Trim());
            _DVT.MakeMessageBox(res);
            if (res._Code == (int)BLLResultType.S_ADD)
            {
                UpdateGridDVT();
                try { mainform.frm_vatlieu.IsReset = true; } catch { }
            }
        }

        private void btn_XoaDVT_Click(object sender, EventArgs e)
        {
            try
            {
                BLLResult res = _DVT.Delete(maDVT, false);
                _DVT.MakeMessageBox(res);
                if (res._Code == (int)BLLResultType.S_DELETE)
                {
                    UpdateGridDVT();
                    try { mainform.frm_vatlieu.IsReset = true; } catch { }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_DVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maDVT = grid_DVT.Rows[e.RowIndex].Cells["MaDV"].Value.ToString().Trim();
            tb_DonViTinh.Text = grid_DVT.Rows[e.RowIndex].Cells["DVT"].Value.ToString().Trim();
        }
    }
}