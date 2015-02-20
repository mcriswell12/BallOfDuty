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
        private bool gameOver;
        private int score;
        private List<Bullet> bullets;
        private int difficulty;
        private int totalBricks;


        public Engine()
        {
            capacity = 500;
            bricks = new Brick[capacity];
            count = 0;
            paddle = new Paddle(1200 / 2 - 50, 720 - 30);
            ball = new Ball(1200 / 2 + 20, 720 - 50 - paddle.Height);
            gameOver = false;
            score = 0;
            bullets = new List<Bullet>();
            totalBricks = 0;
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

        internal int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
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

        public Brick[] getBricks()
        {
            return bricks;
        }

        public void addBullet(int x, int y)
        {
            bullets.Add(new Bullet(x, y));
        }

        /* adds a brick to the array of bricks and increases the count to show the total number of bricks in the array
         */
        public void addBrick(int x, int y, BrickType btype, int brickHits)
        {
            if (count < capacity)
            {
                Brick b = new Brick(x, y, btype, brickHits);
                bricks[count] = b;
                count++;
                totalBricks++;
            }
        }
        /* remove the specificied brick at index i and shifts the array forward so no empty indices will be called upon
         */
        public void removeBrickAt(int i)
        {
            if (0 <= i && i < totalBricks)
            {
                bricks[i].BType = BrickType.Dead;
                count--;
            }
            if(count == 0)
                gameOver = true;
        }

        /* Calls the hit method in brick to see if the ball collides with the object. 
         * If true, determines which side of the brick was hit and modifies the ball movement vectors accordingly
         */
        public void brickHit()
        {
            for (int i = 0; i < totalBricks; i++)
            {
                Brick c = bricks[i];
                if (c.hit(ball))
                {
                    if (ball.XPos - ball.Size <= bricks[i].XPos || ball.XPos + ball.Size >= c.XPos + c.Width)
                    {
                        ball.MoveX = ball.MoveX * -1;
                    }
                    if (ball.YPos - ball.Size <= bricks[i].YPos || ball.YPos + ball.Size >= c.YPos + c.Height)
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

        /* Calls the paddle hit method with the position of a bullet in order to determine if there is a collision.
         * If there is, the length of the paddle is reduced by one.
         */
        public void bulletHit()
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].moveDown();
                if(paddle.hit(bullets[i].XPos, bullets[i].YPos + 10) || bullets[i].YPos > 700)
                    bullets.RemoveAt(i);
            }
        
        }

        /* Divides the paddle into 9 different sections based on its length and modifies the vector of the balls
         * accordingly
         */
        public void paddleHit()
        {
            if (ball.XPos + ball.Size >= paddle.XPos && ball.XPos - ball.Size <= (paddle.XPos + paddle.Length * 20)
                    && ball.YPos + ball.Size >= paddle.YPos - paddle.Height)
            {
                double ballWidth = ball.Size * 2;
                double ballCenterX = ball.XPos;
                double paddleWidth = paddle.Length * 20;
                double paddleCenterX = paddle.XPos + paddleWidth / 2;
                double speedX = ball.MoveX;
                double speedY = ball.Speed;

                double speedXY = Math.Sqrt(speedX * speedX + speedY * speedY);

                double posX = (ballCenterX - paddleCenterX) / (paddleWidth / 2);

                double influenceX = 0.75;

                speedX = speedXY * posX * influenceX;
                ball.MoveX = speedX;

                speedY = Math.Sqrt(speedXY * speedXY - speedX * speedX) *
                         (speedY > 0 ? -1 : 1);
                ball.changeSpeed(speedY);
            }
            if (ball.XPos - ball.Size <= 0 || ball.XPos + ball.Size >= 1200)
            {
                ball.MoveX = ball.MoveX * -1;
            }
            if (ball.YPos > paddle.YPos + 25 || paddle.Length == 0)
            {
                gameOver = true;
            }
            ball.changeMoveX();
            ball.moveUp();
        }

        public void paint(Graphics g)
        {
            foreach (Bullet b in bullets)
            {
                b.paint(g);
            }
            for (int i = 0; i < totalBricks; i++)
            {
                bricks[i].paint(g);
            }
            paddle.paint(g);
            ball.paint(g);
        }
    }
}
