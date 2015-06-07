using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.Properties;

namespace Trial
{
    partial class Main
    {
        private void LevelGenerator()
        {
            penalty = 0;
            level++;
            this.Text = "Game Question #" + level;
            ans = new List<int>();
            color = new List<int>();
            int rightAns;

            choose = rand.Next(3);
            for (Int16 i = 0; i < 4; i++) ansButton[i].BackColor = colors[NewNumber(color)];
            
            switch (choose)
            {
                case 0:
                    colorPanel.BackgroundImage = null;
                    for (Int16 i = 0; i < 4; i++) ansButton[i].Text = colorsString[NewNumber(ans)];
                    rightAns = rand.Next(4);
                    colorPanel.BackColor = colors[ans[rightAns]];
                    break;
                case 1:
                    colorPanel.BackgroundImage = null;
                    colorPanel.BackColor = Color.Transparent;
                    for (Int16 i = 0; i < 4; i++) ansButton[i].Text = soundsString[NewNumber(ans)];
                    rightAns = rand.Next(4);
                    sp = sounds[ans[rightAns]];
                    sp.Play();
                    break;
                default:
                    colorPanel.BackColor = Color.Transparent;
                    for (Int16 i = 0; i < 4; i++) ansButton[i].Text = animalsString[NewNumber(ans)];
                    rightAns = rand.Next(4);
                    colorPanel.BackgroundImage = animals[ans[rightAns]];
                    break;
            }
            for (Int16 i = 0; i < 4; i++) ansButton[i].Tag = "Wrong";
            ansButton[rightAns].Tag = "Right";


            stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
        }

        private int NewNumber(List<int> list)
        {
            int temp = rand.Next(7);
            if (!list.Contains(temp))
            {
                list.Add(temp);
                return temp;
            }
            else return NewNumber(list);
        }

        private void FinishGame()
        {
            double score = Math.Round(scores.Average(), 2);
            double total = Math.Round(scores.Sum(), 2);

            this.Controls.Remove(gamePanel);

            InitializeChart();
            this.DesktopLocation = new Point
            (
                DesktopLocation.X + 50,
                DesktopLocation.Y + 50
            );

            if (start) MessageBox.Show(
                "You finished.\nYour average score is: " + score +
                " seconds.\nTotal time: " + total +
                " seconds.\nPenalty time: " + penaltyTotal + " seconds.",
                "Congratulations");

            this.Controls.Remove(this.chart);

            InitializeComponent();
            this.DesktopLocation = new Point
            (
                DesktopLocation.X + 50,
                DesktopLocation.Y + 50
            );
        }
    }
}