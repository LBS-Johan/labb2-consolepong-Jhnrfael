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
        Paddle leftPaddle = new Paddle(5, 12, 5);
        Paddle rightPaddle = new Paddle(115, 12, 5);
        Ball ball = new Ball(60, 12);

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

            leftPaddle.Draw();
            rightPaddle.Draw();
            ball.Draw();
            ball.Move();
            ball.CheckCollisions(leftPaddle, rightPaddle, Console.WindowWidth, Console.WindowHeight);


            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
                rightPaddle.Move(-1);

            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
                rightPaddle.Move(1);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                leftPaddle.Move(-1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                leftPaddle.Move(1);
            }

            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
