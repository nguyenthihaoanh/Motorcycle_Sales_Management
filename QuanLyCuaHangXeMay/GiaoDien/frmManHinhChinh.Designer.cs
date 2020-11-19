namespace QuanLyCuaHangXeMay
{
    partial class frmManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhChinh));
            this.mnsTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsXemThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyNhaSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManHinhChinh = new System.Windows.Forms.MenuStrip();
            this.hinhAnh = new System.Windows.Forms.PictureBox();
            this.ManHinhChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsTaiKhoan
            // 
            this.mnsTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsXemThongTinTaiKhoan,
            this.mnsDangXuat});
            this.mnsTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsTaiKhoan.Name = "mnsTaiKhoan";
            this.mnsTaiKhoan.ShowShortcutKeys = false;
            this.mnsTaiKhoan.Size = new System.Drawing.Size(107, 44);
            this.mnsTaiKhoan.Text = "Tài Khoản";
            // 
            // mnsXemThongTinTaiKhoan
            // 
            this.mnsXemThongTinTaiKhoan.Name = "mnsXemThongTinTaiKhoan";
            this.mnsXemThongTinTaiKhoan.Size = new System.Drawing.Size(304, 26);
            this.mnsXemThongTinTaiKhoan.Text = "Xem Thông Tin Tài Khoản";
            this.mnsXemThongTinTaiKhoan.Click += new System.EventHandler(this.mnsXemThongTinTaiKhoan_Click);
            // 
            // mnsDangXuat
            // 
            this.mnsDangXuat.Name = "mnsDangXuat";
            this.mnsDangXuat.Size = new System.Drawing.Size(304, 26);
            this.mnsDangXuat.Text = "Đăng Xuất";
            this.mnsDangXuat.Click += new System.EventHandler(this.mnsDangXuat_Click);
            // 
            // mnsQuanLy
            // 
            this.mnsQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsQuanLyXe,
            this.mnsQuanLyKhachHang,
            this.mnsQuanLyHoaDon,
            this.mnsQuanLyNhanVien,
            this.mnsQuanLyNhaCungCap,
            this.mnsQuanLyNhaSanXuat});
            this.mnsQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.mnsQuanLy.Name = "mnsQuanLy";
            this.mnsQuanLy.Size = new System.Drawing.Size(91, 44);
            this.mnsQuanLy.Text = "Quản Lý";
            // 
            // mnsQuanLyXe
            // 
            this.mnsQuanLyXe.Name = "mnsQuanLyXe";
            this.mnsQuanLyXe.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyXe.Text = "Quản Lý Xe";
            this.mnsQuanLyXe.Click += new System.EventHandler(this.mnsQuanLyXe_Click);
            // 
            // mnsQuanLyKhachHang
            // 
            this.mnsQuanLyKhachHang.Name = "mnsQuanLyKhachHang";
            this.mnsQuanLyKhachHang.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.mnsQuanLyKhachHang.Click += new System.EventHandler(this.mnsQuanLyKhachHang_Click);
            // 
            // mnsQuanLyHoaDon
            // 
            this.mnsQuanLyHoaDon.Name = "mnsQuanLyHoaDon";
            this.mnsQuanLyHoaDon.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyHoaDon.Text = "Quản Lý Hóa Đơn";
            this.mnsQuanLyHoaDon.Click += new System.EventHandler(this.mnsQuanLyHoaDon_Click);
            // 
            // mnsQuanLyNhanVien
            // 
            this.mnsQuanLyNhanVien.Name = "mnsQuanLyNhanVien";
            this.mnsQuanLyNhanVien.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.mnsQuanLyNhanVien.Click += new System.EventHandler(this.mnsQuanLyNhanVien_Click);
            // 
            // mnsQuanLyNhaCungCap
            // 
            this.mnsQuanLyNhaCungCap.Name = "mnsQuanLyNhaCungCap";
            this.mnsQuanLyNhaCungCap.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyNhaCungCap.Text = "Quản Lý Nhà Cung Cấp";
            this.mnsQuanLyNhaCungCap.Click += new System.EventHandler(this.mnsQuanLyNhaCungCap_Click);
            // 
            // mnsQuanLyNhaSanXuat
            // 
            this.mnsQuanLyNhaSanXuat.Name = "mnsQuanLyNhaSanXuat";
            this.mnsQuanLyNhaSanXuat.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyNhaSanXuat.Text = "Quản Lý Nhà Sản Xuất";
            this.mnsQuanLyNhaSanXuat.Click += new System.EventHandler(this.mnsQuanLyNhaSanXuat_Click);
            // 
            // mnsThongKe
            // 
            this.mnsThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsThongKeDoanhThu});
            this.mnsThongKe.Name = "mnsThongKe";
            this.mnsThongKe.Size = new System.Drawing.Size(101, 44);
            this.mnsThongKe.Text = "Thống Kê";
            // 
            // mnsThongKeDoanhThu
            // 
            this.mnsThongKeDoanhThu.Name = "mnsThongKeDoanhThu";
            this.mnsThongKeDoanhThu.Size = new System.Drawing.Size(262, 26);
            this.mnsThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            this.mnsThongKeDoanhThu.Click += new System.EventHandler(this.mnsThongKeDoanhThu_Click);
            // 
            // ManHinhChinh
            // 
            this.ManHinhChinh.AutoSize = false;
            this.ManHinhChinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManHinhChinh.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ManHinhChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsTaiKhoan,
            this.mnsQuanLy,
            this.mnsThongKe});
            this.ManHinhChinh.Location = new System.Drawing.Point(0, 0);
            this.ManHinhChinh.Name = "ManHinhChinh";
            this.ManHinhChinh.Size = new System.Drawing.Size(703, 48);
            this.ManHinhChinh.TabIndex = 1;
            this.ManHinhChinh.Text = "menuStrip1";
            // 
            // hinhAnh
            // 
            this.hinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("hinhAnh.Image")));
            this.hinhAnh.Location = new System.Drawing.Point(0, 48);
            this.hinhAnh.Name = "hinhAnh";
            this.hinhAnh.Size = new System.Drawing.Size(703, 565);
            this.hinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hinhAnh.TabIndex = 2;
            this.hinhAnh.TabStop = false;
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 613);
            this.Controls.Add(this.hinhAnh);
            this.Controls.Add(this.ManHinhChinh);
            this.MainMenuStrip = this.ManHinhChinh;
            this.Name = "frmManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManHinhChinh_FormClosed);
            this.Load += new System.EventHandler(this.frmManHinhChinh_Load);
            this.ManHinhChinh.ResumeLayout(false);
            this.ManHinhChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnsTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsXemThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyXe;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnsThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnsThongKeDoanhThu;
        private System.Windows.Forms.MenuStrip ManHinhChinh;
        private System.Windows.Forms.PictureBox hinhAnh;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyNhaSanXuat;
    }
}