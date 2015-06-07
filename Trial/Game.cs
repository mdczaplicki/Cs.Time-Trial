namespace Trial
{
    partial class Main
    {
        private void InitializeGame()
        {
            this.colorPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.ansButton = new System.Windows.Forms.Button[4]
            {
                new System.Windows.Forms.Button(),
                new System.Windows.Forms.Button(),
                new System.Windows.Forms.Button(),
                new System.Windows.Forms.Button()
            };
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.ansButton[0]);
            this.gamePanel.Controls.Add(this.ansButton[1]);
            this.gamePanel.Controls.Add(this.ansButton[2]);
            this.gamePanel.Controls.Add(this.ansButton[3]);
            this.gamePanel.Controls.Add(this.colorPanel);
            this.gamePanel.Controls.Add(this.imageBox);
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(460, 437);
            this.gamePanel.TabIndex = 0;
            // 
            // ansButton3
            // 
            this.ansButton[3].Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.ansButton[3].Location = new System.Drawing.Point(348, 327);
            this.ansButton[3].Size = new System.Drawing.Size(109, 107);
            this.ansButton[3].TabIndex = 4;
            this.ansButton[3].Text = "Ans #4";
            this.ansButton[3].UseVisualStyleBackColor = true;
            this.ansButton[3].Click += this.checkAns;
            // 
            // ansButton2
            // 
            this.ansButton[2].Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.ansButton[2].Location = new System.Drawing.Point(233, 327);
            this.ansButton[2].Size = new System.Drawing.Size(109, 107);
            this.ansButton[2].TabIndex = 3;
            this.ansButton[2].Text = "Ans #3";
            this.ansButton[2].UseVisualStyleBackColor = true;
            this.ansButton[2].Click += this.checkAns;
            // 
            // ansButton1
            // 
            this.ansButton[1].Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.ansButton[1].Location = new System.Drawing.Point(118, 327);
            this.ansButton[1].Size = new System.Drawing.Size(109, 107);
            this.ansButton[1].TabIndex = 2;
            this.ansButton[1].Text = "Ans #2";
            this.ansButton[1].UseVisualStyleBackColor = true;
            this.ansButton[1].Click += this.checkAns;
            // 
            // ansButton0
            // 
            this.ansButton[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.ansButton[0].Location = new System.Drawing.Point(3, 327);
            this.ansButton[0].Size = new System.Drawing.Size(109, 107);
            this.ansButton[0].TabIndex = 1;
            this.ansButton[0].Text = "Ans #1";
            this.ansButton[0].UseVisualStyleBackColor = true;
            this.ansButton[0].Click += this.checkAns;
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(3, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(454, 318);
            this.colorPanel.TabIndex = 0;
            this.colorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // imageBox
            // 
            //this.imageBox.BackgroundImage = global::test.Properties.Resources.cat;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.ErrorImage = null;
            this.imageBox.InitialImage = null;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(454, 318);
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            this.imageBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form2";
            this.gamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button[] ansButton;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.PictureBox imageBox;
    }
}