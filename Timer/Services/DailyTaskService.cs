namespace WebApplication1.Services;

public class DailyTaskService : IHostedService, IDisposable
{
    private Timer _timer;
    private readonly ICarsService _carsService;
    public DailyTaskService(ICarsService carsService)
    {
        _carsService = carsService;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
        return Task.CompletedTask;
    }

    private void DoWork(object state)
    {
        _carsService.GetCarNames();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}