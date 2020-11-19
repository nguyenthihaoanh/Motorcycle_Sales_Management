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
        private frmDoiMK frmDoiMK = new frmDoiMK();
        private NhanVienController nhanVienController = new NhanVienController();
        private TTNVController TTNV = new TTNVController(); 
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
            lbXuatMaNV.Text = ds[0].SubItems[0].Text;
            lbXuatTenNV.Text = ds[0].SubItems[1].Text;
            if (ds[0].SubItems[2].Text == "True")
                lbXuatGioiTinh.Text = "Nữ";
            else
                lbXuatGioiTinh.Text = "Nam";
            lbXuatCMND.Text = ds[0].SubItems[3].Text;
            lbXuatDiaChi.Text = ds[0].SubItems[4].Text;
            if (ds[0].SubItems[5].Text == "True")
                lbXuatChucVu.Text = "Quản Lý";
            else
                lbXuatChucVu.Text = "Nhân Viên";
            lbXuatSDT.Text = ds[0].SubItems[6].Text;
            lbXuatTaiKhoan.Text = ds[0].SubItems[7].Text;
            lbXuatMatKhau.Text = ds[0].SubItems[8].Text;
        }

        private void frmThongTinTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void btSuaMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMK.ShowDialog();
        }
    }
}
