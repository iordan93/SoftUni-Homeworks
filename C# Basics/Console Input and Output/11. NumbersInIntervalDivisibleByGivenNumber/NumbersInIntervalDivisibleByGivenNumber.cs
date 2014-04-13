using System;

class NumbersInIntervalDivisibleByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the start of the interval: ");
        ulong start = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end of the interval: ");
        ulong end = uint.Parse(Console.ReadLine());
        if (end < start)
        {
            Console.WriteLine("The interval is invalid. The end number must not be less than the start number.");
        }
        else
        {
            int numbersCount = 0;
            for (ulong i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    numbersCount++;
                }
            }

            Console.WriteLine("There are {0} numbers in the interval [{1}; {2}] divisible by 5.", numbersCount, start, end);
        }
    }
}