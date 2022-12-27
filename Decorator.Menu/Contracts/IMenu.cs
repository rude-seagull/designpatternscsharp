using System.Collections.Generic;

namespace Decorator.Menu.Contracts;

public interface IMenu
{
    IEnumerable<IMenuItem> Items { get; }
}