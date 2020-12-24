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
    public partial class frmQuanLyHoaDon : Form
    {
        private HDController HDC = new HDController();
        private List<ListViewItem> dshd = new List<ListViewItem>();
        public static ListViewItem lvi { get; private set; } = new ListViewItem();
        decimal tong = 0;
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dshd.Clear();
            lvHD.Items.Clear();
            dshd = HDC.danhSachHD();
            foreach (ListViewItem hd in dshd)
            {
                lvHD.Items.Add(hd);
            }
            tinh_tong_tien_listview();
        }
        private void tinh_tong_tien_listview()
        {
            tong = 0;
            foreach (ListViewItem lvi in lvHD.Items)
            {
                tong += Convert.ToDecimal(lvi.SubItems[8].Text);
            }
            lblTongTien.Text = tong.ToString();
        }
        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            dshd.Clear();
            lvHD.Items.Clear();
            dshd = HDC.TimKiem(tbTim.Text);
            foreach (ListViewItem hd in dshd)
            {
                lvHD.Items.Add(hd);
            }
            dshd = HDC.TimKiemTheoHD(tbTim.Text);
            foreach (ListViewItem hd in dshd)
            {
                lvHD.Items.Add(hd);
            }
            tinh_tong_tien_listview();
        }

        private void lvHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHD.SelectedItems.Count > 0)
            {
                lvi = lvHD.SelectedItems[0];
            }
        }
    }
}
