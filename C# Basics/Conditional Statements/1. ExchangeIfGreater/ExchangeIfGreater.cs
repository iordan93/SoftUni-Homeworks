using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());

        if (first > second)
        {
            Console.WriteLine("{0} {1}", second, first);
        }
        else
        {
            Console.WriteLine("{0} {1}", first, second);
        }
    }
}