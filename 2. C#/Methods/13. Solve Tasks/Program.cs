using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Solve_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. I've got some functionality(methodiality haha... im so funny... i need friends) for solving tasks.");
            Console.WriteLine("What do you want me to show you ? ");
            Console.WriteLine("1. Reverse The Digits of Double or Integer type variable");
            Console.WriteLine("2. Calculate The AVG of a sequence of integers");
            Console.WriteLine("3. Calculate a linear expression");
            Console.WriteLine("Please enter 1, 2 or 3 or 6 if you want them all.");
            int givenInput = int.Parse(Console.ReadLine());
            if (givenInput == 1)
            {
                ReverseNumber();
            }
            else if (givenInput == 2)
            {
                CalculateAvg();
            }

            else if (givenInput == 3)
            {
                CalcLinearExpression();
            }
            else if (givenInput == 6)
            {
                ReverseNumber();
                CalculateAvg();
                CalcLinearExpression();
            }
            else
            {
                Console.WriteLine("Invalid Input. Please restart program.");
            }
        }
        static string ReverseNumber()
        {
            Console.WriteLine("Enter integer to reverse.");
            double Number = double.Parse(Console.ReadLine());
            bool isGreaterThanZero = false;
            if (Number >= 0)
            {
                isGreaterThanZero = true;
            }
            while (isGreaterThanZero == false)
            {
                Console.WriteLine("Enter another integer ( type double if you want ) that is not negative.");
                Number = double.Parse(Console.ReadLine());
                if (Number >= 0)
                {
                    isGreaterThanZero = true;
                }
            }
            string num = Number.ToString();
            char[] numz = num.ToCharArray();
            Array.Reverse(numz);
            string result = new string(numz);
            Console.WriteLine("Reversed ....{0} ", result);
            
                return result;
        }
        static void CalculateAvg()
        {
            int sum = 0;
            Console.WriteLine("Entere elements of array ,separated by space.");
            bool NotEmpty = false;
            string givenInput = Console.ReadLine();
            if (givenInput.Length > 0)
            {
                NotEmpty = true;
            }
            while (NotEmpty == false)
            {
                Console.WriteLine("Enter another sequence of elements , separated by space that does not contain 0 elements.");
                givenInput = Console.ReadLine();
                if (givenInput.Length > 0)
                {
                    NotEmpty = true;
                }
            }
            string[] givenInputArr = givenInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < givenInputArr.Length; i++)
            {
                sum  += int.Parse(givenInputArr[i]);
            }
            double Avg = sum / givenInputArr.Length;
            Console.WriteLine("Average is ... {0} ", Avg);
            
        }
        static void CalcLinearExpression()
        {
            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());
            bool aIsNotZero = false;
            if(a!=0)
            {
                aIsNotZero = true;
            }
            while (aIsNotZero == false)
            {
                Console.WriteLine("Enter another A that is not 0.");
                a = double.Parse(Console.ReadLine());
                if (a != 0)
                {
                    aIsNotZero = true;
                }
            }
            
            Console.WriteLine("Enter B");
            double B = double.Parse(Console.ReadLine());
            //a*x=-b => x=-b/a
            double X = -B / a;
            Console.WriteLine("X is ... {0}", X);
           
        }
    }
}
