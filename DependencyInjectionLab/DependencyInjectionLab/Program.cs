using DependencyInjectionLab.BasicComponents_3;
using DependencyInjectionLab.GameLoops_2;
using DependencyInjectionLab.GameStarter_1;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddTransient<MonsterSpawner>();
        services.AddTransient<ArenaEnvironment>();

        services.AddTransient<SurvivalGameLoop>();
        services.AddTransient<DeathmatchGameLoop>();
        services.AddTransient<NightmareGenerator>();

        services.AddTransient<GameBootstrapper>();

        var serviceProvider = services.BuildServiceProvider();

        var game = serviceProvider.GetRequiredService<GameBootstrapper>();

        game.Run();
    }
}