using System;

public struct Fraction
{
    private long numerator;
    private long denominator;

    public Fraction(long numerator, long denominator) : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public long Numerator
    {
        get
        {
            return this.numerator;
        }

        private set
        {
            this.numerator = value;
        }
    }

    public long Denominator
    {
        get
        {
            return this.denominator;
        }

        private set
        {
            if (value == 0)
            {
                throw new ArgumentException("The denominator cannot be 0.");
            }

            this.denominator = value;
        }
    }

    // For a complete Fraction class, there would be checks if the fractions can be written in another way,
    // for example 20 / 50 = 2 / 5, but I will omit this for simplicity
    public static Fraction operator +(Fraction first, Fraction second)
    {
        return new Fraction(first.Numerator * second.Denominator + second.Numerator * first.Denominator, first.Denominator * second.Denominator);
    }

    public static Fraction operator -(Fraction first, Fraction second)
    {
        return new Fraction(first.Numerator * second.Denominator - second.Numerator * first.Denominator, first.Denominator * second.Denominator);
    }

    public override string ToString()
    {
        return ((double)this.Numerator / this.Denominator).ToString();
    }
}

