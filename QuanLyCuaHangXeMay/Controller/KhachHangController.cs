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

        // Thêm thông tin 1 nv vào listviewitem
        public ListViewItem them_nv_lv(KhachHang khachHang)
        {
            lvit = new ListViewItem();
            lvit.Text = khachHang.maKhachHang.ToString();
            lvit.SubItems.Add(khachHang.tenKhachHang);
            lvit.SubItems.Add(khachHang.soDienThoai);
            lvit.SubItems.Add(khachHang.CMND);
            lvit.SubItems.Add(khachHang.diaChiKhachHang);
            return lvit;
        }
        //Lay danh sach tat ca nhan vien
        public List<ListViewItem> danhSachNV()
        {
            dsKH.Clear();
            var kh = from KH in db.KhachHangs
                     select KH;
            foreach (KhachHang k in kh)
                dsKH.Add(them_nv_lv(k));
            return dsKH;
        }
        //them NhanVien trong database
        public void themTTNV(ListViewItem lvi_nv)
        {
            KhachHang k = new KhachHang();
            k.maKhachHang = lvi_nv.Text.ToString();
            k.tenKhachHang = lvi_nv.SubItems[1].Text;
            k.soDienThoai = lvi_nv.SubItems[2].Text;
            k.CMND = lvi_nv.SubItems[3].Text;
            k.diaChiKhachHang = lvi_nv.SubItems[4].Text;
            db.KhachHangs.InsertOnSubmit(k);
            db.SubmitChanges();
        }
        public void suaTTNV(ListViewItem lvi_nv)
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
    }
}
