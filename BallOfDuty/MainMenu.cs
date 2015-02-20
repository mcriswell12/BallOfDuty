﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallOfDuty
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            using (var soundPlayer = new SoundPlayer(@".\\Images\\title.wav"))
            {
                soundPlayer.Play();
            }
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHighScores_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            HighScoresWindow usr1 = new HighScoresWindow();
            usr1.Show();
            panel1.Controls.Add(usr1);
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            GameWindow usr2 = new GameWindow(this);
            usr2.FormClosed += new FormClosedEventHandler(this.GameOver);
            usr2.Show();
            
        }

        public void GameOver(object sender, FormClosedEventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            HighScoresWindow usr1 = new HighScoresWindow();
            usr1.Show();
            panel1.Controls.Add(usr1);
            
        }

        

        


    }
}
