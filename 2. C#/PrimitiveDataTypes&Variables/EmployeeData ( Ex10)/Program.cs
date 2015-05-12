using System;
/*A marketing firm wants to keep record of its employees. 
 * Each record would have the following characteristics – first name, family name, 
 * age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
 * Declare the variables needed to keep the information for a single employee using 
 * appropriate data types and descriptive names.

*/
class FirmData
{
    static void Main()
    {
        Console.WriteLine("First Name is : ?");
        string Fname = Console.ReadLine();
        Console.WriteLine("Last Name is : ?");
        string Lname = Console.ReadLine();
        Console.WriteLine("Age is : ?");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Gender (M or F) ?");
        char gender = Char.Parse(Console.ReadLine());
        Console.WriteLine("ID Number is : ?");
        ulong idnum = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Unique Employee Number is : ?");
        ulong UniqueNum = ulong.Parse(Console.ReadLine());
        string fullName = Fname + " " + Lname;
        Console.WriteLine("Thank you for validating the information. \n");
        Console.WriteLine("Employee's full name is {0}, \n Employee's age is {1}, \n Employee's Gender is {2}, \n Employee's ID is {3}, \n Employee's uniq number is {4}",
            fullName, age, gender, idnum, UniqueNum);
    }
}

