using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array before sort : ");

            int[] intArray = new int[] {
                5,
                6,
                1,
                2,
                9,
                3,
                4,
                1,
                0,
                5,
                3,
                2,
                1,
                7
            };
            Console.WriteLine();
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0} ", intArray[i]);
            }
            Console.WriteLine();
            int[] HelpingArray = new int[intArray.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                HelpingArray[i] = intArray[getMax(intArray,0)];
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[j] == HelpingArray[i])
                    {
                        intArray[j] = 0;
                        break;
                    }
                }
            }
            Console.WriteLine("Array sorted using mine method : ");
            Console.WriteLine();
            for (int i = 0; i < HelpingArray.Length; i++)
            {
                Console.Write("{0} ", HelpingArray[i]);
            }
        }
        static int getMax(int[] Array, int startIndex)
        {
            int max = 0;
            int indexOfMax = 0;
            for (int i = startIndex; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }
    }
}
