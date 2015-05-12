using System;
using System.Globalization;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in format : hh:mm: tt ");
            Console.WriteLine("Example : 3:00 AM");
            string GivenTime = Console.ReadLine();
            try
            {
                DateTime datetime = DateTime.ParseExact(GivenTime, "h:mm tt", CultureInfo.InvariantCulture);
                TimeSpan time = datetime.TimeOfDay;
                TimeSpan DimensionA = new TimeSpan(13, 0, 0);
                TimeSpan DimensionB = new TimeSpan(03, 0, 0);

                if ((time >= DimensionA) || (time < DimensionB))
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Inalid input.");
            }
        }
    }

