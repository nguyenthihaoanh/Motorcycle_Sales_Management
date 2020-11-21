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

namespace QuanLyCuaHangXeMay.GiaoDien
{
    public partial class frmDoiMK : Form
    {
        private DangNhapController dangNhapController = new DangNhapController();
        public frmDoiMK()
        {
            InitializeComponent();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (dangNhapController.kiemTraMK(DangNhapController.maNV, tbMkCu.Text.ToString()))
            {
                if (tbNhapLaiMk.Text == tbMkMoi.Text)
                {
                    if (tbNhapLaiMk.Text.Length > 0)
                    {
                        dangNhapController.thayDoiMK(DangNhapController.maNV, tbMkMoi.Text.ToString());
                        MessageBox.Show("Thay Đổi Mật Khẩu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        tbMkCu.Clear();
                        tbMkMoi.Clear();
                        tbNhapLaiMk.Clear();
                    }
                    else
                        MessageBox.Show("Mật Khẩu Không Được Để Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật Mã Nhập Lại Không Trùng Khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMkMoi.Clear();
                    tbNhapLaiMk.Clear();
                }
            }
            else
            {
                MessageBox.Show("Sai Mật Khẩu Cũ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMkCu.Clear();
                tbMkMoi.Clear();
                tbNhapLaiMk.Clear();
            }
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
