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
        private int speed;
        private int moveX;
        private int xPos;
        private int yPos;

        public Ball(int x, int y)
        {
            this.size = 8;
            this.speed = 10;
            this.xPos = x;
            this.yPos = y;
        }
        public void moveUp()
        {
            this.yPos = yPos - speed;
            if (this.yPos <= 0)
            {
                speed = speed * -1;
            }
        }

        public void changeMoveX(int moveX)
        {
            this.moveX = moveX;
            this.xPos = xPos + moveX;
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
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public int MoveX
        {
            get { return moveX; }
            set { moveX = value; }
        }
        public void changeSpeed(int newSpeed)
        {
            this.speed = newSpeed;
        }

        public void paint(Graphics g)
        {
            Rectangle rect = new Rectangle(xPos, yPos, 20, 20);
            Image im = Image.FromFile("..\\..\\Images\\ball.png");
            g.DrawImage(im, rect);
        }
    }
}
