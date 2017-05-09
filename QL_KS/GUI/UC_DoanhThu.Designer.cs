namespace GUI
{
    partial class UC_DoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.C_bieudo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbb_slkx = new System.Windows.Forms.ComboBox();
            this.cbb_day = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.C_bieudo)).BeginInit();
            this.SuspendLayout();
            // 
            // C_bieudo
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.C_bieudo.ChartAreas.Add(chartArea1);
            this.C_bieudo.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.C_bieudo.Legends.Add(legend1);
            this.C_bieudo.Location = new System.Drawing.Point(0, 50);
            this.C_bieudo.Name = "C_bieudo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.C_bieudo.Series.Add(series1);
            this.C_bieudo.Size = new System.Drawing.Size(759, 374);
            this.C_bieudo.TabIndex = 0;
            this.C_bieudo.Text = "chart1";
            // 
            // cbb_slkx
            // 
            this.cbb_slkx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_slkx.FormattingEnabled = true;
            this.cbb_slkx.Items.AddRange(new object[] {
            "Column",
            "Spline"});
            this.cbb_slkx.Location = new System.Drawing.Point(638, 3);
            this.cbb_slkx.Name = "cbb_slkx";
            this.cbb_slkx.Size = new System.Drawing.Size(121, 21);
            this.cbb_slkx.TabIndex = 1;
            this.cbb_slkx.Tag = "Biểu Đồ";
            this.cbb_slkx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbb_day
            // 
            this.cbb_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_day.FormattingEnabled = true;
            this.cbb_day.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cbb_day.Location = new System.Drawing.Point(474, 3);
            this.cbb_day.Name = "cbb_day";
            this.cbb_day.Size = new System.Drawing.Size(121, 21);
            this.cbb_day.TabIndex = 2;
            this.cbb_day.Tag = "Kiểu Xem";
            this.cbb_day.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // UC_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_day);
            this.Controls.Add(this.cbb_slkx);
            this.Controls.Add(this.C_bieudo);
            this.Name = "UC_DoanhThu";
            this.Size = new System.Drawing.Size(762, 424);
            ((System.ComponentModel.ISupportInitialize)(this.C_bieudo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart C_bieudo;
        private System.Windows.Forms.ComboBox cbb_slkx;
        private System.Windows.Forms.ComboBox cbb_day;
    }
}
