using System;
using System.Numerics;

class CalculateBinomialCoefficient
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k (k < n): ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFactorial = 1;

        if (k < 1 || k >= n || n > 100)
        {
            Console.WriteLine("You entered a wrong number. Follow this guideline: 1 < k < n < 100");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            if (i <= n - k)
            {
                nMinusKFactorial *= i;
            }
            nFactorial *= i;
        }

        for (int i = 1; i <= k; i++)
        {
            kFactorial *= i;
        }

        BigInteger result = nFactorial / (kFactorial * nMinusKFactorial);
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", result);
    }
}