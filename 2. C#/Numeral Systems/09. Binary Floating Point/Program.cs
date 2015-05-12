using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace _09.Binary_Floating_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter a floating point number :)  ex. 5.45454331 25.25 53.532 etc ");
            float givenNumber = float.Parse(Console.ReadLine());
            string givenNumberr = givenNumber.ToString();
            string[] ExponentAndMantissa = givenNumberr.Split('.');
            int exponent = int.Parse(ExponentAndMantissa[1]);
            int mantissa = int.Parse(ExponentAndMantissa[0]);
            
            byte sign = 0;
            if (mantissa < 0)
            {
                sign = 1;
                mantissa = mantissa * -1;
            }
            string exponentt = exponent.ToString();
            string mantissaa = mantissa.ToString();
            string expBinary = Convert.ToString(Convert.ToInt32(exponentt, 10), 2).PadLeft(16, '0');
            string mantBinary = Convert.ToString(Convert.ToInt32(mantissaa, 10), 2).PadLeft(16, '0');
            Console.WriteLine("Sign is .... {0}", sign);
            Console.WriteLine("Exponent in binary Representation is ... {0}", expBinary);
            Console.WriteLine("Mantissa in binary Representation is ... {0}", mantBinary);

            
        }
    }
}
