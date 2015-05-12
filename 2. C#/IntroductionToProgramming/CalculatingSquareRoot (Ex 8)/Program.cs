using System;
//Calculate the Square root of an integer. 


    class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Give me a number.");
            int GivenInteger = int.Parse(Console.ReadLine());
            if (GivenInteger > 0)
            {
                Console.WriteLine("The Square root of the number you've given me is {0}", Math.Sqrt(GivenInteger));

            }
            else
            {
                Console.WriteLine("Please restart and give me a positive integer.");
            }


        }
    }

