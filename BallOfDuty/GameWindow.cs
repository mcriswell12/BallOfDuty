using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace BallOfDuty
{
    public partial class GameWindow : Form
    {
        private Engine engine;
        private Random r = new Random();
        
        public GameWindow(MainMenu par)
        {
            engine = new Engine();
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Stop();
            using (var soundPlayer = new SoundPlayer(@".\\Images\\game.wav"))
            {
                soundPlayer.PlayLooping();
            }
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            //Row 1 of Map
            engine.addBrick(0, 0, BrickType.Tank1, 3);
            engine.addBrick(100, 0, BrickType.Soldier, 1);
            engine.addBrick(200, 0, BrickType.Tank1, 3);
            engine.addBrick(300, 0, BrickType.Soldier, 1);
            engine.addBrick(400, 0, BrickType.Soldier, 1);
            for (int i = 5; i < 7; i++)
                engine.addBrick(i * 100, 0, BrickType.Tank1, 3);
            for (int i = 7; i < 9; i++)
                engine.addBrick(i * 100, 0, BrickType.Soldier, 1);
            engine.addBrick(900, 0, BrickType.Tank1, 3);
            engine.addBrick(1000, 0, BrickType.Soldier, 1);
            engine.addBrick(1100, 0, BrickType.Tank1, 3);
            //Row 2 of Map
            engine.addBrick(0, 50, BrickType.Soldier, 1);
            engine.addBrick(100, 50, BrickType.Tank1, 3);
            for (int i = 2; i < 4; i++)
                engine.addBrick(i * 100, 50, BrickType.Soldier, 1);
            for (int i = 4; i < 8; i++)
                engine.addBrick(i * 100, 50, BrickType.Sand1, 2);
            for (int i = 8; i < 10; i++)
                engine.addBrick(i * 100, 50, BrickType.Soldier, 1);
            engine.addBrick(1000, 50, BrickType.Tank1, 3);
            engine.addBrick(1100, 50, BrickType.Soldier, 1);
            //Row 3 of Map
            for (int i = 0; i < 12; i++)
                engine.addBrick(i * 100, 100, BrickType.Soldier, 1);
            //Row 4 of Map
            for (int i = 0; i < 5; i++)
                engine.addBrick(i * 100, 150, BrickType.Sand1, 2);
            engine.addBrick(500, 150, BrickType.Soldier, 1);
            engine.addBrick(600, 150, BrickType.Soldier, 1);
            for (int i = 7; i < 12; i++)
                engine.addBrick(i * 100, 150, BrickType.Sand1, 2);
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
            else if (e.KeyCode == Keys.Right && engine.Paddle.XPos + engine.Paddle.Length * 20 < 1200)
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
            if(r.Next(1000)%engine.Difficulty == 0)
            {
                int br = r.Next(100);
                if (engine.getBricks()[br] != null && engine.getBricks()[br].BType != BrickType.Dead)
                {
                    if (engine.getBricks()[br].BType == BrickType.Tank1 || engine.getBricks()[br].BType == BrickType.Tank2 || engine.getBricks()[br].BType == BrickType.Tank3)
                    {
                        engine.addBullet(engine.getBricks()[br].XPos + 25, engine.getBricks()[br].YPos);
                        engine.addBullet(engine.getBricks()[br].XPos + 75, engine.getBricks()[br].YPos);
                    }
                    if (engine.getBricks()[br].BType == BrickType.Sand1 || engine.getBricks()[br].BType == BrickType.Sand2)
                    {
                        engine.addBullet(engine.getBricks()[br].XPos + 50, engine.getBricks()[br].YPos);
                    }
                    if (engine.getBricks()[br].BType == BrickType.Soldier)
                    {
                        engine.addBullet(engine.getBricks()[br].XPos + 12, engine.getBricks()[br].YPos);
                        engine.addBullet(engine.getBricks()[br].XPos + 37, engine.getBricks()[br].YPos);
                        engine.addBullet(engine.getBricks()[br].XPos + 62, engine.getBricks()[br].YPos);
                        engine.addBullet(engine.getBricks()[br].XPos + 87, engine.getBricks()[br].YPos);
                    }
                }
            }
            engine.paddleHit();
            engine.bulletHit();
            this.scoreBox.Text = "Score: " + engine.Score;
            Refresh();
        }

        private void GameWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Point position = e.Location;
            engine.Paddle.updatePos(position.X - (engine.Paddle.Length * 20 / 2));
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            engine.Difficulty = 20;
            easyButton.Enabled = false;
            easyButton.Visible = false;
            mediumButton.Enabled = false;
            mediumButton.Visible = false;
            hardButton.Enabled = false;
            hardButton.Visible = false;
            timer1.Start();

        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            engine.Difficulty = 10;
            easyButton.Enabled = false;
            easyButton.Visible = false;
            mediumButton.Enabled = false;
            mediumButton.Visible = false;
            hardButton.Enabled = false;
            hardButton.Visible = false;
            timer1.Start();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            engine.Difficulty = 5;
            easyButton.Enabled = false;
            easyButton.Visible = false;
            mediumButton.Enabled = false;
            mediumButton.Visible = false;
            hardButton.Enabled = false;
            hardButton.Visible = false;
            timer1.Start();
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
            prompt.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
