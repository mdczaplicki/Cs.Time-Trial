using System.Drawing;
using System.Windows.Forms;

namespace Trial
{
    partial class Main
    {
        private void InitializeGame()
        {
            _colorPanel = new Panel();
            _gamePanel = new Panel();
            _imageBox = new PictureBox();
            _ansButton = new[]
            {
                new Button(),
                new Button(),
                new Button(),
                new Button()
            };
            _gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // gamePanel
            // 
            _gamePanel.Controls.Add(_ansButton[0]);
            _gamePanel.Controls.Add(_ansButton[1]);
            _gamePanel.Controls.Add(_ansButton[2]);
            _gamePanel.Controls.Add(_ansButton[3]);
            _gamePanel.Controls.Add(_colorPanel);
            _gamePanel.Controls.Add(_imageBox);
            _gamePanel.Location = new Point(12, 12);
            _gamePanel.Name = "gamePanel";
            _gamePanel.Size = new Size(460, 437);
            _gamePanel.TabIndex = 0;
            // 
            // ansButton3
            // 
            _ansButton[3].Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            _ansButton[3].Location = new Point(348, 327);
            _ansButton[3].Size = new Size(109, 107);
            _ansButton[3].TabIndex = 4;
            _ansButton[3].Text = @"Ans #4";
            _ansButton[3].UseVisualStyleBackColor = true;
            _ansButton[3].Click += CheckAns;
            // 
            // ansButton2
            // 
            _ansButton[2].Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            _ansButton[2].Location = new Point(233, 327);
            _ansButton[2].Size = new Size(109, 107);
            _ansButton[2].TabIndex = 3;
            _ansButton[2].Text = @"Ans #3";
            _ansButton[2].UseVisualStyleBackColor = true;
            _ansButton[2].Click += CheckAns;
            // 
            // ansButton1
            // 
            _ansButton[1].Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            _ansButton[1].Location = new Point(118, 327);
            _ansButton[1].Size = new Size(109, 107);
            _ansButton[1].TabIndex = 2;
            _ansButton[1].Text = @"Ans #2";
            _ansButton[1].UseVisualStyleBackColor = true;
            _ansButton[1].Click += CheckAns;
            // 
            // ansButton0
            // 
            _ansButton[0].Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Bold);
            _ansButton[0].Location = new Point(3, 327);
            _ansButton[0].Size = new Size(109, 107);
            _ansButton[0].TabIndex = 1;
            _ansButton[0].Text = @"Ans #1";
            _ansButton[0].UseVisualStyleBackColor = true;
            _ansButton[0].Click += CheckAns;
            // 
            // colorPanel
            // 
            _colorPanel.Location = new Point(3, 3);
            _colorPanel.Name = "colorPanel";
            _colorPanel.Size = new Size(454, 318);
            _colorPanel.TabIndex = 0;
            _colorPanel.BackgroundImageLayout = ImageLayout.Stretch;
            // 
            // imageBox
            // 
            //this.imageBox.BackgroundImage = global::test.Properties.Resources.cat;
            _imageBox.BackgroundImageLayout = ImageLayout.Stretch;
            _imageBox.ErrorImage = null;
            _imageBox.InitialImage = null;
            _imageBox.Location = new Point(0, 0);
            _imageBox.Name = "imageBox";
            _imageBox.Size = new Size(454, 318);
            _imageBox.TabIndex = 1;
            _imageBox.TabStop = false;
            _imageBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(_gamePanel);
            Name = "Form2";
            _gamePanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        private Panel _gamePanel;
        private Button[] _ansButton;
        private Panel _colorPanel;
        private PictureBox _imageBox;
    }
}