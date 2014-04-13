using System;

class NumberAsWords
{
    static void Main()
    {
        string[] simpleNumbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", 
                             "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
                             "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number / 100;
        int secondDigit = number / 10;
        int hundreds = (number % 100) / 10;
        int remnantBy100 = number % 100;
        int thirdDigit = number % 10;

        Console.Write("The number is: ");
        if (number >= 0 && number < 20)
        {
            Console.WriteLine(simpleNumbers[number]);
        }
        else if (number >= 20 && number < 100)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine(tens[secondDigit - 2]);
            }
            else
            {
                Console.WriteLine(tens[secondDigit - 2] + "-" + simpleNumbers[thirdDigit]);
            }
        }
        else if (number >= 100 && number < 1000)
        {
            if (remnantBy100 == 0)
            {
                Console.WriteLine(simpleNumbers[firstDigit] + " hundred");
            }
            else if (remnantBy100 > 0 && remnantBy100 < 20)
            {
                Console.WriteLine(simpleNumbers[firstDigit] + " hundred " + "and " + simpleNumbers[remnantBy100]);
            }
            else if (thirdDigit == 0)
            {
                Console.WriteLine(simpleNumbers[firstDigit] + " hundred " + tens[hundreds - 2]);
            }
            else
            {
                Console.WriteLine(simpleNumbers[firstDigit] + " hundred " + tens[hundreds - 2] + "-" + simpleNumbers[thirdDigit]);
            }
        }
    }
}