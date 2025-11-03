using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Ball
    {
        int x;
        int y;
        int xVelocity;
        int yVelocity;

        public Ball(int startX, int startY)
        {
            x = startX;
            y = startY;

            Random rand = new Random();
            xVelocity = rand.Next(0, 2) == 0 ? -1 : 1;
            yVelocity = rand.Next(0, 2) == 0 ? -1 : 1;
        }

        public void Move()
        {
            x += xVelocity;
            y += yVelocity;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }

        public void CheckCollisions(Paddle leftPaddle, Paddle rightPaddle, int width, int height)
        {
            // Studsa på topp och botten
            if (y <= 0 || y >= height - 1)
            {
                yVelocity *= -1;
            }

            // Kollision med vänster paddel
            if (x == leftPaddle.xPos + 1 &&
                y >= leftPaddle.yPos &&
                y < leftPaddle.yPos + leftPaddle.playerSize)
            {
                xVelocity = 1;
            }

            // Kollision med höger paddel
            if (x == rightPaddle.xPos - 1 &&
                y >= rightPaddle.yPos &&
                y < rightPaddle.yPos + rightPaddle.playerSize)
            {
                xVelocity = -1;
            }

            // Om bollen går utanför planen → reset till mitten
            if (x <= 0 || x >= width - 1)
            {
                Reset(width / 2, height / 2);
            }
        }

        private void Reset(int startX, int startY)
        {
            x = startX;
            y = startY;

            Random rand = new Random();
            xVelocity = rand.Next(0, 2) == 0 ? -1 : 1;
            yVelocity = rand.Next(0, 2) == 0 ? -1 : 1;
        }

    }
}
