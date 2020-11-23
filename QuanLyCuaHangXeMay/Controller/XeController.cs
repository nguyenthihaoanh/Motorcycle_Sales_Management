using QuanLyCuaHangXeMay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Controller
{
    public class XeController
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private List<ListViewItem> dsXe = new List<ListViewItem>();
        private List<string> dsNCC = new List<string>();
        private List<string> dsNSX = new List<string>();
        private List<string> dsMau = new List<string>();
        /*private ListViewItem lvit = new ListViewItem();*/

        // Thêm thông tin 1 xe vào listviewitem
        public List<string> ds_ncc()
        {
            var ds = from ncc in db.NhaCungCaps
                     select ncc;
            foreach (var ncc in ds)
            {
                dsNCC.Add(ncc.tenNCC);
            }
            return dsNCC;
        }
        public List<string> ds_nsx()
        {
            var ds = from nsx in db.NhaSanXuats
                     select nsx;
            foreach (var nsx in ds)
            {
                dsNSX.Add(nsx.tenNSX);
            }
            return dsNSX;
        }
        public List<string> ds_mau()
        {
            var ds = from mau in db.MauXes
                     select mau;
            foreach (var mau in ds)
            {
                dsMau.Add(mau.tenMau);
            }
            return dsMau;
        }

        public List<ListViewItem> them_ds_xe()
        {
            dsXe.Clear();
            var ds = from xe in db.Xes
                     join mau in db.MauXes on xe.maMau equals mau.maMau
                     join nsx in db.NhaSanXuats on xe.maNSX equals nsx.maNSX
                     join ncc in db.NhaCungCaps on xe.maNCC equals ncc.maNCC
                     select new
                     {
                         maXe = xe.maXe,
                         nhanHieu = xe.nhanHieu,
                         mau = mau.tenMau,
                         dungTich = xe.dungTich,
                         tenNCC = ncc.tenNCC,
                         tenNSX = nsx.tenNSX,
                         soLuong = xe.soLuong,
                         giaNhap = xe.giaNhap,
                         ngayNhap = xe.ngayNhap
                     };
            foreach (var xe in ds)
            {
                ListViewItem lvit = new ListViewItem();
                lvit.Text = xe.maXe;
                lvit.SubItems.Add(xe.nhanHieu);
                lvit.SubItems.Add(xe.mau);
                lvit.SubItems.Add(xe.dungTich.ToString());
                lvit.SubItems.Add(xe.tenNCC);
                lvit.SubItems.Add(xe.tenNSX);
                lvit.SubItems.Add(xe.soLuong.ToString());
                lvit.SubItems.Add(xe.giaNhap.ToString());
                lvit.SubItems.Add(xe.ngayNhap.ToString());
                dsXe.Add(lvit);
            }
            return dsXe;
        }
        //them xe trong database
        public void themTTXe(ListViewItem lvi_Xe, DateTimePicker ngayNhap)
        {
            Xe k = new Xe();
            k.maXe = lvi_Xe.Text.ToString();
            k.nhanHieu = lvi_Xe.SubItems[1].Text;
            k.maMau = lvi_Xe.SubItems[2].Text;
            k.dungTich = Convert.ToInt32(lvi_Xe.SubItems[3].Text.ToString());
            k.maNCC = lvi_Xe.SubItems[4].Text; /*db.NhaCungCaps.FirstOrDefault(n => n.tenNCC == lvi_Xe.SubItems[4].Text).maNCC;*/
            k.maNSX = lvi_Xe.SubItems[5].Text;/*db.NhaSanXuats.FirstOrDefault(n => n.tenNSX == lvi_Xe.SubItems[5].Text).maNSX;*/
            k.soLuong = Convert.ToInt32(lvi_Xe.SubItems[6].Text.ToString());
            k.giaNhap = Convert.ToDecimal(lvi_Xe.SubItems[7].Text);
            k.ngayNhap = Convert.ToDateTime(ngayNhap.Value.ToShortDateString());
            db.Xes.InsertOnSubmit(k);
            db.SubmitChanges();
        }
        public void suaTTNV(ListViewItem lvi_nv)
        {
            /*var kh = from KH in db.KhachHangs
                     where KH.maKhachHang == lvi_nv.Text
                     select KH;
            foreach (KhachHang k in kh)
            {
                k.tenKhachHang = lvi_nv.SubItems[1].Text;
                k.soDienThoai = lvi_nv.SubItems[2].Text;
                k.CMND = lvi_nv.SubItems[3].Text;
                k.diaChiKhachHang = lvi_nv.SubItems[4].Text;
            }
            db.SubmitChanges();*/
        }
    }
}
