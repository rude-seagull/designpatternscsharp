using System;
using System.Collections.Generic;
using Decorator.Player.Contracts;
using Microsoft.Extensions.Caching.Memory;

namespace Decorator.Player.Decorators;

public class PlayerServiceCachingDecorator : IPlayerService
{
    private const string GetPlayersCacheKey = "players";
    private readonly IMemoryCache _memoryCache;
    private readonly IPlayerService _playerService;

    public PlayerServiceCachingDecorator(
        IPlayerService playerService,
        IMemoryCache memoryCache)
    {
        _playerService = playerService;
        _memoryCache = memoryCache;
    }

    public IEnumerable<IPlayer> GetPlayers()
    {
        if (!_memoryCache.TryGetValue(GetPlayersCacheKey, out IEnumerable<IPlayer> players))
        {
            players = _playerService.GetPlayers();

            _memoryCache.Set(
                GetPlayersCacheKey,
                new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(value: 1)));
        }

        return players;
    }
}