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

namespace QuanLyCuaHangXeMay
{
    public partial class frmChiTietHD : Form
    {
        CTHDController CTHDC = new CTHDController();
        private TTNhanVienController TTNV = new TTNhanVienController();
        public frmChiTietHD()
        {
            InitializeComponent();
        }

        private frmThemXe frmThemXe = new frmThemXe();

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemXe.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            List<ListViewItem> ds = TTNV.NhanTT();
            lbXuatTenNV.Text = ds[0].SubItems[1].Text;
            dtmNgayHD.Value = DateTime.Today;
            lbXuatTenKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[1].Text;
            lbXuatDiaChiKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[4].Text;
            lbXuatSDT.Text = frmQuanLyKhachHang.lvi_KH.SubItems[2].Text;
            lbXuatCMND.Text = frmQuanLyKhachHang.lvi_KH.SubItems[3].Text;
        }
    }
}
