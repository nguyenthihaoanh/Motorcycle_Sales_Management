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
        private ListViewItem lvit;
        // Thêm thông tin 1 ncc vào listviewitem
        public ListViewItem them_hd_lv(HoaDonXe hoaDon)
        {
            lvit = new ListViewItem();
            lvit.Text = hoaDon.maHoaDon.ToString();
            lvit.SubItems.Add(hoaDon.maNhanVien);
            lvit.SubItems.Add(hoaDon.maKhachHang);
            return lvit;
        }
        //Lay danh sach tat ca nhan vien
        public List<ListViewItem> danhSachHD()
        {
            dsCTHD.Clear();
            var hd = from HD in db.HoaDonXes
                      select HD;
            foreach (HoaDonXe n in hd)
                dsCTHD.Add(them_hd_lv(n));
            return dsCTHD;
        }
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
            foreach(var hd in cthd)
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
            int count = lay_hd_theo_maKH().Count;
//            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                lvit.Text = "CTHD00" + stt.ToString();
            else if (stt < 100)
                lvit.Text = "CTHD0" + stt.ToString();
            else if (stt < 1000)
                lvit.Text = "CTHD" + stt.ToString();
            lvit.SubItems.Add(lvi_cthd.SubItems[1]);
            lvit.SubItems.Add(lvi_cthd.SubItems[2]);
            lvit.SubItems.Add(lvi_cthd.SubItems[3]);
            lvit.SubItems.Add(lvi_cthd.SubItems[4]);
            lvit.SubItems.Add(lvi_cthd.SubItems[5]);
            lvit.SubItems.Add(lvi_cthd.SubItems[6]);
            return lvit;

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
