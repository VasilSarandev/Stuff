using System;
using System.Text;
/* Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
 * Note: The © symbol may be displayed incorrectly at the console so you may need to change
 * the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

 * Note: Under old versions of Windows the © symbol may still be displayed incorrectly,
 * regardless of how much effort you put to fix it.
 * 
 * 
 * 
 * 
 * 
 * */

class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            char CopyRight = '\u00A9';
            Console.WriteLine("   {0}", CopyRight); //3
            Console.WriteLine("");
            Console.WriteLine("  {0} {0}", CopyRight); //2
            Console.WriteLine("");
            Console.WriteLine(" {0}   {0}", CopyRight); //1
            Console.WriteLine("{0} {0} {0} {0}", CopyRight); //0
            
        }
    }

