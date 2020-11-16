using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.Entity
{
    class eCTHoaDonXe
    {
        private string maHoaDon, maXe;
        private int soLuong;

        public string MaHoaDon
        {
            get { return maHoaDon; }
        }
        public string MaXe
        {
            get { return maXe; }
        }
        public int SoLuongXe
        {
            get { return soLuong; }

            set { soLuong = value; }
        }
        public eCTHoaDonXe()
        {

        }
        public eCTHoaDonXe(string maHD, string maXe, int soLuong)
        {
            this.maHoaDon = maHD;
            this.maXe = maXe;
            this.soLuong = soLuong;
        }
    }
}
