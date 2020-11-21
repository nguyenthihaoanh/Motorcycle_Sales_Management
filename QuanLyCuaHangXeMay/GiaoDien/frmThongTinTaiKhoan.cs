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
            tbMaNV.Text = ds[0].SubItems[0].Text;
            tbTenNV.Text = ds[0].SubItems[1].Text;
            if (ds[0].SubItems[2].Text == "True")
                tbGioiTinh.Text = "Nữ";
            else
                tbGioiTinh.Text = "Nam";
            tbCMND.Text = ds[0].SubItems[3].Text;
            tbDiaChi.Text = ds[0].SubItems[4].Text;
            if (ds[0].SubItems[5].Text == "True")
                tbChucVu.Text = "Quản Lý";
            else
                tbChucVu.Text = "Nhân Viên";
            tbSDT.Text = ds[0].SubItems[6].Text;
            tbTaiKhoan.Text = ds[0].SubItems[7].Text;
        }
    }
}
