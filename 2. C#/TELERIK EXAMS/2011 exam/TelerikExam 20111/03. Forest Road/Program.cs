using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Forest_Road
{
    class Program
    {
        static void Main(string[] args)
        {
            int Width = int.Parse(Console.ReadLine());
            int Height = Width * 2 - 1;
            int CurrentPlace = 0;
            int SubCurrentPlace = 0;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (j != CurrentPlace)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                   
                    
                }
                CurrentPlace++;
                Console.WriteLine();
            }
            SubCurrentPlace = CurrentPlace - 2;
            for (int i = Width - 1; i > 0; i--)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (j != SubCurrentPlace)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                }
                SubCurrentPlace--;
                Console.WriteLine();
            }
        }
    }
}
