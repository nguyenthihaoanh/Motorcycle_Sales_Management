using QuanLyCuaHangXeMay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Controller
{
    public class HDController
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private List<ListViewItem> dsHD = new List<ListViewItem>();
        private ListViewItem lvit;
        //Lay danh sach tat ca hoa don
        public List<ListViewItem> danhSachHD()
        {
            dsHD.Clear();
            var hd = from HD in db.HoaDonXes
                     join cthd in db.CTHoaDonXes on HD.maHoaDon equals cthd.maHoaDon
                     join kh in db.KhachHangs on HD.maKhachHang equals kh.maKhachHang
                     join nv in db.NhanViens on HD.maNhanVien equals nv.maNhanVien
                     select new
                     {
                         cthd=cthd.maCTHoaDon,
                         maHD = HD.maHoaDon,
                         nv = nv.tenNhanVien,
                         kh = kh.tenKhachHang,
                         sdtKH = kh.soDienThoai,
                         xe = cthd.Xe.nhanHieu,
                         mauXe = cthd.Xe.MauXe.tenMau,
                         soLuong = cthd.soLuong,
                         thanhTien = cthd.thanhTien,
                         ngay = cthd.ngayLap
                     };
            foreach (var n in hd)
            {
                lvit = new ListViewItem();
                lvit.Text = n.cthd;
                lvit.SubItems.Add(n.maHD);
                lvit.SubItems.Add(n.nv);
                lvit.SubItems.Add(n.kh);
                lvit.SubItems.Add(n.sdtKH);
                lvit.SubItems.Add(n.xe);
                lvit.SubItems.Add(n.mauXe);
                lvit.SubItems.Add(n.soLuong.ToString());
                lvit.SubItems.Add(n.thanhTien.ToString());
                lvit.SubItems.Add(n.ngay.ToShortDateString());
                dsHD.Add(lvit);
            }
            return dsHD;
        }
        public List<ListViewItem> TimKiem(string tenKH)
        {
            dsHD.Clear(); dsHD.Clear();
            var hd = from HD in db.HoaDonXes
                     join cthd in db.CTHoaDonXes on HD.maHoaDon equals cthd.maHoaDon
                     join kh in db.KhachHangs on HD.maKhachHang equals kh.maKhachHang
                     join nv in db.NhanViens on HD.maNhanVien equals nv.maNhanVien
                     select new
                     {
                         cthd = cthd.maCTHoaDon,
                         maHD = HD.maHoaDon,
                         nv = nv.tenNhanVien,
                         kh = kh.tenKhachHang,
                         sdtKH = kh.soDienThoai,
                         xe = cthd.Xe.nhanHieu,
                         mauXe = cthd.Xe.MauXe.tenMau,
                         soLuong = cthd.soLuong,
                         thanhTien = cthd.thanhTien,
                         ngay = cthd.ngayLap
                     };
            foreach (var n in hd)
            {
                string t = n.kh.ToLower();
                if (t.Contains(tenKH.ToLower()))
                {
                    lvit = new ListViewItem();
                    lvit.Text = n.cthd;
                    lvit.SubItems.Add(n.maHD);
                    lvit.SubItems.Add(n.nv);
                    lvit.SubItems.Add(n.kh);
                    lvit.SubItems.Add(n.sdtKH);
                    lvit.SubItems.Add(n.xe);
                    lvit.SubItems.Add(n.mauXe);
                    lvit.SubItems.Add(n.soLuong.ToString());
                    lvit.SubItems.Add(n.thanhTien.ToString());
                    lvit.SubItems.Add(n.ngay.ToString());
                    dsHD.Add(lvit);
                }
            }
                return dsHD;
            }
    }
}
