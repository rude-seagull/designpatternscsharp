using System.Collections.Generic;

namespace Decorator.Player.Contracts;

public interface IPlayerService
{
    IEnumerable<IPlayer> GetPlayers();
}