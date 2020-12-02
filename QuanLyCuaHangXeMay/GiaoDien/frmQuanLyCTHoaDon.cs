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
        decimal tong = 0;
        public frmChiTietHD()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            load_data_vao_cb();
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
            load_data_vao_cb();
            dshd.Clear();
            lvCTHD.Items.Clear();
            dshd = xe.them_ds_xe();
            foreach (ListViewItem ncc in dshd)
            {
                lvCTHD.Items.Add(ncc);
            }
        }
        private void thongTinKH()
        {
            lbXuatTenKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[1].Text;
            lbXuatDiaChiKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[4].Text;
            lbXuatSDT.Text = frmQuanLyKhachHang.lvi_KH.SubItems[2].Text;
            lbXuatCMND.Text = frmQuanLyKhachHang.lvi_KH.SubItems[3].Text;
        }

        private void load_data_vao_cb()
        {
            var xe = db.Xes.Where(x => x.soLuong != 0);
            cbTenXe.DisplayMember = "nhanHieu";
            cbTenXe.ValueMember = "maXe";
            cbTenXe.DataSource = xe.GroupBy(x => x.nhanHieu).Where(x => x.Count() > 0).Select(x => x.Key).ToList();/*;*/
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
        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal gia= Convert.ToDecimal(lblDonGia.Text);
            int sl = Convert.ToInt32(nudSoLuong.Value);
            decimal thanhTien = gia * sl;
            lblThanhTien.Text = thanhTien.ToString();
        }

        private void cbTenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nsx = (from x in db.Xes
                       join n in db.NhaSanXuats on x.maNSX equals n.maNSX
                       select new
                       {
                           x.nhanHieu,
                           x.soLuong,
                           n.tenNSX,
                           n.nuocSX,
                           n.maNSX
                       }).Where(x => x.soLuong != 0 && x.nhanHieu.Equals(cbTenXe.SelectedValue.ToString())).ToList();
            
            cbNuocSX.DisplayMember = "nuocSX";
            cbNuocSX.ValueMember = "maNSX";
            cbNuocSX.DataSource = nsx.GroupBy(x => x.nuocSX).Where(x => x.Count() > 0).Select(x => x.Key).ToList();

        }

        private void cbNuocSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mau = (from m in db.Xes
                       join n in db.NhaSanXuats on m.maNSX equals n.maNSX
                       join x in db.MauXes on m.maMau equals x.maMau
                       select new
                       {
                           m.nhanHieu,
                           m.soLuong,
                           n.nuocSX,
                           m.maMau,
                           x.tenMau
                       }).Where(x => x.soLuong != 0 && x.nhanHieu.Equals(cbTenXe.SelectedValue.ToString()) && x.nuocSX.Equals(cbNuocSX.SelectedValue.ToString())).ToList();
            cbMauXe.DisplayMember = "tenMau";
            cbMauXe.ValueMember = "maMau";
            cbMauXe.DataSource = mau;
        }

        private void cbMauXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Xe obj = db.Xes.FirstOrDefault(x => x.nhanHieu.Equals(cbTenXe.SelectedValue.ToString()) && x.maMau.Equals(cbMauXe.SelectedValue.ToString()));
            if (obj != null)
            {
                lblMaXe.Text = obj.maXe;
                lblDungTich.Text = obj.dungTich.ToString();
                lblNCC.Text = obj.NhaCungCap.tenNCC;
                lblNSX.Text = obj.NhaSanXuat.tenNSX;
                lblDonGia.Text = Convert.ToString(obj.giaNhap * 15 / 100);
            }
             nudSoLuong.Maximum=obj.soLuong;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            Xe x = new Xe();

            x = db.Xes.Where(s => s.maXe == lblMaXe.Text).Single();
            if (x.soLuong >= nudSoLuong.Value)
            {
                List<ListViewItem> ds = TTNV.NhanTT();
                /*lvi = new ListViewItem();
                lvi.Text = lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
                lvi.SubItems.Add(frmQuanLyKhachHang.lvi_KH.SubItems[0].Text);
                lvi.SubItems.Add(frmQuanLyNhanVien.lvi_nv.SubItems[0].Text);*/
                HoaDonXe hd = new HoaDonXe()
                {
                    maHoaDon = MaPhatSinhTuDong(),
                    maKhachHang = frmQuanLyKhachHang.lvi_KH.SubItems[0].Text,
                    maNhanVien = ds[0].SubItems[0].Text
                };
                db.HoaDonXes.InsertOnSubmit(hd);

                CTHoaDonXe cthd = new CTHoaDonXe()
                {
                    maHoaDon = lbXuatMaHoaDon.Text,
                    maXe = lblMaXe.Text,
                    soLuong = Convert.ToInt32(nudSoLuong.Value.ToString()),
                    donGia = Convert.ToDecimal(lblDonGia.Text),
                    thanhTien = Convert.ToDecimal(lblThanhTien.Text),
                    ngayLap = Convert.ToDateTime(dateNgayNhap.Value.ToString())
                };
                db.CTHoaDonXes.InsertOnSubmit(cthd);
            
                x.soLuong -= Convert.ToInt32(nudSoLuong.Value);
                db.SubmitChanges();
                MessageBox.Show("Them thanh cong");
                nudSoLuong.Value = 0;
            }
            else
            {
                MessageBox.Show("Khong du sl");
            }
            /*lvi = new ListViewItem();
            lvi.Text = lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
            lvi.SubItems.Add(Convert.ToString(lblMaXe.Text));
            lvi.SubItems.Add(Convert.ToInt32(nudSoLuong.Value).ToString());
            lvi.SubItems.Add(Convert.ToDecimal(lblDonGia.Text).ToString());
            lvi.SubItems.Add(Convert.ToDecimal(lblThanhTien.Text).ToString());
            lvi.SubItems.Add(dateNgayNhap.Text);
            CTHDC.themXeVaoCTHD(lvi, lblMaXe.Text, (int)nudSoLuong.Value, lblDonGia.Text, lblThanhTien.Text, dateNgayNhap);*/
            lbXuatMaHoaDon.Text = MaPhatSinhTuDong();
            capNhap();
            tinh_tong_tien_listview();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
