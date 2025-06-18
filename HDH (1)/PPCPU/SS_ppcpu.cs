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

namespace HDH
{
    public partial class SS_ppcpu : Form
    {
        public SS_ppcpu(List<double> wt, List<double> tat, string qt)
        {
            InitializeComponent();
            SS_ppcpu_Hienthibieudo(wt, tat, qt);
        }

        private void SS_ppcpu_Hienthibieudo(List<double> wt, List<double> tat, string qt)
        {
            if (wt.Count != 4 || tat.Count != 4)
            {
                MessageBox.Show("Danh sách thời gian không hợp lệ. Phải có 4 giá trị cho mỗi danh sách.",
                                "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ss_ppcup_chart.Series.Clear();
            ss_ppcup_chart.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainChartArea");
            chartArea.AxisX.Title = "Thuật toán(RR Qt = " + qt +")";
            chartArea.AxisY.Title = "Thời gian trung bình";
            chartArea.AxisX.Interval = 1;
            ss_ppcup_chart.ChartAreas.Add(chartArea);

            string[] algorithms = { "FCFS", "SJF", "SRTF", "RR" };

            Series seriesWT = new Series("Waiting Time");
            seriesWT.ChartType = SeriesChartType.Column;
            seriesWT.Color = Color.SkyBlue;
            seriesWT.IsValueShownAsLabel = true;

            Series seriesTAT = new Series("Turnaround Time");
            seriesTAT.ChartType = SeriesChartType.Column;
            seriesTAT.Color = Color.Orange;
            seriesTAT.IsValueShownAsLabel = true;

            for (int i = 0; i < 4; i++)
            {
                seriesWT.Points.AddXY(algorithms[i], Math.Round(wt[i], 2));
                seriesTAT.Points.AddXY(algorithms[i], Math.Round(tat[i], 2));
            }

            ss_ppcup_chart.Series.Add(seriesWT);
            ss_ppcup_chart.Series.Add(seriesTAT);
        }
    }
}
