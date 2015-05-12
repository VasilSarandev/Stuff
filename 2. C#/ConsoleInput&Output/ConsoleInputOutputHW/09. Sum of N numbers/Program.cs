using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters a number n and after that enters more n numbers and calculates
//and prints their sum. Note: You may need to use a for-loop.
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Hi. Please Enter N");
            int GivenInteger = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("You will now be asked to enter ... {0} more numbers. 0", GivenInteger);
            for (int i = 0; i < GivenInteger; i++)
            {
                Console.WriteLine("Please give me another Number");
                int newInteger = int.Parse(Console.ReadLine());
                sum += newInteger;
            }
            Console.WriteLine("The sum of the numbers you've just entered is ... {0} ", sum);
        }
    }

