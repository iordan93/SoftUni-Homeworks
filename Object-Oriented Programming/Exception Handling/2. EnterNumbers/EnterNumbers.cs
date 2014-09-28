using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int[] numbers = ReadTenNumbers(start, end);

        Console.WriteLine("The entered numbers are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine();
    }

    static int[] ReadTenNumbers(int start, int end)
    {
        int[] numbers = new int[10];
        for (int index = 0; index <= 9; index++)
        {
            bool exceptionThrown = false;
            try
            {
                numbers[index] = ReadANumber(start, end);
                start = numbers[index];
            }
            catch (ArgumentOutOfRangeException) 
            {
                Console.WriteLine("Please try again.");
                exceptionThrown = true;
            }

            if (exceptionThrown)
            {
                index--;
            }
        }

        return numbers;
    }

    static int ReadANumber(int start, int end)
    {
        int number = 0;
        if (start >= end)
        {
            throw new ArgumentException("The starting number must be smaller than the ending number.");
        }

        try
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if ((number < start) || (number > end))
            {
                // It is best to leave this exception unhandled in the current method
                throw new ArgumentOutOfRangeException("number", "The number is not in the specified range.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big or too small.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please enter a number.");
        }

        return number;
    }
}