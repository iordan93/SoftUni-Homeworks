using System;
using System.Text;

public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;
    private decimal price;

    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen, Battery battery, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.Price = price;
    }

    public Laptop(string model, decimal price)
        : this(model, null, null, 0, null, null, null, null, price)
    {
    }

    #region Properties
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The model must be specified.");
            }

            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.processor = value;
        }
    }

    public int RAM
    {
        get
        {
            return this.ram;
        }
        set
        {
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = value;
        }
    }

    public string HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            this.screen = value;
        }
    }

    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
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
    #endregion

    public override string ToString()
    {
        StringBuilder laptop = new StringBuilder();
        laptop.AppendLine("Model: " + this.Model);
        laptop.AppendLine("price: " + this.Price + " lv.");
        if (this.Manufacturer != null)
        {
            laptop.AppendLine("Manufacturer: " + this.Manufacturer);
        }

        if (this.Processor != null)
        {
            laptop.AppendLine("Processor: " + this.Processor);
        }

        if (this.RAM != 0)
        {
            laptop.AppendLine("RAM: " + this.RAM + " GB");
        }

        if (this.GraphicsCard != null)
        {
            laptop.AppendLine("Graphics card: " + this.GraphicsCard);
        }

        if (this.HDD != null)
        {
            laptop.AppendLine("HDD: " + this.HDD);
        }
        
        if (this.Screen != null)
        {
            laptop.AppendLine("Screen: " + this.Screen);
        }
        
        if (this.Battery != null)
        {
            laptop.AppendLine("Battery: " + this.Battery);
        }

        return laptop.ToString();
    }
}