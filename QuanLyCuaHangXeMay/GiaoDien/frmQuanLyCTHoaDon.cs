using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangXeMay.Controller;
using QuanLyCuaHangXeMay.GiaoDien;
using QuanLyCuaHangXeMay.Model;

namespace QuanLyCuaHangXeMay
{
    public partial class frmChiTietHD : Form
    {
        private CTHDController CTHDC = new CTHDController();
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private TTNhanVienController TTNV = new TTNhanVienController();
        private XeController xe = new XeController();
        public static ListViewItem lvi { get; private set; } = new ListViewItem();
        private XeController xe_Controller = new XeController();
        private List<ListViewItem> dshd = new List<ListViewItem>();
        decimal tong = 0;
        public frmChiTietHD()
        {
            InitializeComponent();
        }
        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            nudSoLuong.Enabled = false;
            btThem.Enabled = false;
            btHuy.Enabled = false;

            List<ListViewItem> ds = TTNV.NhanTT();
            lbXuatTenNV.Text = ds[0].SubItems[1].Text;
            dtmNgayHD.Value = DateTime.Today;
            thongTinKH();
            lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
            capNhap();
            tinh_tong_tien_listview();
        }
        private void tinh_tong_tien_listview()
        {
            tong = 0;
            foreach (ListViewItem lvi in lvXeDaChon.Items)
            {
                tong += Convert.ToDecimal(lvi.SubItems[5].Text);
            }
            lblTongTien.Text = tong.ToString();
        }
        private void capNhap()
        {
            tong = 0;
            dshd.Clear();
            lvDSXe.Items.Clear();
            dshd = xe.them_ds_xe();
            foreach (ListViewItem ncc in dshd)
            {
                lvDSXe.Items.Add(ncc);
            }
        }
        private void thongTinKH()
        {
            lbXuatTenKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[1].Text;
            lbXuatDiaChiKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[2].Text;
            lbXuatSDT.Text = frmQuanLyKhachHang.lvi_KH.SubItems[4].Text;
            lbXuatCMND.Text = frmQuanLyKhachHang.lvi_KH.SubItems[3].Text;
        }

        public string MaPhatSinhTuDong()
        {
            int count = CTHDC.ds_hd().Count;
            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                chuoi = "HD00" + stt.ToString();
            else if (stt < 100)
                chuoi = "HD0" + stt.ToString();
            else if (stt < 1000)
                chuoi = "HD" + stt.ToString();
            return chuoi;
        }
        private void lvDSXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            btHuy.Enabled = false;
            if (lvDSXe.SelectedItems.Count > 0)
            {
                nudSoLuong.Enabled = true;
                foreach (ListViewItem lvi_xe_chon in lvXeDaChon.Items)
                {
                        if (lvDSXe.SelectedItems[0].SubItems[0].Text == lvi_xe_chon.SubItems[7].Text)
                        {
                            nudSoLuong.Maximum = Convert.ToInt32(lvDSXe.SelectedItems[0].SubItems[3].Text) - Convert.ToInt32(lvi.SubItems[3].Text);
                        }
                }
            }
        }

        private void lvXeDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudSoLuong.Enabled = false;
            btThem.Enabled = false;
            btHuy.Enabled = true;
        }
        
        private int RandomInt()
        {
            Random rand = new Random();
            int number2 = rand.Next(1, 999);
            return number2;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (nudSoLuong.Value > 0)
            {
                decimal gia = Convert.ToDecimal(lvDSXe.SelectedItems[0].SubItems[7].Text);
                int sl = Convert.ToInt32(nudSoLuong.Value.ToString());
                decimal tong = gia * sl;
                lvi = new ListViewItem();
                lvi.Text = lbXuatMaHoaDon.Text;
                lvi.SubItems.Add(lvDSXe.SelectedItems[0].SubItems[0].Text);
                lvi.SubItems.Add(lvDSXe.SelectedItems[0].SubItems[1].Text);
                lvi.SubItems.Add(sl.ToString());
                lvi.SubItems.Add(gia.ToString());
                lvi.SubItems.Add(tong.ToString());
                lvi.SubItems.Add(dtmNgayHD.Value.ToShortDateString());
                lvi.SubItems.Add(lvDSXe.SelectedItems[0].SubItems[0].Text);
                CTHDController.cthd_moi = CTHDC.themCTHD(lvi);
                lvXeDaChon.Items.Add(CTHDController.cthd_moi);
                Xe x = new Xe();
                x = db.Xes.Where(s => s.maXe == lvDSXe.SelectedItems[0].SubItems[0].Text).Single();
                x.soLuong -= sl;
                db.SubmitChanges();
                capNhap();
                lvDSXe.SelectedItems.Clear();
                nudSoLuong.Enabled = false;
                nudSoLuong.Value = 0;
                tinh_tong_tien_listview();
            }
            else
                MessageBox.Show("Nhập Số Lượng Lớn Hơn 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (lvXeDaChon.Items.Count > 0)
            {
                int sl = Convert.ToInt32(lvXeDaChon.SelectedItems[0].SubItems[3].Text);
                Xe x = new Xe();
                x = db.Xes.Where(s => s.maXe == lvXeDaChon.SelectedItems[0].SubItems[7].Text).Single();
                x.soLuong += sl;
                db.SubmitChanges();
                lvi = lvXeDaChon.FindItemWithText(lvXeDaChon.SelectedItems[0].Text);
                lvXeDaChon.Items.Remove(lvXeDaChon.SelectedItems[0]);
                capNhap();
            }
        }

        private void btLapHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đã Lập Hóa Đơn Thì Không Thể Hủy Hóa Đơn!!!", "Thông Báo", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                if (lvXeDaChon.Items.Count > 0)
                {
                    CTHDC.Luu_HD(lvXeDaChon.Items, lbXuatMaHoaDon.Text, dtmNgayHD);
                    lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
                    lvXeDaChon.Items.Clear();
                    frmXuatHD frmXuatHD = new frmXuatHD();
                    this.Hide();
                    frmXuatHD.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Hóa đơn chưa có sản phẩm nào");
            }
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi_xe_chon in lvXeDaChon.Items)
            {
                foreach (ListViewItem lvi_dsXe in lvDSXe.Items)
                    if (lvi_dsXe.SubItems[0].Text == lvi_xe_chon.SubItems[7].Text)
                    {
                        Xe x = new Xe();
                        x = db.Xes.Where(s => s.maXe == lvi_dsXe.SubItems[0].Text).Single();
                        x.soLuong += Convert.ToInt32(lvi.SubItems[3].Text);
                        db.SubmitChanges();
                    }
            }
            this.Close();
            lvXeDaChon.Items.Clear();
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            lvDSXe.Items.Clear();
            dshd = new List<ListViewItem>();
            dshd = xe_Controller.TimKiem(tbTim.Text);
            foreach (ListViewItem xe in dshd)
            {
                lvDSXe.Items.Add(xe);
            }
        }

        private void frmChiTietHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (ListViewItem lvi_xe_chon in lvXeDaChon.Items)
            {
                foreach (ListViewItem lvi_dsXe in lvDSXe.Items)
                    if (lvi_dsXe.SubItems[0].Text == lvi_xe_chon.SubItems[7].Text)
                    {
                        Xe x = new Xe();
                        x = db.Xes.Where(s => s.maXe == lvi_dsXe.SubItems[0].Text).Single();
                        x.soLuong += Convert.ToInt32(lvi.SubItems[3].Text);
                        db.SubmitChanges();
                    }
            }
            this.Close();
            lvXeDaChon.Items.Clear();
        }
    }
}
