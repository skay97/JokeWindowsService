using JokeService.WindowsService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<WindowsBackgroundService>();
    })
    .Build();

host.Run();
