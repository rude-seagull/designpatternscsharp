using System.Collections.Generic;
using Decorator.Menu.Contracts;
using Decorator.Menu.Decorators;

namespace Decorator.Menu.Builders;

public class MenuBuilder
{
    private readonly IEnumerable<IMenuItem> _menuItems;
    private double _discountPercentage;
    private bool _withDiscounts;

    public MenuBuilder(IEnumerable<IMenuItem> menuItems)
    {
        _menuItems = menuItems;
    }

    public MenuBuilder WithDiscount(double discountPercentage)
    {
        _withDiscounts = true;
        _discountPercentage = discountPercentage;
        return this;
    }

    public IMenu Build()
    {
        IMenu menu = new Models.Menu(_menuItems);

        if (_withDiscounts)
        {
            menu = new DiscountMenu(menu, _discountPercentage);
        }

        return menu;
    }
}