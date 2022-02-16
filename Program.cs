using WorkerService.DeployTest;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging(loggerFactory => loggerFactory.AddEventLog())
    
    // To call UseWindowsService(), the following package must be installed in your project:
    // <<<<<<<<<<<<<<<<<< Microsoft.Extensions.Hosting.WindowsServices >>>>>>>>>>>>>>>>>>>>
    .UseWindowsService()
    // According to the code documentation, UseWindowsService() does the following:
    // 1. Sets the host lifetime to WindowsServiceLifetime
    // 2. Sets the Content Root
    // 3. Enables logging to the event log with the application name as the default source name

    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
