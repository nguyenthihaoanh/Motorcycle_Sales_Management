using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.Entity
{
    class eXe
    {
        private string maXe, nhanHieu, mauXe, maNCC;
        private DateTime ngayNhap;
        private double giaBan, giaNhap;
        private int soLuong, dungTich;

        public string MaXe
        {
            get { return maXe; }
        }
        public string NhanHieu
        {
            get { return nhanHieu; }

            set { nhanHieu = value; }
        }
        public string MaNCC
        {
            get { return maNCC; }
        }
        public int DungTich
        {
            get { return dungTich; }

            set { dungTich = value; }
        }
        public string MauXe
        {
            get { return mauXe; }

            set { mauXe = value; }
        }
        public DateTime NgayNhap
        {
            get { return ngayNhap; }

            set { ngayNhap = value; }
        }
        public double GiaBan
        {
            get { return giaBan; }

            set { giaBan = value; }
        }
        public double GiaNhap
        {
            get { return giaNhap; }

            set { giaNhap = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }

            set { soLuong = value; }
        }
        public eXe()
        {

        }
        public eXe(string maXe, string nhanHieu, string mauXe, int dungTich, string maNCC, DateTime ngayNhap, double giaNhap, int soLuong, double giaBan)
        {
            this.maXe = maXe;
            this.nhanHieu = nhanHieu;
            this.mauXe = mauXe;
            this.dungTich = dungTich;
            this.maNCC = maNCC;
            this.ngayNhap = ngayNhap;
            this.giaNhap = giaNhap;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
        }
    }
}
