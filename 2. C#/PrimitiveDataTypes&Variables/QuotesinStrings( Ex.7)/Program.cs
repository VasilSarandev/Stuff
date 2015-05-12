using System;
/*
 * Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
 * Do the above in two different ways - with and without using quoted strings.
 * Print the variables to ensure that their value was correctly defined.
 * 
 * 
 * 
 * */


class EscapingQuotations
    {
        static void Main()
        {
            string Quoted = @"The ""use"" of quotations causes difficulties";
            string Escaped = "The \"use\" of quotations causes difficulties";
            Console.WriteLine("Escaped String has value ... {0}", Escaped);
            Console.WriteLine("Quoted String has value ... {0}", Quoted);
        }
    }

