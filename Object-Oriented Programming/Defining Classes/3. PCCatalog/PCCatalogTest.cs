using System;
using System.Collections.Generic;
public class PCCatalogTest
{
    public static void Main()
    {
        var computers = new List<Computer>
        {
            new Computer("Asus", "Asus details", new Component("CPU", 250), new Component("RAM", 40), new Component("Motherboard", 50.99M)),
            new Computer("Asus", "Asus details", new Component("CPU", 250)),
            new Computer("Asus", "Asus details")
        };

        computers.Sort();

        Console.WriteLine(string.Join(Environment.NewLine, computers));
    }
}
