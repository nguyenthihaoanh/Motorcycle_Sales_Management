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
        //them ncc vao database
        public NhaCungCap themTTNCC(ListViewItem lvi_ncc)
        {
            NhaCungCap n = new NhaCungCap();
            n.maNCC = lvi_ncc.Text.ToString();
            n.tenNCC = lvi_ncc.SubItems[1].Text;
            n.diaChiNCC = lvi_ncc.SubItems[2].Text;
            n.email = lvi_ncc.SubItems[3].Text;
            return n;
        }
        public void them(ListViewItem lvi_ncc)
        {
            db.NhaCungCaps.InsertOnSubmit(themTTNCC(lvi_ncc));
            db.SubmitChanges();
        }
        public void suaTTNCC(ListViewItem lvi_ncc)
        {
            var ncc = from NCC in db.NhaCungCaps
                      where NCC.maNCC==lvi_ncc.Text
                      select NCC;
            foreach(NhaCungCap n in ncc)
            {
                n.tenNCC = lvi_ncc.SubItems[1].Text;
                n.diaChiNCC = lvi_ncc.SubItems[2].Text;
                n.email = lvi_ncc.SubItems[3].Text;
            }
            db.SubmitChanges();
        }
        public List<ListViewItem> TimKiem(string ten)
        {
            dsNCC.Clear();
            var ncc = from NCC in db.NhaCungCaps
                      select NCC;
            foreach (NhaCungCap nhaCungCap in ncc)
            {
                string t = nhaCungCap.tenNCC.ToLower();
                if (t.Contains(ten.ToLower()))
                {
                    lvit = new ListViewItem();
                    lvit.Text = nhaCungCap.maNCC.ToString();
                    lvit.SubItems.Add(nhaCungCap.tenNCC);
                    lvit.SubItems.Add(nhaCungCap.diaChiNCC);
                    lvit.SubItems.Add(nhaCungCap.email);
                    dsNCC.Add(lvit);
                }
            }
            return dsNCC;
        }
    }
}
