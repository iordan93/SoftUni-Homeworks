using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a positive decimal number: ");
        long number = long.Parse(Console.ReadLine());

        string result = ConvertDecimalToHexadecimal(number);

        Console.WriteLine("{0} in hexadecimal numeral system is 0x{1}", number, result);
    }

    static char GetSymbol(long i)
    {
        // We need to define a little more "numbers" - the letters A - F now play the part of numbers.
        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        return symbols[i];
    }

    static string ConvertDecimalToHexadecimal(long number)
    {
        string result = string.Empty;
        while (number != 0)
        {
            result = GetSymbol(number % 16) + result;
            number /= 16;
        }
        return result;
    }

}