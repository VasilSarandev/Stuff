using System;
/*Problem 6. Strings and Objects

 *Declare two string variables and assign them with Hello and World.
 *Declare an object variable and assign it with the concatenation of the first
 * two variables (mind adding an interval between).
 *Declare a third string variable and initialize it with the value of the object
 * variable (you should perform type casting).
 * 
 * 
 * 
 * 
 * */



    class StringsAndObjects
    {
        static void Main()
        {
            string Hello = "Hello";
            string World = "World";
            object String2x = Hello + " " + World;
            string ObjToString = (string)(String2x);
            Console.WriteLine("First string value is ... : {0}", Hello);
            Console.WriteLine("Second string value is ... : {0}", World);
            Console.WriteLine("Object has value ... : {0}", String2x);
            Console.WriteLine("Object to string has value ... : {0}", ObjToString);
        }
    }

