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
    public partial class frmDangNhap : Form
    {
        public static string taiKhoan { get; private set; }
        public static string matKhau { get; private set; }
        private DangNhapController dn = new DangNhapController();
        private frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            taiKhoan = tbTaiKhoan.Text;
            matKhau = tbMatKhau.Text.GetHashCode().ToString();
            if (tbTaiKhoan.Text.Trim() == "" && tbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mời Bạn Nhập Tên Tài Khoản Và Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMatKhau.Clear();
            }
            else if (tbTaiKhoan.Text.Trim() != "" && tbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mời Bạn Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMatKhau.Clear();
            }
            else if (tbTaiKhoan.Text.Trim() == "" && tbMatKhau.Text.Trim() != "")
            {
                MessageBox.Show("Mời Bạn Nhập Tên Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMatKhau.Clear();
            }
            else if (dn.kiemTraTaiKhoan(taiKhoan, matKhau))
            {
                this.Hide();
                frmManHinhChinh.ShowDialog();
                tbMatKhau.Clear();
            }
            else 
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại Hoặc Tài Khoản, Mật Khẩu Không Chính Xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMatKhau.Clear();
            }
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            tbTaiKhoan.Text = "";
            tbMatKhau.Text = "";
        }
    }
}
