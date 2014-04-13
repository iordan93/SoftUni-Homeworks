using System;

class MagicDates
{
    static void Main()
    {
        int firstYear = int.Parse(Console.ReadLine());
        int secondYear = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(firstYear, 1, 1);
        DateTime endDate = new DateTime(secondYear, 12, 31);

        bool dateFound = false;
        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            string dateAsString = string.Format("{0}{1}{2}", currentDate.Day, currentDate.Month, currentDate.Year);
            int currentMagicNumber = 0;
            for (int i = 0; i < dateAsString.Length; i++)
            {
                for (int j = 0; j < dateAsString.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    currentMagicNumber += (dateAsString[i] - '0') * (dateAsString[j] - '0');
                }
            }

            if (currentMagicNumber / 2 == magicNumber)
            {
                dateFound = true;
                Console.WriteLine("{0}-{1}-{2}", currentDate.Day.ToString().PadLeft(2, '0'), currentDate.Month.ToString().PadLeft(2, '0'), currentDate.Year);
            }
        }

        if (!dateFound)
        {
            Console.WriteLine("No");
        }
    }
}