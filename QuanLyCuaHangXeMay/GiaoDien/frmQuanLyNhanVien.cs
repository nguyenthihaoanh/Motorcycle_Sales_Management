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
    public partial class frmQuanLyNhanVien : Form
    {
        private List<ListViewItem> list_NV = new List<ListViewItem>();
        private NhanVienController NVC = new NhanVienController();
        public static ListViewItem lvi_nv { get; private set; } = new ListViewItem();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            lvNV.Items.Clear();
            rbNghiLam.Enabled = false;
            btLuu.Enabled = false;
            btSua.Enabled = false;
            btThemTK.Enabled = false;
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbChucVu.Items.Add("Quản Lý");
            cbChucVu.Items.Add("Nhân Viên");
            list_NV = NVC.danhSachNV();
            foreach (ListViewItem nv in list_NV)
            {
                lvNV.Items.Add(nv);
                tbMaNV.Text = MaPhatSinhTuDong();
            }
                
        }
        private void lvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNV.SelectedItems.Count > 0)
            {
                lvi_nv = lvNV.SelectedItems[0];
                tbMaNV.Text = lvi_nv.SubItems[0].Text;
                tbTenNV.Text = lvi_nv.SubItems[1].Text;
                tbSDT.Text = lvi_nv.SubItems[2].Text;
                cbGioiTinh.Text = lvi_nv.SubItems[3].Text;
                tbCMND.Text = lvi_nv.SubItems[4].Text;
                tbDiaChi.Text = lvi_nv.SubItems[5].Text;
                cbChucVu.Text = lvi_nv.SubItems[6].Text;
                if (lvNV.SelectedItems[0].SubItems[7].Text == "Còn Làm")
                {
                    rbConLam.Checked = true;
                }
                else
                    rbNghiLam.Checked = true;

                tbTaiKhoan.Text = lvi_nv.SubItems[8].Text;
                btSua.Enabled = true;
            }
        }


        private void btNhapLai_Click_1(object sender, EventArgs e)
        {
            tbCMND.Text = "";
            tbDiaChi.Text = "";
            tbMaNV.Text = MaPhatSinhTuDong();
            tbSDT.Text = "";
            tbTenNV.Text = "";
            cbChucVu.Text = "";
            cbGioiTinh.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!btThem.Text.Equals("Hủy Thêm"))
            {
                btLuu.Enabled = true;
                btThem.Text = "Hủy Thêm";
            }
            else
            {
                btLuu.Enabled = false;
                btThem.Text = "Thêm";
                btSua.Enabled = false;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string MaPhatSinhTuDong()
        {
            int count = lvNV.Items.Count;
            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                chuoi = "NV00" + stt.ToString();
            else if (stt < 100)
                chuoi = "NV0" + stt.ToString();
            else if (stt < 1000)
                chuoi = "NV" + stt.ToString();
            return chuoi;
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            lvi_nv = new ListViewItem();
            lvi_nv.Text = tbMaNV.Text = MaPhatSinhTuDong();
            lvi_nv.SubItems.Add(tbTenNV.Text);
            lvi_nv.SubItems.Add(tbSDT.Text);
            lvi_nv.SubItems.Add(cbGioiTinh.Text);
            lvi_nv.SubItems.Add(tbCMND.Text);
            lvi_nv.SubItems.Add(tbDiaChi.Text);
            lvi_nv.SubItems.Add(cbChucVu.Text);
            lvi_nv.SubItems.Add(rbConLam.Checked.ToString());
            MessageBox.Show("Thêm Thành Công!");
        }
    }
}