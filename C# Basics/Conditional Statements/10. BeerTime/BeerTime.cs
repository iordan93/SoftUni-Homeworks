using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        CultureInfo usCulture = new CultureInfo("en-US");
        DateTime time;
        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 AM");
        string dateString = Console.ReadLine();

        // Kind of a hack - a booleand variable with three values
        // null -> invalid time, true -> beer time, false -> non-beer time
        bool? beerTime = null;

        if (DateTime.TryParseExact(dateString, "h:mm tt", usCulture,
                                    DateTimeStyles.None, out time))
        {
            // The following if-statement can also be written in a shorter way like this:
            // beerTime = time >= startBeerTime || time < endBeerTime;

            if (time >= startBeerTime || time < endBeerTime)
            {
                beerTime = true;
            }
            else
            {
                beerTime = false;
            }
        }

        Console.WriteLine(beerTime.HasValue ? (beerTime == true ? "beer time" : "non-beer time") : "invalid time");
    }
}