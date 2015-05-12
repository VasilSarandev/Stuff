using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_Larger_Than_Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFirst();
        }
        static void FindFirst()
        {
            Console.WriteLine("Please enter elements of Array, separated by space.");
            string givenInput = Console.ReadLine();
            string[] givenInputArray = givenInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] givenIntegerArray = new int[givenInputArray.Length];
            for (int i = 0; i < givenIntegerArray.Length; i++)
            {
                givenIntegerArray[i] = int.Parse(givenInputArray[i]);
            }
            bool Found = false;
            int FoundIndex = 0;
            if (givenIntegerArray.Length > 2)
            {
                for (int j = 1; j < givenIntegerArray.Length - 1; j++)
                {
                    if (givenIntegerArray[j] > givenIntegerArray[j - 1] && givenIntegerArray[j] > givenIntegerArray[j + 1])
                    {
                        Found = true;
                        FoundIndex=j;
                        break;
                    }
                }
            }
            if (Found)
            {
                Console.WriteLine("Found at index {0} ", FoundIndex);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
