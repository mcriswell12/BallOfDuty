using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallOfDuty
{
    class Paddle
    {
        private int length;
        private int speed;
        private int xPos;
        private int yPos;

        public Paddle()
        {
            this.length = 10;
            this.speed = 7;
            this.xPos = 375;
            this.yPos = 600;
        }

        public void changeLength(int newLength)
        {
            this.length = newLength;
        }

        public void changeSpeed(int newSpeed)
        {
            this.speed = newSpeed;
        }

        public void paint(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, xPos, yPos, xPos + 100, yPos);
        }
    }
}
