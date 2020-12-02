using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.Model;

namespace QuanLyCuaHangXeMay.Controller
{
    public class DangNhapController
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private NhanVienController nv = new NhanVienController();
        public static string chucVu { get; private set; }
        public static string maNV { get; private set; }

        public bool kiemTraTaiKhoan(string tkhoan, string matKhau)
        {
            db = new dbQLMuaBanXeDataContext();
            var nv = (from NV in db.NhanViens
                      join TK in db.TaiKhoans on NV.maNhanVien equals TK.maNhanVien
                      select new
                      {
                          maNV = NV.maNhanVien,
                          chucVu = NV.chucVu,
                          taiKhoan = TK.taiKhoan1,
                          matKhau = TK.matKhau,
                          tinhTrang = NV.tinhTrang
                      }).Where(x => x.taiKhoan == tkhoan);
            if (tkhoan != null)
            {
                foreach (var nhanVien in nv)
                    if (nhanVien.tinhTrang == true) 
                    {
                            if (nhanVien.matKhau == matKhau)
                            {
                                chucVu = nhanVien.chucVu.ToString();
                                maNV = nhanVien.maNV;
                                return true;
                            }
                            else
                                return false;
                    }
                    else
                        return false;
                
            }
            return false;
        }
        public void thayDoiMK(string ma, string mk)
        {
            nv.thayDoiMK(ma, mk);
        }
        public bool kiemTraMK(string ma, string mk)
        {
            return nv.kiemTraMK(ma, mk);
        }
    }
}
