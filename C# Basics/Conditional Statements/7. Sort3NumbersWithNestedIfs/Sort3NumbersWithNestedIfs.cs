using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double third = double.Parse(Console.ReadLine());

        double biggestNumber;
        double middleNumber;
        double smallestNumber;
        if (first > second)
        {
            if (third > first)
            {
                biggestNumber = third;
                middleNumber = first;
                smallestNumber = second;
            }
            else
            {
                if (second > third)
                {
                    biggestNumber = first;
                    middleNumber = second;
                    smallestNumber = third;
                }
                else
                {
                    biggestNumber = first;
                    middleNumber = third;
                    smallestNumber = second;
                }
            }
        }
        else
        {
            if (third > second)
            {
                biggestNumber = third;
                middleNumber = second;
                smallestNumber = first;
            }
            else
            {
                if (first > third)
                {
                    biggestNumber = second;
                    middleNumber = first;
                    smallestNumber = third;
                }
                else
                {
                    biggestNumber = second;
                    middleNumber = third;
                    smallestNumber = first;
                }
            }
        }
        Console.WriteLine("Here are the sorted numbers: {0} {1} {2}", biggestNumber, middleNumber, smallestNumber);
    }
}
