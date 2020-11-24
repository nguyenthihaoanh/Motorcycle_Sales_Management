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
            this.tbTenNhanVien = new System.Windows.Forms.TextBox();
            this.gbTimKiemHD = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbQLHD = new System.Windows.Forms.Label();
            this.maHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbTimKiemHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbTenNhanVien.Location = new System.Drawing.Point(592, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(228, 23);
            this.lbTenNhanVien.TabIndex = 9;
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbTenNhanVien.Location = new System.Drawing.Point(34, 49);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Size = new System.Drawing.Size(263, 32);
            this.tbTenNhanVien.TabIndex = 4;
            // 
            // gbTimKiemHD
            // 
            this.gbTimKiemHD.Controls.Add(this.tbTenNhanVien);
            this.gbTimKiemHD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbTimKiemHD.Location = new System.Drawing.Point(246, 88);
            this.gbTimKiemHD.Name = "gbTimKiemHD";
            this.gbTimKiemHD.Size = new System.Drawing.Size(326, 117);
            this.gbTimKiemHD.TabIndex = 12;
            this.gbTimKiemHD.TabStop = false;
            this.gbTimKiemHD.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(350, 628);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbQLHD
            // 
            this.lbQLHD.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbQLHD.Location = new System.Drawing.Point(-1, 29);
            this.lbQLHD.Name = "lbQLHD";
            this.lbQLHD.Size = new System.Drawing.Size(821, 44);
            this.lbQLHD.TabIndex = 26;
            this.lbQLHD.Text = "Quản Lý Thông Tin Hóa Đơn";
            this.lbQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maHD
            // 
            this.maHD.Text = "Mã HD";
            this.maHD.Width = 150;
            // 
            // tenNV
            // 
            this.tenNV.Text = "Tên Nhân Viên";
            this.tenNV.Width = 200;
            // 
            // tenKH
            // 
            this.tenKH.Text = "Tên Khách Hàng";
            this.tenKH.Width = 200;
            // 
            // ngayLap
            // 
            this.ngayLap.Text = "Ngày Lập HD";
            this.ngayLap.Width = 150;
            // 
            // thanhTien
            // 
            this.thanhTien.Text = "Thành Tiền";
            this.thanhTien.Width = 150;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maHD,
            this.tenNV,
            this.tenKH,
            this.ngayLap,
            this.thanhTien});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 211);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(768, 390);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 685);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbQLHD);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.gbTimKiemHD);
            this.Controls.Add(this.lbTenNhanVien);
            this.Name = "frmQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.gbTimKiemHD.ResumeLayout(false);
            this.gbTimKiemHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.TextBox tbTenNhanVien;
        private System.Windows.Forms.GroupBox gbTimKiemHD;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbQLHD;
        private System.Windows.Forms.ColumnHeader maHD;
        private System.Windows.Forms.ColumnHeader tenNV;
        private System.Windows.Forms.ColumnHeader tenKH;
        private System.Windows.Forms.ColumnHeader ngayLap;
        private System.Windows.Forms.ColumnHeader thanhTien;
        private System.Windows.Forms.ListView listView1;
    }
}