using System;
using System.Text;
public class Component
{
    private string name;
    private string details;
    private decimal price;

    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }

    public Component(string name, decimal price)
        : this(name, null, price)
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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The name must be specified.");
            }

            this.name = value;
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            this.details = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The price must be positive.");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder component = new StringBuilder();
        component.AppendLine("== Component ==");
        component.AppendLine("\tName: " + this.Name);
        component.AppendLine("\tDetails: " + (!string.IsNullOrEmpty(this.Details) ? this.Details : "None"));
        component.Append("\tPrice: " + this.Price);

        return component.ToString();
    }
}