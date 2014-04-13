using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter n numbers, each on a separate line:");

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        Console.WriteLine("The sorted numbers are:");
        Console.WriteLine(string.Join(Environment.NewLine, numbers));
    }
}