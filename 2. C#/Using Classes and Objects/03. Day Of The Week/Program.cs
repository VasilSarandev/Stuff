using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Day_Of_The_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            

            Console.WriteLine("{0:dddd.M.yyyy}", now);
        }
    }
}
