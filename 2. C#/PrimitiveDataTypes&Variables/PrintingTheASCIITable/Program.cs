using System;
using System.Text;



class PrintingTheASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine(symbol);
        }
    }
}
