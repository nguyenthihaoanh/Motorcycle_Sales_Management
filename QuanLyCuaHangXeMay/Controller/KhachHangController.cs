using QuanLyCuaHangXeMay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Controller
{
    public class KhachHangController
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private List<ListViewItem> dsKH = new List<ListViewItem>();
        private ListViewItem lvit;

        // Thêm thông tin 1 kh vào listviewitem
        public ListViewItem them_kh_lv(KhachHang khachHang)
        {
            lvit = new ListViewItem();
            lvit.Text = khachHang.maKhachHang.ToString();
            lvit.SubItems.Add(khachHang.tenKhachHang);
            lvit.SubItems.Add(khachHang.soDienThoai);
            lvit.SubItems.Add(khachHang.CMND);
            lvit.SubItems.Add(khachHang.diaChiKhachHang);
            return lvit;
        }
        //Lay danh sach tat ca kh
        public List<ListViewItem> danhSachKH()
        {
            dsKH.Clear();
            var kh = from KH in db.KhachHangs
                     select KH;
            foreach (KhachHang k in kh)
                dsKH.Add(them_kh_lv(k));
            return dsKH;
        }
        //them kh trong database
        public void themTTKH(ListViewItem lvi_kh)
        {
            KhachHang k = new KhachHang();
            k.maKhachHang = lvi_kh.Text.ToString();
            k.tenKhachHang = lvi_kh.SubItems[1].Text;
            k.soDienThoai = lvi_kh.SubItems[2].Text;
            k.CMND = lvi_kh.SubItems[3].Text;
            k.diaChiKhachHang = lvi_kh.SubItems[4].Text;
            db.KhachHangs.InsertOnSubmit(k);
            db.SubmitChanges();
        }
        public void suaTTKH(ListViewItem lvi_nv)
        {
            var kh = from KH in db.KhachHangs
                     where KH.maKhachHang == lvi_nv.Text
                     select KH;
            foreach (KhachHang k in kh)
            {
                k.tenKhachHang = lvi_nv.SubItems[1].Text;
                k.soDienThoai = lvi_nv.SubItems[2].Text;
                k.CMND = lvi_nv.SubItems[3].Text;
                k.diaChiKhachHang = lvi_nv.SubItems[4].Text;
            }
            db.SubmitChanges();
        }
        public List<ListViewItem> TimKiem(string ten)
        {
            dsKH.Clear();
            var kh = from KH in db.KhachHangs
                     select KH;
            foreach (KhachHang khachHang in kh)
            {
                string t = khachHang.tenKhachHang.ToLower();
                if (t.Contains(ten.ToLower()))
                {
                    lvit = new ListViewItem();
                    lvit.Text = khachHang.maKhachHang.ToString();
                    lvit.SubItems.Add(khachHang.tenKhachHang);
                    lvit.SubItems.Add(khachHang.soDienThoai);
                    lvit.SubItems.Add(khachHang.CMND);
                    lvit.SubItems.Add(khachHang.diaChiKhachHang);
                    dsKH.Add(lvit);
                }
            }
            return dsKH;
        }
    }
}
