namespace QuanLyCuaHangXeMay
{
    partial class frmQuanLyKhachHang
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
            this.tbTimTen = new System.Windows.Forms.TextBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.gbKH = new System.Windows.Forms.GroupBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btMuaXe = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.lbQLKH = new System.Windows.Forms.Label();
            this.lvKH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKH.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTimTen
            // 
            this.tbTimTen.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbTimTen.Location = new System.Drawing.Point(25, 46);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(274, 32);
            this.tbTimTen.TabIndex = 5;
            this.tbTimTen.TextChanged += new System.EventHandler(this.tbTimTen_TextChanged);
            // 
            // lbCMND
            // 
            this.lbCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbCMND.Location = new System.Drawing.Point(111, 280);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(89, 27);
            this.lbCMND.TabIndex = 30;
            this.lbCMND.Text = "CMND:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbDiaChi.Location = new System.Drawing.Point(108, 353);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(92, 27);
            this.lbDiaChi.TabIndex = 28;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbTenKH.Location = new System.Drawing.Point(13, 134);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(187, 27);
            this.lbTenKH.TabIndex = 26;
            this.lbTenKH.Text = "Tên Khách Hàng: ";
            // 
            // lbSDT
            // 
            this.lbSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbSDT.Location = new System.Drawing.Point(39, 207);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(161, 27);
            this.lbSDT.TabIndex = 23;
            this.lbSDT.Text = "Số Điện Thoại: ";
            // 
            // lbMaKH
            // 
            this.lbMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbMaKH.Location = new System.Drawing.Point(18, 61);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(182, 27);
            this.lbMaKH.TabIndex = 22;
            this.lbMaKH.Text = "Mã Khách Hàng: ";
            // 
            // gbKH
            // 
            this.gbKH.Controls.Add(this.tbDiaChi);
            this.gbKH.Controls.Add(this.tbCMND);
            this.gbKH.Controls.Add(this.tbSDT);
            this.gbKH.Controls.Add(this.tbTenKH);
            this.gbKH.Controls.Add(this.tbMaKH);
            this.gbKH.Controls.Add(this.btNhapLai);
            this.gbKH.Controls.Add(this.lbMaKH);
            this.gbKH.Controls.Add(this.btThem);
            this.gbKH.Controls.Add(this.btThoat);
            this.gbKH.Controls.Add(this.btMuaXe);
            this.gbKH.Controls.Add(this.btLuu);
            this.gbKH.Controls.Add(this.btSua);
            this.gbKH.Controls.Add(this.lbTenKH);
            this.gbKH.Controls.Add(this.lbSDT);
            this.gbKH.Controls.Add(this.lbCMND);
            this.gbKH.Controls.Add(this.lbDiaChi);
            this.gbKH.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbKH.Location = new System.Drawing.Point(1301, 74);
            this.gbKH.Name = "gbKH";
            this.gbKH.Size = new System.Drawing.Size(573, 725);
            this.gbKH.TabIndex = 32;
            this.gbKH.TabStop = false;
            this.gbKH.Text = "Thông Tin Khách Hàng";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbDiaChi.Location = new System.Drawing.Point(239, 350);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(316, 34);
            this.tbDiaChi.TabIndex = 61;
            // 
            // tbCMND
            // 
            this.tbCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCMND.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbCMND.Location = new System.Drawing.Point(239, 277);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(316, 34);
            this.tbCMND.TabIndex = 60;
            // 
            // tbSDT
            // 
            this.tbSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSDT.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbSDT.Location = new System.Drawing.Point(239, 204);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(316, 34);
            this.tbSDT.TabIndex = 59;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTenKH.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbTenKH.Location = new System.Drawing.Point(239, 131);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(316, 34);
            this.tbTenKH.TabIndex = 58;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbMaKH.Location = new System.Drawing.Point(239, 58);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(316, 34);
            this.tbMaKH.TabIndex = 57;
            // 
            // btNhapLai
            // 
            this.btNhapLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNhapLai.BackColor = System.Drawing.Color.White;
            this.btNhapLai.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btNhapLai.Location = new System.Drawing.Point(134, 567);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(135, 45);
            this.btNhapLai.TabIndex = 51;
            this.btNhapLai.Text = "Nhập Lại";
            this.btNhapLai.UseVisualStyleBackColor = false;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click_1);
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThem.Location = new System.Drawing.Point(134, 488);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(135, 45);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(297, 646);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(135, 45);
            this.btThoat.TabIndex = 20;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btMuaXe
            // 
            this.btMuaXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMuaXe.BackColor = System.Drawing.Color.White;
            this.btMuaXe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btMuaXe.Location = new System.Drawing.Point(297, 567);
            this.btMuaXe.Name = "btMuaXe";
            this.btMuaXe.Size = new System.Drawing.Size(135, 45);
            this.btMuaXe.TabIndex = 21;
            this.btMuaXe.Text = "Mua Xe";
            this.btMuaXe.UseVisualStyleBackColor = false;
            this.btMuaXe.Click += new System.EventHandler(this.btMuaXe_Click);
            // 
            // btLuu
            // 
            this.btLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLuu.BackColor = System.Drawing.Color.White;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btLuu.Location = new System.Drawing.Point(134, 646);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(135, 45);
            this.btLuu.TabIndex = 16;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btSua.Location = new System.Drawing.Point(297, 488);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(135, 45);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.label1);
            this.gbTimKiem.Controls.Add(this.tbTimTen);
            this.gbTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbTimKiem.Location = new System.Drawing.Point(543, 131);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(318, 108);
            this.gbTimKiem.TabIndex = 33;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm Kiếm";
            // 
            // lbQLKH
            // 
            this.lbQLKH.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.lbQLKH.Location = new System.Drawing.Point(-4, 79);
            this.lbQLKH.Name = "lbQLKH";
            this.lbQLKH.Size = new System.Drawing.Size(1299, 44);
            this.lbQLKH.TabIndex = 49;
            this.lbQLKH.Text = "Quản Lý Thông Tin Khách Hàng";
            this.lbQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvKH
            // 
            this.lvKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvKH.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lvKH.FullRowSelect = true;
            this.lvKH.GridLines = true;
            this.lvKH.HideSelection = false;
            this.lvKH.Location = new System.Drawing.Point(128, 262);
            this.lvKH.Name = "lvKH";
            this.lvKH.Size = new System.Drawing.Size(1148, 537);
            this.lvKH.TabIndex = 50;
            this.lvKH.UseCompatibleStateImageBehavior = false;
            this.lvKH.View = System.Windows.Forms.View.Details;
            this.lvKH.SelectedIndexChanged += new System.EventHandler(this.lvKH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã KH";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên KH";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SĐT";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CMND";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            this.columnHeader5.Width = 250;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.lvKH);
            this.panel1.Controls.Add(this.gbKH);
            this.panel1.Controls.Add(this.lbQLKH);
            this.panel1.Controls.Add(this.gbTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 1033);
            this.panel1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "*tìm theo tên khách hàng";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            this.gbKH.ResumeLayout(false);
            this.gbKH.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbTimTen;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.GroupBox gbKH;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Label lbQLKH;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btMuaXe;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.ListView lvKH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}