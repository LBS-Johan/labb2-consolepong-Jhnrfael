using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Ball
    {
        int xBallPos;
        int yBallPos;
        int xVelocity;
        int yVelocity;

        public Ball(int xBallPosStart, int yBallPosStart)
        {
            xBallPos = xBallPosStart;
            yBallPos = yBallPosStart;

            Random rand = new Random();
            xVelocity = rand.Next(0, 2) == 0 ? -1: 1;
            yVelocity = rand.Next(0, 2) == 0 ? -1: 1;
        }

        public void Move()
        {
            xBallPos += xVelocity;
            yBallPos += yVelocity;
        }

        public void Draw()
        {
            Console.SetCursorPosition(xBallPos, yBallPos);
            Console.Write("O");
        }

        public void CheckCollisions(Paddle leftPaddle, Paddle rightPaddle, int width, int height)
        {

            if (yBallPos <= 0 || yBallPos >= height - 1)
            {
                yVelocity *= -1;
            }

            if (xBallPos >= leftPaddle.xPos + 1 &&
                yBallPos <= leftPaddle.yPos &&
                yBallPos < leftPaddle.yPos + leftPaddle.playerSize)
            {
                xVelocity = -1;

            }
            else if (xBallPos <= rightPaddle.xPos - 1 &&
                     yBallPos >= rightPaddle.yPos &&
                     yBallPos > rightPaddle.yPos + rightPaddle.playerSize)
            {
                xVelocity = +1;
            }

            if (xBallPos <= 0 || xBallPos >= width - 1)
            {
                Reset(width / 2, height / 2);
            }

            void Reset(int x, int y)
            {
                xBallPos = x;
                yBallPos = y;

                Random rand = new Random();
                xVelocity = rand.Next(0, 2) == 0 ? -1 : 1;
                yVelocity = rand.Next(0, 2) == 0 ? -1 : 1;
            }

        }

    }
}
