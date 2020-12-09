using QuanLyCuaHangXeMay.Controller;
using QuanLyCuaHangXeMay.Model;
using QuanLyCuaHangXeMay.GiaoDien;
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
    public partial class frmQuanLyXe : Form
    {
        private frmThemMauXe frmMau = new frmThemMauXe();
        private List<ListViewItem> ds = new List<ListViewItem>();
        private List<string> dsncc = new List<string>();
        private List<string> dsmau = new List<string>();
        private XeController xe_Controller = new XeController();
        public static ListViewItem lvi_Xe { get; private set; } = new ListViewItem();
        public static bool flag_xe { get; private set; } = true;
        public frmQuanLyXe()
        {
            InitializeComponent();
        }

        private dbQLMuaBanXeDataContext db = new dbQLMuaBanXeDataContext();
        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            dateNgayNhap.Value = DateTime.Today;
            capNhapXe();
            capNhapNCC();
            capNhapNSX();
            capNhapMauXe();
            btLuu.Enabled = false;
            btSua.Enabled = false;
            enables_txt(false);
        }
        private void capNhapMauXe(bool clear=true)
        {
            if (clear)
            {
                cbMauXe.Items.Clear();
                dsmau.Clear();
                dsmau = xe_Controller.ds_mau();
                foreach (var mau in dsmau)
                {
                    cbMauXe.Items.Add(mau);
                }
            }
            else
            {
                dsmau.Clear();
                dsmau = xe_Controller.ds_mau();
                foreach (var mau in dsmau)
                {
                    if (!cbMauXe.Items.Equals(mau))
                    {
                        cbMauXe.Items.Add(mau);
                    }
                }
            }
            
        }
        private void capNhapNSX()
        {
            var xe = db.NhaSanXuats.GroupBy(x => x.tenNSX).Where(x => x.Count() > 0).Select(x => x.Key).ToList();
            cbNSX.DisplayMember = "tenNSX";
            cbNSX.ValueMember = "maNSX";
            cbNSX.DataSource = xe;
        }
        private void capNhapNCC()
        {
            dsncc.Clear();
            cbNCC.Items.Clear();
            dsncc = xe_Controller.ds_ncc();
            foreach (var ncc in dsncc)
            {
                cbNCC.Items.Add(ncc);
            }
        }
        private void capNhapXe()
        {
            ds.Clear();
            lvXe.Items.Clear();
            ds = xe_Controller.them_ds_xe();
            foreach (ListViewItem xe in ds)
            {
                lvXe.Items.Add(xe);
            }
        }

        private void lvXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvXe.SelectedItems.Count > 0)
            {
                lvi_Xe = lvXe.SelectedItems[0];
                txtMaXe.Text = lvi_Xe.SubItems[0].Text;
                txtNhanHieu.Text = lvi_Xe.SubItems[1].Text;
                cbMauXe.Text = lvi_Xe.SubItems[2].Text;
                tbDungTich.Text = lvi_Xe.SubItems[5].Text;
                cbNCC.Text = lvi_Xe.SubItems[6].Text;
                cbNSX.Text = lvi_Xe.SubItems[4].Text;
                tbSoLuong.Text = lvi_Xe.SubItems[3].Text;
                tbGiaNhap.Text = lvi_Xe.SubItems[7].Text;
                dateNgayNhap.Text = lvi_Xe.SubItems[8].Text;
                btThem.Enabled = false;
                btSua.Enabled = true;
            }
        }
        private void enables_txt(bool active)
        {
            txtNhanHieu.Enabled = cbMauXe.Enabled = tbDungTich.Enabled = cbNuocSX.Enabled = dateNgayNhap.Enabled = cbNSX.Enabled = cbNCC.Enabled = tbSoLuong.Enabled = tbGiaNhap.Enabled = active;
        }
        public string MaPhatSinhTuDong()
        {
            int count = lvXe.Items.Count;
            string chuoi = "";
            int stt = 0;
            if (count == 0)
            {
                stt = 1;
            }
            else stt = count + 1;
            if (stt < 10)
                chuoi = "Xe00" + stt.ToString();
            else if (stt < 100)
                chuoi = "Xe0" + stt.ToString();
            else if (stt < 1000)
                chuoi = "Xe" + stt.ToString();
            return chuoi;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nhaplai()
        {
            tbDungTich.Text = "";
            tbGiaNhap.Text = "";
            txtMaXe.Text = MaPhatSinhTuDong();
            txtNhanHieu.Text = "";
            tbSoLuong.Text = "";
            tbGiaNhap.Text = "";
        }
        private void btNhapLai_Click(object sender, EventArgs e)
        {
            nhaplai();
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            capNhapMauXe();
            capNhapNSX();
            flag_xe = true;
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
            flag_xe = false;
            if (!btSua.Text.Equals("Hủy Sửa"))
            {
                btSua.Text = "Hủy Sửa";
                btLuu.Enabled = true;
                enables_txt(true);
                btThem.Enabled = false;
                
            }
            else
            {
                //capNhapMauXe();
                btSua.Text = "Sửa";
                btLuu.Enabled = false;
                btThem.Enabled = true;
                enables_txt(false);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtNhanHieu.Text != "" && tbSoLuong.Text != "" && tbGiaNhap.Text != "" && tbDungTich.Text != "" && lblMaNSX.Text != "" && cbNCC.SelectedItem.ToString() != null && cbMauXe.SelectedItem.ToString() != "") 
            {
                lvi_Xe = new ListViewItem();
                lvi_Xe.Text = txtMaXe.Text;
                lvi_Xe.SubItems.Add(txtNhanHieu.Text);
                lvi_Xe.SubItems.Add(Convert.ToInt32(tbSoLuong.Text).ToString());
                lvi_Xe.SubItems.Add(Convert.ToDecimal(tbGiaNhap.Text).ToString());
                lvi_Xe.SubItems.Add(Convert.ToInt32(tbDungTich.Text).ToString());
                lvi_Xe.SubItems.Add(lblMaNSX.Text);
                lvi_Xe.SubItems.Add(cbNCC.SelectedItem.ToString());
                lvi_Xe.SubItems.Add(cbMauXe.SelectedItem.ToString());
                lvi_Xe.SubItems.Add(dateNgayNhap.Text);
                if (flag_xe == true)
                {
                    lvi_Xe.Text = txtMaXe.Text = MaPhatSinhTuDong();
                    xe_Controller.themTTXe(lvi_Xe, tbSoLuong.Text, tbDungTich.Text, tbGiaNhap.Text, dateNgayNhap, cbMauXe.SelectedItem.ToString(), cbNCC.SelectedItem.ToString(), lblMaNSX.Text);
                    capNhapXe();
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    btThem.Text = "Thêm";
                    nhaplai();
                    enables_txt(false);
                }
                else
                {
                    xe_Controller.suaTTXe(lvi_Xe, tbSoLuong.Text, tbDungTich.Text, tbGiaNhap.Text, dateNgayNhap, cbMauXe.SelectedItem.ToString(), cbNCC.SelectedItem.ToString(), lblMaNSX.Text);
                    capNhapXe();
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btSua.Text = "Sửa";
                    nhaplai();
                    enables_txt(false);
                }
            }
            else MessageBox.Show("Nhập và Chọn Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btMauXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMau.ShowDialog();
            capNhapMauXe(false);
            this.Show();
        }

        private void cbNSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nsx = (from  x in db.NhaSanXuats 
                       select new
                       {
                           x.maNSX,
                           x.tenNSX,
                           x.nuocSX
                       }).Where(x => x.tenNSX.Equals(cbNSX.SelectedValue.ToString())).ToList();

            cbNuocSX.DisplayMember = "nuocSX";
            cbNuocSX.ValueMember = "maNSX";
            cbNuocSX.DataSource = nsx;
        }

        private void cbNuocSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaSanXuat obj = db.NhaSanXuats.First(x=> x.tenNSX.Equals(cbNSX.SelectedValue.ToString())&&x.maNSX.Equals(cbNuocSX.SelectedValue.ToString()));
            if (obj != null)
            {
                lblMaNSX.Text = obj.maNSX;
            }
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            lvXe.Items.Clear();
            List<ListViewItem> dsXe = new List<ListViewItem>();
            dsXe = xe_Controller.TimKiem(tbTim.Text);
            foreach (ListViewItem xe in dsXe)
            {
                lvXe.Items.Add(xe);
            }
        }
    }
}
