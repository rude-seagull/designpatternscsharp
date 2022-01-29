using Decorator.Menu.Contracts;

namespace Decorator.Menu.Models;

public class MenuItem : IMenuItem
{
    public MenuItem(string name, double price, bool isSpecial)
    {
        Name = name;
        Price = price;
        IsSpecial = isSpecial;
    }

    public string Name { get; }
    public double Price { get; }
    public bool IsSpecial { get; }

    public override string ToString()
    {
        var specialDisplay = IsSpecial ? "Special item : " : string.Empty;
        return $"{specialDisplay}{Name} : {Price} euros";
    }
}