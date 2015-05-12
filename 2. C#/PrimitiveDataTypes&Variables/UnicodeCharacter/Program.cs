using System;
/* Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal)
 * using the \u00XX syntax, and then print it.
 * Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. 
 * The output should be *.
 * 
 * 
 * 
 * */

    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            char GivenCharacter = '\u002A';
            //42(10)=2A(16)
            Console.WriteLine("The Character {0} has Unicode {1}", GivenCharacter, (int)GivenCharacter);

        }
    }

