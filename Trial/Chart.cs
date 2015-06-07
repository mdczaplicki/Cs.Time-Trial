using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trial
{
    partial class Main
    {
        private void InitializeChart()
        {
            this.Controls.Remove(this.gamePanel);
            ChartArea chartArea = new ChartArea();
            Series series = new Series();
            this.chart = new Chart();
            // 
            // chart
            // 
            this.chart.BackColor = Color.Transparent;
            chartArea.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea);
            this.chart.Location = new Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Palette = ChartColorPalette.EarthTones;
            series.ChartArea = "ChartArea1";
            series.IsValueShownAsLabel = true;
            series.Name = "Score";
            this.chart.Series.Add(series);
            this.chart.Size = new Size(360, 337);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.chart);
            this.Text = "Chart of scores";
            
            for (int i = 0; i < scores.Count(); i++) this.chart.Series["Score"].Points.AddY(Math.Round(scores[i], 2));
        }

        private Chart chart;
    }
}
