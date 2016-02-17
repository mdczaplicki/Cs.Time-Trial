using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Trial
{
    partial class Main
    {
        private void LevelGenerator()
        {
            _penalty = 0;
            _level++;
            Text = @"Game Question #" + _level;
            _ans = new List<int>();
            _color = new List<int>();
            int rightAns;

            _choose = _rand.Next(3);
            for (short i = 0; i < 4; i++) _ansButton[i].BackColor = _colors[NewNumber(_color)];
            
            switch (_choose)
            {
                case 0:
                    _colorPanel.BackgroundImage = null;
                    for (short i = 0; i < 4; i++) _ansButton[i].Text = _colorsString[NewNumber(_ans)];
                    rightAns = _rand.Next(4);
                    _colorPanel.BackColor = _colors[_ans[rightAns]];
                    break;
                case 1:
                    _colorPanel.BackgroundImage = null;
                    _colorPanel.BackColor = Color.Transparent;
                    for (short i = 0; i < 4; i++) _ansButton[i].Text = _soundsString[NewNumber(_ans)];
                    rightAns = _rand.Next(4);
                    _sp = _sounds[_ans[rightAns]];
                    _sp.Play();
                    break;
                default:
                    _colorPanel.BackColor = Color.Transparent;
                    for (short i = 0; i < 4; i++) _ansButton[i].Text = _animalsString[NewNumber(_ans)];
                    rightAns = _rand.Next(4);
                    _colorPanel.BackgroundImage = _animals[_ans[rightAns]];
                    break;
            }
            for (short i = 0; i < 4; i++) _ansButton[i].Tag = "Wrong";
            _ansButton[rightAns].Tag = "Right";


            _stopWatch = new Stopwatch();
            _stopWatch.Start();
        }

        private int NewNumber(ICollection<int> list)
        {
            while (true)
            {
                var temp = _rand.Next(7);
                if (list.Contains(temp)) continue;
                list.Add(temp);
                return temp;
            }
        }

        private void FinishGame()
        {
            var score = Math.Round(_scores.Average(), 2);
            var total = Math.Round(_scores.Sum(), 2);

            Controls.Remove(_gamePanel);

            InitializeChart();
            DesktopLocation = new Point
            (
                DesktopLocation.X + 50,
                DesktopLocation.Y + 50
            );

            if (_start) MessageBox.Show(
                $"You finished.\nYour average score is: {score} seconds.\nTotal time: {total} seconds.\nPenalty time: {_penaltyTotal} seconds.",
                @"Congratulations");

            Controls.Remove(_chart);

            InitializeComponent();
            DesktopLocation = new Point
            (
                DesktopLocation.X + 50,
                DesktopLocation.Y + 50
            );
        }
    }
}