using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallOfDuty
{
    public enum BrickType { Tank1, Tank2, Tank3, Sand1, Sand2, Soldier, Dead };

    class Brick
    {
        private int height;
        private int width;
        private int brickHits;
        private int xPos;
        private int yPos;
        private BrickType bType;
        private Image tank1Image = Image.FromFile(".\\Images\\tank.png");
        private Image tank2Image = Image.FromFile(".\\Images\\damagedtanks.png");
        private Image tank3Image = Image.FromFile(".\\Images\\damagedtanks2.png");
        private Image sand1Image = Image.FromFile(".\\Images\\sandbagClear.png");
        private Image sand2Image = Image.FromFile(".\\Images\\damagedSandbag.png");
        private Image soldierImage = Image.FromFile(".\\Images\\enemyNew.png");
        private Image deadImage = Image.FromFile(".\\Images\\charredOverlay.png");


        public Brick(int x, int y, BrickType btype, int brickHits)
        {
            this.height = 50;
            this.width = 100;
            this.brickHits = brickHits;
            this.xPos = x;
            this.yPos = y;
            this.bType = btype;
            //this.color = color;



        }

        public BrickType BType
        {
            get { return bType; }
            set { bType = value; }
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

        /* Determines if the ball's position is inside the brick's position. If so, true is returned
         * as a hit is detected. The number of hits the brick has is reduced by one.
         */
        public bool hit(Ball b)
        {
            //collision on right of brick (uses left corner of ball)
            if (b.XPos - b.Size >= xPos && b.XPos - b.Size <= (xPos + width) && b.YPos <= (yPos + height) && b.YPos >= yPos)
            {
                switch (bType)
                {
                    case BrickType.Dead:
                        return false;
                    case BrickType.Tank1:
                        bType = BrickType.Tank2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank2:
                        bType = BrickType.Tank3;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank3:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand1:
                        bType = BrickType.Sand2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand2:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Soldier:
                        brickHits = brickHits - 1;
                        return true;
                 }
            }
            //collision on left of brick (uses right corner of ball)
            if (b.XPos + b.Size >= xPos && b.XPos + b.Size <= (xPos + width) && b.YPos <= (yPos + height) && b.YPos >= yPos)
            {
                
                switch (bType)
                {
                    case BrickType.Dead:
                        return false;
                    case BrickType.Tank1:
                        bType = BrickType.Tank2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank2:
                        bType = BrickType.Tank3;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank3:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand1:
                        bType = BrickType.Sand2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand2:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Soldier:
                        brickHits = brickHits - 1;
                        return true;
                }
                
            }
            //collision on top of brick (uses bottom of ball)
            if (b.XPos >= xPos && b.XPos <= (xPos + width) && b.YPos + b.Size <= (yPos + height) && b.YPos + b.Size >= yPos)
            {
                
                switch (bType)
                {
                    case BrickType.Dead:
                        return false;
                    case BrickType.Tank1:
                        bType = BrickType.Tank2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank2:
                        bType = BrickType.Tank3;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank3:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand1:
                        bType = BrickType.Sand2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand2:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Soldier:
                        brickHits = brickHits - 1;
                        return true;
                }
                
            }
            //collision on bottom of brick (uses top of ball)
            if (b.XPos >= xPos && b.XPos <= (xPos + width) && b.YPos - b.Size <= (yPos + height) && b.YPos - b.Size >= yPos)
            {
                
                switch (bType)
                {
                    case BrickType.Dead:
                        return false;
                    case BrickType.Tank1:
                        bType = BrickType.Tank2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank2:
                        bType = BrickType.Tank3;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Tank3:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand1:
                        bType = BrickType.Sand2;
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Sand2:
                        brickHits = brickHits - 1;
                        return true;
                    case BrickType.Soldier:
                        brickHits = brickHits - 1;
                        return true;
                }
                
            }
            return false;
        }

        public void paint(Graphics g)
        {
            Rectangle r = new Rectangle(xPos, yPos, width, height);
            Image image;
            if (bType == BrickType.Sand1)
            {
                image = sand1Image;
                g.DrawImage(image, r);
            }
            else if (bType == BrickType.Sand2)
            {
                image = sand2Image;
                g.DrawImage(image, r);
            }
            else if (bType == BrickType.Soldier)
            {
                image = soldierImage;
                g.DrawImage(image, r);
            }
            else if (bType == BrickType.Tank1)
            {
                image = tank1Image;
                g.DrawImage(image, r);
            }
            else if (bType == BrickType.Tank2)
            {
                image = tank2Image;
                g.DrawImage(image, r);
            }
            else if (bType == BrickType.Tank3)
            {
                image = tank3Image;
                g.DrawImage(image, r);
            }
            else
            {
                image = deadImage;
                g.DrawImage(image, r);
            }


        }
    }
}
