using System;
using System.Text;

class PrintTheAsciiTable
{
    static void Main()
    {
        // Note that some charactes cannot be written to the console because they are control characters
        Console.OutputEncoding = Encoding.Unicode;
        for (int character = 0; character < 255; character++)
        {
            char symbol = (char)character;
            Console.WriteLine("{0} -> {1}", character, symbol);
        }
    }
}