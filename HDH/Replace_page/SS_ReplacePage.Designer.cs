namespace HDH
{
    partial class SS_ReplacePage
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
            this.SS_repa_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SS_repa_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // SS_repa_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.SS_repa_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SS_repa_chart.Legends.Add(legend1);
            this.SS_repa_chart.Location = new System.Drawing.Point(12, 12);
            this.SS_repa_chart.Name = "SS_repa_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SS_repa_chart.Series.Add(series1);
            this.SS_repa_chart.Size = new System.Drawing.Size(776, 426);
            this.SS_repa_chart.TabIndex = 0;
            this.SS_repa_chart.Text = "SS_repa_chart";
            // 
            // SS_ReplacePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SS_repa_chart);
            this.Name = "SS_ReplacePage";
            this.Text = "SS_ReplacePage";
            ((System.ComponentModel.ISupportInitialize)(this.SS_repa_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SS_repa_chart;
    }
}