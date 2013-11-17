using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallOfDuty
{
    class Brick
    {
        private int height;
        private int width;
        private int brickHits;
        private int xPos;
        private int yPos;
        private Image image;

        public Brick(int x, int y, Image image)
        {
            this.height = 50;
            this.width = 100;
            this.brickHits = 1;
            this.xPos = x;
            this.yPos = y;
            //this.color = color;
            this.image = image;
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int BrickHits
        {
            get { return brickHits; }
            set { brickHits = value; }
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

        public bool hit(int ballX, int ballY, int ballSize)
        {
            if (ballX + ballSize >= xPos && ballX - ballSize <= (xPos + width) && ballY - ballSize <= (yPos + height) && ballY + ballSize >= yPos)
            {
                brickHits = brickHits - 1;
                return true;                
            }
            return false;
        }

        public void paint(Graphics g)
        {
            Rectangle r = new Rectangle(xPos, yPos, width, height);
            g.DrawImage(image, r);
        }
    }
}
