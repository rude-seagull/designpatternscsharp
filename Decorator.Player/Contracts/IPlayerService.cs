namespace Decorator.Player.Contracts;

public interface IPlayerService
{
    IEnumerable<IPlayer> GetPlayers();
}