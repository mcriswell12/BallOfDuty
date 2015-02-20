using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallOfDuty
{
    class Ball
    {
        private int size;
        private double speed;
        private double moveX;
        private double xPos;
        private double yPos;

        public Ball(int x, int y)
        {
            this.size = 10;
            this.speed = 10;
            this.xPos = x;
            this.yPos = y;
        }

        public void moveUp()
        {
            this.yPos = yPos - speed;
            if (this.yPos <= 0 + size)
            {
                speed = speed * -1;
            }
        }

        public void changeMoveX()
        {
            this.xPos = xPos + moveX;
        }
        public double XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public double YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public double MoveX
        {
            get { return moveX; }
            set { moveX = value; }
        }


        public void changeSpeed(double newSpeed)
        {
            this.speed = newSpeed;
        }

        public void paint(Graphics g)
        {
            Rectangle rect = new Rectangle((int)(xPos- size), (int)(yPos - size), size * 2, size * 2);
            Image im = Image.FromFile("..\\..\\Images\\ball.png");
            g.DrawImage(im, rect);
        }
    }
}
