using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.Entity
{
    class eKhachHang
    {
        private string maKH, tenKH, diaChiKH;
        private int cMND, SDT;
        public string MaKH
        {
            get { return maKH; }
        }
        public string TenKH
        {
            get { return tenKH; }

            set { tenKH = value; }
        }
        public string DiaChiKH
        {
            get { return diaChiKH; }

            set { diaChiKH = value; }
        }
        public int CMND
        {
            get { return cMND; }

            set { cMND = value; }
        }
        public int SoDT
        {
            get { return SDT; }

            set { SDT = value; }
        }
        public eKhachHang()
        {

        }
        public eKhachHang(string maKH, string tenKH, string diaChi, int CMND, int SDT)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChiKH = diaChi;
            this.cMND = CMND;
            this.SDT = SDT;
        }
    }
}
