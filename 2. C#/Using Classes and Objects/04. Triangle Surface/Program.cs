using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace _04.Triangle_Surface
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Choose which method you want to use.");
            Console.WriteLine("1.Side and altitute to it.");
            Console.WriteLine("2.Three sides.");
            Console.WriteLine("3.Two sides and an angle between them.");
            int givenInput = int.Parse(Console.ReadLine());
            if (givenInput == 1)
            {
                Console.WriteLine("Enter side A. ex:5.0m 4.5m etc");
                decimal sideA = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter height to it . ex 3.0m");
                decimal heightA = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Area is ... {0}", GetArea1(sideA, heightA));
            }
            else if (givenInput == 2)
            {
                Console.WriteLine("Enter side A. ex:5.0m 4.5m etc");
                decimal sideA = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B. ex:5.0m 4.5m etc");
                decimal sideB = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter side C. ex:5.0m 4.5m etc");
                decimal sideC = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Area is ... {0}", GetArea2(sideA, sideB, sideC));
            }
            else
            {
                Console.WriteLine("Enter side A. ex:5.0m 4.5m etc");
                decimal sideA = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B. ex:5.0m 4.5m etc");
                decimal sideB = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Angle AB is ... ? ex:30.0m 25.5m etc");
                decimal angleAB = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Area is ... {0}", GetArea3(sideA, sideB, angleAB));
            }
        }
        
        static decimal GetArea1(decimal sideA, decimal heightA)
        {
            return (sideA * heightA) / 2.0m;
        }
        static decimal GetArea2(decimal sideA, decimal sideB, decimal sideC)
        {
            decimal p = (sideA + sideB + sideC) / 2;
            return (decimal)Math.Sqrt((double)(p * (p - sideA) * (p - sideB) * (p - sideC)));

        }
        static decimal GetArea3(decimal sideA, decimal sideB, decimal angleAB)
        {
            angleAB = angleAB * (decimal)Math.PI / 180.0m;
            return ((decimal)Math.Sin((double)angleAB) * sideA * sideB) / 2.0m;
        }
        
    }
}
