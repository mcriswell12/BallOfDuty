using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallOfDuty
{
    class Brick
    {
        private int length;
        private int width;
        private int brickHits;

        public Brick(int len, int wid, int bH)
        {
            this.length = len;
            this.width = wid;
            this.brickHits = bH;
        }

        public void brickDestroyed()
        {
            if (this.brickHits == 0)
                ;
        }
    }
}
