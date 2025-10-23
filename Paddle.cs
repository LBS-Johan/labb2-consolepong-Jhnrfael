using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        public int xPos { get; private set; }
        public int yPos { get; private set; }
        public int playerSize { get; private set; }

        public Paddle(int x, int y, int size)
        {
            xPos = x;
            yPos = y;
            playerSize = size;
        }

        public void Move(int yAmount)
        {
            int newYPos = yPos + yAmount;

            if (newYPos >= 0 && newYPos + playerSize < Console.WindowHeight)
            {
                yPos = newYPos;
            }

        }

        public void Draw()
        {
            for (int i = 0; i < playerSize; i++)
            {
                Console.SetCursorPosition(xPos, yPos + i);
                Console.Write("|");
            }
        }
    }
}
