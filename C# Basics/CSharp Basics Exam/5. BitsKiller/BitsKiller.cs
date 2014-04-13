using System;
using System.Text;

class BitsKiller
{
    static void Main()
    {
        int elementsLength = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        StringBuilder elements = new StringBuilder();
        for (int i = 0; i < elementsLength; i++)
        {
            elements.Append(Convert.ToString(byte.Parse(Console.ReadLine()), 2).PadLeft(8, '0'));
        }

        int length = elements.Length;
        for (int i = 1; i < length; i += step)
        {
            elements.Remove(i, 1).Insert(i, '*');
        }

        elements.Replace("*", "");
        while (elements.Length % 8 != 0)
        {
            elements.Append('0');
        }

        for (int i = 0; i <= elements.Length - 1; i += 8)
        {
            string current = elements.ToString().Substring(i, 8);
            Console.WriteLine(Convert.ToInt32(current, 2));
        }
    }
}
