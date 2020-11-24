﻿using QuanLyCuaHangXeMay.Model;
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
        
        /*private ListViewItem lvit = new ListViewItem();*/

        // Thêm thông tin 1 xe vào listviewitem
        public List<string> ds_ncc()
        {
            List<string> dsNCC = new List<string>();
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
            List<string> dsNSX = new List<string>();
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
            List<string> dsMau = new List<string>();
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
        public void themTTXe(ListViewItem lvi_Xe, string sl, string dungTich, string gN, DateTimePicker ngayNhap, string mau, string ncc, string nsx)
        {
            Xe k = new Xe();
            k.maXe = lvi_Xe.Text.ToString();
            k.nhanHieu = lvi_Xe.SubItems[1].Text;
            k.maMau = db.MauXes.First(x => x.tenMau == mau).maMau;
            k.dungTich = Convert.ToInt32(dungTich);
            k.maNCC = db.NhaCungCaps.First(x => x.tenNCC == ncc).maNCC;
            k.maNSX = db.NhaSanXuats.First(x => x.tenNSX == nsx).maNSX;
            k.soLuong = Convert.ToInt32(sl);
            k.giaNhap = Convert.ToDecimal(gN);
            k.ngayNhap = Convert.ToDateTime(ngayNhap.Value.ToString());
            db.Xes.InsertOnSubmit(k);
            db.SubmitChanges();
        }
        public void suaTTXe(ListViewItem lvi_Xe, string sl, string dungTich, string gN, DateTimePicker ngayNhap, string mau, string ncc, string nsx)
        {
            var xe = from XE in db.Xes
                     where XE.maXe == lvi_Xe.Text
                     select XE;
            foreach (Xe k in xe)
            {
                k.maXe = lvi_Xe.Text.ToString();
                k.nhanHieu = lvi_Xe.SubItems[1].Text;
                k.maMau = db.MauXes.First(x => x.tenMau == mau).maMau;
                k.dungTich = Convert.ToInt32(dungTich);
                k.maNCC = db.NhaCungCaps.First(x => x.tenNCC == ncc).maNCC;
                k.maNSX = db.NhaSanXuats.First(x => x.tenNSX == nsx).maNSX;
                k.soLuong = Convert.ToInt32(sl);
                k.giaNhap = Convert.ToDecimal(gN);
                k.ngayNhap = Convert.ToDateTime(ngayNhap.Value.ToString());
            }
            db.SubmitChanges();
        }
    }
}
