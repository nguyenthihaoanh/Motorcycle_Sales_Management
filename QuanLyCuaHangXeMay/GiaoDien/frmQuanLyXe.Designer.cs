namespace QuanLyCuaHangXeMay
{
    partial class frmQuanLyXe
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
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.dGVDanhSachXe = new System.Windows.Forms.DataGridView();
            this.lbSL = new System.Windows.Forms.Label();
            this.rbTimTen = new System.Windows.Forms.RadioButton();
            this.lbNCC = new System.Windows.Forms.Label();
            this.lbGiaNhap = new System.Windows.Forms.Label();
            this.lbMaXe = new System.Windows.Forms.Label();
            this.lbMauXe = new System.Windows.Forms.Label();
            this.lbNhanHieu = new System.Windows.Forms.Label();
            this.lbDungTich = new System.Windows.Forms.Label();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.tbTimTen = new System.Windows.Forms.TextBox();
            this.tbTimSDT = new System.Windows.Forms.TextBox();
            this.rbTimSĐT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinXe = new System.Windows.Forms.GroupBox();
            this.tbDungTich = new System.Windows.Forms.TextBox();
            this.cbMauXe = new System.Windows.Forms.ComboBox();
            this.tbNhanHieu = new System.Windows.Forms.TextBox();
            this.tbMaXe = new System.Windows.Forms.TextBox();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.gbTImKiem = new System.Windows.Forms.GroupBox();
            this.lbQLXe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachXe)).BeginInit();
            this.gbThongTinXe.SuspendLayout();
            this.gbTImKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThem.Location = new System.Drawing.Point(20, 502);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 45);
            this.btThem.TabIndex = 27;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btSua.Location = new System.Drawing.Point(197, 502);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(119, 45);
            this.btSua.TabIndex = 28;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btLuu.Location = new System.Drawing.Point(20, 576);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(119, 45);
            this.btLuu.TabIndex = 26;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(107, 650);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 29;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dGVDanhSachXe
            // 
            this.dGVDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachXe.Location = new System.Drawing.Point(35, 234);
            this.dGVDanhSachXe.Name = "dGVDanhSachXe";
            this.dGVDanhSachXe.RowHeadersWidth = 51;
            this.dGVDanhSachXe.RowTemplate.Height = 24;
            this.dGVDanhSachXe.Size = new System.Drawing.Size(721, 487);
            this.dGVDanhSachXe.TabIndex = 38;
            // 
            // lbSL
            // 
            this.lbSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSL.Location = new System.Drawing.Point(40, 348);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(85, 20);
            this.lbSL.TabIndex = 74;
            this.lbSL.Text = "Số Lượng:";
            // 
            // rbTimTen
            // 
            this.rbTimTen.AutoSize = true;
            this.rbTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbTimTen.Location = new System.Drawing.Point(59, 30);
            this.rbTimTen.Name = "rbTimTen";
            this.rbTimTen.Size = new System.Drawing.Size(121, 22);
            this.rbTimTen.TabIndex = 8;
            this.rbTimTen.TabStop = true;
            this.rbTimTen.Text = "Tìm Theo Tên";
            this.rbTimTen.UseVisualStyleBackColor = true;
            // 
            // lbNCC
            // 
            this.lbNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNCC.AutoSize = true;
            this.lbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNCC.Location = new System.Drawing.Point(2, 218);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(123, 20);
            this.lbNCC.TabIndex = 23;
            this.lbNCC.Text = "Nhà Cung Cấp:";
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGiaNhap.AutoSize = true;
            this.lbGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGiaNhap.Location = new System.Drawing.Point(41, 390);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(84, 20);
            this.lbGiaNhap.TabIndex = 19;
            this.lbGiaNhap.Text = "Giá Nhập:";
            // 
            // lbMaXe
            // 
            this.lbMaXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaXe.AutoSize = true;
            this.lbMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMaXe.Location = new System.Drawing.Point(58, 48);
            this.lbMaXe.Name = "lbMaXe";
            this.lbMaXe.Size = new System.Drawing.Size(67, 20);
            this.lbMaXe.TabIndex = 1;
            this.lbMaXe.Text = "Mã Xe: ";
            // 
            // lbMauXe
            // 
            this.lbMauXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMauXe.AutoSize = true;
            this.lbMauXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMauXe.Location = new System.Drawing.Point(54, 132);
            this.lbMauXe.Name = "lbMauXe";
            this.lbMauXe.Size = new System.Drawing.Size(71, 20);
            this.lbMauXe.TabIndex = 2;
            this.lbMauXe.Text = "Màu Xe:";
            // 
            // lbNhanHieu
            // 
            this.lbNhanHieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNhanHieu.AutoSize = true;
            this.lbNhanHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNhanHieu.Location = new System.Drawing.Point(32, 90);
            this.lbNhanHieu.Name = "lbNhanHieu";
            this.lbNhanHieu.Size = new System.Drawing.Size(93, 20);
            this.lbNhanHieu.TabIndex = 64;
            this.lbNhanHieu.Text = "Nhãn Hiệu:";
            // 
            // lbDungTich
            // 
            this.lbDungTich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDungTich.AutoSize = true;
            this.lbDungTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDungTich.Location = new System.Drawing.Point(34, 176);
            this.lbDungTich.Name = "lbDungTich";
            this.lbDungTich.Size = new System.Drawing.Size(91, 20);
            this.lbDungTich.TabIndex = 12;
            this.lbDungTich.Text = "Dung Tích:";
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGiaBan.Location = new System.Drawing.Point(50, 306);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(75, 20);
            this.lbGiaBan.TabIndex = 10;
            this.lbGiaBan.Text = "Giá Bán:";
            // 
            // tbTimTen
            // 
            this.tbTimTen.Location = new System.Drawing.Point(59, 80);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(147, 22);
            this.tbTimTen.TabIndex = 5;
            // 
            // tbTimSDT
            // 
            this.tbTimSDT.Location = new System.Drawing.Point(317, 80);
            this.tbTimSDT.Name = "tbTimSDT";
            this.tbTimSDT.Size = new System.Drawing.Size(147, 22);
            this.tbTimSDT.TabIndex = 6;
            // 
            // rbTimSĐT
            // 
            this.rbTimSĐT.AutoSize = true;
            this.rbTimSĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbTimSĐT.Location = new System.Drawing.Point(317, 30);
            this.rbTimSĐT.Name = "rbTimSĐT";
            this.rbTimSĐT.Size = new System.Drawing.Size(126, 22);
            this.rbTimSĐT.TabIndex = 7;
            this.rbTimSĐT.TabStop = true;
            this.rbTimSĐT.Text = "Tìm Theo SĐT";
            this.rbTimSĐT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(910, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 77;
            // 
            // gbThongTinXe
            // 
            this.gbThongTinXe.Controls.Add(this.dateNgayNhap);
            this.gbThongTinXe.Controls.Add(this.label3);
            this.gbThongTinXe.Controls.Add(this.tbGiaNhap);
            this.gbThongTinXe.Controls.Add(this.tbSoLuong);
            this.gbThongTinXe.Controls.Add(this.tbGiaBan);
            this.gbThongTinXe.Controls.Add(this.cbNSX);
            this.gbThongTinXe.Controls.Add(this.cbNCC);
            this.gbThongTinXe.Controls.Add(this.label2);
            this.gbThongTinXe.Controls.Add(this.tbDungTich);
            this.gbThongTinXe.Controls.Add(this.cbMauXe);
            this.gbThongTinXe.Controls.Add(this.tbNhanHieu);
            this.gbThongTinXe.Controls.Add(this.tbMaXe);
            this.gbThongTinXe.Controls.Add(this.btNhapLai);
            this.gbThongTinXe.Controls.Add(this.lbMaXe);
            this.gbThongTinXe.Controls.Add(this.lbDungTich);
            this.gbThongTinXe.Controls.Add(this.btThem);
            this.gbThongTinXe.Controls.Add(this.btThoat);
            this.gbThongTinXe.Controls.Add(this.btLuu);
            this.gbThongTinXe.Controls.Add(this.btSua);
            this.gbThongTinXe.Controls.Add(this.lbGiaBan);
            this.gbThongTinXe.Controls.Add(this.lbNhanHieu);
            this.gbThongTinXe.Controls.Add(this.lbSL);
            this.gbThongTinXe.Controls.Add(this.lbMauXe);
            this.gbThongTinXe.Controls.Add(this.lbNCC);
            this.gbThongTinXe.Controls.Add(this.lbGiaNhap);
            this.gbThongTinXe.Location = new System.Drawing.Point(799, 26);
            this.gbThongTinXe.Name = "gbThongTinXe";
            this.gbThongTinXe.Size = new System.Drawing.Size(396, 706);
            this.gbThongTinXe.TabIndex = 78;
            this.gbThongTinXe.TabStop = false;
            this.gbThongTinXe.Text = "Thông Tin Xe";
            // 
            // tbDungTich
            // 
            this.tbDungTich.Location = new System.Drawing.Point(151, 176);
            this.tbDungTich.Name = "tbDungTich";
            this.tbDungTich.Size = new System.Drawing.Size(224, 22);
            this.tbDungTich.TabIndex = 80;
            // 
            // cbMauXe
            // 
            this.cbMauXe.FormattingEnabled = true;
            this.cbMauXe.Location = new System.Drawing.Point(151, 132);
            this.cbMauXe.Name = "cbMauXe";
            this.cbMauXe.Size = new System.Drawing.Size(224, 24);
            this.cbMauXe.TabIndex = 79;
            // 
            // tbNhanHieu
            // 
            this.tbNhanHieu.Location = new System.Drawing.Point(151, 90);
            this.tbNhanHieu.Name = "tbNhanHieu";
            this.tbNhanHieu.Size = new System.Drawing.Size(224, 22);
            this.tbNhanHieu.TabIndex = 78;
            // 
            // tbMaXe
            // 
            this.tbMaXe.Location = new System.Drawing.Point(151, 48);
            this.tbMaXe.Name = "tbMaXe";
            this.tbMaXe.Size = new System.Drawing.Size(224, 22);
            this.tbMaXe.TabIndex = 77;
            // 
            // btNhapLai
            // 
            this.btNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btNhapLai.Location = new System.Drawing.Point(197, 576);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(119, 45);
            this.btNhapLai.TabIndex = 76;
            this.btNhapLai.Text = "Nhập Lại";
            this.btNhapLai.UseVisualStyleBackColor = true;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click);
            // 
            // gbTImKiem
            // 
            this.gbTImKiem.Controls.Add(this.rbTimTen);
            this.gbTImKiem.Controls.Add(this.tbTimTen);
            this.gbTImKiem.Controls.Add(this.rbTimSĐT);
            this.gbTImKiem.Controls.Add(this.tbTimSDT);
            this.gbTImKiem.Location = new System.Drawing.Point(111, 69);
            this.gbTImKiem.Name = "gbTImKiem";
            this.gbTImKiem.Size = new System.Drawing.Size(569, 137);
            this.gbTImKiem.TabIndex = 79;
            this.gbTImKiem.TabStop = false;
            this.gbTImKiem.Text = "TÌm Kiếm";
            // 
            // lbQLXe
            // 
            this.lbQLXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLXe.Location = new System.Drawing.Point(-2, 0);
            this.lbQLXe.Name = "lbQLXe";
            this.lbQLXe.Size = new System.Drawing.Size(795, 44);
            this.lbQLXe.TabIndex = 80;
            this.lbQLXe.Text = "Quản Lý Thông Tin Xe";
            this.lbQLXe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Nhà Sản Xuất:";
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(151, 218);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(224, 24);
            this.cbNCC.TabIndex = 87;
            // 
            // cbNSX
            // 
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Location = new System.Drawing.Point(151, 262);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(224, 24);
            this.cbNSX.TabIndex = 88;
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Location = new System.Drawing.Point(151, 306);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(224, 22);
            this.tbGiaBan.TabIndex = 89;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(151, 348);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(224, 22);
            this.tbSoLuong.TabIndex = 90;
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(151, 390);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(224, 22);
            this.tbGiaNhap.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(29, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Ngày Nhập:";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.Location = new System.Drawing.Point(151, 432);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(224, 22);
            this.dateNgayNhap.TabIndex = 93;
            // 
            // frmQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 744);
            this.Controls.Add(this.lbQLXe);
            this.Controls.Add(this.gbTImKiem);
            this.Controls.Add(this.gbThongTinXe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVDanhSachXe);
            this.Name = "frmQuanLyXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachXe)).EndInit();
            this.gbThongTinXe.ResumeLayout(false);
            this.gbThongTinXe.PerformLayout();
            this.gbTImKiem.ResumeLayout(false);
            this.gbTImKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dGVDanhSachXe;
        private System.Windows.Forms.TextBox tbTimSDT;
        private System.Windows.Forms.RadioButton rbTimSĐT;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.RadioButton rbTimTen;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.Label lbGiaNhap;
        private System.Windows.Forms.Label lbMaXe;
        private System.Windows.Forms.Label lbMauXe;
        private System.Windows.Forms.Label lbNhanHieu;
        private System.Windows.Forms.Label lbDungTich;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.TextBox tbTimTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinXe;
        private System.Windows.Forms.GroupBox gbTImKiem;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.Label lbQLXe;
        private System.Windows.Forms.TextBox tbMaXe;
        private System.Windows.Forms.TextBox tbDungTich;
        private System.Windows.Forms.ComboBox cbMauXe;
        private System.Windows.Forms.TextBox tbNhanHieu;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label label2;
    }
}