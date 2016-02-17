using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trial
{
    partial class Main
    {
        private void InitializeChart()
        {
            Controls.Remove(_gamePanel);
            var chartArea = new ChartArea();
            var series = new Series();
            _chart = new Chart {BackColor = Color.Transparent};
            // 
            // chart
            // 
            chartArea.Name = "ChartArea1";
            _chart.ChartAreas.Add(chartArea);
            _chart.Location = new Point(12, 12);
            _chart.Name = "chart";
            _chart.Palette = ChartColorPalette.EarthTones;
            series.ChartArea = "ChartArea1";
            series.IsValueShownAsLabel = true;
            series.Name = "Score";
            _chart.Series.Add(series);
            _chart.Size = new Size(360, 337);
            _chart.TabIndex = 0;
            _chart.Text = @"chart";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(_chart);
            Text = @"Chart of scores";
            
            foreach (var t in _scores)
                _chart.Series["Score"].Points.AddY(Math.Round(t, 2));
        }

        private Chart _chart;
    }
}
