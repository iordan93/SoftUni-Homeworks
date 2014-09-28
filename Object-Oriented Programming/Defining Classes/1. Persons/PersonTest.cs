using System;

public class PersonTest
{
    public static void Main()
    {
        Person john = new Person("John", 20, "john@example.com");
        Person bob = new Person("Bob", 25);

        Console.WriteLine(john);
        Console.WriteLine(bob);

        // These are invalid
        //Person wrongAge = new Person("Wrong", -10);
        //Person anotherWrongAge = new Person("Wrong", 105);
        //Person wrongEmail = new Person("Wrong", 28, "wrongemail.com");
    }
}