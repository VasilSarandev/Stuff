using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Tribonacci_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long FibonacciInt1 = long.Parse(Console.ReadLine());
            long FibonacciInt2 = long.Parse(Console.ReadLine());
            long FibonacciInt3 = long.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int counter = 1;
            int DynamicI = 0;

            long[] MyFibSequence = new long[150];
            MyFibSequence[0]=FibonacciInt1;
            MyFibSequence[1]=FibonacciInt2;
            MyFibSequence[2]=FibonacciInt3;
            // fill the array
            for (int i = 3; i < MyFibSequence.Length; i++)
            {
                MyFibSequence[i] = MyFibSequence[i - 1] + MyFibSequence[i - 2] + MyFibSequence[i - 3];
            }


                for (int i = 0; i < L; i++)
                {
                    for (int j = 0; j < counter; j++)
                    {
                        Console.Write("{0} ",MyFibSequence[DynamicI]);
                        DynamicI++;
                    }
                    counter++;
                    Console.WriteLine();
                }
        }
    }
}
