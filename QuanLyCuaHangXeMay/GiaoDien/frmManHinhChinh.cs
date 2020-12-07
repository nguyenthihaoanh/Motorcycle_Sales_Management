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
                mnuThemNV.Enabled = true;
                mnuSuaNV.Enabled = true;
                mnuTimNV.Enabled = true;
                mnuNCC.Enabled = true;
                mnuNSX.Enabled = true;
            }
            else
            {
                mnuThemNV.Enabled = false;
                mnuSuaNV.Enabled = false;
                mnuTimNV.Enabled = false;
                mnuNCC.Enabled = false;
                mnuNSX.Enabled = false;
            }    
        }

        private void frmManHinhChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuXemTTNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTinTaiKhoan.ShowDialog();
            this.Show();
        }

        private void mnuThemNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }

        private void mnuSuaNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }

        private void mnuTimNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMK.ShowDialog();
            this.Show();
        }

        private void mnuThemNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhaCungCap.ShowDialog();
            this.Show();
        }

        private void mnuSuaNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhaCungCap.ShowDialog();
            this.Show();
        }

        private void mnuTimNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhaCungCap.ShowDialog();
            this.Show();
        }

        private void mnuThemNSX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaSanXuat.ShowDialog();
            this.Show();
        }

        private void mnuSuaNSX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaSanXuat.ShowDialog();
            this.Show();
        }

        private void mnuTimNSX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaSanXuat.ShowDialog();
            this.Show();
        }

        private void mnuThemXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyXe.ShowDialog();
            this.Show();
        }

        private void mnuSuaTTXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyXe.ShowDialog();
            this.Show();
        }

        private void mnuTimXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyXe.ShowDialog();
            this.Show();
        }

        private void mnuThemKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang.ShowDialog();
            this.Show();
        }

        private void mnuSuaKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang.ShowDialog();
            this.Show();
        }

        private void mnuTimKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang.ShowDialog();
            this.Show();
        }

        private void mnuTimHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHoaDon.ShowDialog();
            this.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKe.ShowDialog();
            this.Show();
        }
    }
}
