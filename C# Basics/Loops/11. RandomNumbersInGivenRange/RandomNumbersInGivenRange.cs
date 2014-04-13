using System;

class RandomNumbersInGivenRange
{
    static Random random = new Random();

    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        if (max < min)
        {
            Console.WriteLine("The maximum number should be less than the minimum number.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(random.Next(min, max + 1) + " ");
        }

        Console.WriteLine();
    }
}