using System;
using System.Collections.Generic;
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
    }
}
