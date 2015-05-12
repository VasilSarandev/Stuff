using System;
/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement
 */


    class IntDoubleOrSting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type : ");
            Console.WriteLine("1 ---->> integer");
            Console.WriteLine("2 ----->> string");
            Console.WriteLine("3 ----->> double");
            int GivenChoice = int.Parse(Console.ReadLine());
            switch (GivenChoice)
            {
                case 1: Console.WriteLine("Please enter a integer.");
                    int GivenInteger = int.Parse(Console.ReadLine());
                    GivenInteger += 1;
                    Console.WriteLine("Added 1 to integer. {0}", GivenInteger);
                    break;
                    
                case 2:
                    Console.WriteLine("Please enter a string.");
                    string GivenString = Console.ReadLine();
                    GivenString += "*";
                    Console.WriteLine("* appended to string. {0}", GivenString);
                    break;
                case 3:
                    Console.WriteLine("Please enter a number type double. (example 4,5)");
                    double GivenDouble = double.Parse(Console.ReadLine());
                    GivenDouble += 1;
                    Console.WriteLine("Added 1 to double. {0}", GivenDouble);
                    break;
                default: Console.WriteLine("Not a valid choice."); break;
            }
            
        }
    }

