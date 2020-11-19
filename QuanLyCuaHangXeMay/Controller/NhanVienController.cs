using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangXeMay.Controller;
using QuanLyCuaHangXeMay.Model;

namespace QuanLyCuaHangXeMay
{
    public class NhanVienController
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private List<ListViewItem> dsNV = new List<ListViewItem>();
        private ListViewItem lvit = new ListViewItem();
        
        public List<ListViewItem> Lay_TTNV_Tu_Data(string maNv)//lay thong tin nv từ data theo id
        {
            dsNV.Clear();
            var dsNV_Tu_Data = from nv in db.NhanViens
                               join tk in db.TaiKhoans on nv.maNhanVien equals tk.maNhanVien
                               group tk by new { nv.maNhanVien, nv.tenNhanVien, nv.gioiTinh, nv.CMND, nv.diaChiNV, tk.chucVu, nv.soDienThoai, tk.taiKhoan1, tk.matKhau, nv.tinhTrang} into g
                               select new
                               {
                                   maNV = g.Key.maNhanVien,
                                   tenNV = g.Key.tenNhanVien,
                                   diaChi = g.Key.diaChiNV,
                                   gioiTinh = g.Key.gioiTinh,
                                   cmnd = g.Key.CMND,
                                   sdt = g.Key.soDienThoai,
                                   tinhTrang = g.Key.tinhTrang,
                                   tk = g.Key.taiKhoan1,
                                   mk = g.Key.matKhau,
                                   cv = g.Key.chucVu
                               };
            foreach(var nv in dsNV_Tu_Data)//kiem tra ma nv trung voi csdl thi show
                if (maNv == nv.maNV)
                {
                    lvit.Text = nv.maNV.ToString();
                    lvit.SubItems.Add(nv.tenNV);
                    lvit.SubItems.Add(nv.gioiTinh.ToString());
                    lvit.SubItems.Add(nv.cmnd);
                    lvit.SubItems.Add(nv.diaChi);
                    lvit.SubItems.Add(nv.cv.ToString());
                    lvit.SubItems.Add(nv.sdt);
                    lvit.SubItems.Add(nv.tk);
                    lvit.SubItems.Add(nv.mk);
                    lvit.SubItems.Add(nv.tinhTrang.ToString());
                    dsNV.Add(lvit);
                }
            return dsNV;
        }
        public void thayDoiMK(string ma, string mk)
        {
            var vartk = from TK in db.TaiKhoans
                     where TK.maNhanVien == ma
                     select TK;
            foreach( TaiKhoan taiKhoan in vartk)
            {
                taiKhoan.matKhau = mk;
            }
            db.SubmitChanges();
        }
        public bool kiemTraMK(string ma, string mk)
        {
            var vartk = from TK in db.TaiKhoans
                        where TK.maNhanVien == ma
                        select TK;
            foreach (TaiKhoan taiKhoan in vartk)
            {
                if (taiKhoan.matKhau == mk)
                    return true;
            }
            return false;
        }
    }
}
