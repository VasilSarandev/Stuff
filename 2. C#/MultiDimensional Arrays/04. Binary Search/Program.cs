using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me some integers separated by space.");
            string givenInput = Console.ReadLine();
            string[] givenInputArray = givenInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] finalIntArray = new int[givenInputArray.Length];
            for (int i = 0; i < givenInputArray.Length; i++)
            {
                finalIntArray[i] = int.Parse(givenInputArray[i]);
            }
            List<int> finalIntList = new List<int>();
            for (int i = 0; i < finalIntArray.Length; i++)
            {
                finalIntList.Add(finalIntArray[i]);
            }
            //now we have a list with all integers.
            Console.WriteLine("Hi again. Now please give me an integer K");
            int givenK = int.Parse(Console.ReadLine());
            for (int i = 0; i < finalIntList.Count; i++)
            {
                if (finalIntList.Max() > givenK)
                {
                    finalIntList.Remove(finalIntList.Max());
                }
            }
            //now just do a simple binary search for max :)
            Console.WriteLine("Max from binary search < K = ... {0}", finalIntList[finalIntList.BinarySearch(finalIntList.Max())]);
            
            
        }
    }
}
