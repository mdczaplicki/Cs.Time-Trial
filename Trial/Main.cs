using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.Properties;

namespace Trial
{
    public partial class Main : Form
    {
        private Int16 levels = 10;
        private Int16 level = 0;
        private Random rand = new Random();
        private List<int> ans;
        private List<int> color;
        private List<double> scores;
        private SoundPlayer sp;
        private int choose;
        private bool start = true;
        private bool instruction = true;
        private double penalty, penaltyTotal;
        private Color[] colors = new Color[]
        {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Green,
            Color.Aqua,
            Color.Purple,
            Color.Orange
        };
        private String[] colorsString = new String[]
        {
            "Red",
            "Blue",
            "Yellow",
            "Green",
            "Teal",
            "Purple",
            "Orange"
        };
        private Image[] animals = new Image[]
        {
            Properties.Resources.lion,
            Properties.Resources.dog,
            Properties.Resources.duck,
            Properties.Resources.giraffe,
            Properties.Resources.zebra,
            Properties.Resources.cat,
            Properties.Resources.monkey
        };
        private String[] animalsString = new String[]
        {
            "Lion",
            "Dog",
            "Duck",
            "Giraffe",
            "Zebra",
            "Cat",
            "Monkey"
        };
        private SoundPlayer[] sounds = new SoundPlayer[]
        {
             new SoundPlayer(Properties.Resources.cat1),
             new SoundPlayer(Properties.Resources.dog1),
             new SoundPlayer(Properties.Resources.bird),
             new SoundPlayer(Properties.Resources.chicken),
             new SoundPlayer(Properties.Resources.frog),
             new SoundPlayer(Properties.Resources.horse),
             new SoundPlayer(Properties.Resources.cow)

        };
        private String[] soundsString = new String[]
        {
            "Cat",
            "Dog",
            "Bird",
            "Chicken",
            "Frog",
            "Horse",
            "Cow"
        };
        System.Diagnostics.Stopwatch stopWatch;
        TimeSpan timeSpan;

        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        #region Handlers
        private void startButtonClick(object o, EventArgs e)
        {
            MessageBoxButtons messageButtons = MessageBoxButtons.YesNo;
            if (instruction && MessageBox.Show(
                "In this game you are suppose to solve the puzzles.\n" +
                "There are colors, animals and their sounds to recognize\n" +
                "Be fast, because time is your score in this game!\n\n" +
                "Would you like to see this instruction again?", 
                "Instruction", messageButtons) == DialogResult.No)
            {
                this.instruction = false;
            }

            this.Controls.Remove(this.menuPanel);
            this.DesktopLocation = new Point(
                DesktopLocation.X - 100,
                DesktopLocation.Y - 100);
            scores = new List<double>();
            level = 0;
            start = true;
            penaltyTotal = 0;
            
            this.InitializeGame(); 


            this.LevelGenerator();
        }

        private void tryButtonClick(object o, EventArgs e)
        {
            this.Controls.Remove(this.menuPanel);
            this.DesktopLocation = new Point(
                DesktopLocation.X - 100,
                DesktopLocation.Y - 100);
            scores = new List<double>();
            level = 0;
            start = false;
            penaltyTotal = 0;
            this.InitializeGame();
            this.LevelGenerator();
        }

        private void quitButtonClick(object o, EventArgs e)
        {
            Application.Exit();
        }
        
        private void checkAns(object o, EventArgs e)
        {
            Button b = (Button)o;
            if ((String)b.Tag == "Right")
            {
                if (choose == 1) sp.Stop();
                stopWatch.Stop();
                timeSpan = stopWatch.Elapsed;
                scores.Add(timeSpan.TotalSeconds + penalty);

                if (level < levels) LevelGenerator();
                else FinishGame();
            }
            else { penalty++; penaltyTotal++; }
        }
        #endregion
    }
}