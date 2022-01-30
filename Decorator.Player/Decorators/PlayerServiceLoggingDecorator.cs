using Decorator.Player.Contracts;
using Microsoft.Extensions.Logging;

namespace Decorator.Player.Decorators;

public class PlayerServiceLoggingDecorator : IPlayerService
{
    private readonly ILogger<PlayerServiceLoggingDecorator> _logger;
    private readonly IPlayerService _playerService;

    public PlayerServiceLoggingDecorator(
        IPlayerService playerService, 
        ILogger<PlayerServiceLoggingDecorator> logger)
    {
        _playerService = playerService;
        _logger = logger;
    }

    public IEnumerable<IPlayer> GetPlayers()
    {
        _logger.LogInformation("Retrieving players");
        var players = _playerService.GetPlayers();
        _logger.LogInformation("Done retrieving players");
        return players;
    }
}