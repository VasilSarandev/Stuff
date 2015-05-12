using System;
/*A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit card
 * numbers associated with the account. Declare the variables needed to keep the information for a 
 * single bank account using the appropriate data types and descriptive names.

 * 
 * */
class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Holder's first name is : ?");
        string Fname = Console.ReadLine();
        Console.WriteLine("Holder's middle name is : ?");
        string MName = Console.ReadLine();
        Console.WriteLine("Holder's last name is : ?");
        string LName = Console.ReadLine();
        Console.WriteLine("Holder's Balance is : ?");
        int Balance = int.Parse(Console.ReadLine());
        Console.WriteLine("Holder's Bank Name is : ?");
        string BankName = Console.ReadLine();
        Console.WriteLine("Holder's IBAN is : ? ");
        ulong IBAN = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Holder's BIC is : ? ");
        ulong BIC = ulong.Parse(Console.ReadLine());
        Console.WriteLine("The 3 Credit Card Numbers associated with the account are : ?");
        byte CCN = byte.Parse(Console.ReadLine());
        Console.WriteLine("Thank you for validating information. Processing ....");
        string fullName = Fname + " " + MName + " " + LName;

        Console.WriteLine("Holder's Fullname is {0}, \n Holder's Balance is {1}, \n Holder's Bank Name is {2}, \n Holder's IBAN is {3}, \n Holder's BIC is {4}, \n Holder's CCN are {5}", fullName, Balance, BankName, IBAN, BIC, CCN);
        Console.WriteLine("Thank you for using our services.");
    }
}
