using Decorator.Player.Contracts;

namespace Decorator.Player.Models;

public class Player : IPlayer
{
    public Player(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; }
    public string Name { get; }
}