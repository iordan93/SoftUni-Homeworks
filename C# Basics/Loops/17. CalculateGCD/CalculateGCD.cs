using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int second = int.Parse(Console.ReadLine());
        int gcd = 1;
        if (first > second)
        {
            int swap = first;
            first = second;
            second = swap;
        }

        while (second != 0)
        {
            gcd = first % second;
            first = second;
            if (gcd == 0)
            {
                gcd = second;
                second = 0;
            }
            else
            {
                second = gcd;
            }
        }

        Console.WriteLine("The greatest common divisor (GCD) is {0}", gcd);
    }
}