using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 2. Print Company Information

 *A company has name, address, phone number, fax number, web site and manager. 
 *The manager has first name, last name, age and a phone number.
 *Write a program that reads the information about a company and its manager and prints it back on the console.
*/
    class CompanyInformation
    {



    
        static void Main()
        {
            Console.WriteLine("Enter Company name.");
            string CompName = Console.ReadLine();
            Console.WriteLine("Enter Company address.");
            string CompAddress = Console.ReadLine();
            Console.WriteLine("Enter Company Phone Number.");
            string CompNumber = Console.ReadLine();
            Console.WriteLine("Enter Company Fax Number.");
            string CompFax = Console.ReadLine();
            Console.WriteLine("Enter Company Web Site.");
            string CompWebSite = Console.ReadLine();

            //Manager

            Console.WriteLine("Manager's first name?");
            string ManagerFName = Console.ReadLine();
            Console.WriteLine("Manager's last name?");
            string ManagerLName = Console.ReadLine();
            string ManagerFullName = ManagerFName + " " + ManagerLName;
            Console.WriteLine("Manager's age?");
            string ManagerAge = Console.ReadLine();
            Console.WriteLine("Manager's Phone Number?");
            string ManagerPhNumber = Console.ReadLine();

            Console.WriteLine("Thank you for validating information. Printing Back....");
            Console.WriteLine("Company's name is ... {0}", CompName);
            Console.WriteLine("Company's address is ... {0}", CompAddress);
            Console.WriteLine("Company's phone number is ... {0}", CompNumber);
            Console.WriteLine("Company's FAX  is ... {0}", CompFax);
            Console.WriteLine("Company's Website  is ... {0}", CompWebSite);
            //Manager

            Console.WriteLine("Manager's name is .... {0}", ManagerFullName);
            Console.WriteLine("Manager's age is ..... {0}", ManagerAge);
            Console.WriteLine("Manager's phone number is .... {0}", ManagerPhNumber);
            Console.WriteLine("That's it. Bye bye :)");
            
        }


 }
    

