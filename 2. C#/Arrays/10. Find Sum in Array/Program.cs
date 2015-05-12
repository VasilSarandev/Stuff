using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Find_Sum_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers of array separated by space.");
            string givenString = Console.ReadLine();
            string[] givenArray = givenString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] givenIntArray = new int[givenArray.Length];
            for (int i = 0; i < givenArray.Length; i++)
            {
                givenIntArray[i] = int.Parse(givenArray[i]);
            }
            Console.WriteLine("Now please enter the sum we are searching for ...");
            int desiredSum = int.Parse(Console.ReadLine());

            //got array. now functionality.

            int currentIndex = 0;
            string currSequence = "";
            string approvedSequence = "";
            int currSum = 0;
            
            for (int i = 0; i < givenIntArray.Length; i++)
            {
                for (int j = currentIndex; j < givenIntArray.Length; j++)
                {
                    currSum += givenIntArray[j];
                    currSequence += givenIntArray[j];
                    if (currSum == desiredSum)
                    {
                        approvedSequence = currSequence;
                    }
                    if (j == givenIntArray.Length - 1)
                    {
                        currentIndex++;
                        currSequence = "";
                        currSum = 0;
                        

                    }
                }
                
            }
            for (int i = 0; i < approvedSequence.Length; i++)
            {
                Console.Write("{0} ", approvedSequence[i]);
            }

        }
    }
}
