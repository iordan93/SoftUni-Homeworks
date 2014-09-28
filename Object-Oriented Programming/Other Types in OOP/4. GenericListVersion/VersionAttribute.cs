using System;

[AttributeUsage(
        AttributeTargets.Struct |
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Method |
        AttributeTargets.Enum)]

public class VersionAttribute : System.Attribute
{
    public VersionAttribute(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }

    public int Major { get; private set; }

    public int Minor { get; private set; }

    // Method to return the current version
    public override string ToString()
    {
        return this.Major + "." + this.Minor;
    }
}