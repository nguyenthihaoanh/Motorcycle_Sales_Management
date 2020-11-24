namespace QuanLyCuaHangXeMay
{
    partial class frmThemXe
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
            this.lbThemXe = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbNhanHang = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lbMauXe = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbNhanHang = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbMauXe = new System.Windows.Forms.ComboBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThemXe
            // 
            this.lbThemXe.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbThemXe.Location = new System.Drawing.Point(-2, 9);
            this.lbThemXe.Name = "lbThemXe";
            this.lbThemXe.Size = new System.Drawing.Size(492, 42);
            this.lbThemXe.TabIndex = 40;
            this.lbThemXe.Text = "Thêm Xe";
            this.lbThemXe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbDonGia.Location = new System.Drawing.Point(85, 302);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(94, 25);
            this.lbDonGia.TabIndex = 36;
            this.lbDonGia.Text = "Đơn Giá:";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbSL.Location = new System.Drawing.Point(76, 257);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(103, 25);
            this.lbSL.TabIndex = 35;
            this.lbSL.Text = "Số Lượng:";
            // 
            // lbNhanHang
            // 
            this.lbNhanHang.AutoSize = true;
            this.lbNhanHang.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbNhanHang.Location = new System.Drawing.Point(64, 167);
            this.lbNhanHang.Name = "lbNhanHang";
            this.lbNhanHang.Size = new System.Drawing.Size(115, 25);
            this.lbNhanHang.TabIndex = 34;
            this.lbNhanHang.Text = "Nhãn Hàng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblDonGia.Location = new System.Drawing.Point(211, 302);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(234, 20);
            this.lblDonGia.TabIndex = 39;
            // 
            // lbMauXe
            // 
            this.lbMauXe.AutoSize = true;
            this.lbMauXe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbMauXe.Location = new System.Drawing.Point(90, 212);
            this.lbMauXe.Name = "lbMauXe";
            this.lbMauXe.Size = new System.Drawing.Size(89, 25);
            this.lbMauXe.TabIndex = 44;
            this.lbMauXe.Text = "Màu Xe:";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(326, 405);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 50;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btLuu.Location = new System.Drawing.Point(69, 405);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(119, 45);
            this.btLuu.TabIndex = 49;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nhà Sản Xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nhà Cung Cấp:";
            // 
            // cbNSX
            // 
            this.cbNSX.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Location = new System.Drawing.Point(211, 80);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(234, 33);
            this.cbNSX.TabIndex = 53;
            // 
            // cbNCC
            // 
            this.cbNCC.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(211, 122);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(234, 33);
            this.cbNCC.TabIndex = 54;
            // 
            // cbNhanHang
            // 
            this.cbNhanHang.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbNhanHang.FormattingEnabled = true;
            this.cbNhanHang.Location = new System.Drawing.Point(211, 167);
            this.cbNhanHang.Name = "cbNhanHang";
            this.cbNhanHang.Size = new System.Drawing.Size(234, 33);
            this.cbNhanHang.TabIndex = 55;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.nudSoLuong.Location = new System.Drawing.Point(211, 258);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(47, 32);
            this.nudSoLuong.TabIndex = 59;
            // 
            // cbMauXe
            // 
            this.cbMauXe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbMauXe.FormattingEnabled = true;
            this.cbMauXe.Location = new System.Drawing.Point(211, 212);
            this.cbMauXe.Name = "cbMauXe";
            this.cbMauXe.Size = new System.Drawing.Size(234, 33);
            this.cbMauXe.TabIndex = 58;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.BackColor = System.Drawing.SystemColors.Control;
            this.lblThanhTien.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblThanhTien.Location = new System.Drawing.Point(211, 346);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(234, 20);
            this.lblThanhTien.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label4.Location = new System.Drawing.Point(62, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Thành Tiền:";
            // 
            // frmThemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 471);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.cbMauXe);
            this.Controls.Add(this.cbNhanHang);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.cbNSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.lbMauXe);
            this.Controls.Add(this.lbThemXe);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbNhanHang);
            this.Name = "frmThemXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.Load += new System.EventHandler(this.frmThemXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbThemXe;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbNhanHang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lbMauXe;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.ComboBox cbNhanHang;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbMauXe;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label4;
    }
}