
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
            this.tbTimTen = new System.Windows.Forms.TextBox();
            this.gbNCC = new System.Windows.Forms.GroupBox();
            this.dpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.btThoat = new System.Windows.Forms.Button();
            this.tbTenNSX = new System.Windows.Forms.TextBox();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.lbMa = new System.Windows.Forms.Label();
            this.tbMaNSX = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTimKiem.SuspendLayout();
            this.gbNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 300;
            // 
            // TenNSX
            // 
            this.TenNSX.Text = "Tên NSX";
            this.TenNSX.Width = 300;
            // 
            // MaNSX
            // 
            this.MaNSX.Text = "Mã NSX";
            this.MaNSX.Width = 150;
            // 
            // lvNSX
            // 
            this.lvNSX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNSX,
            this.TenNSX,
            this.diaChi,
            this.email,
            this.nam});
            this.lvNSX.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lvNSX.FullRowSelect = true;
            this.lvNSX.GridLines = true;
            this.lvNSX.HideSelection = false;
            this.lvNSX.Location = new System.Drawing.Point(113, 271);
            this.lvNSX.Name = "lvNSX";
            this.lvNSX.Size = new System.Drawing.Size(1173, 551);
            this.lvNSX.TabIndex = 87;
            this.lvNSX.UseCompatibleStateImageBehavior = false;
            this.lvNSX.View = System.Windows.Forms.View.Details;
            this.lvNSX.SelectedIndexChanged += new System.EventHandler(this.lvNSX_SelectedIndexChanged);
            // 
            // diaChi
            // 
            this.diaChi.Text = "Nước Sản Xuất";
            this.diaChi.Width = 300;
            // 
            // nam
            // 
            this.nam.Text = "Năm Sản Xuất";
            this.nam.Width = 300;
            // 
            // lbQLNCC
            // 
            this.lbQLNCC.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.lbQLNCC.Location = new System.Drawing.Point(-2, 23);
            this.lbQLNCC.Name = "lbQLNCC";
            this.lbQLNCC.Size = new System.Drawing.Size(1310, 44);
            this.lbQLNCC.TabIndex = 86;
            this.lbQLNCC.Text = "Quản Lý Thông Tin Nhà Sản Xuất";
            this.lbQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.label3);
            this.gbTimKiem.Controls.Add(this.tbTimTen);
            this.gbTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbTimKiem.Location = new System.Drawing.Point(565, 119);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(278, 116);
            this.gbTimKiem.TabIndex = 85;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm Kiếm";
            // 
            // tbTimTen
            // 
            this.tbTimTen.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbTimTen.Location = new System.Drawing.Point(41, 43);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(191, 34);
            this.tbTimTen.TabIndex = 5;
            this.tbTimTen.TextChanged += new System.EventHandler(this.tbTimTen_TextChanged);
            // 
            // gbNCC
            // 
            this.gbNCC.Controls.Add(this.dpNgaySX);
            this.gbNCC.Controls.Add(this.btThoat);
            this.gbNCC.Controls.Add(this.tbTenNSX);
            this.gbNCC.Controls.Add(this.btNhapLai);
            this.gbNCC.Controls.Add(this.lbMa);
            this.gbNCC.Controls.Add(this.tbMaNSX);
            this.gbNCC.Controls.Add(this.btThem);
            this.gbNCC.Controls.Add(this.tbEmail);
            this.gbNCC.Controls.Add(this.lbTen);
            this.gbNCC.Controls.Add(this.btSua);
            this.gbNCC.Controls.Add(this.label1);
            this.gbNCC.Controls.Add(this.tbDiaChi);
            this.gbNCC.Controls.Add(this.btLuu);
            this.gbNCC.Controls.Add(this.label2);
            this.gbNCC.Controls.Add(this.lbDiaChi);
            this.gbNCC.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbNCC.Location = new System.Drawing.Point(1314, 56);
            this.gbNCC.Name = "gbNCC";
            this.gbNCC.Size = new System.Drawing.Size(576, 766);
            this.gbNCC.TabIndex = 84;
            this.gbNCC.TabStop = false;
            this.gbNCC.Text = "Thông Tin Nhà Sản Xuất";
            // 
            // dpNgaySX
            // 
            this.dpNgaySX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dpNgaySX.CustomFormat = "dd/MM/yyyy";
            this.dpNgaySX.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpNgaySX.Location = new System.Drawing.Point(255, 399);
            this.dpNgaySX.Name = "dpNgaySX";
            this.dpNgaySX.Size = new System.Drawing.Size(169, 34);
            this.dpNgaySX.TabIndex = 62;
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(236, 666);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(135, 45);
            this.btThoat.TabIndex = 60;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // tbTenNSX
            // 
            this.tbTenNSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTenNSX.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbTenNSX.Location = new System.Drawing.Point(253, 186);
            this.tbTenNSX.Name = "tbTenNSX";
            this.tbTenNSX.Size = new System.Drawing.Size(291, 34);
            this.tbTenNSX.TabIndex = 9;
            // 
            // btNhapLai
            // 
            this.btNhapLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNhapLai.BackColor = System.Drawing.Color.White;
            this.btNhapLai.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btNhapLai.Location = new System.Drawing.Point(309, 581);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(135, 45);
            this.btNhapLai.TabIndex = 61;
            this.btNhapLai.Text = "Nhập Lại";
            this.btNhapLai.UseVisualStyleBackColor = false;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click);
            // 
            // lbMa
            // 
            this.lbMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbMa.Location = new System.Drawing.Point(25, 117);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(196, 27);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Mã Nhà Sản Xuất: ";
            // 
            // tbMaNSX
            // 
            this.tbMaNSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMaNSX.Enabled = false;
            this.tbMaNSX.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbMaNSX.Location = new System.Drawing.Point(253, 114);
            this.tbMaNSX.Name = "tbMaNSX";
            this.tbMaNSX.Size = new System.Drawing.Size(291, 34);
            this.tbMaNSX.TabIndex = 5;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThem.Location = new System.Drawing.Point(146, 493);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(135, 45);
            this.btThem.TabIndex = 58;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbEmail.Location = new System.Drawing.Point(253, 330);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(291, 34);
            this.tbEmail.TabIndex = 49;
            // 
            // lbTen
            // 
            this.lbTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbTen.Location = new System.Drawing.Point(20, 189);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(201, 27);
            this.lbTen.TabIndex = 8;
            this.lbTen.Text = "Tên Nhà Sản Xuất: ";
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btSua.Location = new System.Drawing.Point(309, 493);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(135, 45);
            this.btSua.TabIndex = 59;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(137, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 48;
            this.label1.Text = "Email:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbDiaChi.Location = new System.Drawing.Point(255, 258);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(291, 34);
            this.tbDiaChi.TabIndex = 11;
            // 
            // btLuu
            // 
            this.btLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLuu.BackColor = System.Drawing.Color.White;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btLuu.Location = new System.Drawing.Point(146, 581);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(135, 45);
            this.btLuu.TabIndex = 57;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(60, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "Năm Sản Xuất:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbDiaChi.Location = new System.Drawing.Point(52, 261);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(166, 27);
            this.lbDiaChi.TabIndex = 10;
            this.lbDiaChi.Text = "Nước Sản Xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "*tìm theo tên nhà sản xuất";
            // 
            // frmQuanLyNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lvNSX);
            this.Controls.Add(this.lbQLNCC);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbNCC);
            this.Name = "frmQuanLyNhaSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhaSanXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader nam;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DateTimePicker dpNgaySX;
        private System.Windows.Forms.Label label3;
    }
}