using System;
/*Problem 9. Exchange Variable Values
 *
 * 
 * Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their
 * values by using some programming logic.
 * Print the variable values before and after the exchange.
 * 
 * 
 * 
 * 
 * */
    class ExchangingValues
    {
        static void Main()
        {
            byte a = 5;
            byte b = 10;
            Console.WriteLine("Variable A  has value : {0}", a);
            Console.WriteLine("Variable B  has value : {0}", b);
            Console.WriteLine("Exchanging...");
            byte c = 0;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Variable A now has value : {0}", a);
            Console.WriteLine("Variable B now has value : {0}", b);
            
        }
    }

