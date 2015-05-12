using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.The_Horror
{
    class Program
    {
        static void Main(string[] args)
        {
            string GivenString = Console.ReadLine();
            char[] GivenStringSplit = GivenString.ToCharArray();
            int digitscount = 0;
            int sum = 0;
            for (int i = 0; i < GivenStringSplit.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (Char.IsDigit(GivenStringSplit[i]))
                    {
                        digitscount++;
                        sum += GivenStringSplit[i] - '0';
                    }
                }
            }
            Console.WriteLine("{0} {1}", digitscount, sum);
        }
    }
}
