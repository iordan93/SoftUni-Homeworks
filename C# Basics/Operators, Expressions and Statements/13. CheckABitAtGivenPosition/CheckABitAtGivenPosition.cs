using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position p: ");
        int position = int.Parse(Console.ReadLine());
        int maskBase = 1;
        int mask = maskBase << position;
        int iAndMask = number & mask;
        Console.WriteLine("The bit at position {0} of the number {1} is 1: {2}", position, number, iAndMask != 0);
    }
}
