using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallOfDuty
{
    class Paddle
    {
        private int length;
        private int speed;

        public Paddle()
        {
            this.length = 10;
            this.speed = 7;
        }

        public void changeLength(int newLength)
        {
            this.length = newLength;
        }

        public void changeSpeed(int newSpeed)
        {
            this.speed = newSpeed;
        }
    }
}
