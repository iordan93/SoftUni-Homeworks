using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

public class Computer : IComparable<Computer>
{
    private string name;
    private string details;
    private IEnumerable<Component> components;

    public Computer(string name, string details = null, params Component[] components)
    {
        this.Name = name;
        this.Details = details;
        this.Components = components;
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
                throw new ArgumentException("You must specify a name.");
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

    public IEnumerable<Component> Components
    {
        get
        {
            return this.components;
        }
        set
        {
            this.components = value;
        }
    }

    public decimal Price
    {
        get
        {
            decimal price = 0;
            foreach (var component in this.Components)
            {
                price += component.Price;
            }

            return price;
        }
    }

    public int CompareTo(Computer other) 
    {
        return this.Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        // Set the format of the currency to be Bulgarian
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        StringBuilder computer = new StringBuilder();
        computer.AppendLine("Name: " + this.Name);
        computer.AppendLine("Details: " + (!string.IsNullOrEmpty(this.Details) ? this.Details : "None"));
        if (this.Components != null) 
        {
            foreach (var component in this.Components)
            {
                computer.AppendLine(component.ToString());
            }
        }

        computer.AppendLine(string.Format("Price: {0:C}", this.Price));

        return computer.ToString();
    }
}
