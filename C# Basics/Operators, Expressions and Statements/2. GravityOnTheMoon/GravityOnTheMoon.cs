using System;

class GravityOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter your weight on Earth: ");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Your weight on the moon is {0}.", weight * 0.17);
    }
}