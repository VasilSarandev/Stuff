using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace TryingToRebuildSnake
{
    struct Position
    {
        public int X;
        public int Y;
        public Position(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
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
                new Position(1,0), //down
                new Position(-1,0), //up
            };
            int direction=0;
            Queue<Position> SnakeElements = new Queue<Position>();
            for (int i = 0; i < 6; i++)
            {
                SnakeElements.Enqueue(new Position(0, i));
            }
            foreach (Position item in SnakeElements)
            {
                Console.SetCursorPosition(item.Y,  item.X);
                Console.Write("*");
            }
            Console.BufferHeight = Console.WindowHeight;
            Random RandomIntegerGenerator = new Random();
            Position food = new Position(RandomIntegerGenerator.Next(0, Console.WindowWidth), RandomIntegerGenerator.Next(0, Console.WindowHeight));


                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userInput = Console.ReadKey();
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            direction = 2;
                        }
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            direction = 3;
                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            direction = 0;
                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            direction = 1;
                        }
                    }
                    Position SnakeHead = SnakeElements.Last();
                    
                    Position CurrentDirection = Directions[direction];
                    Position newSnakeHead = new Position(SnakeHead.X + CurrentDirection.X, SnakeHead.Y + CurrentDirection.Y);
                    SnakeElements.Enqueue(newSnakeHead);
                    if (newSnakeHead.X == food.X && newSnakeHead.Y == food.Y)
                    {
                        food = new Position(RandomIntegerGenerator.Next(0, Console.WindowWidth), RandomIntegerGenerator.Next(0, Console.WindowHeight));
                    }
                    else
                    {
                        SnakeElements.Dequeue();
                    }
                    if(newSnakeHead.X>=Console.WindowWidth ||
                       newSnakeHead.Y>=Console.WindowHeight ||
                       newSnakeHead.X<0 ||
                       newSnakeHead.Y < 0)
                    {
                        
                        Console.SetCursorPosition(0, 0);
                        Console.Write("Game over! Your Score is {0} .", SnakeElements.Count * 100);
                        return;
                        
                    }
                    Console.Clear();
                    foreach (Position Position in SnakeElements)
                    {
                        Console.SetCursorPosition(Position.X, Position.Y);
                        Console.Write("*");
                    }
                    Console.SetCursorPosition(food.X, food.Y);
                    Console.Write("@");   
                  
                    Thread.Sleep(100);
                }

        }
    }
}
