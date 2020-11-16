namespace QuanLyCuaHangXeMay
{
    partial class frmQuanLyHoaDon
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
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.tbTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbTenNhanVien = new System.Windows.Forms.TextBox();
            this.tbSDTKH = new System.Windows.Forms.TextBox();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            this.rbTenNV = new System.Windows.Forms.RadioButton();
            this.rbTenKH = new System.Windows.Forms.RadioButton();
            this.rbSDT = new System.Windows.Forms.RadioButton();
            this.rbMaHD = new System.Windows.Forms.RadioButton();
            this.dGVDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.gbTimKiemHD = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbQLHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachHoaDon)).BeginInit();
            this.gbTimKiemHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.lbTenNhanVien.Location = new System.Drawing.Point(592, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(228, 23);
            this.lbTenNhanVien.TabIndex = 9;
            // 
            // tbTenKhachHang
            // 
            this.tbTenKhachHang.Location = new System.Drawing.Point(169, 73);
            this.tbTenKhachHang.Name = "tbTenKhachHang";
            this.tbTenKhachHang.Size = new System.Drawing.Size(179, 22);
            this.tbTenKhachHang.TabIndex = 5;
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Location = new System.Drawing.Point(169, 32);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Size = new System.Drawing.Size(179, 22);
            this.tbTenNhanVien.TabIndex = 4;
            // 
            // tbSDTKH
            // 
            this.tbSDTKH.Location = new System.Drawing.Point(532, 32);
            this.tbSDTKH.Name = "tbSDTKH";
            this.tbSDTKH.Size = new System.Drawing.Size(186, 22);
            this.tbSDTKH.TabIndex = 6;
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.Location = new System.Drawing.Point(532, 73);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.Size = new System.Drawing.Size(186, 22);
            this.tbMaHoaDon.TabIndex = 7;
            // 
            // rbTenNV
            // 
            this.rbTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTenNV.AutoSize = true;
            this.rbTenNV.Checked = true;
            this.rbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbTenNV.Location = new System.Drawing.Point(12, 30);
            this.rbTenNV.Name = "rbTenNV";
            this.rbTenNV.Size = new System.Drawing.Size(140, 24);
            this.rbTenNV.TabIndex = 8;
            this.rbTenNV.TabStop = true;
            this.rbTenNV.Text = "Tên Nhân Viên";
            this.rbTenNV.UseVisualStyleBackColor = true;
            // 
            // rbTenKH
            // 
            this.rbTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTenKH.AutoSize = true;
            this.rbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbTenKH.Location = new System.Drawing.Point(12, 71);
            this.rbTenKH.Name = "rbTenKH";
            this.rbTenKH.Size = new System.Drawing.Size(155, 24);
            this.rbTenKH.TabIndex = 9;
            this.rbTenKH.Text = "Tên Khách Hàng";
            this.rbTenKH.UseVisualStyleBackColor = true;
            // 
            // rbSDT
            // 
            this.rbSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSDT.AutoSize = true;
            this.rbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbSDT.Location = new System.Drawing.Point(391, 30);
            this.rbSDT.Name = "rbSDT";
            this.rbSDT.Size = new System.Drawing.Size(135, 24);
            this.rbSDT.TabIndex = 10;
            this.rbSDT.TabStop = true;
            this.rbSDT.Text = "Số Điện Thoại";
            this.rbSDT.UseVisualStyleBackColor = true;
            // 
            // rbMaHD
            // 
            this.rbMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMaHD.AutoSize = true;
            this.rbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbMaHD.Location = new System.Drawing.Point(391, 71);
            this.rbMaHD.Name = "rbMaHD";
            this.rbMaHD.Size = new System.Drawing.Size(124, 24);
            this.rbMaHD.TabIndex = 11;
            this.rbMaHD.TabStop = true;
            this.rbMaHD.Text = "Mã Hóa Đơn";
            this.rbMaHD.UseVisualStyleBackColor = true;
            // 
            // dGVDanhSachHoaDon
            // 
            this.dGVDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachHoaDon.Location = new System.Drawing.Point(50, 199);
            this.dGVDanhSachHoaDon.Name = "dGVDanhSachHoaDon";
            this.dGVDanhSachHoaDon.RowHeadersWidth = 51;
            this.dGVDanhSachHoaDon.RowTemplate.Height = 24;
            this.dGVDanhSachHoaDon.Size = new System.Drawing.Size(718, 406);
            this.dGVDanhSachHoaDon.TabIndex = 4;
            // 
            // gbTimKiemHD
            // 
            this.gbTimKiemHD.Controls.Add(this.rbTenNV);
            this.gbTimKiemHD.Controls.Add(this.rbTenKH);
            this.gbTimKiemHD.Controls.Add(this.tbTenNhanVien);
            this.gbTimKiemHD.Controls.Add(this.rbSDT);
            this.gbTimKiemHD.Controls.Add(this.tbSDTKH);
            this.gbTimKiemHD.Controls.Add(this.tbMaHoaDon);
            this.gbTimKiemHD.Controls.Add(this.rbMaHD);
            this.gbTimKiemHD.Controls.Add(this.tbTenKhachHang);
            this.gbTimKiemHD.Location = new System.Drawing.Point(38, 76);
            this.gbTimKiemHD.Name = "gbTimKiemHD";
            this.gbTimKiemHD.Size = new System.Drawing.Size(743, 117);
            this.gbTimKiemHD.TabIndex = 12;
            this.gbTimKiemHD.TabStop = false;
            this.gbTimKiemHD.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(350, 628);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(118, 45);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbQLHD
            // 
            this.lbQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLHD.Location = new System.Drawing.Point(-1, 29);
            this.lbQLHD.Name = "lbQLHD";
            this.lbQLHD.Size = new System.Drawing.Size(821, 44);
            this.lbQLHD.TabIndex = 26;
            this.lbQLHD.Text = "Quản Lý Thông Tin Hóa Đơn";
            this.lbQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 685);
            this.Controls.Add(this.lbQLHD);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.gbTimKiemHD);
            this.Controls.Add(this.dGVDanhSachHoaDon);
            this.Controls.Add(this.lbTenNhanVien);
            this.Name = "frmQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachHoaDon)).EndInit();
            this.gbTimKiemHD.ResumeLayout(false);
            this.gbTimKiemHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.TextBox tbTenKhachHang;
        private System.Windows.Forms.TextBox tbTenNhanVien;
        private System.Windows.Forms.TextBox tbSDTKH;
        private System.Windows.Forms.TextBox tbMaHoaDon;
        private System.Windows.Forms.DataGridView dGVDanhSachHoaDon;
        private System.Windows.Forms.RadioButton rbMaHD;
        private System.Windows.Forms.RadioButton rbSDT;
        private System.Windows.Forms.RadioButton rbTenNV;
        private System.Windows.Forms.RadioButton rbTenKH;
        private System.Windows.Forms.GroupBox gbTimKiemHD;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbQLHD;
    }
}