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
            this.mnuXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaTTXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManHinhChinh = new System.Windows.Forms.MenuStrip();
            this.mnuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemTTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNSX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNSX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaNSX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimNSX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimHD = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhAnh = new System.Windows.Forms.PictureBox();
            this.ManHinhChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuXe
            // 
            this.mnuXe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemXe,
            this.mnuSuaTTXe,
            this.mnuTimXe});
            this.mnuXe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.mnuXe.Name = "mnuXe";
            this.mnuXe.Size = new System.Drawing.Size(51, 44);
            this.mnuXe.Text = "Xe";
            // 
            // mnuThemXe
            // 
            this.mnuThemXe.Name = "mnuThemXe";
            this.mnuThemXe.Size = new System.Drawing.Size(220, 30);
            this.mnuThemXe.Text = "Thêm Xe";
            this.mnuThemXe.Click += new System.EventHandler(this.mnuThemXe_Click);
            // 
            // mnuSuaTTXe
            // 
            this.mnuSuaTTXe.Name = "mnuSuaTTXe";
            this.mnuSuaTTXe.Size = new System.Drawing.Size(220, 30);
            this.mnuSuaTTXe.Text = "Chỉnh Sửa Xe";
            this.mnuSuaTTXe.Click += new System.EventHandler(this.mnuSuaTTXe_Click);
            // 
            // mnuTimXe
            // 
            this.mnuTimXe.Name = "mnuTimXe";
            this.mnuTimXe.Size = new System.Drawing.Size(220, 30);
            this.mnuTimXe.Text = "Tìm Kiếm Xe";
            this.mnuTimXe.Click += new System.EventHandler(this.mnuTimXe_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeDoanhThu});
            this.mnuThongKe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(112, 44);
            this.mnuThongKe.Text = "Thống Kê";
            // 
            // mnuThongKeDoanhThu
            // 
            this.mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            this.mnuThongKeDoanhThu.Size = new System.Drawing.Size(288, 30);
            this.mnuThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            this.mnuThongKeDoanhThu.Click += new System.EventHandler(this.mnsThongKeDoanhThu_Click);
            // 
            // ManHinhChinh
            // 
            this.ManHinhChinh.AutoSize = false;
            this.ManHinhChinh.BackColor = System.Drawing.Color.MintCream;
            this.ManHinhChinh.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ManHinhChinh.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ManHinhChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNV,
            this.mnuNCC,
            this.mnuNSX,
            this.mnuXe,
            this.mnuKH,
            this.mnuHoaDon,
            this.mnuThongKe});
            this.ManHinhChinh.Location = new System.Drawing.Point(0, 0);
            this.ManHinhChinh.Name = "ManHinhChinh";
            this.ManHinhChinh.Size = new System.Drawing.Size(1902, 48);
            this.ManHinhChinh.TabIndex = 1;
            this.ManHinhChinh.Text = "menuStrip1";
            // 
            // mnuNV
            // 
            this.mnuNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXemTTNV,
            this.mnuThemNV,
            this.mnuSuaNV,
            this.mnuTimNV,
            this.mnuDoiMatKhau,
            this.mnuDangXuat});
            this.mnuNV.Name = "mnuNV";
            this.mnuNV.Size = new System.Drawing.Size(118, 44);
            this.mnuNV.Text = "Nhân Viên";
            // 
            // mnuXemTTNV
            // 
            this.mnuXemTTNV.Name = "mnuXemTTNV";
            this.mnuXemTTNV.Size = new System.Drawing.Size(333, 30);
            this.mnuXemTTNV.Text = "Xem Thông Tin Tài Khoản";
            this.mnuXemTTNV.Click += new System.EventHandler(this.mnuXemTTNV_Click);
            // 
            // mnuThemNV
            // 
            this.mnuThemNV.Name = "mnuThemNV";
            this.mnuThemNV.Size = new System.Drawing.Size(333, 30);
            this.mnuThemNV.Text = "Thêm Nhân Viên";
            this.mnuThemNV.Click += new System.EventHandler(this.mnuThemNV_Click);
            // 
            // mnuSuaNV
            // 
            this.mnuSuaNV.Name = "mnuSuaNV";
            this.mnuSuaNV.Size = new System.Drawing.Size(333, 30);
            this.mnuSuaNV.Text = "Chỉnh Sửa Nhân Viên";
            this.mnuSuaNV.Click += new System.EventHandler(this.mnuSuaNV_Click);
            // 
            // mnuTimNV
            // 
            this.mnuTimNV.Name = "mnuTimNV";
            this.mnuTimNV.Size = new System.Drawing.Size(333, 30);
            this.mnuTimNV.Text = "Tìm Kiếm Nhân Viên";
            this.mnuTimNV.Click += new System.EventHandler(this.mnuTimNV_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(333, 30);
            this.mnuDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(333, 30);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuNCC
            // 
            this.mnuNCC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNCC,
            this.mnuSuaNCC,
            this.mnuTimNCC});
            this.mnuNCC.Name = "mnuNCC";
            this.mnuNCC.Size = new System.Drawing.Size(156, 44);
            this.mnuNCC.Text = "Nhà Cung Cấp";
            // 
            // mnuThemNCC
            // 
            this.mnuThemNCC.Name = "mnuThemNCC";
            this.mnuThemNCC.Size = new System.Drawing.Size(325, 30);
            this.mnuThemNCC.Text = "Thêm Nhà Cung Cấp";
            this.mnuThemNCC.Click += new System.EventHandler(this.mnuThemNCC_Click);
            // 
            // mnuSuaNCC
            // 
            this.mnuSuaNCC.Name = "mnuSuaNCC";
            this.mnuSuaNCC.Size = new System.Drawing.Size(325, 30);
            this.mnuSuaNCC.Text = "Chỉnh Sửa Nhà Cung Cấp";
            this.mnuSuaNCC.Click += new System.EventHandler(this.mnuSuaNCC_Click);
            // 
            // mnuTimNCC
            // 
            this.mnuTimNCC.Name = "mnuTimNCC";
            this.mnuTimNCC.Size = new System.Drawing.Size(325, 30);
            this.mnuTimNCC.Text = "Tìm Kiếm Nhà Cung Cấp";
            this.mnuTimNCC.Click += new System.EventHandler(this.mnuTimNCC_Click);
            // 
            // mnuNSX
            // 
            this.mnuNSX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNSX,
            this.mnuSuaNSX,
            this.mnuTimNSX});
            this.mnuNSX.Name = "mnuNSX";
            this.mnuNSX.Size = new System.Drawing.Size(148, 44);
            this.mnuNSX.Text = "Nhà Sản Xuất";
            // 
            // mnuThemNSX
            // 
            this.mnuThemNSX.Name = "mnuThemNSX";
            this.mnuThemNSX.Size = new System.Drawing.Size(317, 30);
            this.mnuThemNSX.Text = "Thêm Nhà Sản Xuất";
            this.mnuThemNSX.Click += new System.EventHandler(this.mnuThemNSX_Click);
            // 
            // mnuSuaNSX
            // 
            this.mnuSuaNSX.Name = "mnuSuaNSX";
            this.mnuSuaNSX.Size = new System.Drawing.Size(317, 30);
            this.mnuSuaNSX.Text = "Chỉnh Sửa Nhà Sản Xuất";
            this.mnuSuaNSX.Click += new System.EventHandler(this.mnuSuaNSX_Click);
            // 
            // mnuTimNSX
            // 
            this.mnuTimNSX.Name = "mnuTimNSX";
            this.mnuTimNSX.Size = new System.Drawing.Size(317, 30);
            this.mnuTimNSX.Text = "Tìm KiếmNhà Sản Xuất";
            this.mnuTimNSX.Click += new System.EventHandler(this.mnuTimNSX_Click);
            // 
            // mnuKH
            // 
            this.mnuKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemKH,
            this.mnuSuaKH,
            this.mnuTimKH});
            this.mnuKH.Name = "mnuKH";
            this.mnuKH.Size = new System.Drawing.Size(132, 44);
            this.mnuKH.Text = "Khách Hàng";
            // 
            // mnuThemKH
            // 
            this.mnuThemKH.Name = "mnuThemKH";
            this.mnuThemKH.Size = new System.Drawing.Size(301, 30);
            this.mnuThemKH.Text = "Thêm Khách Hàng";
            this.mnuThemKH.Click += new System.EventHandler(this.mnuThemKH_Click);
            // 
            // mnuSuaKH
            // 
            this.mnuSuaKH.Name = "mnuSuaKH";
            this.mnuSuaKH.Size = new System.Drawing.Size(301, 30);
            this.mnuSuaKH.Text = "Chỉnh Sửa Khách Hàng";
            this.mnuSuaKH.Click += new System.EventHandler(this.mnuSuaKH_Click);
            // 
            // mnuTimKH
            // 
            this.mnuTimKH.Name = "mnuTimKH";
            this.mnuTimKH.Size = new System.Drawing.Size(301, 30);
            this.mnuTimKH.Text = "Tìm Kiếm Khách Hàng";
            this.mnuTimKH.Click += new System.EventHandler(this.mnuTimKH_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimHD});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(106, 44);
            this.mnuHoaDon.Text = "Hóa Đơn";
            // 
            // mnuTimHD
            // 
            this.mnuTimHD.Name = "mnuTimHD";
            this.mnuTimHD.Size = new System.Drawing.Size(273, 30);
            this.mnuTimHD.Text = "Tìm Kiếm Hóa Đơn";
            this.mnuTimHD.Click += new System.EventHandler(this.mnuTimHD_Click);
            // 
            // hinhAnh
            // 
            this.hinhAnh.BackColor = System.Drawing.Color.MintCream;
            this.hinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("hinhAnh.Image")));
            this.hinhAnh.Location = new System.Drawing.Point(0, 48);
            this.hinhAnh.Name = "hinhAnh";
            this.hinhAnh.Size = new System.Drawing.Size(1902, 565);
            this.hinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hinhAnh.TabIndex = 2;
            this.hinhAnh.TabStop = false;
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 613);
            this.Controls.Add(this.hinhAnh);
            this.Controls.Add(this.ManHinhChinh);
            this.MaximizeBox = false;
            this.Name = "frmManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManHinhChinh_FormClosed);
            this.Load += new System.EventHandler(this.frmManHinhChinh_Load);
            this.ManHinhChinh.ResumeLayout(false);
            this.ManHinhChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuXe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeDoanhThu;
        private System.Windows.Forms.MenuStrip ManHinhChinh;
        private System.Windows.Forms.PictureBox hinhAnh;
        private System.Windows.Forms.ToolStripMenuItem mnuKH;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuNV;
        private System.Windows.Forms.ToolStripMenuItem mnuXemTTNV;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNV;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaNV;
        private System.Windows.Forms.ToolStripMenuItem mnuTimNV;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuThemKH;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaKH;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKH;
        private System.Windows.Forms.ToolStripMenuItem mnuNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuTimNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuNSX;
        private System.Windows.Forms.ToolStripMenuItem mnuThemXe;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaTTXe;
        private System.Windows.Forms.ToolStripMenuItem mnuTimXe;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNSX;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaNSX;
        private System.Windows.Forms.ToolStripMenuItem mnuTimNSX;
        private System.Windows.Forms.ToolStripMenuItem mnuTimHD;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
    }
}