using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.Model;

namespace QuanLyCuaHangXeMay.Controller
{
    class DangNhapController
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private NhanVienController nv = new NhanVienController();
        public static string chucVu { get; private set; }
        public static string maNV { get; private set; }

        public bool kiemTraTaiKhoan(string tkhoan, string matKhau)
        {
            maNV = "";
            chucVu = null;
            db = new dbQLMuaBanXeDataContext();
            var tk = from VarTK in db.TaiKhoans
                     where VarTK.taiKhoan1 == tkhoan
                     select VarTK;
            var nv = from VarNV in db.NhanViens
                     select VarNV;
            if (tkhoan != null)
            {
                foreach(NhanVien nhanVien in nv)
                    if (nhanVien.tinhTrang == true)
                    {
                        foreach(TaiKhoan taiKhoan in tk)
                            if (taiKhoan.matKhau == matKhau)
                            {
                                
                                chucVu = taiKhoan.chucVu.ToString();
                                maNV = taiKhoan.maNhanVien;
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
        public void thayDoiMk(string ma, string mk)
        {
            nv.thayDoiMK(ma, mk);
        }
        public bool kiemTraMk(string ma, string mk)
        {
            return nv.kiemTraMK(ma, mk);
        }
    }
}
