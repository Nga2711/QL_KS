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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.C_bieudo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbb_slkx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.C_bieudo)).BeginInit();
            this.SuspendLayout();
            // 
            // C_bieudo
            // 
            chartArea2.Name = "ChartArea1";
            this.C_bieudo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.C_bieudo.Legends.Add(legend2);
            this.C_bieudo.Location = new System.Drawing.Point(-15, 51);
            this.C_bieudo.Name = "C_bieudo";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.C_bieudo.Series.Add(series2);
            this.C_bieudo.Size = new System.Drawing.Size(777, 300);
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
            this.cbb_slkx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UC_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
