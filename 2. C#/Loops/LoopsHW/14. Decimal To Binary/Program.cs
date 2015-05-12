using System;
/*
 Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */

    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please give me an integer so i can give you its binary representation.");
            long GivenInteger = long.Parse(Console.ReadLine());
            string BinaryRepresentation = "";
            long result = GivenInteger;
            while (result > 0)
            {
                BinaryRepresentation += (result % 2).ToString();
                result = result / 2;
            }
            BinaryRepresentation = ReverseBinary(BinaryRepresentation);
            Console.WriteLine("Binary Representation of given string is ... {0}", BinaryRepresentation);

        }
        private static string ReverseBinary(string BinaryRepresentation)
        {
            var temporary = BinaryRepresentation.ToCharArray();
            Array.Reverse(temporary);
            return new String(temporary);
        }
    }

