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

namespace QuanLyCuaHangXeMay.GiaoDien
{
    public partial class frmThemMauXe : Form
    {
        private MauXeConntroller mauXeConntroller = new MauXeConntroller();
        private List<ListViewItem> list_mx = new List<ListViewItem>();
        public static ListViewItem lvi_mx { get; private set; } = new ListViewItem();
        public frmThemMauXe()
        {
            InitializeComponent();
        }
        public string MaPhatSinhTuDong()
        {
            int count = mauXeConntroller.danhSachMX().Count;
            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                chuoi = "M00" + stt.ToString();
            else if (stt < 100)
                chuoi = "M0" + stt.ToString();
            else if (stt < 1000)
                chuoi = "M" + stt.ToString();
            return chuoi;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi_mx = new ListViewItem();
            lvi_mx.Text = tbMaMau.Text = MaPhatSinhTuDong();
            lvi_mx.SubItems.Add(tbTenMau.Text);
            mauXeConntroller.them(lvi_mx);
            MessageBox.Show("Thêm Thành Công");
            this.Close();
        }

        private void frmThemMauXe_Load(object sender, EventArgs e)
        {
            tbMaMau.Text = MaPhatSinhTuDong();
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            tbTenMau.Text = MaPhatSinhTuDong();
            tbMaMau.Text = "";
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
