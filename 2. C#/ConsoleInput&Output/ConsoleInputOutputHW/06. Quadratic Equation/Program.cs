using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads the coefficients a, b and c of a 
//quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Coefficient A is ... ? ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Coefficient B is ... ? ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Coefficient C is ... ? ");
            double c = double.Parse(Console.ReadLine());

            //To solve a quadratic equation we must first find the  D :D (Discriminant).
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("No real roots.");

            }
            else if (D == 0)
            {
                Console.WriteLine("Only one root.");
                double OnlyRoot = -b / (2 * a);
                Console.WriteLine("{0}", OnlyRoot);
            }
            else
            {
                Console.WriteLine("Two real roots.");
                {
                    double RootA = (-b - Math.Sqrt(D)) / ( 2 * a);
                    double RootB = (-b + Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("X1 is ... {0}", RootA);
                    Console.WriteLine("X2 is ... {0}", RootB);
                }
            }
        }
    }

