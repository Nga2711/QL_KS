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
using DAL;
namespace GUI
{
    public partial class UC_DoanhThu : UserControl
    {
        public UC_DoanhThu()
        {
            InitializeComponent();
            C_bieudo.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            C_bieudo.ChartAreas["ChartArea2"].AxisX.Title = "VND";
        }
        private DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
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
        private void setxy(int x,decimal y)
        {
            C_bieudo.Series["Series1"].Points.AddXY(x,y);
        }
        private void Chartload(int diemung)
        {
            C_bieudo.Controls.Clear();
            decimal x=0;
            decimal tam=0;
            DataTable dt = new DataTable();
            string day, month, year;
            DateTime lastday;
            lastday = GetLastDayOfMonth(DateTime.Now);
            day = lastday.Day.ToString();
            month = lastday.Month.ToString();
            year = lastday.Year.ToString();
            if (diemung==12)
            {
               
                 for (int i = 1;i<=12;i++)
                {
                    dt = DBConnect.GetData("select sum(thanhtien) from hoadonphong where ngaythanhtoan>= '"+DateTime.Now.Year+"-"+ i+"-01'and ngaythanhtoan<= '" + year+"-"+i+"-"+day+"'");
                    if (dt != null)
                        decimal.TryParse(dt.Rows[0][0].ToString(), out x);

                    dt = DBConnect.GetData("select sum(tongtien) from hoadondichvu where ngaysudung>= '" + DateTime.Now.Year + "-" + i + "-01'and ngaysudung<= '" + "SELECT DATEADD(DAY, -(DAY(GETDATE())), DATEADD(MONTH, 1," + DateTime.Now.Year + " - " + i + "-01')))");
                    if (dt != null)
                        decimal.TryParse(dt.Rows[0][0].ToString(), out tam);
                    x += tam;
                    setxy(i, x);
                    x = 0;
                    tam = 0;
                }
            }
            else
            {
                for(int i = 1;i<=diemung;i++)
                {
                    
                    dt = DBConnect.GetData("select sum(thanhtien) from hoadonphong where ngaythanhtoan= '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-"+i+"'");
                    if (dt != null)
                        decimal.TryParse(dt.Rows[0][0].ToString(), out x);
                  
                   
                    dt = DBConnect.GetData("select sum(tongtien) from hoadondichvu where ngaysudung = '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + i + "'");
                    if (dt != null)
                        decimal.TryParse(dt.Rows[0][0].ToString(), out tam);
                    x += tam;
                    setxy(i, x);
                    x = 0;
                    tam = 0;
                }
            }

        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbb_day.Text == "Tháng")
            {
                C_bieudo.Series[0].Points.Clear();
                C_bieudo.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                Chartload(int.Parse(GetLastDayOfMonth(DateTime.Now).Day.ToString()));
                
            }
            else
            {
                C_bieudo.Series[0].Points.Clear();
                C_bieudo.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                Chartload(12);
            }
               
        }
    }
}
