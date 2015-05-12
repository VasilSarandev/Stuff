using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

    class RandomIntegersInRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter N");
            int givenN = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi again. Please enter minimum");
            int DimensionA = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi for the last time. Please enter maximum");
            int DimensionB = int.Parse(Console.ReadLine());
            int[] RandomIntegers;
            RandomIntegers=new int[givenN];
            Random rnd = new Random();
            for (int i = 0; i < givenN; i++)
            {
                int RandomInteger = rnd.Next(DimensionA, DimensionB);
                RandomIntegers[i] = RandomInteger;
            }
            Console.WriteLine("Generating {0} Random Numbers between {1} and {2}",givenN, DimensionA, DimensionB);
            for (int i = 0; i < RandomIntegers.Length; i++)
            {
                Console.WriteLine(RandomIntegers[i]);
            }

        }
    }

