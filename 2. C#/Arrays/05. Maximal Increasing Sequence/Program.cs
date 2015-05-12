using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//write a program that finds the maximum increasing sequence in array.

namespace _05.Maximal_Increasing_Sequence
{
    class MaxIncreasingSeq
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please enter elements of array , separated by space.");
            string consoleInput = Console.ReadLine();

            string[] givenArray = consoleInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int currElementIndex = 0;
            string CurrentList = "";
            string BestList = "";
            int currLength = 0;
            int bestLength = 0;
            int counter = 0;
            

            //got the array. now implemenet functionality for task.
            for (int i = 1; i < givenArray.Length; i++)
            {
                if (int.Parse(givenArray[i]) > int.Parse(givenArray[currElementIndex]))
                {
                    if (counter == 0)
                    {
                        CurrentList += givenArray[currElementIndex];
                    }
                    currLength++;
                    currElementIndex = i;
                    CurrentList += givenArray[currElementIndex];
                    counter++;
                }
                else
                {
                    counter = 0;
                    currLength = 0;
                    currElementIndex++;
                    CurrentList = "";
                }
                if (CurrentList.Length > BestList.Length)
                {
                    BestList = CurrentList;
                }

            }
            for (int i = 0; i < BestList.Length; i++)
            {
                Console.Write("{0} ", BestList[i]);
            }

        }
    }
}
