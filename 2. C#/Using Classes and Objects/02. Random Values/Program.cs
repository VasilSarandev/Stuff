using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Random_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensionA = 100;
            int dimensionB = 200;
            int count = 10;
            GenerateRandomInRange(dimensionA, dimensionB, count);
        }
        static void GenerateRandomInRange(int A, int B,int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rnd.Next(A, B));
            }

        }
    }
}
