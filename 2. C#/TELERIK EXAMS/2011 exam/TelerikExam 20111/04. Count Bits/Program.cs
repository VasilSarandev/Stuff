using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string Binary = "";
            int BitToCheckFor = int.Parse(Console.ReadLine());
            long N = long.Parse(Console.ReadLine());
            long GivenInteger = 0;
            int counter = 0;
            if (BitToCheckFor == 0)
            {
                for (int i = 0; i < N; i++)
                {
                    GivenInteger = long.Parse(Console.ReadLine());
                    for (int j = 0; j < Convert.ToString(GivenInteger, 2).Length; j++)
                    {
                        if ((GivenInteger & (1 << j)) == 0)
                        {
                            counter++;

                        }

                    }
                    Console.WriteLine(counter);
                    counter = 0;

                }
            }
            
            if (BitToCheckFor == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    GivenInteger = long.Parse(Console.ReadLine());
                    for (int j = 0; j < Convert.ToString(GivenInteger,2).Length; j++)
                    {
                        if ((GivenInteger & (1 << j)) != 0)
                        {
                            counter++;

                        }
                        
                    }
                    Console.WriteLine(counter);
                    counter = 0;

                }
            }


        }
    }
}