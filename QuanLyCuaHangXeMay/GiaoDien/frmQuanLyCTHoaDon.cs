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
            lbXuatDiaChiKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[4].Text;
            lbXuatSDT.Text = frmQuanLyKhachHang.lvi_KH.SubItems[2].Text;
            lbXuatCMND.Text = frmQuanLyKhachHang.lvi_KH.SubItems[3].Text;
        }

        public string MaPhatSinhTuDong()
        {
            int count = CTHDC.danhSachHD().Count;
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
                /*lblDonGia.Text = lvDSXe.SelectedItems[0].SubItems[7].Text;*/
                lblMax.Text = lvDSXe.SelectedItems[0].SubItems[0].Text;
                nudSoLuong.Maximum = Convert.ToInt32(lvDSXe.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void lvXeDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudSoLuong.Enabled = false;
            btThem.Enabled = false;
            btHuy.Enabled = true;
            /*if (lvXeDaChon.SelectedItems.Count > 0)
            {
                lblMaCTHD.Text= lvXeDaChon.SelectedItems[0].SubItems[0].Text;
                lblDonGia.Text = lvXeDaChon.SelectedItems[0].SubItems[4].Text;
                lblMax.Text = lvXeDaChon.SelectedItems[0].SubItems[2].Text;;
            }*/
        }
        public void themHD()
        {
            List<ListViewItem> ds = TTNV.NhanTT();
            HoaDonXe hd = new HoaDonXe()
            {
                maHoaDon = MaPhatSinhTuDong(),
                maKhachHang = frmQuanLyKhachHang.lvi_KH.SubItems[0].Text,
                maNhanVien = ds[0].SubItems[0].Text
            };
            db.HoaDonXes.InsertOnSubmit(hd);

            /*CTHoaDonXe cthd = new CTHoaDonXe()
            {

                maHoaDon = lbXuatMaHoaDon.Text,
                maCTHoaDon = lblMaCTHD.Text,
                maXe = lblMax.Text,
                soLuong = Convert.ToInt32(nudSoLuong.Value.ToString()),
                donGia = Convert.ToDecimal(lblDonGia.Text),
                thanhTien = Convert.ToDecimal(lblDonGia.Text) * Convert.ToInt32(nudSoLuong.Value.ToString()),
                ngayLap = Convert.ToDateTime(dtmNgayHD.Value.ToString())
            };
            db.CTHoaDonXes.InsertOnSubmit(cthd);
            db.SubmitChanges();*/
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            decimal gia = Convert.ToDecimal(lvDSXe.SelectedItems[0].SubItems[7].Text);
            int sl = Convert.ToInt32(nudSoLuong.Value.ToString());
            decimal tong = gia * sl;
            lvi = new ListViewItem();
            lvi.Text = lvDSXe.SelectedItems.ToString();
            lvi.SubItems.Add(lbXuatMaHoaDon.Text);
            lvi.SubItems.Add(lvDSXe.SelectedItems[0].SubItems[1].Text);
            lvi.SubItems.Add(sl.ToString());
            lvi.SubItems.Add(gia.ToString());
            lvi.SubItems.Add(tong.ToString());
            lvi.SubItems.Add(dtmNgayHD.Value.ToString());
            CTHDController.cthd_moi = CTHDC.themCTHD(lvi);
            
            lvXeDaChon.Items.Add(CTHDController.cthd_moi);

            /*Xe x = new Xe();
            x = db.Xes.Where(s => s.maXe == lblMax.Text).Single();
            x.soLuong -= sl;
            db.SubmitChanges();*/
            int so = Convert.ToInt32(lvDSXe.SelectedItems[0].SubItems[3].Text);
            so -= sl;
            lvDSXe.SelectedItems[0].SubItems[3].Text = so.ToString();
            capNhap();
            /*if (x.soLuong >= nudSoLuong.Value)
            {
                

                MessageBox.Show("Them thanh cong");
                nudSoLuong.Value = 0;
            }
            else
            {
                MessageBox.Show("Khong du sl");
            }
            lblMaCTHD.Text = MaPhatSinhTuDongHD();
            tinh_tong_tien_listview();*/
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(lvXeDaChon.SelectedItems[0].SubItems[3].Text);
            lvi = lvXeDaChon.FindItemWithText(lvXeDaChon.SelectedItems[0].Text);
            lvXeDaChon.Items.Remove(lvXeDaChon.SelectedItems[0]);
            Xe x = new Xe();
            x = db.Xes.Where(s => s.maXe == lblMax.Text).Single();
            x.soLuong += sl;
            db.SubmitChanges();
            capNhap();
            /*CTHoaDonXe cthd = new CTHoaDonXe();
            cthd = db.CTHoaDonXes.Where(s => s.maCTHoaDon == lblMaCTHD.Text).Single();
            cthd.maHoaDon = lbXuatMaHoaDon.Text;
            cthd.maXe = lblMax.Text;
            cthd.soLuong = Convert.ToInt32(nudSoLuong.Value.ToString());
            cthd.donGia = Convert.ToDecimal(lblDonGia.Text);
            cthd.thanhTien = Convert.ToDecimal(lblDonGia.Text) * Convert.ToInt32(nudSoLuong.Value.ToString());
            cthd.ngayLap = Convert.ToDateTime(dtmNgayHD.Value.ToString());
            db.CTHoaDonXes.DeleteOnSubmit(cthd);

            Xe x = new Xe();
            x = db.Xes.Where(s => s.maXe == lblMax.Text).Single();
            x.soLuong += Convert.ToInt32(lvXeDaChon.SelectedItems[0].SubItems[3].Text);
            db.SubmitChanges();
            MessageBox.Show("Xoa thanh cong");*/
        }
        
        private void btLapHoaDon_Click(object sender, EventArgs e)
        {
            themHD();
            lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
            
                /*lvi = new ListViewItem();
                lvi.Text = lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
                lvi.SubItems.Add(Convert.ToString(lblMaXe.Text));
                lvi.SubItems.Add(Convert.ToInt32(nudSoLuong.Value).ToString());
                lvi.SubItems.Add(Convert.ToDecimal(lblDonGia.Text).ToString());
                lvi.SubItems.Add(Convert.ToDecimal(lblThanhTien.Text).ToString());
                lvi.SubItems.Add(dateNgayNhap.Text);
                CTHDC.themXeVaoCTHD(lvi, lblMaXe.Text, (int)nudSoLuong.Value, lblDonGia.Text, lblThanhTien.Text, dateNgayNhap);*/
                
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(lvXeDaChon.SelectedItems[0].Text);
            lvi = lvXeDaChon.FindItemWithText(lvXeDaChon.SelectedItems[0].Text);
            lvXeDaChon.Items.Remove(lvXeDaChon.SelectedItems[0]);
            Xe x = new Xe();
            x = db.Xes.Where(s => s.maXe == lblMax.Text).Single();
            x.soLuong += sl;
            db.SubmitChanges();
            this.Close();
        }
    }
}
