using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter n: ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        decimal x = decimal.Parse(Console.ReadLine());
        decimal sum = 1;
        decimal nFactorial = 1;
        decimal xToTheN = 1;

        // Calculate N factorial and X^N
        for (decimal i = 1; i <= n; i++)
        {
            nFactorial *= i;
            xToTheN = (decimal)(Math.Pow((double)x, (double)i));
            sum += nFactorial / xToTheN;
        }

        Console.WriteLine("{0:F5}", sum);
    }
}