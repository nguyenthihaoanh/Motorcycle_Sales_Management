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
using QuanLyCuaHangXeMay.Model;

namespace QuanLyCuaHangXeMay
{
    public partial class frmChiTietHD : Form
    {
        private CTHDController CTHDC = new CTHDController();
        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private TTNhanVienController TTNV = new TTNhanVienController();
        private List<ListViewItem> dshd = new List<ListViewItem>();
        private XeController xe = new XeController();
        private ListViewItem lvi = new ListViewItem();
        private XeController xe_Controller = new XeController();
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
            /*foreach(ListViewItem lvi in lvCTHD.Items)
            {
                tong += Convert.ToDecimal(lvi.SubItems[4].Text);
            }
            lblTongTien.Text = tong.ToString();*/

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
            int count = CTHDC.lay_hd_theo_maKH().Count;
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
                nudSoLuong.Maximum = Convert.ToInt32(lvDSXe.SelectedItems[0].SubItems[3].Text);
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
            decimal gia = Convert.ToDecimal(lvDSXe.SelectedItems[0].SubItems[7].Text);
            int sl = Convert.ToInt32(nudSoLuong.Value.ToString());
            decimal tong = gia * sl;
            lvi = new ListViewItem();
            lvi.Text = lbXuatMaHoaDon.Text + "-" + RandomInt();
            lvi.SubItems.Add(lbXuatMaHoaDon.Text);
            lvi.SubItems.Add(lvDSXe.SelectedItems[0].SubItems[1].Text);
            lvi.SubItems.Add(sl.ToString());
            lvi.SubItems.Add(gia.ToString());
            lvi.SubItems.Add(tong.ToString());
            lvi.SubItems.Add(dtmNgayHD.Value.ToString());
            lvi.SubItems.Add(lvDSXe.SelectedItems[0].SubItems[0].Text);
            CTHDController.cthd_moi = CTHDC.themCTHD(lvi);
            lvXeDaChon.Items.Add(CTHDController.cthd_moi);

            Xe x = new Xe();
            x = db.Xes.Where(s => s.maXe == lvDSXe.SelectedItems[0].SubItems[0].Text).Single();
            x.soLuong -= sl;
            db.SubmitChanges();
            capNhap();
            nudSoLuong.Value = 0;
        }

        private void btHuy_Click(object sender, EventArgs e)
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
        
        private void btLapHoaDon_Click(object sender, EventArgs e)
        {
            if (lvXeDaChon.Items.Count > 1)
            {
                CTHDC.Luu_HD(lvXeDaChon.Items, lbXuatMaHoaDon.Text, dtmNgayHD);
                this.Close();
                lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
            }

            else
                MessageBox.Show("Hóa đơn chưa có sản phẩm nào");                
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            if (lvXeDaChon.Items.Count == 0)
                this.Close();
             else    
            MessageBox.Show("Moi Ban Huy Tat Ca Loai Xe Da Chon");
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
    }
}
