using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("The first ten members of the sequence 2, -3, 4, -5... are: ");
        int oddMember = 0;
        int evenMember = -1;

        string members = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            oddMember += 2;
            members += oddMember + ", ";
            evenMember -= 2;
            members += evenMember + ", ";
        }

        members = members.Substring(0, members.Length - 2);
        Console.WriteLine(members);
    }
}
