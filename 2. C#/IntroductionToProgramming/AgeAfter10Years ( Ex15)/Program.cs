using System;
//Calculate your age after 10 years (by being read from the console.)

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("How old are you :) ? ");
            int UserAge = int.Parse(Console.ReadLine());
            Console.WriteLine("In 10 years you'll be {0} years old.", UserAge + 10);
        }
    }

