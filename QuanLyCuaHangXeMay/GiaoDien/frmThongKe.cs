using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangXeMay.Controller;
using QuanLyCuaHangXeMay.Model;

namespace QuanLyCuaHangXeMay
{
    public partial class frmThongKe : Form
    {
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private TTNhanVienController TTNV = new TTNhanVienController();
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
            rbThongKeTheoNV.Visible = false;
            chart_thang.Visible = false;
            chart_nv.Visible = false;
        }
        private void rbThongKeTheoNV_CheckedChanged(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dateTimePickerFrom.Value.ToString());
            DateTime end = Convert.ToDateTime(dateTimePickerTo.Value.ToString());
            if (rbThongKeTheoNV.Checked == true)
            {
                chart_nv.Visible = true;
                chart_thang.Visible = false;
                var thongKe = (from cthd in db.CTHoaDonXes
                               where cthd.ngayLap >= start && cthd.ngayLap <= end
                               group cthd by cthd.HoaDonXe.NhanVien.tenNhanVien into g
                               select new
                               {
                                   tenNhanVien = g.Key,
                                   soLuong = g.Sum(x => x.soLuong)
                               }).ToList();
                chart_nv.DataSource = thongKe;
                chart_nv.Series["Số Lượng"].XValueMember = "tenNhanVien";
                chart_nv.Series["Số Lượng"].YValueMembers = "soLuong";
                chart_nv.DataBind();
                chart_nv.Show();
            }
        }

        private void rbThongkeTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThongkeTheoThang.Checked == true)
            {
                chart_thang.Visible = true;
                chart_nv.Visible = false;
                var thongKe = (from cthd in db.CTHoaDonXes
                               group cthd by cthd.ngayLap.Month into g
                               select new
                               {
                                   tenNhanVien = g.Key,
                                   thanhTien = g.Sum(x => x.thanhTien)
                               }).ToList();
                chart_thang.DataSource = thongKe;
                chart_thang.Series["Tổng Tiền"].XValueMember = "tenNhanVien";
                chart_thang.Series["Tổng Tiền"].YValueMembers = "thanhTien";
                chart_thang.DataBind();
                chart_thang.Show();
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value < dateTimePickerTo.Value)
            {
                rbThongKeTheoNV.Visible = true;
            }
            else
                MessageBox.Show("Ngày không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value < dateTimePickerTo.Value)
            {
                rbThongKeTheoNV.Visible = true;
            }
            else
                MessageBox.Show("Ngày không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
