using System;
using System.IO;
using Decorator.Player.Contracts;
using Decorator.Player.Decorators;
using Decorator.Player.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Decorator.Player;

internal static class DependencyInjection
{
    internal static void ConfigureServices(IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddLogging(
            builder =>
            {
                builder.ClearProviders();
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Information);
            });

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        services.AddScoped<IPlayerService, PlayerService>();

        if (Convert.ToBoolean(configuration["EnableCaching"]))
        {
            services.Decorate<IPlayerService, PlayerServiceCachingDecorator>();
        }

        if (Convert.ToBoolean(configuration["EnableLogging"]))
        {
            services.Decorate<IPlayerService, PlayerServiceLoggingDecorator>();
        }
    }
}