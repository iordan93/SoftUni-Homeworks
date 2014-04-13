using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int hundredsDigit = (number % 1000) / 100;
        
        if (hundredsDigit == 7)
        {
            Console.WriteLine("The third digit from right to left is 7.");
        }
        else
        {
            Console.WriteLine("The third digit from right to left is not 7.");
        }
    }
}
