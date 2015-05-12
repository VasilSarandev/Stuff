using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_by_String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the elements of array of strings , separated by space.");
            string givenInput = Console.ReadLine();
            string[] givenArray = givenInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> givenList = givenArray.OfType<string>().ToList();
            int curLength = 0;
            int bestLength = 0;
            List<string> sortedList = new List<string>();
            for (int i = 0; i <= givenList.Count; i++)
            {
                for (int j = 0; j < givenList.Count; j++)
                {
                    curLength = givenList[j].Length;
                    if (curLength > bestLength)
                    {
                        bestLength = curLength;
                    }
                }
                for (int j = 0; j < givenList.Count; j++)
                {
                    if (givenList[j].Length == bestLength)
                    {
                        sortedList.Add(givenList[j]);
                        givenList.Remove(givenList[j]);
                        bestLength = 0;
                    }
                }
            }
            sortedList.AddRange(givenList);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
