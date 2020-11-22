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
    public partial class frmManHinhChinh : Form
    {
        private frmDoiMK frmDoiMK = new frmDoiMK();
        private frmThongTinTaiKhoan frmThongTinTaiKhoan = new frmThongTinTaiKhoan();
        private frmQuanLyXe frmQuanLyXe = new frmQuanLyXe();
        private frmQuanLyKhachHang frmQuanLyKhachHang = new frmQuanLyKhachHang();
        private frmQuanLyHoaDon frmQuanLyHoaDon = new frmQuanLyHoaDon();
        private frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
        private frmQuanLyNhaCungCap frmQuanLyNhaCungCap = new frmQuanLyNhaCungCap();
        private frmQuanLyNhaSanXuat frmNhaSanXuat = new frmQuanLyNhaSanXuat();
        private frmThongKe frmThongKe = new frmThongKe();

        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            if (DangNhapController.chucVu == "True")
            {
                mnsQuanLyNhanVien.Enabled = true;
                mnsQuanLyNhaCungCap.Enabled = true;
                mnsQuanLyNhaSanXuat.Enabled = true;
            }
            else
            { 
                mnsQuanLyNhanVien.Enabled = false;
                mnsQuanLyNhaCungCap.Enabled = false;
                mnsQuanLyNhaSanXuat.Enabled = false;
            }    
        }
        private void mnsXemThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTinTaiKhoan.ShowDialog();
            this.Show();
        }

        private void mnsDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dangXuat = new frmDangNhap();
            dangXuat.Show();
        }

        private void mnsQuanLyXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyXe.ShowDialog();
            this.Show();
        }

        private void mnsQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang.ShowDialog();
            this.Show();
        }

        private void mnsQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHoaDon.ShowDialog();
            this.Show();
        }

        private void mnsQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }

        private void mnsQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhaCungCap.ShowDialog();
            this.Show();
        }

        private void mnsThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKe.ShowDialog();
            this.Show();
        }
        private void mnsQuanLyNhaSanXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaSanXuat.ShowDialog();
            this.Show();
        }

        private void frmManHinhChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnsDoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMK.ShowDialog();
            this.Show();
        }
    }
}
