using QuanLyCuaHangXeMay.Controller;
using QuanLyCuaHangXeMay.Model;
using QuanLyCuaHangXeMay.GiaoDien;
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
    public partial class frmQuanLyXe : Form
    {
        private frmThemMauXe frmMau = new frmThemMauXe();
        private List<ListViewItem> ds = new List<ListViewItem>();
        private List<string> dsncc = new List<string>();
        private List<string> dsnsx = new List<string>();
        private List<string> dsmau = new List<string>();
        private XeController xe_Controller = new XeController();
        private TTNhanVienController TTNV = new TTNhanVienController();
        public static ListViewItem lvi_Xe { get; private set; } = new ListViewItem();
        public static bool flag_xe { get; private set; } = true;
        private frmChiTietHD frmChiTietHD = new frmChiTietHD();
        public frmQuanLyXe()
        {
            InitializeComponent();
        }

        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            List<ListViewItem> tenNV = TTNV.NhanTT();
            lbTenNhanVien.Text = tenNV[0].SubItems[1].Text;
            capNhapXe();
            capNhapNCC();
            capNhapNSX();
            capNhapMauXe();
            btLuu.Enabled = false;
            btSua.Enabled = false;
            enables_txt(false);
        }
        private void capNhapMauXe()
        {
            dsmau.Clear();
            cbMauXe.Items.Clear();
            dsmau = xe_Controller.ds_mau();
            foreach (var mau in dsmau)
            {
                cbMauXe.Items.Add(mau);
            }
        }
        private void capNhapNSX()
        {
            dsnsx.Clear();
            cbNSX.Items.Clear();
            dsnsx = xe_Controller.ds_nsx();
            foreach (var nsx in dsnsx)
            {
                cbNSX.Items.Add(nsx);
            }
        }
        private void capNhapNCC()
        {
            dsncc.Clear();
            cbNCC.Items.Clear();
            dsncc = xe_Controller.ds_ncc();
            foreach (var ncc in dsncc)
            {
                cbNCC.Items.Add(ncc);
            }
        }
        private void capNhapXe()
        {
            ds.Clear();
            lvXe.Items.Clear();
            ds = xe_Controller.them_ds_xe();
            foreach (ListViewItem xe in ds)
            {
                lvXe.Items.Add(xe);
            }
        }

        private void lvXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvXe.SelectedItems.Count > 0)
            {
                lvi_Xe = lvXe.SelectedItems[0];
                txtMaXe.Text = lvi_Xe.SubItems[0].Text;
                txtNhanHieu.Text = lvi_Xe.SubItems[1].Text;
                cbMauXe.Text = lvi_Xe.SubItems[2].Text;
                tbDungTich.Text = lvi_Xe.SubItems[3].Text;
                cbNCC.Text = lvi_Xe.SubItems[4].Text;
                cbNSX.Text = lvi_Xe.SubItems[5].Text;
                tbSoLuong.Text = lvi_Xe.SubItems[6].Text;
                tbGiaNhap.Text = lvi_Xe.SubItems[7].Text;
                dateNgayNhap.Text = lvi_Xe.SubItems[8].Text;
                btThem.Enabled = false;
                btSua.Enabled = true;
            }
        }
        private void enables_txt(bool active)
        {
            txtNhanHieu.Enabled = cbMauXe.Enabled = tbDungTich.Enabled = cbNSX.Enabled = cbNCC.Enabled = tbSoLuong.Enabled = tbGiaNhap.Enabled = active;
        }
        public string MaPhatSinhTuDong()
        {
            int count = lvXe.Items.Count;
            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                chuoi = "Xe00" + stt.ToString();
            else if (stt < 100)
                chuoi = "Xe0" + stt.ToString();
            else if (stt < 1000)
                chuoi = "Xe" + stt.ToString();
            return chuoi;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nhaplai()
        {
            tbDungTich.Text = "";
            tbGiaNhap.Text = "";
            txtMaXe.Text = MaPhatSinhTuDong();
            txtNhanHieu.Text = "";
            tbSoLuong.Text = "";
            tbGiaNhap.Text = "";
        }
        private void btNhapLai_Click(object sender, EventArgs e)
        {
            nhaplai();
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            capNhapMauXe();
            flag_xe = true;
            if (!btThem.Text.Equals("Hủy Thêm"))
            {
                btThem.Text = "Hủy Thêm";
                btLuu.Enabled = true;
                enables_txt(true);
                btSua.Enabled = false;
            }
            else
            {
                btThem.Text = "Thêm";
                btLuu.Enabled = false;
                btSua.Enabled = false;
                enables_txt(false);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            capNhapMauXe();
            flag_xe = false;
            if (!btSua.Text.Equals("Hủy Sửa"))
            {
                btSua.Text = "Hủy Sửa";
                btLuu.Enabled = true;
                enables_txt(true);
                btThem.Enabled = false;
            }
            else
            {
                btSua.Text = "Sửa";
                btLuu.Enabled = false;
                btThem.Enabled = true;
                enables_txt(false);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (lvXe.Items.Count > 0)
            {
                lvi_Xe = new ListViewItem();
                lvi_Xe.Text = txtMaXe.Text;
                lvi_Xe.SubItems.Add(txtNhanHieu.Text);
                lvi_Xe.SubItems.Add(Convert.ToInt32(tbSoLuong.Text).ToString());
                lvi_Xe.SubItems.Add(Convert.ToDecimal(tbGiaNhap.Text).ToString());
                lvi_Xe.SubItems.Add(Convert.ToInt32(tbDungTich.Text).ToString());
                lvi_Xe.SubItems.Add(cbMauXe.SelectedItem.ToString());
                lvi_Xe.SubItems.Add(cbNCC.SelectedItem.ToString());
                lvi_Xe.SubItems.Add(cbNSX.SelectedItem.ToString());
                lvi_Xe.SubItems.Add(dateNgayNhap.Text);
                if (flag_xe == true)
                {
                    lvi_Xe.Text = txtMaXe.Text = MaPhatSinhTuDong();
                    xe_Controller.themTTXe(lvi_Xe, tbSoLuong.Text, tbDungTich.Text, tbGiaNhap.Text, dateNgayNhap, cbMauXe.SelectedItem.ToString(), cbNCC.SelectedItem.ToString(), cbNSX.SelectedItem.ToString());
                    capNhapXe();
                    MessageBox.Show("Thêm Thành Công"); 
                    btThem.Text = "Thêm";
                    nhaplai();
                    enables_txt(false);
                }
                else
                {
                    xe_Controller.suaTTXe(lvi_Xe, tbSoLuong.Text, tbDungTich.Text, tbGiaNhap.Text, dateNgayNhap, cbMauXe.SelectedItem.ToString(), cbNCC.SelectedItem.ToString(), cbNSX.SelectedItem.ToString());
                    capNhapXe();
                    MessageBox.Show("Sửa Thành Công");
                    btSua.Text = "Sửa";
                    nhaplai();
                    enables_txt(false);
                }
            }
            else MessageBox.Show("Nhap du lieu");
        }

        private void btMauXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMau.ShowDialog();
            this.Show();
        }

        private void cbMauXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
