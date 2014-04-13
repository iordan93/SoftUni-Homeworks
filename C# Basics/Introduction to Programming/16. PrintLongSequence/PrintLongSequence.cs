using System;

class PrintLongSequence
{
    static void Main()
    {
        // I am using the same code like in the previous task but I have made the counter of the loop longer in order to print more numbers
        Console.WriteLine("The first 1000 members of the sequence 2, -3, 4, -5... are: ");
        int oddMember = 0;
        int evenMember = -1;

        string members = string.Empty;
        for (int i = 0; i < 500; i++)
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