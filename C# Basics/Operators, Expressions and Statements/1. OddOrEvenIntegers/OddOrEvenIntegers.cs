using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = number % 2 == 1;

        Console.WriteLine("The number {0} is {1}.", number, isOdd ? "odd" : "even");
    }
}
