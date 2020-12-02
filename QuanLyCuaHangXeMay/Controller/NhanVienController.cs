using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private ListViewItem lvit;

        //lay thong tin nv từ data theo id
        public List<ListViewItem> Lay_TTNV_Tu_Data(string maNv)
        {
            lvit = new ListViewItem();
            dsNV.Clear();
            var dsNV_Tu_Data = from nv in db.NhanViens
                               join tk in db.TaiKhoans on nv.maNhanVien equals tk.maNhanVien
                               group tk by new { nv.maNhanVien, nv.tenNhanVien, nv.gioiTinh, nv.CMND, nv.diaChiNV, nv.chucVu, nv.soDienThoai, tk.taiKhoan1, tk.matKhau, nv.tinhTrang} into g
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
            //kiem tra ma nv trung voi csdl thi show
            foreach(var nv in dsNV_Tu_Data)
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
                    lvit.SubItems.Add(nv.tinhTrang.ToString());
                    dsNV.Add(lvit);
                }
            return dsNV;
        }
        //thay doi mat khau
        public void thayDoiMK(string ma, string mk)
        {
            var tk = from taiKhoan in db.TaiKhoans
                     where taiKhoan.maNhanVien == ma
                     select taiKhoan;
            foreach (TaiKhoan taiKhoan in tk)
            {
                taiKhoan.matKhau = mk;
            }
            db.SubmitChanges();
        }
        //kiem tra mat khau
        public bool kiemTraMK(string ma, string mk)
        {
            var tk = from taiKhoan in db.TaiKhoans
                     where taiKhoan.maNhanVien == ma
                     select taiKhoan;
            foreach (TaiKhoan taiKhoan in tk)
            {
                if (taiKhoan.matKhau == mk)
                    return true;
            }
            return false;
        }

        // Thêm thông tin 1 nv vào listviewitem
        public ListViewItem them_nv_lv(NhanVien nhanVien)
        {
            ListViewItem lvit = new ListViewItem();
            var tk = from taiKhoan in db.TaiKhoans
                     select taiKhoan;
            string tenTaiKhoan = "";
            foreach (TaiKhoan t in tk)
            {
                if (t.maNhanVien == nhanVien.maNhanVien)
                {
                    tenTaiKhoan = t.taiKhoan1;
                }
            }
            lvit.Text = nhanVien.maNhanVien.ToString();
            lvit.SubItems.Add(nhanVien.tenNhanVien);
            lvit.SubItems.Add(nhanVien.soDienThoai);
            lvit.SubItems.Add(nhanVien.gioiTinh ? "Nữ" : "Nam");
            lvit.SubItems.Add(nhanVien.CMND);
            lvit.SubItems.Add(nhanVien.diaChiNV);
            lvit.SubItems.Add(nhanVien.tinhTrang ? "Còn Làm" : "Nghỉ Làm");
            lvit.SubItems.Add(nhanVien.chucVu ? "Quản Lý" : "Nhân Viên");
            lvit.SubItems.Add(tenTaiKhoan);
            return lvit;
        }
        //Lay danh sach tat ca nhan vien
        public List<ListViewItem> danhSachNV()
        {
            dsNV.Clear();
            var nv = from nhanVien in db.NhanViens
                     select nhanVien;
            foreach (NhanVien n in nv)
                dsNV.Add(them_nv_lv(n));
            return dsNV;
        }
        //tu them tai khoan va mk
        public TaiKhoan themTaiKhoan(ListViewItem lvi_tk, string mk)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.maNhanVien = lvi_tk.Text.ToString();
            tk.taiKhoan1 = tk.maNhanVien;
            tk.matKhau = mk;
            return tk;
        }
        public void themTK(ListViewItem lvi_tk, string mk)
        {
            db.TaiKhoans.InsertOnSubmit(themTaiKhoan(lvi_tk, mk));
            db.SubmitChanges();
        }
        //them NhanVien trong database
        public NhanVien themTTNV(ListViewItem lvi_nv)
        {
            NhanVien n = new NhanVien();
            n.maNhanVien = lvi_nv.Text.ToString();
            n.tenNhanVien = lvi_nv.SubItems[1].Text;
            n.soDienThoai = lvi_nv.SubItems[2].Text;
            if (lvi_nv.SubItems[3].Text == "Nữ")
                n.gioiTinh = true;
            else
                n.gioiTinh = false;
            n.CMND = lvi_nv.SubItems[4].Text;
            n.diaChiNV = lvi_nv.SubItems[5].Text;
            if (lvi_nv.SubItems[6].Text == "Còn Làm")
                n.tinhTrang = true;
            else
                n.tinhTrang = false;
            if (lvi_nv.SubItems[7].Text == "Quản Lý")
                n.chucVu = true;
            else
                n.chucVu = false;
            return n;
        }
        public void them(ListViewItem lvi_nv)
        {
            db.NhanViens.InsertOnSubmit(themTTNV(lvi_nv));
            db.SubmitChanges();
        }
        public void suaTTNV(ListViewItem lvi_nv)
        {
            var nv = (from nhanVien in db.NhanViens
                     where nhanVien.maNhanVien == lvi_nv.Text
                     select nhanVien);
            foreach (NhanVien n in nv)
            {
                n.tenNhanVien = lvi_nv.SubItems[1].Text;
                n.soDienThoai = lvi_nv.SubItems[2].Text;
                if (lvi_nv.SubItems[3].Text == "Nữ")
                    n.gioiTinh = true;
                else
                    n.gioiTinh = false;
                n.CMND = lvi_nv.SubItems[4].Text;
                n.diaChiNV = lvi_nv.SubItems[5].Text;
                if (lvi_nv.SubItems[6].Text == "Còn Làm")
                    n.tinhTrang = true;
                else
                    n.tinhTrang = false;
                if (lvi_nv.SubItems[7].Text == "Quản Lý")
                    n.chucVu = true;
                else
                    n.chucVu = false;
            }
            db.SubmitChanges();
        }
        public List<ListViewItem> TimKiem(string ten)
        {
            dsNV.Clear();
            var nv = from nhanVien in db.NhanViens
                     select nhanVien;
            foreach (NhanVien nhanVien in nv)
            {
                string t = nhanVien.tenNhanVien.ToLower();
                if (t.Contains(ten.ToLower()))
                {
                    lvit = new ListViewItem();
                    lvit.Text = nhanVien.maNhanVien;
                    lvit.SubItems.Add(nhanVien.tenNhanVien);
                    lvit.SubItems.Add(nhanVien.soDienThoai);
                    lvit.SubItems.Add(nhanVien.gioiTinh ? "Nữ" : "Nam");
                    lvit.SubItems.Add(nhanVien.CMND);
                    lvit.SubItems.Add(nhanVien.diaChiNV);
                    lvit.SubItems.Add(nhanVien.tinhTrang ? "Còn Làm" : "Nghỉ Làm");
                    lvit.SubItems.Add(nhanVien.chucVu ? "Quản Lý" : "Nhân Viên");
                    dsNV.Add(lvit);
                }
            }
                return dsNV;
        }
    }
}
