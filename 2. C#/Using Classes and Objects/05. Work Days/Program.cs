using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Work_Days
{
    class Program
    {
        static List<DateTime> Holidays = new List<DateTime>();
        static void Main(string[] args)
        {
            Holidays = new List<DateTime>()
            {new DateTime(2014,3,1),new DateTime(2015,2,3),new DateTime(2013,5,6)};
            Console.WriteLine("hi. Please enter End date in format dd.mm.yyyy");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(CalcWorkDays(endDate));

        }
        static string CalcWorkDays(DateTime end)
        {
            int DaysCounter = 0;
            int holydays = 0;
            int weekend = 0;
            DateTime now = DateTime.Now;
            while (now < end)
            {
                if (Holidays.Contains(now))
                {
                    holydays++;
                }
                else if ((int)now.DayOfWeek==0 || (int)now.DayOfWeek==6)
                {
                    weekend++;

                }
                else
                {
                    DaysCounter++;
                }
               now= now.AddDays(1);
            }
            return String.Format("Workdays : {0}\nHolidays : {1}\nWeekends : {2}\n", DaysCounter, holydays, weekend);
        }
    }
}
