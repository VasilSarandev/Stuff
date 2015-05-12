using System;


class SquareRoot
{
    static void Main()
    {
        try
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(input));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid number! {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}