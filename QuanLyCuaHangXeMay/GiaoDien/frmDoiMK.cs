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
            /*if (dangNhapController.kiemTraMk(DangNhapController.maNV, tbMkCu.Text.GetHashCode().ToString()))
            {
                if (tbNhapLaiMk.Text == tbMkMoi.Text)
                {
                    if (tbNhapLaiMk.Text.Length > 0)
                    {
                        dangNhapController.kiemTraMk(DangNhapController.maNV, tbMkCu.Text.GetHashCode().ToString());
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Mật khẩu không được để trống");
                }
                else
                    MessageBox.Show("Mật mã nhập lại không trùng khớp");
            }
            else
                MessageBox.Show("Sai mật khẩu cũ");*/
        }

        private void frmDoiMK_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
