using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string helloWorldAsString = (string)helloWorld;

        Console.WriteLine("Object: {0}\r\nString: {1}", helloWorld, helloWorldAsString);
    }
}