using System;
public static class HTMLDispatcher
{
    public static string CreateImage(string source, string alt, string title) 
    {
        ElementBuilder image = new ElementBuilder("img", true);
        image.AddAttribute("src", source);
        image.AddAttribute("alt", alt);
        image.AddAttribute("title", title);
        
        return image.ToString();
    }

    public static string CreateURL(string url, string title, string text)
    {
        ElementBuilder anchor = new ElementBuilder("a");
        anchor.AddAttribute("href", url);
        anchor.AddAttribute("title", title);
        anchor.AddContent(text);

        return anchor.ToString();
    }

    public static string CreateInput(string type, string name, string value)
    {
        ElementBuilder input = new ElementBuilder("input", true);
        input.AddAttribute("type", type);
        input.AddAttribute("name", name);
        input.AddAttribute("value", value);

        return input.ToString();
    }
}
