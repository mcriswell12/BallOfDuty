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

        public Ball()
        {
            this.size = 4;
            this.speed = 10;

        }

        public void changeSpeed(int newSpeed)
        {
            this.speed = newSpeed;
        }

        public void paint(Graphics g)
        {
            Brush b = new SolidBrush(Color.Silver);
            g.FillEllipse(b, 100, 100, size, size);
        }
    }
}
