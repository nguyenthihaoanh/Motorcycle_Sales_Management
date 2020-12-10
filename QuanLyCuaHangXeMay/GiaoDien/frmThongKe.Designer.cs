namespace QuanLyCuaHangXeMay
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btThoat = new System.Windows.Forms.Button();
            this.gbThongKe = new System.Windows.Forms.GroupBox();
            this.rbThongkeTheoThang = new System.Windows.Forms.RadioButton();
            this.rbThongKeTheoNV = new System.Windows.Forms.RadioButton();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lbQLThongKe = new System.Windows.Forms.Label();
            this.chart_thang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_nv = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(893, 921);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 38;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // gbThongKe
            // 
            this.gbThongKe.Controls.Add(this.rbThongkeTheoThang);
            this.gbThongKe.Controls.Add(this.rbThongKeTheoNV);
            this.gbThongKe.Controls.Add(this.dateTimePickerTo);
            this.gbThongKe.Controls.Add(this.dateTimePickerFrom);
            this.gbThongKe.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbThongKe.Location = new System.Drawing.Point(623, 92);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Size = new System.Drawing.Size(709, 128);
            this.gbThongKe.TabIndex = 48;
            this.gbThongKe.TabStop = false;
            this.gbThongKe.Text = "Thống Kê Doanh Thu";
            // 
            // rbThongkeTheoThang
            // 
            this.rbThongkeTheoThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbThongkeTheoThang.AutoSize = true;
            this.rbThongkeTheoThang.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbThongkeTheoThang.Location = new System.Drawing.Point(6, 81);
            this.rbThongkeTheoThang.Name = "rbThongkeTheoThang";
            this.rbThongkeTheoThang.Size = new System.Drawing.Size(249, 31);
            this.rbThongkeTheoThang.TabIndex = 1;
            this.rbThongkeTheoThang.TabStop = true;
            this.rbThongkeTheoThang.Text = "Thống Kê Theo Tháng";
            this.rbThongkeTheoThang.UseVisualStyleBackColor = true;
            this.rbThongkeTheoThang.CheckedChanged += new System.EventHandler(this.rbThongkeTheoThang_CheckedChanged);
            // 
            // rbThongKeTheoNV
            // 
            this.rbThongKeTheoNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbThongKeTheoNV.AutoSize = true;
            this.rbThongKeTheoNV.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbThongKeTheoNV.Location = new System.Drawing.Point(6, 26);
            this.rbThongKeTheoNV.Name = "rbThongKeTheoNV";
            this.rbThongKeTheoNV.Size = new System.Drawing.Size(291, 31);
            this.rbThongKeTheoNV.TabIndex = 1;
            this.rbThongKeTheoNV.TabStop = true;
            this.rbThongKeTheoNV.Text = "Thống Kê Theo Nhân Viên";
            this.rbThongKeTheoNV.UseVisualStyleBackColor = true;
            this.rbThongKeTheoNV.CheckedChanged += new System.EventHandler(this.rbThongKeTheoNV_CheckedChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(519, 22);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(145, 34);
            this.dateTimePickerTo.TabIndex = 0;
            this.dateTimePickerTo.Value = new System.DateTime(2020, 12, 10, 0, 0, 0, 0);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(349, 22);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(145, 34);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // lbQLThongKe
            // 
            this.lbQLThongKe.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbQLThongKe.Location = new System.Drawing.Point(3, 23);
            this.lbQLThongKe.Name = "lbQLThongKe";
            this.lbQLThongKe.Size = new System.Drawing.Size(1898, 44);
            this.lbQLThongKe.TabIndex = 51;
            this.lbQLThongKe.Text = "Quản Lý Thống Kê";
            this.lbQLThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart_thang
            // 
            this.chart_thang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chart_thang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Ghi Chú";
            this.chart_thang.Legends.Add(legend1);
            this.chart_thang.Location = new System.Drawing.Point(159, 258);
            this.chart_thang.Name = "chart_thang";
            this.chart_thang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Tổng Tiền";
            this.chart_thang.Series.Add(series1);
            this.chart_thang.Size = new System.Drawing.Size(729, 644);
            this.chart_thang.TabIndex = 56;
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Thống Kê Doanh Thu Theo Tháng";
            this.chart_thang.Titles.Add(title1);
            // 
            // chart_nv
            // 
            this.chart_nv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "ChartArea1";
            this.chart_nv.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Ghi Chú";
            this.chart_nv.Legends.Add(legend2);
            this.chart_nv.Location = new System.Drawing.Point(1009, 258);
            this.chart_nv.Name = "chart_nv";
            this.chart_nv.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Số Lượng";
            this.chart_nv.Series.Add(series2);
            this.chart_nv.Size = new System.Drawing.Size(729, 644);
            this.chart_nv.TabIndex = 57;
            this.chart_nv.Text = "chart2";
            title2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Thống Kê Số Lượng Xe Đã Bán Của Nhân Viên";
            this.chart_nv.Titles.Add(title2);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.chart_nv);
            this.Controls.Add(this.chart_thang);
            this.Controls.Add(this.lbQLThongKe);
            this.Controls.Add(this.gbThongKe);
            this.Controls.Add(this.btThoat);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.gbThongKe.ResumeLayout(false);
            this.gbThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_nv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox gbThongKe;
        private System.Windows.Forms.Label lbQLThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.RadioButton rbThongkeTheoThang;
        private System.Windows.Forms.RadioButton rbThongKeTheoNV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_nv;
    }
}