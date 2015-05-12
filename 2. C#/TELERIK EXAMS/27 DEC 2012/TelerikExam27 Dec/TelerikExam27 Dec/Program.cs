using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikExam27_Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            int Date = int.Parse(Console.ReadLine());
            int Month = int.Parse(Console.ReadLine());
            int Year = int.Parse(Console.ReadLine());
            int newDate = 0;
            int newMonth = 0;
            int newYear = 0;
            
            if (Date == 31 && Month == 1)
            {
                newDate = 1;
                newMonth = 2;
                newYear = Year;
            }
            else if (Date == 28 && Month == 2 && Year % 4 != 0)
            {
                newDate = 1;
                newMonth = 3;
                newYear = Year;
            }
            else if (Date == 29 && Month == 2 && Year % 4 == 0)
            {
                newDate = 1;
                newMonth = 3;
                newYear = Year;
            }
            else if (Date == 31 && Month == 3)
            {
                newDate = 1;
                newMonth = 4;
                newYear = Year;
            }
            else  if (Date == 30 && Month == 4)
            {
                newDate = 1;
                newMonth = 5;
                newYear = Year;
            }
            else if (Date == 31 && Month == 5)
            {
                newDate = 1;
                newMonth = 6;
                newYear = Year;
            }
            else if (Date == 30 && Month == 6)
            {
                newDate = 1;
                newMonth = 7;
                newYear = Year;
            }
            else if (Date == 31 && Month == 7)
            {
                newDate = 1;
                newMonth = 8;
                newYear = Year;

            }
            else  if (Date == 31 && Month == 8)
            {
                newDate = 1;
                newMonth = 9;
                newYear = Year;
            }
            else  if (Date == 30 && Month == 9)
            {
                newDate = 1;
                newMonth = 10;
                newYear = Year;
            }
            else if (Date == 31 && Month == 10)
            {
                newDate = 1;
                newMonth = 11;
                newYear = Year;
            }
            else if (Date == 30 && Month == 11)
            {
                newDate = 1;
                newMonth = 12;
                newYear = Year;
            }
            else if (Date == 31 && Month == 12)
            {
                newDate = 1;
                newMonth = 1;
                newYear = Year + 1;
            }
            else
            {
                newDate = Date + 1;
                newMonth = Month;
                newYear = Year;
            }
            Console.WriteLine("{0}.{1}.{2}", newDate, newMonth, newYear);
        }
    }
}
