using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Nightmare_on_Code_Street
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            char[] InputSeparated = Input.ToCharArray();
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < InputSeparated.Length; i++)
            {
                if (Char.IsDigit(InputSeparated[i]) && i % 2 != 0)
                {
                    sum = sum + InputSeparated[i] - '0';
                    counter++;
                }
            }
            
            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
