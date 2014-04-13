using System;

class ExtractBitFromInteger
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
        int bit = iAndMask != 0 ? 1 : 0;
        Console.WriteLine("The bit at position {0} of the number {1} is {2}", position, number, bit);
    }
}
