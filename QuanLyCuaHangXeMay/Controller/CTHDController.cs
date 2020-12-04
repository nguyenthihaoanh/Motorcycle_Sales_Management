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
        public List<ListViewItem> lay_hd_theo_maKH()
        {
            dsCTHD.Clear();
            var cthd = from c in db.CTHoaDonXes
                       join hd in db.HoaDonXes on c.maHoaDon equals hd.maHoaDon
                       join xe in db.Xes on c.maXe equals xe.maXe
                       select new
                       {
                           macthd = c.maCTHoaDon,
                           maHD = c.maHoaDon,
                           tenXe = xe.nhanHieu,
                           sl = c.soLuong,
                           gia = c.donGia,
                           thanhTien = c.thanhTien,
                           ngayLapHD = c.ngayLap,
                           maxe = xe.maXe
                       };
            foreach (var hd in cthd)
            {
                lvit = new ListViewItem();
                lvit.Text = hd.macthd.ToString();
                lvit.SubItems.Add(hd.maHD);
                lvit.SubItems.Add(hd.tenXe);
                lvit.SubItems.Add(hd.sl.ToString());
                lvit.SubItems.Add(hd.gia.ToString());
                lvit.SubItems.Add(hd.thanhTien.ToString());
                lvit.SubItems.Add(hd.ngayLapHD.ToString());
                lvit.SubItems.Add(hd.maxe);
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
                cthd.ngayLap = Convert.ToDateTime(ngay_dat_hang.Value.ToString());
                db.CTHoaDonXes.InsertOnSubmit(cthd);
                db.SubmitChanges();

            }
            /*public void themXeVaoCTHD(ListViewItem lvi_themXe, string tenXe, int soLuong, string donGia, string thanhTien, DateTimePicker ngayLap)
            {
                CTHoaDonXe cthd = new CTHoaDonXe();
                cthd.maHoaDon = lvi_themXe.ToString();
                cthd.maXe = Convert.ToString(tenXe);
                //cthd.maXe = lvi_themXe.SubItems[1].Text;
                cthd.soLuong = Convert.ToInt32(soLuong.ToString());
                cthd.donGia = Convert.ToDecimal(donGia);
                cthd.thanhTien = Convert.ToDecimal(thanhTien);
                cthd.ngayLap = Convert.ToDateTime(ngayLap.Value.ToString());
                db.CTHoaDonXes.InsertOnSubmit(cthd);
                db.SubmitChanges();
            }*/
        }
    }
}
