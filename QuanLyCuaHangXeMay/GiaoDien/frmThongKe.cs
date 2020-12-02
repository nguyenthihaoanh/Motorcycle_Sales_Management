using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangXeMay.Model;

namespace QuanLyCuaHangXeMay
{
    public partial class frmThongKe : Form
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            capNhap();
        }
        private void capNhap()
        {
            var thongKe = (from cthd in db.CTHoaDonXes
                          join hd in db.HoaDonXes on cthd.maHoaDon equals hd.maHoaDon
                          select new
                          {
                              tenNV = hd.NhanVien.tenNhanVien,
                              soLuong = cthd.soLuong
                          });
            chart1.Series["Series1"].XValueMember = "tenNV";
            chart1.Series["Series1"].YValueMembers = "soLuong";
            chart1.DataSource = thongKe/*.GroupBy(x => x.tenNV).Select(x => x.Key).ToList()*/;
            chart1.DataBind();
        }
    }
}
