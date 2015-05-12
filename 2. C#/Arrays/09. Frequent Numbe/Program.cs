using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that finds the most frequent number in an array.
namespace _09.Frequent_Numbe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers of array separated by space.");
            string givenString = Console.ReadLine();
            string[] givenArray = givenString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] givenIntArray = new int[givenArray.Length];
            for (int i = 0; i < givenArray.Length; i++)
            {
                givenIntArray[i] = int.Parse(givenArray[i]);
            }
            //got array. now functionality.
            int currentcount = 0;
            int maxcount = 0;
            int best = 0;
            int currBest = 0;
            int currBestIndex = 0;
            for (int i = 0; i < givenIntArray.Length; i++)
            {
                if (givenIntArray[i] == givenIntArray[currBestIndex])
                {
                    currentcount++;
                    currBest = givenIntArray[i];
                    if (currentcount > maxcount)
                    {
                        maxcount = currentcount;
                        best = currBest;
                    }
                    else
                    {
                        currentcount = 0;
                        currBest = 0;
                        currBestIndex++;
                    }
                }
            }
            for (int i = 0; i < maxcount; i++)
            {
                Console.Write("{0} ", best);
            }
            
        }
    }
}
