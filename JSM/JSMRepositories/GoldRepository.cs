using DataLayer;
using DataLayer.Entities;

namespace JSMRepositories;

public class GoldRepository : GenericRepositories<Gold>
{
    public GoldRepository(JSMDbContext context) : base(context)
    {
    }
}