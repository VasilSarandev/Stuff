using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads the radius r of a circle and prints its perimeter
//and area formatted with 2 digits after the decimal point.

    class CirclePerimeterAndArea
    {
        public const double PI = 3.14;
        static void Main()
        {
            Console.WriteLine("Reminder : If you are entering a integer like 3,5 for radius please enter it with COMA ( , ) not dot(.) Thank you");
            Console.WriteLine("Radius R of circle is .... ? ");
            double Radius = double.Parse(Console.ReadLine());
            double Perimeter = 2 * PI * Radius;
            double Area =  PI * (Radius * Radius);
            
            Console.WriteLine("The Perimeter of circle is ... {0} ", string.Format("{0:0.00}", Perimeter));
            Console.WriteLine("The Area of Circle is .... {0}", string.Format("{0:0.00}", Area));
             
        }
    }

