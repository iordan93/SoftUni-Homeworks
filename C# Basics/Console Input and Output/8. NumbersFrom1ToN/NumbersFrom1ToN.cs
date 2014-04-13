using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter the maximal number n: ");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}