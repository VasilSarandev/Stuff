using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Miss_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int GivenN = int.Parse(Console.ReadLine());
            int CurrentResult = 0;
            int[] Cats = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Cats[i] = 0;
            }


                for (int i = 0; i < GivenN; i++)
                {
                    CurrentResult = int.Parse(Console.ReadLine());
                    if (CurrentResult == 1)
                    {
                        Cats[CurrentResult-1]++;
                    }
                    if (CurrentResult == 2)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 3)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 4)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 5)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 6)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 7)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 8)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 9)
                    {
                        Cats[CurrentResult - 1]++;
                    }
                    if (CurrentResult == 10)
                    {
                        Cats[CurrentResult - 1]++;
                    }

                }
            
                int MaxValue = Cats.Max();
                int MaxValueIndex = Cats.ToList().IndexOf(MaxValue);
                Console.Write(MaxValueIndex + 1);
            
        }
    }
}
