using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a positive binary number: ");
        string number = Console.ReadLine();

        long result = 0;
        for (int i = number.Length - 1, power = 1; i >= 0; i--, power *= 2)
        {
            result += (number[i] - '0') * power;
        }

        Console.WriteLine("{0} in decimal numeral system is {1}", number, result);
    }
}