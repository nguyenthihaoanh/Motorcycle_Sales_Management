using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Controller
{
    public class TTNhanVienController
    {
        private NhanVienController nhanVienController = new NhanVienController();
        public List<ListViewItem> thongtin { get; private set; } = new List<ListViewItem>();
        public List<ListViewItem> NhanTT()
        {
            return thongtin = nhanVienController.Lay_TTNV_Tu_Data(DangNhapController.maNV);
        }
    }
}
