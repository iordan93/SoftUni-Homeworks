using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        string result = ConvertDecimalToBinary(number);
        Console.WriteLine("{0} in binary numeral system is {1}", number, result);
    }

    static string ConvertDecimalToBinary(long number)
    {
        string result = string.Empty;

        // If the number is greater than zero, divide by two and take the remnants in reverse order
        if (number >= 0)
        {
            while (number > 0)
            {
                result = number % 2 + result;
                number /= 2;
            }
        }
        // Else, the first bit is one, take the complement of the number and do the normal conversion.
        // Then take into account the first bit and ignore the leading zero
        else
        {
            result = ConvertDecimalToBinary(number + int.MinValue);
            result = "1" + result.Substring(1);
        }

        return result.PadLeft(1, '0');
    }
}
