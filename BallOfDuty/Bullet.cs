using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BallOfDuty
{
    class Bullet
    {
        int xPos;
        int yPos;
        
        public Bullet(int x, int y)
        {
            this.xPos = x;
            this.yPos = y;
        }

        public void moveDown()
        {
          this.yPos = yPos + 10;
            
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
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Rectangle rect = new Rectangle(xPos - 10, yPos - 10, 5, 10);
            g.FillRectangle(myBrush, rect);
        }

    }
}
