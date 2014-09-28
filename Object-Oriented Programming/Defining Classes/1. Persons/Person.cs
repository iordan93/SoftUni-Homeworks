using System;
using System.Text;
public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
        : this(name, age, null)
    {
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The name must be specified.");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("The age must be between 1 and 100.");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
            {
                throw new ArgumentException("The email must contain a \"@\", or be empty.");
            }

            this.email = value;
        }
    }

    public override string ToString()
    {
        StringBuilder person = new StringBuilder();
        person.AppendLine("Name: " + this.Name);
        person.AppendLine("Age: " + this.Age);
        person.AppendLine("Email: " + (string.IsNullOrEmpty(this.Email) ? this.Email : "None"));
        return person.ToString();
    }
}