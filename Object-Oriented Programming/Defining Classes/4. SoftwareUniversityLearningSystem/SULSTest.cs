using System;
using System.Collections.Generic;
using System.Linq;

public class SULSTest
{
    public static void Main()
    {
        // It is best if some of the classes were abstract (like Person, Student, CurrentStudent and Trainer)
        // so we can't instantiate them
        List<Person> people = new List<Person>() 
        {
            new Person("John", "Doe", 20),
            new Trainer("Trainer", "One", 28),
            new JuniorTrainer("Junior", "Trainer", 20),
            new SeniorTrainer("Senior", "Trainer", 20),
            new Student("Student", "One", 25, 12345, 4.56),
            new GraduateStudent("Student", "Two", 26, 456789, 3.6),
            new CurrentStudent("Current Student", "One", 28, 415263, 4.81),
            new CurrentStudent("Current Student", "Two", 20, 458945, 3.38),
            new CurrentStudent("Current Student", "Three", 30, 789430, 5.68),
            new CurrentStudent("Current Student", "Four", 32, 459423, 5.99),
            new CurrentStudent("Current Student", "Five", 12, 487658, 2.12),
            new OnlineStudent("Student", "Three", 28, 197562, 5.12),
            new OnsiteStudent("Student", "Four", 23, 456186, 5.79, 40),
            new DropoutStudent("Student", "Five", 36, 123410, 3.55, "The courses are too hard.")
        };

        Console.WriteLine(string.Join(Environment.NewLine, people
            .Where(p => p is CurrentStudent)
            .Cast<CurrentStudent>()
            .OrderBy(s => s.AverageGrade)));
    }
}
