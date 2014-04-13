using System;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(number));
    }

    static bool IsPrime(int number)
    {
        if (number == 0 || number == 1)
        {
            return false;
        }
        else if (number == 2)
        {
            return true;
        }

        for (int i = 2; i <= Math.Floor(Math.Sqrt(number)); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}