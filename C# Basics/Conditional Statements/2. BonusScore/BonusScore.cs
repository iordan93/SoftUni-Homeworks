using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter the score: ");
        int score = int.Parse(Console.ReadLine());
        if (score <= 0 || score > 9)
        {
            Console.WriteLine("Invalid score");
            return;
        }
        else if (score >= 1 && score <= 3)
        {
            score *= 10;
        }
        else if (score >= 4 && score <= 6)
        {
            score *= 100;
        }
        else if (score >= 7 && score <= 9)
        {
            score *= 1000;
        }

        Console.WriteLine("The new score is: {0}", score);
    }
}