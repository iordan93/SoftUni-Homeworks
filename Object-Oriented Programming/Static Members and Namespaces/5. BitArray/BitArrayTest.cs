using System;

public class BitArrayTest
{
    public static void Main()
    {
        BitArray bitArray = new BitArray(33);
        // Tests with some border cases
        bitArray[0] = 1;
        bitArray[7] = 1;
        bitArray[8] = 1;
        bitArray[31] = 1;
        bitArray[32] = 1;

        bitArray[10] = 1;
        bitArray[10] = 0;
        
        // Printing all numbers - testing the getter and enumerator
        foreach (var bit in bitArray)
        {
            Console.Write(bit + " ");
        }

        Console.WriteLine();

    }
}
