using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Game_of_Page
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
            //read tray
            int BoughtCookies = 0;
            int sum = 0;
            string[] tray = new string[16];
            for (int i = 0; i < 16; i++)
            {
                tray[i] = Console.ReadLine();
            }
            //Questionable position
            Position QuestionnedPosition = new Position(0, 0);



            //read cycle
            while (true)
            {
                string Command = Console.ReadLine();
                if (Command == "paypal")
                {
                    Console.WriteLine("{0:F2}", BoughtCookies * 1.79);
                    break;
                }

                int CoordinateY = int.Parse(Console.ReadLine());
                int CoordinateX = int.Parse(Console.ReadLine());
                //Handle Exceptions.

                QuestionnedPosition.X = CoordinateX;
                QuestionnedPosition.Y = CoordinateY;

                //draw myself smth nice
                /*
                 *                              X X X  1:
                 *                              X O X 
                 *                              X X X 
                 *                              
                  * */
                //make tests for position
                if (Command == "what is")
                {
                    sum = 0;

                    if (tray[QuestionnedPosition.Y][QuestionnedPosition.X] == '1')
                    {
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X - 1, QuestionnedPosition.Y - 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X, QuestionnedPosition.Y - 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X + 1, QuestionnedPosition.Y - 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X - 1, QuestionnedPosition.Y);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X + 1, QuestionnedPosition.Y);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X - 1, QuestionnedPosition.Y + 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X, QuestionnedPosition.Y + 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X + 1, QuestionnedPosition.Y + 1);
                    }



                    if (sum == 8)
                    {
                        Console.WriteLine("cookie");
                    }
                    if (sum < 8 && sum > 1)
                    {
                        Console.WriteLine("broken cookie");
                    }
                    if (sum == 0)
                    {
                        Console.WriteLine("cookie crumb");
                    }

                }
                if (Command == "buy")
                {
                    sum = 0;
                    if (tray[QuestionnedPosition.Y][QuestionnedPosition.X] == '1')
                    {
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X - 1, QuestionnedPosition.Y - 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X, QuestionnedPosition.Y - 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X + 1, QuestionnedPosition.Y - 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X - 1, QuestionnedPosition.Y);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X + 1, QuestionnedPosition.Y);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X - 1, QuestionnedPosition.Y + 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X, QuestionnedPosition.Y + 1);
                        sum += CheckIfOne(tray, sum, QuestionnedPosition.X + 1, QuestionnedPosition.Y + 1);
                    }

                    if (sum == 8)
                    {
                        BoughtCookies++;
                    }
                    if (sum < 8 && sum > 0)
                    {
                        Console.WriteLine("page");
                    }
                    if (sum == 0)
                    {
                        Console.WriteLine("smile");
                    }

                }


            }
        }
        //remember
        private static int CheckIfOne(string[] array, int sum, int x, int y)
        {
            if (x < 0 || x > 15 ||
                y < 0 || y > 15)
            {
                return 0;
            }
            else
            {
                if (array[y][x] == '1')
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
