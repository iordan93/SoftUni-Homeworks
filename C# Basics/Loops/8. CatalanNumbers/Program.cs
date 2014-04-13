using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        ulong n = ulong.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger nPlus1Factorial = 1;
        BigInteger factorialRemnant = 1;
        BigInteger twoNFactorial = 1;
        BigInteger result;
        
        // Calculate n!
        for (ulong i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        
        // Calculate (n+1)!
        nPlus1Factorial = nFactorial * (n + 1);
        
        // Calculate (2n)!
        checked
        {
            for (ulong i = n + 1; i <= 2 * n; i++)
            {
                factorialRemnant *= i;
                twoNFactorial = nFactorial * factorialRemnant;
            }

            result = twoNFactorial / (nFactorial * nPlus1Factorial);
        }

        Console.WriteLine("The number is: {0}", result);
    }
}