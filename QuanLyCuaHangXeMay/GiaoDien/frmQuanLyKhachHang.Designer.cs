﻿namespace QuanLyCuaHangXeMay
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
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbQLKH = new System.Windows.Forms.Label();
            this.lvKH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbKH.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTimTen
            // 
            this.tbTimTen.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbTimTen.Location = new System.Drawing.Point(25, 46);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(274, 32);
            this.tbTimTen.TabIndex = 5;
            // 
            // lbCMND
            // 
            this.lbCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbCMND.Location = new System.Drawing.Point(95, 217);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(84, 25);
            this.lbCMND.TabIndex = 30;
            this.lbCMND.Text = "CMND:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbDiaChi.Location = new System.Drawing.Point(92, 267);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(87, 25);
            this.lbDiaChi.TabIndex = 28;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbTenKH.Location = new System.Drawing.Point(9, 115);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(170, 25);
            this.lbTenKH.TabIndex = 26;
            this.lbTenKH.Text = "Tên Khách Hàng: ";
            // 
            // lbSDT
            // 
            this.lbSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbSDT.Location = new System.Drawing.Point(27, 165);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(152, 25);
            this.lbSDT.TabIndex = 23;
            this.lbSDT.Text = "Số Điện Thoại: ";
            // 
            // lbMaKH
            // 
            this.lbMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbMaKH.Location = new System.Drawing.Point(14, 65);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(165, 25);
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
            this.gbKH.Location = new System.Drawing.Point(757, 33);
            this.gbKH.Name = "gbKH";
            this.gbKH.Size = new System.Drawing.Size(400, 559);
            this.gbKH.TabIndex = 32;
            this.gbKH.TabStop = false;
            this.gbKH.Text = "Thông Tin Khách Hàng";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbDiaChi.Location = new System.Drawing.Point(210, 262);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(172, 32);
            this.tbDiaChi.TabIndex = 61;
            // 
            // tbCMND
            // 
            this.tbCMND.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbCMND.Location = new System.Drawing.Point(210, 214);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(172, 32);
            this.tbCMND.TabIndex = 60;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbSDT.Location = new System.Drawing.Point(210, 162);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(172, 32);
            this.tbSDT.TabIndex = 59;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbTenKH.Location = new System.Drawing.Point(210, 112);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(172, 32);
            this.tbTenKH.TabIndex = 58;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbMaKH.Location = new System.Drawing.Point(210, 62);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(172, 32);
            this.tbMaKH.TabIndex = 57;
            // 
            // btNhapLai
            // 
            this.btNhapLai.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btNhapLai.Location = new System.Drawing.Point(60, 408);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(119, 45);
            this.btNhapLai.TabIndex = 51;
            this.btNhapLai.Text = "Nhập Lại";
            this.btNhapLai.UseVisualStyleBackColor = true;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click_1);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThem.Location = new System.Drawing.Point(60, 329);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 45);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(223, 487);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 20;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btMuaXe
            // 
            this.btMuaXe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btMuaXe.Location = new System.Drawing.Point(223, 408);
            this.btMuaXe.Name = "btMuaXe";
            this.btMuaXe.Size = new System.Drawing.Size(119, 45);
            this.btMuaXe.TabIndex = 21;
            this.btMuaXe.Text = "Mua Xe";
            this.btMuaXe.UseVisualStyleBackColor = true;
            this.btMuaXe.Click += new System.EventHandler(this.btMuaXe_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btLuu.Location = new System.Drawing.Point(60, 487);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(119, 45);
            this.btLuu.TabIndex = 16;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btSua.Location = new System.Drawing.Point(223, 329);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(119, 45);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.tbTimTen);
            this.gbTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbTimKiem.Location = new System.Drawing.Point(217, 52);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(318, 108);
            this.gbTimKiem.TabIndex = 33;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm Kiếm";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbTenNhanVien.Location = new System.Drawing.Point(954, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(203, 23);
            this.lbTenNhanVien.TabIndex = 48;
            this.lbTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbQLKH
            // 
            this.lbQLKH.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbQLKH.Location = new System.Drawing.Point(1, 0);
            this.lbQLKH.Name = "lbQLKH";
            this.lbQLKH.Size = new System.Drawing.Size(750, 44);
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
            this.lvKH.HideSelection = false;
            this.lvKH.Location = new System.Drawing.Point(13, 183);
            this.lvKH.Name = "lvKH";
            this.lvKH.Size = new System.Drawing.Size(727, 382);
            this.lvKH.TabIndex = 50;
            this.lvKH.UseCompatibleStateImageBehavior = false;
            this.lvKH.View = System.Windows.Forms.View.Details;
            this.lvKH.SelectedIndexChanged += new System.EventHandler(this.lvKH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã KH";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên KH";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SĐT";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CMND";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            this.columnHeader5.Width = 200;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 593);
            this.Controls.Add(this.lvKH);
            this.Controls.Add(this.lbQLKH);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbKH);
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            this.gbKH.ResumeLayout(false);
            this.gbKH.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
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
        private System.Windows.Forms.Label lbTenNhanVien;
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
    }
}