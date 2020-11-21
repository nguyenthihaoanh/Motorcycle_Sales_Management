using QuanLyCuaHangXeMay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Controller
{
    public class NCC_Controller
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private List<ListViewItem> dsNCC = new List<ListViewItem>();
        private ListViewItem lvit;
        // Thêm thông tin 1 ncc vào listviewitem
        public ListViewItem them_ncc_lv( NhaCungCap nhaCungCap)
        {
            lvit = new ListViewItem();
            var ncc = from NCC in db.NhaCungCaps
                      select NCC;
            lvit.Text = nhaCungCap.maNCC.ToString();
            lvit.SubItems.Add(nhaCungCap.tenNCC);
            lvit.SubItems.Add(nhaCungCap.diaChiNCC);
            lvit.SubItems.Add(nhaCungCap.email);
            return lvit;
        }
        //Lay danh sach tat ca nhan vien
        public List<ListViewItem> danhSachNCC()
        {
            dsNCC.Clear();
            var ncc = from NCC in db.NhaCungCaps
                      select NCC;
            foreach (NhaCungCap n in ncc)
                dsNCC.Add(them_ncc_lv(n));
            return dsNCC;
        }
    }
}
