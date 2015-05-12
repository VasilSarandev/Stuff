using System;
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

class PrintingLongSequenceOfNumbers
{
    static void Main()
    {
        ushort Counter = 0;
        for (int i = 2; i < 1002; i++)
        {
            if (Counter % 2 == 0)
            {
                Console.Write(" " + i);
            }
            else
            {
                Console.Write(" " + -i);
            }
            Counter++;
        }
    }
}

