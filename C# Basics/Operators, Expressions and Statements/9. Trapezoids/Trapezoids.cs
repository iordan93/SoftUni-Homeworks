using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter the trapezoid's longer base: ");
        double longBase = double.Parse(Console.ReadLine());
        Console.Write("Enter the trapezoid's shorter base: ");
        double shortBase = double.Parse(Console.ReadLine());
        Console.Write("Enter the trapezoid's height: ");
        double height = double.Parse(Console.ReadLine());
        double area = (longBase + shortBase) * height / 2;
        Console.WriteLine("The area of the trapezoid is {0} square units.", area);
    }
}