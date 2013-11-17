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
        private Image im;

        public Paddle(int x, int y)
        {
            this.length = 10;
            this.speed = 7;
            this.xPos = x;
            this.yPos = y;
            im = Image.FromFile(@"..\\..\\Images\american-flag.jpg");
        }

        public void changeLength(int newLength)
        {
            this.length = newLength;
        }

        public void changeSpeed(int newSpeed)
        {
            this.speed = newSpeed;
        }
        public void moveLeft()
        {
            xPos = xPos - 10;

        }
        public void moveRight()
        {
            xPos = xPos + 10;
        }
        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public void paint(Graphics g)
        {
            Rectangle r = new Rectangle(xPos, yPos, 100, 25);
            g.DrawImage(im, r);
            //Pen p = new Pen(Color.Black);
            //g.DrawLine(p, xPos, yPos, xPos + 100, yPos);
        }
    }
}
