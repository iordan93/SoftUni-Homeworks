using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }

    static int Fib(int n)
    {
        int firstNumber = 1;
        int secondNumber = 1;
        int currentNumber = 0;
        if (n == 0)
        {
            return firstNumber;
        }
        else if (n == 1)
        {
            return secondNumber;
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                currentNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = currentNumber;
            }

            return currentNumber;
        }
    }
}