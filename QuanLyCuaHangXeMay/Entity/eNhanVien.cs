using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.Entity
{
    public class eNhanVien
    {
        private string maNV, tenNV, diaChi, chucVu, taiKhoan, matKhau;
        private bool gioiTinh;
        private int CMND, SDT;
        public string MaNV
        {
            get { return maNV; }

            set { maNV = value; }
        }
        public string TenNV
        {
            get { return tenNV; }

            set { tenNV = value; }
        }
        public bool GioiTinh
        {
            get { return gioiTinh; }

            set { gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }

            set { diaChi = value; }
        }
        public string ChucVu
        {
            get { return chucVu; }

            set { chucVu = value; }
        }
        public string TaiKhoan
        {
            get { return taiKhoan; }

            set { taiKhoan = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }

            set { matKhau = value; }
        }
        public int soCMND
        {
            get { return CMND; }

            set { CMND = value; }
        }
        public int SoDT
        {
            get { return SDT; }

            set { SDT = value; }
        }
        public eNhanVien()
        {

        }
        public eNhanVien(string maNV, string tenNV, bool gioiTinh, string diaChi, string chucVu, string taiKhoan, string matKhau, int CMND, int SDT)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.chucVu = chucVu;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.CMND = CMND;
            this.SDT = SDT;
        }
    }
}
