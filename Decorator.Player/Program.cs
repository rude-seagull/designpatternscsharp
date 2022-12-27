using System;
using Decorator.Player;
using Decorator.Player.Contracts;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
DependencyInjection.ConfigureServices(services);
var serviceProvider = services.BuildServiceProvider();
var playerService = serviceProvider.GetRequiredService<IPlayerService>();
var players = playerService.GetPlayers();
foreach (var player in players)
{
    Console.WriteLine($"{player.Id} : {player.Name}");
}