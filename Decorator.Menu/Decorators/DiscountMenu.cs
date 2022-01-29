using Decorator.Menu.Contracts;

namespace Decorator.Menu.Decorators;

public class DiscountMenu : IMenu
{
    private readonly IMenu _menu;
    private readonly double _discountPercentage;

    public DiscountMenu(IMenu menu, double discountPercentage)
    {
        _menu = menu;
        _discountPercentage = discountPercentage;
    }

    public IEnumerable<IMenuItem> Items => _menu.Items.Select(ToDiscountMenuItems);
    
    private IMenuItem ToDiscountMenuItems(IMenuItem menuItem)
    {
        return new DiscountMenuItem(menuItem, _discountPercentage);
    }
}