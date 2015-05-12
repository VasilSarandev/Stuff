using System;
/*
 * Write an if-statement that takes two double variables a and b and exchanges their values if
 * the first one is greater than the second one
 * As a result print the values a and b, separated by a space.
*/

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter Integer A .");
            int IntegerA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Integer B .");
            int IntegerB = int.Parse(Console.ReadLine());
            if (IntegerA > IntegerB)
            {
                int HelpingInteger = 0;
                HelpingInteger = IntegerA;
                IntegerA = IntegerB;
                IntegerB = HelpingInteger;
                
            }
            Console.WriteLine("{0} {1}", IntegerA, IntegerB);
        }
    }

