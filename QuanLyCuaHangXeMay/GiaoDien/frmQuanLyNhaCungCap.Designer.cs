namespace QuanLyCuaHangXeMay
{
    partial class frmQuanLyNhaCungCap
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
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.tbTenNCC = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.tbMaNCC = new System.Windows.Forms.TextBox();
            this.lbMa = new System.Windows.Forms.Label();
            this.gbNCC = new System.Windows.Forms.GroupBox();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.lbQLNCC = new System.Windows.Forms.Label();
            this.lvNCC = new System.Windows.Forms.ListView();
            this.MaNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbNCC.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTimTen
            // 
            this.tbTimTen.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbTimTen.Location = new System.Drawing.Point(49, 43);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(187, 34);
            this.tbTimTen.TabIndex = 5;
            this.tbTimTen.TextChanged += new System.EventHandler(this.tbTimTen_TextChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbDiaChi.Location = new System.Drawing.Point(232, 271);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(282, 34);
            this.tbDiaChi.TabIndex = 11;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbDiaChi.Location = new System.Drawing.Point(134, 274);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(92, 27);
            this.lbDiaChi.TabIndex = 10;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // tbTenNCC
            // 
            this.tbTenNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTenNCC.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbTenNCC.Location = new System.Drawing.Point(232, 194);
            this.tbTenNCC.Name = "tbTenNCC";
            this.tbTenNCC.Size = new System.Drawing.Size(282, 34);
            this.tbTenNCC.TabIndex = 9;
            // 
            // lbTen
            // 
            this.lbTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbTen.Location = new System.Drawing.Point(17, 197);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(209, 27);
            this.lbTen.TabIndex = 8;
            this.lbTen.Text = "Tên Nhà Cung Cấp: ";
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMaNCC.Enabled = false;
            this.tbMaNCC.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbMaNCC.Location = new System.Drawing.Point(232, 117);
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.Size = new System.Drawing.Size(282, 34);
            this.tbMaNCC.TabIndex = 5;
            // 
            // lbMa
            // 
            this.lbMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbMa.Location = new System.Drawing.Point(22, 120);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(204, 27);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Mã Nhà Cung Cấp: ";
            // 
            // gbNCC
            // 
            this.gbNCC.Controls.Add(this.btNhapLai);
            this.gbNCC.Controls.Add(this.btThem);
            this.gbNCC.Controls.Add(this.btSua);
            this.gbNCC.Controls.Add(this.btLuu);
            this.gbNCC.Controls.Add(this.btThoat);
            this.gbNCC.Controls.Add(this.label1);
            this.gbNCC.Controls.Add(this.tbEmail);
            this.gbNCC.Controls.Add(this.tbMaNCC);
            this.gbNCC.Controls.Add(this.tbDiaChi);
            this.gbNCC.Controls.Add(this.lbTen);
            this.gbNCC.Controls.Add(this.lbMa);
            this.gbNCC.Controls.Add(this.tbTenNCC);
            this.gbNCC.Controls.Add(this.lbDiaChi);
            this.gbNCC.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbNCC.Location = new System.Drawing.Point(1332, 24);
            this.gbNCC.Name = "gbNCC";
            this.gbNCC.Size = new System.Drawing.Size(558, 678);
            this.gbNCC.TabIndex = 47;
            this.gbNCC.TabStop = false;
            this.gbNCC.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // btNhapLai
            // 
            this.btNhapLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNhapLai.BackColor = System.Drawing.Color.White;
            this.btNhapLai.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btNhapLai.Location = new System.Drawing.Point(295, 484);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(135, 45);
            this.btNhapLai.TabIndex = 54;
            this.btNhapLai.Text = "Nhập Lại";
            this.btNhapLai.UseVisualStyleBackColor = false;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThem.Location = new System.Drawing.Point(132, 423);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(135, 45);
            this.btThem.TabIndex = 51;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btSua.Location = new System.Drawing.Point(295, 423);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(135, 45);
            this.btSua.TabIndex = 52;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLuu.BackColor = System.Drawing.Color.White;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btLuu.Location = new System.Drawing.Point(132, 484);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(135, 45);
            this.btLuu.TabIndex = 50;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(229, 545);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(135, 45);
            this.btThoat.TabIndex = 53;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(152, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 48;
            this.label1.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbEmail.Location = new System.Drawing.Point(232, 348);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(282, 34);
            this.tbEmail.TabIndex = 49;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.tbTimTen);
            this.gbTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbTimKiem.Location = new System.Drawing.Point(586, 67);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(278, 100);
            this.gbTimKiem.TabIndex = 48;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm Kiếm";
            // 
            // lbQLNCC
            // 
            this.lbQLNCC.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbQLNCC.Location = new System.Drawing.Point(-1, 9);
            this.lbQLNCC.Name = "lbQLNCC";
            this.lbQLNCC.Size = new System.Drawing.Size(1327, 44);
            this.lbQLNCC.TabIndex = 50;
            this.lbQLNCC.Text = "Quản Lý Thông Tin Nhà Cung Cấp";
            this.lbQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvNCC
            // 
            this.lvNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNCC,
            this.TenNCC,
            this.diaChi,
            this.email});
            this.lvNCC.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lvNCC.FullRowSelect = true;
            this.lvNCC.GridLines = true;
            this.lvNCC.HideSelection = false;
            this.lvNCC.Location = new System.Drawing.Point(154, 190);
            this.lvNCC.Name = "lvNCC";
            this.lvNCC.Size = new System.Drawing.Size(1142, 521);
            this.lvNCC.TabIndex = 82;
            this.lvNCC.UseCompatibleStateImageBehavior = false;
            this.lvNCC.View = System.Windows.Forms.View.Details;
            this.lvNCC.SelectedIndexChanged += new System.EventHandler(this.lvNCC_SelectedIndexChanged);
            // 
            // MaNCC
            // 
            this.MaNCC.Text = "Mã NCC";
            this.MaNCC.Width = 200;
            // 
            // TenNCC
            // 
            this.TenNCC.Text = "Tên NCC";
            this.TenNCC.Width = 200;
            // 
            // diaChi
            // 
            this.diaChi.Text = "Địa Chỉ";
            this.diaChi.Width = 200;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 200;
            // 
            // frmQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lvNCC);
            this.Controls.Add(this.lbQLNCC);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbNCC);
            this.Name = "frmQuanLyNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyNhaCungCap_Load);
            this.gbNCC.ResumeLayout(false);
            this.gbNCC.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbTimTen;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox tbTenNCC;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox tbMaNCC;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.GroupBox gbNCC;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Label lbQLNCC;
        private System.Windows.Forms.ListView lvNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ColumnHeader MaNCC;
        private System.Windows.Forms.ColumnHeader TenNCC;
        private System.Windows.Forms.ColumnHeader diaChi;
        private System.Windows.Forms.ColumnHeader email;
    }
}