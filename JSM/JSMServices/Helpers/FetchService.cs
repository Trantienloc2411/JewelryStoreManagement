using JSMServices.IServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace JSMServices.Helpers;

public class FetchService : BackgroundService
{
    private readonly IServiceScopeFactory _hostedService;
    private readonly ILogger<FetchService> _logger;

    public FetchService(IServiceScopeFactory hostedService, ILogger<FetchService> logger)
    {
        _hostedService = hostedService;
        _logger = logger;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using (var scope = _hostedService.CreateScope())
            {
                Console.WriteLine("Start Logging");
                _logger.LogInformation("Starting to fetch gold price data");
                var typePriceService = scope.ServiceProvider.GetRequiredService<ITypePriceService>();
                await typePriceService.fetchDataType();
            }
            _logger.LogInformation("Finished fetching gold price data");
            Console.WriteLine("Finish fetching");

            await Task.Delay(TimeSpan.FromHours(6), stoppingToken);
        }
    }
}