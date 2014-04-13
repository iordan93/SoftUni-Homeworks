using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Enter number i: ");
        int i = int.Parse(Console.ReadLine());
        int maskBase = 1;
        int mask = maskBase << 3;
        int iAndMask = i & mask;
        if (iAndMask != 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}