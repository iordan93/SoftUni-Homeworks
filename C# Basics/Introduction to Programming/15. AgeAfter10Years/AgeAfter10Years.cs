using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birthday (example format: 18.11.1950): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int age = now.Year - birthday.Year;

        // If the birthday of the person has not passed yet, subtract one year
        if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
        {
            age--;
        }

        Console.WriteLine("Your age after 10 years: {0}", age + 10);
    }
}