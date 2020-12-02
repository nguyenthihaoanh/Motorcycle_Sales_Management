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
using QuanLyCuaHangXeMay.GiaoDien;

namespace QuanLyCuaHangXeMay
{
    public partial class frmThongTinTaiKhoan : Form
    {
        private TTNhanVienController TTNV = new TTNhanVienController(); 
        private ListViewItem lvi_nv = new ListViewItem();
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            List<ListViewItem> ds = TTNV.NhanTT();
            lbMaNV.Text = ds[0].SubItems[0].Text;
            lbTenNV.Text = ds[0].SubItems[1].Text;
            if (ds[0].SubItems[2].Text == "True")
                lbGioiTinh.Text = "Nữ";
            else
                lbGioiTinh.Text = "Nam";
            lbCMND.Text = ds[0].SubItems[3].Text;
            lbDiaChi.Text = ds[0].SubItems[4].Text;
            if (ds[0].SubItems[5].Text == "True")
                lbChucVu.Text = "Quản Lý";
            else
                lbChucVu.Text = "Nhân Viên";
            lbSDT.Text = ds[0].SubItems[6].Text;
            lbTaiKhoan.Text = ds[0].SubItems[7].Text;
        }

    }
}
