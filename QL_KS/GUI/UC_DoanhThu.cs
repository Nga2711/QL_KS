using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class UC_DoanhThu : UserControl
    {
        public UC_DoanhThu()
        {
            InitializeComponent();
            this.cbb_slkx.FindStringExact("Column");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_slkx.Text=="Spline")
            {
                C_bieudo.Series[0].ChartType = SeriesChartType.Spline;
                C_bieudo.Series[0].Color = Color.Red;
            }
            else
            {
                C_bieudo.Series[0].ChartType = SeriesChartType.Column;
                C_bieudo.Series[0].Color = Color.Yellow;
            }
        }
    }
}
