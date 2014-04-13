using System;

class CurrentDateAndTime
{
    static void Main()
    {
        // The formatting string "dd.MM.yyyy HH:mm:ss" formats the date like this: 25.07.2002 18:32:07
        Console.WriteLine("The current date and time is: {0}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
    }
}
