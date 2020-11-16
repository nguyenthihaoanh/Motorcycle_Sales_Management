namespace QuanLyCuaHangXeMay
{
    partial class frmChiTietHD
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
            this.lbHoaDonBanHang = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbXuatMaHoaDon = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.dtNgayHD = new System.Windows.Forms.DateTimePicker();
            this.lbXuatTenNV = new System.Windows.Forms.Label();
            this.lbXuatTenKH = new System.Windows.Forms.Label();
            this.lbXuatDiaChiKH = new System.Windows.Forms.Label();
            this.lbXuatCMND = new System.Windows.Forms.Label();
            this.lbXuatSDT = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.dGVHoaDon = new System.Windows.Forms.DataGridView();
            this.lbCuaHangAnhTuan = new System.Windows.Forms.Label();
            this.lbDiaChiCTy = new System.Windows.Forms.Label();
            this.lbSDTCTy = new System.Windows.Forms.Label();
            this.lbXuatSDTCTy = new System.Windows.Forms.Label();
            this.lbXuatDiaChiCTy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHoaDonBanHang
            // 
            this.lbHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoaDonBanHang.Location = new System.Drawing.Point(5, 241);
            this.lbHoaDonBanHang.Name = "lbHoaDonBanHang";
            this.lbHoaDonBanHang.Size = new System.Drawing.Size(625, 42);
            this.lbHoaDonBanHang.TabIndex = 0;
            this.lbHoaDonBanHang.Text = "Hóa Đơn Bán Hàng";
            this.lbHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNgayLap.Location = new System.Drawing.Point(252, 198);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(143, 20);
            this.lbNgayLap.TabIndex = 4;
            this.lbNgayLap.Text = "Ngày lập hóa đơn:";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMaHD.Location = new System.Drawing.Point(252, 170);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(101, 20);
            this.lbMaHD.TabIndex = 5;
            this.lbMaHD.Text = "Mã hóa đơn:";
            // 
            // lbXuatMaHoaDon
            // 
            this.lbXuatMaHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXuatMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatMaHoaDon.Location = new System.Drawing.Point(451, 168);
            this.lbXuatMaHoaDon.Name = "lbXuatMaHoaDon";
            this.lbXuatMaHoaDon.Size = new System.Drawing.Size(178, 20);
            this.lbXuatMaHoaDon.TabIndex = 7;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTenNV.Location = new System.Drawing.Point(252, 137);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(195, 20);
            this.lbTenNV.TabIndex = 8;
            this.lbTenNV.Text = "Nhân Viên Lập Hóa Đơn:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTenKH.Location = new System.Drawing.Point(83, 315);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(139, 20);
            this.lbTenKH.TabIndex = 9;
            this.lbTenKH.Text = "Tên Khách Hàng:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDiaChi.Location = new System.Drawing.Point(83, 365);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(69, 20);
            this.lbDiaChi.TabIndex = 10;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSDT.Location = new System.Drawing.Point(83, 415);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(124, 20);
            this.lbSDT.TabIndex = 11;
            this.lbSDT.Text = "Số Điện Thoại: ";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCMND.Location = new System.Drawing.Point(83, 465);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(65, 20);
            this.lbCMND.TabIndex = 12;
            this.lbCMND.Text = "CMND:";
            // 
            // dtNgayHD
            // 
            this.dtNgayHD.Location = new System.Drawing.Point(401, 198);
            this.dtNgayHD.MaxDate = new System.DateTime(2020, 11, 10, 0, 0, 0, 0);
            this.dtNgayHD.Name = "dtNgayHD";
            this.dtNgayHD.Size = new System.Drawing.Size(227, 22);
            this.dtNgayHD.TabIndex = 13;
            this.dtNgayHD.Value = new System.DateTime(2020, 11, 10, 0, 0, 0, 0);
            // 
            // lbXuatTenNV
            // 
            this.lbXuatTenNV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXuatTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatTenNV.Location = new System.Drawing.Point(451, 137);
            this.lbXuatTenNV.Name = "lbXuatTenNV";
            this.lbXuatTenNV.Size = new System.Drawing.Size(178, 20);
            this.lbXuatTenNV.TabIndex = 17;
            // 
            // lbXuatTenKH
            // 
            this.lbXuatTenKH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXuatTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatTenKH.Location = new System.Drawing.Point(279, 317);
            this.lbXuatTenKH.Name = "lbXuatTenKH";
            this.lbXuatTenKH.Size = new System.Drawing.Size(291, 20);
            this.lbXuatTenKH.TabIndex = 18;
            // 
            // lbXuatDiaChiKH
            // 
            this.lbXuatDiaChiKH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXuatDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatDiaChiKH.Location = new System.Drawing.Point(279, 367);
            this.lbXuatDiaChiKH.Name = "lbXuatDiaChiKH";
            this.lbXuatDiaChiKH.Size = new System.Drawing.Size(291, 20);
            this.lbXuatDiaChiKH.TabIndex = 19;
            // 
            // lbXuatCMND
            // 
            this.lbXuatCMND.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXuatCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatCMND.Location = new System.Drawing.Point(279, 467);
            this.lbXuatCMND.Name = "lbXuatCMND";
            this.lbXuatCMND.Size = new System.Drawing.Size(291, 20);
            this.lbXuatCMND.TabIndex = 21;
            // 
            // lbXuatSDT
            // 
            this.lbXuatSDT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXuatSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatSDT.Location = new System.Drawing.Point(279, 417);
            this.lbXuatSDT.Name = "lbXuatSDT";
            this.lbXuatSDT.Size = new System.Drawing.Size(291, 20);
            this.lbXuatSDT.TabIndex = 20;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThem.Location = new System.Drawing.Point(131, 720);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(118, 45);
            this.btThem.TabIndex = 22;
            this.btThem.Text = "Thêm Xe";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(385, 720);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(118, 45);
            this.btThoat.TabIndex = 23;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dGVHoaDon
            // 
            this.dGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHoaDon.Location = new System.Drawing.Point(10, 505);
            this.dGVHoaDon.Name = "dGVHoaDon";
            this.dGVHoaDon.RowHeadersWidth = 51;
            this.dGVHoaDon.RowTemplate.Height = 24;
            this.dGVHoaDon.Size = new System.Drawing.Size(605, 196);
            this.dGVHoaDon.TabIndex = 24;
            // 
            // lbCuaHangAnhTuan
            // 
            this.lbCuaHangAnhTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuaHangAnhTuan.Location = new System.Drawing.Point(-1, -1);
            this.lbCuaHangAnhTuan.Name = "lbCuaHangAnhTuan";
            this.lbCuaHangAnhTuan.Size = new System.Drawing.Size(631, 44);
            this.lbCuaHangAnhTuan.TabIndex = 25;
            this.lbCuaHangAnhTuan.Text = "Cửa Hàng Anh Tuấn";
            this.lbCuaHangAnhTuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiaChiCTy
            // 
            this.lbDiaChiCTy.AutoSize = true;
            this.lbDiaChiCTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDiaChiCTy.Location = new System.Drawing.Point(105, 71);
            this.lbDiaChiCTy.Name = "lbDiaChiCTy";
            this.lbDiaChiCTy.Size = new System.Drawing.Size(64, 20);
            this.lbDiaChiCTy.TabIndex = 27;
            this.lbDiaChiCTy.Text = "Địa Chỉ";
            // 
            // lbSDTCTy
            // 
            this.lbSDTCTy.AutoSize = true;
            this.lbSDTCTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSDTCTy.Location = new System.Drawing.Point(179, 43);
            this.lbSDTCTy.Name = "lbSDTCTy";
            this.lbSDTCTy.Size = new System.Drawing.Size(47, 20);
            this.lbSDTCTy.TabIndex = 26;
            this.lbSDTCTy.Text = "SĐT:";
            // 
            // lbXuatSDTCTy
            // 
            this.lbXuatSDTCTy.BackColor = System.Drawing.SystemColors.Control;
            this.lbXuatSDTCTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatSDTCTy.Location = new System.Drawing.Point(232, 43);
            this.lbXuatSDTCTy.Name = "lbXuatSDTCTy";
            this.lbXuatSDTCTy.Size = new System.Drawing.Size(215, 20);
            this.lbXuatSDTCTy.TabIndex = 28;
            this.lbXuatSDTCTy.Text = "0729333333 - 0967993555";
            // 
            // lbXuatDiaChiCTy
            // 
            this.lbXuatDiaChiCTy.BackColor = System.Drawing.SystemColors.Control;
            this.lbXuatDiaChiCTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatDiaChiCTy.Location = new System.Drawing.Point(175, 71);
            this.lbXuatDiaChiCTy.Name = "lbXuatDiaChiCTy";
            this.lbXuatDiaChiCTy.Size = new System.Drawing.Size(328, 20);
            this.lbXuatDiaChiCTy.TabIndex = 29;
            this.lbXuatDiaChiCTy.Text = "771, Thống Nhất, Gò Vấp, TP Hồ Chí Minh";
            // 
            // frmChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 777);
            this.Controls.Add(this.lbXuatDiaChiCTy);
            this.Controls.Add(this.lbXuatSDTCTy);
            this.Controls.Add(this.lbDiaChiCTy);
            this.Controls.Add(this.lbSDTCTy);
            this.Controls.Add(this.lbCuaHangAnhTuan);
            this.Controls.Add(this.dGVHoaDon);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.lbXuatCMND);
            this.Controls.Add(this.lbXuatSDT);
            this.Controls.Add(this.lbXuatDiaChiKH);
            this.Controls.Add(this.lbXuatTenKH);
            this.Controls.Add(this.lbXuatTenNV);
            this.Controls.Add(this.dtNgayHD);
            this.Controls.Add(this.lbHoaDonBanHang);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.lbXuatMaHoaDon);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.lbNgayLap);
            this.Name = "frmChiTietHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHoaDonBanHang;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbXuatMaHoaDon;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.DateTimePicker dtNgayHD;
        private System.Windows.Forms.Label lbXuatTenNV;
        private System.Windows.Forms.Label lbXuatTenKH;
        private System.Windows.Forms.Label lbXuatDiaChiKH;
        private System.Windows.Forms.Label lbXuatCMND;
        private System.Windows.Forms.Label lbXuatSDT;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dGVHoaDon;
        private System.Windows.Forms.Label lbCuaHangAnhTuan;
        private System.Windows.Forms.Label lbDiaChiCTy;
        private System.Windows.Forms.Label lbSDTCTy;
        private System.Windows.Forms.Label lbXuatSDTCTy;
        private System.Windows.Forms.Label lbXuatDiaChiCTy;
    }
}