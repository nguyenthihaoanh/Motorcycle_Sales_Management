using QuanLyCuaHangXeMay.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay
{
    public class NhanVienController
    {
        dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        public List<eNhanVien> DuLieu()
        {
            var dsNV = db.NhanViens.ToList();
            List<eNhanVien> list = new List<eNhanVien>();
            foreach(NhanVien nv in dsNV)
            {
                eNhanVien eNV = new eNhanVien();
                eNV.MaNV = nv.maNhanVien;
                eNV.TenNV = nv.tenNhanVien;
                eNV.soCMND = nv.CMND;
                eNV.SoDT = nv.soDienThoai;
                eNV.DiaChi = nv.diaChiNV;
                eNV.ChucVu = nv.chucVu;
                eNV.TaiKhoan = nv.taiKhoan;
                eNV.MatKhau = nv.matKhau;
                if (nv.gioiTinh == true)
                    eNV.GioiTinh = true;
                else
                    eNV.GioiTinh = false;
                list.Add(eNV);
            }
            return list;
        }
    }
}
