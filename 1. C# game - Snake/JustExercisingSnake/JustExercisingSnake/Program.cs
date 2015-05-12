using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace JustExercisingSnake
{
    struct Position
    {
        public int X;
        public int Y;
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position[] Directions = new Position[]
            {
                new Position(0,1), //right
                new Position(0,-1), //left
                new Position(1, 0), //down
                new Position(-1,0), //up
            };
            int direction = 0;
            Console.BufferHeight = Console.WindowHeight;
            Random RandomIntegerGenerator = new Random();
            Position food = new Position(RandomIntegerGenerator.Next(0, Console.WindowHeight), RandomIntegerGenerator.Next(0, Console.WindowWidth));
           

            Queue<Position> SnakeElements = new Queue<Position>();
            for (int i = 0; i < 6; i++)
            {
                SnakeElements.Enqueue(new Position(0, i));
                
            }
            foreach (Position position in SnakeElements)
            {
                Console.SetCursorPosition(position.Y, position.X);
                Console.Write("*");
            }

            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();

                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        direction = 1;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        direction = 0;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        direction = 3;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        direction = 2;
                    }
                }

                Position snakeHead = SnakeElements.Last();
                Position nextDirection = Directions[direction];
                Position SnakeNewHead = new Position(snakeHead.X + nextDirection.X,
                    snakeHead.Y + nextDirection.Y);
                SnakeElements.Enqueue(SnakeNewHead);

                if(SnakeNewHead.X<0 ||
                   SnakeNewHead.Y<0 ||
                   SnakeNewHead.Y >= Console.WindowWidth ||
                   SnakeNewHead.X >= Console.WindowHeight
                    )
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game over!");
                    Console.WriteLine("Your points are : {0} ", SnakeElements.Count()*100);
                    return;
                }
                
                if (SnakeNewHead.X == food.X && SnakeNewHead.Y == food.Y)
                {
                     food = new Position(RandomIntegerGenerator.Next(0, Console.WindowHeight), RandomIntegerGenerator.Next(0, Console.WindowWidth));
                }
                else
                {
                    SnakeElements.Dequeue();
                }


                Console.Clear();
                foreach (Position position in SnakeElements)
                {
                    Console.SetCursorPosition(position.Y, position.X);
                    Console.Write("*");
                }
                
               



                Console.SetCursorPosition(food.Y, food.X);
                Console.WriteLine("@");

                Thread.Sleep(100);
                
            }

        }
    }
}
