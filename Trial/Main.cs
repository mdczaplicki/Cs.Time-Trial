using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Trial.Properties;

namespace Trial
{
    public partial class Main : Form
    {
        private Int16 _levels = 10;
        private Int16 _level;
        private Random _rand = new Random();
        private List<int> _ans;
        private List<int> _color;
        private List<double> _scores;
        private SoundPlayer _sp;
        private int _choose;
        private bool _start = true;
        private bool _instruction = true;
        private double _penalty, _penaltyTotal;
        private readonly Color[] _colors = {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Green,
            Color.Aqua,
            Color.Purple,
            Color.Orange
        };
        private readonly string[] _colorsString = {
            "Red",
            "Blue",
            "Yellow",
            "Green",
            "Teal",
            "Purple",
            "Orange"
        };
        private readonly Image[] _animals = {
            Resources.lion,
            Resources.dog,
            Resources.duck,
            Resources.giraffe,
            Resources.zebra,
            Resources.cat,
            Resources.monkey
        };
        private readonly string[] _animalsString = {
            "Lion",
            "Dog",
            "Duck",
            "Giraffe",
            "Zebra",
            "Cat",
            "Monkey"
        };
        private readonly SoundPlayer[] _sounds = {
             new SoundPlayer(Resources.cat1),
             new SoundPlayer(Resources.dog1),
             new SoundPlayer(Resources.bird),
             new SoundPlayer(Resources.chicken),
             new SoundPlayer(Resources.frog),
             new SoundPlayer(Resources.horse),
             new SoundPlayer(Resources.cow)

        };
        private readonly string[] _soundsString = {
            "Cat",
            "Dog",
            "Bird",
            "Chicken",
            "Frog",
            "Horse",
            "Cow"
        };

        private Stopwatch _stopWatch;
        TimeSpan _timeSpan;

        public Main()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        #region Handlers
        private void StartButtonClick(object o, EventArgs e)
        {
            MessageBoxButtons messageButtons = MessageBoxButtons.YesNo;
            if (_instruction && MessageBox.Show(
                Resources.Main_startButtonClick_, 
                @"Instruction", messageButtons) == DialogResult.No)
            {
                _instruction = false;
            }

            Controls.Remove(menuPanel);
            DesktopLocation = new Point(
                DesktopLocation.X - 100,
                DesktopLocation.Y - 100);
            _scores = new List<double>();
            _level = 0;
            _start = true;
            _penaltyTotal = 0;
            
            InitializeGame(); 


            LevelGenerator();
        }

        private void TryButtonClick(object o, EventArgs e)
        {
            Controls.Remove(menuPanel);
            DesktopLocation = new Point(
                DesktopLocation.X - 100,
                DesktopLocation.Y - 100);
            _scores = new List<double>();
            _level = 0;
            _start = false;
            _penaltyTotal = 0;
            InitializeGame();
            LevelGenerator();
        }

        private void QuitButtonClick(object o, EventArgs e)
        {
            Application.Exit();
        }
        
        private void CheckAns(object o, EventArgs e)
        {
            Button b = (Button)o;
            if ((string)b.Tag == "Right")
            {
                if (_choose == 1) _sp.Stop();
                _stopWatch.Stop();
                _timeSpan = _stopWatch.Elapsed;
                _scores.Add(_timeSpan.TotalSeconds + _penalty);

                if (_level < _levels) LevelGenerator();
                else FinishGame();
            }
            else { _penalty++; _penaltyTotal++; }
        }
        #endregion
    }
}