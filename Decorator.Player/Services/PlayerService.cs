﻿using System.Collections.Generic;
using Decorator.Player.Contracts;

namespace Decorator.Player.Services;

public class PlayerService : IPlayerService
{
    public IEnumerable<IPlayer> GetPlayers()
    {
        return new List<IPlayer>
        {
            new Models.Player(id: 1, "Monkey D. Luffy"),
            new Models.Player(id: 2, "Roronoa Zoro"),
            new Models.Player(id: 3, "Nami"),
            new Models.Player(id: 4, "Usopp"),
            new Models.Player(id: 5, "Sanji")
        };
    }
}