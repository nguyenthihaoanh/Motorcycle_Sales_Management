using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.Entity
{
    class eNhaCungCap
    {
        private string maNCC, tenNCC, diaChi;
        public string MaNCC
        {
            get { return maNCC; }
        }
        public string TenNCC
        {
            get { return tenNCC; }

            set { tenNCC = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }

            set { diaChi = value; }
        }
        public eNhaCungCap()
        {

        }
        public eNhaCungCap(string maNCC, string tenNCC, string diaChi)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
        }
    }
}
