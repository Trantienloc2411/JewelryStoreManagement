using JSMRepositories;
using JSMServices.IServices;

namespace JSMServices.Services;

public class CounterService : ICounterService
{
    private readonly CounterRepository _counterRepository;

    public CounterService(CounterRepository counterRepository)
    {
        _counterRepository = counterRepository;
    }
    
    
}