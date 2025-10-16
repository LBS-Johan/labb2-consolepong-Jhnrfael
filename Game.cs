using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;


        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            Paddle testPaddle = new Paddle(5, 10, 1);
            testPaddle.Draw();

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
                Paddle p1Paddle = new Paddle(5, 10, 1);
                p1Paddle.Move(1);

            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
                Paddle p1Paddle = new Paddle(5, 10, 1);
                p1Paddle.Move(-1);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                Paddle p2Paddle = new Paddle(25, 10, 1);
                p2Paddle.Move(1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                Paddle p2Paddle = new Paddle(25, 10, 1);
                p2Paddle.Move(-1);
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
