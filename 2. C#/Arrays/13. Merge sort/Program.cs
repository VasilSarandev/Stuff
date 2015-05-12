using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sort an Array using the merge algorithm.
namespace _13.Merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements of integer Array separated by space. ");
            string givenString = Console.ReadLine();
            string[] givenStringSeparated = givenString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] givenIntArray = new int[givenStringSeparated.Length];
            for (int i = 0; i < givenStringSeparated.Length; i++)
            {
                givenIntArray[i] = int.Parse(givenStringSeparated[i]);
            }
            //got array. now merge.
            //create new array.
            int[] newSortedArray = new int[givenIntArray.Length];
            for (int i = 0; i < newSortedArray.Length; i++)
            {
                newSortedArray[i] = givenIntArray.Min();
                for (int j = 0; j < givenIntArray.Length; j++)
                {
                    if (givenIntArray[j] == givenIntArray.Min())
                    {
                        givenIntArray[j] = 321922222;
                        break;
                    }
                }
            }
            for (int i = 0; i < newSortedArray.Length; i++)
            {
                Console.Write("{0} ", newSortedArray[i]);
            }
        }
    }
}
