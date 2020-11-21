using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangXeMay.Controller;

namespace QuanLyCuaHangXeMay
{
    public partial class frmQuanLyNhaCungCap : Form
    {
        private List<ListViewItem> list_NCC = new List<ListViewItem>();
        private NCC_Controller ncc_Controller = new NCC_Controller();
        public static bool flag_nv { get; private set; } = true;
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        private void enables_txt(bool active)
        {
            tbTenNCC.Enabled = tbDiaChi.Enabled = tbEmail.Enabled = active;
        }
        public string MaPhatSinhTuDong()
        {
            int count = lvNCC.Items.Count;
            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                chuoi = "NCC00" + stt.ToString();
            else if (stt < 100)
                chuoi = "NCC0" + stt.ToString();
            else if (stt < 1000)
                chuoi = "NCC" + stt.ToString();
            return chuoi;
        }

        private void capNhap()
        {
            lvNCC.Items.Clear();
            list_NCC = ncc_Controller.danhSachNCC();
            foreach (ListViewItem nv in list_NCC)
            {
                lvNCC.Items.Add(nv);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            flag_nv = true;
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
            flag_nv = false;
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

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            tbDiaChi.Text = "";
            tbEmail.Text = "";
            tbTenNCC.Text = "";
            tbMaNCC.Text = MaPhatSinhTuDong();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
