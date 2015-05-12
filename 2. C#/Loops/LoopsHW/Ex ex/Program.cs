using System;

class RandomizeNumbersInRange
{
    static void Main()
    {
        Console.Write("range: ");
        int range = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        int[] numbers = new int[range];

        for (int i = 1; i <= range; i++)
        {
            numbers[i - 1] = i;
        }

        for (int i = 0; i < range; i++)
        {
            int index1 = rnd.Next(0, range - 1);
            int index2 = rnd.Next(0, range - 1);

            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
