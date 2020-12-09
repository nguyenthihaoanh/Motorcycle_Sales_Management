
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
            this.lbMatKhau.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbMatKhau.Location = new System.Drawing.Point(72, 215);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(192, 25);
            this.lbMatKhau.TabIndex = 40;
            this.lbMatKhau.Text = "Nhập Lại Mật Khẩu:";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbTaiKhoan.Location = new System.Drawing.Point(72, 164);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(148, 25);
            this.lbTaiKhoan.TabIndex = 39;
            this.lbTaiKhoan.Text = "Mật Khẩu Mới:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbSDT.Location = new System.Drawing.Point(72, 113);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(137, 25);
            this.lbSDT.TabIndex = 38;
            this.lbSDT.Text = "Mật Khẩu Cũ:";
            // 
            // lbThongTin
            // 
            this.lbThongTin.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.Location = new System.Drawing.Point(0, 9);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(862, 71);
            this.lbThongTin.TabIndex = 50;
            this.lbThongTin.Text = "Đổi Mật Khẩu";
            this.lbThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMkMoi
            // 
            this.tbMkMoi.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbMkMoi.Location = new System.Drawing.Point(292, 161);
            this.tbMkMoi.Name = "tbMkMoi";
            this.tbMkMoi.Size = new System.Drawing.Size(488, 32);
            this.tbMkMoi.TabIndex = 52;
            this.tbMkMoi.UseSystemPasswordChar = true;
            // 
            // tbNhapLaiMk
            // 
            this.tbNhapLaiMk.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbNhapLaiMk.Location = new System.Drawing.Point(292, 212);
            this.tbNhapLaiMk.Name = "tbNhapLaiMk";
            this.tbNhapLaiMk.Size = new System.Drawing.Size(488, 32);
            this.tbNhapLaiMk.TabIndex = 53;
            this.tbNhapLaiMk.UseSystemPasswordChar = true;
            // 
            // tbMkCu
            // 
            this.tbMkCu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbMkCu.Location = new System.Drawing.Point(292, 110);
            this.tbMkCu.Name = "tbMkCu";
            this.tbMkCu.Size = new System.Drawing.Size(488, 32);
            this.tbMkCu.TabIndex = 51;
            this.tbMkCu.UseSystemPasswordChar = true;
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.White;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(261, 295);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(119, 45);
            this.btLuu.TabIndex = 54;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btTroVe
            // 
            this.btTroVe.BackColor = System.Drawing.Color.White;
            this.btTroVe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTroVe.Location = new System.Drawing.Point(456, 295);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(119, 45);
            this.btTroVe.TabIndex = 55;
            this.btTroVe.Text = "Trở Về";
            this.btTroVe.UseVisualStyleBackColor = false;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(865, 374);
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
            this.Text = "Đổi Mật Khẩu";
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