using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Using_Classes_and_Objects
{
    class Program
    {
        static void Main()
        {
            string format = "d.M.yyyy";
            Console.WriteLine("Enter year.");
            string givenInput = Console.ReadLine();
            CheckYear(givenInput, format);
        }
        static void CheckYear(string givenInput, string format)
        {
            try
            {
                DateTime Year = DateTime.ParseExact(givenInput, format, CultureInfo.InvariantCulture);
                if (Year.Year % 4 == 0)
                {
                    Console.WriteLine("Leap year.");
                }
                else
                {
                    Console.WriteLine("Not a leap year.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date. please enter a new one : ex : 14.10.2014");
                Main();
            }
        }
            
    }
}
