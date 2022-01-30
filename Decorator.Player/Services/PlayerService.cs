using Decorator.Player.Contracts;

namespace Decorator.Player.Services;

public class PlayerService : IPlayerService
{
    public IEnumerable<IPlayer> GetPlayers()
    {
        return new List<IPlayer>
        {
            new Models.Player(id: 1, name: "Monkey D. Luffy"),
            new Models.Player(id: 2, name: "Roronoa Zoro"),
            new Models.Player(id: 3, name: "Nami"),
            new Models.Player(id: 4, name: "Usopp"),
            new Models.Player(id: 5, name: "Sanji")
        };
    }
}