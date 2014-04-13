using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchanging:");
        Console.WriteLine("First value: " + a);
        Console.WriteLine("Second value: " + b);

        int tempValue = b;
        b = a;
        a = tempValue;
        Console.WriteLine("After exchanging:");
        Console.WriteLine("First value: " + a);
        Console.WriteLine("Second value: " + b);
    }
}