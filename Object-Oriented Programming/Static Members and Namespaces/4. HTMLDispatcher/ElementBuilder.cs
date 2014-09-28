using System;
using System.Collections.Generic;
using System.Text;

public class ElementBuilder
{
    private string name;

    public ElementBuilder(string name, bool isSelfClosing = false)
    {
        this.Name = name;
        this.IsSelfClosing = isSelfClosing;
        this.Attributes = new Dictionary<string, string>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The element name must not be empty.");
            }

            this.name = value;
        }
    }

    public string Content { get; private set; }

    public bool IsSelfClosing { get; private set; }

    public Dictionary<string, string> Attributes { get; private set; }

    public void AddAttribute(string name, string value)
    {
        this.Attributes.Add(name, value);
    }

    public void AddContent(string content)
    {
        this.Content = content;
    }

    public override string ToString()
    {
        StringBuilder element = new StringBuilder();
        element.Append("<" + this.Name);
        if (this.Attributes != null && this.Attributes.Count > 0)
        {
            foreach (var attribute in this.Attributes)
            {
                element.Append(" " + attribute.Key + "=\"" + attribute.Value + "\"");
            }
        }
        element.Append(this.IsSelfClosing ? " />" : ">");
        if (!this.IsSelfClosing)
        {
            element.Append(this.Content ?? "");
            element.Append("</" + this.Name + ">");
        }

        return element.ToString();
    }

    public static string operator *(ElementBuilder element, int multiplier)
    {
        StringBuilder elements = new StringBuilder();
        for (int i = 0; i < multiplier; i++)
        {
            elements.Append(element.ToString());
        }

        return elements.ToString();
    }
}