using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        List<int> primes = FindPrimesInRange(firstNumber, secondNumber);
        Console.WriteLine("The primes in the range [{0}; {1}] are: {2}", firstNumber, secondNumber, string.Join(", ", primes));
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int number = startNum; number <= endNum; number++)
        {
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        return primes;
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