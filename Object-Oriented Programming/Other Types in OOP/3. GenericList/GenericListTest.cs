using System;
public class GenericListTest
{
    public static void Main()
    {
        // Indexer test
        GenericList<int> list = new GenericList<int>();
        list.Add(0);
        list.Add(1);
        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);

        // Auto-grow test
        list = new GenericList<int>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }

        Console.WriteLine(list.Count == 10);
        Console.WriteLine(list.Capacity == 16);

        // Remove test
        list = new GenericList<int>();
        list.Add(1);
        list.Add(10);
        list.Add(100);
        list.Add(1000);
        list.Add(10000);
        list.Add(100000);
        list.Remove(3);
        Console.WriteLine(list);

        // InsertAt test
        list = new GenericList<int>();
        list.Add(1);
        list.Add(10);
        list.Add(100);
        list.Add(1000);
        list.Add(10000);
        list.Add(100000);
        list.InsertAt(100000000, 2);
        Console.WriteLine(list);

        // Clear test
        list = new GenericList<int>();
        list.Add(1);
        list.Add(10);
        list.Add(100);
        list.Add(1000);
        list.Add(10000);
        list.Add(100000);
        list.Clear();
        list.Add(1);
        Console.WriteLine(list.Count == 1);
        Console.WriteLine(list);

        // Find test
        list = new GenericList<int>();
        list.Add(1);
        list.Add(200);
        list.Add(-30);
        list.Add(324);
        list.Add(2345543);
        list.Add(5);
        int index = list.Find(-30);
        Console.WriteLine(index == 2);
        index = list.Find(0);
        Console.WriteLine(index < 0);

        // Min and Max test
        list = new GenericList<int>();
        list.Add(1);
        list.Add(10);
        list.Add(100);
        list.Add(1000);
        list.Add(10000);
        list.Add(100000);

        Console.WriteLine(list.Min() == 1);
        Console.WriteLine(list.Max() == 100000);

        // Version test
        object[] versionAttributes = typeof(GenericList<int>).GetCustomAttributes(false);
        Console.WriteLine("Version: {0}", versionAttributes[1]);
    }
}
