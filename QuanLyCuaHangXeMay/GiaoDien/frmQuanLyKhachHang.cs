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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private frmChiTietHD frmChiTietHD = new frmChiTietHD();
        
        private void btMuaXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChiTietHD.ShowDialog();
            this.Show();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dlrThoat = MessageBox.Show("Bạn Có Chắc Muốn Thoát Khỏi Chương Trình?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dlrThoat == DialogResult.Yes)
                Application.Exit();
        }

        private void btNhapLai_Click_1(object sender, EventArgs e)
        {
            tbCMND.Text = "";
            tbDiaChi.Text = "";
            tbMaKH.Text = "";
            tbSDT.Text = "";
            tbTenKH.Text = "";
        }
    }
}
