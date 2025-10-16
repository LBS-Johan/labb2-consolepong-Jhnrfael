using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        int xPos;
        int yPos;
        int playerSize;

        public Paddle(int x, int y, int size)
        {
            xPos = x;
            yPos = y;
            playerSize = size;
        }

        public void Move(int yAmount)
        {

        }

        public void Draw()
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write("|");

            Console.SetCursorPosition(xPos, yPos + 1);
            Console.Write("|");

            Console.SetCursorPosition(xPos, yPos + 2);
            Console.Write("|");


            Console.SetCursorPosition(xPos + 110, yPos);
            Console.Write("|");

            Console.SetCursorPosition(xPos + 110, yPos + 1);
            Console.Write("|");

            Console.SetCursorPosition(xPos + 110, yPos + 2);
            Console.Write("|");
        }

    }
}
