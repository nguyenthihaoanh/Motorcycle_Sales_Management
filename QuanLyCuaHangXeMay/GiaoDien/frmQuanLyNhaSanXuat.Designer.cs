
namespace QuanLyCuaHangXeMay.GiaoDien
{
    partial class frmQuanLyNhaSanXuat
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
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNSX = new System.Windows.Forms.ListView();
            this.diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbQLNCC = new System.Windows.Forms.Label();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.rbTimTen = new System.Windows.Forms.RadioButton();
            this.tbTimTen = new System.Windows.Forms.TextBox();
            this.gbNCC = new System.Windows.Forms.GroupBox();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbMa = new System.Windows.Forms.Label();
            this.tbTenNSX = new System.Windows.Forms.TextBox();
            this.tbMaNSX = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.dpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.gbTimKiem.SuspendLayout();
            this.gbNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 200;
            // 
            // TenNSX
            // 
            this.TenNSX.Text = "Tên NSX";
            this.TenNSX.Width = 130;
            // 
            // MaNSX
            // 
            this.MaNSX.Text = "Mã NSX";
            this.MaNSX.Width = 100;
            // 
            // lvNSX
            // 
            this.lvNSX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNSX,
            this.TenNSX,
            this.diaChi,
            this.email,
            this.nam});
            this.lvNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lvNSX.FullRowSelect = true;
            this.lvNSX.HideSelection = false;
            this.lvNSX.Location = new System.Drawing.Point(24, 179);
            this.lvNSX.Name = "lvNSX";
            this.lvNSX.Size = new System.Drawing.Size(690, 306);
            this.lvNSX.TabIndex = 87;
            this.lvNSX.UseCompatibleStateImageBehavior = false;
            this.lvNSX.View = System.Windows.Forms.View.Details;
            this.lvNSX.SelectedIndexChanged += new System.EventHandler(this.lvNSX_SelectedIndexChanged);
            // 
            // diaChi
            // 
            this.diaChi.Text = "Địa Chỉ";
            this.diaChi.Width = 200;
            // 
            // nam
            // 
            this.nam.Text = "Năm Sản Xuất";
            this.nam.Width = 80;
            // 
            // lbQLNCC
            // 
            this.lbQLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLNCC.Location = new System.Drawing.Point(0, -2);
            this.lbQLNCC.Name = "lbQLNCC";
            this.lbQLNCC.Size = new System.Drawing.Size(731, 44);
            this.lbQLNCC.TabIndex = 86;
            this.lbQLNCC.Text = "Quản Lý Thông Tin Nhà Sản Xuất";
            this.lbQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.rbTimTen);
            this.gbTimKiem.Controls.Add(this.tbTimTen);
            this.gbTimKiem.Location = new System.Drawing.Point(226, 56);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(278, 100);
            this.gbTimKiem.TabIndex = 85;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm Kiếm";
            // 
            // rbTimTen
            // 
            this.rbTimTen.AutoSize = true;
            this.rbTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbTimTen.Location = new System.Drawing.Point(61, 21);
            this.rbTimTen.Name = "rbTimTen";
            this.rbTimTen.Size = new System.Drawing.Size(121, 22);
            this.rbTimTen.TabIndex = 8;
            this.rbTimTen.TabStop = true;
            this.rbTimTen.Text = "Tìm Theo Tên";
            this.rbTimTen.UseVisualStyleBackColor = true;
            // 
            // tbTimTen
            // 
            this.tbTimTen.Location = new System.Drawing.Point(86, 66);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(144, 22);
            this.tbTimTen.TabIndex = 5;
            // 
            // gbNCC
            // 
            this.gbNCC.Controls.Add(this.dpNgaySX);
            this.gbNCC.Controls.Add(this.btNhapLai);
            this.gbNCC.Controls.Add(this.btThem);
            this.gbNCC.Controls.Add(this.btSua);
            this.gbNCC.Controls.Add(this.btLuu);
            this.gbNCC.Controls.Add(this.btThoat);
            this.gbNCC.Controls.Add(this.label2);
            this.gbNCC.Controls.Add(this.label1);
            this.gbNCC.Controls.Add(this.tbEmail);
            this.gbNCC.Controls.Add(this.lbMa);
            this.gbNCC.Controls.Add(this.tbTenNSX);
            this.gbNCC.Controls.Add(this.tbMaNSX);
            this.gbNCC.Controls.Add(this.lbTen);
            this.gbNCC.Controls.Add(this.lbDiaChi);
            this.gbNCC.Controls.Add(this.tbDiaChi);
            this.gbNCC.Location = new System.Drawing.Point(737, 33);
            this.gbNCC.Name = "gbNCC";
            this.gbNCC.Size = new System.Drawing.Size(365, 478);
            this.gbNCC.TabIndex = 84;
            this.gbNCC.TabStop = false;
            this.gbNCC.Text = "Thông Tin Nhà Sản Xuất";
            // 
            // btNhapLai
            // 
            this.btNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btNhapLai.Location = new System.Drawing.Point(206, 339);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(119, 45);
            this.btNhapLai.TabIndex = 61;
            this.btNhapLai.Text = "Nhập Lại";
            this.btNhapLai.UseVisualStyleBackColor = true;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThem.Location = new System.Drawing.Point(43, 274);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 45);
            this.btThem.TabIndex = 58;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btSua.Location = new System.Drawing.Point(206, 274);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(119, 45);
            this.btSua.TabIndex = 59;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btLuu.Location = new System.Drawing.Point(43, 339);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(119, 45);
            this.btLuu.TabIndex = 57;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(133, 407);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 60;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Năm Sản Xuất:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEmail.Location = new System.Drawing.Point(190, 168);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(153, 26);
            this.tbEmail.TabIndex = 49;
            // 
            // lbMa
            // 
            this.lbMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMa.Location = new System.Drawing.Point(24, 48);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(150, 20);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Mã Nhà Sản Xuất: ";
            // 
            // tbTenNSX
            // 
            this.tbTenNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTenNSX.Location = new System.Drawing.Point(190, 86);
            this.tbTenNSX.Name = "tbTenNSX";
            this.tbTenNSX.Size = new System.Drawing.Size(153, 26);
            this.tbTenNSX.TabIndex = 9;
            // 
            // tbMaNSX
            // 
            this.tbMaNSX.Enabled = false;
            this.tbMaNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbMaNSX.Location = new System.Drawing.Point(190, 45);
            this.tbMaNSX.Name = "tbMaNSX";
            this.tbMaNSX.Size = new System.Drawing.Size(153, 26);
            this.tbMaNSX.TabIndex = 5;
            // 
            // lbTen
            // 
            this.lbTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTen.Location = new System.Drawing.Point(24, 89);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(155, 20);
            this.lbTen.TabIndex = 8;
            this.lbTen.Text = "Tên Nhà Sản Xuất: ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDiaChi.Location = new System.Drawing.Point(24, 130);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(69, 20);
            this.lbDiaChi.TabIndex = 10;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDiaChi.Location = new System.Drawing.Point(190, 127);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(153, 26);
            this.tbDiaChi.TabIndex = 11;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTenNhanVien.Location = new System.Drawing.Point(899, -2);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(203, 23);
            this.lbTenNhanVien.TabIndex = 83;
            this.lbTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dpNgaySX
            // 
            this.dpNgaySX.Location = new System.Drawing.Point(133, 210);
            this.dpNgaySX.Name = "dpNgaySX";
            this.dpNgaySX.Size = new System.Drawing.Size(226, 22);
            this.dpNgaySX.TabIndex = 62;
            // 
            // frmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 514);
            this.Controls.Add(this.lvNSX);
            this.Controls.Add(this.lbQLNCC);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbNCC);
            this.Controls.Add(this.lbTenNhanVien);
            this.Name = "frmNhaSanXuat";
            this.Text = "frmNhaSanXuat";
            this.Load += new System.EventHandler(this.frmNhaSanXuat_Load);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbNCC.ResumeLayout(false);
            this.gbNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader TenNSX;
        private System.Windows.Forms.ColumnHeader MaNSX;
        private System.Windows.Forms.ListView lvNSX;
        private System.Windows.Forms.ColumnHeader diaChi;
        private System.Windows.Forms.Label lbQLNCC;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.RadioButton rbTimTen;
        private System.Windows.Forms.TextBox tbTimTen;
        private System.Windows.Forms.GroupBox gbNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.TextBox tbTenNSX;
        private System.Windows.Forms.TextBox tbMaNSX;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader nam;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DateTimePicker dpNgaySX;
    }
}