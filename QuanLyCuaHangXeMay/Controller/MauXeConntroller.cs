using QuanLyCuaHangXeMay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Controller
{
    public class MauXeConntroller
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private List<ListViewItem> dsMX = new List<ListViewItem>();
        private ListViewItem lvit;
        // Thêm thông tin 1 ncc vào listviewitem
        public ListViewItem them_mx_lv(MauXe mauXe)
        {
            lvit = new ListViewItem();
            lvit.Text = mauXe.maMau.ToString();
            lvit.SubItems.Add(mauXe.tenMau);
            return lvit;
        }
        //Lay danh sach tat ca nhan vien
        public List<ListViewItem> danhSachMX()
        {
            dsMX.Clear();
            var mx = from MX in db.MauXes
                      select MX;
            foreach (MauXe n in mx)
                dsMX.Add(them_mx_lv(n));
            return dsMX;
        }
        //them ncc vao database
        public MauXe themTTMX(ListViewItem lvi_mx)
        {
            MauXe n = new MauXe();
            n.maMau = lvi_mx.Text;
            n.tenMau = lvi_mx.SubItems[1].Text;
            return n;
        }
        public void them(ListViewItem lvi_mx)
        {
            db.MauXes.InsertOnSubmit(themTTMX(lvi_mx));
            db.SubmitChanges();
        }
    }
}
