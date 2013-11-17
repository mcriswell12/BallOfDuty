using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BallOfDuty
{
    public partial class GameWindow : Form
    {
        private Engine engine;
        
        public GameWindow(MainMenu par)
        {
            engine = new Engine();
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            Image im = Image.FromFile(".\\Images\\tank.png");
            while (y < 200)
            {
                while (x < 1200)
                {
                    engine.addBrick(x, y, im);
                    x += 100;
                }
                y += 50;
                x = 0;
            } 
        }
        private void GameWindow_Paint(object sender, PaintEventArgs e)
        {
            engine.paint(e.Graphics);
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && engine.Paddle.XPos > 0)
            {
                engine.Paddle.moveLeft();
            }
            else if (e.KeyCode == Keys.Right && engine.Paddle.XPos + 100 < 1200)
            {
                engine.Paddle.moveRight();
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (engine.GameOver)
            {
                this.timer1.Stop();
                string promptValue = Prompt.ShowDialog("Enter your name:", "High Score");
                HighScore hs = new HighScore { PlayerName = promptValue, Score = engine.Score };
                HighScoreTable.saveHighScores(hs);
                this.Close();
            }
            if (engine.Ball.YPos <= 250)
            {
                engine.brickHit();
            }
            engine.paddleHit();
            this.scoreBox.Text = "Score: " + engine.Score;
            Refresh();
        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
