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
        private int height;
        private int speed;
        private int xPos;
        private int yPos;
        private Rectangle[] soldiers;
        private Image im;

        public Paddle(int x, int y)
        {
            this.length = 5;
            this.speed = 7;
            this.height = 25;
            this.xPos = x;
            this.yPos = y;
            im = Image.FromFile(@"..\\..\\Images\soldier.png");
            soldiers = new Rectangle[10];
            
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
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
            xPos = xPos - 20;

        }

        public void moveRight()
        {
            xPos = xPos + 20;
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
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
            for (int i = 0; i < length; i++)
            {
                
                soldiers[i] = new Rectangle(xPos + (i * 20), yPos - 25, 20, height);
                g.DrawImage(im, soldiers[i]);
            }
        }

        /* Uses the position of the bullet to determine if there was a collision with the paddle. If so, 
         * the length is reduced by one.
         */
        public bool hit(int bulletX, int bulletY)
        {
            if (bulletX >= xPos && bulletX <= (xPos + length* 20) && bulletY >= yPos - height)
            {
                length--;
                return true;
            }
            return false;
        }


        internal void updatePos(int p)
        {
            this.xPos = p;
        }
    }
}
