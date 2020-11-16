using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManHinhChinh.ShowDialog();
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            tbTaiKhoan.Text = "";
            tbMatKhau.Text = "";
        }

        private void btNhapLai_Click_1(object sender, EventArgs e)
        {
            tbTaiKhoan.Text = "";
            tbMatKhau.Text = "";
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Bạn có chắc là muốn thoát khỏi ứng dụng", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else */

        }
    }
}
