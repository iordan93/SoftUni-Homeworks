using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool divisibleBy5And7 = number % 5 == 0 && number % 7 == 0;

        Console.WriteLine("The number {0} {1} divisible by 5 and 7.", number, divisibleBy5And7 ? "is" : "is not");
    }
}