using System;
using Decorator.Menu.Builders;
using Decorator.Menu.Decorators;
using Decorator.Menu.Models;

var menuItems = new[]
{
    new MenuItem("Pizza", price: 10, isSpecial: false),
    new MenuItem("Pasta", price: 15, isSpecial: false)
};

// Initial Menu
var menu = new Menu(menuItems);
foreach (var item in menu.Items)
{
    Console.WriteLine(item);
}

// Initial menu wrapped (decorated) by our DiscountMenu
var discountedMenu = new DiscountMenu(menu, discountPercentage: 10);
foreach (var item in discountedMenu.Items)
{
    Console.WriteLine(item);
}

// Combine decorators with a builder pattern to control the order in which the decorators are applied
var builtMenu = new MenuBuilder(menuItems)
    .WithDiscount(20)
    .Build();

foreach (var item in builtMenu.Items)
{
    Console.WriteLine(item);
}