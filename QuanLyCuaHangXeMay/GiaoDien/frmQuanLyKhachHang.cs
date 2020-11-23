using QuanLyCuaHangXeMay.Controller;
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
        private List<ListViewItem> list_KH = new List<ListViewItem>();
        private KhachHangController kh_Controller = new KhachHangController();
        private TTNhanVienController TTNV = new TTNhanVienController();
        public static ListViewItem lvi_KH { get; private set; } = new ListViewItem();
        public static bool flag_ncc { get; private set; } = true;
        private frmChiTietHD frmChiTietHD = new frmChiTietHD();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            List<ListViewItem> ds = TTNV.NhanTT();
            lbTenNhanVien.Text = ds[0].SubItems[1].Text;
            capNhap();
            lvKH.Items.Clear();
            list_KH = kh_Controller.danhSachNV();
            foreach (ListViewItem nsx in list_KH)
            {
                lvKH.Items.Add(nsx);
            }
            btLuu.Enabled = false;
            btSua.Enabled = false;
            btMuaXe.Enabled = false;
            enables_txt(false);
        }

        private void lvKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKH.SelectedItems.Count > 0)
            {
                lvi_KH = lvKH.SelectedItems[0];
                tbMaKH.Text = lvi_KH.SubItems[0].Text;
                tbTenKH.Text = lvi_KH.SubItems[1].Text;
                tbSDT.Text = lvi_KH.SubItems[2].Text;
                tbCMND.Text = lvi_KH.SubItems[3].Text;
                tbDiaChi.Text = lvi_KH.SubItems[4].Text;
                btThem.Enabled = false;
                btSua.Enabled = true;
                btMuaXe.Enabled = true;
            }
        }
        private void enables_txt(bool active)
        {
            tbCMND.Enabled = tbDiaChi.Enabled = tbSDT.Enabled = tbTenKH.Enabled = active;
        }
        public string MaPhatSinhTuDong()
        {
            int count = lvKH.Items.Count;
            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                chuoi = "KH00" + stt.ToString();
            else if (stt < 100)
                chuoi = "KH0" + stt.ToString();
            else if (stt < 1000)
                chuoi = "KH" + stt.ToString();
            return chuoi;
        }

        private void capNhap()
        {
            lvKH.Items.Clear();
            list_KH = kh_Controller.danhSachNV();
            foreach (ListViewItem nv in list_KH)
            {
                lvKH.Items.Add(nv);
            }
        }

        private void btMuaXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChiTietHD.ShowDialog();
            this.Show();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNhapLai_Click_1(object sender, EventArgs e)
        {
            tbCMND.Text = "";
            tbDiaChi.Text = "";
            tbMaKH.Text = "";
            tbSDT.Text = "";
            tbTenKH.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            flag_ncc = true;
            if (!btThem.Text.Equals("Hủy Thêm"))
            {
                btThem.Text = "Hủy Thêm";
                btLuu.Enabled = true;
                enables_txt(true);
                btSua.Enabled = false;
                btMuaXe.Enabled = false;
            }
            else
            {
                btThem.Text = "Thêm";
                btLuu.Enabled = false;
                btSua.Enabled = false;
                enables_txt(false);
                btMuaXe.Enabled = false;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            flag_ncc = false;
            if (!btSua.Text.Equals("Hủy Sửa"))
            {
                btSua.Text = "Hủy Sửa";
                btLuu.Enabled = true;
                enables_txt(true);
                btThem.Enabled = false;
                btMuaXe.Enabled = false;
            }
            else
            {
                btSua.Text = "Sửa";
                btLuu.Enabled = false;
                btThem.Enabled = true;
                enables_txt(false);
                btMuaXe.Enabled = false;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            lvi_KH = new ListViewItem();
            lvi_KH.Text = tbMaKH.Text;
            lvi_KH.SubItems.Add(tbTenKH.Text);
            lvi_KH.SubItems.Add(tbDiaChi.Text);
            lvi_KH.SubItems.Add(tbSDT.Text);
            lvi_KH.SubItems.Add(tbCMND.Text);
            if (flag_ncc == true)
            {
                lvi_KH.Text = tbMaKH.Text = MaPhatSinhTuDong();
                kh_Controller.themTTNV(lvi_KH);
                capNhap();
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
            }
            else
            {
                kh_Controller.suaTTNV(lvi_KH);
                capNhap();
                MessageBox.Show("Sửa Thành Công", "Thông Báo");
            }
        }
    }
}
