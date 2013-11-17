using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BallOfDuty
{
    class Engine
    {
        private Brick[] bricks;
        private int capacity;
        private int count;
        private Ball ball;
        private Paddle paddle;
        private int moveX;
        private bool gameOver;
        private int score;


        public Engine()
        {
            capacity = 500;
            bricks = new Brick[capacity];
            count = 0;
            paddle = new Paddle(1200/2 - 50, 720-30);
            ball = new Ball(1200/ 2, 720 - 30);
            gameOver = false;
            score = 0;
        }

        internal Paddle Paddle
        {
            get { return paddle; }
        }

        internal Ball Ball
        {
            get { return ball; }
            set { ball = value; }
        }

        public int Score
        {
            get { return score; }
        }

        public bool GameOver
        {
            get { return gameOver; }
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public int Count
        {
            get { return count; }
        }

        public void addBrick(int x, int y, Image image)
        {
            if (count < capacity)
            {
                Brick b = new Brick(x, y, image);
                bricks[count] = b;
                count++;
            }
        }

        public void removeBrickAt(int i)
        {
            if (0 <= i && i < count)
            {
                for (int j = i + 1; j < count; j++)
                {
                    bricks[j - 1] = bricks[j];
                }
                count--;
            }
            else
            {

            }
        }

        public void brickHit()
        {
            for (int i = 0; i < count; i++)
            {
                Brick c = bricks[i];
                if (c.hit(ball.XPos, ball.YPos, ball.Size))
                {
                    if (ball.XPos + ball.Size <= bricks[i].XPos + ball.Size || ball.XPos - ball.Size >= c.XPos + c.Width - ball.Size)
                    {
                        moveX = moveX * -1;
                    }
                    if (ball.YPos + ball.Size <= bricks[i].YPos + ball.Size || ball.YPos - ball.Size >= c.YPos + c.Height - ball.Size)
                    {
                        ball.Speed = ball.Speed * -1;
                    }
                    if (c.BrickHits <= 0)
                    {
                        removeBrickAt(i);
                    }
                    score += 100;
                }
            }
        }
        public void paddleHit()
        {
            if ((ball.XPos >= (paddle.XPos + 40) && ball.XPos <= (paddle.XPos + 60)
                    && ball.YPos >= paddle.YPos))
            {
                ball.changeSpeed(10);
                moveX = 0;
            }
            if (ball.XPos >= (paddle.XPos + 75) && ball.XPos <= (paddle.XPos + 85)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = 5;
            }
            if (ball.XPos >= paddle.XPos && ball.XPos < (paddle.XPos + 5) && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = -10;
            }
            if (ball.XPos >= (paddle.XPos + 5) && ball.XPos < (paddle.XPos + 15)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = -9;
            }
            if (ball.XPos >= (paddle.XPos + 15) && ball.XPos < (paddle.XPos + 25)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = -8;
            }
            if (ball.XPos >= (paddle.XPos + 25) && ball.XPos < (paddle.XPos + 40)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = -7;
            }
            if (ball.XPos >= (paddle.XPos + 60) && ball.XPos <= (paddle.XPos + 75)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = 7;
            }
            if (ball.XPos >= (paddle.XPos + 75) && ball.XPos <= (paddle.XPos + 85)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = 8;

            }
            if (ball.XPos >= (paddle.XPos + 85) && ball.XPos < (paddle.XPos + 95)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = 9;

            }
            if (ball.XPos >= (paddle.XPos + 95) && ball.XPos <= (paddle.XPos + 100)
                    && ball.YPos >= paddle.YPos)
            {
                ball.changeSpeed(10);
                moveX = 10;
            }
            if (ball.XPos - ball.Size <= 0 || ball.XPos + ball.Size >= 1200)
            {
                moveX = moveX * -1;
            }
            if (ball.YPos > paddle.YPos + 10)
            {
                gameOver = true;
            }
            ball.changeMoveX(moveX);
            ball.moveUp();
        }

        public void paint(Graphics g)
        {
            for (int i = 0; i < count; i++)
            {
                bricks[i].paint(g);
            }
            paddle.paint(g);
            ball.paint(g);
        }
    }
}
