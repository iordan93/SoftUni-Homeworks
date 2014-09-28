using System;
public class HTMLDispatcherTest
{
    public static void Main()
    {
        // I have created an additional constructor parameter to be able to use self-closing tags such as <img /> or <input />
        ElementBuilder div = new ElementBuilder("div");
        div.AddAttribute("id", "page");
        div.AddAttribute("class", "big");
        div.AddContent("<p>Hello</p>");
        Console.WriteLine(div * 2);

        Console.WriteLine();
        Console.WriteLine(HTMLDispatcher.CreateImage("http://example.com/image.jpg", "Alternate text", "Title"));
        Console.WriteLine(HTMLDispatcher.CreateURL("http://example.com", "Title", "Click here"));
        Console.WriteLine(HTMLDispatcher.CreateInput("text", "username", ""));
    }
}