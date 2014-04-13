using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter the number n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger fibonacci;

        if (n <= 0)
        {
            Console.WriteLine("The number n is invalid.");
        }
        else if (n == 1)
        {
            Console.WriteLine("0");
        }
        else if (n == 2)
        {
            Console.WriteLine("0 1");
        }
        else
        {
            Console.Write("0 1 ");
            for (int i = 1; i <= n - 2; i++)
            {
                fibonacci = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fibonacci;
                Console.Write(fibonacci + " ");
            }

            Console.WriteLine();
        }
    }
}
