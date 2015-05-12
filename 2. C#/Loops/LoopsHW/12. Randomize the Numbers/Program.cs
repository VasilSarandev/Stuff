using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
    class RandomizeTheNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter N");
            int GivenN = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] RandomIntegers;
            RandomIntegers = new int[GivenN];
            //give values to positions in arrays.
            for (int i = 1; i <= GivenN; i++)
            {
                RandomIntegers[i - 1] = i;
            }
            //shuffle 
            for (int i = 0; i < GivenN; i++)
            {
                int i1 = rnd.Next(0, GivenN-1);
                int i2 = rnd.Next(0, GivenN-1);
                int temporary = RandomIntegers[i1];
                RandomIntegers[i1] = RandomIntegers[i2];
                RandomIntegers[2] = temporary;
                temporary = 0;
            }
                //print

                for (int i = 0; i < RandomIntegers.Length; i++)
                {
                    Console.WriteLine(RandomIntegers[i]);
                }
        }
    }

