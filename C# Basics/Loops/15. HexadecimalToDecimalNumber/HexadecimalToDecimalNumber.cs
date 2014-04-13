using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a positive hexadecimal number: ");
        string number = Console.ReadLine();

        long result = 0;
        for (int i = number.Length - 1, power = 1; i >= 0; i--, power *= 16)
        {
            result += GetNumber(number[i]) * power;
        }

        Console.WriteLine("{0} in decimal numeral system is {1}", number, result);
    }

    static int GetNumber(char s)
    {
        // Get the current number from an array. We need this because the letters A - F act as numbers
        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i] == s)
            {
                return i;
            }
        }

        return -1;
    }
}