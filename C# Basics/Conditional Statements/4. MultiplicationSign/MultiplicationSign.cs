using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double third = double.Parse(Console.ReadLine());

        char sign = '\0';

        if (first == 0 || second == 0 || third == 0)
        {
            sign = '0';
        }
        else
        {
            if (first > 0)
            {
                if (second > 0)
                {
                    if (third > 0)
                    {
                        sign = '+';
                    }
                    else
                    {
                        sign = '-';
                    }
                }
                else
                {
                    if (third > 0)
                    {
                        sign = '-';
                    }
                    else
                    {
                        sign = '+';
                    }
                }
            }
            else
            {
                if (second > 0)
                {
                    if (third > 0)
                    {
                        sign = '-';
                    }
                    else
                    {
                        sign = '+';
                    }
                }
                else
                {
                    if (third > 0)
                    {
                        sign = '+';
                    }
                    else
                    {
                        sign = '-';
                    }
                }
            }
        }

        Console.WriteLine("The sign is {0}", sign);
    }
}