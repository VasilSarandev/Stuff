using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
 */

namespace ArraysHW
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int[] Elements20Array = new int[20];
            Console.WriteLine("The Array now is ... ");
            for (int i = 0; i < 20; i++)
            {
                Elements20Array[i] = i * 5;
                Console.WriteLine(Elements20Array[i]);
                
            }
            
        }
    }
}
