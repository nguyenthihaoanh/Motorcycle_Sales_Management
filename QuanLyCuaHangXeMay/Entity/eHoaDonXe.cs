using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.Entity
{
    class eHoaDonXe
    {
        private string maHoaDon, maKhachHang, maNhanVien;
        private DateTime ngayLapHD; 
        public string MaHoaDon
        {
            get { return maHoaDon; }
        }
        public string MaKhachHang
        {
            get { return maKhachHang; }
        }
        public string MaNhanVien
        {
            get { return maNhanVien; }
        }
        public DateTime NgayLapHD
        {
            get { return ngayLapHD; }

            set { ngayLapHD = value; }
        }
        public eHoaDonXe()
        {
            this.ngayLapHD = DateTime.Now;
        }
        public eHoaDonXe(string maHD, string maNV, string maKhachHang, DateTime ngayLap)
        {
            this.maHoaDon = maHD;
            this.maKhachHang = maKhachHang;
            this.maNhanVien = maNV;
            this.ngayLapHD = ngayLap;
        }
    }
}
