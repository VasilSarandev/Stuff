using System;
/* Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
 * 
 * 
 * 
 * */

    class NullableIntegers
    {
        static void Main()
        {
            int? SomeInteger = null;
            double? SomeDouble = null;
            Console.WriteLine("Nullable integer has value ... : {0}", SomeInteger);
            Console.WriteLine("Nullable double has value ... : {0}", SomeDouble);
            Console.WriteLine("Nullable integer + 23 has value ... {0}", SomeInteger + 23);
            Console.WriteLine("Nullable double + 2.3 has value .... {0}", SomeDouble + 2.3);
            
        }
    }

