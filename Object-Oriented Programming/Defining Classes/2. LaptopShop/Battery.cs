using System;
public class Battery
{
    private string type;
    private double life;

    public Battery(string type, double life)
    {
        this.Type = type;
        this.Life = life;
    }

    // If there is no special logic in the properties, like here, we can use public string Type { get; set; } for simplicity
    public string Type
    {
        get
        {
            return this.type;
        }
        set 
        {
            this.type = value;
        }
    }

    public double Life
    {
        get
        {
            return this.life;
        }
        set
        {
            this.life = value;
        }
    }

    public override string ToString()
    {
        return this.Type + ", " + this.Life + " hours";
    }
}