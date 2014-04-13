using System;

class QuotesInStrings
{
    static void Main()
    {
        string withBackslash = "The \"use\" of quotations causes difficulties.";
        string withQuotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(withBackslash);
        Console.WriteLine(withQuotedString);
    }
}
