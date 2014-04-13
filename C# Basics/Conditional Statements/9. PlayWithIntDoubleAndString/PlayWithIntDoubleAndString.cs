using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.Write("1 --> int\r\n2 --> double\r\n3 --> string\r\n");
        byte n = byte.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int intNumber = int.Parse(Console.ReadLine());
                intNumber++;
                Console.WriteLine(intNumber);
                break;
            case 2:
                Console.Write("Please enter a real number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber++;
                Console.WriteLine(doubleNumber);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
                break;
            default:
                Console.WriteLine("You entered an invalid number.");
                break;
        }
    }
}