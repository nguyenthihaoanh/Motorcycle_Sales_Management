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
            if (dangNhapController.kiemTraMK(DangNhapController.maNV, tbMkCu.Text.GetHashCode().ToString()))
            {
                if (tbMkMoi.Text != "" && tbNhapLaiMk.Text != "")
                {
                    if (tbMkMoi.Text.ToString().Length >= 3 || tbNhapLaiMk.Text.ToString().Length >= 3)
                    {
                        if (tbNhapLaiMk.Text.GetHashCode().ToString() == tbMkMoi.Text.GetHashCode().ToString())
                        {
                            if (tbMkMoi.Text.GetHashCode().ToString() != tbMkCu.Text.GetHashCode().ToString())
                            {
                                dangNhapController.thayDoiMK(DangNhapController.maNV, tbMkMoi.Text.GetHashCode().ToString());
                                MessageBox.Show("Thay Đổi Mật Khẩu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                tbMkCu.Clear();
                                tbMkMoi.Clear();
                                tbNhapLaiMk.Clear();
                            }
                            MessageBox.Show("Nhập Mật Khẩu Khác Với Mật Khẩu Cũ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật Mã Nhập Lại Không Trùng Khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbMkMoi.Clear();
                            tbNhapLaiMk.Clear();
                        }
                    }
                    else
                        MessageBox.Show("Mật Khẩu Chứa Từ 3 Ký Tự Trở Lên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mật Khẩu Không Được Để Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
