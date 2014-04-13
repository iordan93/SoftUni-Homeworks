using System;

class RandomizeTheNumbersFrom1ToN
{
    static Random random = new Random();

    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        // Fisher-Yates shuffle algorithm
        for (int i = array.Length; i > 1; i--)
        {
            int j = random.Next(i);

            int swap = array[j];
            array[j] = array[i - 1];
            array[i - 1] = swap;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}
