using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HDH
{
    public partial class SS_ReplacePage : Form
    {
        public SS_ReplacePage(List<int> temp)
        {
            InitializeComponent();
            SS_ReplacePage_Hienthibieudo(temp);
        }

        private void SS_ReplacePage_Hienthibieudo(List<int> temp)
        {
            if (temp.Count != 4)
            {
                MessageBox.Show("Danh sách thời gian không hợp lệ.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SS_repa_chart.Series.Clear();
            SS_repa_chart.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainChartArea");
            chartArea.AxisX.Title = "Thuật toán";
            //chartArea.AxisY.Title = "Lần";
            chartArea.AxisX.Interval = 1;
            SS_repa_chart.ChartAreas.Add(chartArea);

            string[] algorithms = { "OPT", "LRU", "FIFO", "CLOCK" };

            Series series = new Series("Số lần thay trang");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.Green;
            series.Font = new Font("Arial", 12, FontStyle.Bold);
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Blue;

            for (int i = 0; i < 4; i++)
            {
                series.Points.AddXY(algorithms[i], temp[i]);
            }

            SS_repa_chart.Series.Add(series);
        }
    }
}
