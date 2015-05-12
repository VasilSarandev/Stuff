using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please give sequence of integers separated by space.");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] givenInts = new int[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                givenInts[i] = int.Parse(inputSplit[i]);
            }
            Console.WriteLine("sum : {0}", calcSum(givenInts));
        }
        static int calcSum(int[] Array)
        {
            int sum = 0;
            foreach (var value in Array)
            {
                sum += value;
            }
            return sum;
        }
    }
}
