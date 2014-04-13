using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        string digit = Console.ReadLine();
        string digitRepresentation = string.Empty;

        switch (digit)
        {
            case "0":
                digitRepresentation = "zero";
                break;
            case "1":
                digitRepresentation = "one";
                break;
            case "2":
                digitRepresentation = "two";
                break;
            case "3": 
                digitRepresentation = "three";
                break;
            case "4": 
                digitRepresentation = "four";
                break;
            case "5": 
                digitRepresentation = "five";
                break;
            case "6": 
                digitRepresentation = "six";
                break;
            case "7":
                digitRepresentation = "seven";
                break;
            case "8": 
                digitRepresentation = "eight";
                break;
            case "9": 
                digitRepresentation = "nine";
                break;
            default:
                digitRepresentation = "not a digit";
                break;
        }

        Console.WriteLine(digitRepresentation);
    }
}