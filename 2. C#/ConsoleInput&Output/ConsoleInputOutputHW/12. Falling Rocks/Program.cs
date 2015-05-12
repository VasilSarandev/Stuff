using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


namespace _12.Falling_Rocks
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
            //directions
            Position[] Directions = new Position[] 
            {
                new Position(1,0), //right
                new Position(-1,0), //left
                new Position(0,1), //down
            };
            int Direction = 0;
            int score = 0;
            string[] rocks = new string[] 
            {
                "^",
                "@",
                "*",
                "&",
                "+",
                "%",
                "$",
                "#",
                "!",
                ".",
                ";",
                "-",
            };
            //end directions
            //small adjustment
            Console.BufferHeight = Console.WindowHeight;
            //create dwarf
            Position SmallDwarf = new Position(Console.WindowWidth / 2, Console.WindowHeight-3);
            //try to draw dwarf
            Console.SetCursorPosition(SmallDwarf.X, SmallDwarf.Y);

            Console.Write("(0)");
            //create food
            Random RandomIntGenerator = new Random();
            
            Queue<Position> FoodElements = new Queue<Position>();
            //generate a chosen by me count of food.
            for (int i = 0; i < 18; i++)
            {
                FoodElements.Enqueue(new Position(RandomIntGenerator.Next(0, Console.WindowWidth - 10), RandomIntGenerator.Next(0, 5)));
            }
            //try to draw food
            foreach (Position FoodElement in FoodElements)
            { //TODO: Different Symbols for food.
                Console.SetCursorPosition(FoodElement.X, FoodElement.Y);
                Console.Write("*");
            }
            // game cycle.
            while (true)
            {
                score++;
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        Direction = 1;
                        Position NextDirection = Directions[Direction];
                        SmallDwarf = new Position(SmallDwarf.X + NextDirection.X, SmallDwarf.Y - NextDirection.Y);
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        Direction = 0;
                        Position NextDirection = Directions[Direction];
                        SmallDwarf = new Position(SmallDwarf.X + NextDirection.X, SmallDwarf.Y - NextDirection.Y);
                    }
                }
                //CREATE NEW ROCKS.

                for (int i = 0; i < 18; i++)
                {
                    if (FoodElements.ElementAt(i).Y == Console.WindowHeight - 1)
                    {
                        for (int j = 0; j < 18; j++)
                        {
                            FoodElements.Enqueue(new Position(RandomIntGenerator.Next(0, Console.WindowWidth - 10), RandomIntGenerator.Next(1, 5)));
                        }
                        for (int k = 0; k < 18; k++)
                        {
                            FoodElements.Dequeue();
                        }
                    }
                }
                //CRASH TEST
                for (int i = 0; i < 18; i++)
                {
                    if ((FoodElements.ElementAt(i).X < SmallDwarf.X+2 && FoodElements.ElementAt(i).X > SmallDwarf.X-2 ) && FoodElements.ElementAt(i).Y > SmallDwarf.Y - 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("ha. Game over !");
                        Console.WriteLine("Score based on your time being alive... : {0}", score*10-180);
                        return;
                    }
                }




                //move food down.
                //create new Queue with new Rocks(changed Y).
                Position result;
                for (int i = 17; i > 0; i--)
                {
                    result = FoodElements.ElementAt(i); //1
                    result.Y += 1; //1
                    //18
                    FoodElements.Enqueue(result); //1-18

                }
                for (int i = 0; i < 17; i++)
                {
                    FoodElements.Dequeue();
                }
                
                //FIX Program Bug.
               





                    //DRAW
                    //draw dwarf
                    Console.Clear();
                    Console.SetCursorPosition(SmallDwarf.X, SmallDwarf.Y);
                    Console.ResetColor();
                    Console.Write("(O)");
                   
                        //draw rocks
                        foreach (Position item in FoodElements)
                        {
                            Console.SetCursorPosition(item.X, item.Y);
                            int TypeOfRock = RandomIntGenerator.Next(0, 12);
                            //COLOR GENERATOR
                            int ColorInt = RandomIntGenerator.Next(0, 5);
                            switch (ColorInt)
                            {
                                case 1: Console.ForegroundColor = ConsoleColor.Cyan; break;
                                case 2: Console.ForegroundColor = ConsoleColor.Yellow; break;
                                case 3: Console.ForegroundColor = ConsoleColor.Green; break;
                                case 4: Console.ForegroundColor = ConsoleColor.White; break;
                                case 5: Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                            Console.Write(rocks[TypeOfRock]);
                        }

                        Thread.Sleep(150);

                    
                        
                }
            }

        }
    }

