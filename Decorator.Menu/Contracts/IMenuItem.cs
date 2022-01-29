namespace Decorator.Menu.Contracts;

public interface IMenuItem
{
    string Name { get; }
    double Price { get; }
    bool IsSpecial { get; }
}