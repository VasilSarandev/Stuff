using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fire_in_the_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //part 1
            for (int i = 0; i < N / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("#");
            Console.Write("#");
            for (int i = 0; i < N / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            int dotCounter = N / 2 - 2;
            int middleDotCounter = 2;
            while (dotCounter != 0)
            {
                
                    for (int k = 0; k < dotCounter; k++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("#");
                    for (int k = 0; k < middleDotCounter; k++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("#");
                    for (int k = 0; k < dotCounter; k++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                    dotCounter--;
                    middleDotCounter = middleDotCounter * 2;
                }
            }




                //part 3
                for (int i = 0; i < N; i++)
                {
                    Console.Write("-");
                }
            Console.WriteLine();

            //part 2
            int counterSlash = 4;
            int CounterDot = 0;
            for (int i = 0; i < N / 2; i++)
            {
                for (int k = 0; k < CounterDot; k++)
                {
                    Console.Write(".");
                }
                for (int k = 0; k < counterSlash; k++)
                {
                    Console.Write('\\');
                }
                
                for (int k = 0; k < counterSlash; k++)
                {
                    Console.Write("/");
                }
                for (int k = 0; k < CounterDot; k++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                counterSlash--;
                CounterDot++;
            }
        }
    }
}
