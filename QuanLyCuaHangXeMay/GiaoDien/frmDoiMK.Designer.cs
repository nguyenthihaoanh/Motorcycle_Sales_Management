
namespace QuanLyCuaHangXeMay.GiaoDien
{
    partial class frmDoiMK
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
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.tbMkMoi = new System.Windows.Forms.TextBox();
            this.tbNhapLaiMk = new System.Windows.Forms.TextBox();
            this.tbMkCu = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btTroVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMatKhau.Location = new System.Drawing.Point(30, 214);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(186, 25);
            this.lbMatKhau.TabIndex = 40;
            this.lbMatKhau.Text = "Nhập Lại Mật Khẩu:";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTaiKhoan.Location = new System.Drawing.Point(30, 163);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(140, 25);
            this.lbTaiKhoan.TabIndex = 39;
            this.lbTaiKhoan.Text = "Mật Khẩu Mới:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSDT.Location = new System.Drawing.Point(30, 112);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(134, 25);
            this.lbSDT.TabIndex = 38;
            this.lbSDT.Text = "Mật Khẩu Cũ:";
            // 
            // lbThongTin
            // 
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.Location = new System.Drawing.Point(0, 9);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(484, 71);
            this.lbThongTin.TabIndex = 50;
            this.lbThongTin.Text = "Đổi Mật Khẩu";
            this.lbThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMkMoi
            // 
            this.tbMkMoi.Location = new System.Drawing.Point(231, 167);
            this.tbMkMoi.Name = "tbMkMoi";
            this.tbMkMoi.Size = new System.Drawing.Size(226, 22);
            this.tbMkMoi.TabIndex = 52;
            // 
            // tbNhapLaiMk
            // 
            this.tbNhapLaiMk.Location = new System.Drawing.Point(231, 218);
            this.tbNhapLaiMk.Name = "tbNhapLaiMk";
            this.tbNhapLaiMk.Size = new System.Drawing.Size(226, 22);
            this.tbNhapLaiMk.TabIndex = 53;
            // 
            // tbMkCu
            // 
            this.tbMkCu.Location = new System.Drawing.Point(231, 116);
            this.tbMkCu.Name = "tbMkCu";
            this.tbMkCu.Size = new System.Drawing.Size(226, 22);
            this.tbMkCu.TabIndex = 51;
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(97, 303);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(119, 45);
            this.btLuu.TabIndex = 54;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btTroVe
            // 
            this.btTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTroVe.Location = new System.Drawing.Point(292, 303);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(119, 45);
            this.btTroVe.TabIndex = 55;
            this.btTroVe.Text = "Trở Về";
            this.btTroVe.UseVisualStyleBackColor = true;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbMkMoi);
            this.Controls.Add(this.tbNhapLaiMk);
            this.Controls.Add(this.tbMkCu);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.lbSDT);
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.TextBox tbMkMoi;
        private System.Windows.Forms.TextBox tbNhapLaiMk;
        private System.Windows.Forms.TextBox tbMkCu;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btTroVe;
    }
}