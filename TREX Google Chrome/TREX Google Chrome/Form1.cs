using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TREX_Google_Chrome
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int JumpSpeed = 10;
        int Force = 12;
        int Score = 0;
        int ObstacleSpeed = 10;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            ResetGame();
        }

        private void ScoreText_Click(object sender, EventArgs e)
        {

        }

        private void GameEvent(object sender, EventArgs e)
        {
            TRex.Top += JumpSpeed;
            ScoreText.Text = "Score: " + Score;

            if (jumping && Force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                JumpSpeed = -12;
                Force -= 1;
            }

            else
            {
                JumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Obstacle")
                {
                    x.Left -= ObstacleSpeed;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        Score++;
                    }

                    if (TRex.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        TRex.Image = Properties.Resources.dead;
                        ScoreText.Text += " Press R to Restrart ";
                    }
                }
            }

            if (TRex.Top >= 380 && !jumping)
            {
                Force = 12;
                TRex.Top = Floor.Top - TRex.Height;
                JumpSpeed = 0;
            }

            if (Score >= 10)
            {
                ObstacleSpeed = 15;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }

            if (jumping)
            {
                jumping = false;
            }
        }

        public void ResetGame()
        {
            Force = 12;
            TRex.Top = Floor.Top - TRex.Height;
            JumpSpeed = 0;
            jumping = false;
            Score = 0;
            ObstacleSpeed = 10;
            ScoreText.Text = "Score : " + Score;
            TRex.Image = Properties.Resources.running;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Obstacle")
                {
                    int position = rnd.Next(600, 1000);

                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }

            GameTimer.Start();
        }
    }
}
