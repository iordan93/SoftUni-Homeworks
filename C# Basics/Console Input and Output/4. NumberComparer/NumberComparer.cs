using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", Math.Max(first, second));
    }
}