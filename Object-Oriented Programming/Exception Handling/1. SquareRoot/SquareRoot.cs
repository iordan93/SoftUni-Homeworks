using System;

public class SquareRoot
{
    public static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Invalid number provided - it should be nonnegative.");
                return;
            }
            else 
            {
                Console.WriteLine(Math.Sqrt(number * 1.0));
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input provided - it should be an integer number.");
            return;
        }
        finally 
        {
            Console.WriteLine("Good bye!");
        }
    }
}
