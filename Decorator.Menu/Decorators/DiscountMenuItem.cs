using Decorator.Menu.Contracts;

namespace Decorator.Menu.Decorators;

public class DiscountMenuItem : IMenuItem
{
    private readonly IMenuItem _menuItem;
    private readonly double _discountPercentage;

    public DiscountMenuItem(IMenuItem menuItem, double discountPercentage)
    {
        _menuItem = menuItem;
        _discountPercentage = discountPercentage;
    }
    
    public double Price => _menuItem.Price - _menuItem.Price * _discountPercentage / 100;
    public string Name => _menuItem.Name;
    public bool IsSpecial => _menuItem.IsSpecial;
    
    public override string ToString()
    {
        var specialDisplay = IsSpecial ? "Special item : " : string.Empty;
        return $"{specialDisplay}{Name} minus discount: {Price} euros";
    }
}