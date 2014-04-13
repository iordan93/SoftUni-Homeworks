using System;

class CalculateNFactorialOverKFactorial
{
    static void Main()
    {
        Console.Write("Enter n: ");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        ulong k = ulong.Parse(Console.ReadLine());
        ulong nFactorial = 1;
        ulong kFactorial = 1;
        if (n < 1 || n > 100)
        {
            Console.WriteLine("n must be between 1 and 100.");
            return;
        }
        if (k < 1 || k > n)
        {
            Console.WriteLine("k must be greater than 1 and smaller than n.");
            return;
        }

        for (ulong i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }

        for (ulong i = 1; i <= k; i++)
        {
            kFactorial *= i;
        }

        ulong result = nFactorial / kFactorial;
        Console.WriteLine("n! / k! = {0}", result);
    }
}