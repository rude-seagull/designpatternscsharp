using System.Collections.Generic;
using System.Linq;
using Decorator.Menu.Contracts;

namespace Decorator.Menu.Decorators;

public class DiscountMenu : IMenu
{
    private readonly double _discountPercentage;
    private readonly IMenu _menu;

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