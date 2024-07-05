using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class CounterRepository : GenericRepositories<Counter>
{
    public CounterRepository(JSMDbContext context) : base(context) { }

}