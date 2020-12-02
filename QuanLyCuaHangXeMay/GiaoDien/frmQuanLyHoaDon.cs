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
        }
    }
}
