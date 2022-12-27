using System.Collections.Generic;
using Decorator.Menu.Contracts;

namespace Decorator.Menu.Models;

public class Menu : IMenu
{
    public Menu(IEnumerable<IMenuItem> menuItems)
    {
        Items = menuItems;
    }

    public IEnumerable<IMenuItem> Items { get; }
}