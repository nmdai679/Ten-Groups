namespace HDH
{
    partial class SS_ppcpu
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
            this.ss_ppcup_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ss_ppcup_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ss_ppcup_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.ss_ppcup_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ss_ppcup_chart.Legends.Add(legend1);
            this.ss_ppcup_chart.Location = new System.Drawing.Point(12, 12);
            this.ss_ppcup_chart.Name = "ss_ppcup_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ss_ppcup_chart.Series.Add(series1);
            this.ss_ppcup_chart.Size = new System.Drawing.Size(776, 400);
            this.ss_ppcup_chart.TabIndex = 0;
            this.ss_ppcup_chart.Text = "ss_ppcup_chart";
            // 
            // SS_ppcpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.ss_ppcup_chart);
            this.MaximizeBox = false;
            this.Name = "SS_ppcpu";
            this.Text = "SS_ppcpu";
            ((System.ComponentModel.ISupportInitialize)(this.ss_ppcup_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ss_ppcup_chart;
    }
}