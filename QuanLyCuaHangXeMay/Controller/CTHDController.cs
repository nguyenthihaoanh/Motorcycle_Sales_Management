using QuanLyCuaHangXeMay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Controller
{
    public class CTHDController
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private List<ListViewItem> dsCTHD = new List<ListViewItem>();
        public static ListViewItem cthd_moi = new ListViewItem();
        private TTNhanVienController TTNV = new TTNhanVienController();
        private ListViewItem lvit;
        public List<ListViewItem> ds_hd()
        {
            dsCTHD.Clear();
            var cthd = from hd in db.HoaDonXes select hd;
            foreach (var hd in cthd)
            {
                lvit = new ListViewItem();
                lvit.Text = hd.maHoaDon.ToString();
                lvit.SubItems.Add(hd.maKhachHang);
                lvit.SubItems.Add(hd.maNhanVien);
                dsCTHD.Add(lvit);

            }
            return dsCTHD;
        }
        public ListViewItem themCTHD(ListViewItem lvi_cthd)
        {
            lvit = new ListViewItem();
            lvit.Text = lvi_cthd.Text;
            lvit.SubItems.Add(lvi_cthd.SubItems[1]);
            lvit.SubItems.Add(lvi_cthd.SubItems[2]);
            lvit.SubItems.Add(lvi_cthd.SubItems[3]);
            lvit.SubItems.Add(lvi_cthd.SubItems[4]);
            lvit.SubItems.Add(lvi_cthd.SubItems[5]);
            lvit.SubItems.Add(lvi_cthd.SubItems[6]);
            lvit.SubItems.Add(lvi_cthd.SubItems[7]);
            return lvit;
        }
        public List<ListViewItem> danhSachCTHD(string maHD)
        {
            dsCTHD.Clear();
            var cthd = from hd in db.CTHoaDonXes
                       join xe in db.Xes on hd.maXe equals xe.maXe
                       select new
                       {
                           maHD = hd.maHoaDon,
                           maXe = hd.maXe,
                           tenXe = xe.nhanHieu,
                           mauXe = xe.MauXe.tenMau,
                           nuocSX = xe.NhaSanXuat.nuocSX,
                           soLuong = hd.soLuong,
                           gia = hd.donGia,
                           tt = hd.thanhTien
                       };
            foreach (var n in cthd)
            {
                if (maHD == n.maHD)
                {
                    lvit = new ListViewItem();
                    lvit.Text = n.maXe;
                    lvit.SubItems.Add(n.tenXe);
                    lvit.SubItems.Add(n.mauXe);
                    lvit.SubItems.Add(n.nuocSX);
                    lvit.SubItems.Add(Convert.ToInt32(n.soLuong).ToString());
                    lvit.SubItems.Add(Convert.ToDecimal(n.gia).ToString());
                    lvit.SubItems.Add(Convert.ToDecimal(n.tt).ToString());
                    dsCTHD.Add(lvit);
                }
            }
            return dsCTHD;
        }
        public void Luu_HD(ListView.ListViewItemCollection list_cthd, string mahd, DateTimePicker ngay_dat_hang)
        {
            List<ListViewItem> ds = TTNV.NhanTT();
            HoaDonXe hd = new HoaDonXe();
            hd.maHoaDon = Convert.ToString(mahd);
            hd.maNhanVien = ds[0].SubItems[0].Text;
            hd.maKhachHang = frmQuanLyKhachHang.lvi_KH.SubItems[0].Text;
            db.HoaDonXes.InsertOnSubmit(hd);
            db.SubmitChanges();
            foreach (ListViewItem lvi in list_cthd)
            {
                CTHoaDonXe cthd = new CTHoaDonXe();
                cthd.maCTHoaDon = Convert.ToString(lvi.SubItems[0].Text);
                cthd.maHoaDon = hd.maHoaDon;
                cthd.maXe = lvi.SubItems[7].Text;
                cthd.soLuong = Convert.ToInt32(lvi.SubItems[3].Text);
                cthd.donGia = Convert.ToDecimal(lvi.SubItems[4].Text);
                cthd.thanhTien = Convert.ToDecimal(lvi.SubItems[5].Text);
                cthd.ngayLap = Convert.ToDateTime(ngay_dat_hang.Value.ToShortDateString());
                db.CTHoaDonXes.InsertOnSubmit(cthd);
                db.SubmitChanges();
            }
        }
    }
}
