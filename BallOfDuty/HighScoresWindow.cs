using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BallOfDuty
{
    public partial class HighScoresWindow : UserControl
    {
        
        public HighScoresWindow()
        {
            using (var soundPlayer = new SoundPlayer(@".\\Images\\highscores.wav"))
            {
                soundPlayer.Play();
            }
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Visible = false;
            ((Panel)this.Parent).Controls.Remove(this);
            using (var soundPlayer = new SoundPlayer(@".\\Images\\title.wav"))
            {
                soundPlayer.Play();
            }
            
        }

        
    }
}
