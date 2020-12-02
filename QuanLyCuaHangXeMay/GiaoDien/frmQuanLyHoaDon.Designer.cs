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
            this.tbTim = new System.Windows.Forms.TextBox();
            this.gbTimKiemHD = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbQLHD = new System.Windows.Forms.Label();
            this.lvHD = new System.Windows.Forms.ListView();
            this.maHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mauXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTimKiemHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTim
            // 
            this.tbTim.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbTim.Location = new System.Drawing.Point(34, 49);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(263, 32);
            this.tbTim.TabIndex = 4;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // gbTimKiemHD
            // 
            this.gbTimKiemHD.Controls.Add(this.tbTim);
            this.gbTimKiemHD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbTimKiemHD.Location = new System.Drawing.Point(786, 88);
            this.gbTimKiemHD.Name = "gbTimKiemHD";
            this.gbTimKiemHD.Size = new System.Drawing.Size(326, 117);
            this.gbTimKiemHD.TabIndex = 12;
            this.gbTimKiemHD.TabStop = false;
            this.gbTimKiemHD.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(951, 874);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(135, 45);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbQLHD
            // 
            this.lbQLHD.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbQLHD.Location = new System.Drawing.Point(-1, 29);
            this.lbQLHD.Name = "lbQLHD";
            this.lbQLHD.Size = new System.Drawing.Size(1901, 44);
            this.lbQLHD.TabIndex = 26;
            this.lbQLHD.Text = "Quản Lý Thông Tin Hóa Đơn";
            this.lbQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvHD
            // 
            this.lvHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maHD,
            this.tenNV,
            this.tenKH,
            this.sdt,
            this.ngay,
            this.xe,
            this.mauXe,
            this.sl,
            this.tt});
            this.lvHD.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lvHD.FullRowSelect = true;
            this.lvHD.GridLines = true;
            this.lvHD.HideSelection = false;
            this.lvHD.Location = new System.Drawing.Point(147, 220);
            this.lvHD.Name = "lvHD";
            this.lvHD.Size = new System.Drawing.Size(1743, 614);
            this.lvHD.TabIndex = 27;
            this.lvHD.UseCompatibleStateImageBehavior = false;
            this.lvHD.View = System.Windows.Forms.View.Details;
            // 
            // maHD
            // 
            this.maHD.Text = "Mã Hóa Đơn";
            this.maHD.Width = 180;
            // 
            // tenNV
            // 
            this.tenNV.Text = "Tên Nhân Viên";
            this.tenNV.Width = 300;
            // 
            // tenKH
            // 
            this.tenKH.Text = "Tên Khách Hàng";
            this.tenKH.Width = 300;
            // 
            // sdt
            // 
            this.sdt.Text = "Số Điện Thoại";
            this.sdt.Width = 300;
            // 
            // ngay
            // 
            this.ngay.Text = "Ngày Lập Hóa Đơn";
            this.ngay.Width = 300;
            // 
            // xe
            // 
            this.xe.Text = "Nhãn Hiệu";
            this.xe.Width = 300;
            // 
            // mauXe
            // 
            this.mauXe.Text = "Màu Xe";
            this.mauXe.Width = 300;
            // 
            // sl
            // 
            this.sl.Text = "Số Lượng";
            this.sl.Width = 300;
            // 
            // tt
            // 
            this.tt.Text = "Thành Tiền";
            this.tt.Width = 300;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lvHD);
            this.Controls.Add(this.lbQLHD);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.gbTimKiemHD);
            this.Name = "frmQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            this.gbTimKiemHD.ResumeLayout(false);
            this.gbTimKiemHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.GroupBox gbTimKiemHD;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbQLHD;
        private System.Windows.Forms.ListView lvHD;
        private System.Windows.Forms.ColumnHeader maHD;
        private System.Windows.Forms.ColumnHeader tenNV;
        private System.Windows.Forms.ColumnHeader tenKH;
        private System.Windows.Forms.ColumnHeader sdt;
        private System.Windows.Forms.ColumnHeader ngay;
        private System.Windows.Forms.ColumnHeader xe;
        private System.Windows.Forms.ColumnHeader mauXe;
        private System.Windows.Forms.ColumnHeader sl;
        private System.Windows.Forms.ColumnHeader tt;
    }
}