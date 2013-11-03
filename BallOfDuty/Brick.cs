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
        private Color color;

        public Brick(int hei, int wid, int bH, int x, int y, Color color)
        {
            this.height = hei;
            this.width = wid;
            this.brickHits = bH;
            this.xPos = x;
            this.yPos = y;
            this.color = color;
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

        public void hit()
        {
            brickHits = brickHits - 1;
            if (brickHits == 0)
            {
                brickDestroyed();
            }
        }

        public void brickDestroyed()
        {
            height = 0;
            width = 0;
        }

        public void paint(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillRectangle(b, xPos, yPos, width, height);
        }
    }
}
