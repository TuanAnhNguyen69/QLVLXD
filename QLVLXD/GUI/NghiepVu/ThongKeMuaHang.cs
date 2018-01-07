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
using QLVLXD.DLL;

namespace QLVLXD.GUI.NghiepVu
{
    public partial class ThongKeMuaHang : DevExpress.XtraEditors.XtraForm
    {
        List<DLL.HoaDonMuaHang> _Orginal = new List<DLL.HoaDonMuaHang>();
        List<DLL.HoaDonMuaHang> _Filter = new List<DLL.HoaDonMuaHang>();
        public Main_Form mainform;
        BLL_CTHoaDonMuaHang _CTHDMH = new BLL_CTHoaDonMuaHang();
        public bool IsReset;

        public ThongKeMuaHang()
        {
            InitializeComponent();

            
        }

       
    }
}