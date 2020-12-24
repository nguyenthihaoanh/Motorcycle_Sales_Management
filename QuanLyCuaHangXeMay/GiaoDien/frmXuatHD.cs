using QuanLyCuaHangXeMay.Controller;
using QuanLyCuaHangXeMay.GiaoDien;
using QuanLyCuaHangXeMay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.GiaoDien
{
    public partial class frmXuatHD : Form
    {
        private TTNhanVienController TTNV = new TTNhanVienController();
        private List<ListViewItem> dshd = new List<ListViewItem>();
        private CTHDController CTHDC = new CTHDController();
        decimal tong = 0;
        public frmXuatHD()
        {
            InitializeComponent();
        }

        private void frmXuatHD_Load(object sender, EventArgs e)
        {
            List<ListViewItem> ds = TTNV.NhanTT();
            lbXuatTenNV.Text = ds[0].SubItems[1].Text;
            dtmNgayHD.Value = DateTime.Today;
            lbXuatMaHoaDon.Text = frmChiTietHD.lvi.SubItems[0].Text;
            thongTinKH();
            capNhap();
            tinh_tong_tien_listview();
        }
        private void tinh_tong_tien_listview()
        {
            tong = 0;
            foreach (ListViewItem lvi in lvXeDaChon.Items)
            {
                tong += Convert.ToDecimal(lvi.SubItems[6].Text);
            }
            lblTongTien.Text = tong.ToString();
        }
        private void thongTinKH()
        {
            lbXuatTenKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[1].Text;
            lbXuatDiaChiKH.Text = frmQuanLyKhachHang.lvi_KH.SubItems[2].Text;
            lbXuatSDT.Text = frmQuanLyKhachHang.lvi_KH.SubItems[4].Text;
            lbXuatCMND.Text = frmQuanLyKhachHang.lvi_KH.SubItems[3].Text;
        }
        private void capNhap()
        {
            tong = 0;
            dshd.Clear();
            lvXeDaChon.Items.Clear();
            dshd = CTHDC.danhSachCTHD(lbXuatMaHoaDon.Text);
            foreach (ListViewItem ncc in dshd)
            {
                lvXeDaChon.Items.Add(ncc);
            }
        }

        private void btInHD_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 12);
            float fortHeight = font.GetHeight();
            int startx = 120;
            int starty = 100;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("\t\tCửa Hàng Xe Máy", new Font("Times New Roman", 22), new SolidBrush(Color.Black), startx, starty);
            offset = offset + (int)FontHeight;
            string top = "\t\t\t\t\t\t\tDate: " + dtmNgayHD.Text.PadLeft(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("\t\t\t\t\t\t\tTên NV: " + lbXuatTenNV.Text.PadLeft(5), font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("\t\t\t\t\t\t\tMã Hóa Đơn: " + lbXuatMaHoaDon.Text.PadLeft(5), font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("\t\t\tTên Khách Hàng: " + lbXuatTenKH.Text.PadLeft(5), font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("\t\t\tĐịa Chỉ: " + lbXuatDiaChiKH.Text.PadLeft(5), font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("-----------------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Mã Xe\t Nhãn Hiệu   Màu Xe      Nước Sản Xuất   Số Lượng    Đơn Giá\t     Thành Tiền" , font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            for (int x = 0; x < lvXeDaChon.Items.Count; x++)
            {
                graphics.DrawString(lvXeDaChon.Items[x].SubItems[0].Text + "\t" + lvXeDaChon.Items[x].SubItems[1].Text + "\t\t" + lvXeDaChon.Items[x].SubItems[2].Text + "\t" + lvXeDaChon.Items[x].SubItems[3].Text + "\t\t" + lvXeDaChon.Items[x].SubItems[4].Text + "        " + lvXeDaChon.Items[x].SubItems[5].Text + "\t" + lvXeDaChon.Items[x].SubItems[6].Text, font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 20;
            }
            offset = offset + (int)FontHeight + 5;
            graphics.DrawString("-----------------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("Tổng Tiền Thanh Toán: " + lblTongTien.Text.PadLeft(5), font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
        }

        private void lvXeDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
